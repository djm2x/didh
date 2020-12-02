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
                    TitleAr = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DescriptionAr = table.Column<string>(nullable: true),
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
                    Abr = table.Column<string>(nullable: true),
                    AbrAr = table.Column<string>(nullable: true),
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
                    Theme = table.Column<int>(nullable: false),
                    SousTheme = table.Column<int>(nullable: false),
                    Reporter = table.Column<string>(nullable: true),
                    ReporterAr = table.Column<string>(nullable: true),
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
                    LienUpload = table.Column<string>(nullable: true),
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
                    { 1, "Développement démocratique et primauté du Droit", "البناء الديموقراطي و سيادة القانون", "la promotion, le développement démocratique et la primauté du droit", "تعزيز البناء الديمقراطي وسيادة القانون" },
                    { 2, "Interaction avec SNU des DH", "التعاون مع المنظومة الأممية", "l’interaction avec le système onusien des droits de l'homme", "مواصلة الانخراط والتعاون مع المنظومة الأممية لحقوق الإنسان" },
                    { 3, "Harmonisation Juridique", "الملائمة", "la promotion et la protection des droits de l'homme, à travers la législation et l’harmonisation avec les normes internationales, constitué d’un sous-thème se rapportant à la législation", "النهوض بحقوق الإنسان وحمايتها عبر التشريع والملاءمة مع المعايير الدولية" },
                    { 4, "DESC", "الحقوق الاقتصادية و الاجتماعية و الثقافية و البيئية", "la promotion des droits économiques, sociaux, culturels et environnementaux", "النهوض بالحقوق الاقتصادية والاجتماعية والثقافية والبيئية" },
                    { 5, "Droits civils et Politiques", "الحقوق المدنية و السياسية", "la protection et la promotion des droits civils et politiques", "حماية الحقوق المدنية والسياسية والنهوض بها" },
                    { 6, "Droits Catégoriels ", "الحقوق الفئوية", "la promotion et la protection des droits catégoriels", "النهوض بالحقوق الفئوية وحمايتها" },
                    { 7, "Education et culture des DH", "النهوض بثقافة حقوق الانسان", "la promotion de la culture des droits de l'homme par l'éducation et la formation", "النهوض بثقافة حقوق الإنسان من خلال التربية والتكوين" },
                    { 8, "Cadre institutionnel des DH", "الاطار المؤسساتي", "la promotion du cadre institutionnel pour la protection et la promotion des droits de l'homme", "الإطار المؤسساتي لحماية حقوق الإنسان والنهوض بها" },
                    { 9, "Recommandations d'ordre général", "توصيات عامة", "des recommandations d'ordre général", "التوصيات العامة" }
                });

            migrationBuilder.InsertData(
                table: "Cycles",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[] { 1, "3ème cycle (2017-2022)", "الجولة الثالثة من آلية الاستعراض الدوري الشامل  )شتنبر 2017)" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[,]
                {
                    { 10, "الفئة 1", new DateTime(2020, 2, 13, 20, 3, 56, 448, DateTimeKind.Local).AddTicks(8696), "Maiores et quia consequatur sed voluptatem aut quia hic. Dolorem et mollitia nihil illum voluptas nemo quaerat rerum provident. Aut modi aut alias libero fuga voluptas. Quasi ipsa provident facere porro. Est recusandae sint qui in amet et perspiciatis in voluptas. Voluptatem cumque molestiae quod ut eum et ad. Aut ad veritatis consequatur provident. Dolore sint debitis a quidem eveniet aut provident. Eum iure provident. Nisi accusantium natus dolorem repellendus aliquid aliquid. Laboriosam sint provident numquam aut voluptatum autem aut ducimus accusamus. Adipisci possimus earum. Nam odio eligendi facere iusto dolorem laboriosam.", "المحتوى ولذلك بشكل عشوائي هذا. النص المعيار مايكر الصفحة قرون. حوت نسخ لم وبشكله الطباعة. طريقة برص لتكوّن زمن قرون هذا توضع مرجع. رقائق التي نسخ. ليتراسيت مرجع التي حقيقة الإلكتروني أن برامج طبيعياَ رقائق لينتشر. نص نص ولايزال. مثل ولذلك أخذتها ولذلك لينتشر. استخدام التركيز طريقة بشكل والتنضيد التركيز تقضي أن. عن مطبعة طريقة الصفحة.", "mollitia", "الصفحة" },
                    { 9, "الفئة 1", new DateTime(2020, 10, 31, 6, 33, 24, 260, DateTimeKind.Local).AddTicks(2951), "Architecto suscipit aliquam. Quibusdam asperiores modi sed et impedit. Hic expedita rerum reprehenderit veniam. A ex excepturi quos consequatur similique quasi similique. Quia sed dolores odio rerum. Possimus asperiores qui rerum explicabo. Voluptatum deleniti aut eius. Rerum animi autem tenetur quaerat perspiciatis mollitia vel in. Asperiores laborum et assumenda amet accusamus provident. Sit quasi nihil qui et consectetur nam consequuntur. Amet deleniti deleniti officiis sed enim sit non. Adipisci enim et distinctio ut et.", "مرجع نسخ الخارجي الصفحة برص يتم وهي استخدام ودور. المقروء ظهور المعيار من صناعات زمن. أخذتها وليس لينتشر النص كتيّب شكل. مايكر مؤخراَ القرن البلاستيكية دليل الطباعة زمن الأصلي الشكل. مجموعة أو الخارجي برص الشكلي والتنضيد. إصدار في مثبتة. زمن إيبسوم هو. التركيز صناعات من منذ ولايزال الأحرف نص التركيز ببساطة للنص. والتي الشكلي رقائق تحوي البلاستيكية الأحرف إصدار. إيبسوم نسخ التي صناعات صناعات كبير إصدار الخارجي الخامس. والتي يقرأها أخرى. مؤخراَ صار خمسة مستخدماً. التي في عندما مستخدماً سيلهي.", "aut", "بشكل" },
                    { 8, "الفئة 1", new DateTime(2020, 5, 20, 6, 0, 1, 438, DateTimeKind.Local).AddTicks(8142), "Et non provident corporis qui. Velit tenetur amet itaque explicabo quia laboriosam minus. Architecto nemo nostrum atque nisi eum nostrum assumenda rerum. Laborum ut aut id aperiam blanditiis consequuntur excepturi est. Optio ea nihil quia quia sapiente facilis deleniti recusandae. Similique et laudantium ad consequatur architecto sint quidem. Accusamus non neque est quos fugit quia modi ut sequi. Ut eligendi error officiis dicta tempore. Dicta commodi vel id consequatur fugiat modi et perspiciatis rerum. Quibusdam sapiente ut quos in ut est provident. Non sunt quibusdam quod ullam voluptas qui est officiis.", "صناعات للنص لصفحة برص. صناعات خمسة أخذتها لم قامت ستينيّات تقضي. انتشر للنص يتم حتى ويُستخدم أخرى الخامس. التي استخدام طبيعياَ كبير لينتشر على حتى. والتنضيد أو شكلي من وبشكله أخرى. بايج القرن هو هناك قامت الشكلي أخذتها ظهور الأصلي. القرن أيضاً صناعات وبشكله منذ. سيلهي دليل وعاد القرن عشر ما بايج التي مثل. يتم توضع شكل الطباعة المطابع إيبسوم شكل لم عشر مطبعة. توضع لأنها بمثابة. برص انه الشكلي لم برامج كتيّب الخارجي. البلاستيكية الشكلي ولذلك الخارجي على.", "sed", "مستخدماً" },
                    { 7, "الفئة 1", new DateTime(2020, 9, 17, 8, 56, 12, 382, DateTimeKind.Local).AddTicks(9680), "Minus consequatur delectus qui laudantium aspernatur sit voluptatem consequatur. Iste harum culpa sequi. Voluptatum sit optio voluptatem harum voluptatibus porro. Quod vitae sit incidunt ipsam qui exercitationem illum sequi et. Eos et magni laboriosam accusantium saepe. Exercitationem consequatur nihil velit aperiam officia in rerum odio ipsam. Cupiditate occaecati necessitatibus perferendis. Modi inventore dolores accusamus cumque dolor architecto ut ea. Vitae sit inventore nisi. Tempore quaerat optio est et dolore perspiciatis ab.", "ألدوس تعطي مع مقاطع الصفحة البلاستيكية. لينتشر الصفحة مجموعة. هو عشر ويُستخدم والتي بمثابة زمن ما وبشكله لهذه لصفحة. وعاد مع مطبعة. الشكلي المحتوى البلاستيكية ظهور لوريم لهذه نص مجهولة انه. حقيقة حقيقة مجموعة. توضع الزمن تقضي خمسة مثبتة عشر. ستينيّات ولايزال شكل أيضاً القرن عشر. ليتراسيت ليتراسيت لتكوّن لوريم دليل الشكل. إيبسوم ببساطة الخامس برص مستخدماً تعطي. وعاد وعاد إصدار هو الإلكتروني نص صار الزمن أخرى عندما. ببساطة دليل مقاطع ولذلك مايكر ولذلك زمن النشر ليتراسيت. الخارجي نسخ حقيقة قرون للنص أن شكل مرجع.", "cum", "حوت" },
                    { 6, "الفئة 1", new DateTime(2019, 12, 24, 5, 2, 2, 881, DateTimeKind.Local).AddTicks(2094), "Expedita sit exercitationem veritatis eligendi sit qui autem sequi. Quos et aut delectus sunt esse. Sint officia aut eligendi et aspernatur. Blanditiis sint voluptates soluta nihil voluptatem temporibus omnis. Eos voluptates excepturi porro tempora illum inventore occaecati. Non ipsum dolor est atque autem. Consectetur sed distinctio ut aperiam sed officia et facilis id. Quam et sunt dolores. Quo omnis quo illo inventore optio aliquam. Non culpa et.", "وهي ببساطة والتنضيد مثبتة الأصلي المقروء. الخارجي وعاد هو عشوائي. الغاية تحوي وعاد وعاد تحوي دليل هي. بل شكل لينتشر عشوائي ما صار يتم. أو هذا الخارجي والتي طبيعياَ ولايزال طويل. شكل ويُستخدم مع عشوائي. ما في المقروء حوت بل مقاطع. النص توضع طريقة شكل مثبتة مرجع لوريم يقرأها. القرن استخدام هو التركيز ستينيّات مستخدماً. المطابع إصدار رقائق توضع. مستخدماً أيضاً مستخدماً مثبتة هناك بمعنى مقاطع نسخ لصفحة. أو التركيز بشكل وليس حتى صار طبيعياَ. البلاستيكية ولايزال الخارجي نسخ مؤخراَ كان انتشر هذا التي لتكوّن.", "quos", "عن" },
                    { 5, "الفئة 1", new DateTime(2020, 5, 5, 13, 38, 37, 581, DateTimeKind.Local).AddTicks(3075), "Velit ut quo vitae dolore doloremque. Dolorum omnis commodi harum perspiciatis. In laborum autem expedita adipisci sed odit odio. Minus aut libero. Ipsa asperiores voluptate debitis quasi. Exercitationem eos est sint commodi animi exercitationem eaque asperiores. Et laboriosam et repudiandae unde cum perspiciatis quis quia. Esse ad maiores sequi sed id velit. Doloribus suscipit numquam cum nostrum dolor magnam excepturi molestiae eligendi. Illo ut beatae. Laborum quam reprehenderit.", "دليل هذا ببساطة ألدوس هذا تقضي هو ودور. مرجع مقاطع المعيار أخذتها شكلي مرة. استخدام شكلي مجموعة أخرى نص أيضاً القارئ. ويُستخدم مايكر لتكوّن النشر أو. ودور ألدوس مرة الخامس مقاطع شكل المعيار لأنها. كتيّب الخامس دليل تقضي بشكل مرجع التركيز ستينيّات ببساطة. لوريم بل كتيّب أيضاً الشكل مثل. ليتراسيت مؤخراَ إصدار والتي وليس عن مثبتة. عشر يقرأها الطباعة المحتوى لم حقيقة لم تعطي منذ. تقضي ظهور عشوائي والتنضيد تعطي قامت ودور الأحرف ألدوس أو. طويل استخدام ستينيّات والتنضيد إيبسوم. وبشكله لهذه المحتوى عندما دليل. مؤخراَ هي النص لتكوّن بل ليتراسيت برامج.", "provident", "نص" },
                    { 4, "الفئة 1", new DateTime(2020, 2, 8, 16, 37, 50, 372, DateTimeKind.Local).AddTicks(9982), "Voluptatum adipisci consequatur rerum. Totam qui tempore cupiditate tempora. Illo soluta reprehenderit consequuntur eveniet. Est qui tempora aperiam suscipit. Eum ut maxime numquam. Doloribus ea cupiditate nostrum ex. Reiciendis ut saepe nobis vel voluptatum similique rerum eum eum. Autem rerum id qui iste ullam. Quam vitae aspernatur. Aut dolorum exercitationem culpa. Magni nobis sed nihil vitae.", "الخامس لوريم مع الخامس المحتوى أخرى. وبشكله طويل توضع لأنها وليس انه. تقضي المحتوى حتى الخارجي مجهولة توضع ما توضع مجهولة. طويل الخامس على استخدام بايج ظهور. ظهور استخدام عشوائي كان انتشر مايكر. بشكل لم ألدوس وعاد منذ والتي عشوائي انه حقيقة. قامت إيبسوم القرن منذ لم. مع لتكوّن والتي المعيار تقضي شكل الخامس على طويل. حتى من ودور ودور. شكل مرجع ظهور كبير القارئ المعيار الشكلي ظهور. الغاية عشوائي هذا ولايزال ألدوس مثل النص. قامت النشر أيضاً ما.", "consequatur", "مثل" },
                    { 3, "الفئة 1", new DateTime(2020, 4, 9, 20, 56, 10, 588, DateTimeKind.Local).AddTicks(8731), "Rerum excepturi delectus vero dolor error et deserunt beatae dolores. Eaque doloremque iusto. Minus ipsum et nihil omnis neque delectus quibusdam eius ut. Earum quam tenetur inventore enim. Ratione nulla sit quis et nemo tempore et. Dolores sint ut. Quia quia dignissimos veritatis ratione quia aut asperiores nisi. Reiciendis quo maxime deserunt accusamus fuga corrupti quidem voluptatem. Ipsam saepe sit aut distinctio et et incidunt praesentium. Doloremque quae non iusto inventore amet et. Consequatur pariatur quaerat optio et. Aliquid sunt sed. Et et non dolores saepe ea laudantium ipsam.", "برص كتيّب مثبتة والتنضيد وهي مثبتة. المعيار بشكل والتنضيد برامج في صناعات لصفحة ولايزال ليتراسيت تحوي. ودور أيضاً الشكل. ودور تقضي سيلهي إيبسوم والتنضيد ودور في لأنها. عندما النشر طريقة والتنضيد وبشكله حتى كان طبيعياَ. لم لهذه وهي المعيار ويُستخدم. خمسة مؤخراَ مايكر طويل سيلهي الخامس. رقائق بشكل الطباعة للنص كتيّب برامج طويل عندما مثبتة. لتكوّن زمن على. كان من مؤخراَ في النص وليس توضع أخذتها ألدوس يتم. بشكل بمثابة البلاستيكية التركيز تقضي عشوائي في الأصلي هذا ستينيّات.", "optio", "يتم" },
                    { 2, "الفئة 1", new DateTime(2020, 1, 2, 12, 6, 7, 968, DateTimeKind.Local).AddTicks(699), "Aperiam laudantium soluta eum animi amet hic molestias. Beatae ea sunt fuga. Quidem nobis nobis deleniti qui in. Tempore et cum recusandae voluptate quia non id et. Assumenda sit voluptatum occaecati aut aut eligendi. Facere in hic et voluptatibus magni ducimus in. Fuga dolorem cumque dolores accusamus. Quo ea nam consequatur saepe consectetur et id. Excepturi dolores officia iste ratione sapiente facere qui asperiores. Fugiat quia voluptates ipsum illum perspiciatis atque consequatur quibusdam.", "الشكل الفقرات أو وعاد النشر القرن وليس طويل الأصلي برامج. المعيار توزيعاَ صار الإلكتروني توضع قامت دليل التركيز. ألدوس مايكر نص بل. للنص سيلهي النص الزمن المعيار مجهولة ودور عن رقائق قرون. المعيار وبشكله طويل والتنضيد حتى للنص قامت ودور. والتي المعيار أخذتها لوريم رقائق نسخ على. مؤخراَ منذ دليل التركيز الفقرات بايج لأنها أو. لهذه لتكوّن لم الأصلي عشوائي خمسة هي القارئ. أيضاً كبير لتكوّن نسخ وبشكله بل شكل طريقة. لوريم الأصلي النص المقروء. ما على المعيار لهذه نص لصفحة. طويل لصفحة كان القارئ وهي. مايكر طبيعياَ قرون زمن قامت ودور الخارجي إيبسوم الخارجي مرجع.", "blanditiis", "إصدار" },
                    { 1, "الفئة 1", new DateTime(2019, 12, 11, 18, 10, 56, 467, DateTimeKind.Local).AddTicks(2908), "Eius numquam accusamus vel expedita ut modi cum. Ad doloribus quis cum corrupti ut eum eum quam et. Quia et excepturi expedita veritatis dignissimos aliquam itaque aut dolor. Ex iusto voluptas exercitationem nihil ipsum. In optio numquam modi dolorem ea voluptas. Est porro ut eius sunt consequatur veritatis. Dolorum enim cumque non placeat numquam porro. Error quisquam rerum quidem itaque. Adipisci deleniti expedita pariatur voluptatem et omnis ut vitae aut. Omnis quo sed qui necessitatibus dicta in exercitationem rerum qui. Quisquam a dolor amet reiciendis non expedita aut sint magni. Eligendi cupiditate veritatis error labore temporibus quaerat.", "رقائق عشوائي الشكلي مرجع. توضع مؤخراَ وعاد بشكل. شكلي حقيقة منذ نسخ مثل. ما لصفحة سيلهي. تعطي رقائق هناك تعطي. إيبسوم لتكوّن أخذتها القارئ. نص ويُستخدم لم نسخ صناعات وعاد مع وهي طويل. تعطي بل منذ. الطباعة يقرأها بشكل الأحرف التركيز كان طريقة تقضي يقرأها. قامت لوريم كبير القرن عشر ولايزال. كتيّب مثبتة الطباعة الأحرف ولذلك كتيّب النص. أن صار هو ببساطة وهي مطبعة وبشكله مرجع.", "natus", "حقيقة" }
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
                columns: new[] { "Id", "Abr", "AbrAr", "Adresse", "Label", "LabelAr", "Tel", "Type" },
                values: new object[,]
                {
                    { 28, "", "", "", "Justice", "العدل", "", "PE" },
                    { 29, "", "", "", "Marocains Résidant à l’Etranger", "المغاربة المقيمون بالخارج", "", "PE" },
                    { 30, "", "", "", "Médiateur", "الوسيط", "", "IN" },
                    { 31, "", "", "", "Observatoire National des Droits de l’Enfant", "المرصد الوطني لحقوق الطفل", "", "Autre" },
                    { 32, "", "", "", "Parlement", "البرلمان", "", "Autre" },
                    { 33, "", "", "", "Santé", "الصحة", "", "PE" },
                    { 34, "", "", "", "Tourisme", "السياحة", "", "PE" },
                    { 35, "", "", "", "Transport", "النقل", "", "PE" },
                    { 36, "", "", "", "IRCAM", "المعهد الملكي للثقافة الأمازيغية", "", "IN" },
                    { 38, "", "", "", "Relations avec parlement", "العلاقات مع البرلمان", "", "PE" },
                    { 39, "", "", "", "Agriculture", "الفلاحة", "", "PE" },
                    { 40, "", "", "", "Education nationale", "التربية الوطنية", "", "PE" },
                    { 43, "", "", "", "ANELCA", "الوكالة الوطنية لمحاربة الأمية", "", "" },
                    { 44, "", "", "", "Conseil Supérieur de l’Education, de la Formation et de la Recherche Scientifique", "المجلس الأعلى للتربية والتكوين والبحث العلمي", "", "IN" },
                    { 45, "", "", "", "Conseil Economique Social et Environnemental", "المجلس الاقتصادي والاجتماعي والبيئي", "", "IN" },
                    { 46, "", "", "", "Environnement", "البيئة", "", "PE" },
                    { 47, "", "", "", "Pêche maritime", "الصيد البحري", "", "PE" },
                    { 48, "", "", "", "Conseil de la communauté marocaine à l’étranger", "مجلس الجالية المغربية بالخارج", "", "IN" },
                    { 49, "", "", "", "ONGs", "المنظمات غير الحكومية", "", "" },
                    { 50, "", "", "", "Partis Politiques", "أحزاب سياسية", "", "" },
                    { 51, "", "", "", "Affaires générales du gouvernement", "شؤون الحكومة العامة", "", "" },
                    { 52, "", "", "", "Rabita Mohammedia des Oulémas", "الرابطة المحمدية للعلماء", "", "" },
                    { 53, "", "", "", "Eaux et Forets", "المياه والغابات", "", "PE" },
                    { 41, "", "", "", "Formation professionnelle", "التكوين المهني", "", "PE" },
                    { 27, "", "", "", "Jeunesse et Sports", "الشباب والرياضة", "", "PE" },
                    { 42, "", "", "", "Enseignement supérieur", "التعليم العالي", "", "PE" },
                    { 25, "", "", "", "HACA", "الهيأة العليا للاتصال السمعي البصري", "", "PE" },
                    { 1, "", "", "", "HCP", "المندوبية السامية للتخطيط", "", "IN" },
                    { 2, "", "", "", "INPPLC", "الهيئة الوطنية للنزاهة و الوقاية من الرشوة و محاربتها", "", "IN" },
                    { 3, "", "", "", "Affaires Etrangères", "الشؤون الخارجية", "", "PE" },
                    { 4, "", "", "", "CNDH", "المجلس الوطني لحقوق الإنسان", "", "IN" },
                    { 5, "", "", "", "Communication", "الاتصال", "", "PE" },
                    { 6, "", "", "", "Présidence du Ministère Public", "رئاسة النيابة العامة", "", "PJ" },
                    { 7, "", "", "", "Chef du Gouvernement", "رئاسة الحكومة", "", "PE" },
                    { 8, "", "", "", "Commerce et Industrie", "التجارة والصناعة", "", "PE" },
                    { 9, "", "", "", "Conseil Supérieur de l’Autorité Judiciaire", "المجلس الأعلى للسلطة القضائية", "", "PJ" },
                    { 11, "", "", "", "Défense Nationale", "الدفاع الوطني", "", "PE" },
                    { 26, "", "", "", "Intérieur", "الداخلية", "", "PE" },
                    { 12, "", "", "", "Développement Social et Solidarité", "التنمية الاجتماعية والتضامن", "", "PE" },
                    { 10, "", "", "", "Culture", "الثقافة", "", "PE" },
                    { 14, "", "", "", "DGSN", "الأمن الوطني", "", "PE" },
                    { 24, "", "", "", "Habous et des Affaires Islamiques", "الأوقاف والشؤون الإسلامية", "", "PE" },
                    { 23, "", "", "", "Habitat", "السكنى", "", "PE" },
                    { 13, "", "", "", "DGAPR", "إدارة السجون", "", "PE" },
                    { 21, "", "", "", "Fonction Publique", "الوظيفة العمومية", "", "PE" },
                    { 20, "", "", "", "Equipement", "التجهيز", "", "PE" },
                    { 22, "", "", "", "Gendarmerie Royale", "الدرك الملكي", "", "PE" },
                    { 18, "", "", "", "Emploi", "الشغل", "", "PE" },
                    { 17, "", "", "", "Economie et Finances", "الاقتصاد والمالية", "", "PE" },
                    { 16, "", "", "", "Eau", "الماء", "", "PE" },
                    { 15, "", "", "", "Droits de l’Homme", "حقوق الإنسان", "", "PE" },
                    { 19, "", "", "", "Energie et Mines", "الطاقة والمعادن", "", "PE" }
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
                    { 65, "Norvège", "النرويج" },
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
                    { 64, "Niger", "النيجر" },
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
                    { 51, "Kenya", "كينيا" },
                    { 43, "Haïti", "هايتي" },
                    { 37, "Gabon", "الغابون" },
                    { 38, "Géorgie", "جورجيا" },
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
                columns: new[] { "Id", "Annee", "PieceJointe", "Reporter", "ReporterAr", "SousTheme", "Theme" },
                values: new object[,]
                {
                    { 10, 2020, "", "Reporter 11", "11 مقرر", 1, 1 },
                    { 15, 2020, "", "Reporter 16", "16 مقرر", 3, 2 },
                    { 14, 2020, "", "Reporter 15", "15 مقرر", 1, 1 },
                    { 13, 2020, "", "Reporter 14", "14 مقرر", 3, 2 },
                    { 12, 2020, "", "Reporter 13", "13 مقرر", 1, 1 },
                    { 11, 2020, "", "Reporter 12", "12 مقرر", 3, 2 },
                    { 9, 2020, "", "Reporter 10", "10 مقرر", 4, 2 },
                    { 6, 2020, "", "Reporter 7", "7 مقرر", 2, 1 },
                    { 7, 2020, "", "Reporter 8", "8 مقرر", 4, 2 },
                    { 8, 2020, "", "Reporter 9", "9 مقرر", 2, 1 },
                    { 5, 2020, "", "Reporter 6", "6 مقرر", 4, 2 },
                    { 4, 2020, "", "Reporter 5", "5 مقرر", 1, 1 },
                    { 3, 2020, "", "Reporter 4", "4 مقرر", 4, 2 },
                    { 2, 2020, "", "Reporter 3", "3 مقرر", 1, 1 },
                    { 1, 2020, "", "Reporter 2", "2 مقرر", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[,]
                {
                    { 67, "", "", new DateTime(2019, 12, 14, 4, 35, 9, 216, DateTimeKind.Local).AddTicks(1897), new DateTime(2019, 12, 12, 15, 40, 42, 939, DateTimeKind.Local).AddTicks(5782), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 68, "", "", new DateTime(2020, 1, 2, 12, 44, 43, 100, DateTimeKind.Local).AddTicks(5336), new DateTime(2020, 2, 4, 1, 9, 3, 501, DateTimeKind.Local).AddTicks(828), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 69, "", "", new DateTime(2020, 3, 9, 22, 2, 6, 879, DateTimeKind.Local).AddTicks(7625), new DateTime(2020, 2, 10, 7, 19, 20, 59, DateTimeKind.Local).AddTicks(8918), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 70, "", "", new DateTime(2020, 11, 16, 2, 1, 3, 969, DateTimeKind.Local).AddTicks(9406), new DateTime(2020, 10, 28, 21, 7, 53, 253, DateTimeKind.Local).AddTicks(5174), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 73, "", "", new DateTime(2020, 10, 31, 22, 20, 26, 738, DateTimeKind.Local).AddTicks(599), new DateTime(2020, 5, 10, 2, 21, 30, 326, DateTimeKind.Local).AddTicks(2827), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 72, "", "", new DateTime(2020, 8, 13, 1, 26, 27, 59, DateTimeKind.Local).AddTicks(211), new DateTime(2020, 4, 13, 19, 6, 34, 87, DateTimeKind.Local).AddTicks(9321), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 66, "", "", new DateTime(2020, 8, 1, 17, 52, 1, 351, DateTimeKind.Local).AddTicks(6839), new DateTime(2020, 3, 30, 7, 37, 49, 79, DateTimeKind.Local).AddTicks(2969), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 74, "", "", new DateTime(2020, 6, 6, 4, 27, 39, 795, DateTimeKind.Local).AddTicks(7922), new DateTime(2020, 3, 7, 3, 42, 13, 562, DateTimeKind.Local).AddTicks(2182), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 71, "", "", new DateTime(2020, 10, 28, 11, 59, 12, 604, DateTimeKind.Local).AddTicks(5476), new DateTime(2020, 5, 23, 2, 56, 17, 265, DateTimeKind.Local).AddTicks(697), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 65, "", "", new DateTime(2020, 2, 27, 6, 47, 12, 968, DateTimeKind.Local).AddTicks(1402), new DateTime(2020, 2, 5, 9, 57, 42, 980, DateTimeKind.Local).AddTicks(6613), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 62, "", "", new DateTime(2020, 9, 20, 7, 51, 4, 400, DateTimeKind.Local).AddTicks(5007), new DateTime(2020, 10, 2, 9, 56, 39, 381, DateTimeKind.Local).AddTicks(4815), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 63, "", "", new DateTime(2020, 3, 19, 9, 48, 4, 668, DateTimeKind.Local).AddTicks(2420), new DateTime(2020, 7, 8, 2, 12, 34, 194, DateTimeKind.Local).AddTicks(217), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 75, "", "", new DateTime(2020, 10, 4, 5, 46, 15, 920, DateTimeKind.Local).AddTicks(3672), new DateTime(2020, 9, 20, 17, 41, 28, 443, DateTimeKind.Local).AddTicks(5323), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 61, "", "", new DateTime(2020, 5, 15, 3, 52, 48, 335, DateTimeKind.Local).AddTicks(2059), new DateTime(2020, 9, 12, 7, 24, 20, 138, DateTimeKind.Local).AddTicks(9121), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 60, "", "", new DateTime(2020, 8, 24, 14, 34, 9, 157, DateTimeKind.Local).AddTicks(3182), new DateTime(2020, 11, 23, 13, 1, 28, 123, DateTimeKind.Local).AddTicks(8303), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 59, "", "", new DateTime(2020, 4, 9, 12, 19, 0, 791, DateTimeKind.Local).AddTicks(3544), new DateTime(2020, 12, 1, 23, 13, 38, 93, DateTimeKind.Local).AddTicks(2779), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 58, "", "", new DateTime(2020, 4, 13, 9, 28, 40, 697, DateTimeKind.Local).AddTicks(9181), new DateTime(2020, 6, 24, 13, 31, 9, 875, DateTimeKind.Local).AddTicks(148), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 57, "", "", new DateTime(2020, 7, 25, 18, 19, 16, 210, DateTimeKind.Local).AddTicks(6683), new DateTime(2020, 7, 8, 14, 26, 19, 153, DateTimeKind.Local).AddTicks(5438), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 56, "", "", new DateTime(2020, 4, 30, 7, 20, 15, 799, DateTimeKind.Local).AddTicks(9699), new DateTime(2020, 1, 29, 7, 24, 45, 723, DateTimeKind.Local).AddTicks(7538), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 55, "", "", new DateTime(2020, 10, 1, 9, 37, 18, 107, DateTimeKind.Local).AddTicks(6562), new DateTime(2020, 3, 7, 15, 44, 14, 709, DateTimeKind.Local).AddTicks(9537), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 54, "", "", new DateTime(2020, 1, 20, 19, 10, 40, 771, DateTimeKind.Local).AddTicks(1583), new DateTime(2020, 3, 11, 0, 30, 30, 760, DateTimeKind.Local).AddTicks(1804), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 53, "", "", new DateTime(2020, 11, 18, 16, 46, 58, 671, DateTimeKind.Local).AddTicks(9920), new DateTime(2020, 1, 15, 22, 59, 9, 230, DateTimeKind.Local).AddTicks(7442), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 64, "", "", new DateTime(2020, 6, 21, 6, 59, 10, 655, DateTimeKind.Local).AddTicks(2128), new DateTime(2020, 8, 2, 15, 27, 14, 665, DateTimeKind.Local).AddTicks(1374), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 76, "", "", new DateTime(2019, 12, 25, 3, 34, 25, 415, DateTimeKind.Local).AddTicks(6165), new DateTime(2020, 6, 23, 22, 3, 39, 357, DateTimeKind.Local).AddTicks(8144), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 79, "", "", new DateTime(2019, 12, 16, 15, 17, 16, 72, DateTimeKind.Local).AddTicks(4841), new DateTime(2020, 7, 28, 15, 44, 46, 985, DateTimeKind.Local).AddTicks(5586), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 78, "", "", new DateTime(2020, 8, 16, 12, 57, 26, 646, DateTimeKind.Local).AddTicks(49), new DateTime(2020, 5, 16, 16, 30, 51, 180, DateTimeKind.Local).AddTicks(8639), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 52, "", "", new DateTime(2020, 4, 1, 19, 59, 48, 908, DateTimeKind.Local).AddTicks(2114), new DateTime(2020, 2, 4, 17, 16, 50, 768, DateTimeKind.Local).AddTicks(4866), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 99, "", "", new DateTime(2020, 7, 2, 22, 38, 57, 81, DateTimeKind.Local).AddTicks(9321), new DateTime(2020, 10, 31, 5, 16, 16, 606, DateTimeKind.Local).AddTicks(4692), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 98, "", "", new DateTime(2019, 12, 23, 21, 41, 35, 249, DateTimeKind.Local).AddTicks(578), new DateTime(2020, 9, 11, 9, 25, 0, 297, DateTimeKind.Local).AddTicks(7256), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 97, "", "", new DateTime(2020, 6, 24, 19, 41, 35, 857, DateTimeKind.Local).AddTicks(4037), new DateTime(2020, 1, 19, 5, 26, 7, 995, DateTimeKind.Local).AddTicks(894), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 96, "", "", new DateTime(2020, 6, 27, 16, 51, 23, 121, DateTimeKind.Local).AddTicks(6020), new DateTime(2020, 5, 29, 10, 32, 28, 351, DateTimeKind.Local).AddTicks(2032), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 95, "", "", new DateTime(2020, 1, 10, 1, 36, 8, 359, DateTimeKind.Local).AddTicks(4867), new DateTime(2020, 9, 6, 22, 54, 11, 356, DateTimeKind.Local).AddTicks(226), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 94, "", "", new DateTime(2020, 4, 18, 2, 31, 26, 2, DateTimeKind.Local).AddTicks(4443), new DateTime(2019, 12, 10, 14, 32, 33, 971, DateTimeKind.Local).AddTicks(1972), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 93, "", "", new DateTime(2020, 10, 27, 19, 23, 0, 85, DateTimeKind.Local).AddTicks(3322), new DateTime(2020, 5, 27, 10, 45, 54, 876, DateTimeKind.Local).AddTicks(7752), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 92, "", "", new DateTime(2020, 7, 31, 6, 47, 35, 953, DateTimeKind.Local).AddTicks(5180), new DateTime(2020, 7, 24, 21, 44, 24, 297, DateTimeKind.Local).AddTicks(899), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 91, "", "", new DateTime(2020, 8, 1, 23, 20, 42, 644, DateTimeKind.Local).AddTicks(1822), new DateTime(2020, 5, 15, 5, 36, 12, 189, DateTimeKind.Local).AddTicks(3828), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 77, "", "", new DateTime(2020, 11, 20, 15, 25, 34, 791, DateTimeKind.Local).AddTicks(6411), new DateTime(2019, 12, 6, 7, 2, 28, 318, DateTimeKind.Local).AddTicks(8690), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 90, "", "", new DateTime(2020, 4, 3, 8, 53, 27, 931, DateTimeKind.Local).AddTicks(3432), new DateTime(2020, 3, 23, 20, 1, 22, 737, DateTimeKind.Local).AddTicks(81), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 88, "", "", new DateTime(2020, 5, 8, 18, 34, 20, 925, DateTimeKind.Local).AddTicks(4523), new DateTime(2020, 11, 25, 7, 58, 27, 154, DateTimeKind.Local).AddTicks(9541), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 87, "", "", new DateTime(2020, 7, 23, 11, 51, 5, 989, DateTimeKind.Local).AddTicks(5238), new DateTime(2020, 5, 30, 13, 2, 22, 586, DateTimeKind.Local).AddTicks(2454), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 86, "", "", new DateTime(2020, 10, 29, 10, 44, 4, 67, DateTimeKind.Local).AddTicks(7417), new DateTime(2020, 2, 14, 20, 12, 36, 568, DateTimeKind.Local).AddTicks(3065), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 85, "", "", new DateTime(2020, 6, 8, 12, 5, 17, 240, DateTimeKind.Local).AddTicks(5447), new DateTime(2020, 4, 10, 4, 50, 37, 48, DateTimeKind.Local).AddTicks(8210), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 84, "", "", new DateTime(2020, 1, 29, 10, 2, 59, 304, DateTimeKind.Local).AddTicks(4399), new DateTime(2020, 4, 14, 18, 3, 40, 933, DateTimeKind.Local).AddTicks(9741), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 83, "", "", new DateTime(2019, 12, 8, 23, 58, 44, 305, DateTimeKind.Local).AddTicks(526), new DateTime(2020, 10, 3, 21, 48, 24, 249, DateTimeKind.Local).AddTicks(9404), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 82, "", "", new DateTime(2020, 4, 8, 18, 0, 56, 686, DateTimeKind.Local).AddTicks(9412), new DateTime(2019, 12, 31, 21, 44, 8, 712, DateTimeKind.Local).AddTicks(4382), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 81, "", "", new DateTime(2020, 5, 20, 11, 21, 51, 262, DateTimeKind.Local).AddTicks(6749), new DateTime(2020, 1, 3, 1, 4, 3, 326, DateTimeKind.Local).AddTicks(3600), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 100, "", "", new DateTime(2020, 10, 12, 4, 57, 54, 791, DateTimeKind.Local).AddTicks(3645), new DateTime(2020, 1, 12, 23, 52, 28, 57, DateTimeKind.Local).AddTicks(5692), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 80, "", "", new DateTime(2020, 10, 8, 9, 41, 46, 350, DateTimeKind.Local).AddTicks(384), new DateTime(2020, 2, 4, 9, 55, 33, 201, DateTimeKind.Local).AddTicks(3583), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 89, "", "", new DateTime(2020, 1, 6, 0, 18, 31, 218, DateTimeKind.Local).AddTicks(9278), new DateTime(2019, 12, 31, 17, 9, 54, 307, DateTimeKind.Local).AddTicks(5514), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 51, "", "", new DateTime(2020, 10, 30, 8, 22, 38, 543, DateTimeKind.Local).AddTicks(8101), new DateTime(2020, 11, 3, 12, 27, 58, 413, DateTimeKind.Local).AddTicks(6041), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 20, "", "", new DateTime(2020, 9, 14, 23, 45, 21, 243, DateTimeKind.Local).AddTicks(9907), new DateTime(2020, 5, 19, 21, 54, 56, 20, DateTimeKind.Local).AddTicks(2175), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 49, "", "", new DateTime(2020, 3, 25, 12, 32, 38, 398, DateTimeKind.Local).AddTicks(6015), new DateTime(2020, 6, 12, 17, 45, 16, 978, DateTimeKind.Local).AddTicks(2957), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 22, "", "", new DateTime(2020, 2, 9, 1, 12, 6, 723, DateTimeKind.Local).AddTicks(9107), new DateTime(2020, 3, 29, 23, 47, 24, 175, DateTimeKind.Local).AddTicks(1743), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 50, "", "", new DateTime(2020, 11, 28, 6, 35, 16, 123, DateTimeKind.Local).AddTicks(2667), new DateTime(2020, 7, 1, 8, 23, 56, 848, DateTimeKind.Local).AddTicks(3120), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 19, "", "", new DateTime(2020, 7, 16, 11, 55, 34, 735, DateTimeKind.Local).AddTicks(5497), new DateTime(2020, 8, 22, 23, 26, 21, 476, DateTimeKind.Local).AddTicks(3206), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 18, "", "", new DateTime(2020, 7, 26, 8, 3, 36, 789, DateTimeKind.Local).AddTicks(1454), new DateTime(2020, 3, 7, 13, 7, 45, 796, DateTimeKind.Local).AddTicks(8698), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 17, "", "", new DateTime(2020, 2, 9, 12, 52, 53, 747, DateTimeKind.Local).AddTicks(9934), new DateTime(2020, 10, 26, 9, 31, 9, 10, DateTimeKind.Local).AddTicks(4264), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 16, "", "", new DateTime(2020, 5, 10, 16, 40, 13, 672, DateTimeKind.Local).AddTicks(7664), new DateTime(2020, 10, 17, 18, 23, 0, 561, DateTimeKind.Local).AddTicks(664), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 15, "", "", new DateTime(2020, 2, 1, 8, 19, 39, 146, DateTimeKind.Local).AddTicks(5820), new DateTime(2020, 7, 20, 21, 10, 30, 149, DateTimeKind.Local).AddTicks(4881), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 14, "", "", new DateTime(2020, 4, 24, 5, 16, 52, 125, DateTimeKind.Local).AddTicks(3518), new DateTime(2020, 6, 23, 4, 21, 16, 448, DateTimeKind.Local).AddTicks(3322), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 13, "", "", new DateTime(2020, 11, 16, 22, 31, 40, 737, DateTimeKind.Local).AddTicks(7111), new DateTime(2020, 4, 15, 5, 16, 41, 536, DateTimeKind.Local).AddTicks(7532), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 12, "", "", new DateTime(2020, 9, 2, 1, 8, 45, 168, DateTimeKind.Local).AddTicks(8314), new DateTime(2020, 1, 16, 16, 18, 15, 383, DateTimeKind.Local).AddTicks(7488), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 11, "", "", new DateTime(2020, 4, 16, 23, 24, 49, 403, DateTimeKind.Local).AddTicks(112), new DateTime(2020, 10, 29, 7, 46, 40, 821, DateTimeKind.Local).AddTicks(7156), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 10, "", "", new DateTime(2020, 9, 26, 20, 53, 42, 631, DateTimeKind.Local).AddTicks(1409), new DateTime(2020, 2, 23, 10, 41, 28, 228, DateTimeKind.Local).AddTicks(8047), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 9, "", "", new DateTime(2020, 2, 22, 8, 15, 8, 512, DateTimeKind.Local).AddTicks(3072), new DateTime(2020, 2, 4, 16, 22, 18, 299, DateTimeKind.Local).AddTicks(9453), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 8, "", "", new DateTime(2020, 9, 22, 19, 18, 19, 111, DateTimeKind.Local).AddTicks(8258), new DateTime(2020, 8, 18, 9, 17, 2, 560, DateTimeKind.Local).AddTicks(7999), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 7, "", "", new DateTime(2019, 12, 18, 15, 32, 16, 271, DateTimeKind.Local).AddTicks(796), new DateTime(2020, 11, 6, 14, 12, 22, 111, DateTimeKind.Local).AddTicks(6864), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 6, "", "", new DateTime(2020, 3, 10, 9, 21, 51, 413, DateTimeKind.Local).AddTicks(196), new DateTime(2020, 6, 11, 21, 15, 16, 567, DateTimeKind.Local).AddTicks(1029), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 5, "", "", new DateTime(2020, 8, 19, 19, 44, 34, 668, DateTimeKind.Local).AddTicks(6723), new DateTime(2019, 12, 31, 16, 33, 8, 55, DateTimeKind.Local).AddTicks(6949), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 4, "", "", new DateTime(2020, 6, 24, 18, 35, 38, 661, DateTimeKind.Local).AddTicks(67), new DateTime(2020, 9, 17, 13, 4, 18, 409, DateTimeKind.Local).AddTicks(1033), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 3, "", "", new DateTime(2020, 4, 13, 19, 53, 52, 630, DateTimeKind.Local).AddTicks(2340), new DateTime(2020, 10, 6, 16, 43, 0, 626, DateTimeKind.Local).AddTicks(8460), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 2, "", "", new DateTime(2020, 6, 26, 18, 51, 10, 813, DateTimeKind.Local).AddTicks(7231), new DateTime(2020, 8, 29, 19, 26, 6, 166, DateTimeKind.Local).AddTicks(8395), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 1, "", "", new DateTime(2020, 6, 2, 5, 56, 17, 222, DateTimeKind.Local).AddTicks(4422), new DateTime(2020, 10, 26, 6, 25, 10, 524, DateTimeKind.Local).AddTicks(8313), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 23, "", "", new DateTime(2020, 11, 4, 4, 13, 11, 230, DateTimeKind.Local).AddTicks(6293), new DateTime(2020, 2, 3, 11, 53, 16, 449, DateTimeKind.Local).AddTicks(8504), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 24, "", "", new DateTime(2020, 7, 27, 15, 45, 2, 589, DateTimeKind.Local).AddTicks(2370), new DateTime(2020, 9, 28, 15, 32, 20, 104, DateTimeKind.Local).AddTicks(6586), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 21, "", "", new DateTime(2020, 6, 12, 7, 49, 32, 512, DateTimeKind.Local).AddTicks(1001), new DateTime(2020, 6, 23, 1, 42, 6, 778, DateTimeKind.Local).AddTicks(9620), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 26, "", "", new DateTime(2020, 1, 24, 18, 12, 10, 655, DateTimeKind.Local).AddTicks(9870), new DateTime(2019, 12, 8, 19, 43, 4, 725, DateTimeKind.Local).AddTicks(995), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 48, "", "", new DateTime(2020, 10, 26, 23, 5, 36, 909, DateTimeKind.Local).AddTicks(3764), new DateTime(2020, 11, 11, 3, 42, 38, 698, DateTimeKind.Local).AddTicks(8895), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 47, "", "", new DateTime(2019, 12, 7, 2, 55, 52, 388, DateTimeKind.Local).AddTicks(3774), new DateTime(2020, 6, 18, 12, 7, 33, 838, DateTimeKind.Local).AddTicks(7026), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 46, "", "", new DateTime(2020, 11, 25, 10, 49, 42, 709, DateTimeKind.Local).AddTicks(2560), new DateTime(2020, 10, 5, 19, 56, 12, 473, DateTimeKind.Local).AddTicks(3618), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 45, "", "", new DateTime(2020, 8, 12, 4, 8, 23, 693, DateTimeKind.Local).AddTicks(8011), new DateTime(2020, 5, 8, 3, 1, 40, 837, DateTimeKind.Local).AddTicks(5393), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 44, "", "", new DateTime(2020, 3, 20, 9, 55, 48, 889, DateTimeKind.Local).AddTicks(1718), new DateTime(2020, 3, 27, 5, 55, 12, 478, DateTimeKind.Local).AddTicks(3526), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 43, "", "", new DateTime(2020, 10, 19, 14, 40, 34, 520, DateTimeKind.Local).AddTicks(9455), new DateTime(2020, 7, 9, 15, 49, 59, 376, DateTimeKind.Local).AddTicks(885), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", "" },
                    { 42, "", "", new DateTime(2020, 11, 16, 2, 56, 34, 706, DateTimeKind.Local).AddTicks(4214), new DateTime(2020, 5, 29, 18, 44, 9, 882, DateTimeKind.Local).AddTicks(703), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 25, "", "", new DateTime(2020, 5, 7, 17, 57, 48, 819, DateTimeKind.Local).AddTicks(6611), new DateTime(2020, 1, 3, 2, 26, 40, 740, DateTimeKind.Local).AddTicks(2490), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 40, "", "", new DateTime(2020, 6, 22, 6, 9, 20, 108, DateTimeKind.Local).AddTicks(1443), new DateTime(2020, 7, 18, 19, 30, 35, 46, DateTimeKind.Local).AddTicks(3604), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 39, "", "", new DateTime(2020, 7, 16, 1, 28, 21, 908, DateTimeKind.Local).AddTicks(2038), new DateTime(2020, 2, 19, 20, 52, 58, 497, DateTimeKind.Local).AddTicks(3982), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportParallelePiece" },
                values: new object[,]
                {
                    { 38, "", "", new DateTime(2020, 8, 19, 3, 9, 28, 428, DateTimeKind.Local).AddTicks(1858), new DateTime(2020, 9, 5, 0, 56, 44, 408, DateTimeKind.Local).AddTicks(6562), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 41, "", "", new DateTime(2020, 2, 13, 5, 43, 45, 546, DateTimeKind.Local).AddTicks(4436), new DateTime(2020, 11, 1, 18, 24, 39, 796, DateTimeKind.Local).AddTicks(9233), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 36, "", "", new DateTime(2020, 7, 13, 0, 33, 5, 233, DateTimeKind.Local).AddTicks(9697), new DateTime(2020, 6, 30, 4, 54, 16, 598, DateTimeKind.Local).AddTicks(3820), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 37, "", "", new DateTime(2020, 11, 26, 11, 24, 1, 550, DateTimeKind.Local).AddTicks(6523), new DateTime(2020, 2, 25, 6, 50, 53, 720, DateTimeKind.Local).AddTicks(1211), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", "" },
                    { 28, "", "", new DateTime(2019, 12, 20, 13, 50, 3, 93, DateTimeKind.Local).AddTicks(9375), new DateTime(2020, 10, 23, 2, 7, 31, 964, DateTimeKind.Local).AddTicks(5925), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", "" },
                    { 29, "", "", new DateTime(2020, 8, 8, 5, 9, 38, 172, DateTimeKind.Local).AddTicks(9674), new DateTime(2020, 7, 29, 11, 16, 0, 238, DateTimeKind.Local).AddTicks(8199), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 30, "", "", new DateTime(2020, 6, 2, 22, 28, 16, 717, DateTimeKind.Local).AddTicks(8205), new DateTime(2019, 12, 16, 15, 20, 49, 913, DateTimeKind.Local).AddTicks(5673), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 27, "", "", new DateTime(2020, 8, 14, 0, 10, 12, 37, DateTimeKind.Local).AddTicks(2105), new DateTime(2019, 12, 15, 14, 35, 24, 883, DateTimeKind.Local).AddTicks(5994), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", "" },
                    { 32, "", "", new DateTime(2020, 3, 31, 11, 25, 44, 436, DateTimeKind.Local).AddTicks(9860), new DateTime(2020, 5, 27, 20, 56, 52, 504, DateTimeKind.Local).AddTicks(4802), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", "" },
                    { 33, "", "", new DateTime(2020, 1, 1, 23, 5, 5, 660, DateTimeKind.Local).AddTicks(4642), new DateTime(2019, 12, 6, 1, 2, 59, 999, DateTimeKind.Local).AddTicks(428), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", "" },
                    { 34, "", "", new DateTime(2020, 4, 20, 3, 30, 3, 436, DateTimeKind.Local).AddTicks(6054), new DateTime(2020, 1, 7, 15, 56, 51, 304, DateTimeKind.Local).AddTicks(7112), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 35, "", "", new DateTime(2020, 5, 17, 1, 34, 46, 879, DateTimeKind.Local).AddTicks(9140), new DateTime(2020, 8, 7, 2, 4, 24, 389, DateTimeKind.Local).AddTicks(28), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", "" },
                    { 31, "", "", new DateTime(2020, 7, 28, 14, 19, 57, 249, DateTimeKind.Local).AddTicks(6139), new DateTime(2020, 3, 25, 9, 45, 48, 150, DateTimeKind.Local).AddTicks(3746), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MandatAr", "MiseOeuvrePiece" },
                values: new object[,]
                {
                    { 7, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2817), "", "", "", "La rapporteuse spéciale dans le domaine des droits culturels", "المقررة الخاصة في مجال الحقوق الثقافية", "" },
                    { 1, new DateTime(2020, 12, 2, 15, 33, 35, 213, DateTimeKind.Local).AddTicks(9634), "", "", "", "la Rapporteuse spéciale sur le droit à l’alimentation", "المقررة الخاصة المعنية بالحق في الغذاء", "" },
                    { 2, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2707), "", "", "", "La Rapporteuse spéciale sur les formes contemporaines de racisme, de discrimination raciale, de xénophobie et de l’intolérance qui y est associée", "المقررة الخاصة المعنية بالأشكال المعاصرة للعنصرية والتمييز العنصري وكره الأجانب وما يتصل بذلك من تعصب", "" },
                    { 3, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2793), "", "", "", "Rapporteur spécial sur la torture et autres peines ou traitements cruels, inhumains ou dégradants", "المقرر الخاص المعني بالتعذيب وغيره من ضروب المعاملة أو العقوبة القاسية", "" },
                    { 4, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2802), "", "", "", "la Rapporteuse spéciale sur la traite des êtres humains, en particulier les femmes et les enfants", "المقررة الخاصة المعنية بالاتجار بالأشخاص، لا سيما النساء والأطفال", "" },
                    { 5, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2808), "", "", "", "Le groupe de travail chargé de la question de la discrimination à l’égard des femmes, dans la législation et dans la pratique", "العامل المعني بمسألة التمييز ضد المرأة في القانون والممارسة", "" },
                    { 6, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2812), "", "", "", "Le groupe de travail sur la détention arbitraire", "الفريق العامل المعني بالاحتجاز التعسفي", "" },
                    { 8, new DateTime(2020, 12, 2, 15, 33, 35, 218, DateTimeKind.Local).AddTicks(2822), "", "", "", "l’Experte indépendante sur les droits de l’homme et la solidarité internationale", "الخبيرة المستقلة المعنية بحقوق الإنسان والتضامن الدولي", "" }
                });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 2, 16, 39, 1, 155, DateTimeKind.Local).AddTicks(7333), new DateTime(2020, 12, 2, 16, 47, 3, 949, DateTimeKind.Local).AddTicks(1834), new DateTime(2020, 12, 3, 8, 17, 11, 754, DateTimeKind.Local).AddTicks(5991), 22, "", "http://romane.fr", "velit" },
                    { 74, new DateTime(2020, 12, 2, 20, 47, 4, 512, DateTimeKind.Local).AddTicks(6800), new DateTime(2020, 12, 3, 5, 38, 5, 118, DateTimeKind.Local).AddTicks(4779), new DateTime(2020, 12, 3, 0, 45, 21, 932, DateTimeKind.Local).AddTicks(7041), 57, "", "https://ethan.com", "harum" },
                    { 6, new DateTime(2020, 12, 2, 21, 18, 54, 369, DateTimeKind.Local).AddTicks(3719), new DateTime(2020, 12, 3, 15, 17, 42, 194, DateTimeKind.Local).AddTicks(3770), new DateTime(2020, 12, 2, 17, 51, 4, 88, DateTimeKind.Local).AddTicks(3046), 57, "", "http://alexandre.com", "ut" },
                    { 84, new DateTime(2020, 12, 2, 23, 7, 52, 20, DateTimeKind.Local).AddTicks(7634), new DateTime(2020, 12, 3, 13, 7, 50, 943, DateTimeKind.Local).AddTicks(5197), new DateTime(2020, 12, 2, 17, 3, 32, 78, DateTimeKind.Local).AddTicks(7344), 56, "", "https://clara.org", "laborum" },
                    { 81, new DateTime(2020, 12, 3, 6, 7, 9, 15, DateTimeKind.Local).AddTicks(8751), new DateTime(2020, 12, 2, 23, 49, 32, 171, DateTimeKind.Local).AddTicks(3872), new DateTime(2020, 12, 2, 17, 9, 31, 973, DateTimeKind.Local).AddTicks(3720), 55, "", "https://laura.info", "fugiat" },
                    { 26, new DateTime(2020, 12, 3, 4, 17, 6, 332, DateTimeKind.Local).AddTicks(9638), new DateTime(2020, 12, 3, 9, 16, 17, 210, DateTimeKind.Local).AddTicks(583), new DateTime(2020, 12, 3, 1, 7, 14, 430, DateTimeKind.Local).AddTicks(7993), 2, "", "https://léa.eu", "ea" },
                    { 47, new DateTime(2020, 12, 3, 7, 26, 48, 457, DateTimeKind.Local).AddTicks(4937), new DateTime(2020, 12, 2, 21, 48, 53, 782, DateTimeKind.Local).AddTicks(6306), new DateTime(2020, 12, 3, 9, 27, 5, 254, DateTimeKind.Local).AddTicks(815), 4, "", "http://lina.fr", "sit" },
                    { 83, new DateTime(2020, 12, 3, 7, 44, 59, 132, DateTimeKind.Local).AddTicks(7706), new DateTime(2020, 12, 3, 5, 18, 0, 428, DateTimeKind.Local).AddTicks(8438), new DateTime(2020, 12, 3, 8, 20, 45, 729, DateTimeKind.Local).AddTicks(226), 4, "", "https://laura.org", "amet" },
                    { 53, new DateTime(2020, 12, 3, 5, 16, 49, 313, DateTimeKind.Local).AddTicks(994), new DateTime(2020, 12, 3, 8, 36, 36, 401, DateTimeKind.Local).AddTicks(4568), new DateTime(2020, 12, 2, 20, 15, 47, 806, DateTimeKind.Local).AddTicks(5193), 5, "", "https://arthur.net", "accusantium" },
                    { 38, new DateTime(2020, 12, 3, 8, 20, 18, 307, DateTimeKind.Local).AddTicks(2309), new DateTime(2020, 12, 2, 23, 46, 1, 381, DateTimeKind.Local).AddTicks(9697), new DateTime(2020, 12, 3, 12, 1, 25, 983, DateTimeKind.Local).AddTicks(7350), 6, "", "http://baptiste.fr", "ut" },
                    { 63, new DateTime(2020, 12, 3, 8, 24, 12, 914, DateTimeKind.Local).AddTicks(912), new DateTime(2020, 12, 3, 6, 34, 30, 434, DateTimeKind.Local).AddTicks(7254), new DateTime(2020, 12, 2, 16, 20, 46, 218, DateTimeKind.Local).AddTicks(9622), 6, "", "http://maëlys.org", "consequatur" },
                    { 16, new DateTime(2020, 12, 2, 23, 10, 19, 659, DateTimeKind.Local).AddTicks(6729), new DateTime(2020, 12, 3, 14, 16, 52, 927, DateTimeKind.Local).AddTicks(7731), new DateTime(2020, 12, 3, 13, 28, 4, 351, DateTimeKind.Local).AddTicks(8648), 7, "", "http://evan.com", "impedit" },
                    { 31, new DateTime(2020, 12, 3, 14, 51, 10, 8, DateTimeKind.Local).AddTicks(3698), new DateTime(2020, 12, 3, 8, 1, 44, 946, DateTimeKind.Local).AddTicks(1879), new DateTime(2020, 12, 3, 11, 23, 21, 504, DateTimeKind.Local).AddTicks(4402), 7, "", "http://adam.eu", "ut" },
                    { 2, new DateTime(2020, 12, 2, 18, 39, 44, 706, DateTimeKind.Local).AddTicks(7443), new DateTime(2020, 12, 3, 1, 49, 39, 550, DateTimeKind.Local).AddTicks(392), new DateTime(2020, 12, 3, 8, 26, 19, 89, DateTimeKind.Local).AddTicks(9233), 9, "", "https://romane.org", "quo" },
                    { 15, new DateTime(2020, 12, 3, 8, 49, 9, 532, DateTimeKind.Local).AddTicks(598), new DateTime(2020, 12, 3, 0, 31, 21, 673, DateTimeKind.Local).AddTicks(5728), new DateTime(2020, 12, 2, 16, 42, 29, 660, DateTimeKind.Local).AddTicks(7908), 9, "", "http://julien.info", "fugit" },
                    { 80, new DateTime(2020, 12, 3, 5, 24, 39, 788, DateTimeKind.Local).AddTicks(2136), new DateTime(2020, 12, 2, 15, 47, 50, 950, DateTimeKind.Local).AddTicks(2562), new DateTime(2020, 12, 3, 9, 50, 49, 293, DateTimeKind.Local).AddTicks(334), 9, "", "https://zoe.org", "excepturi" },
                    { 55, new DateTime(2020, 12, 3, 13, 5, 14, 210, DateTimeKind.Local).AddTicks(6095), new DateTime(2020, 12, 2, 19, 16, 0, 677, DateTimeKind.Local).AddTicks(4421), new DateTime(2020, 12, 2, 21, 27, 58, 908, DateTimeKind.Local).AddTicks(8889), 58, "", "http://lucas.info", "ut" },
                    { 18, new DateTime(2020, 12, 2, 16, 37, 17, 185, DateTimeKind.Local).AddTicks(7344), new DateTime(2020, 12, 3, 6, 16, 56, 438, DateTimeKind.Local).AddTicks(2189), new DateTime(2020, 12, 2, 18, 45, 56, 472, DateTimeKind.Local).AddTicks(9384), 10, "", "http://thomas.com", "quibusdam" },
                    { 68, new DateTime(2020, 12, 3, 14, 48, 54, 561, DateTimeKind.Local).AddTicks(481), new DateTime(2020, 12, 3, 1, 13, 32, 727, DateTimeKind.Local).AddTicks(4871), new DateTime(2020, 12, 3, 3, 37, 55, 173, DateTimeKind.Local).AddTicks(8476), 58, "", "http://carla.eu", "soluta" },
                    { 50, new DateTime(2020, 12, 2, 17, 5, 26, 480, DateTimeKind.Local).AddTicks(1963), new DateTime(2020, 12, 3, 4, 40, 52, 45, DateTimeKind.Local).AddTicks(6873), new DateTime(2020, 12, 3, 10, 27, 12, 976, DateTimeKind.Local).AddTicks(7546), 59, "", "https://marie.net", "ex" },
                    { 7, new DateTime(2020, 12, 3, 1, 34, 30, 516, DateTimeKind.Local).AddTicks(160), new DateTime(2020, 12, 3, 2, 16, 30, 921, DateTimeKind.Local).AddTicks(4180), new DateTime(2020, 12, 2, 20, 13, 22, 735, DateTimeKind.Local).AddTicks(9878), 74, "", "http://mael.fr", "dicta" },
                    { 34, new DateTime(2020, 12, 2, 20, 43, 0, 992, DateTimeKind.Local).AddTicks(3378), new DateTime(2020, 12, 3, 12, 18, 56, 825, DateTimeKind.Local).AddTicks(1292), new DateTime(2020, 12, 2, 15, 42, 46, 344, DateTimeKind.Local).AddTicks(7203), 72, "", "https://alicia.info", "quia" },
                    { 24, new DateTime(2020, 12, 3, 12, 19, 18, 82, DateTimeKind.Local).AddTicks(548), new DateTime(2020, 12, 2, 23, 31, 45, 838, DateTimeKind.Local).AddTicks(2813), new DateTime(2020, 12, 2, 18, 50, 42, 737, DateTimeKind.Local).AddTicks(6262), 72, "", "https://julien.eu", "rerum" },
                    { 19, new DateTime(2020, 12, 3, 13, 8, 32, 404, DateTimeKind.Local).AddTicks(2219), new DateTime(2020, 12, 2, 22, 34, 23, 471, DateTimeKind.Local).AddTicks(7860), new DateTime(2020, 12, 3, 0, 43, 52, 483, DateTimeKind.Local).AddTicks(1611), 72, "", "http://ines.com", "rerum" },
                    { 21, new DateTime(2020, 12, 2, 23, 42, 3, 204, DateTimeKind.Local).AddTicks(9247), new DateTime(2020, 12, 2, 17, 41, 9, 187, DateTimeKind.Local).AddTicks(5085), new DateTime(2020, 12, 3, 12, 10, 35, 82, DateTimeKind.Local).AddTicks(62), 71, "", "https://clémence.name", "dicta" },
                    { 4, new DateTime(2020, 12, 2, 17, 39, 51, 596, DateTimeKind.Local).AddTicks(1837), new DateTime(2020, 12, 3, 4, 25, 11, 372, DateTimeKind.Local).AddTicks(9881), new DateTime(2020, 12, 3, 15, 31, 33, 838, DateTimeKind.Local).AddTicks(8199), 70, "", "https://clara.info", "iure" },
                    { 78, new DateTime(2020, 12, 3, 13, 45, 31, 60, DateTimeKind.Local).AddTicks(1010), new DateTime(2020, 12, 3, 13, 56, 38, 905, DateTimeKind.Local).AddTicks(4839), new DateTime(2020, 12, 2, 16, 11, 58, 550, DateTimeKind.Local).AddTicks(8857), 69, "", "https://baptiste.com", "similique" },
                    { 51, new DateTime(2020, 12, 3, 7, 40, 28, 847, DateTimeKind.Local).AddTicks(6732), new DateTime(2020, 12, 2, 23, 45, 37, 92, DateTimeKind.Local).AddTicks(9679), new DateTime(2020, 12, 3, 4, 32, 27, 253, DateTimeKind.Local).AddTicks(6611), 67, "", "http://noémie.org", "corrupti" },
                    { 40, new DateTime(2020, 12, 2, 22, 30, 3, 972, DateTimeKind.Local).AddTicks(9009), new DateTime(2020, 12, 2, 16, 17, 10, 247, DateTimeKind.Local).AddTicks(2952), new DateTime(2020, 12, 2, 21, 1, 43, 678, DateTimeKind.Local).AddTicks(9372), 67, "", "http://jules.info", "repudiandae" },
                    { 89, new DateTime(2020, 12, 2, 18, 57, 45, 781, DateTimeKind.Local).AddTicks(2972), new DateTime(2020, 12, 2, 20, 22, 21, 163, DateTimeKind.Local).AddTicks(7117), new DateTime(2020, 12, 2, 18, 35, 36, 269, DateTimeKind.Local).AddTicks(2638), 66, "", "http://théo.eu", "et" },
                    { 98, new DateTime(2020, 12, 3, 4, 45, 7, 122, DateTimeKind.Local).AddTicks(6956), new DateTime(2020, 12, 2, 18, 30, 44, 399, DateTimeKind.Local).AddTicks(7524), new DateTime(2020, 12, 3, 13, 24, 56, 168, DateTimeKind.Local).AddTicks(3877), 65, "", "http://anaïs.com", "dignissimos" },
                    { 77, new DateTime(2020, 12, 3, 3, 26, 58, 77, DateTimeKind.Local).AddTicks(1131), new DateTime(2020, 12, 2, 15, 51, 4, 506, DateTimeKind.Local).AddTicks(2233), new DateTime(2020, 12, 3, 10, 59, 47, 305, DateTimeKind.Local).AddTicks(2980), 64, "", "https://alicia.com", "ullam" },
                    { 29, new DateTime(2020, 12, 3, 12, 27, 3, 454, DateTimeKind.Local).AddTicks(2097), new DateTime(2020, 12, 3, 9, 8, 45, 685, DateTimeKind.Local).AddTicks(5868), new DateTime(2020, 12, 2, 21, 23, 59, 873, DateTimeKind.Local).AddTicks(3671), 63, "", "http://lucie.com", "blanditiis" },
                    { 23, new DateTime(2020, 12, 3, 0, 38, 24, 349, DateTimeKind.Local).AddTicks(8824), new DateTime(2020, 12, 3, 10, 34, 44, 662, DateTimeKind.Local).AddTicks(4038), new DateTime(2020, 12, 2, 19, 30, 31, 231, DateTimeKind.Local).AddTicks(38), 62, "", "http://paul.com", "quasi" },
                    { 39, new DateTime(2020, 12, 3, 7, 47, 57, 262, DateTimeKind.Local).AddTicks(4833), new DateTime(2020, 12, 3, 10, 36, 16, 366, DateTimeKind.Local).AddTicks(6324), new DateTime(2020, 12, 3, 7, 32, 46, 968, DateTimeKind.Local).AddTicks(2868), 61, "", "http://lucie.fr", "placeat" },
                    { 100, new DateTime(2020, 12, 3, 15, 31, 55, 487, DateTimeKind.Local).AddTicks(133), new DateTime(2020, 12, 3, 11, 26, 19, 284, DateTimeKind.Local).AddTicks(6607), new DateTime(2020, 12, 3, 7, 39, 52, 172, DateTimeKind.Local).AddTicks(9977), 58, "", "http://noémie.com", "voluptates" },
                    { 22, new DateTime(2020, 12, 2, 23, 10, 48, 10, DateTimeKind.Local).AddTicks(2849), new DateTime(2020, 12, 3, 13, 33, 51, 970, DateTimeKind.Local).AddTicks(4313), new DateTime(2020, 12, 2, 16, 34, 40, 637, DateTimeKind.Local).AddTicks(1216), 10, "", "https://clémence.name", "laborum" },
                    { 12, new DateTime(2020, 12, 3, 3, 29, 28, 770, DateTimeKind.Local).AddTicks(102), new DateTime(2020, 12, 2, 22, 36, 40, 753, DateTimeKind.Local).AddTicks(2829), new DateTime(2020, 12, 3, 11, 57, 28, 463, DateTimeKind.Local).AddTicks(2821), 11, "", "http://julien.name", "vel" },
                    { 75, new DateTime(2020, 12, 2, 22, 30, 21, 562, DateTimeKind.Local).AddTicks(7201), new DateTime(2020, 12, 3, 7, 32, 36, 534, DateTimeKind.Local).AddTicks(1223), new DateTime(2020, 12, 3, 3, 21, 34, 670, DateTimeKind.Local).AddTicks(2881), 11, "", "http://ines.info", "natus" },
                    { 76, new DateTime(2020, 12, 3, 0, 11, 32, 919, DateTimeKind.Local).AddTicks(2555), new DateTime(2020, 12, 3, 4, 40, 21, 190, DateTimeKind.Local).AddTicks(6648), new DateTime(2020, 12, 2, 19, 31, 8, 988, DateTimeKind.Local).AddTicks(3746), 32, "", "http://lola.org", "non" },
                    { 88, new DateTime(2020, 12, 3, 11, 11, 40, 776, DateTimeKind.Local).AddTicks(3698), new DateTime(2020, 12, 2, 17, 46, 13, 794, DateTimeKind.Local).AddTicks(1463), new DateTime(2020, 12, 2, 21, 8, 15, 587, DateTimeKind.Local).AddTicks(5469), 32, "", "https://lou.com", "dolore" },
                    { 92, new DateTime(2020, 12, 3, 7, 9, 34, 900, DateTimeKind.Local).AddTicks(7657), new DateTime(2020, 12, 2, 15, 51, 34, 605, DateTimeKind.Local).AddTicks(2150), new DateTime(2020, 12, 3, 14, 7, 49, 703, DateTimeKind.Local).AddTicks(5952), 33, "", "http://mathilde.eu", "nihil" },
                    { 91, new DateTime(2020, 12, 2, 19, 42, 50, 355, DateTimeKind.Local).AddTicks(8483), new DateTime(2020, 12, 3, 1, 0, 7, 764, DateTimeKind.Local).AddTicks(9728), new DateTime(2020, 12, 2, 23, 28, 32, 685, DateTimeKind.Local).AddTicks(1415), 35, "", "http://océane.org", "iste" },
                    { 54, new DateTime(2020, 12, 3, 6, 8, 41, 19, DateTimeKind.Local).AddTicks(9453), new DateTime(2020, 12, 3, 15, 7, 24, 631, DateTimeKind.Local).AddTicks(2385), new DateTime(2020, 12, 3, 14, 46, 3, 428, DateTimeKind.Local).AddTicks(4112), 36, "", "https://justine.com", "facilis" },
                    { 5, new DateTime(2020, 12, 3, 2, 34, 47, 674, DateTimeKind.Local).AddTicks(8997), new DateTime(2020, 12, 2, 22, 4, 8, 510, DateTimeKind.Local).AddTicks(1889), new DateTime(2020, 12, 3, 2, 44, 43, 462, DateTimeKind.Local).AddTicks(4564), 38, "", "http://nathan.org", "mollitia" },
                    { 13, new DateTime(2020, 12, 3, 6, 46, 47, 756, DateTimeKind.Local).AddTicks(1774), new DateTime(2020, 12, 3, 14, 56, 26, 79, DateTimeKind.Local).AddTicks(9242), new DateTime(2020, 12, 2, 19, 38, 36, 785, DateTimeKind.Local).AddTicks(5247), 38, "", "https://tom.fr", "sunt" },
                    { 60, new DateTime(2020, 12, 3, 11, 27, 28, 637, DateTimeKind.Local).AddTicks(7806), new DateTime(2020, 12, 3, 14, 27, 34, 713, DateTimeKind.Local).AddTicks(7945), new DateTime(2020, 12, 2, 22, 0, 36, 311, DateTimeKind.Local).AddTicks(6962), 38, "", "https://benjamin.fr", "perspiciatis" },
                    { 36, new DateTime(2020, 12, 3, 15, 23, 41, 737, DateTimeKind.Local).AddTicks(2568), new DateTime(2020, 12, 3, 4, 37, 53, 534, DateTimeKind.Local).AddTicks(6981), new DateTime(2020, 12, 3, 13, 53, 33, 964, DateTimeKind.Local).AddTicks(3347), 39, "", "https://louis.com", "modi" },
                    { 10, new DateTime(2020, 12, 2, 23, 2, 42, 743, DateTimeKind.Local).AddTicks(9155), new DateTime(2020, 12, 3, 1, 17, 4, 113, DateTimeKind.Local).AddTicks(2705), new DateTime(2020, 12, 3, 7, 30, 51, 239, DateTimeKind.Local).AddTicks(7547), 40, "", "https://rayan.info", "ea" },
                    { 9, new DateTime(2020, 12, 3, 0, 57, 19, 388, DateTimeKind.Local).AddTicks(3281), new DateTime(2020, 12, 3, 8, 45, 59, 255, DateTimeKind.Local).AddTicks(5328), new DateTime(2020, 12, 3, 6, 38, 5, 434, DateTimeKind.Local).AddTicks(3085), 41, "", "https://maxence.com", "non" },
                    { 72, new DateTime(2020, 12, 3, 6, 27, 15, 933, DateTimeKind.Local).AddTicks(2825), new DateTime(2020, 12, 2, 19, 59, 19, 583, DateTimeKind.Local).AddTicks(8121), new DateTime(2020, 12, 3, 10, 2, 38, 856, DateTimeKind.Local).AddTicks(8384), 41, "", "http://thomas.info", "ad" },
                    { 67, new DateTime(2020, 12, 2, 19, 4, 39, 829, DateTimeKind.Local).AddTicks(139), new DateTime(2020, 12, 2, 23, 45, 26, 929, DateTimeKind.Local).AddTicks(9985), new DateTime(2020, 12, 3, 7, 46, 42, 39, DateTimeKind.Local).AddTicks(8983), 43, "", "https://laura.net", "non" },
                    { 79, new DateTime(2020, 12, 3, 6, 19, 40, 586, DateTimeKind.Local).AddTicks(5612), new DateTime(2020, 12, 2, 21, 53, 19, 497, DateTimeKind.Local).AddTicks(9468), new DateTime(2020, 12, 2, 18, 13, 39, 166, DateTimeKind.Local).AddTicks(4146), 45, "", "http://jeanne.name", "aut" },
                    { 41, new DateTime(2020, 12, 3, 0, 44, 22, 623, DateTimeKind.Local).AddTicks(6266), new DateTime(2020, 12, 3, 14, 15, 27, 842, DateTimeKind.Local).AddTicks(6083), new DateTime(2020, 12, 3, 8, 38, 14, 707, DateTimeKind.Local).AddTicks(3240), 48, "", "https://yanis.eu", "aut" },
                    { 27, new DateTime(2020, 12, 3, 12, 48, 15, 173, DateTimeKind.Local).AddTicks(9560), new DateTime(2020, 12, 3, 14, 27, 48, 792, DateTimeKind.Local).AddTicks(7352), new DateTime(2020, 12, 3, 0, 36, 5, 463, DateTimeKind.Local).AddTicks(689), 30, "", "http://noa.info", "tenetur" },
                    { 28, new DateTime(2020, 12, 3, 8, 10, 13, 364, DateTimeKind.Local).AddTicks(4561), new DateTime(2020, 12, 3, 4, 20, 52, 794, DateTimeKind.Local).AddTicks(6307), new DateTime(2020, 12, 3, 11, 38, 41, 275, DateTimeKind.Local).AddTicks(4973), 29, "", "http://juliette.name", "similique" },
                    { 82, new DateTime(2020, 12, 3, 2, 38, 39, 387, DateTimeKind.Local).AddTicks(3764), new DateTime(2020, 12, 3, 1, 11, 5, 895, DateTimeKind.Local).AddTicks(9772), new DateTime(2020, 12, 2, 19, 49, 35, 767, DateTimeKind.Local).AddTicks(9720), 28, "", "https://alice.eu", "eius" },
                    { 66, new DateTime(2020, 12, 2, 18, 42, 32, 901, DateTimeKind.Local).AddTicks(2230), new DateTime(2020, 12, 3, 5, 28, 1, 583, DateTimeKind.Local).AddTicks(282), new DateTime(2020, 12, 2, 16, 42, 58, 834, DateTimeKind.Local).AddTicks(8430), 27, "", "https://sarah.org", "aut" },
                    { 86, new DateTime(2020, 12, 2, 23, 23, 4, 906, DateTimeKind.Local).AddTicks(2381), new DateTime(2020, 12, 3, 11, 4, 53, 48, DateTimeKind.Local).AddTicks(5724), new DateTime(2020, 12, 3, 15, 7, 11, 389, DateTimeKind.Local).AddTicks(7196), 12, "", "http://adam.name", "quam" },
                    { 73, new DateTime(2020, 12, 2, 18, 30, 50, 686, DateTimeKind.Local).AddTicks(7996), new DateTime(2020, 12, 2, 19, 45, 9, 589, DateTimeKind.Local).AddTicks(303), new DateTime(2020, 12, 3, 13, 0, 30, 435, DateTimeKind.Local).AddTicks(140), 13, "", "http://lucie.org", "aut" },
                    { 93, new DateTime(2020, 12, 3, 9, 26, 53, 82, DateTimeKind.Local).AddTicks(5413), new DateTime(2020, 12, 3, 6, 51, 28, 846, DateTimeKind.Local).AddTicks(9765), new DateTime(2020, 12, 3, 14, 49, 53, 181, DateTimeKind.Local).AddTicks(6214), 15, "", "http://charlotte.org", "sunt" },
                    { 11, new DateTime(2020, 12, 2, 18, 38, 31, 216, DateTimeKind.Local).AddTicks(4144), new DateTime(2020, 12, 3, 11, 46, 56, 563, DateTimeKind.Local).AddTicks(7064), new DateTime(2020, 12, 2, 22, 14, 26, 995, DateTimeKind.Local).AddTicks(3948), 16, "", "https://victor.net", "omnis" },
                    { 49, new DateTime(2020, 12, 3, 6, 59, 34, 729, DateTimeKind.Local).AddTicks(876), new DateTime(2020, 12, 3, 14, 55, 22, 638, DateTimeKind.Local).AddTicks(4285), new DateTime(2020, 12, 3, 9, 4, 34, 813, DateTimeKind.Local).AddTicks(9799), 16, "", "https://tom.name", "sint" },
                    { 64, new DateTime(2020, 12, 3, 2, 18, 49, 3, DateTimeKind.Local).AddTicks(3505), new DateTime(2020, 12, 3, 12, 24, 42, 499, DateTimeKind.Local).AddTicks(6470), new DateTime(2020, 12, 3, 14, 20, 23, 25, DateTimeKind.Local).AddTicks(710), 16, "", "https://mathilde.name", "excepturi" },
                    { 8, new DateTime(2020, 12, 3, 4, 7, 29, 629, DateTimeKind.Local).AddTicks(6764), new DateTime(2020, 12, 2, 19, 30, 21, 941, DateTimeKind.Local).AddTicks(290), new DateTime(2020, 12, 2, 18, 42, 31, 586, DateTimeKind.Local).AddTicks(1688), 18, "", "https://célia.fr", "officia" },
                    { 65, new DateTime(2020, 12, 3, 13, 27, 35, 113, DateTimeKind.Local).AddTicks(9515), new DateTime(2020, 12, 3, 5, 31, 14, 806, DateTimeKind.Local).AddTicks(7996), new DateTime(2020, 12, 3, 5, 11, 33, 544, DateTimeKind.Local).AddTicks(6895), 74, "", "https://louna.net", "qui" },
                    { 14, new DateTime(2020, 12, 2, 15, 59, 40, 257, DateTimeKind.Local).AddTicks(170), new DateTime(2020, 12, 3, 8, 53, 24, 158, DateTimeKind.Local).AddTicks(8383), new DateTime(2020, 12, 3, 1, 36, 43, 640, DateTimeKind.Local).AddTicks(5896), 19, "", "https://maëlys.name", "cumque" },
                    { 30, new DateTime(2020, 12, 2, 22, 25, 4, 658, DateTimeKind.Local).AddTicks(6037), new DateTime(2020, 12, 3, 12, 6, 38, 895, DateTimeKind.Local).AddTicks(7390), new DateTime(2020, 12, 2, 17, 28, 48, 182, DateTimeKind.Local).AddTicks(2956), 21, "", "http://louise.info", "laudantium" },
                    { 44, new DateTime(2020, 12, 2, 23, 50, 34, 868, DateTimeKind.Local).AddTicks(1433), new DateTime(2020, 12, 3, 4, 17, 15, 22, DateTimeKind.Local).AddTicks(3234), new DateTime(2020, 12, 3, 5, 54, 16, 329, DateTimeKind.Local).AddTicks(9591), 21, "", "https://maxime.org", "dolore" },
                    { 52, new DateTime(2020, 12, 3, 3, 27, 13, 650, DateTimeKind.Local).AddTicks(2269), new DateTime(2020, 12, 2, 19, 39, 14, 478, DateTimeKind.Local).AddTicks(8805), new DateTime(2020, 12, 2, 15, 37, 51, 142, DateTimeKind.Local).AddTicks(7074), 52, "", "http://paul.info", "quibusdam" },
                    { 33, new DateTime(2020, 12, 2, 18, 20, 11, 214, DateTimeKind.Local).AddTicks(1086), new DateTime(2020, 12, 3, 0, 43, 16, 762, DateTimeKind.Local).AddTicks(4286), new DateTime(2020, 12, 2, 19, 4, 29, 696, DateTimeKind.Local).AddTicks(9355), 23, "", "http://lina.info", "doloremque" },
                    { 94, new DateTime(2020, 12, 3, 1, 55, 2, 947, DateTimeKind.Local).AddTicks(2434), new DateTime(2020, 12, 2, 17, 1, 49, 471, DateTimeKind.Local).AddTicks(5254), new DateTime(2020, 12, 2, 17, 0, 42, 785, DateTimeKind.Local).AddTicks(7490), 24, "", "http://pauline.fr", "nostrum" },
                    { 71, new DateTime(2020, 12, 2, 17, 38, 46, 422, DateTimeKind.Local).AddTicks(3020), new DateTime(2020, 12, 2, 20, 3, 27, 339, DateTimeKind.Local).AddTicks(513), new DateTime(2020, 12, 2, 15, 49, 10, 775, DateTimeKind.Local).AddTicks(3679), 25, "", "http://clément.net", "vel" },
                    { 87, new DateTime(2020, 12, 2, 21, 3, 27, 624, DateTimeKind.Local).AddTicks(3025), new DateTime(2020, 12, 3, 12, 51, 33, 529, DateTimeKind.Local).AddTicks(1356), new DateTime(2020, 12, 3, 1, 26, 47, 661, DateTimeKind.Local).AddTicks(9676), 26, "", "http://mathilde.name", "nisi" },
                    { 56, new DateTime(2020, 12, 3, 10, 9, 49, 591, DateTimeKind.Local).AddTicks(510), new DateTime(2020, 12, 2, 21, 55, 46, 591, DateTimeKind.Local).AddTicks(7816), new DateTime(2020, 12, 3, 7, 17, 55, 171, DateTimeKind.Local).AddTicks(6365), 19, "", "http://lou.fr", "suscipit" },
                    { 20, new DateTime(2020, 12, 3, 7, 33, 32, 33, DateTimeKind.Local).AddTicks(9431), new DateTime(2020, 12, 2, 17, 34, 57, 665, DateTimeKind.Local).AddTicks(7503), new DateTime(2020, 12, 2, 16, 50, 4, 981, DateTimeKind.Local).AddTicks(7436), 76, "", "https://chloé.info", "recusandae" },
                    { 85, new DateTime(2020, 12, 2, 19, 13, 36, 137, DateTimeKind.Local).AddTicks(9262), new DateTime(2020, 12, 3, 4, 20, 2, 218, DateTimeKind.Local).AddTicks(7699), new DateTime(2020, 12, 2, 17, 32, 51, 803, DateTimeKind.Local).AddTicks(185), 76, "", "http://ethan.org", "incidunt" },
                    { 99, new DateTime(2020, 12, 3, 3, 28, 57, 835, DateTimeKind.Local).AddTicks(9172), new DateTime(2020, 12, 3, 4, 27, 7, 852, DateTimeKind.Local).AddTicks(4006), new DateTime(2020, 12, 3, 12, 20, 18, 136, DateTimeKind.Local).AddTicks(429), 76, "", "http://noa.info", "earum" },
                    { 95, new DateTime(2020, 12, 3, 2, 36, 59, 744, DateTimeKind.Local).AddTicks(8890), new DateTime(2020, 12, 2, 23, 35, 10, 137, DateTimeKind.Local).AddTicks(8759), new DateTime(2020, 12, 2, 19, 4, 25, 261, DateTimeKind.Local).AddTicks(8708), 48, "", "http://léa.eu", "eaque" },
                    { 61, new DateTime(2020, 12, 2, 21, 27, 47, 759, DateTimeKind.Local).AddTicks(3530), new DateTime(2020, 12, 3, 8, 14, 31, 282, DateTimeKind.Local).AddTicks(1928), new DateTime(2020, 12, 2, 16, 37, 53, 244, DateTimeKind.Local).AddTicks(9646), 96, "", "https://manon.info", "ab" },
                    { 70, new DateTime(2020, 12, 2, 16, 35, 22, 797, DateTimeKind.Local).AddTicks(8651), new DateTime(2020, 12, 2, 18, 24, 58, 310, DateTimeKind.Local).AddTicks(6239), new DateTime(2020, 12, 3, 13, 39, 21, 811, DateTimeKind.Local).AddTicks(8942), 94, "", "http://léo.com", "et" },
                    { 97, new DateTime(2020, 12, 2, 20, 14, 33, 345, DateTimeKind.Local).AddTicks(6415), new DateTime(2020, 12, 3, 9, 49, 47, 59, DateTimeKind.Local).AddTicks(5543), new DateTime(2020, 12, 2, 16, 50, 29, 375, DateTimeKind.Local).AddTicks(8804), 92, "", "http://ethan.fr", "vitae" },
                    { 48, new DateTime(2020, 12, 3, 10, 44, 25, 166, DateTimeKind.Local).AddTicks(3569), new DateTime(2020, 12, 3, 10, 39, 13, 434, DateTimeKind.Local).AddTicks(3529), new DateTime(2020, 12, 2, 18, 36, 5, 677, DateTimeKind.Local).AddTicks(8851), 92, "", "https://thomas.info", "eveniet" },
                    { 3, new DateTime(2020, 12, 3, 8, 11, 7, 786, DateTimeKind.Local).AddTicks(5600), new DateTime(2020, 12, 3, 2, 50, 5, 420, DateTimeKind.Local).AddTicks(6246), new DateTime(2020, 12, 3, 1, 34, 28, 587, DateTimeKind.Local).AddTicks(1343), 91, "", "https://léo.name", "soluta" },
                    { 62, new DateTime(2020, 12, 3, 11, 21, 50, 730, DateTimeKind.Local).AddTicks(7136), new DateTime(2020, 12, 2, 22, 19, 53, 905, DateTimeKind.Local).AddTicks(9931), new DateTime(2020, 12, 2, 18, 48, 16, 214, DateTimeKind.Local).AddTicks(9332), 90, "", "http://adam.com", "ducimus" },
                    { 42, new DateTime(2020, 12, 2, 20, 48, 11, 904, DateTimeKind.Local).AddTicks(2694), new DateTime(2020, 12, 2, 17, 21, 39, 782, DateTimeKind.Local).AddTicks(1014), new DateTime(2020, 12, 2, 17, 12, 40, 569, DateTimeKind.Local).AddTicks(6172), 89, "", "https://tom.com", "ducimus" },
                    { 37, new DateTime(2020, 12, 2, 15, 36, 43, 891, DateTimeKind.Local).AddTicks(8207), new DateTime(2020, 12, 3, 5, 58, 8, 801, DateTimeKind.Local).AddTicks(4053), new DateTime(2020, 12, 2, 17, 45, 0, 724, DateTimeKind.Local).AddTicks(8312), 89, "", "https://kylian.com", "exercitationem" },
                    { 59, new DateTime(2020, 12, 2, 19, 13, 58, 608, DateTimeKind.Local).AddTicks(2382), new DateTime(2020, 12, 3, 3, 49, 52, 608, DateTimeKind.Local).AddTicks(9350), new DateTime(2020, 12, 3, 6, 28, 55, 980, DateTimeKind.Local).AddTicks(5922), 88, "", "https://ines.com", "iusto" },
                    { 43, new DateTime(2020, 12, 3, 13, 35, 50, 51, DateTimeKind.Local).AddTicks(6907), new DateTime(2020, 12, 3, 10, 7, 2, 78, DateTimeKind.Local).AddTicks(7610), new DateTime(2020, 12, 3, 8, 31, 15, 492, DateTimeKind.Local).AddTicks(2260), 51, "", "http://noa.org", "cumque" },
                    { 32, new DateTime(2020, 12, 3, 8, 16, 28, 897, DateTimeKind.Local).AddTicks(4226), new DateTime(2020, 12, 2, 17, 29, 4, 889, DateTimeKind.Local).AddTicks(4758), new DateTime(2020, 12, 2, 18, 6, 20, 567, DateTimeKind.Local).AddTicks(5140), 83, "", "https://louise.name", "molestiae" },
                    { 96, new DateTime(2020, 12, 3, 2, 52, 37, 286, DateTimeKind.Local).AddTicks(3438), new DateTime(2020, 12, 3, 8, 48, 53, 294, DateTimeKind.Local).AddTicks(8926), new DateTime(2020, 12, 2, 15, 38, 5, 147, DateTimeKind.Local).AddTicks(4116), 82, "", "https://océane.com", "ab" },
                    { 58, new DateTime(2020, 12, 3, 2, 10, 10, 670, DateTimeKind.Local).AddTicks(591), new DateTime(2020, 12, 3, 2, 14, 30, 768, DateTimeKind.Local).AddTicks(8303), new DateTime(2020, 12, 2, 16, 53, 6, 763, DateTimeKind.Local).AddTicks(2270), 82, "", "https://romain.org", "aut" },
                    { 45, new DateTime(2020, 12, 2, 19, 13, 15, 743, DateTimeKind.Local).AddTicks(4651), new DateTime(2020, 12, 3, 4, 46, 37, 197, DateTimeKind.Local).AddTicks(8844), new DateTime(2020, 12, 3, 7, 48, 11, 921, DateTimeKind.Local).AddTicks(8180), 81, "", "https://rayan.com", "et" },
                    { 17, new DateTime(2020, 12, 2, 23, 17, 47, 534, DateTimeKind.Local).AddTicks(6175), new DateTime(2020, 12, 3, 1, 25, 31, 62, DateTimeKind.Local).AddTicks(5174), new DateTime(2020, 12, 3, 9, 52, 29, 394, DateTimeKind.Local).AddTicks(8258), 81, "", "http://nicolas.eu", "ut" },
                    { 90, new DateTime(2020, 12, 2, 20, 19, 11, 937, DateTimeKind.Local).AddTicks(7635), new DateTime(2020, 12, 2, 15, 53, 18, 765, DateTimeKind.Local).AddTicks(2668), new DateTime(2020, 12, 3, 8, 33, 51, 190, DateTimeKind.Local).AddTicks(6325), 80, "", "http://mohamed.eu", "dolorem" },
                    { 25, new DateTime(2020, 12, 3, 11, 58, 57, 376, DateTimeKind.Local).AddTicks(6304), new DateTime(2020, 12, 3, 2, 10, 51, 356, DateTimeKind.Local).AddTicks(5012), new DateTime(2020, 12, 3, 9, 37, 3, 90, DateTimeKind.Local).AddTicks(397), 80, "", "http://thomas.eu", "voluptatem" },
                    { 69, new DateTime(2020, 12, 3, 0, 26, 17, 576, DateTimeKind.Local).AddTicks(2213), new DateTime(2020, 12, 3, 1, 19, 33, 632, DateTimeKind.Local).AddTicks(6759), new DateTime(2020, 12, 3, 15, 2, 8, 870, DateTimeKind.Local).AddTicks(6469), 79, "", "http://mohamed.org", "nostrum" },
                    { 57, new DateTime(2020, 12, 2, 22, 53, 46, 85, DateTimeKind.Local).AddTicks(1252), new DateTime(2020, 12, 3, 14, 21, 16, 859, DateTimeKind.Local).AddTicks(3805), new DateTime(2020, 12, 2, 15, 59, 31, 813, DateTimeKind.Local).AddTicks(2472), 78, "", "http://louise.fr", "error" },
                    { 46, new DateTime(2020, 12, 3, 8, 41, 51, 632, DateTimeKind.Local).AddTicks(3817), new DateTime(2020, 12, 3, 7, 19, 50, 603, DateTimeKind.Local).AddTicks(7512), new DateTime(2020, 12, 3, 0, 51, 43, 608, DateTimeKind.Local).AddTicks(3852), 84, "", "http://julie.fr", "ipsam" },
                    { 35, new DateTime(2020, 12, 2, 19, 24, 35, 117, DateTimeKind.Local).AddTicks(3621), new DateTime(2020, 12, 3, 1, 43, 25, 415, DateTimeKind.Local).AddTicks(5275), new DateTime(2020, 12, 2, 23, 1, 30, 330, DateTimeKind.Local).AddTicks(6206), 77, "", "https://julien.eu", "quasi" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 577, null, "R92", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", "Les partis politiques instituent divers moyens de garantir l’intégration des femmes dans les listes électorales", "null", "", "" },
                    { 576, null, "R91P6", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", "Veiller à ce qu’une suite soit donnée aux recommandations de la commission consultative sur la régionalisation concernant l’égalité entre les sexes dans le cadre de la mise en place du système de gouvernance des régions et d’autres collectivités territoriales envisagé dans la Constitution; les fonds de développement social et de solidarité interrégionale prévus par la Constitution doivent intégrer dans leur travail les principes de la budgétisation axée sur la parité.", "null", "", "" },
                    { 575, null, "R91P3P4", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", @"c) Revoir la représentation des femmes au Conseil des ministres pour faire en sorte que les objectifs d’égalité formelle et effective entre les hommes et les femmes soient atteints ; 
                d) Revoir les règles de procédure régissant la prise de décisions aux échelons supérieurs des organes exécutif, législatif et judiciaire pour faire en sorte que l’objectif de la parité soit pris en compte", "null", "", "" },
                    { 574, null, "R90", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", @"a) le Conseil national des droits de l’homme et d’autres institutions nationales indépendantes doivent intensifier leurs efforts volontaristes pour faire face à la discrimination à l’égard des femmes en droit et en pratique en tant que partie intégrante des processus de protection et de promotion des droits de l’homme et de bonne gouvernance, notamment par le biais de systèmes indépendants de surveillance des droits de l’homme accessibles à toutes les femmes;
                b) Renforcer l’exécution de leurs mandats aux niveaux régional et local par des mesures spéciales pour assurer au niveau local l’accès des femmes qui sont victimes de multiples formes de discrimination.", "null", "", "" },
                    { 553, null, "R88P2", "null", "", "Réalisé", "", 100, 8, null, null, null, null, 4, "Procédure spéciale", "-    Les agents de l’Inspection du travail devraient être habilités à surveiller les conditions de travail de ces employés, qui sont souvent plus exposés que quiconque au risque d’être victimes de la traite.", "null", "", "" },
                    { 555, null, "R96P1", "null", "", "En cours", "", 30, 9, null, null, null, null, 4, "Procédure spéciale", "-    Renforcer les relations de partenariat avec les pays d’origine dans toutes les régions, y compris l’Afrique subsaharienne et l’Asie du Sud‑Est, ainsi que de coopérer aux fins de l’échange d’informations et de la fourniture d’un appui juridique mutuel", "null", "", "" },
                    { 554, null, "R98", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", "-    La participation et la collaboration des organisations de la société civile sont essentielles dans le cadre de 35. À cet égard, des mesures devraient être prises immédiatement, d’une part, pour fournir l’appui nécessaire aux organisations de la société civile qui aident les victimes, notamment en leur proposant un accompagnement psychologique, et d’autre part, pour établir le cadre juridique requis. Les organisations de la société civile et les organismes d’aide aux victimes devraient être en mesure d’exercer leurs activités dans toutes les régions du pays.", "null", "", "" },
                    { 578, null, "R93P1", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", "Revoir le fonds social pour le développement créé en vertu de la Constitution afin qu’il consacre une part équitable de ses ressources aux femmes, en particulier aux femmes rurales et aux femmes victimes de violence, de façon à les aider à jouir de leurs droits fondamentaux", "null", "", "" },
                    { 552, null, "R86", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", "-    Davantage de ressources, financières et autres, devraient être allouées à l’aide aux victimes de la traite, et des programmes et des institutions parrainés ou soutenus par l’État devraient être créés et développés de sorte que les victimes puissent bénéficier de soins à court et à long terme.", "null", "", "" },
                    { 573, null, "R89P8", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", @"Accélérer la création d’une autorité pour la parité et la lutte contre la discrimination à l’égard des femmes en tant qu’organisation faîtière pour consolider les acquis en matière d’égalité et d’élimination de la discrimination à l’égard des femmes. 
                - Le futur organisme devrait avoir pour tâches d’établir le bilan des progrès accomplis, de repérer les problèmes persistants et de proposer et d’exécuter des mesures en vue d’accomplir d’autres progrès. 
                - Le Gouvernement devrait assurer un processus de consultation vaste et ouvert avec toutes les parties prenantes en faisant fond sur le travail accompli par le Conseil national des droits de l’homme, et faire en sorte que cette autorité coopère avec lui", "null", "", "" },
                    { 579, null, "R93P2", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", "Prendre des mesures pour faire en sorte que les conseils locaux soient plus soucieux des questions de parité entre les sexes et de promouvoir, en tant que moyen d’autonomiser davantage la femme, la capacité individuelle et collective des femmes locales de participer véritablement à la vie publique au niveau local", "null", "", "" },
                    { 607, null, "R83P12", "null", "", "En cours", "", 30, 8, null, null, null, null, 6, "Procédure spéciale", @"Afin de lutter contre le surpeuplement dans les prisons, utiliser des alternatives à la détention préventive en conformité avec les Règles minima des Nations Unies pour l’élaboration de mesures non privatives de liberté (Règles de Tokyo) et étudier la dépénalisation possible de certaines infractions et la réduction possible des peines de prison. 
                - Un système pourrait être conçu pour organiser la caution et l’usage plus fréquent des sanctions non privatives de liberté dans le cas d’infractions moins graves", "null", "", "" },
                    { 581, null, "R93P6", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", "Elargir la protection juridique aux organisations caritatives qui fournissent une assistance et une protection aux groupes de femmes vulnérables et assurer un appui continu et d’une plus vaste portée de la part de l’État", "null", "", "" },
                    { 582, null, "R94", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", "Le Groupe de travail recommande au Conseil national des droits de l’homme et à d’autres organismes nationaux indépendants de mettre en place, là où il n’en existe pas, des mécanismes efficaces de surveillance et de protection sensibles à la condition des femmes et capables d’atteindre les communautés pauvres et rurales et, notamment, de faire face à la discrimination extrême dont sont victimes les travailleuses dans les champs de fraises du nord du Maroc.", "null", "", "" },
                    { 551, null, "R85", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", "-    le Gouvernement devrait faire beaucoup plus d’efforts pour protéger et aider toutes les victimes de la traite, y compris les hommes et les garçons, en veillant au plein respect de leurs droits de l’homme, et devrait faire en sorte que les enquêtes menées sur les affaires de traite soient axées sur une approche fondée sur les droits de l’homme.", "null", "", "" },
                    { 608, null, "R83P13", "null", "", "En cours", "", 30, 8, null, null, null, null, 6, "Procédure spéciale", "-       Continuer de s’engager à renforcer le 4 et lui fournir tous les moyens nécessaires pour assurer son bon fonctionnement ;", "null", "", "" },
                    { 609, null, "R83P14P2", "null", "", "Réalisé", "", 100, 8, null, null, null, null, 6, "Procédure spéciale", "-       … établir un mécanisme national de prévention efficace, conformément à l’article 17 du Protocole facultatif ; et lancer un processus de consultation inclusif de tous les acteurs concernés, y compris les organisations de la société civile", "null", "", "" },
                    { 610, null, "R83P15", "null", "", "En cours", "", 30, 8, null, null, null, null, 6, "Procédure spéciale", "-       Allouer des crédits pour équiper le mécanisme national de prévention des ressources humaines et autres suffisantes pour lui permettre d’inspecter régulièrement tous les lieux de détention, de recevoir des plaintes, d’engager des poursuites et de les suivre jusqu’à leur conclusion;", "null", "", "" },
                    { 636, null, "R86P1-1", "ت.86.ف.1ج1", "", "En cours", "", 30, null, null, null, null, null, 7, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en promulguant sans délai des lois donnant effet à la disposition constitutionnelle conférant à la langue amazighe le statut de langue officielle", @"(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                - سن قوانين فورية لإنفاذ الحكم الدستوري الذي يمنح اللغة الأمازيغية صفة رسمية؛", "", "" },
                    { 644, null, "R73P3", "null", "", "En cours", "", 30, 8, null, null, null, null, 8, "Procédure spéciale", "Renforcer la politique globale de développement national, de la planification et de la conception à la mise en œuvre et l’exécution, au suivi, à l’examen et à l’évaluation et à la cohérence et l’harmonisation des politiques entre les divers ministères, y compris ceux qui œuvrent en faveur de la coopération internationale pour le développement. Il est fortement recommandé qu’un seul service soit investi d’une fonction de contrôle à cet égard, de façon à optimiser les ressources et à éviter les doubles emplois", "null", "", "" },
                    { 645, null, "R73P4", "null", "", "En cours", "", 30, 8, null, null, null, null, 8, "Procédure spéciale", "Mettre en œuvre des consultations plus systématiques et approfondies aux fins de la planification, de la mise en œuvre, du suivi et de l’évaluation des programmes de développement, y compris les programmes d’aide au développement, avec la participation effective de la société civile et des collectivités concernées", "null", "", "" },
                    { 646, null, "R73P6-1", "null", "", "En cours", "", 30, 8, null, null, null, null, 8, "Procédure spéciale", "Collaborer avec les acteurs de la société civile, y compris les organisations de défense des droits de l’homme et les partenaires de développement, afin de mettre en place un cadre de suivi des fonds étrangers reçus par les acteurs de la société civile. Ce cadre devrait se fonder sur l’impartialité et l’objectivité, le principe de responsabilité, la transparence et l’équité, et être entièrement compatible avec la liberté d’association", "null", "", "" },
                    { 647, null, "R73P7", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 8, "Procédure spéciale", "Mettre en place un cadre tripartite, composé de représentants du Gouvernement, des partenaires de développement et de la société civile, qui soit chargé de suivre la mise en œuvre et les résultats des programmes d’aide au développement", "null", "", "" },
                    { 648, null, "R74P1", "null", "", "En cours", "", 30, 8, null, null, null, null, 8, "Procédure spéciale", "Consulter toutes les parties prenantes concernées par les programmes d’aide au développement et intégrer pleinement les approches fondées sur les droits de l’homme à tous les stades du processus, de la planification à la mise en œuvre, au suivi et à l’évaluation", "null", "", "" },
                    { 580, null, "R93P4P5", "null", "", "En cours", "", 30, 8, null, null, null, null, 5, "Procédure spéciale", @"Accélérer l’entrée en service du Fonds pour la famille et les déboursements pour aider les bénéficiaires qui sont dans le besoin
                - Renouveler le programme Tamkine et assurer sa viabilité, et faire bénéficier de ses prestations les groupes de femmes rurales et d’autres femmes marginalisées", "null", "", "" },
                    { 550, null, "R84", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", @"Étant donné que l’on ne dispose pas de données fiables au sujet de la traite, il est urgent de mettre au point un mécanisme de collecte de données sur les affaires de traite, ainsi que sur les formes de traite, les différentes manifestations de ce phénomène et les tendances observées dans ce domaine. 
                - Ces données sont essentielles à l’élaboration de mesures réfléchies de lutte contre la traite.", "null", "", "" },
                    { 527, null, "R98", "ت.98", "", "Réalisé", "", 100, 9, null, null, null, null, 3, "Procédure spéciale", "-    Le Rapporteur spécial invite la communauté internationale à appuyer le Maroc dans ses efforts pour appliquer les recommandations ci-dessus, et notamment pour reformer son système judiciaire, mettre en place un cadre de prévention de la torture et des mauvais traitements et un mécanisme national de prévention efficace et dispenser à la police et au personnel pénitentiaire la formation voulue.", "-          يطلب المقرر الخاص إلى المجتمع الدولي أن يدعم جهود المغرب الرامية إلى تطبيق التوصيات المذكورة، خاصة إصلاح نظامه القانوني، ووضع إطار للوقاية من التعذيب وسوء المعاملة، وإنشاء آلية وقائية وطنية، وتوفير التدريب المناسب لأفراد الشرطة وموظفي السجون.", "", "" },
                    { 548, null, "R82", "null", "", "Réalisé", "", 100, 8, null, null, null, null, 4, "Procédure spéciale", @"créer un organisme national qui serait chargé de coordonner les différentes activités menées par les organismes gouvernementaux dans le domaine de lutte contre la traite
                - envisager de nommer un rapporteur spécial, chargé de surveiller la mise en œuvre de la législation relative à la traite et des mesures prises dans ce domaine et de mesurer leurs effets sur la situation des droits de l’homme.", "null", "", "" },
                    { 435, null, "R72", "null", "", "En cours", "", 30, 9, null, null, null, null, 1, "Procédure spéciale", "-   Revoir régulièrement les politiques qui ont trait aux importations et aux secours d’urgence afin de garantir la sécurité alimentaire.", "null", "", "" },
                    { 436, null, "R86", "null", "", "En cours", "", 30, 9, null, null, null, null, 1, "Procédure spéciale", "-   Promouvoir la mise en place d’une budgétisation tenant compte des questions de genre comme outil permettant d’évaluer les politiques publiques du point de vue du genre", "null", "", "" },
                    { 437, null, "R96P2", "null", "", "En cours", "", 30, 9, null, null, null, null, 1, "Procédure spéciale", @"Pour les provinces marocaines du sud :
                - Suivre la mise en œuvre des programmes relatifs aux jeunes", "null", "", "" },
                    { 466, null, "R88", "null", "", "En cours", "", 30, 8, null, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit jouer un rôle de premier plan pour favoriser une meilleure compréhension des droits de l’homme en ce qui concerne le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, qui se manifestent tous même dans des sociétés comme celle du Maroc, pays dont l’identité nationale est traditionnellement marquée par la diversité et la multiculturalité.", "null", "", "" },
                    { 467, null, "R89", "null", "", "Non réalisé", "", 0, 8, null, null, null, null, 2, "Procédure spéciale", "-       Le Conseil national des droits de l’homme doit jouer un rôle moteur dans l’adoption et la mise en œuvre à l’échelle nationale d’un plan d’action pour combattre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, conformément à la Déclaration et au Programme d’action de Durban.", "null", "", "" },
                    { 468, null, "R92", "null", "", "En cours", "", 30, 8, null, null, null, null, 2, "Procédure spéciale", "-��      Le Conseil national des droits de l’homme doit poursuivre son important travail de sensibilisation au racisme, à la discrimination raciale, à la xénophobie et à l’intolérance qui y est associée, de signalement des cas et d’assistance aux victimes dans tous les contextes.", "null", "", "" },
                    { 469, null, "R70P3", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       Adopter un plan d’action national de lutte contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée.", "null", "", "" },
                    { 470, null, "R93", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       l’Union européenne et de ses États membres doivent cesser de faire pression sur les gouvernements africains pour qu’ils limitent la liberté de circulation des Africains et qu’ils fassent de la sécurisation des frontières contre les migrations une priorité en appliquant des pratiques inhumaines, notamment en ayant recours à la discrimination raciale.", "null", "", "" },
                    { 471, null, "R94", "null", "", "Non réalisé", "", 0, 9, null, null, null, null, 2, "Procédure spéciale", "-       l’Union européenne et de ses États membres doivent appliquer une approche régionale de gouvernance des migrations qui soit fondée sur les droits de l’homme et qui comprenne des voies légales de migration.", "null", "", "" },
                    { 472, null, "R95", "null", "", "En cours", "", 30, 9, null, null, null, null, 2, "Procédure spéciale", "-       Les organismes des Nations Unies chargés des questions relatives aux réfugiés et aux migrants doivent fournir d’urgence une aide humanitaire aux migrants noirs d’origine subsaharienne qui vivent dans la forêt de Tanger ainsi qu’aux autres migrants victimes de graves violations des droits de l’homme dans tout le pays, en particulier les femmes et les enfants qui sont au quotidien la cible de violences, notamment sexuelles, commises par les réseaux de passeurs et de trafiquants, entre autres.", "null", "", "" },
                    { 473, null, "R96", "null", "", "En cours", "", 30, 9, null, null, null, null, 2, "Procédure spéciale", "-       Les organismes des Nations Unies chargés des questions relatives aux réfugiés et aux migrants doivent veiller à ce qu’une approche fondée sur les droits de l’homme soit au cœur de tout le travail effectué, à l’échelle nationale et locale, auprès des migrants, des demandeurs d’asile et des réfugiés en situation régulière et irrégulière, en mettant particulièrement l’accent sur la promotion de leurs droits à la non-discrimination et à l’égalité", "null", "", "" },
                    { 549, null, "R83P1", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", "-    Mettre en place un système de détection adapté, doté de ressources suffisantes, devrait être mis en place. Ce système devrait comporter des outils et des protocoles spécifiques permettant de repérer les victimes de la traite", "null", "", "" },
                    { 515, null, "R88P7", "ت.88.ف.7", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "-    mettre en place un mécanisme d’enquête pénale et de poursuites indépendant qui n’ait aucun lien avec l’organe chargé de l’enquête ou des poursuites dans la procédure engagée contre la victime présumée; de donner effet au droit de plainte et de faire en sorte que les défendeurs qui comparaissent devant le mécanisme aient une bonne chance de formuler leurs allégations au sujet des tortures et des mauvais traitements qu’ils ont pu subir", "-          (ز) إنشاء آلية للتحقيق الجنائي والملاحقة تكون فعالة ومستقلة ولا ترتبط بالهيئة المكلفة بالتحقيق في الدعاوى المقامة على من يدعون أنهم ضحايا وبملاحقتهم؛ وإعمال الحق في الشكوى؛ والتأكد من إتاحة الفرصة أمام المدّعى عليهم الذين يمثلون أولاً أمام الآلية كي يتحدثوا عما يدعونه من تعرضهم للتعذيب أو سوء المعاملة؛", "", "" },
                    { 517, null, "R88P13", "ت.88.ف.13", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    Mettre en place des mécanismes de plainte indépendants, efficaces et accessibles dans tous les lieux de détention en installant des lignes d’assistance téléphonique ou des boîtes confidentielles de dépôt de plaintes, et de faire en sorte que chaque détenu ait un accès sans entrave et sans surveillance au procureur sur sa demande et que les plaignants ne soient pas soumis à des représailles", "-          (م) إنشاء آليات شكوى مستقلة وفعالة وميسرة في جميع أماكن الاحتجاز بواسطة تركيب خطوط هاتف مباشرة أو صناديق لوضع الشكاوى سراً، وضمان اتصال كل محتجز بالمدعي العام دون عوائق أو مراقبة بناء على الطلب، وعدم الانتقام من الشاكين؛", "", "" },
                    { 518, null, "R88P14-2", "ت.88.ف.14ج2", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    Créer un mécanisme national de prévention de la torture efficace conformément à l’article 17 du Protocole facultatif, et entamer un processus de consultation de toutes les parties prenantes sans exception, notamment les organisations de la société civile", "-          (ن)  ....إنشاء آلية وقاية وطنية فعالة وفقاً ��لمادة 17 من البروتوكول الاختياري؛ وبدء عملية تشاور يشارك فيها جميع الفاعلين المعنيين بالموضوع، مثل منظمات المجتمع المدني؛", "", "" },
                    { 519, null, "R88P15", "ت.88.ف.15", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    Ouvrir les crédits nécessaires pour doter le mécanisme national de prévention des ressources humaines et autres dont il a besoin pour inspecter régulièrement tous les lieux de détention, recevoir des plaintes, engager des poursuites et les suivre jusqu’à leur terme", "-          (س) رصد ميزانية لإمداد آلية الوقاية الوطنية بما يكفي من موارد بشرية وغيرها حتى يتسنى لها تفتيش جميع أماكن الاحتجاز بانتظام، وتلقي الشكاوى، ورفع دعاوى ومتابعتها حتى نهايتها؛", "", "" },
                    { 520, null, "R88P16", "ت.88.ف.16", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    Renforcer la confiance et la coopération entre l’État et la société civile de façon que toutes les organisations non gouvernementales soient en mesure de collaborer de manière plus efficace avec les mécanismes nationaux et internationaux et d’effectuer un travail de sensibilisation sur la base de dossiers bien documentés", "-          (ع) ترسيخ الثقة وتوثيق التعاون بين الدول والمجتمع المدني بحيث تستطيع المنظمات غير الحكومية العمل بمزيد من الفاعلية مع الآليات الوطنية والدولية، والدعوة على أساس حالات موثقة توثيقاً جيداً؛", "", "" },
                    { 522, null, "R93P4", "ت.93.ف.4", "", "Réalisé", "", 100, 8, null, null, null, null, 3, "Procédure spéciale", "Exercer un contrôle judiciaire sur les établissements pénitentiaires ; - Renforcer les pouvoirs des juges d’application de façon à leur permettre de contrôler de manière effective ces établissements, de surveiller l’application des peines et de vérifier leur validité ; - Renforcer le droit d’appel des personnes soumises à des mesures disciplinaires", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي: -  (د) فرض المراقبة القضائية على الإصلاحيات؛ وتدعيم سلطات القضاة المكلفين بتنفيذ الأحكام بحيث يستطيعون مراقبة تلك المؤسسات بفعالية، ورصد إنفاذ العقوبات، والتحقيق في صلاحيته؛ وتعزيز حق المتضررين من الإجراءات التأديبية في الاستئناف؛", "", "" },
                    { 523, null, "R93P5", "ت.93.ف.5", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    faciliter la surveillance exercée par les commissions régionales, au moyen d’inspections régulières et effectives des prisons et de la présentation de rapports sur la situation des prisons et des prisonniers, de façon à améliorer la situation dans les prisons et à donner effet aux droits des prisonniers ;", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:   (ﻫ) تسهيل الرصد الذي تتولاه اللجان الإقليمية لتحسين الأوضاع في السجون، وإعمال حقوق السجناء، عن طريق الزيارات المنتظمة والفعالة إلى السجون، وتقديم التقارير عن أوضاع السجون والسجناء؛", "", "" },
                    { 524, null, "R94P2", "ت.94.ف. 2", "", "Réalisé", "", 100, 8, null, null, null, null, 3, "Procédure spéciale", "-    Pour ce qui est des établissements psychiatriques, faire en sorte que le Bureau du Procureur général et le 4 effectuent des visites dans les établissements psychiatriques comme prévu par la loi.", "بخصوص المصحات النفسية، يوصي المقرر الخاص الحكومة بما يلي: (ب) زيارة النيابة العامة والمجلس الوطني لحقوق الإنسان المصحات النفسية، عملاً بالقانون.", "", "" },
                    { 525, null, "R95P1", "ت.95.ف.1", "", "Réalisé", "", 100, 8, null, null, null, null, 3, "Procédure spéciale", "-    Faire en sorte que les plus hautes autorités, en particulier celles qui sont responsables de l’application de la loi, déclarent sans équivoque qu’elles ne toléreront pas le recours à la torture ou aux mauvais traitements par leurs subordonnés et que les auteurs de tels actes auront à en rendre compte ;", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي: (أ) السعي إلى أن تعلن أعلى السلطات، خاصة المعنية بأنشطة إنفاذ القوانين، بكامل الوضوح أنها لن تتساهل مع ممارسة المرؤوسين التعذيب أو إساءتهم المعاملة، ومساءلة الجناة؛", "", "" },
                    { 526, null, "R97P4", "ت.97.ف.4", "", "Non réalisé", "", 0, 8, null, null, null, null, 3, "Procédure spéciale", "En ce qui concerne les provinces marocaines du Sud -  L’établissement d’un mécanisme régional intergouvernementales de surveillance des droits de l’homme, robuste, comme une mesure importante visant à instaurer la confiance et qui peut contribuer à améliorer la situation en ce qui concerne le respect des droits de l’homme et, en particulier, l’interdiction de la torture et autres peines ou traitements cruels, inhumains ou dégradants.", "فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي: (د)  من شأن المنطقة بكاملها أن تستفيد من إنشاء آلية حكومية دولية إقليمية متينة لحقوق الإنسان بوصفها إجراء مهماً لبناء الثقة قد يساعد على تحسين وضع التقيد بحقوق الإنسان، خاصة ما يتعلق بحظر التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 546, null, "R95P2", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", "-    …De nouvelles mesures devraient être prises pour que les victimes de la traite qui ont besoin d’une protection internationale soient dûment identifiées et aiguillées vers le système d’asile, selon que de besoin.", "null", "", "" },
                    { 547, null, "R81", "null", "", "En cours", "", 30, 8, null, null, null, null, 4, "Procédure spéciale", "-    Mettre au point, d’entente avec toutes les parties prenantes, notamment les organisations de la société civile, un plan national d’action qui définisse clairement les objectifs à atteindre et les responsabilités de chacun et fixe des indicateurs clairs permettant de mesurer les progrès accomplis et l’efficacité des mesures prises pour lutter contre la traite des êtres humains", "null", "", "" },
                    { 516, null, "R88P12", "ت.88.ف.12", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    Fournir au Ministère de l’26 tout le soutien logistique et financier nécessaire pour lui permettre d’appliquer le projet envisagé par le Ministère de la justice et des libertés visant à effectuer un enregistrement vidéo de toutes les déclarations faites à la police pendant l’enquête et l’interrogatoire. De telles mesures ne doivent pas se substituer à la représentation légale pendant toutes les phases de l’interrogatoire mais la compléter", "-          (ل) إمداد وزارة الداخلية بكل الدعم اللوجستي والمالي اللازم لتنفيذ مشروع وزير العدل والحريات الداعي إلى تسجيل جميع بيانات الشرطة بالصورة والصوت أثناء التحقيق والاستجواب. وينبغي النظر إلى هذا الأسلوب على أنه يكمل التمثيل القضائي في جميع مراحل الاستجواب؛", "", "" },
                    { 521, null, "R88P17", "ت.88.ف.17", "", "En cours", "", 30, 8, null, null, null, null, 3, "Procédure spéciale", "-    Faciliter l’accès des organisations de la société civile aux établissements pénitentiaires et de renforcer le partenariat avec ces institutions pour qu’elles puissent jouer leur rôle de sensibilisation et de propagation de la culture des droits de l’homme et contribuer à l’amélioration de la formation des superviseurs et du personnel des établissements pénitentiaires.", "-          (ف) تسهيل زيارة منظمات المجتمع المدني الإصلاحيات، وتوطيد الشراكة معها لمساعدتها على أداء دورها في التوعية، ونشر ثقافة حقوق الإنسان، والمساهمة في الارتقاء بمستوى تدريب المشرفين عليها وموظفيها.", "", "" },
                    { 650, null, "R73P1-1", "null", "", "En cours", "", 30, 9, null, null, null, null, 8, "Procédure spéciale", "Fournir des informations simplifiées et largement accessibles sur les accords internationaux signés par le Maroc, notamment les accords économiques et commerciaux, et l’incidence de ces accords sur la population marocaine. Ces informations ne devraient pas être seulement accessibles sur des sites Web, afin de ne pas exclure ceux qui n’ont pas accès à Internet.", "null", "", "" },
                    { 244, null, "R21P3P4", "ت.21.ف3.ف.4", "", "En cours", "", 30, 8, null, 6, null, null, null, "Organes de traités", @"Entreprendre des études sur les causes et l’ampleur de la violence à l’égard des femmes et des filles, y compris la violence sexuelle et la violence dans la famille. 
                - Recueillir des données ventilées sur toutes les formes de violence à l’égard des femmes,", @"إجراء دراسات عن أسباب العنف الموجه ضد النساء والفتيات ونطاقه، بما في ذلك العنف الجنسي والأسري. 
                -جمع بيانات مصنفة عن جميع أشكال العنف ضد المرأة،", "", "" },
                    { 312, null, "R67", "ت.67", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", "Mettre en place une coordination Trans sectorielle et de procéder à des interventions multidisciplinaires, auxquelles participeraient de nombreuses parties prenantes à différents niveaux, afin de faire en sorte que les enfants des rues soient convenablement vêtus, logés, soignés et bénéficient de possibilités d’éducation, notamment d’une formation pour l’acquisition de compétences professionnelles ou pour la vie quotidienne, de façon à favoriser leur plein développement.", "-          إنشاء تنسيقية متعددة القطاعات وإجراء تدخلات متعددة التخصصات يشارك فيها فاعلون عدة من مستويات شتى بحيث يوفَّر لأطفال الشوارع الغذاء الكافي والملبس الكريم والسكن اللائق والرعاية الصحية الملائمة وفرص التعليم المناسبة، بما فيها التدريب المهني والتدريب على المهارات الحياتية، وذلك لدعم نمائهم الكامل.", "", "" },
                    { 311, null, "R65 P3", "ت.65.ف.3", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", "c) Renforcer l’inspection du travail, autoriser, par la loi, les inspecteurs à entrer chez les particuliers et accorder la priorité à des interventions visant à faire cesser l’exploitation économique des enfants", "-           (ج) تدعيم تفتيش العمل وتخويل المفتشين، قانوناً، دخول المنازل الخاصة وترتيب تدخلاتهم حسب الأولوية لإنقاذ الأطفال من الاستغلال الاقتصادي؛", "", "" },
                    { 310, null, "R53P1", "ت.53.ف.1", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"Compte tenu de l’article 23 de la Convention et de son Observation générale no 9 (2006) sur les droits des enfants handicapés, le Comité demande instamment au Maroc d’adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier:
                a) D’organiser la collecte de données sur les enfants handicapés et de mettre en place un système efficace de diagnostic du handicap, qui est nécessaire pour élaborer des politiques et des programmes en faveur des enfants handicapés;", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                - (أ) تنظيم جمع البيانات عن الأطفال ذوي الإعاقة ووضع نظام تشخيص يتسم بالكفاءة، وهو أمر ضروري لوضع سياسات وبرامج تلائم الأطفال ذوي الإعاقة", "", "" },
                    { 309, null, "R51P3P4P5", "ت.51.ف.3.ف.4.ف5", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité recommande au Maroc:
                c) D’assurer un suivi approprié des enfants placés sous le régime de la kafalah;
                d) De prendre toutes les mesures nécessaires pour prévenir et punir l’exploitation d’enfants par le biais du système de la kafalah;
                e) Abroger la circulaire 40S/2 de 2012.", @"(ج) ضمان متابعة صحيحة الأطفال المكفولين؛ 
                - (د) اتخاذ جميع التدابير اللازمة لمنع استغلال الأطفال من خلال نظام الكفالة ومعاقبة الجناة؛ 
                - (هـ) إلغاء المنشور رقم 40/س2 الصادر في عام 2012.", "", "" },
                    { 308, null, "R49P1P3P4P6P7P8P9", "ت.49.ف.1.ف3.ف.4.ف.6.ف.7.ف8.ف.9", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"Appelant l’attention sur les lignes directrices relatives à la protection de remplacement pour les enfants (résolution 64/142 de l’Assemblée générale, annexe), le Comité demande au Maroc:
                a) De faire en sorte que la pauvreté financière et matérielle ou les situations qui en résultent directement et exclusivement ne soient jamais l’unique raison de retirer un enfant à ses parents, de placer l’enfant dans une structure de protection de remplacement ou d’empêcher la réinsertion sociale de l’enfant;
                c) De renforcer les mécanismes de détection précoce des enfants vivant dans des conditions difficiles et de mettre en place des programmes de soutien aux parents et aux mères célibataires, ainsi que des programmes communautaires, en vue de réduire rapidement le recours au placement d’enfants en institution;
                d) De soutenir l’Entraide nationale, qui est chargée d’appliquer la loi no 14 05, et d’allouer les ressources nécessaires au projet de réforme des établissements de protection sociale lancé en 2012 en vue d’améliorer les conditions de vie des enfants placés en institution;
                f) De procéder périodiquement à un examen approfondi des placements d’enfants en institution et de créer des mécanismes pour recevoir et examiner les plaintes émanant d’enfants;
                g) De prendre toutes les mesures nécessaires pour réduire la durée du séjour des enfants en institution et de faire en sorte qu’ils ne soient plus séparés de leurs frères et sœurs et transférés d’un centre à un autre et que leur soit assuré un environnement stable qui favorise l’instauration et le maintien de relations constructives avec les adultes et les enfants;
                h) De faciliter, lorsque l’intérêt supérieur de l’enfant le requiert, les contacts entre l’enfant et sa famille biologique de façon à encourager et à appuyer le regroupement lorsqu’il est possible;
                i) De retirer d’urgence des hôpitaux les enfants abandonnés qui continuent d’y vivre et faire en sorte qu’ils puissent bénéficier d’un placement de type familial.", @"تلفت اللجنة انتباه المملكة المغربية إلى المبادئ التوجيهية للرعاية البديلة للأطفال (مرفق قرار الجمعية العامة 64/142) وحثتها على ما يلي: 
                - (أ) ضمان ألا يكون الفقر المالي والمادي أو الظروف المنسوبة مباشرة وحصراً إلى هذا الفقر أبداً المبرر الأوحد لحرمان طفل من رعاية الوالدين أو قبوله في مؤسسة للرعاية البديلة أو منعه من الاندماج في المجتمع مجدداً؛ 
                -  (ج) ترسيخ آليات الكشف المبكر عن الأطفال الذين يعانون ظروفاً صعبة، ووضع برامج لدعم الوالدين والأمهات غير المتزوجات والبرامج المجتمعية بهدف التعجيل بالحد من إيداع الأطفال في المؤسسات؛ 
                - (د) دعم التعاون الوطني، المكلف بتنفيذ القانون رقم 14-05، وتخصيص الموارد اللازمة لمشروع إصلاح مؤسسات الحماية الاجتماعية الذي استُهل في عام 2012 لتحسين ظروف معيشة الأطفال المودعين في المؤسسات؛ 
                -  (و) إجراء مراجعة شاملة ودورية لمسألة إيداع الأطفال في مؤسسات الرعاية، وإنشاء آليات لتلقي شكاوى الأطفال والبت فيها؛
                - (ز) اتخاذ جميع التدابير اللازمة لتقليص مدة بقاء الأطفال في المؤسسات، وضمان عدم فصلهم أبداً عن أشقائهم ونقلهم من مركز إلى آخر، وتوفير الرعاية لهم في بيئة مستقرة تلائم إقامة علاقات إيجابية مع البالغين والأطفال والحفاظ عليها؛
                - (ح) تيسير الاتصال بين الطفل وأسرته البيولوجية، متى كان ذلك يصب في مصلحته العليا، لتشجيع لمّ الشمل ودعمه ما أمكن؛
                (ط) نقل الأطفال المهملين من المستشفيات على جناح السرعة، وضمان إمكان إيداعهم في إطار شبيه بالأسرة", "", "" },
                    { 306, null, "R39P1P3P4P6", "ت.39.ف.1.ف.3.ف4.ف.6", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité recommande au Maroc de tenir compte de l’Observation générale no 13 (2011) sur le droit de l’enfant d’être protégé contre toutes les formes de violence, et en particulier de mettre en place, en étroite coopération avec la société civile, un système de protection des enfants bien coordonné et bien financé. Le Maroc devrait en particulier:
                a) Créer une base de données nationale sur tous les cas de violence dans la famille à l’égard des enfants et procéder à une évaluation complète de l’ampleur, des causes et de la nature d’une telle violence;
                c) Prendre d’urgence des mesures pour régler le problème que posent les conditions de vie des enfants se trouvant dans les centres de sauvegarde, faire sortir sans délai de ces centres les enfants marginalisés et défavorisés et faire en sorte qu’ils bénéficient de programmes de placement auprès d’un parent ou d’une institution et retrouvent leur famille lorsque leur intérêt supérieur le requiert;
                d) Mettre rapidement en place des groupes de protection des enfants et appuyer ces groupes dans les hôpitaux et les postes de police des lieux où il n’en existe pas encore, en particulier dans les zones rurales et les régions reculées, et établir des mécanismes de recours dans les institutions de protection de remplacement et les centres de détention et doter tous ces mécanismes des ressources humaines, financières et techniques nécessaires pour leur permettre de protéger efficacement les enfants contre toutes les formes de violence;
                f) Continuer de fournir des subventions aux organisations non gouvernementales spécialisées qui exécutent des programmes de prévention et de réadaptation en faveur des enfants qui risquent d’être victimes de la violence;
                :", @"الأخذ في الحسبان التعليق العام  رقم 13(2011) بشأن حق الطفل في التحرر من جميع أشكال العنف، ووضع نظاماً لحماية الطفل منسقاً تنسيقاً جيداً وممولاً تمويلاً كافياً بتعاون وثيق مع المجتمع المدني و الاضطلاع بما يلي خاصةً:
                - (أ) إنشاء قاعدة بيانات وطنية تضم جميع حالات العنف المنزلي الممارس على الأطفال، وإجراء تقييم شامل لمدى انتشار هذا العنف وأسبابه وطبيعته؛ 
                -  (ج) اتخاذ تدابير عاجلة لمعالجة الأوضاع المعيشية للأطفال في مراكز حماية الطفولة، ونقل الأطفال المهمشين والمحرومين من هذه المراكز دون إبطاء، وضمان استفادتهم من برامج رعاية ذوي القربى والحضانة ولمّ شملهم بأسرهم متى كان ذلك يصب في مصلحتهم العليا؛
                - (د) المسارعة إلى إنشاء وحدات لحماية الأطفال ووحدات دعم في المستشفيات ومراكز الشرطة في المناطق التي لم تُنشأ فيها بعد، ولا سيما في المناطق الريفية والنائية، وإنشاء آليات تظلم في مؤسسات الرعاية البديلة ومراكز الاحتجاز، وإمداد جميع هذه الآليات بما يلزم من موارد بشرية ومالية وتقنية كي يتسنى لها حماية الأطفال من جميع أشكال العنف بفاعلية؛
                -  (و) مواصلة تقديم المنح إلى المنظمات غير الحكومية المتخصصة التي تنفذ برامج الوقاية وإعادة التأهيل للأطفال المعرضين للعنف أو ضحاياه؛", "", "" },
                    { 305, null, "R29P1", "ت.29.ف.1", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 12 (2009) sur le droit de l’enfant d’être entendu et lui recommande:
                a) De revoir les critères d’éligibilité au 32des enfants en vue d’assurer que les enfants soient élus par leurs pairs dans le cadre d’un processus démocratique et que les enfants de tous les segments de la société soient dûment représentés", @"تلفت اللجنة انتباه الدولة الطرف إلى تعليقها العام رقم 12(2009) بشأن حق الطفل في أن يُستمع إليه، وتوصيها بالآتي:   
                (أ) إعادة النظر في معايير الأهلية لبرلمان الأطفال بحيث يَنتخب الأطفالَ قرناؤهم بواسطة عملية ديمقراطية ويمثَّل أطفال جميع فئات المجتمع فعلياً؛", "", "" },
                    { 304, null, "R27", "ت.27", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 14 (2013) sur le droit de l’enfant à ce que son intérêt supérieur soit une considération primordiale, et lui recommande de redoubler d’efforts pour faire en sorte que ce droit soit dûment intégré et appliqué uniformément dans toutes les procédures législatives, administratives et judiciaires, ainsi que dans la totalité des politiques, programmes et projets concernant les enfants et ayant un impact sur eux. 
                - Le Maroc est encouragé à définir des procédures et des critères destinés à guider toutes les personnes investies d’une autorité pour déterminer l’intérêt supérieur de l’enfant dans chaque domaine et lui attribuer le poids voulu en tant que considération primordiale.", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 14(2013) بشأن حق الطفل في إيلاء الاعتبار الأول لمصالحه الفُضلى، وتوصيها بتعزيز جهودها بحيث يراعى هذا الحق حق المراعاة ويطبق دوماً في جميع الإجراءات التشريعية والإدارية والقضائية وفي السياسيات والبرامج والمشاريع التي تعني الأطفال وتؤثر فيهم.
                تشجع اللجنة المملكة المغربية في هذا الصدد على وضع إجراءات ومعايير لتوجيه جميع الأشخاص المعنيين من أصحاب السلطة لتحديد مصالح الطفل الفضلى في كل المجالات ولجعلها تتصدر قائمة الأولويات.", "", "" },
                    { 303, null, "R25P3", "ت.25.ف.3", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", "c) faire en sorte que la politique intégrée de l’enfance actuellement en cours d’élaboration aborde en priorité la situation des enfants les plus marginalisés ou défavorisés et, notamment, les différents types de discrimination dont sont victimes les filles, les enfants handicapés et les enfants vivant dans les zones rurales et les régions reculées.", "-           (ج) التأكد من أن السياسة المندمجة للطفولة قيد الإعداد تولي الأولوية لوضع الأطفال الأكثر تهميشاً وحرماناً، خاصة أنواع التمييز المتعددة التي تعانيها الفتيات والأطفال ذوو الإعاقة والأطفال ا��ذين يعيشون في المناطق الريفية والنائية.", "", "" },
                    { 302, null, "R23 P2", "ت.23.ف.2", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande:
                b) D’établir des mécanismes de surveillance pour faire en sorte que les violations des droits de l’enfant fassent l’objet d’enquêtes et donnent lieu à des réparations de façon à améliorer le respect de l’obligation de rendre des comptes et la transparence", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي:
                (ب) إنشاء آليات رصد للتحقيق في انتهاكات حقوق الطفل و جبر الأضرار المترتبة عليها، و ذلك بهدف تعزيز المسؤولية و الشفافية؛", "", "" },
                    { 301, null, "R21", "ت.21", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", @"Renforcer le cadre de coopération avec les organisations qui s’occupent des enfants lors de l’élaboration, de l’application et d’évaluation des décisions et projets en faveur des enfants, comme le prévoit le paragraphe 3 de l’article 12 de la Constitution, et de songer, à cette fin, à établir un cadre officiel de coopération avec les organisations de la société civile. 
                - faire en sorte que les organisations de la société civile, qui jouent un rôle important en la matière, continuent de bénéficier d’un soutien public qui leur permette de mener une action cohérente et durable en faveur des enfants, tout en renforçant la capacité de répondre aux besoins de protection des enfants.", @"توطيد إطار التعاون مع منظمات حقوق الطفل عند وضع القرارات والمشاريع المتعلقة بالأطفال وتنفيذها وتقييمها، تمشياً مع الفقرة 3 من المادة 12 من الدستور، 
                - النظر، لهذا الغرض، في إنشاء إطار رسمي للتعاون مع منظمات المجتمع المدني. 
                - مواصلة الدولة  دعمها المالي لمنظمات المجتمع المدني التي تؤدي خدمات جليلة في ذلك الصدد بحيث تكون الأنشطة التي يستفيد منها الأطفال متسقة ومستدامة", "", "" },
                    { 300, null, "R19", "ت.19", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", "Prendre des mesures en vue d’adopter rapidement la loi portant réforme du mandat du Conseil national des droits de l’homme de façon à créer un mécanisme spécialisé dans la surveillance des droits de l’enfant habilité à recevoir les plaintes émanant d’enfants, à enquêter sur ces plaintes et les traiter dans le respect de la sensibilité de l’enfant.", "-           الإسراع باتخاذ تدابير على وجه السرعة لاعتماد القانون الذي يعدّل ولاية المجلس الوطني لحقوق الإنسان بغية إنشاء آلية محددة لرصد حقوق الطفل يمكنها تلقي شكاوى الأطفال والتحقيق فيها ومعالجتها بطريقة ملائمة للطفل.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 299, null, "R17", "ت.17", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"Dans l’optique des articles 2, 3, 4 et 6 de la Convention, le Comité recommande au Maroc:
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
                    { 298, null, "R15", "ت.15", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"Coordonner de manière effective et efficace l’application de toutes les dispositions de la Convention, ainsi que la politique intégrée de l’enfance, à la fois entre les ministères et entre les autorités nationales, régionales et locales. 
                - Doter l’organe de coordination des ressources humaines, techniques et financières dont il a besoin pour opérer efficacement, et devrait nommer des autorités pour assurer cette coordination aux niveaux régional et local", @"العمل على تنسيق وتنفيذ جميع أحكام الاتفاقية بفاعلية وكفاءة ، بما في ذلك السياسة المندمجة لحماية الطفولة، سواء فيما بين الوزارات              أو فيما بين السلطات الوطنية والإقليمية والمحلية. 
                - تأمين الموارد البشرية والتقنية والمالية اللازمة لهيئة التنسيق لإدارة عملياتها بفاعلية
                -  إنشاء  هيئات إقليمية ومحلية لهذا الغرض.", "", "" },
                    { 313, null, "R77P1", "ت.77.ف.1", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", "-                    Prendre toutes les mesures voulues pour donner pleinement effet aux recommandations qui figurent dans les présentes observations finales.", "اتخاذ جميع التدابير المناسبة لضمان تنفيذ التوصيات الواردة في هذه الملاحظات الختامية تنفيذاً تاماً.", "", "" },
                    { 297, null, "R13", "ت.13", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", @"Faire en sorte que la politique intégrée en faveur de l’enfance englobe la protection des enfants et s’étende à tous les domaines visés par la Convention et tous les enfants, une attention particulière devant être accordée aux plus vulnérables et aux plus défavorisés d’entre eux. 
                - Etablir, sur la base de cette politique et en partenariat avec les organisations de la société civile, les stratégies requises pour son application, et de consacrer suffisamment de ressources humaines, techniques et financières à cet objectif.", @"الحرص على أن تشمل السياسية المندمجة لحماية الطفولة حماية الأطفال وكل المجالات التي تغطيها الاتفاقية، وكذلك جميعَ الأطفال، على أن يحظى أضعف الأطفال وأشدهم حرماناً باهتمام خاص.
                - توصي اللجنة المملكة المغربية بأن ترسم، بناء على هذه السياسة وفي إطار الشراكة مع منظمات المجتمع المدني، استراتيجيات مناسبة لتنفيذها، وبأن تخصص لهذا الغرض الموارد البشرية والتقنية والمالية الكافية.", "", "" },
                    { 243, null, "R11P4", "ت.11.ف.4", "", "Réalisé", "", 100, 8, null, 6, null, null, null, "Organes de traités", "Prévoir des procédures précises pour le dépôt des plaintes pour discrimination à l’égard des femmes, des sanctions correspondant à ces actes de discrimination et des voies de recours efficaces pour les femmes dont les droits ont été bafoués.", "وضع إجراءات واضحة لتقديم الشكاوى بشأن التمييز ضد المرأة، والتنصيص على جزاءات كافية لأفعال التمييز، وتكفل إتاحة سبل الانتصاف الفعالة للنساء اللائي انتهكت حقوقهن", "", "" },
                    { 195, null, "R28P4", "ت.28.ف4.", "", "En cours", "", 30, 7, null, 5, null, null, null, "Organes de traités", @"Prendre des mesures et intensifier les efforts visant à remédier d’urgence aux problèmes des mauvais traitements et autres actes de violence commis contre les travailleurs migrants et les membres de leur famille, quels que soient les auteurs de ces actes. En particulier, le Comité recommande au Maroc: 
                d) Organiser, pour les fonctionnaires de police et les agents de contrôle aux frontières, des formations sur le respect des droits de l’homme, le non-usage de la violence et plus particulièrement sur le contenu de la Convention.", @"اتخاذ تدابير بتكثيف الجهود في سبيل الإسراع في معالجة مشاكل سوء المعاملة وغير ذلك من أعمال العنف المرتكبة في حق العمال المهاجرين وأفراد أسرهم، أياً كان مرتكبوها. وعلى وجه الخصوص، توصي اللجنة الدولة الطرف باتخاذ التدابير التالية: 
                 (د) تدريب موظفي الشرطة ومراقبة الحدود على احترام حقوق الإنسان وعدم استعمال العنف، وبخاصة على محتوى الاتفاقية.", "", "" },
                    { 194, null, "R30P2", "ت.30.ف2.", "", "En cours", "", 30, 7, null, 5, null, null, null, "Organes de traités", "Mener des campagnes de sensibilisation auprès des praticiens de la santé sur les droits des travailleurs migrants.", "تنظيم حملات لتوعية العاملين في قطاع الصحة بحقوق العمال المهاجرين.", "", "" },
                    { 193, null, "R48P5", "ت.48.ف5.", "", "Réalisé", "", 100, 7, null, 5, null, null, null, "Organes de traités", @"Rendre les mesures nécessaires pour que la stratégie nationale de lutte contre le trafic des êtres humains comprenne notamment les mesures suivantes :
                 e) Renforcer la formation des policiers et autres membres des forces de l’ordre, des juges et des procureurs, des inspecteurs du travail, des enseignants ainsi que du personnel des services de santé, des ambassades et des consulats de l’État partie.", @"اتخاذ التدابير اللازمة كي تتضمن الاستراتيجية الوطنية لمحاربة الاتجار بالبشر التدابير التالية على وجه الخصوص:
                 (ﻫ) تعزيز تدريب الشرطة وسائر أفراد قوات حفظ النظام والقضاة وأعضاء النيابة العامة ومفتشي العمل والمدرسين والعاملين في قطاع الصحة وفي سفارات الدولة الطرف وقنصلياتها.", "", "" },
                    { 192, null, "R18P1P3", "ت.18.ف1.ف3.", "", "En cours", "", 30, 7, null, 5, null, null, null, "Organes de traités", @"a) Intensifier de manière concrète la formation de tous les fonctionnaires qui travaillent dans le domaine des migrations de travail, en particulier les fonctionnaires de police et les agents de contrôle aux frontières, ainsi que les fonctionnaires s’occupant des travailleurs migrants au niveau local et les agents consulaires;
                c) Poursuivre la collaboration avec les organisations de la société civile pour diffuser et promouvoir la Convention.", @"(أ) العمل على تكثيف تدريب جميع الموظفين العاملين في مجال الهجرة لأغراض العمل على نحو ملموس، لا سيما موظفو الشرطة ومراقبة الحدود، وكذلك الموظفون المعنيون على الصعيد المحلي بالعمال المهاجرين وموظفو القنصليات؛
                (ج) مواصلة التعاون مع منظمات المجتمع المدني من أجل نشر الاتفاقية وترويجها.", "", "" },
                    { 164, null, "R34P3", "ت.34.ف.3", "", "Réalisé", "", 100, 9, null, 4, null, null, null, "Organes de traités", "-             En attendant la promulgation de ces lois, le Comité invite l’État partie à faciliter la constitution des syndicats sur la base de l’article 8 du Pacte.", "-          تيسير تكوين النقابات استناداً إلى المادة 8 من العهد ريثما تسن هذه القوانين.", "", "" },
                    { 163, null, "R16", "ت.16", "", "Réalisé", "", 100, 9, null, 4, null, null, null, "Organes de traités", @"Combattre toute discrimination ou stigmatisation contre les lesbiennes, les gays, les bisexuels et les transgenres fondée sur leur orientation sexuelle et 
                - punir les auteurs de violence motivée par la haine envers ces personnes. Le Comité lui recommande enfin de veiller à ce que ces personnes puissent exercer tous les droits consacrés par le Pacte", @"مكافحة أي شكل من أشكال التمييز أو الوصم ضد المثليات والمثليين ومزدوجي الميل الجنسي ومغايري الهوية الجنسانية القائم على أساس ميلهم الجنسي، ومعاقبة مرتكبي أعمال العنف بدافع كره أولئك الأشخاص. 
                - الحرص على تمكين هؤلاء الأشخاص من ممارسة جميع الحقوق المكرسة في العهد", "", "" },
                    { 123, null, "R36P6", "ت.36.ف.6", "", "Réalisé", "", 100, 8, null, 3, null, null, null, "Organes de traités", "e) prévenir et éliminer le recours excessif à la force par les agents des forces de l’ordre en renforçant notamment les mécanismes de contrôle et de responsabilisation (migrants et demandeurs d’asil);", "-           (ه) منع لجوء قوات الأمن في استخدام القوة المفرطة و التخلص من هذه الممارسة، لا سيما بتدعيم آليات المراقبة والمساءلة؛", "", "" },
                    { 122, null, "R24P5", "ت.24.ف5", "", "Réalisé", "", 100, 8, null, 3, null, null, null, "Organes de traités", "Accélérer le processus d’adoption de la loi établissant le mécanisme national de prévention de la torture.", "-           (ه) تسريع عملية اعتماد القانون المنشئ للآلية الوطنية لمنع التعذيب.", "", "" },
                    { 86, null, "R22P1P2", "ت.22.ف.1.ف.2", "", "En cours", "", 30, 8, null, 2, null, null, null, "Organes de traités", @"S’assurer que le mécanisme national de contrôle et de surveillance des lieux de détention qui doit être prochainement établi soit également compétent pour inspecter les autres lieux de privation de liberté, tels que les hôpitaux psychiatriques. En outre, il devrait faire en sorte qu’il soit donné suite aux résultats de ce processus de contrôle. 
                - Le mécanisme en question devrait prévoir des visites périodiques et inopinées de manière à prévenir la torture et autres peines ou traitements cruels, inhumains ou dégradants.", @"التأكد   من قدرة الآلية الوطنية لرصد ومراقبة مرافق الاحتجاز، التي يجب أن تنشأ قريباً، وعلى تفتيش أماكن الاحتجاز الأخرى، مثل مستشفيات الأمراض النفسانية.
                -  كفالة متابعة نتائج عملية الرصد التي وينبغي أن تشمل آلية الوطنية لرصد ومراقبة مرافق الاحتجاز زيارات دورية ومفاجئة من شأنها أن تمنع حدوث التعذيب وغيره من ضروب المعاقبة أو المعاملة القاسية أو اللاإنسانية أو المهينة", "", "" },
                    { 85, null, "R18P1P2", "ت.18.ف.1.ف.2", "", "En cours", "", 30, 8, null, 2, null, null, null, "Organes de traités", @"S’assurer que le mécanisme national de contrôle des lieux de détention soit en mesure d’assurer une surveillance et une inspection effectives de tous les lieux de détention, et qu’une suite soit donnée aux résultats de ces contrôles.
                - Ledit mécanisme devrait prévoir les visites périodiques et inopinées des observateurs nationaux et internationaux de sorte de prévenir la torture et autres peines ou traitements cruels, inhumains ou dégradants", @"ا التأكد من قدرة الآلية الوطنية لرصد أماكن الاحتجاز على ضمان مراقبة جميع أماكن الاحتجاز وتفتيشها بفعالية، ومتابعة نتائج التفتيش هذه.
                - تضمين الآلية المذكورة زيارات دورية ومفاجئة يقوم بها مراقبون وطنيون ودوليون لمنع حدوث التعذيب وغيره من ضروب العقوبة أو المعاملة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 84, null, "R6P3P4", "ت.6.ف.3.ف4", "", "Non réalisé", "", 0, 8, null, 2, null, null, null, "Organes de traités", @"Prévoir l’interdiction de toute amnistie éventuelle des crimes de torture et de tout pardon en violation de la Convention, notamment par : 
                - L’instauration d’un mécanisme visant à protéger les subordonnés qui refusent d’obéir aux ordre des supérieurs ou d’une autorité publique qui peuvent être invoqués pour justifier la torture
                - Diffuser l’interdiction d’obéir audits ordres ainsi que les mécanismes de protection y afférents auprès de l’ensemble des forces de l’ordre", @"إنشاء آلية تهدف إلى حماية المرؤوسين الذين يرفضون الانصياع لمثل أوامر رؤسائهم التي قد تبرر ممارسة التعذيب   
                - نشر حظر الانصياع لمثل هذا الأمر وآليات الحماية المتصلة به على نطاق واسع في أوساط جميع قوات إنفاذ القانون", "", "" },
                    { 32, null, "R19", "ت.19", "", "Réalisé", "", 100, 8, null, 1, null, null, null, "Organes de traités", "veiller à la pleine application des articles 21, 73, 74 et 120 du Code de procédure pénale, afin de garantir un service d’interprétation, notamment en procédant à la formation de plus d’ interprètes assermentés, et de s’assurer que des justiciables appartenant à des catégories vulnérables et ne parlant pas l’arabe, notamment les amazighs, les saharawis, les noirs, les migrants, les réfugiés, les demandeurs d’asile, puissent bénéficier d’une bonne administration de la justice.", "ضمان التطبيق الكامل للمواد 21 و73 و74 و120 من قانون المسطرة الجنائية وبأن تكفل خدمات الترجمة الفورية، خاصة عن طريق تدريب عدد أكبر من المترجمين الفوريين المحلفين، وضمان استفادة المتقاضين من الفئات الضعيفة غير المتحدثة باللغة العربية من نظام جيد لإقامة العدل، لا سيما منهم الأمازيغ والصحراويون والزنوج والمهاجرون واللاجئون وطالبو اللجوء.", "", "" },
                    { 31, null, "R18P3", "ت.18.ف.3", "", "Non réalisé", "", 0, 8, null, 1, null, null, null, "Organes de traités", "Envisager d’adopter la méthode du «testing» pour récolter des preuves de discrimination raciale.", "التفكير في اعتماد أسلوب 'الاختبار' للحصول على أدلة على التمييز العنصري.", "", "" },
                    { 649, null, "R74P2", "null", "", "En cours", "", 30, 8, null, null, null, null, 8, "Procédure spéciale", @"Assurer l’égalité des chances en ce qui concerne l’accès des acteurs de la société civile aux fonds d’aide au développement, s’agissant en particulier des organisations locales des zones rurales et reculées, qui sont souvent exclues par manque d’accès à l’information. 
                - Envisager de modifier la procédure actuelle d’appel à propositions, en tenant compte de la situation dans les zones reculées où il n’y a pas d’accès à Internet", "null", "", "" },
                    { 314, null, "R75P5", "ت.75.ف.5", "", "En cours", "", 30, 7, null, 7, null, null, null, "Organes de traités", @"mettre le système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs, en particulier:
                e) Mettre en place des programmes de réinsertion sociale dûment financés pour les enfants en conflit avec la loi", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                -  (ه) وضع برامج إدماج اجتماعي ممولة تمويلاً كافياً للأطفال الجانحين؛", "", "" },
                    { 307, null, "R47P2", "ت.47.ف.2", "", "Réalisé", "", 100, 7, null, 7, null, null, null, "Organes de traités", "-…élaborer et appliquer une politique pour protéger les droits des adolescentes enceintes et de leurs enfants……….", "-          ووضع وتنفيذ سياسة لحماية حقوق المراهقات الحوامل والمراهقات الأمهات وأطفالهن،", "", "" },
                    { 1211, null, "R144.54", "54.144", "", "Réalisé", "", 100, 8, 1, null, 10, null, null, "Examen périodique universal", "Créer un mécanisme national pour la protection des droits des personnes handicapées", "إنشاء آلية وطنية لحماية حقوق الأشخاص ذوي الإعاقة", "", "" },
                    { 1220, null, "R144.37", "37.144", "", "Réalisé", "", 100, 9, 1, null, 97, null, null, "Examen périodique universal", "Poursuivre ses mesures visant à consolider les principes des droits de l’homme et des libertés publiques", "مواصلة سيره على طريق توطيد مبدأي حقوق الإنسان والحريات العامة", "", "" },
                    { 1201, null, "R144.44P2", "44.144.ج.2", "", "Réalisé", "", 100, 8, 1, null, 96, null, null, "Examen périodique universal", "Poursuivre les réformes visant à consolider l’état de droit et les mécanismes nationaux de protection des droits de l’homme", "مواصلة الإصلاحات بقصد توطيد والآليات الوطنية لحماية حقوق الإنسان", "", "" },
                    { 1217, null, "R144.62", "62.144", "", "Réalisé", "", 100, 8, 1, null, 92, null, null, "Examen périodique universal", "Poursuivre les efforts du Gouvernement visant à doter l’institution nationale des droits de l’homme des ressources budgétaires suffisantes", "مواصلة الحكومة جهودها لتزويد المؤسسة الوطنية لحقوق الإنسان بالموارد الكافية", "", "" },
                    { 1209, null, "R144.52", "52.144", "", "Réalisé", "", 100, 8, 1, null, 90, null, null, "Examen périodique universal", "Veiller à ce qu’un mécanisme national de prévention soit mis sur pied rapidement et que le mécanisme s’appuie sur une base juridique et reçoive les ressources humaines et les moyens financiers nécessaires pour s’acquitter de son mandat en toute indépendance et de manière efficace", "ضمان الإسراع في إنشاء آلية وطنية لمنع التعذيب، وأن ترتكز تلك الآلية على أساس قانوني وأن تحصل على الموارد البشرية والمالية اللازمة لأداء وظيفتها على نحوٍ مستقل وكفء", "", "" },
                    { 1224, null, "R144.4", "43.144", "", "Réalisé", "", 100, 9, 1, null, 82, null, null, "Examen périodique universal", "Renforcer les réalisations dans le domaine de la consolidation des droits de l’homme", "توطيد الإنجازات التي تحققت في مجال ترسيخ حقوق الإنسان", "", "" },
                    { 374, null, "R59", "ت.59", "", "En cours", "", 30, null, null, 9, null, null, null, "Organes de traités", "Appliquer pleinement les indicateurs liés au handicap pour le suivi de la mise en œuvre des objectifs de développement durable et de tenir compte des liens qui existent entre l’article 31 de la Convention et la cible 17.8 des objectifs de développement durable afin de disposer d’un beaucoup plus grand nombre de données de qualité, actualisées et exactes, ventilées par niveau de revenu, sexe, âge, race, appartenance ethnique, statut migratoire (notamment le statut de demandeur d’asile et de réfugié), handicap et emplacement géographique, et selon d’autres caractéristiques propres au pays. Il recommande en outre à l’État partie d’utiliser l’ensemble des questions proposées par le Groupe de Washington sur les statistiques des incapacités pour son recensement et les enquêtes sur les ménages.", "-      التطبيق الكامل للمؤشرات ذات الصلة بالإعاقة لرصد تنفيذ أهداف التنمية المستدامة، وإيلاء الاهتمام للصلات القائمة بين المادة ٣١ من الاتفاقية والغاية 17-18 من هذه الأهداف، من أجل تحقيق زيادة كبيرة في توافر بيانات عالية الجودة ومناسبة التوقيت وموثوقة ومفصلة حسب الدخل، ونوع الجنس، والسن، والعرق، والانتماء الإثني، والوضع كمهاجر (بما في ذلك وضع طالب اللجوء ووضع اللاجئ)، والإعاقة، والموقع الجغرافي وغيرها من الخصائص ذات الصلة في سياقها الوطني. وتوصي الدولةَ الطرف كذلك باستخدام المجموعة الكاملة من الأسئلة التي أصدرها فريق واشنطن المعني بإحصاءات الإعاقة من أجل إجراء التعدادات واستقصاءات الأسر المعيشية.", "", "" },
                    { 1218, null, "R144.67", "67.144", "", "Réalisé", "", 100, 8, 1, null, 72, null, null, "Examen périodique universal", "Veiller à ce que des ressources humaines et financières suffisantes soient allouées à la mise en œuvre de programmes et d’activités sur les droits de l’homme", "ضمان تخصيص ما يكفي من الموارد البشرية والمالية لتنفيذ البرامج والأنشطة المتعلقة بحقوق الإنسان", "", "" },
                    { 1200, null, "R144.42", "42.144", "", "Réalisé", "", 100, 8, 1, null, 72, null, null, "Examen périodique universal", "Continuer à mettre en place des politiques et des programmes publics relatifs aux droits de l’homme, y compris sur le rôle effectif des parlementaires dans la promotion et la protection des droits de l’homme", "مواصلة وضع سياسيات وبرامج حول حقوق الإنسان، تشمل الدور الفعال الذي يلعبه البرلمانيون في تعزيز وحماية حقوق الإنسان", "", "" },
                    { 1226, null, "R144.88", "88.144", "", "Réalisé", "", 100, 9, 1, null, 71, null, null, "Examen périodique universal", "Poursuivre les efforts visant à retirer les mines terrestres et autres restes explosifs de guerre", "مواصلة الجهود لإزالة الألغام الأرضية وغيرها من المتفجرات من مخلفات الحرب", "", "" },
                    { 1219, null, "R144.33P1", "33.144 .ج.1", "", "Réalisé", "", 100, 9, 1, null, 66, null, null, "Examen périodique universal", "Continuer de renforcer son cadre institutionnel pour la promotion et la protection des droits de l’homme", "مواصلة توطيد الإطار التشريعي بغية تعزيز وحماية حقوق الإنسان", "", "" },
                    { 1199, null, "R144.33", "33.144", "", "Réalisé", "", 100, 8, 1, null, 66, null, null, "Examen périodique universal", "Continuer de renforcer son cadre institutionnel pour la promotion et la protection des droits de l’homme", "مواصلة توطيد الإطار المؤسساتي بغية تعزيز وحماية حقوق الإنسان", "", "" },
                    { 1216, null, "R144.60", "60.144", "", "Réalisé", "", 100, 8, 1, null, 59, null, null, "Examen périodique universal", "Continuer d’améliorer le rôle et les capacités de l’institution nationale des droits de l’homme, qui a conservé son statut A en mars 2016, en pleine conformité avec les Principes concernant le statut des institutions nationales pour la promotion et la protection des droits de l’homme (Principes de Paris)", "مواصلة ترسيخ دور المؤسسة الوطنية لحقوق الإنسان وقدرتها، وهي التي حصلت مجدداً على المركز ألف في آذار/مارس 2016 في امتثالٍ تام للمبادئ المتعلقة بمركز المؤسسات الوطنية لتعزيز وحماية حقوق الإنسان (مبادئ باريس)", "", "" },
                    { 1215, null, "R144.59", "59.144", "", "Réalisé", "", 100, 8, 1, null, 56, null, null, "Examen périodique universal", "Renforcer les mesures prises par le Conseil national pour la promotion et la protection des droits de l’homme, en particulier par l’intermédiaire de ses commissions sur l’ensemble du territoire", "تقوية العمل الذي يقوم به المجلس الوطني لحقوق الإنسان من أجل تعزيز وحماية حقوق الإنسان، ولا سيما عن طريق لجانه الموجودة في جميع أنحاء البلد", "", "" },
                    { 1210, null, "R144.53", "53.144", "", "Réalisé", "", 100, 8, 1, null, 56, null, null, "Examen périodique universal", "Mettre en place un mécanisme de protection des droits des personnes handicapées", "إنشاء آلية لحماية حقوق الأشخاص ذوي الإعاقة", "", "" },
                    { 1213, null, "R144.56", "56.144", "", "Réalisé", "", 100, 8, 1, null, 75, null, null, "Examen périodique universal", "Soutenir l’action pour la promotion et la protection des droits de l’homme menée par le Conseil national des droits de l’homme par l’intermédiaire de ses commissions régionales sur tout le territoire", "دعم العمل على تعزيز وحماية حقوق الإنسان الذي يقوم به المجلس الوطني لحقوق الإنسان بواسطة لجانه الجهوية في جميع أنحاء البلد", "", "" },
                    { 1203, null, "R144.46", "46.144", "", "Réalisé", "", 100, 8, 1, null, 50, null, null, "Examen périodique universal", "Poursuivre les efforts visant à soutenir les comités régionaux du Conseil national des droits de l’homme, en particulier dans les provinces du sud", "مواصلة الجهود لدعم دور اللجان الإقليمية للمجلس الوطني لحقوق الإنسان، ولا سيما في الأقاليم الجنوبية", "", "" },
                    { 1204, null, "R144.47", "47.144", "", "Réalisé", "", 100, 8, 1, null, 52, null, null, "Examen périodique universal", "Mettre en place l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", "إنشاء هيئة المناصفة ومكافحة كل أشكال التمييز", "", "" },
                    { 1212, null, "R144.55", "55.144", "", "Réalisé", "", 100, 8, 1, null, 10, null, null, "Examen périodique universal", "Continuer à promouvoir le rôle des institutions nationales de protection des droits de l’homme en appuyant les activités des comités régionaux du Conseil national des droits de l’homme dans diverses régions, en particulier dans les villes de Laayoune et Dakhla, dans les provinces du sud", "مواصلة تعزيز دور المؤسسات الوطنية لحماية حقوق الإنسان عن طريق دعم أنشطة اللجان الجهوية للمجلس الوطني لحقوق الإنسان في مختلف المناطق، ولا سيما في مدينتي العيون والداخلة في الأقاليم الجنوبية", "", "" },
                    { 1225, null, "R144.141", "141.144", "", "Réalisé", "", 100, 9, 1, null, 27, null, null, "Examen périodique universal", "Poursuivre et accélérer les efforts visant à promouvoir les droits économiques, sociaux et culturels pour l’ensemble de la population", "مواصلة الجهود وتسريعها بغرض تعزيز الحقوق الاقتصادية والاجتماعية والثقافية لجميع السكان", "", "" },
                    { 1221, null, "R144.39", "39.144", "", "Réalisé", "", 100, 9, 1, null, 35, null, null, "Examen périodique universal", "Continuer d’allouer les fonds nécessaires à la mise en œuvre de projets visant à accroître l’intégration des droits de l’homme dans les politiques publiques", "مواصلة تخصيص التمويل المطلوب لتنفيذ مشاريع بهدف زيادة إدماج حقوق الإنسان في السياسات العامة", "", "" },
                    { 1202, null, "R144.45", "45.144", "", "Réalisé", "", 100, 8, 1, null, 37, null, null, "Examen périodique universal", "Accélérer le processus de création de l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", "تسريع عملية إنشاء هيئة المناصفة ومكافحة كل أشكال التمييز", "", "" },
                    { 1208, null, "R144.51", "51.144", "", "Réalisé", "", 100, 8, 1, null, 31, null, null, "Examen périodique universal", "Intensifier les efforts pour combattre la torture et les autres mauvais traitements commis par des agents de l’État par la mise en place d’un mécanisme national indépendant et efficace pour la prévention de la torture", "تكثيف الجهود لمكافحة حالات التعذيب وغيره من ضروب المعاملة السيئة على يد أعوان الدولة، وذلك بإنشاء آلية وطنية لمنع التعذيب تكون مستقلة وفعالة", "", "" },
                    { 1222, null, "R144.40", "40.144", "", "En cours", "", 30, 9, 1, null, 37, null, null, "Examen périodique universal", "Consolider l’expérience de la régionalisation et poursuivre la participation des jeunes et des femmes dans toutes les régions du Royaume, y compris dans les provinces méridionales", "تكريس تجربة الجهوية ومواصلة مشاركة الشباب والنساء في جميع مناطق المملكة، بما فيها الأقاليم الجنوبية", "", "" },
                    { 1205, null, "R144.48", "48.144", "", "Réalisé", "", 100, 8, 1, null, 40, null, null, "Examen périodique universal", "Établir un mécanisme national de prévention indépendant, efficace et doté de ressources suffisantes conformément au Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "إنشاء آلية وقائية وطنية مستقلة وفعالة ومزوَّدة بقدر جيد من الموارد بما يتفق مع متطلبات البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة", "", "" },
                    { 1206, null, "R144.49", "49.144", "", "Réalisé", "", 100, 8, 1, null, 41, null, null, "Examen périodique universal", "Accélérer le processus de création du mécanisme national de prévention de la torture", "تسريع عملية إنشاء الآلية الوطنية لمنع التعذيب", "", "" },
                    { 1207, null, "R144.50", "50.144", "", "Réalisé", "", 100, 8, 1, null, 42, null, null, "Examen périodique universal", "Rationaliser le processus de création du mécanisme national de prévention de la torture, et assurer une participation large et sans exclusive audit mécanisme", "ترشيد عملية إنشاء الآلية الوطنية لمنع التعذيب عن طريق ضمان المشاركة الواسعة والشاملة في تلك الآلية", "", "" },
                    { 1223, null, "R144.41", "41.144", "", "En cours", "", 30, 9, 1, null, 46, null, null, "Examen périodique universal", "Accélérer la mise en œuvre de la régionalisation avancée, en tant que moyen de promouvoir la participation des citoyens, en particulier des femmes et des jeunes, des 12 régions du Royaume, à la gouvernance politique et économique du pays", "تسريع تنفيذ الجهوية المتقدمة باعتبارها وسيلة من وسائل زيادة تعزيز مشارکة المواطنین، ولا سیما النساء والشباب، في الحوكمة السیاسیة والاقتصادية في البلد في مناطق المملكة البالغ عددها 12 منطقة", "", "" },
                    { 1214, null, "R144.57", "57.144.", "", "Réalisé", "", 100, 8, 1, null, 37, null, null, "Examen périodique universal", "Poursuivre ses efforts en vue de mettre en place et consolider les institutions et mécanismes nationaux de promotion et de protection des droits de l’homme", "مواصلة الجهود لإنشاء وتوطيد مؤسسات وآليات وطنية بغرض تعزيز وحماية حقوق الإنسان", "", "" }
                });

            migrationBuilder.InsertData(
                table: "SousAxes",
                columns: new[] { "Id", "IdAxe", "Label", "LabelAr" },
                values: new object[,]
                {
                    { 18, 4, "Le droit à un logement convenable", "الحق في السكن اللائق" },
                    { 12, 4, "Les droits culturels", "الحقوق الثقافية" },
                    { 17, 4, "Le droit et l’accès à l’eau", "الحق في الولوج إلى الماء" },
                    { 16, 4, "Le droit au développement", "الحق في التنمية" },
                    { 15, 4, "Le droit au travail", "الحق في الشغل" },
                    { 14, 4, "Le droit à l’éducation", "الحق في والتعليم" },
                    { 13, 4, "Le droit à la santé", "الحق في الصحة" },
                    { 11, 4, "La lutte contre la pauvreté et la vulnérabilité", "محاربة الفقر والهشاشة" },
                    { 2, 1, "La réforme du système de la justice", "إصلاح منظومة العدالة" },
                    { 9, 3, "Législation", "التشريع" },
                    { 8, 2, "Le suivi des résultats des conférences et des déclarations internationales", "متابعة نتائج وتوصيات المؤتمرات الدولية" },
                    { 7, 2, "La coopération avec les mécanismes onusiens des droits de l'homme", "التعاون مع الآليات الأممية لحقوق الإنسان" },
                    { 6, 2, "L’interaction avec les PS du Conseil des droits de l’Homme", "التفاعل مع آلية الإجراءات الخاصة" },
                    { 5, 2, "La ratification et l'adhésion aux mécanismes internationaux relatifs aux droits de l'homme", "المصادقة أو الانضمام للصكوك الدولية" },
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
                    { 650, 47, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5985) },
                    { 1225, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7706) },
                    { 1225, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7702) },
                    { 1225, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7699) },
                    { 1225, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7695) },
                    { 1225, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7691) },
                    { 1212, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7592) },
                    { 1211, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7588) },
                    { 374, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2196) },
                    { 314, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1123) },
                    { 314, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1116) },
                    { 314, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1109) },
                    { 314, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1104) },
                    { 313, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1098) },
                    { 312, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1093) },
                    { 312, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1088) },
                    { 312, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1081) },
                    { 311, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1075) },
                    { 310, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1068) },
                    { 309, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1062) },
                    { 309, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1055) },
                    { 308, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1046) },
                    { 308, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1039) },
                    { 308, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1032) },
                    { 308, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1025) },
                    { 307, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1018) },
                    { 307, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1009) },
                    { 306, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1001) },
                    { 306, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(995) },
                    { 306, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(990) },
                    { 1208, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7576) },
                    { 306, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(985) },
                    { 1221, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7650) },
                    { 1221, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7657) },
                    { 1218, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7632) },
                    { 1218, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7629) },
                    { 1218, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7625) },
                    { 1200, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7540) },
                    { 1226, 11, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7709) },
                    { 1219, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7639) },
                    { 1219, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7636) },
                    { 1199, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7536) },
                    { 1199, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7531) },
                    { 1199, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7520) },
                    { 1216, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7614) },
                    { 1215, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7611) },
                    { 1210, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7583) },
                    { 1204, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7562) },
                    { 1204, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7558) },
                    { 1203, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7554) },
                    { 1223, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7679) },
                    { 1207, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7573) },
                    { 1206, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7569) },
                    { 1205, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7565) },
                    { 1222, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7676) },
                    { 1214, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7607) },
                    { 1214, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7603) },
                    { 1202, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7550) },
                    { 1202, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7547) },
                    { 1221, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7672) },
                    { 1221, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7668) },
                    { 1221, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7665) },
                    { 1221, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7661) },
                    { 1221, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7653) },
                    { 306, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(980) },
                    { 305, 31, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(974) },
                    { 304, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(969) },
                    { 192, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9014) },
                    { 192, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9007) },
                    { 192, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9000) },
                    { 192, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8993) },
                    { 192, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8986) },
                    { 192, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8980) },
                    { 192, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8975) },
                    { 192, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8969) },
                    { 192, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8963) },
                    { 164, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8437) },
                    { 164, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8430) },
                    { 163, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8424) },
                    { 163, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8417) },
                    { 123, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7646) },
                    { 123, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7632) },
                    { 122, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7625) },
                    { 122, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7618) },
                    { 86, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6841) },
                    { 85, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6835) },
                    { 84, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6830) },
                    { 84, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6823) },
                    { 84, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6816) },
                    { 84, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6810) },
                    { 84, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6803) },
                    { 32, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5513) },
                    { 32, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5507) },
                    { 32, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5500) },
                    { 31, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5493) },
                    { 650, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5981) },
                    { 192, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9021) },
                    { 193, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9028) },
                    { 193, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9035) },
                    { 193, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9042) },
                    { 303, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(962) },
                    { 302, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(956) },
                    { 302, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(949) },
                    { 302, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(942) },
                    { 301, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(935) },
                    { 300, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(928) },
                    { 300, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(921) },
                    { 299, 2, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(914) },
                    { 299, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(907) },
                    { 299, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(900) },
                    { 298, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(895) },
                    { 297, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(890) },
                    { 244, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(59) },
                    { 244, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(52) },
                    { 1213, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7595) },
                    { 244, 1, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(45) },
                    { 243, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(33) },
                    { 243, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(28) },
                    { 195, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9118) },
                    { 195, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9112) },
                    { 195, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9105) },
                    { 195, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9099) },
                    { 194, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9094) },
                    { 193, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9088) },
                    { 193, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9081) },
                    { 193, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9076) },
                    { 193, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9069) },
                    { 193, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9063) },
                    { 193, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9055) },
                    { 193, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9048) },
                    { 244, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(38) },
                    { 1213, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7600) },
                    { 123, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7639) },
                    { 1224, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7686) },
                    { 578, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4896) },
                    { 577, 50, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4890) },
                    { 577, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4884) },
                    { 576, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4877) },
                    { 576, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4870) },
                    { 575, 9, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4864) },
                    { 575, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4858) },
                    { 575, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4853) },
                    { 574, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4848) },
                    { 573, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4842) },
                    { 573, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4837) },
                    { 573, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4830) },
                    { 555, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4583) },
                    { 555, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4577) },
                    { 554, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4572) },
                    { 554, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4567) },
                    { 553, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4562) },
                    { 552, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4555) },
                    { 552, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4549) },
                    { 551, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4542) },
                    { 551, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4535) },
                    { 551, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4529) },
                    { 550, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4522) },
                    { 550, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4515) },
                    { 550, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4510) },
                    { 550, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4505) },
                    { 550, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4498) },
                    { 549, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4493) },
                    { 549, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4486) },
                    { 578, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4903) },
                    { 579, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4909) },
                    { 580, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4914) },
                    { 581, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4920) },
                    { 1224, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7683) },
                    { 650, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5975) },
                    { 650, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5969) },
                    { 649, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5964) },
                    { 649, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5957) },
                    { 649, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5950) },
                    { 648, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5943) },
                    { 648, 51, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5937) },
                    { 647, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5930) },
                    { 647, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5920) },
                    { 646, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5914) },
                    { 646, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5904) },
                    { 646, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5898) },
                    { 645, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5893) },
                    { 549, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4479) },
                    { 645, 51, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5886) },
                    { 644, 45, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5873) },
                    { 644, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5866) },
                    { 644, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5860) },
                    { 644, 51, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5853) },
                    { 644, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5847) },
                    { 636, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5698) },
                    { 610, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5385) },
                    { 609, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5378) },
                    { 608, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5372) },
                    { 607, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5365) },
                    { 607, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5358) },
                    { 607, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5353) },
                    { 582, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4930) },
                    { 582, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4925) },
                    { 645, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5880) },
                    { 549, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4473) },
                    { 647, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5925) },
                    { 547, 49, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4459) },
                    { 517, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3900) },
                    { 517, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3894) },
                    { 516, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3887) },
                    { 516, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3880) },
                    { 515, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3873) },
                    { 515, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3867) },
                    { 473, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3268) },
                    { 473, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3261) },
                    { 472, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3256) },
                    { 472, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3251) },
                    { 471, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3245) },
                    { 471, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3239) },
                    { 470, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3233) },
                    { 470, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3227) },
                    { 469, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3220) },
                    { 468, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3214) },
                    { 467, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3207) },
                    { 466, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3201) },
                    { 437, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2746) },
                    { 437, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2741) },
                    { 437, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2735) },
                    { 436, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2729) },
                    { 435, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2724) },
                    { 1220, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7643) },
                    { 1201, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7543) },
                    { 1217, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7621) },
                    { 548, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4466) },
                    { 1217, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7618) },
                    { 1209, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7580) },
                    { 517, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3906) },
                    { 517, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3914) },
                    { 1220, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7646) },
                    { 519, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3925) },
                    { 518, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3919) },
                    { 547, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4446) },
                    { 547, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4452) },
                    { 547, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4436) },
                    { 546, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4430) },
                    { 547, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4441) },
                    { 527, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4072) },
                    { 527, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4067) },
                    { 527, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4061) },
                    { 527, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4056) },
                    { 526, 11, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4049) },
                    { 526, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4043) },
                    { 526, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4036) },
                    { 526, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4029) },
                    { 526, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4023) },
                    { 546, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4425) },
                    { 525, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4016) },
                    { 520, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3936) },
                    { 520, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3943) },
                    { 522, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3956) },
                    { 522, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3963) },
                    { 523, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3969) },
                    { 523, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3975) },
                    { 521, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3949) },
                    { 519, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3930) },
                    { 524, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3987) },
                    { 524, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3992) },
                    { 525, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3998) },
                    { 525, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4004) },
                    { 524, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3981) },
                    { 525, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4009) }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 1159, null, "P2R144.184", "184.144 ج.2", "", "Réalisé", "", 100, 6, 1, null, 59, 32, null, "Examen périodique universal", "Poursuivre les efforts louables visant à promouvoir et protéger les droits des enfants", ".......مواصلة الجهود الحميدة الرامية إلى تعزيز حماية حقوق الأطفال", "", "" },
                    { 1160, null, "R144.217", "217.144", "", "En cours", "", 30, 6, 1, null, 23, 32, null, "Examen périodique universal", "Éliminer la pratique néfaste du mariage précoce et sensibiliser le public et les parents pour la protection efficace des mineures", "القضاء على الممارسة الضارة المتمثلة في الزواج المبكر وتوعية الجمهور والآباء والأمهات من أجل حماية الفتيات القاصرات حمايةً فعالة", "", "" },
                    { 1161, null, "R144.218P1", "218.144 ج.1", "", "En cours", "", 30, 6, 1, null, 84, 32, null, "Examen périodique universal", "Renforcer les mesures visant à éliminer les mariages d’enfants", "تقوية التدابير الرامية إلى القضاء التام على زواج الأطفال ......", "", "" },
                    { 1162, null, "R144.222 P1", "222.144. ج.1", "", "Réalisé", "", 100, 6, 1, null, 19, 32, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des enfants", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل لحقوق الطفل....... وغير ذلك من الفئات الضعيفة", "", "" },
                    { 1163, null, "R144.223", "223.144", "", "Réalisé", "", 100, 6, 1, null, 77, 32, null, "Examen périodique universal", "Poursuivre les efforts pour faire en sorte que les enfants et adolescents vulnérables vivant en milieu rural aient accès à une éducation et à des services de santé de qualité", "مواصلة الجهود من أجل كفالة حصول الأطفال والمراهقين الضعيفة حالهم في المجتمعات الريفية على التعليم الجيد وخدمات الرعاية الصحية الجيدة", "", "" },
                    { 1165, null, "R144.225", "225.144", "", "Réalisé", "", 100, 6, 1, null, 57, 32, null, "Examen périodique universal", "Poursuivre ses efforts pour lutter contre le travail des enfants par la mise en œuvre effective de la loi sur les conditions de travail et d’emploi des travailleurs domestiques", "مواصلة جهوده في سبيل مكافحة عمالة الأطفال عن طريق التنفيذ الفعال لقانون العمال المنزليين وظروف الاستخدام", "", "" },
                    { 1166, null, "R144.226", "226.144", "", "Réalisé", "", 100, 6, 1, null, 95, 32, null, "Examen périodique universal", "Interdire et incriminer expressément l’enrôlement et l’utilisation dans des hostilités d’enfants de moins de 18 ans", "حظر وتجريم تجنيد الأطفال دون سن 18 واستخدامهم في الأعمال العدائية حظراً وتجريماً صريحين", "", "" },
                    { 1167, null, "R144.227P2", "227.144. ج.2", "", "Réalisé", "", 100, 6, 1, null, 20, 32, null, "Examen périodique universal", "Poursuivre ses efforts pour assurer la protection et la promotion des droits des groupes vulnérables, notamment et les enfants", "مواصلة جهوده من أجل حماية وتعزيز حقوق الإنسان للفئات الضعيفة بما فيها..... الأطفال", "", "" },
                    { 1158, null, "R144.139", "139.144", "", "En cours", "", 30, 6, 1, null, 94, 32, null, "Examen périodique universal", "Éliminer les frais pour les actes de naissance et faciliter la délivrance d’un certificat de naissance à tous les enfants réfugiés qui n’en ont pas encore", "إلغاء الرسوم المفروضة على إصدار شهادات الميلاد وتيسير إصدار شهادات الميلاد لجميع الأطفال اللاجئين الذين لا يملكون شهادة ميلاد بعد", "", "" },
                    { 1168, null, "R144.138P1", "138.144 ج.1", "", "Réalisé", "", 100, 6, 1, null, 94, 32, null, "Examen périodique universal", "Retirer toute référence dans les documents d’identité qui permettrait de repérer les enfants nés hors mariage", "سحب أي إشارة في وثائق الهوية من شأنها أن تمكّن من تحديد الأطفال المولودين خارج إطار الزواج.......", "", "" },
                    { 1164, null, "R144.224P1", "224.144 ج.1", "", "Réalisé", "", 100, 6, 1, null, 79, 32, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des enfants", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان، وبخاصة حقوق الطفل....", "", "" },
                    { 1169, null, "R144.228P2", "228.144 ج.2", "", "En cours", "", 30, 6, 1, null, 38, 32, null, "Examen périodique universal", "Accélérer encore les efforts visant à promouvoir les droits des enfants, en particulier ceux qui sont handicapés", "زيادة تسريع الجهود المبذولة لأجل تعزيز حقوق... والطفل، وخاصة ذوي الإعاقة منهم", "", "" },
                    { 510, null, "R91P3", "ت.91.ف.3", "", "En cours", "", 30, 6, null, null, null, 32, 3, "Procédure spéciale", "-    Pour ce qui est des mineurs, le Rapporteur spécial recommande au Gouvernement de déployer des procureurs et des fonctionnaires de police judiciaire spécialisés dans les affaires concernant des délinquants mineurs.", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي: (ج) توفير خدمات مدعين عامين متخصصين وموظفين في الشرطة القضائية متخصصين في قضايا الجانحين الأحداث.", "", "" },
                    { 1156, null, "R144.135", "135.144", "", "Réalisé", "", 100, 6, 1, null, 71, 32, null, "Examen périodique universal", "Envisager d’éliminer des documents d’identité toutes les données qui pourraient conduire à une discrimination contre les enfants nés hors mariage", "النظر في إلغاء جميع البيانات من وثائق الهوية التي من شأنها أن تؤدي إلى تمييز في حق الأطفال المولودين خارج إطار الزواج", "", "" },
                    { 603, null, "R83P22", "null", "", "Réalisé", "", 100, 6, null, null, null, 32, 6, "Procédure spéciale", "-       Fournir des procureurs spécialisés et des officiers de police judiciaire specialises pour les cas de jeunes délinquants", "null", "", "" },
                    { 602, null, "R83P20", "null", "", "Réalisé", "", 100, 6, null, null, null, 32, 6, "Procédure spéciale", @"Mettre en place un système de visites régulières dans les postes de police avec un accent particulier sur les délinquants juvéniles, ne pas placer les mineurs dans les prisons ordinaires mais plutôt dans des centres de protection de l’enfance
                - Enquêter sur toutes les plaintes de torture et de mauvais traitements des mineurs, notamment des allégations de châtiments corporels", "null", "", "" },
                    { 537, null, "R99P1-2", "null", "", "En cours", "", 30, 6, null, null, null, 32, 4, "Procédure spéciale", @"En ce qui les provinces marocaines du sud :
                - a) …………. prendre des mesures concrètes pour améliorer la situation des employés de maison et lutter contre le travail des enfants et l’exploitation sexuelle des femmes et des enfants", "null", "", "" },
                    { 186, null, "R38", "ت.38", "", "Réalisé", "", 100, 6, null, 5, null, 32, null, "Organes de traités", "Prendre les mesures nécessaires pour assurer à tout enfant de travailleur migrant, y compris ceux en situation irrégulière, l’enregistrement de sa naissance.", "اتخاذ التدابير اللازمة لضمان تسجيل كل طفل من أبناء العمال المهاجرين، بمن فيهم الموجودون في وضع غير قانوني.", "", "" },
                    { 509, null, "R91P1", "ت.91.ف.1", "", "En cours", "", 30, 6, null, null, null, 32, 3, "Procédure spéciale", "-    Organiser des visites régulières dans les postes de police en accordant une attention particulière aux délinquants mineurs, de ne pas placer des mineurs dans des prisons ordinaires mais de renforcer les centres de protection des enfants et d’enquêter sur toutes les plaintes de torture et de mauvais traitements émanant de mineurs, en particulier sur les allégations relatives aux châtiments corporels;", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي: - (أ) زيارة مراكز الشرطة بانتظام، مع التركيز خصوصاً على الأحداث الجانحين؛ وعدم حبسهم في سجون عادية وإنما تدعيم هيكلية مراكز حماية الأطفال؛ والتحقيق في جميع شكاوى تعذيبهم أو إساءة معاملتهم، لا سيما الادعاءات المتعلقة بالعقوبة البدنية؛", "", "" },
                    { 425, null, "R89", "null", "", "En cours", "", 30, 6, null, null, null, 32, 1, "Procédure spéciale", "-   Redoubler d’efforts pour allouer des ressources suffisantes à l’amélioration et à la protection de l’alimentation des enfants, et pour concevoir, adopter et mettre en œuvre des politiques et des programmes coordonnés dans ce domaine, en particulier en milieu rural", "null", "", "" },
                    { 424, null, "R88", "null", "", "En cours", "", 30, 6, null, null, null, 32, 1, "Procédure spéciale", "-   Veiller à ce que le budget de l’État reflète la volonté de réaliser les droits des enfants en allouant des ressources équitables et suffisantes aux services essentiels pour les enfants, notamment en garantissant le droit de l’enfant à une alimentation saine et équilibrée.", "null", "", "" },
                    { 354, null, "R39P2", "ت.39.ف.2", "", "En cours", "", 30, 6, null, 8, null, 32, null, "Organes de traités", "De mettre en place une stratégie pour la désinstitutionnalisation des personnes handicapées qui comprenne des dispositions relatives à la collecte de données, en particulier en ce qui concerne les enfants handicapés abandonnés vivant en institution, ainsi qu’un calendrier précis et des indicateurs", "-       (ب) وضع استراتيجية لإنهاء رعاية الأشخاص ذوي الإعاقة داخل المؤسسات تتضمن بنوداً لجمع البيانات، ولا سيما عن الأطفال ذوي الإعاقة المُسيَّبين في المؤسسات، وإطاراً زمنياً ومؤشرات واضحين؛", "", "" },
                    { 353, null, "R17", "ت.17", "", "En cours", "", 30, 6, null, 8, null, 32, null, "Organes de traités", "Légiférer et prendre des mesures concrètes pour garantir que les enfants handicapés, notamment ceux qui ont été abandonnés, soient suffisamment protégés contre la violence, l’exploitation et la maltraitance, y compris les châtiments corporels, et que les auteurs de tels actes soient punis.", "اعتماد تشريعات وتدابير ملموسة تضمن تمتع الأطفال ذوي الإعاقة، بمن فيهم الأطفال ذوو الإعاقة المُسيَّبون، بحماية كافية من التعرض للعنف والاستغلال والاعتداء، بما في ذلك العقوبة البدنية، وتضمن إنزال العقوبة بالجناة.", "", "" },
                    { 233, null, "R21P7", "ت.21.ف.7", "", "En cours", "", 30, 6, null, 6, null, 32, null, "Organes de traités", "veiller au respect de la législation relative au travail des enfants, afin de protéger les filles contre les formes multiples de discrimination.", "ضمان إنفاذ القيود المفروضة على عمل الأطفال وذلك لحماية الطفلة من شتى أشكال التمييز", "", "" },
                    { 1157, null, "R144.136", "136.144", "", "Réalisé", "", 100, 6, 1, null, 83, 32, null, "Examen périodique universal", "Améliorer les procédures actuelles d’enregistrement des enfants pour garantir l’égalité entre les enfants et l’égalité de traitement juridique sans aucune discrimination", "تحسين الإجراءات المتّبعة في تسجيل الأطفال من أجل ضمان المساواة بين الأطفال والمعاملة القانونية المتساوية لهم دونما تمييز", "", "" },
                    { 1170, null, "P2R144.191", "191.144", "", "Réalisé", "", 100, 6, 1, null, 62, 32, null, "Examen périodique universal", "Prendre des mesures appropriées pour prévenir le mariage des mineurs", "اتخاذ تدابير مناسبة، مع مراعاة التزاماته الدولية، لمنع زواج القاصرين", "", "" },
                    { 359, null, "R31P2", "ت.31.ف.2", "", "En cours", "", 30, 6, null, 8, null, 33, null, "Organes de traités", "Prévoir une voie de recours pour les personnes handicapées qui risquent d’être privées de liberté, notamment d’être placées en institution ou internées, en s’inspirant notamment, à cette fin, des directives du Comité relatives à l’article 14 de la Convention.", "-      ….. واستحداث سبل تظلم قانوني للأشخاص ذوي الإعاقة المعرضين لخطر سلب حريتهم، بما في ذلك من خلال إيداعهم مؤسسات الرعاية أو حبسهم، وبالاسترشاد، في تحقيق هذه الغاية، بالمبادئ التوجيهية التي وضعتها اللجنة بشأن المادة 14 من الاتفاقية.", "", "" },
                    { 1172, null, "R144.91", "91.144", "", "Non réalisé", "", 0, 6, 1, null, 69, 32, null, "Examen périodique universal", "Mettre en place une législation interdisant les châtiments corporels et les mauvais traitements infligés aux garçons et aux filles", "وضع تشريعات تحظر العقوبة البدنية وإساءة معاملة البنين والبنات", "", "" },
                    { 118, null, "R36P2P3P4", "ت.36.ف.2.ف.3.ف.4", "", "En cours", "", 30, 6, null, 3, null, 34, null, "Organes de traités", @"b) poursuivre et renforcer les efforts pour régulariser la situation de personnes ayant besoin d’une protection internationale, notamment les réfugiés syriens, en leur octroyant un statut légal et des cartes nationales de réfugiés, afin de garantir leur droit à la non-discrimination, y compris l’accès au marché formel de l’emploi ;
                 c) établir des procédures de détermination du statut de réfugié aux points d’entrée dans le pays, y compris dans les aéroports ;
                 d) mettre un terme aux arrestations collectives et cesser de participer aux opérations d’expulsions collectives de migrants opérées notamment à proximité des villes autonomes espagnoles de Ceuta et Melilla ;", @"(ب) ومواصلة وتعزيز الجهود لتسوية وضع الأشخاص الذين يحتاجون إلى الحماية الدولية، بمن فيهم اللاجئون السوريون، بمنحهم صفة قانونية وبطاقات وطنية للاجئين، من أجل ضمان حقهم في عدم التمييز، بما في ذلك دخول سوق العمل الرسمية؛
                -  (ج) العمل بإجراءات تحديد صفة اللاجئ في نقاط دخول البلد، بما فيها المطارات؛
                -  (د) وضع حد للاعتقالات الجماعية، والتوقف عن المشاركة في عمليات الطرد الجماعي للمهاجرين، خاصة بالقرب من مدينتي سبتة ومليلية الإسبانيتين المستقلتين ذاتياً؛", "", "" },
                    { 79, null, "R26P1P2P3", "ت.26.ف.1.ف.2ف.3", "", "Réalisé", "", 100, 6, null, 2, null, 34, null, "Organes de traités", @"Prendre des mesures visant à garantir que les garanties légales régissant les reconduites à la frontière des migrants illégaux et l’expulsion des étrangers soient toujours mises en œuvre dans la pratique et que les reconduites et les expulsions soient conformes à la loi marocaine. 
                - Mener des enquêtes impartiales et efficaces sur les allégations selon lesquelles des expulsions de migrants se seraient accompagnées d’un recours excessif à la force ou de mauvais traitements à l’endroit des migrants. 
                - Faire en sorte que les responsables soient traduits en justice et qu’il leur soit infligé des peines à la mesure de la gravité de leurs actes.", @"اتخاذ تدابير تكفل تطبيق الضمانات القانونية التي تحكم اقتياد المهاجرين غير الشرعيين إلى الحدود وطرد الأجانب عملياً على الدوام، وأن تكون عمليات الاقتياد والطرد منسجمة مع القانون المغربي. 
                - إجراء تحقيقات نزيهة وفعالة في الادعاءات التي تفيد باحتمال الاستخدام المفرط للقوة وإساءة معاملة المهاجرين في سياق عمليات 
                -  تقديم المسؤولين عن ذلك إلى العدالة وإنزال عقوبات عليهم تتناسب مع جسامة أفعالهم.", "", "" },
                    { 117, null, "R48", "ت.48", "", "En cours", "", 30, 6, null, 3, null, 32, null, "Organes de traités", "Appliquer rigoureusement les dispositions légales relatives au travail et à l’exploitation des enfants en vue d’éliminer ces pratiques, poursuivre ses efforts de sensibilisation de la population et renforcer les mécanismes de surveillance.", "تنفيذ الأحكام القانونية المتعلقة بالعمل واستغلال الأطفال بصرامة قصد القضاء على هذه الممارسات، ومواصلة جهود توعية السكان التي تبذلها الدولة، وتوطّيد آليات المراقبة.", "", "" },
                    { 78, null, "R25P2", "ت.25.ف.2", "", "En cours", "", 30, 6, null, 2, null, 34, null, "Organes de traités", @"Développer les instruments institutionnels et administratifs propres à mettre en œuvre cette protection, notamment en renforçant sa coopération avec le Haut-Commissariat des Nations Unies pour les réfugiés et en octroyant au Haut-Commissariat un statut d’observateur au cours du processus de réforme du système d’asile. 
                - S’assurer de la mise en place des procédures et des mécanismes propres à garantir l’identification systématique des demandeurs d’asile potentiels à tous les points d’entrée sur le territoire marocain. 
                - Permettre à ces personnes de déposer leur demande d’asile. 
                - Faire en sorte que lesdits mécanismes garantissent que la décision rendue soit susceptible d’un recours avec effet suspensif et que la personne ne soit pas refoulée vers un pays où existe un risque de torture", @"تطوير الأدوات المؤسسية والإدارية القادرة على تنفيذ هذه الحماية، لا سيما بتعزيز تعاونها مع المفوضية السامية لشؤون اللاجئين وبمنح المفوضية السامية صفة مراقب في سياق عملية إصلاح نظام اللجوء. 
                -  وضع إجراءات وآليات قادرة على ضمان تحديد هوية طالبي اللجوء المحتملين بصورة منهجية في جميع نقاط الدخول إلى الأراضي المغربية.
                -  تمكين هؤلاء الأشخاص من تقديم طلبات لجوئهم. 
                - تضمين هذه الآليات أيضاً إمكانية تعرض القرارات المتخذة للطعن وأن يقترن ذلك بوقف التنفيذ وعدم إبعاد الشخص المعني إلى بلد يواجه فيه خطر التعذيب", "", "" },
                    { 27, null, "R14", "ت.14", "", "Réalisé", "", 100, 6, null, 1, null, 34, null, "Organes de traités", "Prendre des mesures visant à protéger les non-ressortissants dépourvus de titre de séjour contre la discrimination raciale et la xénophobie, à veiller à l’application de toutes garanties juridiques relatives à leur détention, ainsi qu’à faciliter leur accès aux tribunaux. Le Comité recommande également à l’Etat partie de garantir l’application correcte du principe de non-refoulement.", @"اتخاذ تدابير لحماية غير المواطنين الذين لا يملكون رخصة إقامة من التمييز العنصري ومن كراهية الأجانب
                -الحرص على إحاطة احتجازهم غير المواطنين الذين لا يملكون رخصة إقامة بجميع الضمانات القانونية وعلى تيسير لجوئهم إلى المحاكم. وتوصي اللجنة الدولة الطرف كذلك بضمان تطبيق مبدأ عدم الإعادة على النحو الصحيح.", "", "" },
                    { 26, null, "R13P2", "ت.13.ف.2", "", "Réalisé", "", 100, 6, null, 1, null, 34, null, "Organes de traités", "Garantir la protection des droits des réfugiés et des demandeurs d’asile, notamment en ce qui concerne l’accès à l’emploi et l’accès au logement, ainsi que leur protection contre la discrimination raciale", "ضمان حماية حقوق اللاجئين وطالبي اللجوء فيما يخص الحصول على العمل والسكن وحماية تلك الفئات من الناس من أي تمييز عنصري.", "", "" },
                    { 1185, null, "R144.231", "231.144", "", "En cours", "", 30, 6, 1, null, 56, 33, null, "Examen périodique universal", "Intégrer la langue des signes dans les médias publics et assurer la formation des interprètes dans ce domaine", "إدماج لغة الإشارة في وسائط الإعلام العامة وتوفير التدريب للمترجمين في هذا المجال", "", "" },
                    { 1184, null, "R144.230", "230.144", "", "Réalisé", "", 100, 6, 1, null, 55, 33, null, "Examen périodique universal", "Continuer à renforcer la mise en œuvre des politiques publiques concernant les personnes handicapées", "مواصلة تقوية تنفيذ السياسات العامة المتعلقة بالأشخاص ذوي الإعاقة", "", "" },
                    { 1183, null, "R144.229", "229.144", "", "Réalisé", "", 100, 6, 1, null, 45, 33, null, "Examen périodique universal", "Continuer de prendre des mesures globales pour mieux intégrer les personnes handicapées dans la société", "مواصلة اتخاذ تدابير شاملة لتحسين اندماج الأشخاص ذوي الإعاقة في المجتمع", "", "" },
                    { 1182, null, "R144.227P1", "227.144. ج.1", "", "Réalisé", "", 100, 6, 1, null, 20, 33, null, "Examen périodique universal", "Poursuivre ses efforts pour assurer la protection et la promotion des droits des groupes vulnérables, notamment les personnes handicapées", "مواصلة جهوده من أجل حماية وتعزيز حقوق الإنسان للفئات الضعيفة بما فيها الأشخاص ذوي الإعاقة.....", "", "" },
                    { 1181, null, "R144.224P3", "224.144 ج.3", "", "Réalisé", "", 100, 6, 1, null, 79, 33, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des personnes handicapées", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان،..... وبخاصة حقوق الأشخاص ذوي الإعاقة", "", "" },
                    { 1180, null, "R144.222P2", "222.144. ج.2", "", "Réalisé", "", 100, 6, 1, null, 19, 33, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des personnes handicapées", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل لحقوق.... الأشخاص ذوي الإعاقة.... وغير ذلك من الفئات الضعيفة", "", "" },
                    { 1171, null, "R144.90", "90.144", "", "En cours", "", 30, 6, 1, null, 43, 32, null, "Examen périodique universal", "Mettre en œuvre les recommandations issues du deuxième cycle figurant dans le document A/HRC/21/3 (par. 129.62 et 129.65) et interdire sans équivoque les châtiments corporels en tous lieux, y compris à la maison, dans les institutions de protection de remplacement, dans les crèches et dans les écoles", "تنفيذ التوصيات المنبثقة عن الجولة الثانية، الواردة في الوثيقة A/HRC/21/3، الفقرتان 129‑62 و129‑65، وحظر العقوبة البدنية حظراً لا يدع مجالاً للشك، في جميع الأماكن وحتى داخل المنزل وفي مؤسسات الرعاية البديلة وفي دور الحضانة النهارية وفي المدارس", "", "" },
                    { 1179, null, "R144.167", "167.144", "", "En cours", "", 30, 6, 1, null, 30, 33, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir l’éducation inclusive en renforçant l’accès à l’éducation pour les personnes handicapées", "مواصلة الجهود لتعزيز التعليم الجامع عن طريق تيسير حصول الأشخاص ذوي الإعاقة على التعليم", "", "" },
                    { 426, null, "R93", "null", "", "En cours", "", 30, 6, null, null, null, 33, 1, "Procédure spéciale", "-   Intégrer pleinement la problématique du handicap dans les politiques et les programmes relatifs à la nutrition, les politiques relatives à la santé maternelle et infantile et les initiatives plus générales en matière de santé.", "null", "", "" },
                    { 358, null, "R29P1", "ت.29.ف.1", "", "En cours", "", 30, 6, null, 8, null, 33, null, "Organes de traités", "Prendre des mesures pour garantir que toutes les personnes handicapées, en particulier celles qui présentent un handicap psychosocial ou intellectuel, ainsi que les personnes sourdes et malentendantes, aient accès à la justice, et à l’information et aux communications dans des formats accessibles, notamment en braille, sur des supports tactiles, en langue facile (Easy Read) et en langue des signes", "-       (أ) اعتماد تدابير لضمان إمكانية اللجوء إلى القضاء لجميع الأشخاص ذوي الإعاقة، ولا سيما الأشخاص ذوي الإعاقة النفسية - الاجتماعية و/أو العقلية، والصم وضعاف السمع، وضمان إمكانية وصولهم إلى خدمات الإعلام والاتصال باستعمال أشكال ميسرة، مثل طريقة برايل، وأشكال الاتصال عن طريق اللمس والأشكال التي تسهل قراءتها ولغة الإشارة؛", "", "" },
                    { 357, null, "R25", "ت.25", "", "En cours", "", 30, 6, null, 8, null, 33, null, "Organes de traités", "adopter une stratégie de réduction des risques de catastrophe qui soit accessible aux personnes handicapées et les prenne en considération, dans toutes les situations de risque, conformément au Cadre de Sendai pour la réduction des risques de catastrophe 2015-2030.", "-      اعتماد استراتيجية للحد من مخاطر الكوارث تنص على تيسير إمكانية الوصول وشمول الأشخاص ذوي الإعاقة في جميع حالات الخطر، تماشياً مع إطار سينداي للحد من مخاطر الكوارث 2015-2030.", "", "" },
                    { 356, null, "R13P3", "ت.13.ف.3", "", "En cours", "", 30, 6, null, 8, null, 33, null, "Organes de traités", "Prévoir des mesures en faveur des personnes handicapées qui ont été victimes d’actes de discrimination fondée sur le handicap, notamment de veiller à ce que ces personnes puissent obtenir réparation et être indemnisées, et d’infliger des sanctions aux auteurs de tels actes", "-       (ج) وضع تدابير، بما في ذلك التعويض وجبر الضرر، للأشخاص ذوي الإعاقة الذين تعرضوا للتمييز بسبب الإعاقة، وفرض جزاءات على الجناة.", "", "" },
                    { 355, null, "R9P2", "ت.9.ف.2", "", "En cours", "", 30, 6, null, 8, null, 33, null, "Organes de traités", ".......,Adopter des mesures concrètes pour protéger toutes les personnes handicapées, y compris celles qui présentent un handicap psychosocial ou intellectuel et celles qui appartiennent à des minorités nationales, ethniques, religieuses ou linguistiques, telles que les Amazighs, les Noirs, les migrants, les réfugiés et les demandeurs d’asile,........", "-       (أ) ........ واعتماد تدابير محددة لحماية جميع الأشخاص ذوي الإعاقة، بمن فيهم الأشخاص ذوو الإعاقة النفسية - الاجتماعية و/أو العقلية والأشخاص ذوو الإعاقة الذين ينتمون إلى أقليات قومية، أو إثنية أو دينية أو لغوية، مثل الأمازيغ والسود والمهاجرين واللاجئين وطالبي اللجوء، ...........؛", "", "" },
                    { 156, null, "R24P2P3", "ت.24.ف.2.ف.3", "", "En cours", "", 30, 6, null, 4, null, 33, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour permettre aux personnes handicapées de jouir pleinement de leurs droits économiques, sociaux et culturels. 
                - Appliquer le quota de 7 % et prendre toute autre mesure spéciale pour faciliter l’accès des personnes handicapées à l’emploi, à l’éducation et aux soins de santé.", @"اتخاذ جميع التدابير اللازمة لكي يتسنى للأشخاص ذوي الإعاقة التمتع كلياً بحقوقهم الاقتصادية والاجتماعية والثقافية. 
                - تطبيق حصة 7 في المائة واتخاذ أي من التدابير الخاصة الأخرى لتيسير إمكانية حصول الأشخاص ذوي الإعاقة على العمل والتعليم والرعاية الصحية.", "", "" },
                    { 1178, null, "R144.201", "201.144", "", "Réalisé", "", 100, 6, 1, null, 51, 32, null, "Examen périodique universal", "Poursuivre la mise en conformité de la législation des politiques et des programmes qui établissent les droits de l’enfant afin d’empêcher que les enfants travaillent dans des conditions nocives, mettre un terme aux mariages précoces et criminaliser toutes les formes d’exploitation des enfants", "مواصلة مواءمة تشريعاته وسياساته وبرامجه التي تكرس حقوق الطفل من أجل منع عمل الأطفال في ظروف مؤذية ووقف حالات الزواج المبكر وتجريم جميع أشكال استغلال الأطفال", "", "" },
                    { 1177, null, "R144.219", "219.144", "", "Réalisé", "", 100, 6, 1, null, 89, 32, null, "Examen périodique universal", "Prendre des mesures pour contrecarrer la tendance des autorisations judiciaires de mariage entre mineurs, notamment en apportant les modifications nécessaires au Code de la famille", "اتخاذ تدابير من أجل مقاومة الميل إلى استصدار أذون قضائية لحالات زواج تهمُّ قاصرين بوسائل منها إجراء التعديلات الضرورية لمدونة الأسرة", "", "" },
                    { 1176, null, "R144.218P2", "218.144 ج.2", "", "Non réalisé", "", 0, 6, 1, null, 84, 32, null, "Examen périodique universal", "Renforcer les mesures visant à éliminer les mariages d’enfants et accélérer l’adoption de la loi abolissant le mariage forcé des enfants", "......... الإسراع بسَنّ التشريع الذي يلغي تزويج الأطفال كرهاً", "", "" },
                    { 1175, null, "R144.159", "159.144", "", "Réalisé", "", 100, 6, 1, null, 94, 32, null, "Examen périodique universal", "Adopter un projet de loi réglementant les conditions de travail des travailleurs domestiques", "اعتماد مشروع قانون يحدد شروط عمل العمال المنزليين", "", "" },
                    { 1174, null, "R144.134P2", "134.144 ج.2", "", "Réalisé", "", 100, 6, 1, null, 3, 32, null, "Examen périodique universal", "permettre la pleine reconnaissance juridique des enfants nés hors mariage", "...... السماح بالاعتراف القانوني التام بالأطفال المولودين خارج إطار الزواج.....", "", "" },
                    { 1173, null, "R144.130P1P3", "130.144 ج.1 و ج.3", "", "Non réalisé", "", 0, 6, 1, null, 18, 32, null, "Examen périodique universal", "Analyser la législation existante et abroger toutes les règles qui sont contraires au principe de l’égalité entre les enfants ou qui constituent une discrimination à l’égard des droits de l’enfant", "تحليل التشريعات القائمة وإلغاء جميع القواعد التي تتنافى مع مبدأ المساواة بين الأطفال أو التي تشكل تمييزاً في حق الطفل", "", "" },
                    { 628, null, "R88P3", "ت.88.ف.3", "", "En cours", "", 30, 6, null, null, null, 33, 7, "Procédure spéciale", "Davantage d’investissements devraient être réalisés dans le renforcement des capacités et dans l’aménagement des centres de culture pour les rendre plus accessibles aux personnes handicapées.", "-    زيادة الاستثمار في بناء القدرات وجعل الاستفادة من هذه المراكز أمراً أسهل بالنسبة للأشخاص ذوي الإعاقة.", "", "" },
                    { 1155, null, "R144.185P1", "185.144 ج.1", "", "En cours", "", 30, 6, 1, null, 89, 30, null, "Examen périodique universal", "….revoir toutes les lois et pratiques qui établissent une discrimination fondée sur le sexe et les mettre en conformité avec le droit international et les normes internationales, et prendre des mesures pour améliorer encore la protection des femmes victimes de la violence", "........ استعراض جميع القوانين والممارسات التي تشكل تمييزاً على أساس نوع الجنس وجعلها متوائمة مع القانون الدولي والمعايير الدولية واتخاذ خطوات من أجل زيادة تحسين حماية النساء اللواتي يتعرضن للعنف", "", "" },
                    { 1123, null, "R144.184P1", "184.144 ج.1", "", "Réalisé", "", 100, 6, 1, null, 59, 30, null, "Examen périodique universal", "Poursuivre les efforts louables visant à promouvoir et protéger les droits des femmes", "مواصلة الجهود الحميدة الرامية إلى تعزيز حماية حقوق النساء", "", "" },
                    { 1153, null, "R144.196P1", "196.144 ج.1", "", "Réalisé", "", 100, 6, 1, null, 14, 30, null, "Examen périodique universal", "Poursuivre ses efforts tendant à améliorer la législation concernant la violence à l’égard des femmes", "مواصلة الجهود من أجل تحسين التشريعات المتعلقة بالعنف على المرأة بما يتفق مع المعايير الدولية بأن تتناول أبعاد الوقاية والحماية والمساعدة، ............", "", "" },
                    { 1120, null, "R144.69", "69.144", "", "Réalisé", "", 100, 6, 1, null, 93, 30, null, "Examen périodique universal", "Poursuivre les efforts visant à élaborer un cadre national pour le développement humain qui tienne compte de l’égalité des sexes et de la non‑discrimination", "مواصلة الجهود الرامية إلى صوغ إطار وطني للتنمية البشرية يضع في الاعتبار المساواة بين الجنسين وعدم التمييز", "", "" },
                    { 627, null, "R89", "ت.89", "", "Réalisé", "", 100, 6, null, null, null, 30, 7, "Procédure spéciale", "Pour garantir une égalité effective des sexes au bénéfice des femmes assurant une direction spirituelle, les femmes devraient pouvoir devenir membres à part entière des conseils religieux à tous les niveaux, y compris les institutions chargées d’émettre des fatwa, et être autorisées à exercer des fonctions de supervision dans les mosquées, que ce soit par l’enseignement ou la prédication.", "-    لضمان مساواة فعالة بين الجنسين للنساء اللواتي يقدمن إرشادات دينية، ينبغي أن تكون النساء قادرات على الانضمام - كأعضاء كاملي العضوية - إلى المجالس الدينية على جميع المستويات، بما في ذلك مؤسسات الفتوى، وأن يُسمح لهن بممارسة الإشراف الديني داخل المساجد، سواء من خلال الدروس أو الوعظ.", "", "" },
                    { 626, null, "R86P6-2", "ت.86.ف.6ج2", "", "En cours", "", 30, 6, null, null, null, 30, 7, "Procédure spéciale", "Tenir compte des droits de l’homme, de l’égalité des sexes et de la justice sociale dans l’élaboration du plan national de développement culturel.", "-    (و) وضع خطة عمل وطنية للتنمية الثقافية تضمن بشكل فعال إبراز التنوع الثقافي؛ ..... وينبغي أن تساهم مفاهيم حقوق الإنسان والمساواة بين الجنسين والعدالة الاجتماعية في إعداد خطة وطنية للتنمية الثقافية.", "", "" },
                    { 569, null, "R89P10", "null", "", "Réalisé", "", 100, 6, null, null, null, 30, 5, "Procédure spéciale", "Approuver et appliquer l’Agenda du Gouvernement pour l’égalité 2011-2015. Toutes les politiques et programmes dotés d’objectifs en matière d’égalité et de non-discrimination devraient faire l’objet d’une évaluation régulière pour s’assurer qu’ils permettront d’atteindre ces objectifs", "null", "", "" },
                    { 568, null, "R89P9", "null", "", "En cours", "", 30, 6, null, null, null, 30, 5, "Procédure spéciale", "Transposer à l’échelon régional, provincial et communal les progrès notables accomplis au niveau national dans le domaine de l’intégration et de la budgétisation axée sur la parité au sein des organismes publics", "null", "", "" },
                    { 567, null, "R89P6", "null", "", "En cours", "", 30, 6, null, null, null, 30, 5, "Procédure spéciale", "Rassembler des informations étayées par des faits sur l’application de l’obligation qu’a l’État partie d’agir avec la diligence voulue pour prévenir, interdire et punir les violations des normes internationales relatives à l’égalité et à la non-discrimination,  et pour assurer aux femmes en temps voulu des moyens de recours abordables et accessibles, y compris judiciaires;", "null", "", "" },
                    { 508, null, "R92P2", "ت.92.ف.2", "", "En cours", "", 30, 6, null, null, null, 30, 3, "Procédure spéciale", "-    En ce qui concerne les femmes, réduire le taux de surpeuplement des prisons en prenant des mesures de remplacement des peines privatives de liberté, en particulier dans le cas des femmes ayant des enfants.", "عن النساء، يوصي المقرر الخاص الحكومة بما يلي:  (ب) تقليص نسبة الاكتظاظ بتنفيذ تدابير بديلة، لا سيما لفائدة النساء والأطفال.", "", "" },
                    { 507, null, "R92P1", "ت.92.ف.1", "", "En cours", "", 30, 6, null, null, null, 30, 3, "Procédure spéciale", "-    Donner effet à la protection des prisonnières contre toutes les violences fondées sur le sexe", "عن النساء، يوصي المقرر الخاص الحكومة بما يلي:  (أ) تعزيز حماية السجينات من جميع أشكال العنف الجنساني؛", "", "" },
                    { 423, null, "R81", "null", "", "En cours", "", 30, 6, null, null, null, 30, 1, "Procédure spéciale", "-   Appliquer les dispositions du Code des habous et prendre des mesures pour éliminer les obstacles socioculturels empêchant les femmes d’exercer leur droit à la terre.", "null", "", "" },
                    { 422, null, "R79", "null", "", "En cours", "", 30, 6, null, null, null, 30, 1, "Procédure spéciale", "-   Prendre toutes les mesures nécessaires pour éliminer les préjugés et pratiques néfastes qui empêchent les femmes d’exercer leurs droits, conformément aux obligations qui incombent au Maroc en vertu de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes", "null", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 352, null, "R35P1", "ت.35.ف. 1", "", "En cours", "", 30, 6, null, 8, null, 30, null, "Organes de traités", "Adopter des mesures concrètes et efficaces pour faire en sorte que les personnes handicapées, en particulier les femmes et les filles victimes de violence sexiste et les enfants victimes de mauvais traitements, aient accès à des services et à des informations, notamment des permanences téléphoniques, des refuges, des services d’appui aux victimes et des services de consultation et de conseil, ainsi qu’à des mécanismes de plainte qui soient chargés, entre autres, d’accorder des indemnisations aux victimes et d’imposer des sanctions contre les auteurs de ces actes ;", "-       (أ) اعتماد تدابير ملموسة وفعالة لضمان إمكانية وصول الأشخاص ذوي الإعاقة، ولا سيما النساء والفتيات ذوات الإعاقة من ضحايا العنف الجنساني والأطفال ذوي الإعاقة من ضحايا سوء المعاملة، إلى الخدمات والمعلومات، بما في ذلك خطوط الاتصال المباشر ومراكز الإيواء وخدمات دعم الضحايا، والمشورة والنصح، وإلى آليات تقديم الشكاوى المخولة، في جملة أمور، بتقديم تعويضات وفرض جزاءات على الجناة؛", "", "" },
                    { 351, null, "R15P4", "ت.15.ف.4", "", "En cours", "", 30, 6, null, 8, null, 30, null, "Organes de traités", @"Le Comité recommande à l’État partie, conformément à son observation générale no 3 (2016) sur les femmes et les filles handicapées et à la cible 5.2 des objectifs de développement durable, de mettre fin à toute forme de violence à l’égard des femmes et des filles handicapées dans les sphères tant publique que privée, notamment à la traite et à l’exploitation, sexuelle et autre. Il recommande également à l’État partie : 
                d) Mettre en place des mécanismes efficaces permettant de faire en sorte que les femmes et les filles handicapées qui sont victimes de violence et de maltraitance soient protégées et qu’elles puissent bénéficier de soins médicaux, d’un soutien psychologique et de services juridiques au même titre que les autres.", @"تماشياً مع التعليق العام رقم 3(2016) بشأن النساء والفتيات ذوات الإعاقة والغاية 5-2 من أهداف التنمية المستدامة، توصي اللجنة الدولة الطرف بالقضاء على جميع أشكال العنف ضد النساء والفتيات في المجالين العام والخاص، بما في ذلك الاتجار بالبشر والاستغلال الجنسي وغير ذلك من أشكال الاستغلال. وتوصي الدولة الطرف أيضاً بما يلي:‬‬‬‬ ‬‬
                -  (د) وضع آليات فعالة لضمان حماية ضحايا العنف والاعتداء من النساء والفتيات ذوات الإعاقة وضمان إمكانية حصولهن على خدمات الرعاية الطبية والرعاية النفسية - الاجتماعية والخدمات القانونية على قدم المساواة مع الآخرين", "", "" },
                    { 155, null, "R38 P2", "ت.38.ف.2", "", "En cours", "", 30, 6, null, 4, null, 30, null, "Organes de traités", "Prendre des mesures pour enquêter et poursuivre les auteurs et permettre aux victimes de la violence faites aux femmes au foyer d’accéder à des moyens de recours utiles et à une protection immédiate, y compris par la mise en place de foyers d’accueil en nombre suffisant.", "-          اتخاذ التدابير اللازمة للتحقيق في أعمال العنف المنزلي وملاحقة مرتكبيه وتمكين ضحاياه من الوصول إلى سبل الانتصاف الفعالة والحصول على حماية فورية بطرق منها إنشاء عدد كاف من مراكز الإيواء.", "", "" },
                    { 116, null, "R22P2", "ت.22.ف2", "", "En cours", "", 30, 6, null, 3, null, 30, null, "Organes de traités", @"Veiller à garantir un accès effectif à l’avortement légal, notamment en éliminant les conditions contraignantes envisagées dans le projet de loi. 
                - Promouvoir et garantir l’accès à la contraception, à l’éducation et aux services de santé sexuelle et reproductive.", @"الحرص على توفير سبل فعالة إلى الإجهاض القانوني، لا سيما بإلغاء الشروط الصارمة المقترح إدراجها في مشروع القانون.
                -  تشجيع اللجوء إلى وسائل منع الحمل والتعليم وخدمات الصحة الجنسية والإنجابية وتكفلها", "", "" },
                    { 115, null, "R16P2P3", "ت.16.ف.2.ف.3", "", "Réalisé", "", 100, 6, null, 3, null, 30, null, "Organes de traités", @"b) faciliter le dépôt de plaintes pour violences en veillant à ce que les cas de violence à l’égard des femmes fassent l’objet d’enquêtes approfondies, que les auteurs soient poursuivis et condamnés, et que les victimes aient accès à des recours utiles et ne soient pas poursuivies pour relations sexuelles hors mariage ; 
                c) garantir une prise en charge légale, médicale et psychologique des victimes de violences domestiques et sexuelles, améliorer les services des structures d’accueil et les dispositifs de prise en charge des victimes.", @"(ب) تيسير تقديم الشكاوى من العنف بحيث يحقَّق في قضايا العنف بالنساء تحقيقاً متعمقاً، وملاحقة الجناة وإدانتهم، وتوفير سبل انتصاف فعالة للضحايا وعدم ملاحقتهم بسبب علاقاتهم الجنسية خارج نطاق الزواج؛ 
                - (ج) توفير الرعاية القانونية والطبية والنفسية لضحايا العنف المنزلي والجنسي، وتحسين خدمات مرافق الرعاية وترتيبات رعاية الضحايا.", "", "" },
                    { 114, null, "R14P2", "ت.14.ف.2", "", "En cours", "", 30, 6, null, 3, null, 30, null, "Organes de traités", "b) Prendre des mesures appropriées pour faire reculer la polygamie, en vue de la faire disparaître", "(ب)  اتخاذ التدابير المناسبة للحد من تعدد الزوجات قصد إلغاء هذه الممارسة", "", "" },
                    { 77, null, "R23P2P4", "ت.23.ف.2.ف.4", "", "En cours", "", 30, 6, null, 2, null, 30, null, "Organes de traités", @"Veiller à ce que les femmes et les filles victimes de violences aient immédiatement accès à des moyens de protection, y compris des foyers d’accueil, qu’elles puissent obtenir réparation et que les auteurs soient poursuivis et punis comme il convient.
                - procéder à des études sur les causes et l’ampleur de la violence à l’encontre des femmes et des filles, y compris la violence sexuelle et la violence dans la famille
                .", @"ضمان وصول النساء والفتيات ضحايا العنف فوراً إلى وسائل الحماية، بما في ذلك دور الإيواء، وعلى تمكينهن من الحصول على تعويضات، وعلى مقاضاة الجناة ومعاقبتهم على النحو المناسب.
                - إجراء دراسات بشأن أسباب ومدى انتشار العنف المرتكب في حق النساء والفتيات، بما في ذلك العنف الجنسي والعنف الأُسري.", "", "" },
                    { 25, null, "R17", "ت.17", "", "En cours", "", 30, 6, null, 1, null, 30, null, "Organes de traités", "Prendre toutes les mesures nécessaires afin de s’assurer de la pleine application du Code de la famille de manière uniforme sur tout le territoire national et d’éviter que certaines catégories parmi les plus vulnérables de sa population, en particulier les femmes et les enfants résidant dans les régions éloignées, ne soient victimes de doubles ou multiples discriminations.", "اتخاذ جميع التدابير الضرورية لضمان تطبيق كامل وموحد لمدونة الأسرة في جميع أنحاء الإقليم الوطني ولتفادي وقوع فئات معينة من أضعف السكان، وخاصةً النساء والأطفال في المناطق النائية، ضحية التمييز المزدوج أو المتعدد. وتذكّر اللجنة الدولة الطرف خصوصاً بتوصيتها العامة رقم 25(2000) بشأن أبعاد التمييز العنصري المتعلقة بنوع الجنس.", "", "" },
                    { 625, null, "R86P2-1-2", "ت.86.ف.2ج1ج2", "", "Réalisé", "", 100, 5, null, null, null, 29, 7, "Procédure spéciale", @"veiller à ce que les officiers de l’état civil observent pleinement les dispositions de la circulaire du 9 avril 2010 sur le choix des prénoms du Ministère des affaires 26es. 
                - ouvrir en temps voulu des recours effectifs aux individus dont on a refusé d’inscrire les enfants sous le prénom choisi. Dans un tel cas, les officiers d’état civil devraient répondre par écrit aux demandeurs, en temps voulu, en indiquant clairement les raisons de leur refus et les possibilités de recours.", @"(ب) ضمان تقيد سجلات الحالة المدنية تقيدا تاما بأحكام مذكروزارة الداخلية المؤرخة 9 نيسان/أبريل 2010 والمتعلقة باختيار الأسماء.
                -   إتاحة الوصول إلى سبل الانتصاف في الوقت المناسب وبشكل فعال للأشخاص الذين حرموا من تسجيل أسماء أطفالهم. وفي هذه الحالة، ينبغي أن يقدم موظفو الحالة المدنية ردوداً خطية إلى أصحاب الطلبات، في الوقت المناسب، مع الإشارة بوضوح لأسباب هذا الرفض وإمكانيات الطعن فيه.", "", "" },
                    { 284, null, "R31P1P2P3", "ت.31.ف.1.ف2.ف3", "", "En cours", "", 30, 5, null, 7, null, 29, null, "Organes de traités", @"a) Adopter toutes les mesures nécessaires en vue d’une application effective des modifications apportées à la loi sur la nationalité et à modifier le paragraphe 7 de l’article 16 de la loi no 37-99 pour faire en sorte que toutes les mères, sans distinction aucune, puissent transmettre leur nom de famille à leurs enfants;
                b) Faire en sorte que tous les enfants nés sur le territoire de l’État partie, quel que soit le statut de leurs parents ou la nature de leur permis de résidence, soient enregistrés et obtiennent immédiatement un bulletin de naissance officiel sans obstacle indu;
                c) Abolir les frais imposés pour l’obtention d’un bulletin de naissance, prolonger le court délai d’enregistrement des nouveau-nés (trente jours) et faciliter la délivrance de bulletins de naissance à tous les enfants réfugiés qui n’en possèdent pas encore un;", @"(أ) اتخاذ جميع التدابير اللازمة لتنفيذ إصلاح قانون الجنسية تنفيذاً فعالاً، وتعديل الفقرة 7 من المادة 16 من القانون رقم 37-99 بحيث تستطيع جميع الأمهات، دون تمييز، نقل أسمائهن العائلية إلى أطفالهن؛
                - (ب) تأمين تسجيل جميع الأطفال المولودين على أراضيها، بصرف النظر عن وضع والديهم أو تصاريح إقامتهم القانونية، وتوفير شهادات ميلاد رسمية لهم على الفور، دون أي حواجز لا مبرر لها؛ 
                - (ج) إلغاء رسوم شهادات الميلاد، وتمديد فترة تسجيل الوِلْدان القصيرة (30 يوماً) وتيسير تقديم شهادات الميلاد لجميع أطفال اللاجئين الذين لا يزالون يفتقرون إليها", "", "" },
                    { 113, null, "R18P3", "ت.18.ف.3", "", "En cours", "", 30, 5, null, 3, null, 28, null, "Organes de traités", "Réduire la durée initiale de la garde à vue à quarante-huit heures au maximum, y compris pour les affaires liées au terrorisme, et permettre l’accès à un avocat dès le début de la détention.", "-          تقليص المدة الأولية للاحتجاز لدى الشرطة إلى 48 ساعة على أقصى تقدير، بما في ذلك في القضايا المرتبطة بالإرهاب، والسماح بتوكيل محام منذ بداية الاحتجاز.", "", "" },
                    { 76, null, "R8P3", "ت.8.ف.3", "", "Réalisé", "", 100, 5, null, 2, null, 28, null, "Organes de traités", "Conformément aux résolutions du Conseil de sécurité, notamment 1456 (2003) et 1566 (2004), et à d’autres résolutions pertinentes, les mesures de lutte contre le terrorisme doivent être appliquées dans le plein respect du droit international relatif aux droits de l’homme.", "-          يجب، وفقاً لقرارات مجلس الأمن، وخاصة القرارين 1456(2003) و1566(2004) والقرارات الأخرى الوثيقة الصلة بالموضوع، تطبيق تدابير مكافحة الإرهاب في نطاق الاحترام التام للقانون الدولي المتعلق بحقوق الإنسان.", "", "" },
                    { 24, null, "R15", "ت.15", "", "Réalisé", "", 100, 5, null, 1, null, 28, null, "Organes de traités", "Assurer l’application des garanties juridiques fondamentales aux personnes soupçonnées de terrorisme, en particulier des étrangers, en tenant compte de la Déclaration adoptée par le Comité, le 8 mars 2002 sur la discrimination raciale et les mesures de lutte contre le terrorisme (A/57/18, paragraphe 514).", "الحرص على ضمان تطبيق الضمانات القانونية الأساسية على الأشخاص الذين يُشتبه في تورطهم في الإرهاب، خاصةً إذا كانوا يحملون جنسية أجنبية، مع اعتبار الإعلان الذي اعتمدته اللجنة في 8 آذار/مارس 2002 بشأن التمييز العنصري وتدابير مكافحة الإرهاب (A/57/18، الفقرة 514).", "", "" },
                    { 187, null, "R10P2P3", "ت.10.ف2.ف3.", "", "Réalisé", "", 100, 6, null, 5, null, 34, null, "Organes de traités", @"Veiller à ce que la politique globale migratoire en cours d’élaboration se réfère aux différents instruments internationaux des droits de l’homme et plus particulièrement à la Convention. 
                - Renforcer les mesures visant à surveiller l’application de la 9 relative aux travailleurs migrants, ainsi que celle de la Convention", @"الحرص على استرشاد السياسة العامة التي تجري صياغتها فيما يتعلق بالهجرة بمختلف الصكوك الدولية لحقوق الإنسان، لا سيما الاتفاقية.
                وتعزيز التدابير الرامية إلى مراقبة تطبيق التشريعات المتعلقة بالعمال المهاجرين وتطبيق الاتفاقية في مرحلة لاحقة.", "", "" },
                    { 1119, null, "P1R 144.111", "111.144. ج.1", "", "Réalisé", "", 100, 5, 1, null, 51, 27, null, "Examen périodique universal", "Supprimer les pratiques restrictives à l’encontre des chrétiens et d’autres minorités conformément au droit international", "إزالة الممارسات التقييدية في حق المسيحيين وأقليات أخرى.. .......", "", "" },
                    { 1121, null, "R144.182", "182.144", "", "Réalisé", "", 100, 6, 1, null, 28, 30, null, "Examen périodique universal", "Continuer à promouvoir l’égalité entre hommes et femmes dans les politiques publiques", "مواصلة تعزيز المساواة بين الرجال والنساء في السياسات العامة", "", "" },
                    { 1122, null, "R144.183", "183.144", "", "Réalisé", "", 100, 6, 1, null, 77, 30, null, "Examen périodique universal", "Continuer de promouvoir l’égalité des sexes et la participation des femmes à la vie politique et aux services publics", "مواصلة تشجيع المساواة بين الجنسين وإشراك المرأة في الحياة السياسية والوظيفة العمومية", "", "" },
                    { 1124, null, "R144.187", "187.144", "", "Réalisé", "", 100, 6, 1, null, 43, 30, null, "Examen périodique universal", "Comme suite aux recommandations issues du deuxième cycle figurant dans le document A/HRC/21/3 (par. 129.19, 129.22, 129.27, 129.39, 129.40, 129.43, 129.78, 129.88, 129.93 et 131.7), intensifier les efforts visant à améliorer les droits économiques, sociaux et culturels de la population féminine, avec leur pleine participation", "متابعة للتوصيات المنبثقة عن الجولة الثانية والواردة في الوثيقة A/HRC/21/3، الفقرات 129-19 و129-22 و129-27 و129-39 و129-40 و129-43 و129-78 و129-88 و129-93 و131-7، وتكثيف الجهود من أجل تحسين التمتع بالحقوق الاقتصادية والاجتماعية والثقافية مع مشاركة النساء مشاركة تامة", "", "" },
                    { 1125, null, "R144.190", "190.144", "", "Réalisé", "", 100, 6, 1, null, 36, 30, null, "Examen périodique universal", "Prendre toutes les mesures nécessaires afin de renforcer la lutte contre la violence domestique et les violences sexuelles envers les femmes", "اتخاذ جميع التدابير الضرورية لتشديد مكافحة العنف المنزلي والعنف الجنسي الذي يمارَس على النساء", "", "" },
                    { 1152, null, "R144.209", "209.144", "", "Réalisé", "", 100, 6, 1, null, 67, 30, null, "Examen périodique universal", "Mettre en place une législation spécifique pour prévenir les violences faites aux femmes, mener des enquêtes sur ces actes et les réprimer", "وضع تشريع محدد لمنع العنف على المرأة والتحقيق فيه والمعاقبة عليه", "", "" },
                    { 1151, null, "R144.208", "208.144", "", "Réalisé", "", 100, 6, 1, null, 90, 30, null, "Examen périodique universal", "Adopter et appliquer une loi globale et non discriminatoire sur la violence à l’égard des femmes et des filles", "اعتماد وتنفيذ قانون شامل ولا تمييزي بشأن العنف على النساء والبنات", "", "" },
                    { 1150, null, "R144.206", "206.144", "", "Réalisé", "", 100, 6, 1, null, 86, 30, null, "Examen périodique universal", "Accélérer la promulgation de la loi sur la violence à l’égard des femmes et l’adoption de la définition internationale de la violence fondée sur le genre", "الإسراع في سنّ القانون المتعلق بالعنف على المرأة واعتماد التعريف العالمي للعنف القائم على أساس نوع الجنس", "", "" },
                    { 1149, null, "R144.205", "205.144", "", "En cours", "", 30, 6, 1, null, 76, 30, null, "Examen périodique universal", "Renforcer la législation pour assurer l’égalité entre les sexes, en particulier pour prévenir la violence à l’égard des femmes, et mettre un terme aux mariages précoces et forcés", "تقوية التشريعات وتشديدها لكفالة المساواة بين الجنسين وخاصة لمنع العنف على المرأة ووقف حالات الزواج المبكر والقسري", "", "" },
                    { 1148, null, "R144.204", "204.144", "", "Réalisé", "", 100, 6, 1, null, 69, 30, null, "Examen périodique universal", "Adopter une loi générale sur la violence à l’égard des femmes, conformément aux normes internationales, en fournissant les moyens de sa mise en œuvre effective", "اعتماد قانون عام متعلق بالعنف على المرأة بما يتفق مع المعايير الدولية مع توفير وسائل تنفيذه تنفيذاً فعالاً", "", "" },
                    { 1147, null, "R144.203", "203.144", "", "Réalisé", "", 100, 6, 1, null, 65, 30, null, "Examen périodique universal", "Mettre en œuvre la loi sur la violence à l’égard des femmes rapidement", "تنفيذ القانون المتعلق بالعنف على المرأة بصورة عاجلة", "", "" },
                    { 1146, null, "R144.202", "202.144", "", "Réalisé", "", 100, 6, 1, null, 60, 30, null, "Examen périodique universal", "Adopter une législation spécifique sur la violence à l’égard des femmes, y compris les dispositions pénales et civiles nécessaires pour remédier à la violence familiale et au harcèlement sexuel des femmes et des filles", "اعتماد تشريعات محددة بشأن العنف على المرأة تتضمن أحكاماً جنائية ومدنية ضرورية للتصدي للعنف المنزلي والتحرش الجنسي بالنساء والفتيات", "", "" },
                    { 1144, null, "R144.199", "199.144", "", "Réalisé", "", 100, 6, 1, null, 49, 30, null, "Examen périodique universal", "Renforcer le cadre juridique visant à prévenir la discrimination et la violence à l’égard des femmes, notamment la violence familiale", "تقوية الإطار القانوني منعاً للتمييز والعنف على المرأة، ولا سيما العنف المنزلي", "", "" },
                    { 1143, null, "R144.198", "198.144", "", "Réalisé", "", 100, 6, 1, null, 3, 30, null, "Examen périodique universal", "Mettre en œuvre des mesures adéquates pour assurer la protection complète et efficace des femmes contre la violence familiale et accélérer le processus de rédaction d’un projet de loi conforme aux normes internationales dans ce domaine", "تنفيذ تدابير كافية لضمان توفير الحماية الشاملة والفعالة للنساء من العنف المنزلي وتسريع عملية صياغة مشروع قانون يتماشى مع المعايير الدولية لتوفير الحماية الشاملة والفعالة للنساء من العنف المنزلي", "", "" },
                    { 1142, null, "R144.197", "197.144", "", "En cours", "", 30, 6, 1, null, 17, 30, null, "Examen périodique universal", "Ériger en infraction le viol conjugal et les menaces de violence dans le cadre de son projet de loi 103.13 sur la lutte contre la violence à l’égard des femmes et mettre en œuvre des programmes, financés par l’État, pour soutenir les victimes", "تجريم الاغتصاب في إطار الزواج والتهديدات بالعنف كجزء من مشروع القانون 103-13 المتعلق بمكافحة العنف على المرأة وتنفيذ برامج برعاية الدولة لمساندة الضحايا", "", "" },
                    { 1141, null, "R144.195", "195.144", "", "Réalisé", "", 100, 6, 1, null, 12, 30, null, "Examen périodique universal", "Accélérer l’adoption du projet de loi no 103.13 sur la violence à l’égard des femmes, tout en tenant compte de l’importance de l’élargissement de la protection destinée aux femmes victimes de violence, et ériger en infraction le viol conjugal", "تسريع اعتماد مشروع القانون 103-13 المتعلق بالعنف على المرأة، مع مراعاة أهمية توسيع نطاق الحماية ليشمل النساء ضحايا العنف ولتجريم الاغتصاب في إطار الزواج", "", "" },
                    { 1140, null, "R144.194", "194.144", "", "En cours", "", 30, 6, 1, null, 7, 30, null, "Examen périodique universal", "Modifier la législation interne pour supprimer toutes les formes de discrimination sexiste et protéger les droits des femmes et des enfants", "تعديل التشريعات الداخلية لإزالة جميع أشكال التمييز القائم على نوع الجنس ولحماية حقوق المرأة والطفل", "", "" },
                    { 1154, null, "R144.210", "210.144", "", "Réalisé", "", 100, 6, 1, null, 86, 30, null, "Examen périodique universal", "Régler le nouveau protocole de la loi sur l’avortement pour donner aux femmes le droit d’avorter en cas d’inceste ou de viol, sur base du rapport de police seulement", "تعديل قانون الإجهاض الجديد لمنح النساء الحق في الإجهاض في حالات التعرض لزنا المحارم والاغتصاب بناءً على محضر الشرطة فقط", "", "" },
                    { 1139, null, "R144.189", "189.144", "", "Réalisé", "", 100, 6, 1, null, 18, 30, null, "Examen périodique universal", "Renforcer le cadre juridique existant pour protéger les femmes contre toutes les formes de violence et éliminer toutes les normes juridiques à caractère sexiste", "تقوية الإطار القانوني القائم من أجل حماية النساء من جميع أشكال العنف وإزالة جميع القواعد القانونية التمييزية القائمة على نوع الجنس", "", "" },
                    { 1137, null, "R144.133", "133.144", "", "Non réalisé", "", 0, 6, 1, null, 26, 30, null, "Examen périodique universal", "Abroger les dispositions qui privent les femmes de la tutelle légale des enfants mineurs sur un pied d’égalité avec les hommes", "إلغاء الأحكام القانونية التي تحرم النساء من ممارسة الوصاية القانونية على الأطفال القصّر على قدم المساواة مع الرجال", "", "" },
                    { 1136, null, "R144.132", "132.144", "", "Non réalisé", "", 0, 6, 1, null, 21, 30, null, "Examen périodique universal", "Abolir la disposition empêchant les Marocaines de transmettre leur nationalité à leur mari étranger", "إلغاء النص القانوني الذي يمنع النساء المغربيات من نقل جنسيتهن إلى أزواجهن الأجانب", "", "" },
                    { 1135, null, "R144.228P1", "228.144 ج.1", "", "En cours", "", 30, 6, 1, null, 38, 30, null, "Examen périodique universal", "Accélérer encore les efforts visant à promouvoir les droits des femmes en particulier ceux qui sont handicapés", "زيادة تسريع الجهود المبذولة لأجل تعزيز حقوق المرأة...... ولا سيما ذوي الإعاقات منهم", "", "" },
                    { 1134, null, "R144.221", "221.144.", "", "Réalisé", "", 100, 6, 1, null, 50, 30, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir la participation politique des femmes", "مواصلة الجهود الرامية إلى تعزيز مشاركة المرأة في الحياة السياسية", "", "" },
                    { 1133, null, "R144.220", "220.144", "", "En cours", "", 30, 6, 1, null, 30, 30, null, "Examen périodique universal", "Renforcer la promotion de la participation politique des femmes et des jeunes", "زيادة تعزيز مشاركة المرأة والشباب في الحياة السياسية", "", "" },
                    { 1132, null, "R144.214", "214.144", "", "Réalisé", "", 100, 6, 1, null, 83, 30, null, "Examen périodique universal", "Adopter des mesures appropriées en vue d’intégrer davantage les femmes dans les activités économiques et de leur garantir le droit à l’égalité de traitement et l’égalité de rémunération pour un travail de valeur égale", "اعتماد التدابير المناسبة بغية إدماج النساء أكثر في الأنشطة الاقتصادية وضمان حقهن في المعاملة المتساوية والأجر المتساوي لقاء العمل ذي القيمة المتساوية", "", "" },
                    { 1131, null, "R144.212", "212.144", "", "Réalisé", "", 100, 6, 1, null, 41, 30, null, "Examen périodique universal", "Prendre des mesures supplémentaires sur la violence familiale", "اتخاذ مزيد من التدابير بشأن العنف المنزلي", "", "" },
                    { 1130, null, "R144.211", "211.144", "", "Réalisé", "", 100, 6, 1, null, 91, 30, null, "Examen périodique universal", "Intensifier les efforts pour combattre la violence à l’égard des femmes en appliquant strictement les lois pertinentes et améliorer les mécanismes d’assistance aux victimes", "تكثيف الجهود لمكافحة العنف على المرأة بتطبيق القوانين ذات الصلة تطبيقاً صارماً وبتحسين آليات مساندة الضحايا", "", "" },
                    { 1129, null, "R144.207", "207.144", "", "Réalisé", "", 100, 6, 1, null, 31, 30, null, "Examen périodique universal", "Accomplir de nouveaux progrès dans la lutte contre toutes les formes de discrimination et de violence à l’égard des femmes en mettant en service l’Autorité pour l’égalité des sexes et la lutte contre toutes les formes de discrimination", "إحراز مزيد من التقدم في محاربة جميع أشكال التمييز والعنف على المرأة وبدئ هيئة المناصفة ومكافحة كل أشكال التمييز عملها", "", "" },
                    { 1128, null, "R144.198P1", "198.144", "", "En cours", "", 30, 6, 1, null, 3, 30, null, "Examen périodique universal", "Mettre en œuvre des mesures adéquates pour assurer la protection complète et efficace des femmes contre la violence familiale", "تنفيذ تدابير كافية لضمان توفير الحماية الشاملة والفعالة للنساء من العنف المنزلي وتسريع عملية صياغة مشروع قانون يتماشى مع المعايير الدولية لتوفير الحماية الشاملة والفعالة للنساء من العنف المنزلي", "", "" },
                    { 1127, null, "R144.193", "193.144", "", "Réalisé", "", 100, 6, 1, null, 93, 30, null, "Examen périodique universal", "Continuer de s’employer à lutter contre les violences faites aux femmes", "مواصلة الجهود لمكافحة العنف على المرأة", "", "" },
                    { 1126, null, "R144.192", "192.144", "", "Réalisé", "", 100, 6, 1, null, 85, 30, null, "Examen périodique universal", "Prendre toutes les mesures nécessaires afin de renforcer la lutte contre la violence domestique et les violences sexuelles envers les femmes", "اتخاذ جميع التدابير الضرورية لتشديد مكافحة العنف المنزلي والعنف الجنسي الذي يمارَس على النساء", "", "" },
                    { 1138, null, "R144.188", "188.144", "", "En cours", "", 30, 6, 1, null, 44, 30, null, "Examen périodique universal", "Adopter une 9 complète et globale visant à éliminer la discrimination et toutes les formes de violence à l’égard des femmes et à les promouvoir dans tous les domaines, notamment le domaine économique", "اعتماد تشريعات شاملة ومتكاملة للقضاء على التمييز وعلى جميع أشكال العنف على المرأة ولتشجيع ارتقائها في جميع المجالات بما فيها المجال الاقتصادي", "", "" },
                    { 188, null, "R20P2", "ت.20.ف2", "", "En cours", "", 30, 6, null, 5, null, 34, null, "Organes de traités", "prendre sans délai des mesures efficaces pour lutter contre la stigmatisation sociale et raciale envers les travailleurs migrants, particulièrement les travailleurs migrants subsahariens.", "المبادرة إلى اتخاذ تدابير فعالة من أجل مكافحة الوصم الاجتماعي والعنصري الذي يتعرض له العمال المهاجرون، لا سيما المنحدرون من أفريقيا جنوب الصحراء.", "", "" },
                    { 630, null, "R83P2", "ت.83.ف.2", "", "Non réalisé", "", 0, 8, null, null, null, 36, 7, "Procédure spéciale", "Les nouvelles lois et mesures relatives à la mise en œuvre de nouvelles dispositions constitutionnelles, en particulier celles qui concernent les droits et la diversité culturels exigent l’adoption de politiques et stratégies pertinentes, et ceux qui sont chargés de mettre celles-ci en œuvre doivent recevoir une formation et des orientations à cet effet.", "-       تتطلب القوانين والتدابير الجديدة  المتعلقة بإنفاذ الأحكام الدستورية الجديدة، لا سيما تلك الخاصة بالحقوق الثقافية والتنوع الثقافي اعتماد سياسات واستراتيجيات مناسبة وينبغي أن تقترن بتدريب مناسب وتوجيه صحيح للمسؤولين المكلفين بتطبيقها.", "", "" },
                    { 190, null, "R24", "ت.24", "", "Réalisé", "", 100, 6, null, 5, null, 34, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que tous les travailleurs migrants et les membres de leur famille puissent librement quitter l’État partie, y compris les travailleurs migrants marocains et les membres de leur famille.", "اتخاذ التدابير اللازمة لضمان إمكانية أن يغادر الدولة بحرية جميع العمال المهاجرين وأفراد أسرهم، بمن فيهم العمال المهاجرون المغاربة وأفراد أسرهم، انسجاما مع مقتضيات المادة 8 من الاتفاقية.", "", "" },
                    { 197, null, "R51", "ت.51", "", "En cours", "", 30, 7, null, 5, null, 37, null, "Organes de traités", "diffuser largement les présentes observations finales, notamment auprès des organismes publics et du pouvoir judiciaire, des organisations non gouvernementales et autres membres de la société civile, et de prendre des mesures pour les faire connaître aux migrants marocains à l’étranger ainsi qu’aux travailleurs migrants étrangers en transit ou résidant au Maroc.", "تعميم الملاحظات الختامية على نطاق واسع، لا سيما على المؤسسات العامة والسلطة القضائية والمنظمات غير الحكومية وجهات المجتمع المدني الأخرى، واعتماد تدابير من أجل إطلاع المهاجرين المغاربة في الخارج والعمال المهاجرين الأجانب العابرين للمغرب أو المقيمين به على هذه الملاحظات.", "", "" },
                    { 196, null, "R20P4", "ت.20.ف4", "", "En cours", "", 30, 7, null, 5, null, 37, null, "Organes de traités", "Mener des campagnes de sensibilisation et d’éducation au sujet de toutes les formes de discrimination raciale.", "تنظيم حملات توعية وتثقيف في مجال. مناهضة العنصرية وجميع أشكال التمييز العنصري", "", "" },
                    { 162, null, "R32P2", "ت.32.ف.2", "", "Réalisé", "", 100, 8, null, 4, null, 37, null, "Organes de traités", "-            Prendre des mesures pour que les victimes (Harcèlement sexuel, notamment dans le milieu du travail) puissent déposer plainte sans craindre des représailles et aient accès aux voies de recours et à une réparation adéquate.", "-          اتخاذ جميع التدابير التي تمكن ضحايا التحرش الجنسي لا سيما في مكان العمل من تقديم شكاوى دون خوف من الانتقام، ومن الوصول إلى سبل الانتصاف والحصول على الجبر المناسب.", "", "" },
                    { 161, null, "R30P3", "ت.30.ف.3", "", "En cours", "", 30, 8, null, 4, null, 37, null, "Organes de traités", "-            Mettre sur pied un mécanisme d’inspection pour contrôler les conditions de travail des employés de maison.", "إنشاء آلية تفتيش لرصد ظروف عمل العمال المنزليين.", "", "" },
                    { 160, null, "R12P3", "ت.12.ف.3", "", "En cours", "", 30, 8, null, 4, null, 37, null, "Organes de traités", "-            c) Encourager l’instance nationale de la probité, de la prévention et de la lutte contre la corruption à faire figurer dans ses rapports annuels une description des cas de corruption traités par elle pour dissuader la commission de tels actes et renforcer l’application effective de la loi", "-          (ج) تشجيع الهيئة الوطنية للنزاهة والوقاية من الرشوة ومحاربتها على تضمين تقاريرها السنوية وصفاً لحالات الفساد التي عالجتها ردعاً لمرتكبي هذه الأفعال وتعزيزاً لتطبيق القانون على نحو فعال؛", "", "" },
                    { 159, null, "R18P1P2", "ت.18.ف.1.ف.2", "", "En cours", "", 30, 7, null, 4, null, 37, null, "Organes de traités", @"Tenant compte de son observation générale no 16 (2005) sur le droit égal de l’homme et de la femme au bénéfice de tous les droits économiques, sociaux et culturels, le Comité recommande de :
                - a) Combattre la discrimination contre les femmes à travers notamment des campagnes de sensibilisation auprès de la population, en particulier des chefs religieux et traditionnels en vue de l’élimination de toute forme de discrimination fondée sur le sexe………
                - b) Abolir la polygamie et de mener des campagnes de sensibilisation pour éliminer les stéréotypes sexistes et promouvoir les droits des femmes", @"في ضوء تعليقها العام رقم 16(2005) بشأن المساواة بين الرجل والمرأة في حق التمتع بجميع الحقوق الاقتصادية والاجتماعية والثقافية، توصي اللجنة بما يلي:
                -  (أ)مكافحة التمييز ضد المرأة بوسائل منها تنظيم حملات للتوعية في أوساط السكان، وبخاصة في صفوف الزعماء الدينيين والتقليديين، من أجل القضاء على جميع أشكال التمييز الجنساني. 
                -  ب) إلغاء تعدد الزوجات وتنظيم حملات توعية للقضاء على التنميط الجنساني وتعزيز حقوق المرأة؛", "", "" },
                    { 121, null, "R51", "ت.51", "", "Réalisé", "", 100, 7, null, 3, null, 37, null, "Organes de traités", @"Assurer une large diffusion du Pacte, du sixième rapport périodique, des réponses écrites à la liste de points établie par le Comité et des observations finales afin de sensibiliser les autorités judiciaires, législatives et administratives, la société civile, les organisations non gouvernementales œuvrant dans le pays et le grand public aux droits consacrés par le Pacte. 
                veiller à ce que le rapport et les présentes observations finales soient traduits dans les langues officielles", "نشر نص العهد، والتقرير الدوري السادس، والردود الخطية على قائمة المسائل التي وضعتها اللجنة، وهذه الملاحظات الختامية، على نطاق واسع من أجل توعية السلطات القضائية والتشريعية والإدارية، والمجتمع المدني، والمنظمات غير الحكومية العاملة في البلد، وعامة الناس، بالحقوق التي يكرسها العهد. وينبغي أن تترجم التقرير وهذه الملاحظات الختامية إلى لغتيها الرسميتين.", "", "" },
                    { 83, null, "R32", "ت.32", "", "Réalisé", "", 100, 7, null, 2, null, 37, null, "Organes de traités", "-            Diffuser largement les rapports soumis au Comité, ainsi que les conclusions et recommandations de celui-ci, par le biais des sites Internet officiels, des médias et des organisations non gouvernementales.", "-           النشر، على نطاق واسع، للتقارير التي تم تقديمها إلى اللجنة وكذلك استنتاجات اللجنة وتوصياتها، عن طريق مواقع الانترنت الرسمية وعبر وسائل الإعلام والمنظمات غير الحكومية.", "", "" },
                    { 82, null, "R24P2", "ت.24.ف.2", "", "En cours", "", 30, 7, null, 2, null, 37, null, "Organes de traités", "-            sensibiliser le public aux formes positives, participatives et non violentes de discipline des enfants", "في سياق تربية الأطفال سواء داخل الأسرة أو داخل مراكز حماية الطفل، يجب توعية الجمهور فيما يتعلق بأشكال التأديب الإيجابية التشاركية لا على الأشكال العنيفة .", "", "" },
                    { 30, null, "R20P2", "ت.20.ف2", "", "En cours", "", 30, 7, null, 1, null, 37, null, "Organes de traités", "- Poursuivre les initiatives de sensibilisation et d’éducation du public, à la diversité multiculturelle, à l’entente et à la tolérance, notamment à l’égard de certaines catégories vulnérables, en particulier de certains amazighs, des saharawis, des noirs, des non-ressortissants, des réfugiés et des demandeurs d’asile.", "مواصلة تنفيذ مبادرات تحسيس عامة الناس وتثقيفهم بشأن التنوع الثقافي والوئام والتسامح، خصوصاً تجاه بعض الفئات الضعيفة، وخاصة بعض الأمازيغ والصحراويين والزنوج وغير المواطنين واللاجئين وطالبي اللجوء", "", "" },
                    { 29, null, "R18P2", "ت.18.ف.2", "", "En cours", "", 30, 7, null, 1, null, 37, null, "Organes de traités", "Informer la population, en particulier les catégories vulnérables et notamment les Amazighs, les Sahraouis, les noirs, les non-ressortissants, les réfugiés et les demandeurs d’asile, de toutes les voies de recours juridiques disponibles, de simplifier ces recours et d’en faciliter l’accès", "إعلام السكان، وخاصة الفئات الضعيفة ولا سيما الأمازيغ والصحراويون والزنوج وغير المواطنين واللاجئون وطالبو اللجوء، بجميع سبل الانتصاف القانونية المتاحة، وتبسيط تلك السبل وتسهيل اللجوء إليها", "", "" },
                    { 1197, null, "R144.66", "66.144", "", "En cours", "", 30, 7, 1, null, 76, 36, null, "Examen périodique universal", "Promouvoir l’éducation et la formation des agents de la fonction publique aux droits de l’homme, en veillant à la fourniture des ressources nécessaires, à tous les niveaux. Les employés de l’administration à l’échelon local, qui ont l’influence la plus directe sur la population, manquent le plus souvent de formation aux droits de l’homme ou des ressources nécessaires pour satisfaire aux normes internationales sur les droits de l’homme", "تعزيز التثقيف في ميدان حقوق الإنسان وتدريب الموظفين العموميين، إلى جانب التزويد بالموارد الضرورية على جميع المستويات. فموظفو الحكومات المحلية، الذين لهم الأثر الأكثر مباشرَة على الناس، كثيراً ما يفتقرون إلى تدريب في ميدان حقوق الإنسان أو إلى الموارد لتلبية المعايير الدولية في ميدان حقوق الإنسان", "", "" },
                    { 1196, null, "R144.65", "65.144", "", "En cours", "", 30, 7, 1, null, 54, 36, null, "Examen périodique universal", "Continuer de former les fonctionnaires aux droits de l’homme", "مواصلة تدريب المسؤولين العموميين على حقوق الإنسان", "", "" },
                    { 1195, null, "R144.64", "64.144", "", "En cours", "", 30, 7, 1, null, 9, 36, null, "Examen périodique universal", "Poursuivre l’expérience positive consistant à organiser des programmes de renforcement des capacités en matière de droits de l’homme à l’intention des organismes chargés de faire respecter la loi", "مواصلة التجربة الإيجابية المتمثلة في تنظيم برامج لبناء القدرات في ميدان حقوق الإنسان لفائدة وكالات إنفاذ القانون", "", "" },
                    { 1194, null, "R144.38", "38.144", "", "En cours", "", 30, 7, 1, null, 28, 36, null, "Examen périodique universal", "Continuer à intégrer les droits de l’homme dans différents secteurs et organismes nationaux", "مواصلة تعميم منظور حقوق الإنسان في مختلف الهيئات والقطاعات الوطنية", "", "" },
                    { 643, null, "R74P3", "null", "", "En cours", "", 30, 7, null, null, null, 36, 8, "Procédure spéciale", "Dans le cadre de leur partenariat, prévoir à l’intention de la société civile et des collectivités des activités d’éducation, de formation et de renforcement des capacités dans le domaine des droits de l’homme, afin de leur permettre d’être de véritables acteurs de leur propre développement.", "null", "", "" },
                    { 642, null, "R73P5", "null", "", "En cours", "", 30, 7, null, null, null, 36, 8, "Procédure spéciale", @"Allouer des ressources supplémentaires au renforcement des capacités à tous les niveaux de la mise en œuvre des activités de développement, compte tenu en particulier de la décentralisation imminente
                - Il est suggéré que la Délégation interministérielle aux droits de l’homme intensifie, en coordination avec le Conseil national des droits de l’homme et autres partenaires, les programmes de formation aux droits de l’homme, en particulier ceux qui sont destinés aux fonctionnaires œuvrant à la prestation de services publics. Cela améliorerait la transparence et constituerait une mesure positive en vue de prévenir le favoritisme et la corruption dans la fonction public", "null", "", "" },
                    { 635, null, "R87", "ت.87", "", "En cours", "", 30, 9, null, null, null, 36, 7, "Procédure spéciale", "lors du recensement de 2014, des informations doivent être recueillies sur la composition de la population, l’usage des langues arabe, amazighe et autres, et sur tout autre indicateur de la diversité ethnique et culturelle de la population.", "-       توصي الخبيرة المستقلة أيضاً بأن تُجمع، خلال التعداد السكاني لعام 2014، معلومات عن تركيبة السكان، واستخدام اللغتين العربية والأمازيغية وغيرهما من اللغات، وأي مؤشر آخر على التنوع الإثني والثقافي للسكان. وفي هذا الصدد، قد ترغب الحكومة في التماس مساعدة اليونسكو فيما يخص عملها المتعلق بالمؤشرات الثقافية.", "", "" },
                    { 634, null, "R90P1P2", "ت.90.ف.1.ف.2", "", "En cours", "", 30, 8, null, null, null, 36, 7, "Procédure spéciale", "- Mettre en place des mécanismes permettant une participation effective et digne de ce nom, notamment en matière de prise de décisions, de la population au recensement, à l’interprétation, à la promotion et à la protection du patrimoine culturel.", @"إنشاء آليات تسمح للأشخاص باتخاذ قرارات فعالة ومجدية والمشاركة في تحديد التراث الثقافي وتفسيره وتعزيزه وحمايته. 
                - توفير الدعم القانوني والمالي والمؤسسي لمقترح 'الكنوز البشرية الحية'.", "", "" },
                    { 633, null, "R86P1-5", "ت.86.ف1ج5", "", "En cours", "", 30, 8, null, null, null, 36, 7, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en veillant à ce que les chaînes de télévision et stations de radio qui diffusent leurs programmes en langue arabe diffusent également au moins 30 % de ceux-ci en langue amazighe, comme le prévoit la loi; des mesures supplémentaires devraient aussi être prises pour élaborer des programmes aux niveaux national et régional afin d’appuyer les activités menées pour promouvoir la connaissance du patrimoine culturel et la diversité culturelle dans le cadre des émissions pédagogiques et destinées à la jeunesse et pour associer les médias nationaux à cette action", @"(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                - 5-ضمان قيام قنوات وسائط الإعلام التي تبث برامجها باللغة العربية ببث ما لا يقل عن 30 في المائة من برامجها باللغة الأمازيغية، مثلما ينص على ذلك القانون؛ وينبغي اتخاذ مزيد من التدابير لإعداد برامج على الصعيدين الوطني والإقليمي من أجل دعم الجهود الرامية إلى تعزيز معرفة التراث الثقافي والتنوع في البرامج التعليمية والشبابية، وتعبئة وسائط الإعلام الوطنية للدعوة إلى هذا النهج؛", "", "" },
                    { 632, null, "R86P1-4", "ت.86.ف1ج4", "", "En cours", "", 30, 8, null, null, null, 36, 7, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en fournissant des fonds et une assistance adéquats dans le cadre de mesures de renforcement des capacités pour promouvoir l’utilisation de la langue amazighe dans l’éducation et la vie publique; en particulier, une assistance financière supplémentaire devrait être apportée à l’IRCAM afin que ces ouvrages et publications soient largement distribués dans les zones rurales", @"(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                - 4-تقديم التمويل والمساعدة الكافيين لتدابير بناء القدرات من أجل تعزيز استخدام اللغة الأمازيغية في التعليم والحياة العامة؛ وبصورة خاصة، ينبغي تقديم مزيد من المساعدة المالية للمعهد الملكي للثقافة الأمازيغية لضمان توزيع الكتب والمنشورات ذات الصلة على نطاق واسع في المناطق الريفية؛", "", "" },
                    { 631, null, "R88P1", "ت.88.ف.1", "", "En cours", "", 30, 8, null, null, null, 36, 7, "Procédure spéciale", "Adoption d’une procédure plus efficace, plus simple et plus conviviale de présentation des projets culturels à l’INDH et aux autres institutions de développement est cruciale pour autonomiser le secteur culturel de la société civile et susciter une participation plus active aux niveaux régional et national.", "-       اعتماد عملية أكثر فعالية وبساطة وسهولة في الاستعمال لتقديم الطلبات فيما يخص المشاريع الثقافية التي تدخل في إطار المبادرة الوطنية للتنمية البشرية وغيرها من الوكالات الإنمائية، لتمكين القطاع المدني الثقافي والسماح بمشاركة أكثر فعالية على الصعيدين الإقليمي والوطني.", "", "" },
                    { 629, null, "R86P1-6", "ت.86.ف1ج6", "", "En cours", "", 30, 7, null, null, null, 36, 7, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en encourageant les fonctionnaires et administrateurs fournissant des services publics aux locuteurs amazighs, les juges et les avocats à améliorer leurs connaissances linguistiques et en veillant à ce que des interprètes de langue amazighe soient formés et disponibles auprès des tribunaux ;", @"(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                - 6- تعزيز المهارات اللغوية في صفوف الموظفين الحكوميين والإداريين الذين يقدمون خدمات عامة للناطقين بالأمازيغية، وفي صفوف القضاة والمحاميين، وضمان تدريب وتوفر مترجمين شفويين لدى المحاكم", "", "" },
                    { 571, null, "R91P5", "null", "", "En cours", "", 30, 7, null, null, null, 36, 5, "Procédure spéciale", "Faciliter l’accès des 32aires des deux sexes, en particulier ceux qui sont élus pour la première fois, aux services de renforcement des capacités, de façon à accroître leurs connaissances des obligations internationales de l’État en matière de droits de l’homme et de tous les aspects des droits fondamentaux des femmes ainsi que des techniques de rédaction juridique et d’autres tâches législatives; dans les environnements où les hommes prédominent, les femmes devraient bénéficier d’une formation pour développer leur sens de la direction et leur confiance en elle-même;", "null", "", "" },
                    { 570, null, "R89P11", "null", "", "En cours", "", 30, 7, null, null, null, 36, 5, "Procédure spéciale", @"Prendre d’autres mesures pour sensibiliser et former l’ensemble du personnel et des services du secteur de la justice en ce qui concerne les obligations de l’État dans le domaine des droits de l’homme, ainsi que leur place et leur incorporation dans l’ordre juridique interne. 
                - Le Ministère de l’26, le Ministère de la justice et le Ministère de la solidarité, de la femme, de la famille et du développement social sont encouragés à assurer une sensibilisation accrue de la société à tous les aspects de la violence à l’égard des femmes et à intégrer l’information sur la prévention effective de la violence fondée sur le sexe et de la lutte contre cette violence dans les programmes de formation de la police, et de la justice et des secteurs juridique et social", "null", "", "" },
                    { 198, null, "R32P2", "ت.32.ف.2", "", "En cours", "", 30, 8, null, 5, null, 37, null, "Organes de traités", "Créer des mécanismes de surveillance qui garantissent que les reconduites à la frontière des migrants sont faites dans le strict respect des normes internationales relatives aux migrants.", "إنشاء آليات مراقبة تكفل تنفيذ عمليات إعادة المهاجرين إلى الحدود في إطار تقيد صارم بالقواعد الدولية المتعلقة بالمهاجرين.", "", "" },
                    { 199, null, "R46", "ت.46", "", "En cours", "", 30, 8, null, 5, null, 37, null, "Organes de traités", "S’assurer que les autorités consulaires ou diplomatiques fournissent des renseignements et une aide appropriée aux travailleurs migrants marocains et aux membres de leurs familles vivant à l’étranger, y compris ceux en situation irrégulière.", "كفالة  تقديم السلطات القنصلية أو الدبلوماسية معلومات ومساعدة مناسبة إلى العمال المهاجرين المغاربة وأفراد أسرهم المقيمين بالخارج، بمن فيهم الموجودون في وضع غير قانوني.", "", "" },
                    { 237, null, "R13P2", "ت.13.ف.2", "", "En cours", "", 30, 7, null, 6, null, 37, null, "Organes de traités", "Diffuser largement le texte de la Convention et de les recommandations générales auprès de toutes les parties prenantes, y compris les ministères, les 32aires, les autorités judiciaires, les partis politiques, les organisations non gouvernementales, le secteur privé et le public en général.", "-نشر الاتفاقية وتوصياتها العامة على أوسع نطاق بين جميع أصحاب المصلحة، بما في ذلك الوزارات الحكومية وأعضاء البرلمان والسلطات القضائية، والأحزاب السياسية والمنظمات غير الحكومية والقطاع الخاص وعامة الجمهور.", "", "" },
                    { 238, null, "R19", "ت.19", "", "En cours", "", 30, 7, null, 6, null, 37, null, "Organes de traités", @"S’attaquer aux stéréotypes concernant le rôle et les responsabilités des femmes et des hommes dans la famille et la société, notamment les schémas et normes cachés qui perpétuent la discrimination directe et indirecte à l’égard des femmes et des filles dans tous les domaines de la vie.
                - Redoubler d’efforts dans la conception et l’application de programmes complets de sensibilisation visant à favoriser une meilleure compréhension de l’égalité entre les hommes et les femmes à tous les échelons de la société afin de modifier les comportements stéréotypés et les normes culturelles négatives relatives au rôle des femmes et des hommes dans la famille et dans la société, conformément à l’article 5 a) de la Convention. 
                - Inciter les médias à donner une image favorable des femmes et à promouvoir l’égalité de statut et de responsabilités des femmes et des hommes dans la société", @"معالجة المواقف النمطية تجاه الأدوار والمسؤوليات المنوطة بالنساء والرجال، بما في ذلك الأنماط والأعراف الثقافية الخفية التي تعمل على إدامة التمييز المباشر وغير المباشر ضد المرأة والفتاة في كافة مناحي الحياة. 
                -مضاعفة جهودها الرامية إلى تصميم وتنفيذ برامج توعية شاملة لتحسين فهم المساواة بين المرأة والرجل على جميع مستويات المجتمع، وذلك بغرض تغيير المواقف النمطية والأعراف الثقافية السلبية بشأن المسؤوليات والأدوار المنوطة بالنساء والرجال في الأسرة والمجتمع، عملا بالمادة 5 (أ) من الاتفاقية. 
                -تشجيع وسائط الإعلام على تقديم صورة إيجابية عن المرأة وعن تكافؤ المركز والمسؤوليات بين المرأة والرجل في المجتمع", "", "" },
                    { 455, null, "R87", "null", "", "Réalisé", "", 100, 5, null, null, null, 27, 2, "Procédure spéciale", "-       Veiller à ce que tous les Marocains, y compris les membres de minorités religieuses, jouissent pleinement de leur droit à la liberté de pensée, de conscience et de religion dans des conditions d’égalité", "null", "", "" },
                    { 1198, null, "R144.63", "63.144", "", "En cours", "", 30, 7, 1, null, 54, 37, null, "Examen périodique universal", "Redoubler d’efforts pour promouvoir la culture des droits de l’homme et l’éducation aux droits de l’homme", "بذل المزيد من الجهود لتعزيز ثقافة حقوق الإنسان والتثقيف في ميدان حقوق الإنسان", "", "" },
                    { 641, null, "R73P1-2", "null", "", "En cours", "", 30, 7, null, null, null, 37, 8, "Procédure spéciale", "Les nouveaux objectifs de développement durable, le document final de la troisième Conférence internationale sur le financement du développement et l’accord sur le climat issu de la vingt et unième session de la Conférence des Parties à la Convention-cadre des Nations Unies sur les changements climatiques devraient être diffusés sous une présentation simplifiée auprès du plus grand nombre, afin que le public puisse prendre connaissance de leurs conséquences directes pour le Maroc", "null", "", "" },
                    { 572, null, "R89P12", "null", "", "En cours", "", 30, 7, null, null, null, 37, 5, "Procédure spéciale", "Mettre l’enseignement, les médias et d’autres moyens au service d’une sensibilisation accrue aux questions juridiques et d’une meilleure connaissance de ces questions, s’agissant notamment des moyens d’obtenir une réparation d’ordre judiciaire et sous toute autre forme en cas de violation des droits de l’homme et de combattre les obstacles culturels et sociaux à l’égalité et au respect des droits fondamentaux des femmes au Maroc", "null", "", "" },
                    { 545, null, "R89", "null", "", "En cours", "", 30, 7, null, null, null, 37, 4, "Procédure spéciale", @"Des efforts de sensibilisation et de renforcement des capacités devraient être entrepris d’urgence afin que les affaires de traite fassent l’objet de mesures centrées sur la victime. 
                - Le Gouvernement devrait également redoubler d’efforts pour sensibiliser le grand public à toutes les formes de traite des êtres humains, afin de mieux faire comprendre ce qui constitue une forme de traite", "null", "", "" },
                    { 465, null, "R77", "null", "", "En cours", "", 30, 7, null, null, null, 37, 2, "Procédure spéciale", "-       Redoubler d’efforts pour éliminer les préjugés, les stéréotypes négatifs et la stigmatisation et prendre des mesures efficaces visant à promouvoir la tolérance et la compréhension, conformément à l’article 7 de la Convention internationale sur l’élimination de toutes les formes de discrimination raciale", "null", "", "" },
                    { 373, null, "R63P1P2", "ت.63.ف.1.ف.2", "", "Réalisé", "", 100, 7, null, 8, null, 37, null, "Organes de traités", @"a) préciser le rôle de la commission interministérielle chargée d’appuyer la mise en œuvre de la Convention et celui des différents points de contact et, en particulier, d’adopter des mesures visant à renforcer l’efficacité de la commission et des points de contact ;
                b) mettre en place un mécanisme et un système de points de contact aux niveaux régional et local pour mettre en œuvre la Convention ;", @"(أ) تحديد أدوار اللجنة الوزارية المكلفة بدعم تنفيذ الاتفاقية وأدوار جهات التنسيق المعنية، والقيام، على وجه الخصوص، باعتماد تدابير ترمي إلى تعزيز كفاءة اللجنة وجهات التنسيق؛
                -  (ب) وضع آلية ونظام لجهات التنسيق على الصعيدين الإقليمي والمحلي من أجل تنفيذ الاتفاقية؛", "", "" },
                    { 372, null, "R35P3", "ت.35.ف. 3", "", "Réalisé", "", 100, 7, null, 8, null, 37, null, "Organes de traités", "Mettre en place un mécanisme indépendant chargé de protéger les personnes handicapées contre les actes de violence et les mauvais traitements, de contrôler, conformément au paragraphe 3 de l’article 16 de la Convention, les établissements et programmes destinés aux personnes handicapées et de fournir les ressources budgétaires nécessaires pour que ces établissements et programmes soient fonctionnels et efficaces.", "-       (ج) إنشاء آلية مستقلة لمنع تعرض الأشخاص ذوي الإعاقة للعنف والاعتداء؛ ورصد المرافق والبرامج المعدة لخدمة الأشخاص ذوي الإعاقة، تماشياً مع المادة 16(3) من الاتفاقية؛ ورصد المخصصات اللازمة في الميزانية لضمان تشغيل هذه المرافق وفعاليتها.", "", "" },
                    { 371, null, "R33P4", "ت.33.ف.4", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", "Habiliter le Conseil national des droits de l’homme, en sa qualité de mécanisme national de prévention, à surveiller tous les lieux dans lesquels les personnes handicapées peuvent être privées de liberté, en application du Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants.", "-           (ج) تمكين المجلس الوطني لحقوق الإنسان، بوصفه الآلية الوقائية الوطنية، من رصد جميع الأماكن التي يمكن أن يُسلَب فيها الأشخاص ذوو الإعاقة حريتهم، تماشياً مع البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 370, null, "R29P2P4", "ت.29.ف.2.ف.4", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", @"b) Prévoir, au sein du secteur judiciaire, des aménagements effectifs à la procédure en faveur des personnes handicapées, en fonction de leur sexe et de leur âge ;
                d) Prendre les mesures qui s’imposent pour soutenir les personnes handicapées et leur donner les moyens de travailler dans le système de justice, notamment en qualité de juges ou de procureurs, en leur apportant tout l’appui nécessaire, afin d’améliorer l’accès des personnes handicapées à la justice.", @"(ب) توفير ترتيبات إجرائية فعالة، داخل القضاء، للأشخاص ذوي الإعاقة، بحسب نوع الجنس والسن؛ 
                - (ج) ضمان استمرارية برامج التدريب وحملات التوعية والإعلام التي تستهدف موظفي المحاكم والقضاة والمدعين العامين والموظفين المكلفين بإنفاذ القوانين، بمن فيهم أفراد الشرطة وموظفو السجون، بشأن ضرورة تيسير إمكانية اللجوء إلى القضاء للأشخاص ذوي الإعاقة؛", "", "" },
                    { 369, null, "R27P2", "ت.27.ف.2", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", @"Le Comité recommande à l’État partie, conformément à son observation générale no 1 (2014) sur la reconnaissance de la personnalité juridique dans des conditions d’égalité : 
                b) D’instituer et de développer, à l’intention des personnes handicapées, des mécanismes de prise de décisions assistée qui respectent leur autonomie, leurs droits, leur volonté et leurs préférences, dans tous les domaines ;", "تماشياً مع التعليق العام رقم 1(2014) بشأن الاعتراف بالأشخاص ذوي الإعاقة على قدم المساواة مع الآخرين أمام القانون، توصي اللجنة بما يلي: (ب) استحداث وتطوير آليات لتقديم الدعم للأشخاص ذوي الإعاقة في اتخاذ القرارات تحترم استقلاليتهم وحقوقهم وإرادتهم وأفضلياتهم في جميع مجالات الحياة؛", "", "" },
                    { 368, null, "R23P2", "ت.23.ف2", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", "b) De mettre en place un mécanisme visant à contrôler le respect des normes d’accessibilité dans tous les domaines visés par la Convention, de veiller au respect de la loi no 10-03 relative aux accessibilités et d’infliger des sanctions en cas de non-respect", "-          (ب) وضع آلية لرصد الامتثال لمعايير تيسير إمكانية الوصول في جميع المجالات التي تشملها الاتفاقية، وضمان إنفاذ القانون 10-03 المتعلق بالولوجيات وفرض جزاءات في حالة عدم الامتثال للقانون؛", "", "" },
                    { 544, null, "R99P2-1", "null", "", "En cours", "", 30, 7, null, null, null, 36, 4, "Procédure spéciale", @"En ce qui les provinces marocaines du sud :
                - b) Renforcer encore les capacités actuelles pour permettre de détecter les cas de traite des êtres humains…….", "null", "", "" },
                    { 367, null, "R19", "ت.19", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", "Instituer un mécanisme permettant d’assurer une concertation effective avec les enfants handicapés, par l’intermédiaire des organisations qui les représentent, et de veiller à ce que les enfants handicapés soient pleinement intégrés au forum national des enfants, au 32de l’enfant et dans les conseils des enfants à l’échelle des municipalités et des gouvernorats, dans des conditions d’égalité avec les autres enfants.", "-      اعتماد آلية لإجراء مشاورات فعلية مع الأطفال ذوي الإعاقة من خلال المنظمات التي تمثلهم، وبضمان الإدماج الكامل للأطفال ذوي الإعاقة في المنتدى الوطني للأطفال، وبرلمان الطفل ومجالس الطفولة في المحافظات والمجالس البلدية، على قدم المساواة مع غيرهم من الأطفال.", "", "" },
                    { 365, null, "R37P2", "ت.37.ف.2", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", "Sensibiliser la population aux effets néfastes de ces pratiques et de renforcer les mécanismes visant à garantir que le consentement éclairé des personnes handicapées soit obtenu pour les traitements médicaux et chirurgicaux.", "-      .إذكاء الوعي بشأن مضار هذه الممارسات وبتعزيز الآليات الرامية إلى ضمان موافقة الأشخاص ذوي الإعاقة، موافقة مستنيرة، على أي علاج طبي أو جراحي.", "", "" },
                    { 296, null, "R77P2", "ت.77.ف.2", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", "-                        Diffuser largement dans les langues du pays les troisième et quatrième rapports périodiques, les réponses écrites du Maroc et les présentes observations finales.", "إشاعة التقرير الجامع للتقريرين الدوريين الثالث والرابع والردود الخطية الملاحظات الختامية ، بلغات البلد،.", "", "" },
                    { 295, null, "R53P5", "ت.53.ف.5", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", @"Le comité recommande au Maroc d'adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier :
                e) D’entreprendre des campagnes de sensibilisation destinées aux autorités, au public et aux familles pour combattre la stigmatisation des enfants handicapés et les préjugés à leur égard et promouvoir une image positive des enfants et des adultes handicapés.", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                -  (هـ) تنظيم حملات توعية موجهة إلى الحكومة والأسر والناس عامة لمكافحة الوصم والتحامل على الأطفال ذوي الإعاقة، وتقديم صورة إيجابية عن الأطفال والبالغين ذوي الإعاقة.", "", "" },
                    { 294, null, "R41P3", "ت.41.ف.3", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", "Exécuter des activités de sensibilisation pour combattre la stigmatisation des victimes d’exploitation et d’abus sexuels, notamment d’inceste, et de mettre en place des mécanismes accessibles, confidentiels, adaptés aux enfants et efficaces pour dénoncer de telles violations.", "تنفيذ أنشطة للتوعية من أجل مكافحة وصم ضحايا الاستغلال والاعتداء الجنسيين، بما في ذلك زنى المحارم، وتوفير قنوات ميسّرة وسرية وفعالة ومواتية للأطفال للإبلاغ عن تلك الانتهاكات.", "", "" },
                    { 293, null, "R39P5P7", "ت.39.ف.5.ف.7", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", @"Tenir compte de l’Observation générale no 13 (2011) sur le droit de l’enfant d’être protégé contre toutes les formes de violence, et en particulier de mettre en place, en étroite coopération avec la société civile, un système de protection des enfants bien coordonné et bien financé, en particulier:
                e) Renforcer davantage les programmes de sensibilisation et d’éducation, notamment les campagnes organisées avec la participation des enfants en vue d’informer ces derniers des mécanismes de protection auxquels ils peuvent avoir accès;
                g) Faire face aux causes profondes de la violence et des sévices et prendre des mesures concrètes pour changer les attitudes, les traditions, les coutumes et les comportements qui souvent servent de prétexte à la pratique de la violence dans la famille, en particulier à l’égard des filles.", @"الأخذ في الحسبان التعليق العام رقم 13(2011) بشأن حق الطفل في التحرر من جميع أشكال العنف، ووضع نظام لحماية الطفل منسق تنسيقاً جيداً وممولاً تمويلاً كافياً بتعاون وثيق مع المجتمع المدني والاضطلاع بما يلي خاصةً:
                -  (هـ) مواصلة الارتقاء بمستوى برامج التوعية والتثقيف، بسبل منها تنظيم حملات يشارك فيها الأطفال من أجل إعلام الأطفال بآليات الحماية التي يمكنهم اللجوء إليها؛ 
                -  (ز) اجتثاث جذور العنف وإساءة المعاملة، واتخاذ تدابير عملية لتغيير المواقف والتقاليد والعادات والسلوكيات التي تبرر في الغالب العنف المنزلي، خاصة على الفتيات", "", "" },
                    { 292, null, "R37P3", "ت.37.ف.3", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", @"Renvoyant à son Observation générale no 8 (2006) relative aux droits de l’enfant et à une protection contre les châtiments corporels et les autres formes cruelles ou dégradantes de châtiment, le Comité invite le Maroc à:
                c) Organiser des campagnes publiques soutenues d’éducation, de sensibilisation et de mobilisation sociale associant les enfants, les familles, les collectivités et les chefs religieux sur les effets physiques et psychologiques néfastes des châtiments corporels en vue de faire évoluer les mentalités à l’égard de cette pratique et de promouvoir des formes d’éducation et de discipline constructives non violentes et participatives en remplacement des châtiments corporels;", @"في ضوء تعليق اللجنة العام رقم 8(2006) بشأن حق الطفل في الحماية من العقوبة البدنية وغيرها من ضروب العقوبة القاسية أو المهينة، تحث اللجنة الدولة المملكة المغربية على ما يلي: 
                -  (ج) وضع برامج مستمرة للتثقيف العام والتوعية والتعبئة الاجتماعية عن الأضرار البدنية والنفسية المترتبة على العقوبة البدنية يشارك فيها الأطفال، والأسر، والمجتمعات المحلية، والقيادات الدينية، بهدف تغيير الموقف العام من هذه الممارسة وتشجيع أشكال إيجابية وخالية من العنف وقائمة على المشاركة لتنشئة الأطفال تكون بديلاً للعقوبة البدنية", "", "" },
                    { 291, null, "R29P2", "ت.29.ف.2", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 12 (2009) sur le droit de l’enfant d’être entendu et lui recommande:
                b) D’exécuter des programmes et des activités de sensibilisation en vue de promouvoir une participation active et autonome de tous les enfants à la vie de la famille, de la collectivité et de l’école, notamment dans le cadre des conseils d’élèves, en accordant une attention particulière aux filles et aux enfants vulnérables.", @"تلفت اللجنة انتباه الدولة الطرف إلى تعليقها العام رقم 12(2009) بشأن حق الطفل في أن يُستمع إليه، وتوصيها بالآتي: 
                - (ب) تنفيذ برامج وأنشطة توعية لتشجيع مشاركة جميع الأطفال الجادة والقوية داخل الأسرة والمجتمع والمدرسة، بما في ذلك داخل هيئات مجالس التلاميذ، مع إيلاء اهتمام خاص للفتيات والأطفال المستضعفين", "", "" },
                    { 290, null, "R23P3", "ت.23.ف.3", "", "En cours", "", 30, 7, null, 7, null, 37, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                c) D’entreprendre des campagnes de sensibilisation auprès du secteur du tourisme et du grand public à la prévention du tourisme pédophile et de diffuser largement la Charte d’honneur pour le tourisme et le code mondial d’éthique du tourisme de l’Organisation mondiale du tourisme auprès des agences de voyages et du secteur du tourisme;", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                - (ج) تنظيم حملات توعية بمشاركة قطاع السياحة وعامة الناس عن منع سياحة الجنس مع الأطفال، وإشاعة ميثاق الشرف للعاملين في السياحة والمدونة العالمية لأخلاقيات السياحة التي وضعتها منظمة السياحة العالمية بين وكلاء السفر وفي قطاع السياحة؛", "", "" },
                    { 242, null, "R52", "ت.52", "", "Réalisé", "", 100, 7, null, 6, null, 37, null, "Organes de traités", @"Les présentes observations finales doivent être largement diffusées la population du pays, en particulier les membres de l’administration et les responsables politiques, soit au courant des mesures prises pour assurer l’égalité de droit et de fait entre les sexes et sache quelles mesures restent à prendre à cet égard. 
                - Diffuser largement, surtout auprès des associations féminines et des organisations de défense des droits de l’homme, le texte de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes et de son Protocole facultatif; les recommandations générales du comité; la Déclaration et le Programme d'action de Beijing; et les textes issus de la vingt-troisième session extraordinaire de l’Assemblée générale, intitulée  « Les femmes en l’an 2000 : égalité entre les sexes, développement et paix pour le XXIe siècle ».", @"نشر الملاحظات الختامية على أوسع نطاق ممكن من أجل توعية الشعب المغربي، ولا سيما المديرين الحكوميين والسياسيين، بالخطوات التي اتخذت لكفالة المساواة بين المرأة والرجل قانونيا وفعليا، وبالخطوات التي يتعين اتخاذها مستقبلا في هذا الصدد. 
                -مواصلة نشر اتفاقية القضاء على جميع أشكال التمييز ضد المرأة والبروتوكول الاختياري الملحق بها، على أوسع نطاق، لا سيما بين المنظمات النسائية ومنظمات حقوق الإنسان؛ وكذلك التوصيات العامة للجنة المعنية بالقضاء على التمييز ضد المرأة؛ وإعلان ومنهاج عمل بيجين؛ ونتائج الدورة الاستثنائية الثالثة والعشرين للجمعية العامة المعنونة ”المرأة عام 2000: المساواة بين الجنسين والتنمية والسلام في القرن الحادي والعشرين“.", "", "" },
                    { 241, null, "R31P2", "ت.31.ف.2", "", "En cours", "", 30, 7, null, 6, null, 37, null, "Organes de traités", "Multiplier les campagnes de sensibilisation à l’importance des soins de santé, en y incluant des informations sur la propagation des maladies sexuellement transmissibles et du VIH/sida ainsi que sur la prévention des grossesses non désirées grâce à la planification familiale et à l’éducation sexuelle.", "توصي اللجنة، في ضوء توصيتها العامة رقم 24، بأن تزيد الدولة من حملات التوعية بأهمية الرعاية الصحية ويشمل ذلك المعلومات المتعلقة بانتشار الأمراض التي تنتقل عن طريق الاتصال الجنسي والإصابة بفيروس نقص المناعة البشرية/الإيدز والمعلومات المتصلة بمنع الحمل غير المرغوب فيه من خلال تنظيم الأسرة والتثقيف الجنسي.", "", "" },
                    { 240, null, "R27P5", "ت.27.ف.5", "", "En cours", "", 30, 7, null, 6, null, 37, null, "Organes de traités", "Sensibiliser l’opinion à l’importance de l’éducation en tant que droit fondamental et condition de l’autonomisation des femmes et à prendre des mesures pour modifier les attitudes traditionnelles qui tendent à perpétuer la discrimination.", "-رفع مستوى الوعي عموما بأهمية التعليم كحق من حقوق الإنسان وكأساس لتمكين المرأة، وعلى اتخاذ خطوات للتغلب على أنماط السلوك التقليدية التي تعمل على استدامة التمييز", "", "" },
                    { 239, null, "R25P3", "ت.25.ف.3", "", "En cours", "", 30, 7, null, 6, null, 37, null, "Organes de traités", "Lancer des campagnes d’information pour attirer l’attention sur l’importance de la participation des femmes à la prise de décisions dans l’ensemble de la société, y compris dans les secteurs public et privé.", "الاضطلاع بحملات لإذكاء الوعي بشأن الأهمية التي تكتسبها مشاركة المرأة في عملية اتخاذ القرار بالنسبة للمجتمع بأسره، بما في ذلك في القطاعين العام والخاص.", "", "" },
                    { 366, null, "R68", "ت.68", "", "En cours", "", 30, 7, null, 8, null, 37, null, "Organes de traités", "-                    Diffuser largement les présentes observations finales, notamment auprès des organisations non gouvernementales et des organisations de personnes handicapées, ainsi qu’auprès des personnes handicapées elles-mêmes et de leurs proches, dans les langues nationales et minoritaires, notamment en langue des signes, et sous des formes accessibles. Il lui demande aussi de les diffuser sur le site Web public consacré aux droits de l’homme.", "نشر هذه الملاحظات الختامية على نطاق واسع، بما يشمل المنظمات غير الحكومية ومنظمات الأشخاص ذوي الإعاقة، والأشخاص ذوي الإعاقة أنفسهم وأفراد أسرهم، باللغات الوطنية ولغات الأقليات، بما في ذلك لغة الإشارة، وفي أشكال يسهل الاطلاع عليها، وإتاحتها في موقع الحكومة الشبكي المتعلق بحقوق الإنسان.", "", "" },
                    { 543, null, "R90", "null", "", "En cours", "", 30, 7, null, null, null, 36, 4, "Procédure spéciale", "-    Organiser des programmes de formation à l’application des instruments juridiques internationaux au profit des avocats et autres professionnels pour pouvoir appliquer les lois et les normes internationales relatives aux droits de l’homme.", "null", "", "" },
                    { 542, null, "R83P2", "null", "", "En cours", "", 30, 7, null, null, null, 36, 4, "Procédure spéciale", @"……..Former le personnel des organismes d’application des lois, en particulier les policiers, les agents des services d’immigration et les inspecteurs du travail. 
                - Le personnel ainsi formé devrait être mieux à même de repérer rapidement et sans se tromper les victimes de la traite et de les orienter vers les services voulus. 
                - Distinguer clairement les migrants en situation irrégulière des victimes de la traite, ces deux catégories de personnes devant être soumises à des lois et à des procédures distinctes.", "null", "", "" },
                    { 514, null, "R95P2", "ت.95.ف.2", "", "En cours", "", 30, 7, null, null, null, 36, 3, "Procédure spéciale", "-    sensibiliser davantage l’ensemble du personnel chargé d’appliquer la loi à son rôle de prévention de la torture et des mauvais traitements au moyen de cours obligatoires de formation aux normes internationales relatives à l’interdiction de la torture, aux dispositions régissant les enquêtes en cas de torture et de mauvais traitements, et aux techniques d’interrogatoire et de renforcer les programmes de formation sur la façon de déceler, de signaler et de prévenir la torture, destinés aux professionnels de la santé et de l’administration de la justice;", @"بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:
                - (ب) إذكاء وعي جميع موظفي إنفاذ القانون بدورهم في منع التعذيب وسوء المعاملة بواسطة التدريب الإلزامي على المعايير الدولية المتعلقة بمنع التعذيب والأحكام المنظمة للتحقيقات في التعذيب وسوء المعاملة وأساليب الاستجواب، واستحداث المزيد من البرامج التدريبية التي ينبغي تقديمها أثناء دورات التأهيل المهني للعاملين في مجالي الصحة والقانون بشأن كشف التعذيب والإبلاغ عنه وتوقيه؛", "", "" },
                    { 540, null, "R93", "null", "", "En cours", "", 30, 6, null, null, null, 35, 4, "Procédure spéciale", "-    Les peines et les sanctions infligées aux personnes qui se rendent coupables de travail forcé devraient être plus lourdes, de façon à dissuader les trafiquants qui recrutent à cette fin.", "null", "", "" },
                    { 539, null, "R91", "null", "", "En cours", "", 30, 6, null, null, null, 35, 4, "Procédure spéciale", @"Redoubler les efforts pour poursuivre les trafiquants tout en garantissant leur droit à un procès équitable dans le cadre d’une approche de la justice pénale fondée sur les droits de l’homme, et pour établir le cadre juridique et les procédures nécessaires en vue d’assurer la protection des victimes et des témoins. 
                - En ce qui concerne les Marocains vivant à l’étranger, le Gouvernement devrait définir et mettre en œuvre des mesures judiciaires efficaces pour protéger les Marocaines prises au piège des réseaux de prostitution à l’étranger.", "null", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 235, null, "R23P1", "ت.23.ف.1", "", "En cours", "", 30, 6, null, 6, null, 35, null, "Organes de traités", @"Adopter des mesures efficaces pour prévenir et combattre la traite des êtres humains, notamment des femmes et des filles, et d’enquêter de manière approfondie sur les affaires de cette nature, conformément à l’article 6 de la Convention et à sa recommandation générale no 19. 
                -Renforcer la coopération internationale visant à lutter contre la traite, à engager des poursuites contre les trafiquants, à leur infliger des peines proportionnelles à la gravité des crimes qu’ils commettent, et à protéger les droits fondamentaux des femmes et des filles victimes de l’exploitation et de la traite, en prenant notamment des mesures pour leur réadaptation et leur réintégration sociale.", @"اعتماد تدابير فعالة لمنع ومكافحة الاتجار بالأشخاص، ولا سيما النساء والفتيات، وإجراء تحقيقات مستفيضة في هذه القضايا، وذلك وفقا للمادة 6 من الاتفاقية والتوصية العامة رقم 19. 
                 -توطيد جهود التعاون الدولي لمنع الاتجار وملاحقة الضالعين فيه قضائيا ومعاقبتهم حسب جسامة جرمهم، وكفالة حماية حقوق الإنسان الواجبة للنساء والفتيات من ضحايا الاستغلال والاتجار، بسبل منها اتخاذ التدابير اللازمة لتأهيلهن وإدماجهن في المجتمع", "", "" },
                    { 191, null, "R48P2P3P4", "ت.48.ف2.ف3.ف4", "", "Réalisé", "", 100, 6, null, 5, null, 35, null, "Organes de traités", @"Prendre les mesures nécessaires pour que la stratégie nationale de lutte contre le trafic des êtres humains comprenne notamment les mesures suivantes :
                b) Collecter systématiquement des données ventilées sur la traite des personnes ;
                c) Intensifier les campagnes de prévention, en particulier dans les zones frontalières où les victimes de la traite sont les plus nombreuses ; 
                d) Mettre en place des mécanismes efficaces d’identification, de protection et d’assistance à toutes les victimes de la traite, en particulier en leur offrant des centres d’accueil et en lançant des projets pour les aider à reconstruire leur vie;", @"اتخاذ التدابير اللازمة كي تتضمن الاستراتيجية الوطنية لمحاربة الاتجار بالبشر التدابير التالية على وجه الخصوص:
                 (ب) القيام على نحو منهجي بجمع بيانات مُصنَّفة عن ظاهرة الاتجار بالبشر؛
                 (ج) تكثيف حملات الوقاية، لا سيما في المناطق الحدودية حيث يوجد العدد الأكبر من ضحايا الاتجار؛
                 (د) إقرار آليات فعالة لتحديد جميع ضحايا الاتجار وحمايتهم ومساعدتهم، لا سيما بتوفير مراكز لاستقبالهم ومباشرة مشاريع لمساعدتهم على إعادة بناء حياتهم؛", "", "" },
                    { 80, null, "R27P2P3", "ت.27.ف.2.ف.3", "", "Réalisé", "", 100, 6, null, 2, null, 35, null, "Organes de traités", @"Créer des conditions propices à l’exercice par les femmes et des enfants victimes de la traite de leur droit de déposer plainte. 
                - Procéder rapidement à des enquêtes impartiales et efficaces sur toutes les allégations de traite, de même que veiller à ce que les responsables soient traduits en justice et que des peines à la mesure de la gravité de leurs actes leur soient infligées", @"قمع عملية الاتجار وحماية الضحايا، بتوفير الحماية لهم وبضمان حصول الضحايا على خدمات تأهيلية وكذلك على خدمات طبية واجتماعية وقانونية، وعلى خدمات التوعية عند الحاجة. وينبغي كذلك أن تهيئ الدولة الطرف ظروفاً مواتية لممارسة الضحايا حقهم في تقديم الشكاوى. 
                - إجراء تحقيقات نزيهة وفعالة بشأن جميع الادعاءات المتعلقة بالاتجار بالبشر، وضمان تقديم المسؤولين عنها إلى العدالة، ومعاقبتهم عقاباً يتناسب مع جسامة ممارساتهم.", "", "" },
                    { 1190, null, "R144.241", "241.144", "", "Réalisé", "", 100, 6, 1, null, 82, 34, null, "Examen périodique universal", "Envisager de partager avec d’autres pays l’expérience marocaine en matière de protection et de promotion des droits des migrants", "النظر في تبادل الخبرة المغربية مع بلدان أخرى فيما يتعلق بحماية وتعزيز حقوق المهاجرين", "", "" },
                    { 1189, null, "R144.238", "238.144", "", "Réalisé", "", 100, 6, 1, null, 27, 34, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir et protéger les droits des migrants", "مواصلة الجهود الرامية إلى تعزيز وحماية حقوق المهاجرين", "", "" },
                    { 1188, null, "R144.237", "237.144", "", "Réalisé", "", 100, 6, 1, null, 75, 34, null, "Examen périodique universal", "Poursuivre la mise en œuvre de la politique de promotion et de protection effectives des droits des migrants", "مواصلة تنفيذ سياسة التعزيز والحماية الفعّالين لحقوق المهاجرين", "", "" },
                    { 1187, null, "R144.224P2", "224.144 ج.2", "", "Réalisé", "", 100, 6, 1, null, 79, 34, null, "Examen périodique universal", "Continuer à renforcer les politiques publiques pertinentes pour la promotion et la protection des droits de l’homme, en particulier les droits des demandeurs d’asile  ;", "مواصلة تقوية السياسات العامة ذات الصلة لتعزيز وحماية حقوق الإنسان، وبخاصة حقوق... المهاجرين وملتمسي اللجوء ...", "", "" },
                    { 1186, null, "R144.222P3", "222.144. ج.3", "", "Réalisé", "", 100, 6, 1, null, 19, 34, null, "Examen périodique universal", "Prendre des mesures plus efficaces pour mieux protéger les droits des migrants", "اتخاذ تدابير أكثر نجوعاً من أجل توفير حماية أفضل.... المهاجرين وغير ذلك من الفئات الضعيفة", "", "" },
                    { 606, null, "R83P19", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 6, "Procédure spéciale", "-       Envisager différentes mesures non privatives de liberté, telles que l’obligation de faire rapport, avant de recourir à la détention des migrants, réfugiés et demandeurs d’asile ;", "null", "", "" },
                    { 605, null, "R83P18", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 6, "Procédure spéciale", @"S’assurer que les garanties juridiques régissant la pratique de reconduite à la frontière des migrants sans papiers et l’expulsion de ressortissants étrangers soient effectivement appliquées et que de telles pratiques et expulsions soient effectuées conformément au droit international et national. 
                - Le Gouvernement devrait demander des enquêtes impartiales et efficaces sur les allégations de mauvais traitements ou d’usage excessif de la force lors des expulsions de migrants. Il convient également de s’assurer que les responsables soient traduits en justice et condamnés à des peines proportionnelles à la gravité de leurs actes", "null", "", "" },
                    { 541, null, "R99P2-2", "null", "", "En cours", "", 30, 6, null, null, null, 35, 4, "Procédure spéciale", @"En ce qui les provinces marocaines du sud :
                - b) …..prendre de nouvelles mesures pour réduire la vulnérabilité des victimes potentielles de la traite assurer une protection adéquate aux migrants et aux membres de leur famille", "null", "", "" },
                    { 604, null, "R83P17", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 6, "Procédure spéciale", "-       Prendre toutes les mesures nécessaires pour empêcher les arrestations massives et autres actes de violence et enquêter sur les rapports concernant les violences commises contre les migrants sub-sahariens, les réfugiés et les demandeurs d’asile", "null", "", "" },
                    { 513, null, "R90P3", "ت.90.ف.3", "", "Réalisé", "", 100, 6, null, null, null, 34, 3, "Procédure spéciale", "-    Respecter les droits de l’homme fondamentaux des migrants, des réfugiés et des demandeurs d’asile et de leur assurer l’accès aux établissements de santé et aux soins médicaux sans crainte d’être arrêtés.", "-          (ب) احترام الحقوق الإنسانية الأساسية للمهاجرين واللاجئين وملتمسي اللجوء، وتيسير دخولهم المرافق الصحية وتلقيهم الرعاية الطبية دون خوف من اعتقالهم.", "", "" },
                    { 512, null, "R90P2", "ت.90.ف.2", "", "Réalisé", "", 100, 6, null, null, null, 34, 3, "Procédure spéciale", "-    Prendre toutes les mesures nécessaires pour prévenir d’autres violences et enquêter sur les informations faisant état d’actes de violence subis par des migrants, des réfugiés et des demandeurs d’asile subsahariens", "(أ) اتخاذ جميع التدابير اللازمة لمنع حدوث المزيد من أعمال العنف، والتحقيق في التقارير التي تتحدث عن تلك الأعمال في حق المهاجرين واللاجئين وملتمسي اللجوء من الصحراء الغربية؛", "", "" },
                    { 511, null, "R88P11", "ت.88.ف.11", "", "Réalisé", "", 100, 6, null, null, null, 34, 3, "Procédure spéciale", "-    veiller à ce que le principe de non-refoulement énoncé à l’article 3 de la Convention contre la torture soit pleinement appliqué, notamment dans le cas des migrants, des réfugiés et des demandeurs d’asile, pour que nul ne soit expulsé vers un pays où il risque d’être soumis à la torture;", "-          (ك) ضمان تطبيق مبدأ عدم الإعادة القسرية المنصوص عليه في المادة 3 من اتفاقية مناهضة التعذيب تطبيقاً تاماً، مثلاً على المهاجرين واللاجئين وملتمسي اللجوء، بحيث لا يسلّم الناس إلى أي بلد يحتمل أن يعذبوا فيه؛", "", "" },
                    { 461, null, "R85", "null", "", "En cours", "", 30, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Fournir une aide humanitaire d’urgence à toutes les personnes victimes de graves violations des droits de l’homme dans le contexte migratoire, sans distinction de race, d’appartenance ethnique, d’origine nationale, d’ascendance ou de statut migratoire, en particulier à celles qui risquent de subir une discrimination croisée en raison de leur sexe, de leur identité de genre, de leur orientation sexuelle, d’un handicap ou de toute autre situation", "null", "", "" },
                    { 460, null, "R84", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Éliminer toutes les pratiques de profilage racial et toutes les autres pratiques discriminatoires d’application de la loi sur l’immigration, y compris les réinstallations forcées, les arrestations et détentions arbitraires, le confinement régional des Africains noirs d’origine subsaharienne et le recours excessif à la force à leur égard.", "null", "", "" },
                    { 459, null, "R83", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Veiller à ce que la politique migratoire nationale fondée sur les droits de l’homme soit appliquée uniformément à tous les échelons de l’administration.", "null", "", "" },
                    { 458, null, "R82", "null", "", "En cours", "", 30, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Renforcer les mesures visant à éliminer les obstacles administratifs et les autres obstacles structurels à l’intégration des réfugiés et des migrants", "null", "", "" },
                    { 457, null, "R81", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 2, "Procédure spéciale", "-       Adopter et promouvoir une approche multipartite dans l’élaboration d’un cadre permanent relatif à la régularisation des migrants", "null", "", "" },
                    { 456, null, "R80", "null", "", "Réalisé", "", 100, 6, null, null, null, 34, 2, "Procédure spéciale", "Garantir des voies de migration supplémentaires systématisées, notamment en attendant la finalisation des projets de loi nationaux sur les migrations et l’asile en cours d’examen par le parlement", "null", "", "" },
                    { 286, null, "R63", "ت.63", "", "Réalisé", "", 100, 6, null, 7, null, 34, null, "Organes de traités", @"Le Comité recommande au Maroc d’accélérer l’adoption d’un cadre juridique et institutionnel pour assurer le respect, en toutes circonstances, des droits des enfants migrants, des enfants demandeurs d’asile et des enfants réfugiés non accompagnés, conformément au droit international relatif aux réfugiés et aux droits de l’homme. 
                L’État partie devrait veiller à ce que :
                a) Les enfants migrants, réfugiés et demandeurs d’asile ne soient pas arrêtés, détenus arbitrairement et renvoyés en violation de la loi ;
                b) Une enquête pour déterminer les responsabilités dans le renvoi de cinq enfants dans le désert en 2013 soit menée, des sanctions soient prises contre les responsables et des mesures soient adoptées pour prévenir qu’une telle situation ne se reproduise ;
                c) Des mesures soient prises rapidement pour assurer aux enfants migrants, réfugiés et demandeurs d’asile un meilleur accès aux services de protection se trouvant dans les hôpitaux et pour améliorer la situation sanitaire dans le Centre d’accueil pour migrants.", @"توصي اللجنة المملكة المغربية بأن تعجل باعتماد إطار قانوني ومؤسسي يكفل احترام حقوق الأطفال بلا مرافق والمهاجرين وملتمسي اللجوء واللاجئين في كل الأحوال وفقاً للقانون الدولي للاجئين ولحقوق الإنسان. وينبغي للدولة الطرف أن تكفل ما يلي:
                -  (أ) عدم انتهاكها القانون بالقبض على الأطفال اللاجئين وملتمسي اللجوء واحتجازهم تعسفاً وطردهم؛
                - (ب) إجراء تحقيق لتحديد المسؤوليات عن طرد 5 أطفال في الصحراء في عام 2013، ومعاقبة الجناة، واتخاذ تدابير لمنع تكرار هذا الوضع؛
                - (ج) التعجيل باتخاذ تدابير لتيسير دخول الأطفال ملتمسي اللجوء واللاجئين والمهاجرين وحدات الحماية الموجودة في المشافي، وتحسين الأوضاع الصحية في مراكز استقبال المهاجرين.", "", "" },
                    { 285, null, "R31P3", "ت.31.ف3", "", "En cours", "", 30, 6, null, 7, null, 34, null, "Organes de traités", "c) Abolir les frais imposés pour l’obtention d’un bulletin de naissance, prolonger le court délai d’enregistrement des nouveau-nés (trente jours) et faciliter la délivrance de bulletins de naissance à tous les enfants réfugiés qui n’en possèdent pas encore un;", "-           (ج) إلغاء رسوم شهادات الميلاد، وتمديد فترة تسجيل الوِلْدان القصيرة (30 يوماً) وتيسير تقديم شهادات الميلاد لجميع أطفال اللاجئين الذين لا يزالون يفتقرون إليها؛", "", "" },
                    { 234, null, "R45P3", "ت.45.ف.3", "", "Réalisé", "", 100, 6, null, 6, null, 34, null, "Organes de traités", "Permettre aux réfugiés et demandeurs d’asile de bénéficier des services publics, d’octroyer des permis de travail à ceux d’entre eux qui sont en situation régulière et à garantir leur droit à la sécurité notamment en ce qui concerne les femmes et les enfants.", "السماح للاجئين وملتمسي اللجوء بإمكانية الحصول على الخدمات العامة، وتوفير تصاريح عمل لأولئك اللاجئين وملتمسي اللجوء الذين لديهم وثائق، وأن تكفل حقهم في الأمن، لا سيما بالنسبة إلى النساء والأطفال.", "", "" },
                    { 538, null, "R99P1-1", "null", "", "En cours", "", 30, 6, null, null, null, 34, 4, "Procédure spéciale", @"En ce qui les provinces marocaines du sud :
                - a) prendre des mesures concrètes pour améliorer la situation des migrants en situation irrégulière…………", "null", "", "" },
                    { 189, null, "R22", "ت.22", "", "En cours", "", 30, 6, null, 5, null, 34, null, "Organes de traités", @"Diffuser de l’information auprès des travailleurs migrants et des membres de leur famille, y compris ceux en situation irrégulière, les informer des recours judiciaires ou autres qui leur sont ouverts et de traiter leurs plaintes le plus efficacement possible. 
                - Garantir que les travailleurs migrants et les membres de leur famille, y compris ceux en situation irrégulière, aient les mêmes possibilités que les nationaux de porter plainte et d’exercer un recours utile devant les tribunaux s’ils ont été atteints dans les droits que leur reconnaît la Convention.", @"تعميم المعلومات على العمال المهاجرين وأفراد أسرهم بمن فيهم الموجودون في وضع غير قانوني، وإبلاغهم بسبل الانتصاف القضائية أو غير ذلك من سبل الانتصاف المتاحة لهم، ومعالجة شكاواهم بأقصى قدر ممكن من الفعالية.
                كفالة أن يُتاح للعمال المهاجرين وأفراد أسرهم، بمن فيهم الموجودون في وضع غير قانوني، الإمكانات ذاتها التي تتاح للمواطنين من أجل رفع الشكاوى والاستفادة من سبيل انتصاف فعال أمام المحاكم في حال انتهاك حقوقهم المعترف بها في الاتفاقية.", "", "" },
                    { 1191, null, "R144.108", "108.144", "", "En cours", "", 30, 6, 1, null, 44, 35, null, "Examen périodique universal", "Renforcer ses mécanismes nationaux et la coopération internationale pour lutter contre la traite des êtres humains et, en particulier, le tourisme sexuel impliquant des enfants", "تقوية آلياته الوطنية والتعاون الدولي على مكافحة الاتجار بالأشخاص ولا سيما سياحة الجنس التي يُستخدم فيها أطفال", "", "" },
                    { 1193, null, "R144.110P1", "110.144.ج.1", "", "Réalisé", "", 100, 6, 1, null, 80, 35, null, "Examen périodique universal", "Élaborer une stratégie nationale pour lutter contre l’esclavage moderne", "وضع استراتيجية وطنية للتصدي للعبودية المعاصرة", "", "" },
                    { 464, null, "R91", "null", "", "En cours", "", 30, 7, null, null, null, 36, 2, "Procédure spéciale", "-       Accroître les ressources des bureaux régionaux du Conseil national des droits de l’homme et leur procurer des possibilités de formation sur les obligations internationales en matière de droits de l’homme pour combattre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, en prêtant particulièrement attention aux variations locales dans les manifestations de ces problèmes", "null", "", "" },
                    { 463, null, "R90", "null", "", "En cours", "", 30, 7, null, null, null, 36, 2, "Procédure spéciale", "-       Renforcer les capacités et les compétences des bureaux régionaux du Conseil national des droits de l’homme en matière de lutte contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, en accordant une attention particulière aux dynamiques régionales qui influent sur l’égalité raciale.", "null", "", "" },
                    { 462, null, "R76", "null", "", "En cours", "", 30, 7, null, null, null, 36, 2, "Procédure spéciale", "-       Renforcer les mesures préventives d’éducation, de formation et de sensibilisation de sorte que tous les agents publics, y compris ceux qui sont responsables de l’administration des services publics, s’abstiennent de toute forme de racisme, de discrimination raciale, de xénophobie et d’intolérance qui y est associée.", "null", "", "" },
                    { 434, null, "R90P2", "null", "", "En cours", "", 30, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Renforcer le rôle des travailleurs sociaux et veiller à ce que ceux-ci soient rémunérés en conséquence, afin de garantir le contrôle effectif du respect du droit de l’enfant à une alimentation suffisante et équilibrée et de promouvoir une alimentation équilibrée auprès des familles.", "null", "", "" },
                    { 433, null, "R87", "null", "", "En cours", "", 30, 8, null, null, null, 36, 1, "Procédure spéciale", @"Veiller à ce que les dispositifs de protection sociale bénéficient aux groupes les plus pauvres et les plus désavantagés, notamment à ceux vivant en milieu rural, en s’employant à mieux identifier les personnes admissibles ; 
                - -Veiller à ce que les cibles des programmes soient choisies de manière transparente et éliminer la corruption à tous les niveaux du système", "null", "", "" },
                    { 432, null, "R74", "null", "", "En cours", "", 30, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Élargir les mécanismes de suivi existants pour que les permis de pêche annuels soient délivrés de manière transparente, conformément aux règles internationales relatives à la pêche", "null", "", "" },
                    { 431, null, "R70", "null", "", "En cours", "", 30, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Renforcer les mécanismes de suivi et d’évaluation afin que les projets d’intensification agricole lancés dans le cadre du pilier I du Plan Maroc Vert soient écologiquement viables et qu’ils ne conduisent pas à l’épuisement des ressources.", "null", "", "" },
                    { 430, null, "R69", "null", "", "En cours", "", 30, 8, null, null, null, 36, 1, "Procédure spéciale", @"Promouvoir une société civile indépendante, qui permettra au Maroc de renforcer l’engagement qu’il a pris de garantir le respect des droits de l’homme et des libertés fondamentales à l’avenir. 
                - Encourager la société civile à incorporer les droits économiques, sociaux et culturels, en particulier le droit à l’alimentation, dans son programme.", "null", "", "" },
                    { 429, null, "R67P1", "null", "", "En cours", "", 30, 8, null, null, null, 36, 1, "Procédure spéciale", "-   Garantir la bonne application des lois en vigueur en renforçant les mécanismes de suivi et de responsabilisation", "null", "", "" },
                    { 428, null, "R66P2", "null", "", "Non réalisé", "", 0, 8, null, null, null, 36, 1, "Procédure spéciale", @"Désigner les autorités et les organismes responsables de la mise en œuvre et mettre en place des mécanismes adéquats de suivi et de responsabilisation se rapportant à la loi-cadre relative au droit à l’alimentation à mettre en place. 
                - Garantir la pleine participation de tous les acteurs concernés, notamment des plus vulnérables face à la faim et à la malnutrition", "null", "", "" },
                    { 427, null, "R78", "null", "", "En cours", "", 30, 7, null, null, null, 36, 1, "Procédure spéciale", "-   Sensibiliser les populations locales, en particulier les femmes et les jeunes, et faciliter leur participation, avec l’appui des organisations non gouvernementales, aux mesures de développement visant à combattre les effets des changements climatiques", "null", "", "" },
                    { 364, null, "R35P2", "ت.35.ف. 2", "", "En cours", "", 30, 7, null, 8, null, 36, null, "Organes de traités", "Dispenser une formation aux familles des personnes handicapées, aux personnes qui s’occupent de ces dernières, aux professionnels de la santé et aux agents des forces de l’ordre pour leur permettre de reconnaître toutes les formes d’exploitation, de violence et de maltraitance, et de mieux communiquer et travailler avec les personnes handicapées qui sont victimes d’actes de violence ;", "-       (ب) توفير التدريب للأسر ومقدمي الرعاية، والموظفين الصحيين، وموظفي إنفاذ القوانين بشأن التعرف على جميع أشكال الاستغلال والعنف والاعتداء، والتواصل والعمل الفعالين مع الأشخاص ذوي الإعاقة من ضحايا العنف؛", "", "" },
                    { 1192, null, "R144.109", "109.144", "", "Réalisé", "", 100, 6, 1, null, 74, 35, null, "Examen périodique universal", "Poursuivre les efforts visant à lutter contre la traite des êtres humains et veiller à ce qu’une attention particulière soit accordée aux groupes vulnérables en appliquant la loi adoptée à cet égard", "مواصلة الجهود لمكافحة الاتجار بالبشر وضمان إيلاء عناية خاصة للفئات الضعيفة عند تطبيق القانون المعتمَد في هذا الشأن", "", "" },
                    { 363, null, "R29P3", "ت.29.ف.3", "", "En cours", "", 30, 7, null, 8, null, 36, null, "Organes de traités", "c) Veiller à ce que des programmes de formation et des campagnes de sensibilisation et d’information soient régulièrement mis en œuvre à l’intention du personnel des tribunaux, des juges, des procureurs et des responsables de l’application des lois, notamment de la police et de l’administration pénitentiaire, sur la nécessité d’assurer l’accès des personnes handicapées à la justice", "-       (ج) ضمان استمرارية برامج التدريب وحملات التوعية والإعلام التي تستهدف موظفي المحاكم والقضاة والمدعين العامين والموظفين المكلفين بإنفاذ القوانين، بمن فيهم أفراد الشرطة وموظفو السجون، بشأن ضرورة تيسير إمكانية اللجوء إلى القضاء للأشخاص ذوي الإعاقة؛", "", "" },
                    { 361, null, "R21", "ت.21", "", "En cours", "", 30, 7, null, 8, null, 36, null, "Organes de traités", @"a) Renforcer, avec la participation des personnes handicapées par l’intermédiaire des organisations qui les représentent et avec le concours des médias, les campagnes de sensibilisation visant à réaffirmer la valeur et la dignité des personnes handicapées ;
                b) Sensibiliser les responsables politiques, notamment les responsables des pouvoirs législatif, exécutif et judiciaire, aux dispositions de la Convention et du Protocole facultatif s’y rapportant et de s’assurer de leur soutien aux fins de la mise en œuvre des recommandations figurant dans les observations finales du Comité ;
                c) Engager un dialogue au sein de la société, en y associant les responsables des communautés et les dignitaires religieux, en vue de prévenir la stigmatisation de toutes les catégories de personnes handicapées ;
                d) Concevoir des campagnes de sensibilisation et de réviser les supports pédagogiques pour éviter la confusion pouvant résulter du fait d’avoir une orientation sexuelle différente et d’être une personne handicapée.", @"(أ) العمل، بمشاركة الأشخاص ذوي الإعاقة، من خلال المنظمات التي تمثلهم، وبانخراط وسائط الإعلام، على تعزيز حملات التوعية العامة الرامية إلى إعادة تأكيد قيمة الأشخاص ذوي الإعاقة وكرامتهم؛ 
                - (ب) إذكاء الوعي في أوساط السياسيين، بما في ذلك في أوساط السلطات التشريعية والتنفيذية والقضائية، بشأن الاتفاقية وبروتوكولها الاختياري وتأمين دعمها في تنفيذ التوصيات الواردة في الملاحظات الختامية للجنة؛
                - (ج) عقد حوار في المجتمع، ينخرط فيه زعماء المجتمع المحلي والزعماء الدينيون، بهدف منع وصم الأشخاص ذوي الإعاقة بجميع فئاتهم؛
                - (د) إعداد حملات لإذكاء الوعي ومراجعة المواد التعليمية لمنع الخلط المحتمل بين شخص له ميل جنسي مختلف وشخص من ذوي الإعاقة", "", "" },
                    { 360, null, "R15 P1P2", "ت.15.ف.1.ف.2", "", "En cours", "", 30, 7, null, 8, null, 36, null, "Organes de traités", @"conformément à son observation générale no 3 (2016) sur les femmes et les filles handicapées et à la cible 5.2 des objectifs de développement durable, Le Comité recommande de mettre fin à toute forme de violence à l’égard des femmes et des filles handicapées dans les sphères tant publique que privée, notamment à la traite et à l’exploitation, sexuelle et autre. Il recommande également :
                a) …… et de mener des campagnes de sensibilisation pour battre en brèche les stéréotypes, les préjugés et les mythes sur les femmes et les filles handicapées 
                b) Sensibiliser la population à toutes les formes de discrimination à l’égard des femmes et de tenir compte des points de vue des femmes qui s’occupent d’enfants handicapés dans les politiques de lutte contre la discrimination sexiste", @"تماشياً مع التعليق العام رقم 3(2016) بشأن النساء والفتيات ذوات الإعاقة والغاية 5-2 من أهداف التنمية المستدامة، توصي اللجنة الدولة الطرف بالقضاء على جميع أشكال العنف ضد النساء والفتيات في المجالين العام والخاص، بما في ذلك الاتجار بالبشر والاستغلال الجنسي وغير ذلك من أشكال الاستغلال. وتوصي الدولة الطرف أيضاً بما يلي:‬‬‬‬ ‬‬
                -  (أ) ......، وتنظيم حملات توعية عامة لمكافحة القوالب النمطية ومواقف التحيز والخرافات السائدة عنها؛ 
                -  (ب) التوعية بجميع أشكال التمييز ضد المرأة، والأخذ بوجهات نظر النساء اللواتي يتعهدن أطفالاً من ذوي الإعاقة بالرعاية في السياسات العامة المتعلقة بالتصدي للتمييز الجنساني؛", "", "" },
                    { 289, null, "R75P4", "ت.75.ف.4", "", "En cours", "", 30, 7, null, 7, null, 36, null, "Organes de traités", @"Mettre le système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs, en particulier:
                d) Assurer le renforcement des capacités et la spécialisation de toutes les parties prenantes dans le système de justice, notamment les magistrats, les agents pénitentiaires et les avocats en ce qui concerne les dispositions de la Convention;", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                -  (د) ضمان بناء قدرات جميع العاملين في سلك القضاء وتخصصهم                 فيما يتعلق بأحكام الاتفاقية، بمن فيهم القضاة وموظفو السجون والمحامون؛", "", "" },
                    { 288, null, "R49P5", "ت.49.ف.5", "", "En cours", "", 30, 7, null, 7, null, 36, null, "Organes de traités", @"Appelant l’attention sur les lignes directrices relatives à la protection de remplacement pour les enfants (résolution 64/142 de l’Assemblée générale, annexe), le Comité demande au Maroc:
                e) De faire en sorte que l’ensemble du personnel des institutions de protection sociale reçoive la formation requise aux droits de l’enfant, notamment à la façon de procéder pour signaler les cas de mauvais traitement, et de fournir toutes les ressources humaines techniques et financières nécessaires pour améliorer la situation des enfants;", @"تلفت اللجنة انتباه المملكة المغربية إلى المبادئ التوجيهية للرعاية البديلة للأطفال (مرفق قرار الجمعية العامة 64/142) وحثتها على ما يلي:  
                - (هـ)  ضمان تدريب جميع الموظفين العاملين في المؤسسات تدريباً كافياً في مجال حقوق الطفل، بما في ذلك بشأن الكيفية التي يمكن بها الإبلاغ عن حالات سوء المعاملة، وتوفير جميع الموارد البشرية والتقنية والمالية اللازمة لتحسين أوضاع الأطفال", "", "" },
                    { 287, null, "R35P2", "ت.35.ف.2", "", "En cours", "", 30, 7, null, 7, null, 36, null, "Organes de traités", "…….. dispenser aux agents de la force publique la formation requise aux normes régissant le traitement des enfants qui ont affaire à la justice ou sont en conflit avec la loi……………………", "-          توفير التدريب المناسب لموظفي إنفاذ القانون على قواعد ومعايير معاملة الأطفال الخاضعين لإجراءات قضائية أو المخالفين للقانون", "", "" },
                    { 236, null, "R17P1P2", "ت.17.ف.1.ف.2", "", "En cours", "", 30, 7, null, 6, null, 36, null, "Organes de traités", @"Intensifier ses campagnes de sensibilisation et la formation relative à la nouvelle législation, ainsi qu’aux dispositions de la Convention à l’intention des procureurs, des avocats et des magistrats, de façon à ancrer dans le pays une culture juridique favorisant l’égalité des sexes et la non-discrimination. 

                - Faire mieux connaître aux femmes leurs droits en mettant en place des programmes de vulgarisation et une assistance juridiques s’inscrivant dans la durée.", @"تكثيف حملات التوعية والتدريب بشأن التشريعات المعتمدة حديثا، فضلا عن أحكام الاتفاقية، في أوساط المدعين العامين والمحامين والقضاة، كيما يتسنى غرس ثقافة قانونية مساندة لمساواة المرأة مع الرجل وعدم التمييز 
                -زيادة تثقيف النساء بحقوقهن عن طريق تنفيذ برامج مستديمة لمحو الأمية القانونية وتقديم المساعدة القانونية. وتشجع اللجنة الدولة الطرف على مواصلة ما تقوم به من إصلاحات بالتشاور مع المجتمع المدني. ولا سيما المنظمات النسائية.", "", "" },
                    { 158, null, "R12P4", "ت.12.ف.4", "", "En cours", "", 30, 7, null, 4, null, 36, null, "Organes de traités", "d)  Mener des campagnes de sensibilisation auprès des responsables politiques, des magistrats, des parlementaires et des fonctionnaires sur la nécessité d’appliquer strictement la loi anticorruption et de tendre vers son élimination complète.", "-(د) تنظيم حملات توعية في أوساط المسؤولين السياسيين والقضاة والبرلمانيين والموظفين بشأن ضرورة تطبيق قانون محاربة الرشوة تطبيقاً صارماً والسعي إلى القضاء عليها قضاء تاماً.", "", "" },
                    { 157, null, "R10P3", "ت.10.ف.3", "", "En cours", "", 30, 7, null, 4, null, 36, null, "Organes de traités", "-            Mener des campagnes de sensibilisation auprès des juges, des avocats et de la population en général sur les dispositions du Pacte et sur sa primauté sur les lois internes permettant son application directe.", "-          تنظيم حملات توعية في أوساط القضاة والمحامين وعامة الجمهور بشأن أحكام العهد، وأولويته على التشريعات المحلية بما يسمح تطبيقه على نحو مباشر. وتوجه اللجنة انتباه الدولة الطرف إلى تعليقها العام رقم 9(1998) بشأن التطبيق المحلي للعهد.", "", "" },
                    { 120, null, "R36P5", "ت.36.ف.5", "", "En cours", "", 30, 7, null, 3, null, 36, null, "Organes de traités", "e) prévenir et éliminer le recours excessif à la force par les agents des forces de l’ordre en renforçant notamment les formations à cet égard (migrants et demandeurs asil) ;", "-          (ه) منع لجوء قوات الأمن في استخدام القوة المفرطة و التخلص من هذه الممارسة، لا سيما بتدعيم التدريب في هذا الصدد", "", "" },
                    { 119, null, "R6P1", "ت.6.ف.1", "", "En cours", "", 30, 7, null, 3, null, 36, null, "Organes de traités", "Poursuivre les efforts pour sensibiliser les juges, les avocats, les procureurs et autres personnes participant à l’administration de la justice aux dispositions du Pacte, de sorte que celles-ci soient prises en compte devant et par les tribunaux nationaux.", "-          مواصلة الجهود لتوعية القضاة والمحامين والمدعين العامين وغيرهم من المعنيين بإقامة العدل بأحكام العهد بحيث تراعَى هذه الأحكام أمام المحاكم وتراعيها المحاكم.", "", "" },
                    { 81, null, "R28", "ت.28", "", "En cours", "", 30, 7, null, 2, null, 36, null, "Organes de traités", @"Continuer à concevoir des programmes de formation, et à renforcer ces derniers, pour que tous les fonctionnaires – forces de l’ordre, services de renseignement, agents de sécurité, militaires, personnel pénitentiaire et personnel médical des prisons ou des hôpitaux psychiatriques – connaissent bien les dispositions de la Convention; que les violations signalées ne soient pas tolérées; que ces violations donnent lieu à des enquêtes et que les auteurs soient poursuivis. 
                - S’assurer que tous les personnels concernés, y compris les membres du corps médical, apprennent à détecter les signes de torture et de mauvais traitements grâce à des formations spécifiques s’appuyant sur le Manuel pour enquêter efficacement sur la torture et autres peines ou traitements cruels, inhumains ou dégradants (Protocole d’Istanbul). 
                - évaluer l’efficacité et l’incidence de ces programmes de formation et de cet enseignement", @"مواصلة وضع برامج التدريب، وتعزيز تلك البرامج ليتسنى لجميع الموظفين - العاملين ضمن قوات إنقاذ القانون، وأجهزة الاستخبارات، وأفراد الأمن، والعسكريين، وموظفي السجون، وموظفي القطاع الطبي العاملين في السجون أوفي مستشفيات الأمراض النفسانية - من معرفة أحكام الاتفاقية تمام المعرفة، ولكيلا يُتسامح في أمر الانتهاكات التي يبلغ عنها، وأن يحقق في ِشأن تلك الانتهاكات، وأن يلاحَق مرتكبوها قضائياً. وعلاوة على ذلك، 
                - التأكد من تعلّم جميع الموظفين المعنيين، بمن فيهم الطواقم الطبية، كيفية كشف علامات التعذيب وسوء المعاملة عن طريق تنظيم دورات خاصة تعتمد على دليل التحري والتوثيق الفعالين بشأن التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة (بروتوكول اسطنبول). وأخيراً، ينبغي أن تقيّم الدولة الطرف فعالية وتأثير هذه البرامج التدريبية وهذا التعليم.", "", "" },
                    { 28, null, "R20P1", "ت.20.ف1", "", "En cours", "", 30, 7, null, 1, null, 36, null, "Organes de traités", "Accentuer les efforts de formation aux droits de l’homme, en particulier à la lutte contre la discrimination raciale, de même que ses efforts de sensibilisation à la tolérance, à l’entente interraciale ou interethnique et aux relations interculturelles auprès des agents chargés de l’application des lois, notamment des personnels de police et de gendarmerie, de la justice, de l’administration pénitentiaire, des avocats, ainsi que des enseignants.", "- بذل مزيد من الجهود للتدريب على حقوق الإنسان، وخاصة على مكافحة التمييز العنصري، ومزيد من جهود التحسيس كذلك في صفوف الموظفين المكلفين بإنفاذ القوانين، ولا سيما العاملين في الشرطة والدرك والقضاء وإدارة السجون، وفي صفوف المحامين والمدرِّسين، بقيم التسامح والوئام بين الأعراق أو الإثنيات والعلاقات بين الثقافات.", "", "" },
                    { 362, null, "R27P3", "ت.27.ف.3", "", "En cours", "", 30, 7, null, 8, null, 36, null, "Organes de traités", "c) Concevoir des programmes de renforcement des capacités à l’intention des fonctionnaires concernant le droit des personnes handicapées à la reconnaissance de leur personnalité juridique dans des conditions d’égalité et le système de prise de décisions assistée, et de sensibiliser les personnes handicapées, leur famille et la société à ce droit et à ce système.", "(ج) تصميم برامج ترمي إلى بناء قدرات الموظفين العموميين فيما يتعلق بحق الأشخاص ذوي الإعاقة في الاعتراف بهم على قدم المساواة مع الآخرين أمام القانون، وتطبيق نظام تقديم الدعم في اتخاذ القرارات، وإلى إذكاء الوعي في أوساط الأشخاص ذوي الإعاقة وأسرهم والمجتمع بهذا الشأن.", "", "" },
                    { 112, null, "R40", "ت.40", "", "En cours", "", 30, 5, null, 3, null, 27, null, "Organes de traités", "Eliminer toute disposition législative ou pratique discriminatoire qui viole la liberté de pensée, de conscience et de religion et s’assurer que le projet de Code pénal, actuellement en discussion, est pleinement conforme à l’article 18 du Pacte.", "-          إلغاء كل حكم أو ممارسة تنطوي على تمييز تنتهك حرية الفكر والوجدان والدين، وكفالة التوافق التام لمشروع القانون الجنائي، قيد النقاش حالياً، مع المادة 18 من العهد.", "", "" },
                    { 1145, null, "R144.200", "200.144", "", "Réalisé", "", 100, 6, 1, null, 50, 30, null, "Examen périodique universal", "Accélérer le processus d’adoption du projet de loi sur l’élimination de la violence à l’égard des femmes", "تسريع عملية اعتماد مشروع القانون المتعلق بالقضاء على العنف على المرأة", "", "" },
                    { 111, null, "R38", "ت.38", "", "Réalisé", "", 100, 5, null, 3, null, 26, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour faire en sorte que les activités de surveillance soient conformes aux obligations découlant du Pacte, notamment de l’article 17, et pour garantir que toute immixtion dans la vie privée soit conforme aux principes de légalité, de proportionnalité et de nécessité. 
                - Etablir des mécanismes de contrôle indépendants pour prévenir les abus.", @"اتخاذ جميع التدابير اللازمة بحيث تتوافق أنشطة المراقبة التي تضطلع بها مع التزاماتها بمقتضى العهد، خاصة المادة 17، وبحيث يتوافق أي تدخل في الخصوصية مع مبادئ الشرعية والتناسب والضرورة. 
                - إنشاء آليات رقابة مستقلة لمنع التجاوزات", "", "" },
                    { 176, null, "R48P1", "ت.48.ف.1", "", "Réalisé", "", 100, 3, null, 5, null, 9, null, "Organes de traités", @"Prendre les mesures nécessaires pour que la stratégie nationale de lutte contre le trafic des êtres humains comprenne notamment les mesures suivantes :
                a) Adopter une loi relative à la lutte contre la traite des personnes et à la protection des victimes de la traite ;", @"اتخاذ التدابير اللازمة كي تتضمن الاستراتيجية الوطنية لمحاربة الاتجار بالبشر التدابير التالية على وجه الخصوص:
                 (أ) اعتماد قانون لمكافحة الاتجار بالبشر وحماية ضحاياه؛", "", "" },
                    { 214, null, "R11P1P2P3", "ت.11.ف.1.ف.2.ف.3", "", "Réalisé", "", 100, 3, null, 6, null, 9, null, "Organes de traités", @"Incorporer le principe d’égalité des sexes dans la Constitution ou dans les autres dispositions de son droit interne, conformément à l’alinéa a) de l’article 2 de la Convention
                - Inscrire explicitement la définition de la discrimination figurant à l’article premier de la Convention dans sa législation nationale. 
                - Promulguer et de faire appliquer une loi générale relative à l’égalité des sexes, qui aurait une valeur contraignante dans les secteurs public comme privé, et de faire connaître aux femmes les droits qui sont les leurs en vertu de ces textes.", @"إدماج مبدأ المساواة بين المرأة والرجل في الدستور، أو في قانون آخر مناسب، بما يتماشى وأحكام المادة 2 (أ) من الاتفاقية، 
                -تضمين التشريعات الوطنية التعريف الكامل للتمييز الوارد في المادة 1 من الاتفاقية. 
                -سن وتنفيذ قانون شامل عن المساواة بين الجنسين يكون ملزما للقطاعين العام والخاص كليهما، وتثقيف النساء بحقوقهن بموجب ذلك القانون.", "", "" },
                    { 257, null, "R11", "ت.11", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Poursuivre et renforcer les efforts pour mettre l’ensemble de la législation, en particulier le Code de la famille, en conformité avec la Convention et pour abroger rapidement toutes les dispositions qui sont discriminatoires à l’égard des filles et des femmes et nuisent à tous les enfants, telles que celles concernant l’héritage et la polygamie. 
                - Songer à élaborer un code de l’enfance qui englobe tous les domaines de la Convention et à faire en sorte que les ressources humaines, financières et techniques nécessaires soient effectivement affectées à l’application de la législation relative aux enfants", @"مواصلة وتعزيز الجهود الرامية إلى جعل جميع التشريعات الوطنية، وبخاصة مدونة الأسرة، تتوافق مع الاتفاقية، 
                - الإسراع بإلغاء جميع الأحكام التي تنطوي على تمييز في حق الفتيات والنساء وتضر بجميع الأطفال، من قبيل أحكام الميراث وتعدد الزوجات. وتشجعها على النظر في وضع قانون للطفل يشمل جميع مجالات الاتفاقية، والتأكد من أن الموارد البشرية والمالية والتقنية اللازمة تُرصد فعلاً لتنفيذ التشريعات المتعلقة بالأطفال", "", "" },
                    { 258, null, "R65 P2", "ت.65.ف.2", "", "En cours", "", 30, 3, null, 7, null, 9, null, "Organes de traités", "b) veiller à ce que les lois qui interdisent l’emploi d’enfants âgés de moins de 15 ans et les formes dangereuses de travail des enfants âgés de moins de 18 ans, y compris le travail domestique, soient effectivement appliquées et que les personnes qui exploitent les enfants soient dûment sanctionnées;", "-           (ب) السهر على إنفاذ فعال للقوانين التي تحظر تشغيل الأطفال دون             سن 15 وأشكال عمل الأطفال دون سن 18 المحفوفة بالمخاطر، بما في ذلك الخدمة المنزلية، ومعاقبة من يستغلون الأطفال وفق القانون.", "", "" },
                    { 259, null, "R23P1", "ت.23.ف.1", "", "En cours", "", 30, 3, null, 7, null, 9, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                a) D’examiner et d’adapter son cadre législatif concernant la responsabilité juridique des entreprises commerciales et de leurs filiales gérées dans l’État partie ou ayant des activités sur son territoire, en particulier dans le secteur du tourisme", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                - (أ) النظر في إطارها التشريعي المتعلق بالمساءلة القانونية للشركات الخاصة وفروعها العاملة في إقليم الدولة الطرف أو التي تدار انطلاقاً منها، خاصة في قطاع السياحة، وتكييف ذلك الإطار", "", "" },
                    { 260, null, "R33", "ت.33", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", "Autoriser, par la loi, les femmes et les enfants à entamer les procédures pour établir la paternité sur la base d’analyses de l’ADN.", "-          إباحة إثبات الأبوة على أساس اختبار الحَمْض النَّوَوِي الرِّيْبِيِّ المنْزُوع الأوكسِجين للنساء والأطفال قانوناً.", "", "" },
                    { 261, null, "R37P2", "ت.37.ف.2", "", "En cours", "", 30, 3, null, 7, null, 9, null, "Organes de traités", @"Renvoyant à son Observation générale no 8 (2006) relative aux droits de l’enfant et à une protection contre les châtiments corporels et les autres formes cruelles ou dégradantes de châtiment, le Comité invite le Maroc à:
                       b) Faire réellement appliquer les lois interdisant les châtiments corporels et veiller à ce que des poursuites soient systématiquement engagées contre les personnes qui usent de violence envers les enfants", @"في ضوء تعليق اللجنة العام رقم 8(2006) بشأن حق الطفل في الحماية من العقوبة البدنية وغيرها من ضروب العقوبة القاسية أو المهينة، تحث اللجنة الدولة المملكة المغربية على ما يلي: 
                -  (ب) التأكد من تنفيذ القوانين التي تحظر العقوبة البدنية تنفيذاً فعّالاً ومن اتخاذ إجراءات قانونية بصورة منهجية ضد كل من أساء معاملة الأطفال؛", "", "" },
                    { 262, null, "R39P2", "ت.39.ف.2", "", "En cours", "", 30, 3, null, 7, null, 9, null, "Organes de traités", @"Le Comité recommande au Maroc de tenir compte de l’Observation générale no 13 (2011) sur le droit de l’enfant d’être protégé contre toutes les formes de violence, et en particulier de mettre en place, en étroite coopération avec la société civile, un système de protection des enfants bien coordonné et bien financé. Le Maroc devrait en particulier:
                b) Mettre en place un cadre juridique complet, ainsi qu’un cadre national de coordination pour prévenir, interdire et punir toutes les formes de délaissement, de sévices et de violence, notamment dans la famille, à l’égard de tous les enfants jusqu’à l’âge de 18 ans;", @"الأخذ في الحسبان التعليق العام  رقم 13(2011) بشأن حق الطفل في التحرر من جميع أشكال العنف، ووضع نظاماً لحماية الطفل منسقاً تنسيقاً جيداً وممولاً تمويلاً كافياً بتعاون وثيق مع المجتمع المدني و الاضطلاع بما يلي خاصةً:
                -  (ب) وضع إطار قانوني شامل، إضافة إلى إطار تنسيق وطني، لمنع جميع أشكال الإهمال وإساءة المعاملة والعنف، بما فيه العنف المنزلي، التي يتعرض لها كل الأطفال حتى سن 18؛", "", "" },
                    { 263, null, "R43", "ت.43", "", "En cours", "", 30, 3, null, 7, null, 9, null, "Organes de traités", "Le Comité appelle le Maroc sur les nombreuses conséquences néfastes des mariages précoces et lui demande instamment de ne pas ramener à 16 ans l’âge minimum du mariage et de prendre des mesures concrètes pour mettre fin à la pratique des mariages précoces et forcés.", "تلفت اللجنة انتباه الدولة الطرف إلى العواقب الوخيمة الكثيرة الناشئة عن الزواج المبكر، وتحثها على الامتناع عن خفض الحد الأدنى لسن الزواج إلى 16 عاماً وعلى اتخاذ تدابير فعالة من أجل وضع حد للزواج المبكر والزواج بالإكراه.", "", "" },
                    { 264, null, "R49P2", "ت.49.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 9, null, "Organes de traités", @"Appelant l’attention sur les lignes directrices relatives à la protection de remplacement pour les enfants (résolution 64/142 de l’Assemblée générale, annexe), le Comité demande instamment au Maroc :
                b) D’achever le processus d’adoption du projet de loi sur la protection de remplacement en accordant la priorité à d’autres solutions que le placement en institution, en particulier au placement auprès d’un parent, au placement en famille d’accueil et au renforcement des programmes visant à prévenir le placement dans des structures de remplacement;", @"تلفت اللجنة انتباه المملكة المغربية إلى المبادئ التوجيهية للرعاية البديلة للأطفال (مرفق قرار الجمعية العامة 64/142) وحثتها على ما يلي: 
                -  (ب) وضع الصيغة النهائية لعملية اعتماد مشروع القانون عن الرعاية البديلة، مع إيلاء الأولوية لبدائل المؤسسات، لا سيما رعاية ذوي القربى والحضانة وبرامج توثيق الأواصر الأسرية توقياً للإيداع خارج البيت", "", "" },
                    { 320, null, "R13P1P2", "ت.13.ف1.ف.2", "", "Réalisé", "", 100, 3, null, 8, null, 9, null, "Organes de traités", @"a) Définir dans la législation nationale le refus d’aménagement raisonnable comme constituant une forme de discrimination fondée sur le handicap 
                b) Introduire expressément dans la législation nationale une protection contre les formes de discrimination multiples et croisées fondées sur le sexe, le genre, l’âge, le handicap, l’origine nationale, l’appartenance ethnique et le statut migratoire, et de prévoir des sanctions effectives en cas de non-respect", @"(أ) إدراج الحرمان من الترتيبات التيسيرية المعقولة في التشريعات الوطنية باعتباره من أشكال التمييز بسبب الإعاقة.
                -  (ب) إدراج حكم في القانون الوطني ينص على توفير حماية صريحة من التعرض لأشكال التمييز المتعدد الجوانب والمتقاطع بسبب الجنس والسن والإعاقة والأصل القومي والأصل الإثني والوضع كمهاجر، وعلى فرض جزاءات فعالة ضد الجناة", "", "" },
                    { 321, null, "R15P1", "ت.15.ف.1", "", "En cours", "", 30, 3, null, 8, null, 9, null, "Organes de traités", @"conformément à son observation générale no 3 (2016) sur les femmes et les filles handicapées et à la cible 5.2 des objectifs de développement durable, Le Comité recommande de mettre fin à toute forme de violence à l’égard des femmes et des filles handicapées dans les sphères tant publique que privée, notamment à la traite et à l’exploitation, sexuelle et autre. Il recommande également :
                a) D’intégrer la question des droits des femmes et des filles handicapées dans la législation sur l’égalité des sexes, ainsi que dans les lois et les politiques relatives au handicap,….", @"تماشياً مع التعليق العام رقم 3(2016) بشأن النساء والفتيات ذوات الإعاقة والغاية 5-2 من أهداف التنمية المستدامة، توصي اللجنة الدولة الطرف بالقضاء على جميع أشكال العنف ضد النساء والفتيات في المجالين العام والخاص، بما في ذلك الاتجار بالبشر والاستغلال الجنسي وغير ذلك من أشكال الاستغلال. وتوصي الدولة الطرف أيضاً بما يلي:‬‬‬‬ ‬‬
                -  (أ) تعميم مراعاة حقوق النساء والفتيات ذوات الإعاقة في التشريعات المتعلقة بالمساواة بين الجنسين وفي التشريعات والسياسات المتعلقة بالإعاقة….", "", "" },
                    { 322, null, "R39P1", "ت.39.ف.1", "", "En cours", "", 30, 3, null, 8, null, 9, null, "Organes de traités", "Reconnaître dans sa législation le droit subjectif des personnes handicapées de vivre de façon indépendante et d’être incluses dans la société", "(أ) الاعتراف في التشريعات بالحق الذاتي للأشخاص ذوي الإعاقة في العيش المستقل وإدماجهم في المجتمع‬ المحلي؛", "", "" },
                    { 323, null, "R43P2P3", "ت.43.ف.2ف.3", "", "En cours", "", 30, 3, null, 8, null, 9, null, "Organes de traités", @"b) Adopter des lois et des mesures visant à garantir que les propriétaires et les concepteurs de sites Web rendent leurs sites accessibles aux personnes handicapées, en particulier aux personnes aveugles et malvoyantes 
                - c) Accélérer l’adoption du projet de loi sur le droit à l’accès à l’information et d’en éliminer toute restriction qui entrave la jouissance de ce droit par les personnes handicapées", @"(ب) اعتماد تشريعات وتدابير مناسبة تضمن أن يوفر أصحاب المواقع الشبكية ومصمموها إمكانية الوصول إلى مواقعهم للأشخاص ذوي الإعاقة، ولا سيما للمكفوفين وذوي العاهات البصرية؛
                -  (ج) تسريع إجراءات اعتماد مشروع القانون المتعلق بالحق في الحصول على المعلومات، وإلغاء أي قيود فيه تعوق تمتع الأشخاص ذوي الإعاقة بهذا الحق.", "", "" },
                    { 324, null, "R63P3", "ت.63.ف.3", "", "Réalisé", "", 100, 3, null, 8, null, 9, null, "Organes de traités", "Accélérer l’adoption par le parlemeent du projet de loi relatif au Conseil national des droits de l’homme conférant à celui-ci les pouvoirs d’un mécanisme indépendant de protection, de promotion et de suivi de l’application de la Convention, conformément aux dispositions de l’article 33 de la Convention, et d’allouer au Conseil des ressources budgétaires et humaines suffisantes ;", "-       (ج) إسراع البرلمان في اعتماد مشروع القانون المتعلق بالمجلس الوطني لحقوق الإنسان الذي يعترف بصلاحية المجلس ممارسة الاختصاصات المخولة لآلية مستقلة لحماية الاتفاقية وتعزيزها ورصد تنفيذها، وفقاً للأحكام الواردة في المادة ٣٣ من الاتفاقية، ورصد ما يكفي من مخصصات الميزانية والموارد البشرية للمجلس؛", "", "" },
                    { 401, null, "R66P1", "null", "", "Non réalisé", "", 0, 3, null, null, null, 9, 1, "Procédure spéciale", "-   Élaborer et adopter une loi-cadre relative au droit à l’alimentation prévoyant des plans de mise en œuvre pour chaque région ainsi qu’un calendrier des opérations. Cette loi devrait également prévoir les mesures budgétaires et fiscales nécessaires afin d’être viable dans la durée", "null", "", "" },
                    { 402, null, "R92", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 1, "Procédure spéciale", "-   Adopter au plus vite le projet de loi n o 97.13 relatif à la protection et à la promotion des droits des personnes en situation de handicap, actuellement examiné par le 32, afin de garantir la protection juridique des personnes handicapées", "null", "", "" },
                    { 442, null, "R71", "null", "", "En cours", "", 30, 3, null, null, null, 9, 2, "Procédure spéciale", "-       Adopter des dispositions législatives et des mesures concrètes pour faire en sorte que l’élimination du racisme, de la discrimination raciale, de la xénophobie et de l’intolérance qui y est associée soit intégrée aux travaux et au mandat des organes chargés de promouvoir les droits de l’homme, l’égalité et la non-discrimination.", "null", "", "" },
                    { 443, null, "R78P1", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 2, "Procédure spéciale", "-       Adopter sans délai la loi organique nécessaire pour donner à l’amazigh le statut constitutionnel de langue officielle", "null", "", "" },
                    { 480, null, "R87P1", "ت.87.ف.1", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "a) Modifier l’article 231-1 du Code pénal pour faire en sorte que la complicité ou le consentement exprès ou tacite des fonctionnaires chargés d’appliquer la loi et des forces de sécurité ou de toute autre personne agissant à titre officiel soient expressément visés", "-          (أ) تعديل المادة 231-1 من القانون الجنائي بحيث تشمل تحديداً تواطؤ موظفي إنفاذ القانون أو غيرهم من الأشخاص الذين يتصرفون بصفة رسمية أو موافقتهم الصريحة أو الضمنية؛", "", "" },
                    { 481, null, "R87P2", "ت.87.ف.2", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    Modifier l’article 224 du Code pénal pour mettre la définition du fonctionnaire public en conformité avec la définition de l’agent de la 21 ou toute autre personne agissant à titre officiel qui figure dans la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "-          (ب) تعديل المادة 224 من القانون الجنائي بحيث يتوافق تعريف الموظف العمومي مع تعريف موظف الخدمة المدنية أو غيره من الأشخاص الذين يعملون بصفة رسمية، الوارد في اتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة؛", "", "" },
                    { 482, null, "R87P3", "ت.87.ف.3", "", "Réalisé", "", 100, 3, null, null, null, 9, 3, "Procédure spéciale", "-    veiller à ce qu’aucune personne reconnue coupable d’actes de torture ou faisant l’objet de poursuites pour de tels actes ne puisse bénéficier d’une mesure d’amnistie", "-          (ج)  التأكد من عدم استفادة أي شخص مدان أو محكوم عليه بسبب ارتكابه جريمة التعذيب من أي عفو؛", "", "" },
                    { 483, null, "R87P4", "ت.87.ف.4", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    inclure dans le Code pénal une disposition expresse établissant que l’ordre d’un supérieur ou d’une autorité publique ne peut être invoqué pour justifier la torture, et mettre en place un mécanisme pour la protection des subordonnés qui refusent d’obéir à un ordre visant à torturer une personne en détention", "-          (د) إدراج حكم محدد في القانون الجنائي ينص على أنه لا يجوز الاحتجاج بصدور أمر من موظف سام أو سلطة عامة لتبرير التعذيب، وتوفير آلية لحماية المرؤوسين الذين يرفضون إطاعة أوامر تعذيب أشخاص محتجزين لديهم؛", "", "" },
                    { 484, null, "R87P5", "ت.87.ف.5", "", "Non réalisé", "", 0, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier la loi (no 03-03) contre le terrorisme de façon à réduire le délai de garde à vue de quatre-vingt-seize heures (renouvelables deux fois)", "-          (ﻫ) تعديل قانون مكافحة الإرهاب (03-03) لتقليص مدة الحبس الاحتياطي البالغة 96 يوماً (والقابلة للتجديد مرتين)؛", "", "" },
                    { 485, null, "R87P6", "ت.87.ف.6", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 290 du Code de procédure pénale de façon à appliquer aux infractions pénales la règle de la preuve qui régit les délits et contraventions afin que tous les rapports établis par la police pour des procès pénaux soient considérés comme des éléments de preuve parmi d’autres sans présomption quant à leur véracité", "-          (و) مراجعة المادة 290 من قانون الإجراءات الجنائية كي تشمل معايير الاستدلال، التي تحكم الجرائم والتي يُعمل بها أصلاً، الجنحَ والمخالفات، بحيث يُتعامل مع جميع بيانات المحاكمات الجنائية التي تعدها الشرطة على أنها دليل واحد في جملة أدلة، دون افتراض صدقها؛", "", "" },
                    { 486, null, "R87P7", "ت.87.ف.7", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier le Code de procédure pénale pour qu’il dispose qu’en cas d’allégation de torture ou de mauvais traitements, la charge de la preuve incombe à l’accusation, qui doit montrer au-delà de tout doute raisonnable que les aveux soumis au tribunal n’ont pas été obtenus par des moyens illicites", "-          (ز) تعديل قانون الإجراءات الجنائية بحيث ينص على أنه متى كان ادعاء بالتعذيب أو سوء المعاملة، كان على الادعاء أن يثبت، دون أي شك معقول، أن كل اعتراف من الاعترافات لم يُنتزع بأساليب غير مشروعة؛", "", "" },
                    { 487, null, "R87P8", "ت.87.ف.8", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 84 de la loi (no 23/98) sur les prisons de façon à habiliter les directeurs régionaux à autoriser les organisations de la société civile à visiter les établissements pénitentiaires, et de modifier l’article 10 du décret d’application de la loi no 23/98 afin d’élargir le champ des activités des organisations non gouvernementales dans ce domaine", "-          (ح) تعديل المادة 84 من قانون السجون (رقم 23/98) بحيث يخول المديرين الإقليميين سلطة الترخيص لمنظمات المجتمع المدني بزيارة المؤسسة؛ وتعديل المادة 10 من المرسوم التنفيذي للقانون رقم 23/98 بحيث توسع نطاق أنشطة المنظمات غير الحكومية في هذا المجال؛", "", "" },
                    { 175, null, "R26", "ت.26", "", "Réalisé", "", 100, 3, null, 5, null, 9, null, "Organes de traités", "Compte tenu de son observation générale no 2 (2013) sur les droits des travailleurs migrants en situation irrégulière et des membres de leur famille, le Comité considère que l’entrée ou la sortie d’un travailleur migrant de l’État partie, sans la documentation requise, ainsi que le séjour au-delà de la durée de validité d’un permis de séjour ne peuvent être considérés comme des infractions pénales. Par conséquent, le Comité recommande à l’État partie de dépénaliser la migration irrégulière et de prévoir des sanctions administratives adéquates.", "إلغاء تجريم الهجرة غير الشرعية وإقرار عقوبات إدارية مناسبة  اعتبارا للتعليق العام للجنة رقم 2(2013) بشأن حقوق العمال المهاجرين الذين هم في وضع غير نظامي وأفراد أسرهم ولكونها  ترى ان دخول عامل مهاجر الدولة الطرف أو خروجه منها دون حمل الوثائق المطلوبة، وإقامته بها لفترة تتجاوز تاريخ صلاحية تصريح إقامته أمور لا يمكن أن تعتبر جرائم.", "", "" },
                    { 488, null, "R87P9", "ت.87.ف.9", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    modifier l’article 134 du Code pénal pour faire en sorte que les auteurs d’infraction souffrant d’une maladie mentale soient placés dans un établissement psychiatrique, quelle que soit la gravité de l’infraction commise", "-          (ط) تعديل المادة 134 من القانون الجنائي بحيث تنص على إيداع جميع المجرمين المصابين بخلل عقلي في مصحة نفسية، بصرف النظر عن درجة خطورة الجرم.", "", "" },
                    { 174, null, "R32P1", "ت.32.ف.1", "", "Réalisé", "", 100, 3, null, 5, null, 9, null, "Organes de traités", "-       Prendre les mesures appropriées pour mettre en place un cadre juridique régissant les procédures d’expulsion/de renvoi conformément aux dispositions de la Convention et de prendre en compte l’observation générale no 2 du Comité qui énonce en particulier que les intéressés ont le droit de faire valoir les raisons pour lesquelles ils ne devraient pas être expulsés et de faire examiner leur cas par une autorité compétente.", ". اتخاذ التدابير المناسبة لوضع إطار قانوني ينظم إجراءات الطرد/الإعادة وفقاً لأحكام الاتفاقية، كما توصيها بأن تضع في اعتبارها تعليقها العام رقم 2 الذي ينص تحديدا ًعلى أن من حق الأشخاص المعنيين بيان الأسباب التي تبرر ضرورة عدم طردهم، وعرض حالتهم على سلطة مختصة", "", "" },
                    { 137, null, "R50P1", "ت.50.ف.1", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", "-            Adopter, le plus rapidement possible, le projet de loi organique sur la langue amazighe comme une des langues officielles de l’État", "-          اعتماد مشروع القانون الأساسي بشأن اللغة الأمازيغية باعتبارها من اللغات الرسمية للدولة في أقرب وقت ممكن", "", "" },
                    { 587, null, "R83P16", "null", "", "Réalisé", "", 100, 2, null, null, null, 7, 6, "Procédure spéciale", "-       En ce qui concerne les migrants en situation irrégulière, réfugiés et demandeurs d’asile, travailler en coopération plus étroite avec le Haut-Commissariat des Nations Unies pour les réfugiés ; le Haut-Commissariat des Nations Unies aux droits de l’homme ; le Rapporteur spécial sur les droits de l’homme des migrants et d’autres organismes des Nations Unies", "null", "", "" },
                    { 614, null, "R90P3", "ت.90.ق.3", "", "En cours", "", 30, 2, null, null, null, 7, 7, "Procédure spéciale", "Intensifier les efforts pour appliquer la Convention pour la sauvegarde du patrimoine culturel immatériel.", "- الدفع قدما بالجهود فيما يتعلق بتنفيذ اتفاقية صون التراث الثقافي غير المادي.", "", "" },
                    { 638, null, "R73P8-2", "null", "", "En cours", "", 30, 2, null, null, null, 7, 8, "Procédure spéciale", "L’Experte indépendante encourage le Gouvernement à redoubler d’efforts en vue de soumettre ses rapports en temps voulu aux organes conventionnels des droits de l’homme pertinents", "null", "", "" },
                    { 1026, null, "R144.17", "17.144", "", "Réalisé", "", 100, 2, 1, null, 80, 7, null, "Examen périodique universal", "Adopter un processus de sélection ouvert, fondé sur le mérite, pour sélectionner les candidats nationaux aux élections aux organes conventionnels de l’ONU", "اعتماد إجراء اختيار علني وقائم على الجدارة والاستحقاق عند اختيار المرشحين الوطنيين لانتخاب أعضاءٍ في هيئات معاهدات الأمم المتحدة", "", "" },
                    { 1027, null, "R144.29", "29.144.", "", "Réalisé", "", 100, 2, 1, null, 84, 7, null, "Examen périodique universal", "Continuer de travailler avec le HCDH et le Haut-Commissariat des Nations Unies pour les réfugiés pour rétablir le programme d’aide humanitaire à la population du Sahara occidental", "مواصلة العمل مع مفوضية الأمم المتحدة السامية لحقوق الإنسان ومع مكتب مفوضية الأمم المتحدة السامية لشؤون اللاجئين من أجل إعادة العمل ببرنامج المعونة الإنسانية لسكان الصحراء الغربية", "", "" },
                    { 11, null, "R22", "ت.22", "", "En cours", "", 30, 2, null, 1, null, 8, null, "Organes de traités", "A la lumière de sa Recommandation générale no. 33 (2009) sur le suivi de la Conférence d’examen de Durban, le Comité recommande à l’État partie de tenir compte de la Déclaration et du Programme d’action de Durban adoptés en septembre 2001 par la Conférence mondiale contre le racisme, la discrimination raciale, la xénophobie et l’intolérance qui y est associée, ainsi que du document final de la Conférence d’examen de Durban, qui s’est tenue à Genève en avril 2009, lorsqu’il applique la Convention dans son ordre juridique interne.", "القيام بإنفاذ إعلان وبرنامج عمل ديربان اللذين اعتمدا في أيلول/سبتمبر 2001 أثناء المؤتمر العالمي لمناهضة العنصرية والتمييز العنصري وكراهية الأجانب وما يتصل بذلك من تعصب، على ضوء توصية اللجنة العامة رقم 33(2009) بشأن متابعة مؤتمر استعراض نتائج ديربان، مع مراعاة الوثيقة الختامية لهذا المؤتمر  الذي عُقد في جنيف في نيسان/أبريل 2009، عندما تكون بصدد إدراج أحكام الاتفاقية في نظامها القانوني الداخلي. وتطلب اللجنة إلى الدولة الطرف أن تورد في تقريرها الدوري المقبل معلومات محددة عن خطط العمل وغيرها من التدابير المتخذة لتنفيذ إعلان وبرنامج عمل ديربان على الصعيد الوطني.", "", "" },
                    { 12, null, "R9", "ت.9", "", "En cours", "", 30, 3, null, 1, null, 9, null, "Organes de traités", "Le Comité recommande à l’État partie d’amender sa 9 ou d’adopter une législation spécifique relative à l’interdiction de la discrimination raciale qui soit en pleine conformité avec l’article premier de la Convention.", "تعديل التشريعات الوطنية أو اعتماد تشريع يتناول تحديداً حظر التمييز العنصري على نحو يتماشى تماماً مع المادة 1 من الاتفاقية.", "", "" },
                    { 13, null, "R11P4", "ت.11.ف.4", "", "Réalisé", "", 100, 3, null, 1, null, 9, null, "Organes de traités", "Envisager l’inscription dans la constitution de la langue amazigh comme langue officielle", "التفكير في إدراج اللغة الأمازيغية كلغة رسمية في الدستور", "", "" },
                    { 14, null, "R12", "ت.12", "", "Réalisé", "", 100, 3, null, 1, null, 9, null, "Organes de traités", "clarifier la signification et la portée dans sa 9 de la notion de «prénom à caractère marocain» et garantir pleinement l’application par les officiers d’état civil de la circulaire du Ministère de l’intérieur de mars 2010 relative aux choix des prénoms, afin d’assurer pour tous l’inscription de prénoms, en particulier des prénoms amazighs", "توضيح معنى ونطاق مفهوم 'مغربية الاسم' في التشريعات. وضمان تطبيق ضباط الحالة المدنية لما نص عليه تعميم وزارة الداخلية المؤرخ في آذار/مارس 2010 المتعلق باختيار الأسماء والذي يضمن لجميع المواطنين تسجيل الأسماء، وخاصة الأمازيغية منها.", "", "" },
                    { 15, null, "R13P1", "ت.13.ف.1", "", "En cours", "", 30, 3, null, 1, null, 9, null, "Organes de traités", "Etablir un cadre juridique et institutionnel visant à clarifier les procédures d’asile", "إنشاء إطار قانوني ومؤسسي تكون الغاية منه توضيح إجراءات اللجوء", "", "" },
                    { 16, null, "R18P1P4", "ت.18.ف1.ف.4", "", "Réalisé", "", 100, 3, null, 1, null, 9, null, "Organes de traités", "Promouvoir la législation relative à la discrimination raciale,Le Comité recommande en outre que dans la législation de l’État partie la charge de la preuve soit renversée lorsque les faits de discrimination raciale relèvent de la matière civile", "تعزيز التشريع المتعلق بالتمييز العنصري .وضع عبء ا الإثبات في التشريعاتُ الوطنية على الطرف المدعى عليه بالنسبة لأفعال التمييز العنصري الواقعة في سياق قضايا مدنية", "", "" },
                    { 46, null, "R5P1", "ت.5.ف.1", "", "En cours", "", 30, 3, null, 2, null, 9, null, "Organes de traités", "S’assurer que les projets de loi actuellement devant le 32étendent le champ d’application de la définition de la torture, conformément à l’article premier de la Convention contre la torture.", "العمل على أن تتضمن مشاريع القوانين المعروضة حالياً على البرلمان توسيعا لنطاق تطبيق تعريف التعذيب وفقاً للمادة الأولى من اتفاقية مناهضة التعذيب.", "", "" },
                    { 47, null, "R6P1", "ت.6.ف.1", "", "En cours", "", 30, 3, null, 2, null, 9, null, "Organes de traités", "S’assurer que le cadre juridique prévoie l’interdiction de toute amnistie éventuelle des crimes de torture et de tout pardon en violation de la Convention.", "العمل على أن ينصّ الإطار القانوني على حظر أي عفو عام محتمل عن جرائم التعذيب وحظر أي عفو ينتهك الاتفاقية.", "", "" },
                    { 48, null, "R7P1", "ت.7.ف.1", "", "En cours", "", 30, 3, null, 2, null, 9, null, "Organes de traités", "Veiller à ce que les projets de loi actuellement à l’étude garantissent à toute personne suspectée le droit de bénéficier dans la pratique des garanties fondamentales prévues par la loi, qui incluent notamment que l’intéressé ait accès à un avocat dès son arrestation, qu’il soit examiné par un médecin indépendant, qu’il puisse contacter un proche, qu’il soit informé de ses droits – comme des charges retenues contre lui –, et qu’il soit présenté immédiatement devant un juge.", "الحرص على أن تتضمن مشاريع القوانين قيد البحث حالياً لكل مشتبه فيه الحق في الاستفادة عملياً من الضمانات الأساسية التي ينص عليها القانون والتي تشمل الحق في الوصول إلى محام لحظة إيقافه، وفي أن يتولى طبيب مستقل فحصه، وفي أن يتمكن من الاتصال بأحد أقاربه، وفي أن يطلع على حقوقه وعلى التهم الموجهة إليه كذلك، وفي أن يُعرض فوراً على قاض.", "", "" },
                    { 49, null, "R23P1P3", "ت.23.ف.1.ف.3", "", "Réalisé", "", 100, 3, null, 2, null, 9, null, "Organes de traités", "Promulguer au plus vite une législtion sur la violence faite aux femmes et aux filles de manière à ériger en infractions pénales toutes les formes de violence à l’encontre des femmes. Modifier sans plus tarder le Code pénal de manière à criminaliser le viol conjugal et à s’assurer que les auteurs de viols n’échappent pas aux poursuites pénales quand ils épousent leur victime", "سنّ قانون في أسرع وقت بشأن العنف المرتكب في حق النساء والفتيات، بصفة تجرم جميع أشكال العنف ضد النساء.  تعديل، القانون الجنائي بصفة تجرم الاغتصاب في إطار الزواج وضمان عدم إفلات المغتصبين من الملاحقة الجنائية في حالة زواجهم من الضحية", "", "" },
                    { 50, null, "R25P1", "ت.25.ف.1", "", "En cours", "", 30, 3, null, 2, null, 9, null, "Organes de traités", "établir un cadre juridique en vue de garantir les droits des réfugiés et des demandeurs d’asile.", "وضع إطار قانوني لضمان حقوق اللاجئين وطالبي اللجوء", "", "" },
                    { 51, null, "R27P1", "ت.27.ف.1", "", "Réalisé", "", 100, 3, null, 2, null, 9, null, "Organes de traités", "Intensifier les efforts pour prévenir et combattre la traite des femmes et des enfants, notamment en adoptant une loi spécifique sur la prévention, la répression de la traite et la protection des victimes,", "-          تكثيف الجهود لمنع ومكافحة الاتجار بالنساء والأطفال، لا سيما عن طريق سن قانون محدد بشأن منع حدوثه", "", "" },
                    { 93, null, "R8", "ت.8", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", @"Elaborer une législation comportant des dispositions claires sur l’état d’exception, de façon à ce que les droits protégés par le paragraphe 2 de l’article 4 du Pacte ne puissent être suspendus en aucune circonstance,
                 
                Veiller à ce que les conditions requises pour une dérogation soient conformes au Pacte.", "سنّ تشريع يتضمن أحكاماً واضحة عن حالة الطوارئ بحيث لا يمكن تعطيل العمل بالحقوق التي تحميها الفقرة 2 من المادة 4 من العهد بأي حال من الأحوال، وكفالة تَوافق مقتضيات أي استثناء من ذلك مع العهد، عملا بما جاء في التعليق العام للجنة رقم 29(2001) بشأن عدم التقيّد بأحكام العهد أثناء حالات الطوارئ.", "", "" },
                    { 94, null, "R26", "ت.26", "", "En cours", "", 30, 3, null, 3, null, 9, null, "Organes de traités", "L’État partie devrait veiller à ce que la réforme législative en cours fixe la durée normale de la garde à vue à quarante-huit heures et garantisse à toute personne arrêtée l’accès immédiat à un avocat dès le début de la détention.", "الحرص على أن يحدد الإصلاح التشريعي الجاري المدة العادية للاحتجاز لدى الشرطة بـ 48 ساعة، ويتيح  لكل شخص يلقى عليه القبض إمكانية توكيل محام منذ بداية الاحتجاز.", "", "" },
                    { 95, null, "R36 P9", "ت.36.ف.9", "", "Non réalisé", "", 0, 3, null, 3, null, 9, null, "Organes de traités", "f)…….. adopter un cadre juridique pour prévenir l’apatridie.", "-           (و)  ........اعتماد إطار قانوني لمنع انعدام الجنسية", "", "" },
                    { 130, null, "R14P1", "ت.14.ف.1", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", @"Tenant en compte son observation générale no 20 (2009) sur la non-discrimination dans l’exercice des droits économiques, sociaux et culturels, le Comité appelle à :
                a) Adopter et mettre en œuvre une loi anti discrimination complète, qui devrait interdire de manière générale toute forme de discrimination, directe et indirecte, et qui autorise la mise en œuvre de mesures spéciales temporaires en faveur des groupes défavorisés ou marginalisés ;", @"رجوعا إلى تعليقها العام رقم 20(2009) بشأن عدم التمييز في الحقوق الاقتصادية والاجتماعية والثقافية، تدعو اللجنة إلى:
                (أ) اعتماد وتنفيذ قانون شامل لمكافحة التمييز يحظر بصفة عامة جميع أشكال التمييز، المباشر منه وغير المباشر، ويجيز تنفيذ التدابير الخاصة المؤقتة لمصلحة الفئات المحرومة أو المهمشة؛", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 131, null, "R18P1", "ت.18.ف.1", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", @"Tenant compte de son observation générale no 16 (2005) sur le droit égal de l’homme et de la femme au bénéfice de tous les droits économiques, sociaux et culturels, le Comité recommande de :
                - a) …Prendre en considération les avis des parties prenantes en vue de l’adoption des différentes lois pendantes, notamment la loi 79.14 relative à l’Autorité pour la parité et la lutte contre toutes les formes de discrimination", @"في ضوء تعليقها العام رقم 16(2005) بشأن المساواة بين الرجل والمرأة في حق التمتع بجميع الحقوق الاقتصادية والاجتماعية والثقافية، توصي اللجنة بما يلي:
                (أ) ..... الأخذ بآراء الجهات صاحبة المصلحة من أجل اعتماد مختلف القوانين المعلقة، بما في ذلك القانون رقم 79-14 المتعلق بهيئة المناصفة ومكافحة كل أشكال التمييز", "", "" },
                    { 132, null, "R30P1P2", "ت.30.ف.1.ف.2", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", @"Adopter le projet de loi fixant les conditions de travail et d’emploi des employés de maison. 
                - S’assurer que cette loi établisse l’âge minimum à 18 ans et garantisse que les travailleurs domestiques jouissent de conditions de travail justes et favorables comme d’autres travailleurs", @"اعتماد مشروع القانون الذي يحدد شروط عمل العمال المنزليين وتشغيلهم. 
                - الحرص على أن يحدد هذا القانون سن 18 عاماً سناً دنيا، ويضمن تمتع العمال المنزليين بشروط عمل عادلة وملائمة إسوة بغيرهم من العمال.", "", "" },
                    { 133, null, "R32P1", "ت.32.ف.1", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", "-            Accélérer l’adoption du projet de loi sur le harcèlement sexuel, en particulier sur le lieu de travail, mais aussi le harcèlement sexuel sous toutes ses formes et en tout lieu, incluant des peines à la mesure de la gravité de cette infraction.", "-          الإسراع في اعتماد مشروع القانون بشأن التحرش الجنسي لا سيما في مكان العمل، فضلاً عن التحرش الجنسي بجميع أشكاله وفي أي مكان كان، على أن يتضمن عقوبات تتناسب مع خطورة الجريمة.", "", "" },
                    { 134, null, "R34P2", "ت.34.ف.2", "", "En cours", "", 30, 3, null, 4, null, 9, null, "Organes de traités", "-            Adopter les lois relatives à l’exercice du droit de grève et aux syndicats professionnels.", "-          اعتماد القوانين المتعلقة بممارسة الحق في الإضراب وبالنقابات المهنية.", "", "" },
                    { 135, null, "R24P1", "ت.24.ف.1", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", "-            Accélérer l’adoption de la loi relative à la promotion et à la protection des droits des personnes handicapés et de promouvoir son application.", "-          الإسراع في اعتماد القانون المتعلق بتعزيز وحماية حقوق الأشخاص ذوي الإعاقة الذكر والتشجيع على تطبيقه.", "", "" },
                    { 136, null, "R38P1", "ت.38.ف.1", "", "Réalisé", "", 100, 3, null, 4, null, 9, null, "Organes de traités", "Adopter une législation globale sur les violences faites aux femmes conformément aux normes internationales en la matière et de veiller à son application en vue d’éliminer toutes les formes de violence à l’égard des femmes, y compris le viol conjugal", "-          اعتماد تشريعات شاملة بشأن العنف ضد المرأة بما يتماشى مع المعايير الدولية في هذا المجال، وبالحرص على تطبيق هذه التشريعات بغية القضاء على جميع أشكال العنف ضد المرأة بما في ذلك الاغتصاب الزوجي.", "", "" },
                    { 173, null, "R20P1P3", "ت.20.ف1.ف 3.", "", "En cours", "", 30, 3, null, 5, null, 9, null, "Organes de traités", @"veiller à ce que tous les travailleurs migrants et les membres de leur famille se trouvant sur son territoire ou relevant de sa juridiction jouissent sans discrimination aucune des droits reconnus par la Convention, conformément à l’article 7. 

                - adopter une loi contre le racisme et toute discrimination raciale", @"تمتيع جميع العمال المهاجرين وأفراد أسرهم الموجودين في إقليم المملكة المغربية  أو الخاضعين لولايتها، دون أي تمييز كان، بالحقوق المعترف بها في الاتفاقية، وفقاً للمادة 7. 
                -  اعتماد قانون لمناهضة العنصرية وجميع أشكال التمييز العنصري،", "", "" },
                    { 489, null, "R91P2", "ت.91.ف.2", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    Modifier l’article 473 du Code de procédure pénale de façon à porter de 12 à 18 ans l’âge auquel un délinquant mineur peut être emprisonné et à souligner que l’emprisonnement des délinquants mineurs est une mesure exceptionnelle ;", "فيما يتعلق بالأحداث، يوصي المقرر الخاص الحكومة بما يلي:  (ب) تعديل المادة 473 من قانون الإجراءات الجنائية لزيادة العمر الذي يُسمح فيه بسجن الحدث الجانح من 12 إلى 18 عاماً، والتشديد على أن سجن الأحداث الجانحين إجراء استثنائي؛", "", "" },
                    { 490, null, "R88P2", "ت.88.ف.2", "", "En cours", "", 30, 3, null, null, null, 9, 3, "Procédure spéciale", "-    Assurer, par des modifications apportées à la législation, que l’accès à un avocat choisi par le suspect lui-même soit garanti dès l’arrestation, sans surveillance policière et sans avoir à obtenir l’autorisation préalable du Procureur, y compris en cas de menace contre la sécurité et de terrorisme. Cet accès doit être accordé en application de la loi et tout fonctionnaire qui refuserait de l’accorder devrait être sanctionné", "ب) التأكد، بواسطة تعديل التشريعات، من أن توكيل المحامين من اختيار المشتبه فيهم مكفول منذ اللحظة الأولى من إلقاء القبض، دون حضور محقق ودون اشتراط إذن من المدعي العام، بما في ذلك قضايا تهديد الأمن القومي والإرهاب. وينبغي منح ذلك الحق قانوناً، وتأديب كل موظف يحول دون ذلك؛", "", "" },
                    { 531, null, "R80P2", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 4, "Procédure spéciale", "-    Accélérer l’adoption des modifications à apporter au Code pénal, puis à promulguer et à appliquer des textes législatifs spécifiques contre la traite, dans un délai déterminé", "null", "", "" },
                    { 97, null, "R14P1P3", "ت.14.ف.1.ف.3", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", @"a) Abroger ou modifier toutes les dispositions discriminatoires envers les femmes afin de donner plein effet au principe d’égalité consacré par la Constitution ;
                 c) Réviser les dispositions légales permettant de déroger à l’âge minimum du mariage.", @"(أ) إلغاء أو تعديل جميع الأحكام التي تنطوي على تمييز في حق المرأة من أجل إعمال مبدأ المساواة الذي يكرسه الدستور إعمالاً تاماً؛ 

                - (ج) وتنقيح الأحكام القانونية التي تجيز الاستثناءات من الحد الأدنى لسن الزواج.", "", "" },
                    { 98, null, "R16P1", "ت.16.ف.1", "", "Réalisé", "", 100, 3, null, 3, null, 10, null, "Organes de traités", "a) Amender rapidement la législation nationale en vue de garantir la protection adéquate des femmes contre la violence et le harcèlement sexuel ;", "-           (أ) التسريع بتعديل التشريعات الوطنية لتوفير الحماية المناسبة للنساء من العنف والتحرش الجنسي؛", "", "" },
                    { 99, null, "R18P1P2", "ت.18.ف.1.ف2", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", @"réviser les dispositions du Code pénal relatives au terrorisme et définir les infractions liées au terrorisme en fonction de leur objet mais aussi définir la nature de ces actes avec suffisamment de précision 
                - veiller à ce que cette législation n’impose pas de restriction injustifiée à l’exercice des droits consacrés par le Pacte", @"مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب، وتحديد الجرائم المتصلة بالإرهاب من حيث موضوعها، وأيضاً تحديد طبيعة هذه الأعمال بما يكفي من الدقة، 
                - التأكد من أن ذلك التشريع لا يفرض قيوداً لا مبرر لها على ممارسة الحقوق التي يكرسها العهد.", "", "" },
                    { 100, null, "R22P1", "ت.22.ف.1", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", "Accélérer la révision de la législation afin d’introduire d’autres exceptions à l’interdiction de l’avortement, notamment lorsque la grossesse résulte d’un viol ou d’un inceste ou lorsque le fœtus présente des malformations mortelles, et veiller à ce que les femmes ne soient pas conduites, du fait de restrictions dans la 9, à recourir à des avortements clandestins qui mettent en danger leur vie et leur santé.", "-          تسريع تنقيح التشريعات  من أجل إدراج استثناءات إضافية من حظر الإجهاض، ومن جملتها عندما يكون الحمل نتيجة اغتصاب أو سفاح أو عندما يعاني الجنين من تشوهات فتاكة، وأن تحرص على ألا تُضطر النساء، بسبب القيود التي تنص عليها التشريعات، إلى اللجوء إلى الإجهاض السري الذي يعرض حياتهن وصحتهن للخطر.", "", "" },
                    { 101, null, "R32", "ت.32", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", "Réviser la législation pour faire en sorte que l’emprisonnement ne soit en aucun cas utilisé comme moyen d’assurer l’exécution d’obligations contractuelles.", "تنقيح التشريعات بحيث لا يستخدم السجن وسيلةً لإنفاذ الالتزامات التعاقدية.", "", "" },
                    { 102, null, "R36P1P7", "ت.36.ف.1ف.7", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", @"a) accélérer le processus de révision du cadre juridique régissant la migration et l’asile pour le rendre conforme aux dispositions du Pacte, y compris l’adoption du projet de loi no 26-14 ;
                 f) lever les barrières juridiques à l’enregistrement des nouveau-nés et à la reconnaissance des mariages entre réfugiés et demandeurs d’asile, réviser le Code de la nationalité de 2007 pour garantir la transmission de la nationalité à tous les enfants nés au Maroc", @"(أ) تسريع عملية تنقيح الإطار القانوني الذي ينظم الهجرة واللجوء لجعله يتوافق مع أحكام العهد، بما في ذلك اعتماد مشروع القانون رقم 26-14؛ 
                - (و) إزالة الحواجز القانونية أمام تسجيل المواليد والاعتراف بالزواج بين اللاجئين وملتمسي اللجوء، وتنقيح قانون الجنسية لعام 2007 بحيث يكفل نقل الجنسية إلى جميع الأطفال المولودين في المغرب", "", "" },
                    { 103, null, "R44", "ت.44", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", "Réviser toutes les dispositions pertinentes du Code pénal pour les rendre conformes à l’article 19 du Pacte et veiller à ce que les restrictions à l’exercice de la liberté d’expression et d’association soient conformes aux prescriptions strictes du paragraphe 3 de l’article 19.", "-          تنقيح جميع أحكام القانون الجنائي المتصلة بالموضوع بحيث تتوافق مع المادة 19 من العهد، والحرص على تَوافُق القيود المفروضة على حرية التعبير وتكوين الجمعيات مع الشروط الصارمة التي تنص عليها الفقرة 3 من المادة 19.", "", "" },
                    { 138, null, "R10P1", "ت.10.ف.1", "", "En cours", "", 30, 3, null, 4, null, 10, null, "Organes de traités", "-            Prendre les mesures nécessaires pour donner effet au Pacte dans l’ordre juridique interne.", "-          اتخاذ التدابير اللازمة لتطبيق العهد في النظام القانوني الداخلي", "", "" },
                    { 139, null, "R34P1", "ت.34.ف.1", "", "En cours", "", 30, 3, null, 4, null, 10, null, "Organes de traités", "-            Réviser l’article 288 du Code pénal, conformément à l’article 8 du Pacte, et de faciliter la constitution des syndicats.", "-          تنقيح المادة 288 من القانون الجنائي وفقاً للمادة 8 من العهد، وتيسير تكوين النقابات.", "", "" },
                    { 140, null, "R40", "ت.40", "", "Non réalisé", "", 0, 3, null, 4, null, 10, null, "Organes de traités", @"Amender le projet de loi pour fixer l’âge minimum de mariage à 18 ans. 
                - Abroger l’article 20 du Code de la famille, qui permet au juge d’autoriser un mariage avant l’âge légal de 18 ans.
                - Veiller à ce que le mariage soit contracté avec le libre consentement des futurs époux.", @"تعديل مشروع القانون لتحديد الثامنة عشرة سناً دُنيا للزواج،
                -  إلغاء المادة 20 من قانون الأسرة التي تجيز للقاضي إعطاء الإذن بالزواج قبل السن القانونية المحددة، وهي سن 18 عاماً، 
                - الحرص على أن يعقد الزواج برضا الطرفين رضا لا إكراه فيه.", "", "" },
                    { 141, null, "R46P2", "ت.46.ف.2", "", "En cours", "", 30, 3, null, 4, null, 10, null, "Organes de traités", "Abroger la législation concernant l’interdiction totale de l’avortement afin d’adopter une législation compatible avec les droits de la femme et de prendre des mesures pour prévenir F49les avortements dangereux.", "-          إلغاء التشريع المتعلق بالحظر الكامل للإجهاض تمهيداً لاعتماد تشريعات تتماشى مع حقوق المرأة وباتخاذ تدابير لمنع الإجهاض غير المأمون.", "", "" },
                    { 177, null, "R10P1", "ت.10.ف1", "", "En cours", "", 30, 3, null, 5, null, 10, null, "Organes de traités", "Prendre les mesures pour mettre en harmonie la loi no 02-03 avec les dispositions de la Convention, en vue d’étendre la protection des droits consacrés dans la Convention à tous les travailleurs migrants et aux membres de leur famille dans l’État partie.", ". اتخاذ تدابير لمواءمة القانون رقم 2-3 مع أحكام الاتفاقية، بغية توسيع نطاق حماية الحقوق المكرسة في الاتفاقية ليشمل جميع العمال المهاجرين وأفراد أسرهم في الدولة الطرف.", "", "" },
                    { 178, null, "R36", "ت.36", "", "Réalisé", "", 100, 3, null, 5, null, 10, null, "Organes de traités", @"Se conformer, dans le projet de loi sur les travailleurs domestiques, aux dispositions de la Convention, et de prendre en compte les éléments prévus dans l’observation générale no 1 (2010) du Comité sur les travailleurs domestiques migrants, à savoir :
                a) Des inspections du travail pour surveiller les conditions de travail des travailleurs domestiques migrants ;
                b) L’imposition de sanctions et autres pénalités aux employeurs qui exploitent des travailleurs domestiques migrants ou qui les soumettent au travail forcé et leur infligent des sévices, en particulier dans le cadre de l’économie informelle ;
                c) L’accès à des mécanismes efficaces pour porter plainte contre les employeurs et obtenir que ceux qui sont responsables de pratiques abusives soient poursuivis et sanctionnés.", @"الامتثال لأحكام الاتفاقية في مشروع القانون المتعلق بالعمال المنزليين والأخذ بعين الاعتبار العناصر المنصوص عليها في تعليق اللجنة العام رقم 1(2010) بشأن العمال المنزليين المهاجرين، وعلى وجه التحديد العناصر التالية:
                 (أ) إجراء عمليات تفتيش العمل لمراقبة ظروف عمل العمال المنزليين المهاجرين؛
                (ب) فرض عقوبات وجزاءات أخرى على أصحاب العمل الذين يستغلون العمال المنزليين المهاجرين أو الذين يُخضعونهم للعمل الجبري ويسيئون معاملتهم، لا سيما في إطار الاقتصاد غير المنظَّم؛
                (ج) إتاحة الوصول إلى آليات فعالة لتقديم شكاوى ضد أصحاب العمل وكفالة مقاضاة المسؤولين عن الممارسات المؤذية ومعاقبتهم.", "", "" },
                    { 218, null, "R13P1P2", "ت.13.ف.1.ف.2", "", "Réalisé", "", 100, 3, null, 6, null, 10, null, "Organes de traités", @"Définir clairement le statut des conventions internationales dans son cadre législatif interne, en garantissant la primauté des instruments internationaux, dont la Convention, sur la législation nationale 
                - Veiller à ce que les dispositions de son droit interne soient conformes à ces instruments", @"تحديد مركز الاتفاقيات الدولية بوضوح ضمن الإطار القانوني المحلي، وإعطاء الأولوية للصكوك الدولية، بما فيها الاتفاقية، على التشريعات الوطنية، 
                -كفالة اتساق التشريعات الوطنية مع الصكوك الدولية.", "", "" },
                    { 219, null, "R37", "ت.37", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", "Modifier le Code de la famille afin d’interdire la polygamie, institution qui contrevient au droit des femmes à l’égalité avec les hommes. Il exhorte en outre l’État partie à éliminer du Code toute autre trace de discrimination à l’égard des femmes.", @"في ضوء توصيتها العامة 21، تحث اللجنة الدولة الطرف على تعديل مدونة الأسرة بها لحظر تعدد الزوجات، حيث أنه يتناقض مع حق المرأة في المساواة مع الرجل. 
                -تحث الدولة الطرف على القضاء على أي تمييز آخر ضد النساء مما قد يكون باقيا في تلك المدونة.", "", "" },
                    { 220, null, "R39", "ت.39", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", @"Assurer l’égalité entre les hommes et les femmes dans le mariage et en cas de dissolution du mariage, en donnant aux femmes des droits égaux dans le mariage et dans les relations familiales. 
                - Modifier sans délai toutes les dispositions du Code de la famille discriminatoires à l’égard des femmes, notamment celles portant sur le divorce, la garde et la tutelle des enfants et la succession. 
                - Promulguer des dispositions législatives pour faire en sorte qu’en cas de dissolution du mariage, les femmes aient des droits égaux sur les biens acquis pendant le mariage, conformément à l’alinéa h) du paragraphe 1 de l’article 16 de la Convention et à la recommandation générale 21 du Comité.
                - Opérer ces modifications en consultation avec des organisations féminines", @"كفالة المساواة بين المرأة والرجل خلال الزواج وبعد فسخه من خلال كفالة المساواة بينهما خلال الزواج وفي العلاقات الأسرية. 
                -تعديل جميع ما تبقى من أحكام تمييزية، بما في ذلك الأحكام المتصلة بالطلاق وحضانة الأطفال والوصاية القانونية عليهم والميراث. 
                - وضع نصوص قانونية تكفل أن يكون للمرأة، بعد فسخ الزواج، نفس الحقوق التي يتمتع بها الرجل بالنسبة للممتلكات التي تمت حيازتها خلال الزواج، تمشيا مع الفقرة 1 (ح) من المادة 16 من الاتفاقية والتوصية العامة رقم 21 للجنة. وتشجــع اللجنة الدولة الطرف على إجراء تلك التعــديلات بالتشاور مع المنظمات النسائية.", "", "" },
                    { 221, null, "R41", "ت.41", "", "Non réalisé", "", 0, 3, null, 6, null, 10, null, "Organes de traités", "Modifier sans délai toute disposition du Code de la nationalité portant atteinte aux droits des femmes afin de l’harmoniser avec la Convention et s’acquitter de cette tâche en consultation avec des organisations féminines.", "-القيام دون إبطاء بتعديل جميع النصوص التمييزية التي تؤثر على حقوق المرأة، والواردة في مدونة الجنسية، لمواءمتها مع الاتفاقية على نحو تام. وتحــث اللجنة الدولة الطرف على القيـام بتلك المهمة بالتشاور مع المنظمات النسائيـة.", "", "" },
                    { 222, null, "R45P2", "ت.45.ف.2", "", "En cours", "", 30, 3, null, 6, null, 10, null, "Organes de traités", "Adopter une législation nationale relative aux réfugiés qui soit conforme à la Convention relative au statut des réfugiés et à son Protocole.", "اعتماد تشريع وطني للاجئين، امتثالا للاتفاقية المتعلقة بمركز اللاجئين والبروتوكول الملحق بها.", "", "" },
                    { 265, null, "R51P1", "ت.51.ف.1", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "a) modifier la législation régissant le système de la kafalah en vue de la rendre pleinement conforme à la Convention", "-          (أ) تعديل التشريعات التي تحكم نظام الكفالة بحيث تتقيد كلياً بالاتفاقية؛", "", "" },
                    { 266, null, "R69P1", "ت.69.ف.1", "", "Réalisé", "", 100, 3, null, 7, null, 10, null, "Organes de traités", "Adopter la législation contre la traite et faire en sorte qu’elle soit pleinement adaptée aux spécificités de la traite des enfants", "-          اعتماد تشريعات عن الاتجار وضمان أنها تعالج خصوصيات الاتجار بالأطفال وتتصدى لها. وينبغي للدولة الطرف أن تتخذ أيضاً تدابير حازمة لوضع حد لإفلات المتجرين بالأطفال من العقاب.", "", "" },
                    { 267, null, "R25P1P2", "ت.25.ف.1.ف.2", "", "Réalisé", "", 100, 3, null, 7, null, 10, null, "Organes de traités", @"a) prendre sans délai des mesures pour modifier le paragraphe 7 de l’article 16 de la loi n° 37-99 et de retirer des documents d’identité toute mention qui permettrait d’identifier des enfants comme nés hors mariage;
                b) abroger toutes les dispositions qui sont discriminatoires à l’égard des filles et des enfants nés hors mariage, en particulier dans le Code de la famille;", @"(أ) التعجيل بتعديل الفقرة 7 من المادة 16 من القانون رقم 37-99، وحذف أي إشارة في وثائق الهوية تؤدي إلى تحديد هوية الأطفال على أنهم وُلِدوا خارج إطار الزواج؛ 
                - (ب) إلغاء جميع الأحكام القانونية، ولا سيما تلك الواردة في مدونة الأسرة التي تنطوي على تمييز في حق الفتيات والفتيان المولودين خارج إطار الزواج؛", "", "" },
                    { 268, null, "R45", "ت.45", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", @"Revoir la loi provisoire sur le statut personnel pour faire en sorte que toutes ses dispositions qui sont discriminatoires à l’égard des femmes et des filles et qui nuisent à leurs enfants, telles que celles qui autorisent la polygamie, soient abrogées. 
                - Eliminer toute forme de discrimination à l’égard des enfants nés d’un mariage entre une musulmane et un non-musulman conformément à sa Constitution.", "تنقيح مدونة الأحوال الشخصية المؤقتة وضمان إلغاء جميع الأحكام التي تنطوي على تمييز في حق النساء والفتيات وتؤثر سلباً في أطفالهن، كتلك التي تجيز تعدد الزوجات. وتحثها أيضاً على القضاء على كل أشكال التمييز في حق الأطفال المولودين من زواج بين مسلمة وغير مسلم، عملاً بالدستور", "", "" },
                    { 269, null, "R47P1", "ت.47.ف.1", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", "Abroger l’article 490 du Code pénal de façon à assurer aux mères célibataires le soutien dont elles ont besoin pour s’occuper de leurs enfants,", "إلغاء المادة 490 من القانون الجنائي،  وتقديم الدعم اللازم للأمهات غير المتزوجات لإقدارهن على رعاية أطفالهن", "", "" },
                    { 270, null, "R57P2", "ت.57.ف.2", "", "Non réalisé", "", 0, 3, null, 7, null, 10, null, "Organes de traités", @"Renvoyant à son Observation générale no 4 (2003) sur la santé et le développement de l’adolescent, le Comité demande instamment au Maroc:
                b)       De dépénaliser l’avortement et de revoir sa législation en vue de garantir l’intérêt supérieur des adolescentes enceintes, et de faire en sorte que, par la loi et dans la pratique, les opinions de l’enfant soient toujours entendues et respectées dans les décisions relatives à l’avortement;", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                - (ب) رفع الصفة الجرمية عن الإجهاض ومراجعة تشريعاتها بحيث تكفل المصالح الفضلى للمراهقات الحوامل، واتخاذ الإجراءات القانونية والعملية لضمان الاستماع إلى آراء الطفل واحترامها دائماً عندما يتعلق الأمر بقرارات الإجهاض", "", "" },
                    { 271, null, "R75P1P2P3", "ت.75.ف.1.ف.2.ف.3", "", "En cours", "", 30, 3, null, 7, null, 10, null, "Organes de traités", @"Mettre le système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs, en particulier:
                a) Veiller à ce que la détention, notamment la détention avant jugement, soit une mesure de dernier recours appliquée pour la période la plus courte possible, même en cas d’infraction très grave et qu’elle fasse l’objet d’un réexamen régulier en vue de sa levée;
                b) Faire en sorte que les enfants en conflit avec la loi bénéficient d’une aide juridictionnelle compétente et indépendante dès le début de la procédure, y compris en cas de flagrant délit;
                C)  Promouvoir des mesures de substitution à la détention telles que la déjudiciarisation, la probation, la médiation, l’accompagnement psychologique et les travaux d’intérêt général, chaque fois que cela est possible;", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                - (أ) ضمان عدم اللجوء إلى الاحتجاز، بما فيه الاحتجاز السابق للمحاكمة، إلا عند الضرورة القصوى ولأقصر مدة ممكنة، حتى عن الجرائم الخطرة جداً، وإعادة النظر فيه بانتظام للتخلي عنه؛
                - (ب) ضمان تقديم مساعدة قانونية مؤهلة ومستقلة للأطفال الجانحين في مرحلة مبكرة من الدعوى وطوال الإجراءات القانونية، حتى في حالات التلبس بالجريمة؛
                - (ج) تشجيع التدابير البديلة للاحتجاز ما أمكن، مثل عدم اللجوء إلى القضاء أو الإفراج تحت المراقبة أو الوساطة أو التوجيه أو الخدمة المجتمعية؛", "", "" },
                    { 325, null, "R7", "ت.7", "", "En cours", "", 30, 3, null, 8, null, 10, null, "Organes de traités", "Harmoniser et actualiser les définitions du handicap énoncées dans ses diverses lois et politiques et de les rendre conformes à l’approche axée sur les droits de l’homme consacrée par la Convention.", "-      مواءمة وتحديث تعريف الإعاقة في مختلف القوانين والسياسات وجعلها تتماشى مع نموذج حقوق الإنسان في تناول مسألة الإعاقة المنصوص عليه في الاتفاقية.", "", "" },
                    { 326, null, "R9P1", "ت.9.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Réviser la loi-cadre n° 97-13 pour la rendre conforme à la Convention……… Préciser le délai d’entrée en vigueur de cette loi", "-       (أ) تنقيح القانون الإطار 97-13 لجعله يتماشى مع الاتفاقية ......ء، وتحديد الإطار الزمني لدخول القانون حيز النفاذ؛", "", "" },
                    { 96, null, "R6P2", "ت.6.ف.2", "", "En cours", "", 30, 3, null, 3, null, 10, null, "Organes de traités", "Accélérer la réforme législative visant à garantir la pleine conformité du droit interne avec les traités internationaux dûment ratifiés", "تسريع الإصلاح التشريعي الذي يهدف إلى جعل القانون المحلي يتوافق كلياً مع المعاهدات الدولية التي صدقت عليها وفق الأصول؛", "", "" },
                    { 59, null, "R29P3", "ت.29.ف.3", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", "Inclure dans la législation des dispositions sur le droit des personnes victimes de torture d’être indemnisées de manière équitable et adéquate du préjudice ainsi subi.", "إدراج أحكاماً بشأن حق ضحايا التعذيب في الحصول على تعويض منصف ومناسب عن الضرر الذي لحق بهم في التشريعات الوطنية.", "", "" },
                    { 58, null, "R24P1", "ت.24.ف1", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation afin d’interdire le recours aux châtiments corporels dans l’éducation des enfants, tant au sein de la famille que dans les centres de protection de l’enfance.", "-          تعديل التشريعات بهدف منع اللجوء إلى العقاب البدني في سياق تربية الأطفال سواء داخل الأسرة أو داخل مراكز حماية الطفل.", "", "" },
                    { 57, null, "R18P4", "ت.18.ف.4", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation afin d’octroyer également aux organisations non gouvernementales la possibilité d’effectuer des visites régulières, indépendantes, inopinées et illimitées dans les lieux de détention.", "تعديل التشريعات لتتيح أيضاً للمنظمات غير الحكومية إمكانية إجراء زيارات منتظمة ومستقلة ومفاجئة وغير محدودة لأماكن الاحتجاز.", "", "" },
                    { 532, null, "R87", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 4, "Procédure spéciale", "-    Tout projet de modification ou de loi relative à la traite des êtres humains devrait être axé sur une approche fondée sur les droits de l’homme et comporter des dispositions relatives à l’indemnisation des victimes et aux recours effectifs dont celles-ci disposent.", "null", "", "" },
                    { 533, null, "R80P3/R88P1", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 4, "Procédure spéciale", "-    Le champ d’application de la législation du travail devrait être élargi de sorte que les employés de maison bénéficient d’une protection suffisante.", "null", "", "" },
                    { 534, null, "R92", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 4, "Procédure spéciale", @"Une réforme pénale devrait être entreprise et des systèmes de protection des victimes et des témoins devraient être institués. 
                - Parallèlement à la réforme pénale, des modifications devraient être apportées au Code pénal et un cadre juridique plus vaste devrait être établi, qui exempte les victimes de la traite des peines encourues pour prostitution, pour immigration illégale et pour d’autres infractions connexes résultant directement de la traite", "null", "", "" },
                    { 560, null, "R89P4P5", "null", "", "En cours", "", 30, 3, null, null, null, 9, 5, "Procédure spéciale", @"Combler les lacunes dans la protection juridique des droits des femmes et des groupes qui ont besoin d’une protection particulière, notamment les travailleurs domestiques et les travailleurs migrants, et faire en sorte que les groupes de femmes vulnérables bénéficient de l’égale protection de la loi. 
                - Les projets de loi sur la violence à l’égard des femmes et la violence au foyer devraient être réexaminés à la lumière des observations finales du Comité contre la torture. Le Code pénal, qui est en cours de modification, devrait être revu dans le sens du respect des principes et des normes internationaux et adopté. Ses articles 475 et 490 devraient être abrogés
                - Entamer un examen complet de l’application de toutes les lois et dispositions préjudiciables aux femmes et aux filles, y compris, entre autres, le Code de la famille, le Code de la nationalité, le Code pénal et le Code du travail. Cet examen devrait se faire avec la participation active des organisations de la société civile, notamment celles qui ont suivi les décisions des tribunaux dans des affaires relatives au mariage précoce et à la polygamie ;", "null", "", "" },
                    { 561, null, "R91P1", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 5, "Procédure spéciale", "Accélérer l’élaboration des lois organiques appelées à définir les conditions et les modalités d’exercice, par tous les citoyens, femmes et hommes du droit de présenter des motions en matière législative et des pétitions aux pouvoirs publics; de telles lois devraient prévoir des mesures spéciales pour renforcer l’accès effectif des femmes pauvres et marginalisées à ce droit, y compris la mobilisation de ressources pour le renforcement des capacités des groupes locaux de femmes", "null", "", "" },
                    { 562, null, "R91P2", "null", "", "En cours", "", 30, 3, null, null, null, 9, 5, "Procédure spéciale", @"Institutionnaliser, en modifiant les lois sur les élections, les mesures spéciales visant à augmenter le nombre de femmes aux postes électifs, aux niveaux national et local, de façon à satisfaire aux normes internationales ; 
                - les listes nationales dans lesquelles un nombre déterminé de sièges est réservé aux femmes devraient être conservées et les quotas augmentés. 
                - Les femmes devraient avoir la possibilité de présenter leur candidature pour une réélection sur les listes nationales. 
                - Une augmentation des quotas, qui réponde aux normes internationales, devrait être effectuée dans les élections locales", "null", "", "" },
                    { 588, null, "R83P26", "null", "", "Réalisé", "", 100, 3, null, null, null, 9, 6, "Procédure spéciale", "-       Adopter rapidement le projet de loi sur les tribunaux militaires afin de s’assurer que les civils ne soient pas condamnés par un tribunal militaire et d’examiner les jugements rendus par le tribunal militaire dans le cas des 25 personnes sahraouies du camp de Gdeim Izik.", "null", "", "" },
                    { 615, null, "R86P2-3", "ت.86.ف.2ج3", "", "Réalisé", "", 100, 3, null, null, null, 9, 7, "Procédure spéciale", "-          envisager d’adopter une nouvelle loi reconnaissant le droit de chacun de choisir librement le prénom de ses enfants dans sa propre langue;", "- التفكير أيضاً في اعتماد قانون جديد يقر حق كل شخص في اختيار اسم طفله بحرية بلغته الخاصة؛", "", "" },
                    { 1028, null, "R144.107", "107.144", "", "Non réalisé", "", 0, 3, 1, null, 40, 9, null, "Examen périodique universal", "Adopter les amendements proposés au Code de procédure pénale pour assurer le respect des garanties en détention", "اعتماد التعديلات المقترَحة لقانون المسطرة الجنائية من أجل ضمان احترام الضمانات والتدابير الوقائية أثناء الاحتجاز", "", "" },
                    { 1029, null, "R144.128", "128.44", "", "Non réalisé", "", 0, 3, 1, null, 80, 9, null, "Examen périodique universal", "Réviser le Code pénal et le Code de procédure pénale dans le cadre de la réforme en cours du secteur de la justice", "مراجعة القانون الجنائي وقانون المسطرة الجنائية كجزء من عملية الإصلاح الجارية لقطاع القضاء", "", "" },
                    { 185, null, "R18P2", "ت.18.ف2", "", "En cours", "", 30, 5, null, 5, null, 26, null, "Organes de traités", "-       Adopter les mesures pratiques pour garantir l’accès des travailleurs migrants à l’information et leur fournir une orientation sur les droits que leur reconnaît la Convention", "اعتماد تدابير عملية لضمان وصول العمال المهاجرين إلى المعلومات وإرشادهم فيما يتعلق بحقوقهم المعترف بها في الاتفاقية؛", "", "" },
                    { 1031, null, "R144.72", "72.144", "", "Réalisé", "", 100, 3, 1, null, 17, 9, null, "Examen périodique universal", "Interdire la discrimination et ériger en infraction la violence envers des personnes en raison de leur orientation sexuelle ou de leur identité de genre", "اعتماد وتطبيق قانون شامل مناهض للتمييز", "", "" },
                    { 1032, null, "R144.73", "73.144", "", "Réalisé", "", 100, 3, 1, null, 36, 9, null, "Examen périodique universal", "Mettre fin aux formes de discrimination (notamment juridiques) auxquelles se heurtent les lesbiennes, gays, bisexuels, transgenres et intersexués", "إنهاء أشكال التمييز (بما فيها الأشكال القانونية) التي يتعرض لها المثليات والمثليون ومزدوجو الميل الجنسي ومغايرو الهوية الجنسانية وحاملو صفات الجنسين", "", "" },
                    { 559, null, "R89P13", "null", "", "En cours", "", 30, 2, null, null, null, 7, 5, "Procédure spéciale", "Solliciter l’assistance technique de l’Organisation des Nations Unies en vue d’accroître la sensibilisation aux obligations internationales de l’État et d’en promouvoir le respect, notamment en ce qui concerne l’égalité et les droits fondamentaux des femmes, en s’appuyant sur l’attachement du Maroc à la coopération avec tous les organes et organismes des Nations Unies.", "null", "", "" },
                    { 1033, null, "R144.75 P1P3", "75.144. ج.1 ج.3", "", "Réalisé", "", 100, 3, 1, null, 31, 9, null, "Examen périodique universal", "Garantir les mêmes droits à tous les citoyens, y compris ceux de la communauté des lesbiennes, gays, bisexuels, transgenres et intersexué en éliminant toutes les lois discriminatoires sur la base de l’orientation sexuelle", "ضمان تمتع جميع المواطنين بالحقوق نفسها، بمن فيهم المثليات والمثليون ومزدوجو الميل الجنسي ومغايرو الهوية الجنسانية وحاملو صفات الجنسين، ..... وإلغاء جميع التشريعات التمييزية على أساس الميل الجنسي", "", "" },
                    { 1035, null, "R144.78", "78.144", "", "Non réalisé", "", 0, 3, 1, null, 1, 9, null, "Examen périodique universal", "Adopter une législation complète contre la discrimination", "اعتماد قانون شامل لمكافحة التمييز", "", "" },
                    { 1036, null, "R144.79", "79.144", "", "Réalisé", "", 100, 3, 1, null, 6, 9, null, "Examen périodique universal", "Prendre des mesures d’urgence pour révoquer les normes qui criminalisent et stigmatisent les lesbiennes, les gays, les bisexuels, les transgenres et les intersexués, et poursuivre et punir les auteurs d’actes de discrimination et de violence à leur égard", "اتخاذ تدابير عاجلة لإلغاء الأحكام التي تجرّم وتصم المثليات والمثليين ومزدوجي الميل الجنسي ومغايري الهوية الجنسانية وحاملي صفات الجنسين، والتحقيقُ مع مرتكبي أفعال التمييز والعنف في حقهم ومعاقبتُهم", "", "" },
                    { 1037, null, "R144.120", "120.144", "", "Réalisé", "", 100, 3, 1, null, 101, 9, null, "Examen périodique universal", "Créer et maintenir, en droit et dans la pratique, un environnement sûr et favorable pour la société civile et les défenseurs des droits de l’homme, y compris au Sahara occidental et en ce qui le concerne, grâce à une révision du Code pénal, et supprimer les restrictions à la liberté d’expression, revoir le système d’enregistrement des associations et de notification des réunions et veiller à une application cohérente des règles à tous les rassemblements pacifiques indépendamment de leur objet", "إنشاء بيئة آمنة وممكّنة، في القانون والممارسة، والمحافظة عليها لفائدة المجتمع المدني والمدافعين عن حقوق الإنسان حتى في الصحراء الغربية وفيما يتعلق بها عن طريق مراجعة القانون الجنائي وإزالة القيود المفروضة على حرية التعبير واستعراض نظام تسجيل الجمعيات والإشعار بالتجمعات والتطبيق المتّسق للقواعد على جميع التجمعات السلمية بصرف النظر عن موضوعها", "", "" },
                    { 1038, null, "R144.85", "85.144", "", "Réalisé", "", 100, 3, 1, null, 45, 9, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme et définir les infractions liées au terrorisme plus clairement et précisément", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب ووضعُ تعريف أوضح وأدق للجرائم المرتبطة بالإرهاب", "", "" },
                    { 1039, null, "R144.239", "239.144", "", "Réalisé", "", 100, 3, 1, null, 44, 9, null, "Examen périodique universal", "Réexaminer complètement la législation nationale sur les migrations et l’asile", "استعراض التشريعات الوطنية بشأن الهجرة واللجوء استعراضاً مفصلاً", "", "" },
                    { 17, null, "R8", "ت.8", "", "Réalisé", "", 100, 3, null, 1, null, 10, null, "Organes de traités", "Consacrer dans la constitution le principe de la primauté des traités internationaux sur la législation interne, afin de lui donner une portée générale et de permettre aux justiciables d’invoquer devant les tribunaux les dispositions pertinentes de la Convention.", "تكريس مبدأ أسبقية المعاهدات الدولية على التشريعات الداخلية في الدستور حتى تعطي لهذا المبدأ قوةً حجية عامة ويتمكن بذلك المتقاضون الاعتداد أمام المحاكم بأحكام الاتفاقية ذات الصلة بقضاياهم.", "", "" },
                    { 18, null, "R10", "ت.10", "", "Réalisé", "", 100, 3, null, 1, null, 10, null, "Organes de traités", "Inclure dans le Code pénal des dispositions donnant pleinement effet à l’article 4 de la Convention, en particulier une incrimination spécifique sur la diffusion d’idées racistes. prévoir dans sa législation pénale le motif raciste comme circonstance aggravante de la discrimination raciale.", "إدراج أحكام في القانون الجنائي تفعل المادة 4 من الاتفاقية تفعيلاً كاملاً، وبخاصة تجريم نشر الأفكار العنصرية على وجه التحديد، وذلك في إطار الإصلاح العام المقبل لنظام العدالة وفق التوصية العامة  رقم 1(1972) و7(1985) و15(1993) التي أضفت على أحكام المادة 4 طابعاً آمراً ووقائياً.إ دراج الدافع العنصري بوصفه ظرفاً مشدداً للتمييز العنصري في التشريعات الجنائية", "", "" },
                    { 19, null, "R16", "ت.16", "", "En cours", "", 30, 3, null, 1, null, 10, null, "Organes de traités", "réviser le Code de la nationalité afin de permettre à la femme marocaine de transmettre sa nationalité à son époux d’origine étrangère à égalité avec les hommes de nationalité marocaine.", "مراجعة قانون الجنسية لكي يتيح للمرأة المغربية نقل جنسيتها إلى زوجها الأجنبي من أجل المساواة في الحقوق بينها وبين الرجل الذي يحمل الجنسية المغربية.", "", "" },
                    { 52, null, "R6P2", "ت.6.ف.2", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation de façon à établir explicitement que l’ordre d’un supérieur ou d’une autorité publique ne saurait être invoqué pour justifier la torture.", "-          تعديل التشريعات لتنص صراحة على عدم جواز الاعتداد بأمر موظف أعلى رتبة أو سلطة عمومية لتبرير التعذيب.", "", "" },
                    { 53, null, "R8P1P2", "ت.8.ف.1.ف.2", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", @"Revoir la loi antiterroriste n° 03-03 afin de mieux définir le terrorisme, de réduire la durée maximale de la garde à vue au strict minimum et de permettre l’accès à un avocat dès le début de la détention. 
                - Le Comité rappelle qu’en vertu de la Convention contre la torture, aucune circonstance exceptionnelle quelle qu’elle soit ne saurait être invoquée pour justifier la torture", @"مراجعة القانون المتعلق بمكافحة الإرهاب 03-03 لتعريف الإرهاب بشكل أدق وتقليص المدة القصوى للحبس الاحتياطي إلى أدنى حد ممكن وإتاحة الوصول إلى محام فور بداية الاحتجاز. 
                - تذكّر اللجنة أنه لا يجوز بموجب معاهدة مناهضة التعذيب الاعتداد بأي ظروف استثنائية أياً كانت لتبرير التعذيب", "", "" },
                    { 54, null, "R13P1", "ت.13.ف.1", "", "Réalisé", "", 100, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation afin de garantir à toutes les personnes civiles d’être jugées exclusivement par des juridictions civiles.", "تعديل التشريعات لكي تضمن محاكمة جميع المدنيين أمام المحاكم المدنية دون غيرها.", "", "" },
                    { 55, null, "R16P2", "ت.16.ف.2", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation de sorte que celle-ci stipule explicitement que l’ordre d’un supérieur ou d’une autorité publique ne saurait être invoqué pour justifier la torture.", "-           تعديل التشريعات لتكرس صراحة عدم جواز الاعتداد بأمر موظف أعلى رتبة أو سلطة عمومية لتبرير التعذيب.", "", "" },
                    { 56, null, "R19P2", "ت.19.ف.2", "", "En cours", "", 30, 3, null, 2, null, 10, null, "Organes de traités", "Modifier la législation pour permettre le recours aux mesures de substitution à la mise en détention préventive, conformément aux Règles minima des Nations Unies pour l’élaboration de mesures non privatives de liberté (Règles de Tokyo). À cet effet, il pourrait développer un système de cautionnement et de recours plus fréquent aux peines non privatives de liberté pour les infractions les moins graves.", "تعديل التشريعات لتتيح اللجوء إلى تدابير بديلة عن الاحتجاز الوقائي وفقاً لقواعد الأمم المتحدة النموذجية الدنيا للتدابير غير الاحتجازية (قواعد طوكيو) والنظر في إمكانية تطوير نظام للكفالة، وزيادة اللجوء إلى عقوبات غير سالبة للحرية فيما يتعلق بالمخالفات الأقل خطورة. ، وذلك ومكافحة اكتظاظ السجون", "", "" },
                    { 1034, null, "R144.76", "76.144", "", "Réalisé", "", 100, 3, 1, null, 45, 9, null, "Examen périodique universal", "Adopter et appliquer une législation complète contre la discrimination qui contienne une interdiction générale de toutes formes de discrimination directe et indirecte", "تطبيق واعتماد قانون شامل لمكافحة التمييز يتضمن حظراً عاماً لجميع أشكال التمييز المباشرة منها وغير المباشرة", "", "" },
                    { 327, null, "R15 P3", "ت.15.ف.3", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "c) Réviser le projet de loi no 103-13 relatif à la lutte contre la violence à l’égard des femmes de sorte qu’il tienne compte de la question du handicap, des risques particuliers de violence sexiste auxquels sont exposées les femmes et les filles handicapées, en particulier les femmes qui présentent un handicap psychosocial ou intellectuel, et des obstacles à la protection de ces femmes contre la violence sexiste ;", "-       (ج) تنقيح مشروع القانون 103-13 المتعلق بمحاربة العنف ضد النساء، بهدف تضمينه منظور الإعاقة ومعالجة المخاطر المحددة التي ينطوي عليها العنف الجنساني والحواجز التي تحول دون حماية النساء والفتيات ذوات الإعاقة، ولا سيما النساء ذوات الإعاقة النفسية - الاجتماعية و/أو العقلية؛", "", "" },
                    { 530, null, "R97", "null", "", "En cours", "", 30, 2, null, null, null, 7, 4, "Procédure spéciale", @"collaborer avec les organisations internationales et bilatérales aux fins de l’hébergement et de l’indemnisation des victimes de la traite. 
                Envisager la possibilité d’utiliser les revenus issus du blanchiment d’argent ou les avoirs confisqués aux trafiquants comme ressources complémentaires pour financer l’aide aux victimes", "null", "", "" },
                    { 479, null, "R97P3", "ت.97.ف.3", "", "Réalisé", "", 100, 2, null, null, null, 7, 3, "Procédure spéciale", @"En ce qui concerne les provinces marocaines du Sud 
                - c) Trouver des moyens pour renforcer encore plus la protection des droits de l’homme internationalement reconnus, notamment en adressant des invitations aux titulaires de mandat au titre des procédures spéciales de l’Organisation des Nations Unies, en renforçant la coopération avec la société civile et l’institution nationale des droits de l’homme et en facilitant la présence d’organisations non gouvernementales régionales", @"فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:
                - (ج) استحداث جميع الوسائل الممكنة لتعزيز حماية حقوق الإنسان المعترف بها دولياً بسبل منها دعوة آليات الإجراءات الخاصة التابعة للأمم المتحدة؛ وتدعيم التعاون مع المجتمع المدني والمؤسسة الوطنية لحقوق الإنسان؛ وتسهيل حضور المنظمات غير الحكومية الدولية؛", "", "" },
                    { 89, null, "R20P2", "ت.20.ف.2", "", "Non réalisé", "", 0, 2, null, 3, null, 5, null, "Organes de traités", "- Envisager d’adhérer au deuxième Protocole facultatif se rapportant au Pacte, visant à abolir la peine de mort.", "النظر في إمكانية الانضمام إلى البروتوكول الاختياري الثاني الملحق بالعهد، الهادف إلى إلغاء عقوبة الإعدام.", "", "" },
                    { 90, null, "R36 P8", "ت.36.ف.8", "", "En cours", "", 30, 2, null, 3, null, 5, null, "Organes de traités", "-Envisager la ratification des Conventions de 1954 et 1961 relatives à l’apatridie", "-          (و)  النظر في التصديق على اتفاقيتي عام 1954 و1961 المتعلقتين بانعدام الجنسية، ...", "", "" },
                    { 125, null, "R51", "ت.51", "", "Non réalisé", "", 0, 2, null, 4, null, 5, null, "Organes de traités", "-            Ratifier Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels le plus tôt possible.", "تشجع اللجنة المملكة المغربية على التصديق على البروتوكول الاختياري الملحق بالعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية في أقرب وقت ممكن.", "", "" },
                    { 165, null, "R14", "ت.14", "", "En cours", "", 30, 2, null, 5, null, 5, null, "Organes de traités", "Poursuivre les actions allant dans le sens de la ratification des Conventions nos 97, 143 et 189 de l’OIT.", "مواصلة الإجراءات الرامية إلى التصديق على اتفاقيات منظمة العمل الدولية رقم 97 و143 و189", "", "" },
                    { 166, null, "R12", "ت.12", "", "En cours", "", 30, 2, null, 5, null, 5, null, "Organes de traités", "Poursuivre les actions pour faire les déclarations prévues aux articles 76 et 77 de la Convention.", "مواصلة الإجراءات الرامية إلى تقديم الإعلانين المنصوص عليهما في المادتين 76 و77 من الاتفاقية.", "", "" },
                    { 200, null, "R15", "ت.15", "", "En cours", "", 30, 2, null, 6, null, 5, null, "Organes de traités", @"Notifier, dans les meilleurs délais, au Secrétaire général, en sa qualité de dépositaire de la Convention, la levée des réserves et déclarations
                - continuer de prendre les mesures voulues pour lever toutes ses déclarations et réserves au sujet des articles 2 et 16 de la Convention, qui sont contraires à l’objet et au but de la Convention,  afin que les marocaines puissent se prévaloir de toutes les dispositions de la Convention", @"إشعار الأمين العام للأمم المتحدة، بصفته وديع الاتفاقية، بسحب التحفظات والتصريحات على الاتفاقية في أقرب وقت ممكن.
                - مواصلة اتخاذ الخطوات الضرورية لسحب كل ما تبقى من تصريحات وتحفظات على المادتين 2 و 16 من الاتفاقية، لأنها من وجهة نظر اللجنة تتعارض مع موضوع الاتفاقية وهدفها، وذلك من أجل أن تستفيد المرأة المغربية من جميع أحكام الاتفاقية", "", "" },
                    { 201, null, "R23P2", "ت.23.ف.2", "", "Réalisé", "", 100, 2, null, 6, null, 5, null, "Organes de traités", "Ratifier le Protocole additionnel à la Convention des Nations Unies contre la criminalité transnationale organisée visant à prévenir, réprimer et punir la traite des personnes, en particulier des femmes et des enfants…...", "التصديق على بروتوكول منع وقمع ومعاقبة الاتجار بالأشخاص، وبخاصة النساء والأطفال، المكمل لاتفاقية الأمم المتحدة لمكافحة الجريمة المنظمة العابرة للحدود الوطنية،", "", "" },
                    { 202, null, "R47", "ت.47", "", "Réalisé", "", 100, 2, null, 6, null, 5, null, "Organes de traités", "Signer et ratifier le Protocole facultatif relatif à la Convention et accepter la modification du paragraphe 1 de l’article 20 de la Convention relatif à la durée des réunions du Comité.", "التوقيع على البروتوكول الاختياري للاتفاقية والتصديق عليه، وقبول التعديل الذي أدخل على الفقرة 1 من المادة 20 من الاتفاقية، والمتعلق بمواعيد اجتماعات اللجنة.", "", "" },
                    { 203, null, "R51", "ت.51", "", "Réalisé", "", 100, 2, null, 6, null, 5, null, "Organes de traités", "Envisager de ratifier les instruments auxquels le Maroc n’est pas encore partie, à savoir la Convention internationale pour la protection de toutes les personnes contre les disparitions forcées et la Convention relative aux droits des personnes handicapées.", "النظر في التصديق على المعاهدات التي لم تصبح بعد طرفاً فيها، وهما الاتفاقية الدولية لحماية جميع الأشخاص من الاختفاء القسري واتفاقية حقوق الأشخاص ذوي الإعاقة.", "", "" },
                    { 245, null, "R9", "ت.9", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "le Comité encourage le Maroc à retirer la déclaration interprétative concernant le paragraphe 1 de l’article 14 de la Convention.", "تشجع اللجنة المملكة المغربية على سحب الإعلان التفسيري بشأن الفقرة 1 من المادة 14 من الاتفاقية، تماشياً مع توصياتها السابقة (الوثيقة CRC/C/15/Add.211  لعام 2003، الفقرة 8)، وفي ضوء إعلان وبرنامج عمل فيينا لعام 1993.", "", "" },
                    { 246, null, "R31P4", "ت.31.ف.4", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "Songer à ratifier la Convention de 1961 sur la réduction des cas d’apatridie.", "(د) النظر في التصديق على اتفاقية تخفيض حالات انعدام الجنسية  لعام 1961.", "", "" },
                    { 247, null, "R65 P4", "ت.65.ف.4", "", "Non réalisé", "", 0, 2, null, 7, null, 5, null, "Organes de traités", "Songer à ratifier la Convention no 189 (2011) de l’Organisation internationale du Travail (OIT), sur les travailleuses et travailleurs domestiques ;", "-           (د) النظر في التصديق على اتفاقية منظمة العمل الدولية رقم 189 بشأن العمل اللائق للعمال المنزليين", "", "" },
                    { 248, null, "R76", "ت.76", "", "En cours", "", 30, 2, null, 7, null, 5, null, "Organes de traités", "Ratifier les principaux instruments relatifs aux droits de l’homme auxquels le Maroc n’est pas encore partie, à savoir le Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications ainsi que les protocoles facultatifs à d’autres instruments de l’ONU relatifs aux droits de l’homme.", "-          التصديق على الصكوك الأساسية لحقوق الإنسان التي لا تعد المملكة المغربية طرفاً فيها بعد، أي البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء تقديم البلاغات، إضافة إلى البروتوكولات الاختيارية لصكوك الأمم المتحدة الأخرى في مجال حقوق الإنسان، وذلك لمواصلة الارتقاء بمستوى إعمال حقوق الطفل.", "", "" },
                    { 315, null, "R57", "ت.57", "", "En cours", "", 30, 2, null, 8, null, 5, null, "Organes de traités", "-                    mener rapidement à terme le processus de ratification du Traité de Marrakech visant à faciliter l’accès des aveugles, des déficients visuels et des personnes ayant d’autres difficultés de lecture des textes imprimés aux œuvres publiées", "تسريع الإجراءات لاستكمال عملية التصديق على معاهدة مراكش لتيسير النفاذ إلى المصنفات المنشورة لفائدة الأشخاص المكفوفين أو معاقي البصر أو ذوي إعاقات أخرى في قراءة المطبوعات.", "", "" },
                    { 400, null, "R65", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 1, "Procédure spéciale", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels", "null", "", "" },
                    { 477, null, "R88P14-1", "ت.88.ف.14ج1", "", "Réalisé", "", 100, 2, null, null, null, 5, 3, "Procédure spéciale", "-    prendre des mesures concrètes pour accélérer la ratification du Protocole facultatif à la Convention contre la torture", "-          (ن) اتخاذ تدابير ملموسة لتسريع عملية التصديق على البروتوكول الاختياري الملحق باتفاقية مناهضة التعذيب.....", "", "" },
                    { 528, null, "R96P2", "null", "", "En cours", "", 30, 2, null, null, null, 5, 4, "Procédure spéciale", "-    Envisager de ratifier la Convention no 189 de l’OIT sur les travailleuses et travailleurs domestiques.", "null", "", "" },
                    { 557, null, "R89P2", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 5, "Procédure spéciale", "Retirer toutes les déclarations restantes au sujet de la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes, en particulier celles concernant l’article 2 et le paragraphe 4 de l’article 15, ainsi que la réserve à cet instrument", "null", "", "" },
                    { 558, null, "R89P3", "null", "", "En cours", "", 30, 2, null, null, null, 5, 5, "Procédure spéciale", "Signer et ratifier le Protocole facultatif à la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes ou y adhérer, et ratifier la Convention pour la protection de toutes les personnes contre les disparitions forcées", "null", "", "" },
                    { 586, null, "R83P14P1", "null", "", "Réalisé", "", 100, 2, null, null, null, 5, 6, "Procédure spéciale", "-       Prendre des mesures concrètes et durables pour parachever le processus de ratification du Protocole facultatif à la Convention contre la torture", "null", "", "" },
                    { 613, null, "R91", "ت.91", "", "Non réalisé", "", 0, 2, null, null, null, 5, 7, "Procédure spéciale", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels.", "-       التصديق على البروتوكول الاختياري للعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية.", "", "" },
                    { 637, null, "R73P8-1", "null", "", "Non réalisé", "", 0, 2, null, null, null, 5, 8, "Procédure spéciale", "Envisager de ratifier les Protocoles facultatifs se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels et au Pacte international relatif aux droits civils et politiques", "null", "", "" },
                    { 1012, null, "R144.1", "1.144", "", "Non réalisé", "", 0, 2, 1, null, null, 5, null, "Examen périodique universal", "Ratifier le premier Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques et adhérer au premier Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "التصديق على البروتوكول الاختياري الأول الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية والانضمام إلى البروتوكول الاختياري الأول الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 1013, null, "R144.4", "4.144", "", "Réalisé", "", 100, 2, 1, null, 65, 5, null, "Examen périodique universal", "Envisager de ratifier le deuxième Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques", "النظر في التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 1014, null, "R144.6", "6.144", "", "Non réalisé", "", 0, 2, 1, null, 73, 5, null, "Examen périodique universal", "Ratifier le Protocole facultatif se rapportant au Pacte international relatif aux droits économiques, sociaux et culturels", "التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية", "", "" },
                    { 1015, null, "R144.7", "7.144", "", "Réalisé", "", 100, 2, 1, null, 49, 5, null, "Examen périodique universal", "Signer et ratifier le Protocole facultatif à la Convention sur l’élimination de toutes les formes de discrimination à l’égard des femmes", "التوقيع والتصديق على البروتوكول الاختياري الثاني الملحق باتفاقية القضاء على جميع أشكال التمييز ضد المرأة ؛", "", "" },
                    { 1016, null, "R144.9", "9.144", "", "Non réalisé", "", 0, 2, 1, null, null, 5, null, "Examen périodique universal", "Ratifier le Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications", "التصديق على البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء البلاغات", "", "" },
                    { 88, null, "R6P3", "ت.6.ف.3", "", "Non réalisé", "", 0, 2, null, 3, null, 5, null, "Organes de traités", "Mener à terme, dans les meilleurs délais, le processus d’adhésion au premier Protocole facultatif se rapportant au Pacte, qui prévoit l’examen de communications individuelles.", "-          إنهاء عملية الانضمام إلى البروتوكول الاختياري الأول الملحق بالعهد، الذي ينص على النظر في البلاغات الفردية، في أقرب وقت ممكن.", "", "" },
                    { 1017, null, "R144.10", "10.144", "", "Non réalisé", "", 0, 2, 1, null, 38, 5, null, "Examen périodique universal", "Accélérer la procédure de ratification du Protocole facultatif à la Convention relative aux droits de l’enfant établissant une procédure de présentation de communications", "تسريع عملية التصديق على البروتوكول الاختياري لاتفاقية حقوق الطفل المتعلق بإجراء تقديم البلاغات", "", "" },
                    { 36, null, "R31P2", "ت.31.ف.2", "", "Non réalisé", "", 0, 2, null, 2, null, 5, null, "Organes de traités", "envisager d’adhérer au Statut de Rome de la Cour pénale internationale.", "النظر في الانضمام إلى ونظام روما الأساسي للمحكمة الجنائية الدولية.", "", "" },
                    { 34, null, "R25P3", "ت.25.ف.3", "", "En cours", "", 30, 2, null, 2, null, 5, null, "Organes de traités", "Envisager d’adhérer à la Convention relative au statut des apatrides (1954) et à la Convention sur la réduction des cas d’apatridie (1966).", "النظر في الانضمام إلى الاتفاقية المتعلقة بوضع الأشخاص عديمي الجنسية لعام 1954 وإلى اتفاقية خفض حالات انعدام الجنسية لعام 1966.", "", "" },
                    { 124, null, "R12P1P2", "ت.12.ف.1.ف.2", "", "En cours", "", 30, 1, null, 4, null, 1, null, "Organes de traités", @"a) Redoubler d’efforts pour lutter efficacement contre la corruption et garantir la transparence dans la conduite des affaires publiques, notamment en appliquant la loi no 113.12 et en tenant compte des observations des organisations de la société civile;
                - b) Veiller à la protection des dénonciateurs et des témoins en garantissant si nécessaire leur anonymat et en les protégeant contre toute forme de représailles ainsi que de fournir une compensation aux victimes", @"(أ) مضاعفة الجهود من أجل مكافحة الفساد وضمان الشفافية في تسيير الشؤون العامة بطرق منها تطبيق القانون رقم 113-12 والأخذ بملاحظات منظمات المجتمع المدني؛
                - (ب) الحرص على حماية المبلغين والشهود بضمان عدم الكشف عن هويتهم، عند الاقتضاء، وحمايتهم من التعرض لأي شكل من أشكال الانتقام ومنح تعويض للضحايا", "", "" },
                    { 438, null, "R74", "null", "", "Réalisé", "", 100, 1, null, null, null, 1, 2, "Procédure spéciale", @"Donner à toutes les personnes les moyens de faire valoir leurs droits, en garantissant à toutes les victimes de discrimination ou d’intolérance raciale et xénophobe un accès effectif à la justice et à des voies de recours adéquates. 
                - Mieux faire connaître les voies de recours disponibles et en faciliter l’accès, notamment en supprimant les obstacles linguistiques et en fournissant des informations adéquates et accessibles sur les droits et les recours dont disposent les groupes et les personnes en situation de vulnérabilité.", "null", "", "" },
                    { 439, null, "R79P2", "null", "", "Réalisé", "", 100, 1, null, null, null, 1, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès à la justice", "null", "", "" },
                    { 474, null, "R88P4", "ت.88.ف.4", "", "En cours", "", 30, 1, null, null, null, 1, 3, "Procédure spéciale", "-    Faire en sorte que les déclarations ou les aveux d’une personne privée de liberté, qui ne sont pas faits en présence d’un juge et avec l’assistance d’un avocat, n’aient aucune valeur probante dans les procédures contre cette personne ;", "-          (د) ضمان ألا يكون لبيانات شخص مسلوب الحرية أو اعترافاته، غير تلك المدلى بها بحضور قاض أو بمساعدة محام، أي قوة مقنعة في الإجراءات المتعلقة بذلك الشخص؛", "", "" },
                    { 475, null, "R88P5", "ت.88.ف.5", "", "En cours", "", 30, 1, null, null, null, 1, 3, "Procédure spéciale", "-    Faire en sorte que les rapports établis par la police judiciaire pendant l’enquête restent irrecevables dans le cadre d’un procès tant que l’accusation, à qui incombe la charge de la preuve, n’a pas prouvé leur véracité et leur validité juridique, conformément au Code de procédure pénale ;", "-          (ﻫ) التأكد من عدم قبول تقارير الشرطة القضائية المعدة إبّان مرحلة التحقيق في المحاكم حتى يثبت الادعاء صحتها وصلاحيتها القانونية وفقاً لقانون الإجراءات الجنائية؛", "", "" },
                    { 476, null, "R88P9", "ت.88.ف.9", "", "En cours", "", 30, 1, null, null, null, 1, 3, "Procédure spéciale", @"faire en sorte que le personnel médical des lieux de détention soit véritablement indépendant des organes chargés d’appliquer la loi et reçoive une formation au sujet du Protocole d’Istanbul ;
                -  autoriser l’accès à des examens médicaux indépendants effectués sans surveillance ni ingérence de la part d’agents chargés d’appliquer la loi ou de procureurs et d’assurer l’accès en temps voulu à des examens médicaux indépendants, au moment de l’arrestation, lors d’un transfert vers un autre lieu de détention ou sur demande;", @"ط) التأكد من أن العاملين الطبيين في أماكن الاحتجاز مستقلون تماماً عن موظفي إنفاذ القانون، ومدربون على بروتوكول اسطنبول؛ 
                      الترخيص في الفحوص الطبية المستقلة دون تدخل العاملين في مجال إنفاذ القانون أو المدعين العامين أو حضورهم؛ وضمان تلك الفحوص في الوقت المناسب عند إلقاء القبض أو النقل إلى مكان احتجاز آخر أو عند الطلب؛", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 583, null, "R83P2", "null", "", "En cours", "", 30, 1, null, null, null, 1, 6, "Procédure spéciale", "-       S’assurer que tous les suspects aient le droit de bénéficier, dans la pratique, des autres garanties fondamentales prévues par la loi, notamment le droit d’être examiné par un médecin indépendant, de communiquer avec un proche ou un ami, d’être informés de leurs droits et des charges retenues contre eux, et d’être traduits devant un juge sans délai", "null", "", "" },
                    { 584, null, "R83P9", "null", "", "Réalisé", "", 100, 1, null, null, null, 1, 6, "Procédure spéciale", "-       Renforcer les efforts pour lutter contre la détention au secret, conformément à l’article 23 de la Constitution", "null", "", "" },
                    { 1000, null, "R144.44P1", "44.144.ج.1", "", "En cours", "", 30, 1, 1, null, 96, 1, null, "Examen périodique universal", "Poursuivre les réformes visant à consolider l’état de droit et les mécanismes nationaux de protection des droits de l’homme", "مواصلة الإصلاحات بقصد توطيد سيادة القانون لحماية حقوق الإنسان", "", "" },
                    { 1001, null, "R144.123", "123.144", "", "Réalisé", "", 100, 1, 1, null, 34, 1, null, "Examen périodique universal", "Mener des enquêtes complètes, impartiales et indépendantes sur toutes les allégations de corruption ou d’abus par les forces de sécurité et en poursuivre les responsables, le cas échéant", "إجراء تحقيقات كاملة ونزيهة ومستقلة في جميع ادعاءات الفساد أو الاعتداء على يد قوات الأمن وملاحقة المسؤولين عنها، عند الاقتضاء", "", "" },
                    { 1002, null, "R144.124", "124.144", "", "Réalisé", "", 100, 1, 1, null, 7, 1, null, "Examen périodique universal", "Prendre des mesures supplémentaires pour garantir l’indépendance du pouvoir judiciaire, ce qui est important pour garantir un procès équitable conformément aux normes internationales des droits de l’homme", "القيام بخطوات أخرى من أجل ضمان استقلال القضاء، وهو أمر مهم لضمان إجراء محاكمات عادلة بما يتفق مع المعايير الدولية لحقوق الإنسان", "", "" },
                    { 585, null, "R83P11", "null", "", "Réalisé", "", 100, 1, null, null, null, 2, 6, "Procédure spéciale", "-       Réformer le système judiciaire afin de garantir que toutes les personnes en détention préventive bénéficient d’un procès équitable et rapide", "null", "", "" },
                    { 1003, null, "R144.125", "125.144", "", "En cours", "", 30, 1, 1, null, 52, 2, null, "Examen périodique universal", "Mener à bien la réforme de la de la justice", "إكمال إصلاحات القضاء", "", "" },
                    { 1004, null, "R144.126", "126.144", "", "Réalisé", "", 100, 1, 1, null, 99, 2, null, "Examen périodique universal", "Accélérer la mise en œuvre de la charte sur la réforme du système judiciaire", "تسريع تنفيذ ميثاق إصلاح منظومة العدالة", "", "" },
                    { 1005, null, "R144.127", "127.144", "", "Réalisé", "", 100, 1, 1, null, 87, 2, null, "Examen périodique universal", "Parachever le processus de réforme du système judiciaire et garantir l’indépendance du pouvoir judiciaire en conformité avec les exigences constitutionnelles", "مواصلة إتمام عملية إصلاح منظومة العدالة وضمان استقلال القضاء بما يتفق مع مقتضيات الدستور ذات الصلة", "", "" },
                    { 556, null, "R89P7", "null", "", "Réalisé", "", 100, 1, null, null, null, 3, 5, "Procédure spéciale", @"Adopter une approche globale et intégrée de la rédaction de toutes les lois d’application et organiques relatives aux institutions qui tirent leur mandat de la
                Constitution, afin d’assurer, dans toutes ces institutions, la cohérence et l’homogénéité requises, notamment l’application du principe de l’égalité des sexes et la réalisation des objectifs en matière d’égalité entre les hommes et les femmes, conformément aux normes internationales. 
                Les efforts de coordination entre le Gouvernement, le Conseil national des droits de l’homme, la société civile et d’autres partenaires devraient viser à assurer l’application effective des dispositions constitutionnelles", "null", "", "" },
                    { 611, null, "R83P1", "ت.83.ف.1", "", "En cours", "", 30, 1, null, null, null, 3, 7, "Procédure spéciale", "De nouvelles dispositions constitutionnelles, en particulier celles qui concernent les droits et la diversité culturels, devraient être effectivement appliquées au moyen de textes législatifs, y compris tous les décrets pertinents, comme le stipule la Constitution", @"ينبغي إنفاذ الأحكام الدستورية الجديدة، لا سيما تلك المتعلقة بالحقوق الثقافية والتنوع الثقافي، إنفاذاً فعالاً من خلال اعتماد قوانين، بما فيها جميع القوانين الفرعية المناسبة، مثلما ينص على ذلك الدستور. 
                - تتطلب القوانين والتدابير الجديدة  المتعلقة بإنفاذ الأحكام الدستورية الجديدة، لا سيما تلك الخاصة بالحقوق الثقافية والتنوع الثقافي اعتماد سياسات واستراتيجيات مناسبة وينبغي أن تقترن بتدريب مناسب وتوجيه صحيح للمسؤولين المكلفين بتطبيقها.", "", "" },
                    { 612, null, "R86P1-1", "ت.86.ف.1ج1", "", "En cours", "", 30, 1, null, null, null, 3, 7, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en promulguant sans délai des lois donnant effet à la disposition constitutionnelle conférant à la langue amazighe le statut de langue officielle", @"(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                - سن قوانين فورية لإنفاذ الحكم الدستوري الذي يمنح اللغة الأمازيغية صفة رسمية؛", "", "" },
                    { 1006, null, "R144.117", "117.144", "", "En cours", "", 30, 1, 1, null, 89, 3, null, "Examen périodique universal", "Veiller à ce que les dispositions de la Constitution sur la liberté de la presse, la liberté d’opinion et d’expression et la liberté de réunion et d’association soient respectées, y compris pour les personnes qui veulent exprimer leurs vues sur la situation du et au Sahara occidental", "ضمان احترام أحكام الدستور المتعلقة بحرية الصحافة وحرية الرأي والتعبير وحرية التجمع وتكوين الجمعيات، حتى للأشخاص الذين يريدون التعبير عن آرائهم بشأن الحالة في الصحراء الغربية ووضعها السياسي", "", "" },
                    { 1007, null, "R144.114P2", "114.144.ج.2", "", "Réalisé", "", 100, 1, 1, null, 36, 3, null, "Examen périodique universal", "Garantir pleinement les libertés d’expression et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية تكوين الجمعيات ضماناً تاماً بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" },
                    { 1008, null, "R144.121", "121.144", "", "Réalisé", "", 100, 1, 1, null, 89, 3, null, "Examen périodique universal", "Lever les obstacles à l’enregistrement des associations non gouvernementales auprès des autorités", "إزالة العوائق التي تمنع الجمعيات غير الحكومية من التماس تسجيلها من قِبل السلطات", "", "" },
                    { 1009, null, "R144.122", "122.144", "", "En cours", "", 30, 1, 1, null, 34, 3, null, "Examen périodique universal", "Approuver les demandes de licence pour toutes les associations non gouvernementales demandant l’enregistrement conformément à la loi, y compris les organisations qui défendent les membres des populations minoritaires", "الموافقة على طلبات الترخيص لجميع الجمعيات غير الحكومية التي تلتمس التسجيل وفقاً للقانون، بما فيها الجمعيات التي تدافع عن أفراد الأقليات من السكان", "", "" },
                    { 1010, null, "R144.58P1", "58.144. ج.1", "", "Réalisé", "", 100, 1, 1, null, 48, 3, null, "Examen périodique universal", "Veiller à établir des procédures régissant l’enregistrement des organisations de la société civile", "ضمان وضع إجراءات تحكم تسجيل منظمات المجتمع المدني ......", "", "" },
                    { 1011, null, "R144.61P1", "61.144. ج.1", "", "Réalisé", "", 100, 1, 1, null, 65, 3, null, "Examen périodique universal", "Veiller à ce que les procédures régissant l’enregistrement des organisations de la société civile, soient conformes aux normes internationales", "ضمان أن تكون الآليات التي تنظم تسجيل منظمات المجتمع المدني..... متوافقة مع المعايير الدولية", "", "" },
                    { 1, null, "R21", "ت.21", "", "Réalisé", "", 100, 2, null, 1, null, 5, null, "Organes de traités", "Envisager de ratifier les traités internationaux relatifs aux droits de l’homme auxquels il n’est pas encore partie mais qui pourraient avoir un rapport avec la  question de la discrimination raciale qui est en voie de trouver une solution et faire écho à l’histoire récente du Maroc, tels que la Convention internationale pour la protection de toutes les personnes contre les disparitions forcées adoptée en 2006.", "التفكير في التصديق على المعاهدات الدولية المتعلقة بحقوق الإنسان التي لم تنضم إليها المملكة المغربية بعد والتي قد تكون ذات صلة بمسألة التمييز العنصري التي هي مسألة في طريق الحل وإيجاد صدى لها في تاريخ المغرب الحديث، كالاتفاقية الدولية لحماية جميع الأشخاص من الاختفاء القسري، التي اعتُمدت في عام 2006.", "", "" },
                    { 2, null, "R24", "ت.24", "", "Non réalisé", "", 0, 2, null, 1, null, 5, null, "Organes de traités", "Ratifier les modifications apportées au paragraphe 6 de l’article 8 de la Convention, adoptées le 15 janvier 1992 à la quatorzième réunion des Etats parties à la Convention et approuvées par l’Assemblée générale dans sa résolution 47/111 en date du 16 décembre 1992. A cet égard, il renvoie à la résolution 61/148 de l’Assemblée générale, par laquelle l’Assemblée a demandé instamment aux Etats parties à la Convention d’accélérer leurs procédures internes de ratification des modifications et d’informer par écrit le Secrétaire général, dans les meilleurs délais, de leur acceptation de ces modifications.", "التصديق على التعديل الذي أُجري على الفقرة 6 من المادة 8 من الاتفاقية والذي اعتُمد في 15 كانون الثاني/يناير 1992 أثناء الدورة الرابعة عشرة للدول الأطراف في الاتفاقية (انظر مرفق الوثيقة CERD/SP/45) وأقرته الجمعية العامة في قرارها 47/111. وفي هذا الصدد، تشير اللجنة إلى الفقرة 14 من قرار الجمعية العامة 61/148 التي حثت فيها الجمعيةُ العامة بقوة الدول الأطراف في الاتفاقية على التعجيل باتخاذ إجراءاتها الداخلية للتصديق على التعديل وعلى إخطار الأمين العام بموافقتها عليه كتابةً وفي أسرع وقت ممكن.", "", "" },
                    { 33, null, "R21P1", "ت.21ف.1", "", "Non réalisé", "", 0, 2, null, 2, null, 5, null, "Organes de traités", "Envisager de ratifier le deuxième Protocole facultatif se rapportant au Pacte international relatif aux droits civils et politiques, visant à abolir la peine de mort.", "النظر في التصديق على البروتوكول الاختياري الثاني الملحق بالعهد الدولي الخاص بالحقوق المدنية والسياسية، الذي يرمي إلى إلغاء عقوبة الإعدام.", "", "" },
                    { 35, null, "R31P1", "ت.31.ف.1", "", "Réalisé", "", 100, 2, null, 2, null, 5, null, "Organes de traités", "envisager d’adhérer au Protocole facultatif se rapportant à la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "النظر في الانضمام إلى البروتوكول الاختياري لاتفاقية مناهضة التعذيب وغيره من ضروب المعاملة القاسية أو اللاإنسانية أو المهينة.", "", "" },
                    { 1018, null, "R144.16", "16.144.", "", "Non réalisé", "", 0, 2, 1, null, 72, 5, null, "Examen périodique universal", "Ratifier la convention (no 189) de l’OIT sur les travailleuses et travailleurs domestiques, 2011", "التصديق على اتفاقية العمال المنزليين، 2011 (رقم 189)، لمنظمة العمل الدولية", "", "" },
                    { 1019, null, "R144.110 P2", "110.144.ج.2", "", "Non réalisé", "", 0, 2, 1, null, 80, 5, null, "Examen périodique universal", "Ratifier le Protocole de 2014 à la Convention sur le travail forcé de l’Organisation internationale du Travail", "التصديق على بروتوكول عام 2014 لاتفاقية منظمة العمل الدولية لإلغاء السخرة", "", "" },
                    { 1020, null, "R144.242", "242.144.", "", "Non réalisé", "", 0, 2, 1, null, 51, 5, null, "Examen périodique universal", "Adhérer aux conventions relatives au statut des apatrides et à la réduction des cas d’apatridie pour accorder la nationalité aux enfants qui, autrement, demeureraient apatrides et les incorporer dans le droit interne", "الانضمام إلى الاتفاقيات المتعلقة بمركز الأشخاص عديمي الجنسية وإدراج أحكامها في قانونه الداخلي والحد من حالات انعدام الجنسية عن طريق منح الجنسية للأطفال الذين سيظلون بلا جنسية ما لم يُمنَحوا الجنسية المغربية", "", "" },
                    { 170, null, "R53", "ت.53", "", "En cours", "", 30, 2, null, 5, null, 7, null, "Organes de traités", "Assurer une large participation de tous les ministères et organismes publics à l’établissement du prochain rapport et de consulter à cette occasion diverses organisations de défense des droits des travailleurs migrants et des droits de l’homme.", "- كفالة مشاركة جميع الوزارات والهيئات الحكومية مشاركة واسعة في إعداد التقرير المُقبل والتشاور بهذه المناسبة مع منظمات شتى للدفاع عن حقوق العمال المهاجرين وحقوق الإنسان.", "", "" },
                    { 171, null, "R52", "ت.52", "", "En cours", "", 30, 2, null, 5, null, 7, null, "Organes de traités", "-soumettre le deuxième rapport périodique le 13 septembre 2018 au plus tard. -opter pour la procédure simplifiée de soumission de rapports, suivant laquelle le Comité établit à l’intention de l’État partie une liste de points à traiter. Les réponses de l’État partie à cette liste constituent son rapport aux fins de l’article 73 de la Convention et le dispensent de soumettre son rapport selon la formule classique. Cette nouvelle procédure facultative a été adoptée par le Comité à sa quatorzième session, en avril 2011 (voir A/66/48, par. 26).", "تقديم التقرير الدوري الثاني في موعد أقصاه 13 سبتمبر 2018، علما أن للمملكة المغربية إمكانية اختيار الإجراء المُبسَّط لتقديم التقارير، الذي تقدم بموجبه اللجنة إلى الدولة الطرف قائمة المسائل الواجب معالجتها. وتشكّل ردود الدولة الطرف على هذه القائمة تقريرها بموجب المادة 73 من الاتفاقية وتُعفيها من تقديم تقريرها بالصيغة التقليدية. وقد اعتمدت اللجنة هذا الإجراء الاختياري الجديد في دورتها الرابعة عشرة المعقودة في نيسان/أبريل 2011 (انظر الوثيقة A/66/48، الفقرة 26).", "", "" },
                    { 172, null, "R54", "ت.54", "", "En cours", "", 30, 2, null, 5, null, 7, null, "Organes de traités", "suivre les directives harmonisées concernant l’établissement des rapports destinés aux organes créés en vertu d’instruments internationaux relatifs aux droits de l’homme (HRI/GEN/2/Rev.6), notamment les directives portant sur le document de bases communes et les rapports propres à chaque instrument. Le document propre à la Convention ne devrait pas dépasser 40 pages et le document de base commun mis à jour ne devrait pas dépasser 80 pages.", @"اتباع المبادئ التوجيهية المنسَّقة لتقديم التقارير بموجب المعاهدات الدولية لحقوق الإنسان (HRI/GEN/2/Rev.6)، بما في ذلك المبادئ التوجيهية لتقديم وثيقة أساسية موحَّدة ووثائق خاصة بمعاهدات بعينها. 
                ينبغي ألا يتجاوز حجم الوثيقة الخاصة بالاتفاقية 40 صفحة والوثيقة الأساسية الموحدة المُحدَّثة 80 صفحة.", "", "" },
                    { 204, null, "R9", "ت.9", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", @"appliquer، de manière systématique et constante, toutes les dispositions de la Convention, 
                - les sujets de préoccupation et recommandations figurant dans les présentes observations finales doivent faire l’objet d’une attention prioritaire de la part de l’État partie jusqu’à la soumission du prochain rapport périodique. 
                - le Maroc doit axer ses activités de mise en œuvre sur ces questions et à faire rapport sur les mesures prises et les résultats obtenus dans son prochain rapport périodique. 
                - le Maroc doit soumettre les présentes observations finales à tous les ministères compétents, au 32et aux autorités judiciaires afin d’en assurer l’application pleine et entière.
                -  le Maroc est encouragé à poursuivre ses réformes en concertation avec la société civile, en particulier les organisations de femmes.", @"تذكر اللجنة بالتزام المغرب بتنفيذ جميع أحكام الاتفاقية على نحو منهجي ومستمر، 
                - ترى اللجنة أن الشواغل والتوصيات المحددة في هذه التعليقات الختامية تتطلب الأولوية من حيث العناية من الآن وإلى حين تقديم التقرير المرحلي المقبل. وعليه، فإن  
                - تدعو اللجنة   إلى أن يتم التركيز على المجالات التي حددتها في أنشطة التنفيذ التي تضطلع بها، وأن تبلغ المملكة المغربية في تقريرها الدوري المقبل عن الإجراءات المتخذة والنتائج المحققة. 
                -تدعو اللجنة المغرب إلى عرض هذه التعليقات الختامية على البرلمان وكافة الوزارات الحكومية المعنية والسلطات القضائية لكفالة تنفيذها تنفيذا كاملا.", "", "" },
                    { 205, null, "R17P3", "ت.17.ف.3", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "Fournir, dans son prochain rapport périodique, des renseignements détaillés concernant les voies de recours disponibles en cas de discrimination, les affaires de discrimination portées devant le Médiateur et les tribunaux et les suites qui leur sont données", "- تضمين التقرير الدوري المقبل معلومات مفصلة عن سبل الانتصاف المتاحة في حالات التمييز، وعن الشكاوى المقدمة في الحالات المتصلة بالتمييز ضد المرأة أمام ديوان المظالم والمحاكم، وعن النتائج التي أسفرت عنها.", "", "" },
                    { 206, null, "R21P5", "ت.21.ف.5", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "Présenter, dans le prochain rapport, des informations sur les lois et politiques en vigueur visant à lutter contre les violences familiales y compris le viol conjugal et de rendre compte des effets des mesures prises", "تضمين التقرير المقبل معلومات عن القوانين والسياسات المعمول بها للتصدي للعنف الأسري بما في ذلك الاغتصاب الزوجي وعن أثر التدابير المتخذة في هذا الصدد.", "", "" },
                    { 207, null, "R45P1", "ت.45.ف.1", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "Continuer à renforcer la coopération avec le Haut-Commissariat des Nations Unies pour les réfugiés (HCR)", "مواصلة تقوية التعاون مع مفوضية الأمم المتحدة لشؤون اللاجئين", "", "" },
                    { 208, null, "R53", "ت.53", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "répondre aux préoccupations exprimées dans les présentes observations dans le prochain rapport périodique que le Maroc présentera en application de l’article 18 de la Convention et présenter dans un rapport unique, en 2014, le  cinquième rapport périodique, qui devait être soumis en juillet 2010, et le sixième rapport périodique, prévu pour juillet 2014.", "الاستجابة للشواغل المعرب عنها في التعليقات الختامية الحالية وذلك في التقرير الذي سيقدم بموجب المادة 18 من الاتفاقية. ‎          تقديم التقرير الدوري ‏الخامس، الذي يحل موعد تقديمه في تموز/يوليه 2010، والتقرير الدوري السادس، الذي يحل موعد ‏تقديمه في تموز/يوليه 2014، في تقرير موحد في تموز/يوليه 2014.", "", "" },
                    { 209, null, "R23P3", "ت.23.ف.3", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "communiquer, dans le prochain rapport périodique, des données statistiques sur la traite et l’exploitation.", "موافاة اللجنة، في التقرير الدوري المقبل، ببيانات إحصائية تتعلق بالاتجار بالأشخاص واستغلالهم.", "", "" },
                    { 210, null, "R46", "ت.46", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", @"Améliorer la collecte et l’analyse de données statistiques et inclure dans le prochain rapport des données statistiques sur la situation des femmes, ventilées par âge, zone de résidence urbaine ou rurale, appartenance ethnique et origine régionale, Sahara occidental compris, de façon à donner une idée claire de la situation des femmes et indiquer l’impact des mesures prises et les résultats obtenus en ce qui concerne l’égalité effective entre les sexes.
                -Indiquer l’impact des mesures prises et les résultats obtenus en ce qui concerne l’égalité effective entre les sexes.", @"تعزيز عملية جمع البيانات وتحليلها، وتضمين التقرير المقبل بيانات إحصائية وتحليلات عن وضع المرأة، مصنفة حسب السن، وحسب المناطق الريفية والحضرية، والعرق، والدين، متضمنة الصحراء الغربية، لتقديم صورة واضحة لحالة المرأة في الدولة الطرف. 
                -توضيح تأثير التدابير المتخذة والنتائج المحققة في التطبيق العملي على التحقيق الفعلي لمساواة المرأة بالرجل.", "", "" },
                    { 211, null, "R48", "ت.48", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "Associer tous les ministères et organismes publics à l’élaboration du prochain rapport et consulter les organisations non gouvernementales à cette occasion. Soumettre le rapport à l’examen de son Parlement avant de le lui présenter.", "كفالة المشاركة الواسعة لجميع الوزارات والهيئات العامة في إعداد التقرير التالي، ومواصلة التشاور مع المنظمات غير الحكومية خلال تلك المرحلة. وإشراك البرلمان في مناقشة التقرير قبل تقديمه إلى اللجنة.", "", "" },
                    { 212, null, "R49", "ت.49", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "-S’appuyer pleinement, pour s’acquitter de ses obligations en vertu de la Convention, sur la Déclaration et le Programme d’action de Beijing, qui renforcent les dispositions de la Convention, et inclure des informations à ce sujet dans son prochain rapport périodique.", "استخدام بصورة كاملة، عند تنفيذ الالتزامات بموجب الاتفاقية، إعلان ومنهاج عمل بيجين لأنهما يعززان أحكام الاتفاقية، وإدراج معلومات بشأن هذه المسألة في التقرير الدوري المقبل.", "", "" },
                    { 213, null, "R50", "ت.50", "", "Réalisé", "", 100, 2, null, 6, null, 7, null, "Organes de traités", "Veiller à ce que la réalisation des objectifs du Millénaire pour le développement passe nécessairement par l’application intégrale de la Convention et que le principe de l’égalité des sexes et les dispositions de la Convention soient expressément pris en considération dans toutes les initiatives visant à la réalisation des objectifs du Millénaire pour le développement et inclure des informations à ce sujet dans son prochain rapport périodique.", "العمل على إدماج منظور جنساني في جميع الجهود الرامية إلى تحقيق الأهداف الإنمائية للألفية، وعلى أن تتجلى أحكام الاتفاقية صراحة في جميع الجهود الرامية إلى بلوغ الأهداف الإنمائية للألفية وتضمين معلومات عن ذلك في تقريرها الدوري المقبل.", "", "" },
                    { 249, null, "R23P4", "ت.23.ف.4", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", @"Le Comité appelle l’attention de l’État partie sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                d) De renforcer sa coopération internationale contre le tourisme pédophile par le biais d’accords multilatéraux, régionaux et bilatéraux pour la prévention et l’élimination de ce phénomène.", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                -  (د) تعزيز تعاونها الدولي على مكافحة سياحة الجنس مع الأطفال، عن طريق ترتيبات متعددة الأطراف وإقليمية وثنائية قصد منعها والقضاء عليها.", "", "" },
                    { 250, null, "R23P5", "ت.23.ف.5", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", @"Le Comité appelle l’attention de l’État partie sur son Observation générale no 16 (2013) sur les obligations des États concernant les incidences du secteur des entreprises sur les droits de l’enfant et, en particulier, lui recommande :
                d) De renforcer sa coopération internationale contre le tourisme pédophile par le biais d’accords multilatéraux, régionaux et bilatéraux pour la prévention et l’élimination de ce phénomène.", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 16(2013) بشأن التزامات الدولة المتعلقة بالآثار التي يحدثها قطاع الأعمال على حقوق الأطفال، وتوصيها خاصة بالآتي: 
                - (أ) النظر في إطارها التشريعي المتعلق بالمساءلة القانونية للشركات الخاصة وفروعها العاملة في إقليم الدولة الطرف أو التي تدار انطلاقاً منها، خاصة في قطاع السياحة، وتكييف ذلك الإطار", "", "" },
                    { 251, null, "R57P4", "ت.57.ف.4", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", @"Renvoyant à son Observation générale no 4 (2003) sur la santé et le développement de l’adolescent, le Comité demande instamment à l’État partie:
                d) De solliciter une assistance technique auprès, entre autres, du Programme commun des Nations Unies sur le VIH/sida (ONUSIDA) et l’UNICEF.", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                - (د) التماس المساعدة التقنية من جهات مثل برنامج الأمم المتحدة المشترك بين منظمات الأمم المتحدة لمكافحة الإيدز واليونيسيف", "", "" },
                    { 252, null, "R65 P5", "ت.65.ف.5", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", "Solliciter à cet égard l’assistance technique du programme international sur l’élimination du travail des enfants de l’OIT", "(ه) التماس المساعدة التقنية في هذا الصدد من البرنامج الدولي لمنظمة العمل الدولية للقضاء على عمل الأطفال", "", "" },
                    { 253, null, "R71", "ت.71", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", "Donner suite aux recommandations qui figurent dans ses observations finales concernant le rapport initial du Maroc au titre du Protocole facultatif à la Convention relative aux droits de l’enfant, concernant la vente d’enfants, la prostitution des enfants et la pornographie mettant en scène des enfants, et faire figurer des informations complètes à cet égard dans son prochain rapport périodique.", "-          نفيذ التوصيات الواردة في ملاحظات اللجنة الختامية بشأن تقرير الدولة الطرف الأولي بمقتضى البروتوكول الاختياري المتعلق ببيع الأطفال واستغلال الأطفال في البغاء وفي المواد الإباحية وتقديم معلومات شاملة في هذا الصدد في تقريرها الدوري القادم.", "", "" },
                    { 254, null, "R75P6", "ت.75.ف.6", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", @"Le Comité exhorte le Maroc à mettre son système de justice pour mineurs en totale conformité avec la Convention, en particulier avec les articles 37, 39 et 40, ainsi qu’avec d’autres normes applicables et avec l’Observation générale no 10 (2007) du Comité sur les droits de l’enfant dans le système de justice pour mineurs. Il exhorte en particulier le Maroc à:
                f) Utiliser les outils d’assistance technique mis au point par le groupe inter institutions sur la justice pour mineurs et ses membres, notamment l’Office des Nations Unies contre la drogue et le crime.", @"تحث اللجنة المملكة لمغربية على التوفيق التام بين نظامها لعدالة الأحداث والاتفاقية، لا سيما المواد 37 و39 و40، وكذلك مع معايير أخرى متصلة بالموضوع ومع تعليق اللجنة العام رقم 10(2007) بشأن حقوق الطفل في قضاء الأحداث. وتحثها خاصة على الآتي:
                -  (و) توظيف أدوات المساعدة التقنية التي وضعها الفريق المشترك بين الوكالات المعني بقضاء الأحداث وأعضاؤه، بما في ذلك مكتب الأمم المتحدة المعني بالمخدرات والجريمة.", "", "" },
                    { 255, null, "R78", "ت.78", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", @"Soumettre les cinquième et sixième rapports en un seul document d’ici à juillet 2020 et à y faire figurer des informations sur la suite donnée aux présentes observations finales. 
                - Le rapport devrait être conforme aux directives harmonisées du Comité pour l’établissement des rapports portant spécifiquement sur l’application de la Convention, adoptées le 1er octobre 2010 (CRC/C/58/Rev.2 et Corr.1) et ne devrait pas excéder 21 200 mots (voir résolution 68/268 de l’Assemblée générale, par. 16). 
                - Si l’État partie soumet un rapport dont le nombre de pages dépasse la limite fixée, il sera invité à le raccourcir et à le soumettre à nouveau conformément à la résolution susmentionnée. S’il n’est pas en mesure de remanier son rapport et de le soumettre à nouveau, la traduction de ce rapport aux fins d’examen par le Comité ne pourra être garantie", @"تقديم التقرير الجامع للتقريرين الدوريين الثالث والرابع بحلول 20 تموز/يوليه 2020 وتضمينه معلومات عن متابعة هذه الملاحظات. 
                - التقيد في إعداد التقرير بالمبادئ التوجيهية المنسقة لتقديم التقارير الخاصة بمعاهدة بعينها، التي اعتمدتها اللجنة في 1 تشرين الأول/أكتوبر 2010 (الوثيقتان CRC/C/58/Rev.2 وCorr.1)، وألا يتجاوز عدد كلماتها 200 21 كلمة (انظر قرار الجمعية العامة رقم 68/268، الفقرة 16). 
                - إن تجاوز عدد كلمات التقرير المقدَّم الحد الأقصى المنصوص عليه، طُلب من الدولة الطرف أن تقلّص حجمه عملاً بالقرار السالف الذكر. وإذا تعذّر على الدولة الطرف مراجعة التقرير وتقديمه من جديد، لم يمكن تأمين ترجمة التقرير كي تنظر فيه هيئة المعاهدة.", "", "" },
                    { 256, null, "R79", "ت.79", "", "En cours", "", 30, 2, null, 7, null, 7, null, "Organes de traités", @"Soumettre un document de base actualisé conformément aux prescriptions applicables au document de base figurant dans les directives harmonisées pour l’établissement de rapports, qui ont été approuvées en juin 2006 à la cinquième réunion intercomités des organes créés en vertu d’instruments internationaux relatifs aux droits de l’homme (HRI/GEN/2/Rev.6, chap. I). 
                - La limite fixée pour le document de base commun est de 42 400 mots, comme l’a décidé l’Assemblée générale dans sa résolution 68/268 (par. 16).", @"تقديم وثيقة أساسية محدَّثة وفقاً لمتطلبات الوثيقة الأساسية المشتركة الواردة في المبادئ التوجيهية المنسقة لتقديم التقارير، كما أقرها الاجتماع الخامس المشترك بين لجان هيئات معاهدات حقوق الإنسان في حزيران/يونيه 2006 (الوثيقة HRI/GEN/2/Rev.6، الفصل الأول). 
                - يصل الحد الأقصى لعدد الكلمات في الوثيقة الأساسية المشتركة إلى 400 42 كلمة، وفقاً لما حددته الجمعية العامة في قرارها رقم 68/268 (الفقرة 16).", "", "" },
                    { 316, null, "P65", "ت.65", "", "Réalisé", "", 100, 2, null, 8, null, 7, null, "Organes de traités", "-                    faire parvenir au Comité, dans un délai de douze mois, des renseignements sur l’adoption des présentes observations finales et, conformément au paragraphe 2 de l’article 35 de la Convention, sur les mesures prises pour mettre en œuvre les recommandations figurant aux paragraphes 11 et 15.", "موافاة اللجنة المعنية، في غضون 12 شهراً من اعتماد هذه الملاحظات الختامية ووفقاً للمادة 35(2) من الاتفاقية، بمعلومات عن التدابير المتخذة لتنفيذ توصيات اللجنة الواردة في الفقرتين 11 و15.", "", "" },
                    { 317, null, "R66", "ت.66", "", "En cours", "", 30, 2, null, 8, null, 7, null, "Organes de traités", @"mettre en œuvre les recommandations figurant dans les présentes observations finales. 
                - transmettre les présentes observations finales, pour examen et suite à donner, aux membres du Gouvernement et du 32, aux responsables des différents ministères, aux autorités locales, aux organisations de personnes handicapées et aux membres des professions concernées, tels les professionnels de l’éducation, de la santé et du droit, ainsi qu’aux médias, en utilisant pour ce faire les stratégies de communication sociale modernes", @"تنفيذ التوصيات الواردة في هذه الملاحظات الختامية. 
                - إحالة هذه الملاحظات الختامية، للنظر فيها واتخاذ إجراءات بشأنها، إلى أعضاء الحكومة والبرلمان والمسؤولين في الوزارات المختصة والسلطات المحلية ومنظمات الأشخاص ذوي الإعاقة وأعضاء المجموعات المهنية المعنية، مثل العاملين في التعليم والمهن الطبية والقانونية، وكذلك إلى وسائط الإعلام، باستخدام استراتيجيات التواصل الاجتماعي الحديثة", "", "" },
                    { 318, null, "R67", "ت.67", "", "Non réalisé", "", 0, 2, null, 8, null, 7, null, "Organes de traités", "-                    associer les organisations de la société civile, en particulier les organisations de personnes handicapées, à l’élaboration de ses rapports périodiques.", "-           إشراك منظمات المجتمع المدني، ولا سيما منظمات الأشخاص ذوي الإعاقة، في إعداد التقرير الدوري.", "", "" },
                    { 319, null, "R69", "ت.69", "", "Non réalisé", "", 0, 2, null, 8, null, 7, null, "Organes de traités", @"soumettre le rapport valant deuxième à quatrième rapports périodiques le 2 mai 2023 au plus tard et d’y faire figurer des renseignements sur la mise en œuvre des recommandations formulées dans les présentes observations finales. 
                - envisager de soumettre ce rapport selon la procédure simplifiée de présentation des rapports, dans le cadre de laquelle le Comité établit une liste de points au moins un an avant la date prévue pour la soumission du rapport. Les réponses de l’État partie à cette liste de points constituent son rapport périodique", @"تقديم التقرير الجامع للتقارير الدورية الثاني إلى الرابع بحلول 2 أيار/مايو 2023 وتضمينه معلومات عن تنفيذ التوصيات الواردة في هذه الملاحظات الختامية. 
                - النظر في تقديم التقارير المذكورة أعلاه عملاً بإجراء اللجنة المبسط لتقديم التقارير، الذي تعد اللجنة بموجبه قائمة مسائل قبل التاريخ المحدد لتقديم تقرير الدولة الطرف أو تقاريرها الموحدة بسنة واحدة على الأقل. وتشكل ردود الدولة الطرف على قائمة المسائل هذه تقريرها.", "", "" },
                    { 441, null, "R69", "null", "", "Réalisé", "", 100, 2, null, null, null, 7, 2, "Procédure spéciale", "-       Soumettre sans plus tarder le rapport unique valant dix-neuvième, vingtième et vingt et unième rapports périodiques au Comité pour l’élimination de la discrimination raciale.", "null", "", "" },
                    { 478, null, "R90P1", "ت.90.ف.1", "", "En cours", "", 30, 2, null, null, null, 7, 3, "Procédure spéciale", @"En ce qui concerne les migrants, les réfugiés et les demandeurs d ’ asile, le Rapporteur spécial recommande au
                Gouvernement de collaborer plus étroitement avec le Haut- Commissariat des Nations Unies aux droits de l ’ homme, le
                Rapporteur spécial sur les droits de l ’ homme des migrants et d ’ autres organismes des Nations Unies, tels que le
                Haut-Commissariat des Nations Unies pour les réfugiés et:
                a) De prendre toutes les mesures nécessaires pour prévenir d ’ autres violences et enquêter sur les informations faisant
                état d ’ actes de violence subis par des migrants, des réfugiés et des demandeurs d ’ asile subsahariens;", @"فيما يتعلق بالمهاجرين واللاجئين وملتمسي اللجوء، يوصي المقرر الخاص الحكومة بأن توثق تعاونها مع مفوضية الأمم المتحدة السامية لحقوق الإنسان، والمقرر الخاص المعني بحقوق الإنسان للمهاجرين، ووكالات أخرى تابعة للأمم المتحدة، مثل مفوضية الأمم المتحدة السامية لشؤون اللاجئين؛ كما يوصيها بما يلي:
                    أ) اتخاذ جمیع التدابیر اللازمة لمنع حدوث المزید من أعمال العنف، والتحقیق في التقاریر التي تتحدث عن تلك الأعمال في حق) المھاجرین واللاجئین وملتمسي اللجوء من الصحراء الغربیة؛", "", "" },
                    { 169, null, "R50", "ت.50", "", "En cours", "", 30, 2, null, 5, null, 7, null, "Organes de traités", "associer à l’élaboration du deuxième rapport périodique les organisations de la société civile travaillant dans le domaine de la migration au niveau national.", "- إشراك منظمات المجتمع المدني العاملة في مجال الهجرة على الصعيد الوطني في إعداد تقريرها الدوري الثاني.", "", "" },
                    { 168, null, "R49", "ت.49", "", "En cours", "", 30, 2, null, 5, null, 7, null, "Organes de traités", "-       faire figurer dans le deuxième rapport périodique des renseignements détaillés sur les mesures   prises pour donner suite aux recommandations formulées dans les présentes observations finales et prendre toutes les dispositions voulues pour que lesdites recommandations soient appliquées.", "تضمين التقرير الدوري الثاني معلومات مفصَّلة عما اتخذته الدولة من تدابير لتنفيذ التوصيات المقدمة في هذه الملاحظات الختامية. واتخاذ جميع التدابير المطلوبة لضمان تنفيذ هذه التوصيات.", "", "" },
                    { 167, null, "R16", "ت.16", "", "En cours", "", 30, 2, null, 5, null, 7, null, "Organes de traités", @"faire figurer dans le prochain rapport périodique des données ventilées sur les domaines et les conditions dans lesquels les travailleurs migrants sont employés, y compris ceux en situation irrégulière, ainsi que sur leur jouissance des droits qui leur sont reconnus par la Convention et fournir  des renseignements sur le nombre de travailleurs migrants marocains et de membres de leur famille se trouvant à l’étranger, y compris ceux qui sont en situation irrégulière. 
                En l’absence d’informations précises, le Comité souhaiterait obtenir des données fiables, fondées sur des sondages ou des estimations crédibles.", "تضمين التقرير الدوري المقبل بيانات مصنفة عن:  - مجالات وظروف عمل العمال المهاجرين بمن فيهم العمال الموجودون في وضع غير قانوني، وعن مدى تمتعهم بالحقوق المعترف بها في الاتفاقية. - عدد العمال المهاجرين المغاربة وأفراد أسرهم في الخارج، بمن فيهم الموجودون في وضع غير قانوني. -   في غياب المعلومات الدقيقة، تود اللجنة الحصول على بيانات موثوق بها تستند إلى استقصاءات أو تقديرات ذات مصداقية.", "", "" },
                    { 129, null, "R54", "ت.54", "", "Non réalisé", "", 0, 2, null, 4, null, 7, null, "Organes de traités", "-            Présenter son cinquième rapport périodique, conformément aux directives adoptées par le Comité en 2008 (E/C.12/2008/2), d’ici au 31 octobre 2020.", "-          تقديم التقرير الدوري الخامس، وفقاً للمبادئ التوجيهية التي اعتمدتها اللجنة في عام 2008 (E/C.12/2008/2)، بحلول 31 أكتوبر 2020.", "", "" },
                    { 1021, null, "R144.19", "19.144", "", "Non réalisé", "", 0, 2, 1, null, 8, 5, null, "Examen périodique universal", "Envisager d’adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales", "النظر في توجيه دعوة دائمة إلى المكلفين بولايات في إطار الإجراءات الخاصة", "", "" },
                    { 37, null, "R30", "ت.30", "", "En cours", "", 30, 2, null, 2, null, 6, null, "Organes de traités", "Intensifier la coopération avec les mécanismes des droits de l’homme de l’ONU, notamment en autorisant les visites, entre autres :du Groupe de travail sur la détention arbitraire, de la Rapporteuse spéciale sur la traite des êtres humains, en particulier les femmes et les enfants et du Rapporteur spécial sur le droit de réunion et d’association pacifiques", "تكثيف التعاون مع آليات حقوق الإنسان التابعة للأمم المتحدة، خاصة بترخيص الزيارات والتي من بينها: زيارة فريق العمل المعني بالاحتجاز التعسفي، زيارة المقررة الخاصة المعنية بالاتجار بالبشر، وخاصة النساء والأطفال، زيارة المقرر الخاص المعني بحرية التجمع وتكوين الجمعيات", "", "" },
                    { 440, null, "R86", "null", "", "Non réalisé", "", 0, 2, null, null, null, 6, 2, "Procédure spéciale", "-       Inviter le Rapporteur spécial sur les droits de l’homme des migrants à effectuer une visite de pays", "null", "", "" },
                    { 1022, null, "R144.20", "20.144", "", "Réalisé", "", 100, 2, 1, null, 22, 6, null, "Examen périodique universal", "Continuer d’interagir de manière constructive avec les mécanismes des procédures spéciales du Conseil des droits de l’homme", "مواصلة التحاور بشكلٍ بنّاء مع آليات الإجراءات الخاصة التابعة لمجلس حقوق الإنسان", "", "" },
                    { 1023, null, "R144.21", "21.144", "", "Non réalisé", "", 0, 2, 1, null, 42, 6, null, "Examen périodique universal", "Adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales du Conseil des droits de l’homme", "توجيه دعوة دائمة إلى المكلفين بولايات في إطار الإجراءات الخاصة التابعة لمجلس حقوق الإنسان", "", "" },
                    { 1024, null, "R144.22", "22.144", "", "Non réalisé", "", 0, 2, 1, null, 53, 6, null, "Examen périodique universal", "Adresser une invitation permanente aux titulaires de mandat au titre des procédures spéciales, comme cela a été précédemment recommandé", "توجيه دعوة دائمة للإجراءات الخاصة، مثلما سبقت التوصية بذلك", "", "" },
                    { 1025, null, "R144.23", "23.144", "", "Réalisé", "", 100, 2, 1, null, 73, 6, null, "Examen périodique universal", "Prendre des mesures concrètes pour renforcer sa coopération avec les procédures spéciales de l’ONU, notamment celles du Conseil des droits de l’homme", "اتخاذ خطوات حقيقية من أجل تعزيز التعاون مع الإجراءات الخاصة التابعة للأمم المتحدة، ولا سيما مع إجراءات مجلس حقوق الإنسان", "", "" },
                    { 3, null, "R7", "ت.7", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "A la lumière de sa Recommandation générale no.8 (1990) concernant l’interprétation et l’application des paragraphes 1 et 4 de l’article premier de la Convention et conformément aux paragraphes 10 à 12 des directives révisées concernant l’établissement de rapports (CERD/C/2007/1), le Comité recommande à l’État partie de fournir des renseignements sur la composition de sa population, l’utilisation de langues maternelles, les langues communément parlées et d’autres indicateurs de la diversité ethnique, ainsi que toute autre information émanant d’études socio-économiques ciblées menées à titre volontaire, dans le plein respect de la vie privée et de l’anonymat des personnes concernées, afin qu’il puisse évaluer la situation de sa population sur le plan économique, social et culturel.", "في ضوء توصيتها العامة رقم 8 (1990) المتعلقة بتفسير وتطبيق أحكام     الفقرتين 1 و4 من المادة 1 من الاتفاقية وفي ضوء الفقرات 10 إلى 12 من مبادئها التوجيهية المنقحة المتعلقة بصياغة التقارير الدورية (CERD/C/2007/1)، توصي اللجنة الدولة الطرف بتقديم معلومات عن تكوين سكانها، وعن استخدام اللغات الأم، وعن اللغات الشائعة، وعن أي مؤشر آخر يتعلق بالتنوع العرقي. وتوصي اللجنة كذلك بأن تبلَّغ بأي معلومات أخرى مستقاة من دراسات اجتماعية واقتصادية محددة الهدف تُجرى على نحو طوعي مع الاحترام الكامل لحرمة الحياة الخاصة وإغفال هويات الأشخاص المعنيين، حتى يتسنى لها تقييم وضع سكانها على الصعيد الاقتصادي والاجتماعي والثقافي.", "", "" },
                    { 4, null, "R18P5", "ت.18.ف.5", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "fournir dans le prochain rapport des données complètes sur les plaintes déposées, les poursuites engagées, les condamnations et les peines prononcées pour des faits de discrimination raciale.", "تضمين التقرير المقبل بيانات كاملة عن الشكاوى المقدمة والملاحقات التي شُرع فيها والإدانات والعقوبات المنطوق بها في قضايا تتعلق بأفعال التمييز العنصري.", "", "" },
                    { 5, null, "R23", "ت.23", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "Poursuivre les consultations et d’approfondir son dialogue avec les organisations de la société civile œuvrant dans le domaine de la protection des droits de l’homme, en particulier avec celles qui luttent contre la discrimination raciale, en vue de l’élaboration du prochain rapport périodique.", "مواصلة التشاور مع منظمات المجتمع المدني العاملة في مجال حماية حقوق الإنسان، ولا سيما في مكافحة التمييز العنصري، وتعميق الحوار معها عند صياغة التقرير الدوري المقبل.", "", "" },
                    { 6, null, "R28", "ت.28", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "faire figurer dans le prochain rapport périodique des informations détaillées sur les mesures concrètes prises pour appliquer les recommandations7, 9, 10, 18, 20 et 26", "تقديم معلومات مفصلة في التقرير الدوري المقبل عن التدابير الملموسة والمناسبة المتخذة لتنفيذ التوصيات الواردة في الفقرات 7 و9 و10 و18 و20 الواردة في الفقرات 7 و9 و10 و18 و20 تنفيذاً فعالاً.", "", "" },
                    { 7, null, "R25", "ت.25", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "mettre les rapports à la disposition du public dès leur soumission et de diffuser également ses observations finales sur ces rapports dans la langue officielle et les autres langues communément utilisées, selon le cas.", "إتاحة التقارير الدورية لعامة الجمهور حال تقديمها، ونشر الملاحظات الختامية التي تعتمدها باللغة الرسمية وباللغات الأخرى الشائع استخدامها، حسب الاقتضاء، عند الفراغ من النظر في تلك التقارير.", "", "" },
                    { 8, null, "R26", "ت.26", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "Présenter une version mise à jour  du document de base en 2002 document de base présenté en 2002, qui devrait comporter de 60 à 80 pages, conformément aux directives harmonisées concernant l’établissement des rapports établis au titre des instruments internationaux relatifs aux droits de l’homme, à savoir celles qui se rapportent au document de base commun, telles qu’adoptées par la cinquième réunion inter comités des organes crées en vertu des traités relatifs aux droits de l’homme tenue en juin 2006 (HRI/GEN/2/Rev.4).", "تقديم نسخة محيَّنة للوثيقة الأساسية التي سبق ت إحالتها في عام 2002، من 60 إلى 80 صفحة، وفقاً للمبادئ التوجيهية المنسقة لتقديم التقارير بموجب المعاهدات الدولية لحقوق الإنسان، ولا سيما ما يتصل منها بالوثيقة الأساسية المشتركة، بالصيغة المعتمدة في الاجتماع الخامس المشترك بين لجان هيئات معاهدات حقوق الإنسان المعقود في حزيران/يونيه 2006 (HRI/GEN/2/Rev.4).", "", "" },
                    { 529, null, "R95P1", "null", "", "En cours", "", 30, 2, null, null, null, 7, 4, "Procédure spéciale", "-    Poursuivre la collaboration étroite avec les organisations internationales et les organismes des Nations Unies compétents, notamment avec le HCR et l’OIM, afin de permettre aux victimes de la traite de retourner saines et sauves dans leur pays, en tenant dûment compte, s’il y a lieu, de la nécessité de leur garantir une protection internationale.", "null", "", "" },
                    { 9, null, "R27", "ت.27", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "Fournir, dans un délai d’un an à compter de l’adoption des présentes observations finales, des informations sur la suite qu’il aura donnée aux recommandations contenues dans les paragraphes 11,13 et 14 ci-dessus, et ce conformément au au paragraphe 1 de l’article 9 de la Convention et à l’article 65 de son règlement 26 modifié", "تقديم معلومات بشأن متابعتها للتوصيات الواردة في الفقرات 11 و13 و14 أعلاه، في غضون سنة واحدة من اعتماد هذه الاستنتاجات، عملا بأحكام الفقرة 1 من المادة 9 من الاتفاقية والمادة 65 من نظام اللجنة الداخلي المعدل", "", "" },
                    { 38, null, "R33", "ت.33", "", "Réalisé", "", 100, 2, null, 2, null, 7, null, "Organes de traités", "fournir, avant le 25 novembre 2012, des renseignements sur la suite qui aura été donnée aux recommandations formulées visant à: 1) assurer ou renforcer les garanties juridiques des personnes détenues; 2) mener des enquêtes promptes, impartiales et effectives; 3) poursuivre les suspects et sanctionner les auteurs, de torture ou de mauvais traitements; et 4) octroyer les réparations visées aux paragraphes 7, 11, 15 et 28 du présent document. Informer le comité de la suite qui aura été donnée aux recommandations qu’il lui a adressées sur la loi contre le terrorisme au paragraphe 8 du présent document", "تقديم معلومات إلى اللجنة، قبل 25 نونبر 2012، عن متابعة التوصيات المقدمة والتي تهدف إلى:حماية وتعزيز الضمانات القانونية للأشخاص المعتقلين؛إجراء تحقيقات فورية ونزيهة وفعالة؛ ملاحقة المتهمين ومعاقبة ممارسي التعذيب وسوء المعاملة؛منح التعويضات المشار إليها في الفقرات 7 و11 و15 و28 من هذه الوثيقة. وعلاوة على ذلك، تطلب اللجنة من الدولة الطرف معلومات ذات صلة عن تنفيذ التوصيات التي قدمتها إليها بشأن قانون مكافحة الإرهاب المذكور في الفقرة 8 من هذه الوثيقة", "", "" },
                    { 39, null, "R34", "ت.34", "", "Réalisé", "", 100, 2, null, 2, null, 7, null, "Organes de traités", "Mettre à jour, si nécessaire, le document de base en date du 15 avril 2002 (HRI/CORE/1/Add.23/Rev.1 et Corr.1), conformément aux instructions relatives au document de base commun qui figurent dans les Directives harmonisées concernant l’établissement des rapports destinés aux organes créés en vertu d’instruments internationaux relatifs aux droits de l’homme (HRI/GEN/2/Rev.6).", "تحديث الوثيقة الأساسية المؤرخة في 15 أبريل 2002 (HRI/CORE/1/Add.23/Rev.1 وCorr.1)، وفق التعليمات المتعلقة بالوثيقة الأساسية الموحدة والواردة في المبادئ التوجيهية المنسقة المتعلقة بإعداد التقارير المقدمة بموجب الصكوك الدولية لحقوق الإنسان (HRI/GEN/2/Rev.6).", "", "" },
                    { 40, null, "R23P5", "ت.23.ف.5", "", "En cours", "", 30, 2, null, 2, null, 7, null, "Organes de traités", "Présenter dans le prochain rapport au Comité des informations sur les lois et les politiques en vigueur pour lutter contre les violences envers les femmes et rendre compte des effets des mesures prises.", "تقديم، معلومات عن القوانين والسياسات السارية لمكافحة أعمال العنف المرتكبة في حق المرأة في التقرير المقبل إلى اللجنة، وتقديم معلومات عن آثار التدابير المتخذة.", "", "" },
                    { 41, null, "R9P4P5", "ت.9.ف.4.ف.5", "", "En cours", "", 30, 2, null, 2, null, 7, null, "Organes de traités", "Respecter les obligations internationales et se conformer aux décisions finales et provisoires du Comité dans les cas individuels qui lui sont soumis en vertu de l’article 22 de la Convention. Dans le cas de M. Ktiti, le Maroc devrait décider d’annuler son extradition vers son pays d’origine, de manière définitive, sous peine de violer l’article 3 de la Convention", "احترام الالتزامات الدولية والامتثال للقرارات النهائية والقرارات المؤقتة التي تصدر عن اللجنة في القضايا الفردية المعروضة عليها بموجب المادة 22 من الاتفاقية. فيما يتعلق بقضية السيد كتيتي، ينبغي أن يصدر المغرب قراراً يقضي نهائياً بإلغاء تسليمه إلى بلده الأصلي، وإلا فإنّه سيُعدّ منتهكاً لأحكام المادة 3 من الاتفاقية.", "", "" },
                    { 42, null, "R17P3", "ت.17ف.3", "", "En cours", "", 30, 2, null, 2, null, 7, null, "Organes de traités", "-            Prendre toutes mesures correctives appropriées et informer le Comité de ses conclusions sur les aveux sous la contrainte mentionnés dans le paragraphe 17 des observations.", "-          اتخاذ جميع الإجراءات التصحيحية المناسبة وإبلاغ اللجنة بالنتائج التي تخلص إليها بخصوص القضايا المثارة حول التصريحات المنتزعة تحت التعذيب المشار إليها في الفقرة 17 من التوصيات", "", "" },
                    { 43, null, "R20P2", "ت.20.ف.2", "", "En cours", "", 30, 2, null, 2, null, 7, null, "Organes de traités", "Fournir au Comité des informations sur tout décès en détention résultant d’actes de torture, de mauvais traitements ou d’une négligence volontaire.", "تقديم معلومات إلى اللجنة عن كل حالة وفاة في الحجز نتيجة التعذيب وسوء المعاملة أو الإهمال المتعمد.", "", "" },
                    { 44, null, "R26P4", "ت.26.ف.4", "", "En cours", "", 30, 2, null, 2, null, 7, null, "Organes de traités", "-  Fournir dans le prochain rapport des informations détaillées sur les lieux de détention et les régimes de détention des étrangers en attente d’expulsion ainsi que des données ventilées par année, genre, lieu, durée de détention et raison justifiant la détention et l’expulsion.", "تضمين التقرير القادم معلومات مفصلة عن أماكن الاحتجاز وعن أنظمة حبس الأجانب في انتظار طردهم وبيانات مصنّفة حسب السنة ونوع الجنس ومكان ومدة الاحتجاز والسبب الذي يبرر الاحتجاز والطرد.", "", "" },
                    { 45, null, "R35", "ت.35", "", "En cours", "", 30, 2, null, 2, null, 7, null, "Organes de traités", @"Soumettre le prochain rapport périodique, qui sera le cinquième, le 25 novembre 2015 au plus tard. 
                Accepter, avant le 25 novembre 2012, de soumettre le rapport selon la procédure facultative qui consiste en la transmission par le Comité à l’État partie d’une liste de questions préalable au rapport périodique", "تقديم التقرير الدوري المقبل، وهو الخامس، في موعد لا يتجاوز 25 نونبر 2015 على أبعد تقدير. القبول، قبل 25 نونبر 2012، بتقديم التقرير طبقاً للإجراء الاختياري الذي يتمثل في إحالة اللجنة إلى الدولة الطرف مجموعة أسئلة تمهيداً للتقرير الدوري. وستشكل ردود الدولة الطرف على هذه المجموعة من الأسئلة التقرير الدوري المقبل للدولة الطرف بموجب المادة 19 من الاتفاقية.", "", "" },
                    { 91, null, "R52", "ت.52", "", "Réalisé", "", 100, 2, null, 3, null, 7, null, "Organes de traités", "Faire parvenir, dans un délai d’un an à compter de l’adoption des présentes observations finales, des renseignements sur la suite donnée aux recommandations faites par le Comité aux paragraphes 18 (lutte contre le terrorisme), 24 (interdiction de la torture et des mauvais traitements) et 42 (liberté d’association et activités des défenseurs des droits de l’homme)", "-          تقديم، معلومات عن تنفيذها التوصيات التي قدمتها اللجنة في الفقرات 18 (مكافحة الإرهاب)، و24 (حظر التعذيب وسوء المعاملة)، و42 (حرية تكوين الجمعيات وأنشطة المدافعين عن حقوق الإنسان) في غضون عام من اعتماد هذه الملاحظات الختامية، وذلك عملاً بالفقرة 5 من المادة 71 من النظام الداخلي للجنة،", "", "" },
                    { 92, null, "R53", "ت.53", "", "Non réalisé", "", 0, 2, null, 3, null, 7, null, "Organes de traités", @"Soumettre le prochain rapport périodique le 4 novembre 2020 au plus tard et y faire figurer des renseignements précis et à jour sur la mise en œuvre des recommandations faites dans les présentes observations finales et sur l’application du Pacte dans son ensemble.
                 
                Consulter largement la société civile et les organisations non gouvernementales présentes dans le pays aux fins de l’élaboration du rapport.
                 
                Accepter, G18d’ici le 4 novembre 2017, la procédure simplifiée d’établissement des rapports, qui consiste pour le Comité à transmettre une liste de points à l’État partie avant que celui-ci ne soumette le rapport périodique. Les réponses de l’État partie à cette liste constitueront dès lors le prochain rapport périodique devant être soumis conformément à l’article 40 du Pacte.", @"تقديم التقرير الدوري المقبل بحلول 4 تشرين الثاني/نوفمبر 2020 على أقصى تقدير، وتضمينه معلومات محددة ومحدثة عن تنفيذ التوصيات المقدمة في هذه الملاحظات الختامية وعن تنفيذ العهد ككل. 
                - إجراء مشاورات واسعة مع المجتمع المدني والمنظمات غير الحكومية العاملة في البلد عند إعداد التقرير.وفقاً لقرار الجمعية العامة 68/268، على ألا يتجاوز عدد كلماته 200 21 كلمة.‬‬
                - القبول، بحلول 4 تشرين الثاني/نوفمبر 2017، الإجراء المبسط لتقديم التقارير الذي يتمثل في إحالة اللجنة قائمة مسائل إلى الدولة الطرف قبل أن تقدم تقريرها الدوري. وهكذا، تكون ردود الدولة الطرف على قائمة المسائل هذه بمثابة التقرير الدوري المقبل الذي يقدم بموجب المادة 40 من العهد.", "", "" },
                    { 126, null, "R10P2", "ت.10.ف.2", "", "En cours", "", 30, 2, null, 4, null, 7, null, "Organes de traités", "-            Inclure, dans le prochain rapport périodique, des informations relatives aux décisions judiciaires ou administratives prises dans le sens de l’10 de l’ordre juridique interne avec le pacte.", "-          تضمين التقرير الدوري المقبل معلومات عن القرارات القضائية أو الإدارية المتخذة لتطبيق العهد في النظام القانوني الداخلي", "", "" },
                    { 127, null, "R52P1P2", "ت.52.ف.1.ف.2", "", "En cours", "", 30, 2, null, 4, null, 7, null, "Organes de traités", @"Encourager une collecte systématique de données et d’élaborer et d’utiliser des statistiques sur les indicateurs des droits de l’homme, dont les droits économiques, sociaux et culturels, fondées sur de telles données.
                - Faire figurer dans le prochain rapport périodique des données statistiques annuelles comparatives sur l’exercice de chaque droit énoncé dans le Pacte, ventilées par âge, sexe, population rurale/urbaine et autres critères pertinents, en prêtant une attention particulière à la situation des groupes défavorisés.", @"تشجع اللجنة المملكة المغربية على التجميع المنهجي للبيانات وإعداد إحصاءات تتعلق بمؤشرات حقوق الإنسان، بما في ذلك الحقوق الاقتصادية والاجتماعية والثقافية، واستخدام هذه الإحصاءات.
                - تضمين التقرير الدوري المقبل بيانات إحصائية سنوية مقارنة عن التمتع بكل حق يكفله العهد، تكون مصنفة بحسب السن والجنس وسكان المدن/الأرياف وأية معايير أخرى ذات صلة، مع إيلاء اهتمام خاص لوضع الفئات المحرومة.", "", "" },
                    { 128, null, "R53P1P2", "ت.53.ف.1.ف.2", "", "En cours", "", 30, 2, null, 4, null, 7, null, "Organes de traités", "Diffuser largement les présentes observations finales dans tous les secteurs de la société, en particulier auprès des agents de l’État, des autorités judiciaires, des parlementaires, des avocats et des organisations de la société civile, et de l’informer, dans le prochain rapport périodique, des mesures prises pour les mettre en œuvre.", "-          نشر هذه الملاحظات الختامية على نطاق واسع وعلى جميع صُعُد المجتمع، وبخاصة في أوساط الموظفين العموميين والسلطات القضائية والبرلمانيين والمحامين ومنظمات المجتمع المدني، وتبليغ اللجنة في التقرير الدوري المقبل بما تم اتخاذه من تدابير لتنفيذ هذه الملاحظات.", "", "" },
                    { 10, null, "R29", "ت.29", "", "Réalisé", "", 100, 2, null, 1, null, 7, null, "Organes de traités", "soumettre le dix-neuvième, vingtième et vingt-unième rapports périodiques en un seul document, attendu le 17 janvier 2013, qui tiendra compte des directives concernant l’élaboration des documents propres au Comité pour l’élimination de la discrimination raciale, adoptées par le Comité à sa soixante et onzième session (CERD/C/2007/1) et qui ne devrait pas dépasser 40 pages et traitera tous les points soulevés dans les présentes observations finales.", "تقديم الدولة الطرف التقارير الدورية المقبلة التاسع عشر والعشرين والحادي والعشرين في وثيقة واحدة، لا تتعدى 40 صفحة، في موعد أقصاه 17 كانون الثاني/يناير 2014، مع مراعاة المبادئ التوجيهية المتعلقة بإعداد الوثائق الخاصة بلجنة القضاء على التمييز العنصري، التي اعتمدتها اللجنة في دورتها الحادية والسبعين (CERD/C/2007/1)، على أن يتم تناول جميع النقاط المثارة في هذه الملاحظات الختامية في تلك الوثيقة.", "", "" },
                    { 328, null, "R27P1", "ت.27.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", @"Conformément à son observation générale no 1 (2014) sur la reconnaissance de la personnalité juridique dans des conditions d’égalité, le comité recommande au Maroc :
                a) D’abroger les dispositions du Code de la famille et d’autres textes de loi qui limitent la personnalité juridique des personnes handicapées, en particulier des personnes qui présentent un handicap psychosocial ou intellectuel", @"تماشياً مع التعليق العام رقم 1(2014) بشأن الاعتراف بالأشخاص ذوي الإعاقة على قدم المساواة مع الآخرين أمام القانون، توصي اللجنة بما يلي:‬
                -  (أ) إلغاء ما ورد في مدونة الأسرة وفي قوانين أخرى من أحكام تقيد الأهلية القانونية للأشخاص ذوي الإعاقة، ولا سيما الأشخاص ذوي الإعاقة النفسية - الاجتماعية و/أو العقلية؛", "", "" },
                    { 1030, null, "R144.34", "34.144", "", "Non réalisé", "", 0, 3, 1, null, 95, 9, null, "Examen périodique universal", "Adopter et appliquer une législation complète contre la discrimination", "اعتماد وتطبيق قانون شامل مناهض للتمييز", "", "" },
                    { 330, null, "R45P3", "ت.45.ف.3", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Modifier le Code de la famille afin de faire en sorte que les personnes présentant un handicap psychosocial ou intellectuel puissent exercer leur droit au mariage", "-       (ب)......وتعديل مدونة الأسرة لضمان تمتع الأشخاص ذوي الإعاقة النفسية - اجتماعية و/أو العقلية بالحق في الزواج.", "", "" },
                    { 451, null, "R79P5", "null", "", "Réalisé", "", 100, 4, null, null, null, 18, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les droits fonciers", "null", "", "" },
                    { 217, null, "R35", "ت.35", "", "En cours", "", 30, 3, null, 6, null, 19, null, "Organes de traités", "Veiller à la stricte application de l’âge minimum fixé dans le Code de la famille et modifier le Code afin que le mariage d’enfants ne puisse être autorisé que dans des conditions juridiques contraignantes, strictes et exceptionnelles.", "كفالة التنفيذ الدقيق للأحكام المتعلقة بالحد الأدنى لسن الزواج الواردة في مدونة الأسرة وتعديل مدونــة الأســرة لعدم التصــريح بزواج الأطفال إلا بشــروط قانونية إلزامية دقيقة استثنائيــة.", "", "" },
                    { 418, null, "R73", "null", "", "En cours", "", 30, 4, null, null, null, 19, 1, "Procédure spéciale", "-   Créer des conditions permettant aux agriculteurs d’adopter des pratiques agro écologiques et dispenser une formation sur les différentes méthodes de lutte contre les organismes nuisibles afin d’éviter l’utilisation excessive des pesticides synthétiques.", "null", "", "" },
                    { 419, null, "R76", "null", "", "En cours", "", 30, 4, null, null, null, 19, 1, "Procédure spéciale", "-   Promouvoir le maintien et la gestion de la biodiversité agricole afin de garantir une diversité génétique permettant de préserver les ressources naturelles nécessaires à la résilience des agriculteurs, à l’innovation agricole et à l’adaptation de l’agriculture aux changements climatiques.", "null", "", "" },
                    { 420, null, "R77", "null", "", "En cours", "", 30, 4, null, null, null, 19, 1, "Procédure spéciale", "-   Mieux appliquer les lois environnementales afin de protéger les bassins versants, les forêts et les rivières, qui sont les premières sources de nourriture. Mettre en place des mécanismes permettant de prévenir l’érosion des sols et les inondations et de renforcer la biodiversité.", "null", "", "" },
                    { 60, null, "R5P2", "ت.5.ف.2", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", "S’assurer que quiconque se rend coupable ou complice d’actes de torture, tente de commettre de tels actes ou participe à leur commission fasse l’objet d’une enquête, de poursuites et d’un châtiment sans pouvoir bénéficier d’un délai de prescription.", "خضوع كل من يرتكب أفعال تعذيب أو يتواطأ على ارتكابها أو يحاول اقترافها أو يشارك فيها للتحقيق والملاحقة والمعاقبة دون أن يتسنى له الاستفادة من أي أجل تقادم.", "", "" },
                    { 61, null, "R7P2", "ت.7.ف.2", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", "Prendre des mesures pour permettre l’accès à un avocat dès le début de la garde à vue, sans aucune autorisation préalable, et mettre en place un régime effectif d’aide juridictionnelle gratuite, en particulier pour les personnes se trouvant en situation de risque ou appartenant à des groupes en situation de vulnérabilité.", "-          اتخاذ خطوات لإتاحة الوصول إلى محام منذ بداية الحبس الاحتياطي دون إذن مسبق، وأن تنشئ نظاماً فعلياً للمساعدة القانونية المجانية، يستفيد منه بصفة خاصة الأشخاص المعرضون للخطر أو المنتمون إلى فئات ضعيفة.", "", "" },
                    { 62, null, "R7P3", "ت.7.ف.2", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", "Prendre des mesures pour permettre l’accès à un avocat dès le début de la garde à vue, sans aucune autorisation préalable, et mettre en place un régime effectif d’aide juridictionnelle gratuite, en particulier pour les personnes se trouvant en situation de risque ou appartenant à des groupes en situation de vulnérabilité.", "اتخاذ خطوات لإتاحة الوصول إلى محام منذ بداية الحبس الاحتياطي دون إذن مسبق، وأن تنشئ نظاماً فعلياً للمساعدة القانونية المجانية، يستفيد منه بصفة خاصة الأشخاص المعرضون للخطر أو المنتمون إلى فئات ضعيفة.", "", "" },
                    { 63, null, "R9P1P2P3", "ت.9.ف.1ف.2ف.3", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", @"N’expulse ,ne renvoyer ou n’extrader une personne vers un État où il y a des motifs sérieux de croire qu’elle risque d’être soumise à la torture.
                - Examiner minutieusement, sur le fond, chaque cas particulier, y compris la situation générale en matière de torture dans le pays de retour.
                - Etablir et mettre en œuvre des procédures bien définies pour obtenir des assurances diplomatiques, des mécanismes judiciaires appropriés de contrôle et des dispositifs efficaces de suivi en cas de refoulement.", @"الإحجام عن طرد أو إبعاد أو تسليم أي شخص باتجاه دولة توجد بشأنها أسباب وجيهة تدعو إلى الاعتقاد بأن الشخص قد يتعرض فيها للتعذيب. 
                - البحث في كل حالة على حدة بحثاً دقيقاً من حيث الأسس الموضوعية، بما في ذلك الحالة العامة المتعلقة بالتعذيب في البلد الذي يُعاد إليه الشخص المعني.
                - وضع وتنفيذ إجراءات محددة جيداً للحصول على هذه الضمانات الدبلوماسية وإنشاء الآليات القضائية المناسبة للرصد، وآليات فعالة للمتابعة في حالات الإبعاد.", "", "" },
                    { 64, null, "R10", "ت.10", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", "Prendre immédiatement des mesures concrètes pour enquêter sur les actes de torture, et poursuivre et punir leurs auteurs. -Garantir que les membres des forces de l’ordre n’utilisent pas la torture, notamment en réaffirmant clairement l’interdiction absolue de la torture, en condamnant publiquement la pratique de la torture, en particulier par la police, le personnel pénitentiaire et les membres de la DST, et en faisant clairement savoir que quiconque commet de tels actes, s’en rend complice ou y participe en sera tenu personnellement responsable devant la loi, fera l’objet de poursuites pénales et se verra infliger des peines appropriées", @"اتخاذ خطوات ملموسة للتحقيق في أعمال التعذيب وملاحقة مرتكبيه ومعاقبتهم. 
                - ضمان ألا يمارس أفراد الشرطة التعذيب، وخاصة بالتوكيد مجدّداً وبوضوح على الحظر المطلق للتعذيب وعبر الإدانة العلنية لممارسة التعذيب لا سيما من جانب الشرطة وموظفي السجون وأفراد مديرية مراقبة التراب الوطني، وعبر الإعلان الواضح عن أن كل من يرتكب مثل هذه الأعمال ويتواطأ فيها أو يشارك فيها سيُحمّل مسؤولية شخصية على ذلك أمام القانون وسيكون عرضة للملاحقة الجنائية، وسينال العقوبات المناسبة.", "", "" },
                    { 65, null, "R11", "ت.11", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", @"Faire en sorte qu’aucun individu placé sous le contrôle de l’Etat à un moment donné ne fasse l’objet de tels «transfèrements secrets». Le transfèrement, le refoulement, la détention et l’interrogation des personnes dans de telles conditions constituent en eux-mêmes une violation de la Convention. 
                - Mener des investigations effectives et impartiales et, le cas échéant, faire toute la lumière sur les cas de «transfèrements secrets» dans lesquels il a pu jouer un rôle. Il devrait poursuivre et punir les auteurs de ces transfèrements.", @"كفالة عدم تعرض أي فرد وضع تحت سلطة الدولة في وقت مّا 'لعمليات ترحيل' ' المنفَّذة في سياق الحرب الدولية على الإرهاب. فترحيل وإبعاد واحتجاز واستجواب الأشخاص في مثل تلك الظروف أمور تمثل في حد ذاتها انتهاكاً للاتفاقية. 
                - إجراء تحقيقات فعالة ونزيهة وتسليط الضوء، عند الضرورة، على 'عمليات الترحيل السري' التي قد لعبت فيها دوراً وإحالة منفذي عمليات الإبعاد إلى القضاء ومعاقبتهم", "", "" },
                    { 66, null, "R13P2", "ت.13.ف.2", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", "-            Renforcer les mesures prises pour que des enquêtes approfondies, impartiales et efficaces soient menées rapidement sur les violences et les décès survenus à l’occasion du démantèlement du camp de GdeimIzik, et que les responsables soient traduits en justice.", "-          تعزيز التدابير المتخذة من أجل إجراء تحقيقات مسهبة ونزيهة وفعالة على وجه السرعة في أعمال العنف وفي حالات الوفيات التي وقعت أثناء تفكيك مخيم اكديم الزيك، وتقديم المسؤولين عن هذه الأفعال إلى العدالة.", "", "" },
                    { 67, null, "R15", "ت.15", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", @"Garantir que toute personne arrêtée et détenue bénéficie des procédures judiciaires en vigueur et que les garanties fondamentales consacrées par le droit positif soient respectées : par exemple, l’accès du détenu à un avocat et à un médecin indépendant, son droit à ce que les membres de sa famille soient informés de son arrestation et de son lieu de détention, et sa présentation devant un juge. 
                - Prendre des mesures en vue de garantir que les registres, les procès-verbaux et tous les documents officiels relatifs à l’arrestation et à la détention des personnes soient tenus avec la plus grande rigueur et que tous les éléments se rapportant à l’arrestation et à la détention y soient consignés et attestés à la fois par les officiers de police judiciaire et par la personne concernée. 
                - S’assurer que des enquêtes approfondies, impartiales et efficaces soient menées rapidement sur toutes les allégations d’arrestation et de détention arbitraires et les responsables éventuels traduits en justice. 
                - Faire en sorte que nul ne soit gardé dans un centre de détention secret placé de facto sous son contrôle effectif et ouvrir une enquête impartiale et efficace sur l’existence de tels lieux de détention. Tous les lieux de détention devraient être soumis à un système régulier de contrôle et de surveillance", @"كفالة استفادة كل شخص معتقل ومحتجز من الإجراءات القانونية السارية وكفالة الضمانات الأساسية المكرسة في القانون الوضعي: ومن الأمثلة على ذلك: السماح للمعتقل بالوصول إلى محام وإلى طبيب مستقل، ومنحه الحق في إخطار أسرته باعتقاله وبمكان احتجازه ومثوله أمام قاض. 
                - اتخاذ تدابير لضمان مسك السجلات والمحاضر وجميع الوثائق الرسمية المتعلقة باعتقال واحتجاز الأشخاص وفق أكبر قدر من الصرامة، وأن تدون فيها جميع العناصر المتصلة بالاعتقال والاحتجاز وأن يشهد عليها كل من ضباط الشرطة القضائية والشخص المعني.
                -  التأكد من إجراء تحقيقات مسهبة ونزيهة وفعالة على وجه السرعة بشأن جميع المزاعم المتعلقة بحالات الاعتقال والاحتجاز التعسفية وأن تتم إحالة من يحتمل مسؤوليتهم عنها إلى العدالة.
                - كفالة ألا يُحتفظ بأي شخص في مركز احتجاز سري خاضع لسيطرة الدولة الفعلية بحكم الواقع. وكما أكدته اللجنة مراراً، يعد احتجاز أشخاص في ظل هذه الظروف انتهاكاً للاتفاقية. 
                - فتح تحقيق نزيه وفعال بشأن مدى وجود مراكز احتجاز من هذا القبيل. ويجب أن تخضع كل أماكن الاحتجاز السرية للرصد والمراقبة على نحو منتظم", "", "" },
                    { 68, null, "R16P1P3", "ت.16.ف.1.ف.3", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", @"Faire en sorte que toutes les allégations de torture et de mauvais traitements fassent rapidement l’objet d’une enquête efficace et impartiale et que les auteurs soient poursuivis et condamnés à des peines proportionnées à la gravité de leurs actes, comme le requiert l’article 4 de la Convention. 
                - Veiller à ce que, dans la pratique, les plaignants et les témoins soient protégés contre tout mauvais traitement et tout acte d’intimidation liés à leur plainte ou à leur témoignage.", @"إجراء تحقيق فعال ونزيه بشأن جميع مزاعم التعذيب وإساءة المعاملة، وملاحقة مرتكبيها قضائياً وإدانتهم بأحكام تتناسب مع جسامة أفعالهم، وفقاً لما تنص عليه المادة 4 من الاتفاقية
                - الحرص على حماية المشتكين والشهود من أي سوء معاملة ومن أي ترهيب بسبب شكواهم أو شهادتهم", "", "" },
                    { 69, null, "R17P1P2", "ت.17ف.1.ف.2", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", @"Prendre toutes mesures nécessaires pour garantir que les condamnations pénales soient prononcées sur la foi de preuves autres que les aveux de l’inculpé, notamment lorsque l’inculpé revient sur ses aveux durant le procès, et que les déclarations faites sous la torture ne soient pas invoquées comme éléments de preuve au cours de la procédure, si ce n’est contre la personne accusée de torture, conformément aux dispositions de la Convention.
                - Examiner les condamnations pénales prononcées exclusivement sur la foi d’aveux afin d’identifier dans quels cas la condamnation s’est fondée sur des aveux obtenus sous la torture ou par des mauvais traitements", @"اتخاذ التدابير اللازمة لضمان استناد الإدانات الجنائية إلى أدلة أخرى غير اعترافات المتهم، خاصة حينما يتراجع المهم عن اعترافاته أثناء المحاكمة، وألا يعتد بالتصريحات المنتزعة تحت التعذيب كدليل يمكن استخدامه أثناء الإجراءات، إلا إذا كانت هذه الإجراءات ضد الشخص المتهم بارتكاب التعذيب، وذلك وفقاً لأحكام الاتفاقية.
                - مراجعة الإدانات الجنائية الصادرة بالاستناد إلى الاعترافات فقط، حتى يتسنى تحديد الحالات التي استندت فيها الإدانة إلى اعترافات منتزعة تحت التعذيب أو سوء المعاملة", "", "" },
                    { 70, null, "R20P1P3", "ت.20.ف.1.ف.3", "", "Réalisé", "", 100, 5, null, 2, null, 20, null, "Organes de traités", @"Enquêter rapidement et de manière approfondie et impartiale sur tous les décès en détention et poursuivre les personnes responsables, le cas échéant. 
                - Veiller à ce que les examens soient effectués par des médecins légistes indépendants, et accepter les conclusions de ces examens comme preuves dans les procédures pénales et civiles", @"إجراء تحقيقات عاجلة مسهبة ونزيهة في جميع حالات الوفيات في الحجز، وملاحقة المسؤولين عنها عند اللزوم. 
                - الحرص على أن يتم إجراء الفحوصات من قبل أطباء شرعيين مستقلين وأن تقبل نتائج تلك الفحوصات كدليل يعتد به في الإجراءات الجنائية والمدنية.", "", "" },
                    { 71, null, "R21P2P3P4", "ت.21.ف.2.ف.3.ف.4", "", "En cours", "", 30, 5, null, 2, null, 20, null, "Organes de traités", @"Poursuivre son moratoire de facto sur l’application des peines capitales, faire en sorte que sa législation prévoie la possibilité de commuer les condamnations à mort et 
                - Veiller à ce que tous les condamnés à mort bénéficient de la protection assurée par la Convention. 
                - Faire en sorte que ces derniers soient traités avec humanité, et qu’ils puissent, en particulier, bénéficier des visites de leur famille et de leurs avocats", @"الاستمرار في التوقف الفعلي عن تنفيذ عقوبة الإعدام
                - العمل على أن تتيح التشريعات إمكانية تخفيف أحكام الإعدام، وأن يستفيد جميع المحكوم عليهم بالإعدام من الحماية التي توفرها الاتفاقية. 
                -كفالة معاملة هؤلاء المحكوم عليهم بالإعدام معاملة إنسانية، وبخاصة إتاحة الفرصة أمامهم لتلقي زيارات عائلاتهم ومحاميهم.", "", "" },
                    { 72, null, "R22P3P4", "ت.22.ف.3.ف.4", "", "En cours", "", 30, 5, null, 2, null, 20, null, "Organes de traités", @"Faire en sorte que des médecins légistes formés à la détection des signes de torture soient présents pendant ces visites. 
                - S’assurer que les patients détenus dans ces institutions contre leur gré soient en mesure de faire appel de la décision d’internement et d’avoir accès à un médecin de leur choix", @"كفالة أن يحضر زيارات أماكن الاحتجاز بما فيها المستشفيات أطباء شرعيون مدربون على كشف علامات التعذيب. 
                - تمكين المرضى المعتقلين في تلك المؤسسات بدون إرادتهم من إمكانية طلب استئناف قرار الاعتقال وإمكانية الاتصال بطبيب من اختيارهم", "", "" },
                    { 73, null, "R18P3", "ت.18.ف.3", "", "En cours", "", 30, 5, null, 2, null, 20, null, "Organes de traités", "-            Faire en sorte que des médecins légistes formés à la détection des signes de torture soient présents pendant les visites périodiques et inopinées des observateurs nationaux et internationaux, prévues par le mécanisme national de contrôle des lieux de détention", "-          العمل على حضور الزيارات لأماكن الاحتجاز من قبل أطباء شرعيين مدربين على كشف علامات التعذيب.", "", "" },
                    { 105, null, "R20P1", "ت.20.ف.1", "", "En cours", "", 30, 4, null, 3, null, 20, null, "Organes de traités", "- Poursuivre le débat national en cours relatif à l’abolition de la peine de mort et envisager d’officialiser le moratoire de fait observé actuellement. Il devrait par ailleurs", "مواصلة المناقشة الوطنية الحالية بشأن إلغاء عقوبة الإعدام والنظر في إضفاء طابع رسمي على الوقف الاختياري الفعلي المعمول به حالياً.", "", "" },
                    { 106, null, "R24P1P2P3P4", "ت.24.ف.1.ف.2.ف.3.ف.4", "", "En cours", "", 30, 4, null, 3, null, 20, null, "Organes de traités", @"a) Prendre des mesures fortes pour éradiquer la torture et les traitements cruels, inhumains ou dégradants et pour enquêter efficacement, poursuivre et punir ces actes ; 
                b) Procéder sans délai à des expertises médicales pour toutes les allégations de torture et de mauvais traitements ; 
                c) Veiller à l’application effective, dans la pratique, de l’interdiction des aveux forcés et de l’irrecevabilité des éléments de preuve entachés de torture ; 
                d) Offrir des recours utiles et garantir réparation aux victimes ;", @"(أ) اتخاذ تدابير صارمة لاستئصال التعذيب والمعاملة القاسية أو اللاإنسانية أو المهينة، وللتحقيق بفعالية في هذه الأعمال وملاحقة مرتكبيها ومعاقبتهم؛ 
                - (ب) إجراء فحوص طبية فورية في جميع ادعاءات التعذيب وسوء المعاملة؛ 
                - (ج) والحرص على التطبيق الفعال، في الواقع، لحظر الاعترافات القسرية وعدم قبول الأدلة المشوبة بالتعذيب؛ 
                - (د) وتوفير سبل انتصاف فعالة ومنح تعويضات للضحايا؛ 
                - (ه) وتسريع عملية اعتماد القانون المنشئ للآلية الوطنية لمنع التعذيب.", "", "" },
                    { 107, null, "R28", "ت.28", "", "En cours", "", 30, 4, null, 3, null, 20, null, "Organes de traités", "Poursuivre et accélérer ses efforts pour élucider tous les cas de disparition forcée, y compris ceux liés au Sahara occidental, et procéder sans délai à des enquêtes en vue d’identifier, juger et punir les responsables de disparitions forcées.", "-          مواصلة تكثيف الجهود لتجلية جميع حالات الاختفاء القسري، بما فيها تلك المتصلة بالصحراء الغربية، والتعجيل بالتحقيق فيها لتحديد هوية الجناة ومحاكمتهم ومعاقبتهم.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 182, null, "R28P1P2P3", "ت.28.ف1.ف.2.ف3.", "", "Réalisé", "", 100, 5, null, 5, null, 20, null, "Organes de traités", @"prendre des mesures et intensifier les efforts visant à remédier d’urgence aux problèmes des mauvais traitements et autres actes de violence commis contre les travailleurs migrants et les membres de leur famille, quels que soient les auteurs de ces actes. En particulier, le Comité recommande de prendre les mesures suivantes :
                a) Veiller à ce que les travailleurs migrants et les membres de leur famille aient accès à des mécanismes de plaintes indépendants, ainsi qu’à des services de conseils légaux et à des interprètes ;
                b) Veiller à ce que tout acte de torture ou traitement cruel, inhumain ou dégradant, ainsi que toute atteinte à la vie des travailleurs migrants fassent l’objet d’enquêtes et d’investigations; 
                c) Veiller à ce que les responsables soient jugés et condamnés de façon appropriée", @"اتخاذ تدابير وتكثيف الجهود في سبيل الإسراع في معالجة مشاكل سوء المعاملة وغير ذلك من أعمال العنف المرتكبة في حق العمال المهاجرين وأفراد أسرهم، أياً كان مرتكبوها. وعلى وجه الخصوص، اتخاذ التدابير التالية: 
                (أ) ضمان وصول العمال المهاجرين وأفراد أسرهم إلى آليات تظلم مستقلة وإلى خدمات مشورة قانونية ومترجمين فوريين؛
                 (ب) ضمان إجراء تحريات وتحقيقات في كل فعل من أفعال التعذيب أو المعاملة القاسية أو اللاإنسانية أو المهينة وكل اعتداء على حياة العمال المهاجرين؛
                (ج) ضمان محاكمة المسؤولين عن تلك الأفعال وإدانتهم على النحو السليم؛", "", "" },
                    { 183, null, "R34", "ت.34", "", "En cours", "", 30, 5, null, 5, null, 20, null, "Organes de traités", @"Prendre des mesures adéquates pour mettre un terme aux abus et aux violations dont sont victimes les travailleurs migrants et les membres de leur famille. 
                - Créer un mécanisme de surveillance des activités des autorités marocaines chargées des procédures de migration ou impliquées dans ces procédures afin de garantir que les abus et les violations commis à l’encontre de travailleurs migrants et des membres de leur famille, tels que la confiscation et la destruction de leurs documents d’identité, fassent l’objet d’une enquête et que les responsables soient poursuivis et sanctionnés, conformément à l’article 21 de la Convention", "اتخاذ تدابير مناسبة لوضع حدٍ للتجاوزات والانتهاكات التي يتعرض لها العمال المهاجرون وأفراد أسرهم. وعلى وجه الخصوص، إنشاء آلية لمراقبة أنشطة السلطات المغربية المعنية بإجراءات الهجرة أو المشاركة في هذه الإجراءات بغية ضمان التحقيق في التجاوزات والانتهاكات المرتكبة في حق العمال المهاجرين وأفراد أسرهم مثل مصادرة وثائق هويتهم وإتلافها، وضمان مقاضاة المسؤولين عن تلك الأفعال ومعاقبتهم، وفقاً للمادة 21 من الاتفاقية.", "", "" },
                    { 280, null, "R35 P1", "ت.35.ف.1", "", "En cours", "", 30, 5, null, 7, null, 20, null, "Organes de traités", @"Enquêter sur tous les cas de torture et de mauvais traitements et poursuive les auteurs, en veillant à ce que l’enfant maltraité ne soit pas stigmatisé dans le cadre des procédures judiciaires et à ce que sa vie privée soit protégée. 
                - Equiper toutes les structures d’accueil et les centres de détention pour enfants de caméras de surveillance à même de détecter toute maltraitance et mettre à la disposition des enfants des mécanismes de recours accessibles et sûrs. Tous les auteurs de sévices devraient être tenus responsables et sévèrement punis
                .", @"التحقيق في حالات إساءة المعاملة ومقاضاة مقترفيها، و الحرص على عدم وقوع الطفل المساء إليه ضحيةً في الإجراءات القانونية وعلى حماية خصوصيته
                - تجهيز كل مؤسسات استقبال/مراكز احتجاز الأطفال بآلات التصوير لكشف أي اعتداء عليهم، وتوفير آليات تظلّم ميسّرة ومأمونة للأطفال. وينبغي مساءلة جميع الجناة ومعاقبتهم عقاباً شديداً.", "", "" },
                    { 281, null, "R37P1P4", "ت.37.ف.1.ف.4", "", "En cours", "", 30, 5, null, 7, null, 20, null, "Organes de traités", @"Renvoyant à son Observation générale no 8 (2006) relative aux droits de l’enfant et à une protection contre les châtiments corporels et les autres formes cruelles ou dégradantes de châtiment, le Comité invite le Maroc à:
                a) Interdire sans équivoque les châtiments corporels dans tous les contextes;
                 d) Assurer la participation de l’ensemble de la société, y compris les enfants, à la conception et à la mise en œuvre de stratégies de prévention des châtiments corporels", @"في ضوء تعليق اللجنة العام رقم 8(2006) بشأن حق الطفل في الحماية من العقوبة البدنية وغيرها من ضروب العقوبة القاسية أو المهينة، تحث اللجنة الدولة المملكة المغربية على ما يلي: 
                - (أ) حظر العقوبة البدنية في جميع الأماك�� صراحةً؛
                -  (د) تهيئة سبل انخراط ومشاركة المجتمع ككل، بما فيه الأطفال، في وضع وتنفيذ استراتيجيات تقي الأطفال العقوبة البدنية.", "", "" },
                    { 282, null, "R41P1P2", "ت.41.ف.1.ف.2", "", "En cours", "", 30, 5, null, 7, null, 20, null, "Organes de traités", @"Prendre toutes les mesures requises pour faire en sorte que les filles qui avaient été forcées à épouser la personne qui a abusé d’elles avant l’abrogation de l’article 475 du Code pénal reçoivent l’aide dont elles ont besoin pour échapper à des situations dans lesquelles elles sont victimes d’abus.
                - Faire en sorte que tous les enfants soumis à une quelconque forme d’exploitation et d’abus sexuels soient traités en tant que victimes et ne fassent jamais l’objet de sanctions pénales", @"اتخاذ جميع التدابير التي تؤمّن للفتيات اللائي أكرهن على الزواج ممن اعتدوا عليهن قبل إلغاء المادة 475 من القانون الجنائي الدعم اللازم ليخلصن من الحالات التعسفية. 
                - ضمان معاملة جميع الأطفال المعرضين لأي شكل من أشكال الاستغلال والاعتداء الجنسيين معاملة الضحايا وألا يعرضوا أبداً لعقوبات جنائية", "", "" },
                    { 154, null, "R44", "ت.44", "", "En cours", "", 30, 4, null, 4, null, 18, null, "Organes de traités", @"a) prendre des mesures concrètes pour veiller à ce que les ressources allouées aux programmes de logement soient uniformément et équitablement réparties entre les différentes régions et entre les zones rurales urbaines ;
                - b) renforcer les activités d’amélioration des conditions de vie pour offrir un logement abordable à la population, notamment à ceux qui vivent dans les zones rurales ainsi que dans les bidonvilles urbains et ruraux. Veiller également à ce que les projets de relogement comportent également un volet d’appui aux personnes les plus démunies ;
                - c) résoudre la question des sans-abri en leur offrant un logement et de s’assurer que les victimes d’expulsions forcées bénéficient d’un relogement ou d’une indemnisation adéquate.
                le Comité renvoie  à son observation générale no 7 (1997) sur le droit à un logement suffisant : expulsions forcées et à son observation générale no 4 (1991) sur le droit à un logement suffisant.", @"(أ) اتخاذ تدابير ملموسة لضمان توزيع الموارد المخصصة لبرامج الإسكان توزيعاً متساوياً وعادلاً بين مختلف المناطق وبين المناطق الحضرية والمناطق الريفية؛
                - (ب) تعزيز الأنشطة الرامية إلى تحسين الظروف المعيشية من أجل توفير مساكن ميسورة التكلفة للسكان، ولا سيما لسكان المناطق الريفية وسكان أحياء الصفيح في المدن والأرياف. وتوصيها كذلك بالحرص على إدراج شق يتعلق بتقديم الدعم للسكان الأشد عوزاً في مشاريع إعادة الإسكان؛
                - (ج) إيجاد حل لمشكلة المشردين بتوفير السكن لهم وضمان إعادة إسكان ضحايا الإخلاء القسري أو تقديم تعويضات كافية لهم.
                في هذا الصدد، تحيل اللجنة الدولة الطرف إلى تعليقها العام رقم 7(1997) بشأن الحق في السكن الملائم: حالات إخلاء المساكن بالإكراه، وتعليقها العام رقم 4(1991) بشأن الحق في السكن الملائم.", "", "" },
                    { 216, null, "R29P4", "ت.29.ف.4", "", "Réalisé", "", 100, 3, null, 6, null, 17, null, "Organes de traités", "Promulguer rapidement la législation voulue pour réglementer l’emploi des travailleuses domestiques", "سن تشريعات مناسبة لتنظيم عمل النساء العاملات بالخدمة المنزلية", "", "" },
                    { 1099, null, "R144.157", "157.144", "", "En cours", "", 30, 4, 1, null, 29, 16, null, "Examen périodique universal", "Continuer de renforcer la promotion des droits environnementaux par leur incorporation dans les plans de développement social et économique pour l’ensemble du Royaume", "الاستمرار في تعزيز الحقوق البيئية وذلك بإدراجها في خطط التنمية الاجتماعية والاقتصادية في جميع أنحاء المملكة", "", "" },
                    { 1098, null, "R144.84", "84.144", "", "En cours", "", 30, 4, 1, null, 46, 16, null, "Examen périodique universal", "Renforcer l’intégration des droits environnementaux dans l’élaboration et la mise en œuvre des stratégies de développement", "زيادة تعميم مراعاة الحقوق البيئية في وضع الاستراتيجيات الإنمائية وتنفيذها", "", "" },
                    { 1087, null, "R144.180", "180.144", "", "Réalisé", "", 100, 4, 1, null, 29, 14, null, "Examen périodique universal", "Promouvoir des programmes qui encouragent l’éducation des enfants, notamment des filles dans les villages, et bénéficient aux groupes vulnérables", "النهوض بالبرامج التي تشجع تعليم الأطفال وخاصة الفتيات في القرى ولصالح الفئات الهشة", "", "" },
                    { 22, null, "R11P2", "·          ت.11.ف.2", "", "En cours", "", 30, 4, null, 1, null, 15, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que des amazighs ne soient victimes d’aucune forme de discrimination raciale, notamment dans l’accès à l’emploi", "اتخاذ التدابير اللازمة لضمان عدم تعرض الأمازيغ لأي شكل من أشكال التمييز العنصري، لا سيما في التوظيف", "", "" },
                    { 150, null, "R18P3", "ت.18.ف.3", "", "En cours", "", 30, 4, null, 4, null, 15, null, "Organes de traités", @"Tenant compte de son observation générale no 16 (2005) sur le droit égal de l’homme et de la femme au bénéfice de tous les droits économiques, sociaux et culturels, le Comité recommande de :

                - c) - Identifier les obstacles rencontrés par les femmes dans l’emploi et la vie professionnelle et prendre des mesures appropriées, y compris des mesures ciblées, pour la conciliation de la vie familiale avec le monde du travail, qui permettent d’augmenter le taux de participation des femmes. 
                Continuer à œuvrer pour atteindre un pourcentage acceptable de postes bien rémunérés et à responsabilités occupés par les femmes en adoptant des mesures temporaires spéciales le cas échéant.", @"في ضوء تعليقها العام رقم 16(2005) بشأن المساواة بين الرجل والمرأة في حق التمتع بجميع الحقوق الاقتصادية والاجتماعية والثقافية، توصي اللجنة بما يلي:
                - (ج) - تحديد العقبات التي تواجهها المرأة في العمل وفي الحياة المهنية، واتخاذ تدابير مناسبة للتوفيق بين الحياة الأسرية والعمل، تشمل تدابير محددة الأهداف تتيح زيادة المشاركة النسائية. 
                   - مواصلة العمل من أجل بلوغ نسبة مئوية مقبولة من النساء في مناصب المسؤولية ذات الدخل المرتفع، وذلك من خلال اعتماد التدابير الخاصة المؤقتة عند الاقتضاء.", "", "" },
                    { 151, null, "R20", "ت.20", "", "En cours", "", 30, 4, null, 4, null, 15, null, "Organes de traités", @"Prendre les mesures nécessaires pour garantir, en droit comme en pratique, des recours efficaces et accessibles pour la protection du droit du travail. 
                - créer des tribunaux spécialisés en matière de contentieux du travail", @"اتخاذ التدابير اللازمة لكي تضمن، في القانون وفي الممارسة العملية،
                - توفر سبل انتصاف فعالة وميسرة من أجل حماية قانون العمل. وتشجعها على إنشاء محاكم متخصصة في منازعات العمل.", "", "" },
                    { 152, null, "R22", "ت.22", "", "En cours", "", 30, 4, null, 4, null, 15, null, "Organes de traités", "Redoubler d’efforts pour réduire sensiblement le taux de chômage en ciblant les femmes et les jeunes, y compris par des programmes de requalification et de formation professionnelle et technique, en plus des mesures incitatives pour les employeurs. le comité invite le Maroc  à se reporter à son observation générale no 18 (2005) sur le droit au travail.", "مضاعفة جهودها من أجل خفض معدل البطالة بنسبة كبيرة من خلال استهداف النساء والشباب، بوسائل منها وضع برامج لإعادة التأهيل والتدريب المهني والتقني بالإضافة إلى وضع تدابير تحفيزية لأرباب العمل. وفي هذا F84الصدد، تدعو اللجنة F84 إلى الرجوع إلى تعليقها العام رقم 18(2005) بشأن الحق في العمل.", "", "" },
                    { 153, null, "R28", "ت.28", "", "En cours", "", 30, 4, null, 4, null, 15, null, "Organes de traités", @"Renforcer les efforts pour réguler l’économie informelle et le travail indépendant, notamment en intégrant ces travailleurs dans les régimes de sécurité sociale et en améliorant progressivement leurs conditions de travail.
                -  Etendre de façon systématique les services de l’inspection du travail au secteur informel et aux zones rurales, et s’attaquer plus fermement aux obstacles à la création d’emplois dans l’économie formelle.
                À cet égard, le comité encourage le gouvernement marocain à s’inspirer de la recommandation de 2015 de l’Organisation internationale du Travail sur la transition de l’économie informelle vers l’économie formelle (no 204).", @"تعزيز الجهود من أجل تنظيم الاقتصاد غير النظامي والعمل المستقل بوسائل منها إدماج هؤلاء العمال في أنظمة الضمان الاجتماعي والعمل على تحسين ظروف عملهم تدريجياً. 
                - توسيع نطاق خدمات تفتيش العمل بصورة منهجية لتشمل القطاع غير النظامي والمناطق الريفية، وبالتصدي بحزم أكبر للعقبات التي تحول دون توفير فرص العمل في الاقتصاد النظامي. 
                وفي هذا الصدد، تشجع الدولة الطرف على استلهام توصية منظمة العمل الدولية لعام 2015 بشأن الانتقال من الاقتصاد غير النظامي إلى الاقتصاد النظامي (التوصية رقم 204).", "", "" },
                    { 181, null, "R44", "ت.44", "", "En cours", "", 30, 4, null, 5, null, 15, null, "Organes de traités", @"Prendre les mesures nécessaires pour assurer la réinsertion des Marocains qui sont revenus dans l’État partie. 
                - Prendre, conformément à l’article 67 de la Convention, des mesures effectives à l’égard des Marocains expulsés du territoire algérien. 
                - Fournir des informations sur ce sujet dans le prochain rapport périodique. 
                - Fournir des informations sur les efforts de coopération internationale menés en application de l’article 64 de la Convention", @"اتخاذ التدابير اللازمة لضمان إعادة إدماج المغاربة العائدين إلى البلد. 
                وفقاً للمادة 67 من الاتفاقية، اتخاذ تدابير فعالة لفائدة المغاربة المطرودين من الأراضي الجزائرية. 
                تضمين التقرير الدوري المُقبل معلومات عن هذا الموضوع. 
                تقديم معلومات عن جهود التعاون الدولي المبذولة طبقاً للمادة 64 من الاتفاقية.", "", "" },
                    { 228, null, "R29P1P2P3P5", "ت.29.ف.1ف.2ف.3.ف.5", "", "En cours", "", 30, 4, null, 6, null, 15, null, "Organes de traités", @"Considérer comme prioritaire la réalisation de l’égalité de facto avec les hommes sur le marché de l’emploi, afin d’appliquer intégralement l’article 11 de la Convention. 
                - Renforcer les mesures d’inspection pour assurer une meilleure application de la législation du travail 
                - prendre des mesures volontaristes pour éliminer la ségrégation par profession, tant horizontale que verticale, et combler l’écart salarial entre hommes et femmes
                - Adopter une politique d’emploi soucieuse de l’égalité entre les sexes pour réglementer le travail des femmes dans le secteur informel et améliorer leur accès aux emplois dans le secteur formel.", @"إيلاء الأولوية لتحقيق المساواة الفعلية بين المرأة والرجل في سوق العمل بحيث يتم الامتثال التام للمادة 11 من الاتفاقية. 
                -تعزيز تدابير التفتيش المتصلة بالعمال لكفالة تنفيذ أفضل لمدونة الشغل،
                 -اتخاذ تدابير استباقية للقضاء على العزل المهني عموديا وأفقيا وتضييق بل وسد الفجوة في الأجور بين النساء والرجال. 
                -اعتماد سياسات تصل بالعمالة لتنظيم عمل النساء في القطاع غير النظامي وتعزيز وصولهن إلى سوق العمل النظامي.", "", "" },
                    { 229, null, "R21P6", "ت.21.ف.6", "", "En cours", "", 30, 4, null, 6, null, 15, null, "Organes de traités", "-       adopter des mesures de protection des employées de maison", "- توفير الحماية للمشتغلات بالخدمة في المنازل", "", "" },
                    { 230, null, "R27P4", "ت.27.ف.4", "", "En cours", "", 30, 4, null, 6, null, 15, null, "Organes de traités", "-       Accorder une attention particulière aux jeunes filles employées de maison, afin de s’assurer qu’il ne s’agit pas de mineures de moins de 15 ans et qu’elles ont pu poursuivre leur scolarité au moins jusqu’à cet âge", "-إيلاء عناية خاصة إلى الفتيات اللاتي يعملن بالخدمة في المنازل لكفالة منع من كن دون سن الخامسة عشرة من العمل للسماح لهن بمواصلة الدراسة حتى هذه السن على الأقل.", "", "" },
                    { 339, null, "R51", "ت.51", "", "En cours", "", 30, 4, null, 8, null, 15, null, "Organes de traités", @"a) Adopter un plan à long terme pour garantir l’accès des personnes handicapées au marché du travail général et de définir des objectifs et des mesures spécifiques concernant l’accès à l’emploi des femmes et des jeunes handicapés. Dans le cadre de ces mesures, l’État partie devrait notamment prévoir la mise en place de partenariats public-privé avec les coopératives et le secteur privé afin d’accroître l’employabilité des personnes handicapées ; 
                b) Instaurer l’obligation juridique, pour les employeurs dans tous les secteurs de l’économie, de procéder à des aménagements raisonnables sur le lieu de travail des personnes handicapées ; 
                c) Ne plus utiliser des listes de postes réservés aux personnes handicapées et de veiller à ce que ces dernières bénéficient d’une formation et aient accès à tous les types d’emploi sur un pied d’égalité avec les autres ; 
                d) Tenir compte des liens entre l’article 27 de la Convention et la cible 8.5 des objectifs de développement durable afin de garantir l’avènement d’un plein emploi productif et de conditions de travail décentes pour tous, y compris les personnes handicapées.", @"(أ) اعتماد خطة طويلة الأجل لضمان وصول الأشخاص ذوي الإعاقة إلى سوق العمل المفتوحة، ووضع أهداف وتدابير محددة بشأن حصول النساء والشباب ذوي الإعاقة على فرص عمل. وينبغي للدولة الطرف أن تُضمِّن تلك التدابير إقامة شراكات بين القطاعين العام والخاص والتعاونيات والقطاع الخاص من أجل زيادة إمكانية تشغيل الأشخاص ذوي الإعاقة؛ 
                -  (ب) إرساء التزام قانوني بأن يوفر أرباب العمل في جميع قطاعات الاقتصاد الترتيبات التيسيرية المعقولة للأشخاص ذوي الإعاقة في مكان العمل؛ 
                -  (ج) وقف استخدام قوائم الوظائف المخصصة للأشخاص ذوي الإعاقة فقط، وضمان تدريب وتمكين الأشخاص ذوي الإعاقة ليزاولوا جميع أنواع العمل على قدم المساواة مع الآخرين؛ 
                -  (د) إيلاء الاهتمام للصلات القائمة بين المادة 27 من الاتفاقية والغاية 8-5 من أهداف التنمية المستدامة، وذلك بغرض تحقيق العمالة الكاملة والمنتجة وتوفير العمل اللائق للجميع، بمن في ذلك الأشخاص ذوو الإعاقة. ‬‬‬‬", "", "" },
                    { 416, null, "R91", "null", "", "En cours", "", 30, 4, null, null, null, 15, 1, "Procédure spéciale", @"Redoubler d’efforts pour réduire sensiblement le taux de chômage en ciblant les femmes et les jeunes, 
                - Accroître le nombre de programmes de requalification et de 41 et technique, 
                - Adopter des mesures visant à inciter les employeurs à créer des emplois et à recruter des femmes et des jeunes selon qu’il convient.", "null", "", "" },
                    { 417, null, "R95P2P4", "null", "", "En cours", "", 30, 4, null, null, null, 15, 1, "Procédure spéciale", @"Pour les provinces marocaines du sud :
                - Etablir des mécanismes visant à réduire sensiblement le taux de chômage
                - Adopter des mesures qui incitent les employeurs à recruter des jeunes sans aucune discrimination.", "null", "", "" },
                    { 283, null, "R69P2", "ت.69.ف.2", "", "En cours", "", 30, 5, null, 7, null, 20, null, "Organes de traités", "L’État partie devrait également prendre des mesures pour mettre fin à l’impunité de ceux qui se livrent à la traite des enfants.", "متابعة الملاحظات الختامية والتوصيات التي سبق أن قدمتها اللجنة بشأن البروتوكول الاختياري لاتفاقية حقوق الطفل بشأن بيع الأطفال واستغلال الأطفال في البغاء وفي المواد الإباحية", "", "" },
                    { 450, null, "R79P3", "null", "", "Réalisé", "", 100, 4, null, null, null, 15, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès à l’emploi", "null", "", "" },
                    { 1089, null, "R144.152", "152.144", "", "En cours", "", 30, 4, 1, null, 11, 15, null, "Examen périodique universal", "Poursuivre ses efforts louables pour réduire le taux de chômage élevé qui prévaut dans le pays", "مواصلة عمله الجيد على الحد من معدل البطالة المرتفع في البلد", "", "" },
                    { 1090, null, "R144.154", "154.144", "", "Réalisé", "", 100, 4, 1, null, 47, 15, null, "Examen périodique universal", "Renforcer les lois favorisant la réduction des taux de chômage et accroître les possibilités d’emploi  afin de contribuer à la réalisation d’un développement durable", "تجديد القوانين الرامية إلى الحد من معدلات البطالة وزيادة فرص العمل للمساهمة في تحقيق التنمية المستدامة", "", "" },
                    { 1091, null, "R144.155", "155.144", "", "Réalisé", "", 100, 4, 1, null, 55, 15, null, "Examen périodique universal", "Poursuivre ses efforts pour réduire le taux de chômage chez les jeunes, notamment par le renforcement des programmes de formation professionnelle", "مواصلة الجهود لأجل الحد من معدلات البطالة في صفوف الشباب بوسائل منها تقوية برامج التدريب المهني", "", "" },
                    { 1092, null, "R144.156", "156.144", "", "En cours", "", 30, 4, 1, null, 69, 15, null, "Examen périodique universal", "Établir des dialogues visant à engager une coopération qui permettra l’application de pratiques optimales et de plans visant à réduire le chômage, le sous-emploi et le travail informel, et renforcer les politiques de création d’emplois et d’emploi  des jeunes", "إقامة حوارات للانخراط في التعاون الذي سيتيح تطبيق الممارسات والخطط الفضلى للحد من البطالة وقلة فرص العمل والعمل في القطاع غير النظامي، وتقوية السياسات الرامية إلى إنشاء فرص العمل وإلى عمالة الشباب", "", "" },
                    { 1093, null, "R144.158", "158.144", "", "Réalisé", "", 100, 4, 1, null, 85, 15, null, "Examen périodique universal", "Continuer à mettre en œuvre des politiques et à développer des infrastructures permettant d’accroître l’accès à l’emploi , en particulier pour les jeunes", "مواصلة تنفيذ السياسات وتطوير الهياكل الأساسية التي تزيد من الفرص في الحصول على العمل خاصةً في صفوف الشباب", "", "" },
                    { 23, null, "R11P6", "·          ت.11.ف.6", "", "En cours", "", 30, 4, null, 1, null, 16, null, "Organes de traités", "Mettre un accent particulier sur le développement des régions habitées par les amazighs, et ce dans le cadre de la Commission consultative de Régionalisation", "تنمية المناطق التي يسكنها الأمازيغ وذلك في إطار اللجنة الاستشارية للهيكلة الإقليمية.", "", "" },
                    { 340, null, "R53P2", "ت.53.ف.2", "", "En cours", "", 30, 4, null, 8, null, 16, null, "Organes de traités", "b) Tenir compte des liens entre l’article 28 de la Convention et la cible 10.2 des objectifs de développement durable afin d’autonomiser toutes les personnes et de favoriser leur intégration économique, indépendamment du handicap.", "-       (ب) إيلاء الاهتمام للصلات القائمة بين المادة 28 من الاتفاقية والغاية 10-2 من أهداف التنمية المستدامة، بهدف تمكين وتعزيز الإدماج الاجتماعي والاقتصادي والسياسي للجميع، بغض النظر عن الإعاقة.", "", "" },
                    { 566, null, "R93P3", "null", "", "En cours", "", 30, 4, null, null, null, 16, 5, "Procédure spéciale", "Revoir l’Initiative nationale pour le développement humain afin de faire en sorte qu’elle tienne compte des questions de parité entre les sexes et mette à profit le rôle plus actif des femmes à tous les niveaux (national, régional et local) et à toutes les étapes (conception, exécution et évaluation)", "null", "", "" },
                    { 640, null, "R73P2", "null", "", "Réalisé", "", 100, 4, null, null, null, 16, 8, "Procédure spéciale", @"Élaborer une politique générale nationale sur le développement humain qui tienne compte des droits de l’homme et se fonde sur les normes internationales en la matière, notamment l’égalité et la non-discrimination. 
                - Intégrer dans tous les programmes et politiques de développement de tous les secteurs une démarche tenant compte de la problématique hommes-femmes.
                - Dans le cadre d’une approche du développement fondée sur les droits de l’homme, la planification et la mise en œuvre de mesures de développement doivent être mûrement réfléchies, ciblées et progressives afin d’instaurer des conditions favorables à l’exercice et à la réalisation des droits de l’homme", "null", "", "" },
                    { 1094, null, "R144.82", "82.144", "", "En cours", "", 30, 4, 1, null, 5, 16, null, "Examen périodique universal", "Continuer à élaborer et à mettre en œuvre des programmes de développement et à améliorer les capacités économiques dans l’ensemble du pays, y compris dans les provinces du sud du Maroc", "مواصلة وضع وتنفيذ برامج إنمائية، وتحسين القدرات الاقتصادية للبلد ككل بما فيه الأقاليم الجنوبية للمغرب", "", "" },
                    { 1095, null, "R 144.153", "153.144", "", "En cours", "", 30, 4, 1, null, 19, 16, null, "Examen périodique universal", "Continuer à promouvoir le développement économique et social afin de relever le niveau de vie de la population régulièrement, dans le but de fournir une base solide à la jouissance de tous les droits de l’homme", "مواصلة تشجيع التنمية الاقتصادية والاجتماعية من أجل الرفع المطّرد من مستويات معيشة السكان وذلك لتزويدهم بأساس متين للتمتع بجميع حقوق الإنسان", "", "" },
                    { 1096, null, "R144.81", "81.144", "", "En cours", "", 30, 4, 1, null, 66, 16, null, "Examen périodique universal", "Poursuivre les efforts visant à réaliser les objectifs stratégiques nationaux pour le développement durable (2015-2020)", "مواصلة الجهود من أجل تحقيق الأهداف الوطنية الاستراتيجية للتنمية المستدامة (2015-‑2020)", "", "" },
                    { 1097, null, "R144.83", "83.144", "", "En cours", "", 30, 4, 1, null, 25, 16, null, "Examen périodique universal", "Accélérer la mise en œuvre de la politique nationale sur les changements climatiques", "تسريع تنفيذ السياسة الوطنية المتعلقة بتغير المناخ", "", "" },
                    { 1088, null, "R144.142", "142.144", "", "En cours", "", 30, 4, 1, null, 5, 15, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir et protéger les droits économiques et sociaux au moyen de stratégies de développement encourageant l’investissement et l’emploi", "مواصلة الجهود من أجل تعزيز وحماية الحقوق الاقتصادية والاجتماعية عن طريق تنفيذ استراتيجية إنمائية لتشجيع الاستثمار والعمالة", "", "" },
                    { 341, null, "R33P1P3", "ت.33.ف.1.ف.3", "", "En cours", "", 30, 5, null, 8, null, 20, null, "Organes de traités", @"Légiférer et de prendre des mesures concrètes sur le plan administratif pour protéger les personnes handicapées, en particulier les femmes qui présentent un handicap intellectuel ou psychosocial, contre la torture et autres peines ou traitements cruels, inhumains ou dégradants.
                - Prendre des mesures concrètes pour garantir que, dans la pratique, les personnes handicapées ne soient pas soumises à des procédures et à des expérimentations médicales sans y avoir consenti librement et en connaissance de cause", @"(أ) اعتماد أحكام قانونية وتدابير إدارية ملموسة لحماية الأشخاص ذوي الإعاقة، ولا سيما النساء ذوات الإعاقة العقلية و/أو النفسية - الاجتماعية، من التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة،    
                -  (ب) اعتماد تدابير ملموسة تضمن، في الممارسة العملية، عدم إخضاع الأشخاص ذوي الإعاقة لإجراءات وتجارب طبية من دون موافقتهم الحرة والمستنيرة؛", "", "" },
                    { 452, null, "R75", "null", "", "En cours", "", 30, 5, null, null, null, 20, 2, "Procédure spéciale", "-       Prendre des mesures concrètes pour renforcer le principe de responsabilité pour tous les actes de discrimination raciale et de xénophobie, en veillant à ce que les allégations de tels actes fassent l’objet d’enquêtes approfondies et, s’il y a lieu, de poursuites et de sanctions, même dans les cas où les violations des droits ne résultent pas directement d’une politique ou de mesures délibérées du Gouvernement.", "null", "", "" },
                    { 494, null, "R88P6", "ت.88.ف.6", "", "En cours", "", 30, 5, null, null, null, 20, 3, "Procédure spéciale", "-    diligenter des enquêtes impartiales et approfondies sur toutes les allégations de torture et de traitements cruels, inhumains ou dégradants, sans qu’il soit nécessaire qu’une plainte soit déposée par écrit, conformément à l’article 13 de la Convention contre la torture; de mettre en place des procédures pour enquêter d’office sur tout cas de torture et de mauvais traitements quelle que soit la manière dont il est invoqué, même lorsque les victimes n’utilisent pas les procédures prescrites par la loi pour soumettre leur plainte", "-          (و) التعجيل بإجراء تحقيقات فورية ونزيهة وشاملة في جميع ادعاءات التعذيب وغيره من أشكال المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة، دون الحاجة إلى شكوى خطية، عملاً بالمادة 13 من اتفاقية مناهضة التعذيب؛ ووضع إجراءات للتحقيق، بحكم الوظيفة، في أي قضية تعذيب أو سوء معاملة تثار بأي وسيلة من الوسائل، حتى عندما لا يقدم الضحايا شكاوى بالطرق القانونية؛", "", "" },
                    { 342, null, "R33P2", "ت.33.ف.2", "", "En cours", "", 30, 5, null, 8, null, 22, null, "Organes de traités", "Prendre des mesures pour soutenir les victimes de tels actes en leur offrant une assistance juridique et un accompagnement psychologique et en veillant à ce que des mesures d’indemnisation et de réparation soient ordonnées en leur faveur", "-          (أ) اعتماد أحكام قانونية وتدابير إدارية ملموسة لحماية الأشخاص ذوي الإعاقة، ولا سيما النساء ذوات الإعاقة العقلية و/أو النفسية - الاجتماعية، من التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة، واعتماد تدابير ترمي إلى دعم هؤلاء الضحايا من خلال إسداء النصح القانوني والمشورة لهم وتعويضهم وجبر ضررهم؛", "", "" },
                    { 505, null, "R95P4", "ت.95.ف.4", "", "En cours", "", 30, 5, null, null, null, 22, 3, "Procédure spéciale", "Faire en sorte que les victimes obtiennent une réparation et une indemnisation équitable et suffisante, y compris les moyens d’une réadaptation aussi complète que possible ;                        Etablir des mécanismes et des programmes, notamment les structures requises au sein du Ministère de la santé, pour fournir à toutes les victimes des services de réadaptation, et de financer les services privés médicaux, juridiques et autres, y compris ceux administrés par des organisations non gouvernementales, prestataires de services médicaux, psychologiques et de réadaptation sociale", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:  (ج) اتباع الإدارات المعنية بالصحة في السجون لوزارة الصحة، الأمر الذي يُفترض أن يسهم في تقديم خدمات طبية فائقة الجودة؛ ...استحداث آليات وبرامج، مثل البنى التحتية المناسبة داخل وزارة الصحة، وإعادة تأهيل الضحايا، وتمويل المرافق الطبية والقانونية وغيرها، مثل تلك التي تديرها المنظمات غير الحكومية، التي تقدم خدمات إعادة التأهيل الطبي والنفسي والاجتماعي؛", "", "" },
                    { 506, null, "R95P5", "ت.95.ف.5", "", "En cours", "", 30, 5, null, null, null, 22, 3, "Procédure spéciale", "-    Envisager un financement bilatéral direct des organisations de la société civile qui apportent un soutien aux victimes et aux membres de leur famille, et de mettre en place des services spécialisés au sein du système de santé national. Le Fonds de contributions volontaires des Nations Unies pour les victimes de la torture est invité à examiner les demandes d’aide émanant d’ONG œuvrant pour assurer aux personnes qui ont été torturées l’accès à des soins médicaux et à des recours judiciaires.", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي: ... (ﻫ) النظر في التمويل الثنائي المباشر لمنظمات المجتمع المدني التي تساعد الضحايا وأسرهم، واستحداث إدارات متخصصة داخل النظام الصحي الوطني. ويُدعى صندوق الأمم المتحدة للتبرعات لضحايا التعذيب إلى النظر في طلبات المساعدة المقدمة من المنظمات غير الحكومية العاملة في مجال مساعدة ضحايا التعذيب على الحصول على الخدمات الطبية والانتصاف القانوني.", "", "" },
                    { 184, null, "R42", "ت.42", "", "En cours", "", 30, 5, null, 5, null, 23, null, "Organes de traités", "Prendre des mesures pour assurer l’exercice du droit de vote à tous les travailleurs migrants marocains qui vivent à l’étranger.", "اتخاذ تدابير لضمان حق التصويت لجميع العمال المهاجرين المغاربة المقيمين في الخارج.", "", "" },
                    { 231, null, "R25P1P2", "ت.25.ف.1.ف.2", "", "En cours", "", 30, 5, null, 6, null, 23, null, "Organes de traités", @"Prendre des dispositions législatives efficaces et s’inscrivant dans la durée pour accroître la représentation des femmes à tous les niveaux de la vie politique, y compris des mesures temporaires spéciales, en application du paragraphe 1 de l’article 4 de la Convention. 
                - Instituer des quotas pour les candidates aux élections municipales de 2009 et adopter des mesures temporaires spéciales qui permettent d’accroître la représentation des femmes aux postes de prise de décisions dans tous les domaines d’activité", @"اتخاذ التدابير القانونية الفعالة والمستدامة لزيادة التمثيل السياسي للمرأة على جميع المستويات، بما في ذلك اتخاذ تدابير استثنائية مؤقتة وفقا للفقرة 1 من المادة 4 من الاتفاقية، بدلا من الاعتماد على تعهدات أخلاقية تقطعها الأحزاب السياسية لخدمة أهداف بعينها. 
                تخصيص حصص قانونية للمرأة في الانتخابات البلدية لعام 2009 واعتماد تدابير استثنائية مؤقتة لزيادة نسبة تمثيل المرأة في مناصب اتخاذ القرار في جميع الأوساط", "", "" },
                    { 232, null, "R33P3", "ت.33.ف.3", "", "En cours", "", 30, 5, null, 6, null, 23, null, "Organes de traités", "Le comité recommande au Maroc de prendre des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention, pour s’assurer que les femmes rurales jouissent de leurs droits politiques, sociaux, économiques et culturels sans aucune discrimination. Il recommande aussi que les femmes participent pleinement à la formulation et à l’exécution de toutes les politiques et de tous les programmes sectoriels.", "إدماج تدابير خاصة مؤقتة، على النحو المنصوص عليه في الفقرة 1 من المادة 4 من الاتفاقية، لكفالة تمتع المرأة الريفية بحقوقها السياسية والاجتماعية والاقتصادية والثقافية دونما تمييز إدماجا تاما في عملية صوغ وتنفيذ جميع السياسات والبرامج في شتى القطاعات.", "", "" },
                    { 343, null, "R9P3", "ت.9.ف.3", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", "- Associer toutes les personnes handicapées à l’élaboration des politiques publiques et des plans d’action qu’il entend mettre en œuvre dans le domaine du handicap pour s’acquitter des obligations mises à sa charge par le paragraphe 1 c) de l’article 4 et de supprimer toute distinction entre les personnes handicapées titulaires d’une carte d’invalidité et les autres.", "-       (ب) شمول جميع الأشخاص ذوي الإعاقة في عملية وضع السياسات العامة وخطط العمل في مجال الإعاقة الرامية إلى تنفيذ التزاماتها بموجب المادة ٤(1)(ج) وإلغاء أي تمييز بين الأشخاص ذوي الإعاقة الذين يحملون بطاقة الإعاقة ومن لا يحملونها.", "", "" },
                    { 344, null, "R11", "ت.11", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", @"Le Comité recommande à l’État partie : 
                a) D’instituer des mécanismes permettant d’assurer la participation et la consultation effectives et constructives des personnes handicapées, par l’intermédiaire des organisations qui les représentent et de façon régulière, et d’allouer des ressources budgétaires suffisantes de façon à encourager la participation constructive des personnes handicapées ; 
                b) D’encourager et de soutenir la participation des organisations de femmes, d’enfants et de jeunes handicapés et de personnes présentant un handicap intellectuel ou psychosocial, d’élaborer des mécanismes de consultation à l’intention des personnes présentant un handicap intellectuel et de diffuser des informations au sujet de ces mécanismes dans des formats qui soient accessibles à ces personnes.", @"توصي اللجنة المملكة المغربية بما يلي:
                (أ) إنشاء آليات لضمان إشراك ومشاورة الأشخاص ذوي الإعاقة بشكل فعلي ومجد ومنتظم، من خلال المنظمات التي تمثلهم، وضمان توفير موارد كافية في الميزانية من أجل تعزيز مشاركتهم مشاركة مجدية؛
                -  (ب) تشجيع ودعم مشاركة المنظمات التي تمثل النساء والأطفال والشباب من ذوي الإعاقة والأشخاص ذوي الإعاقة العقلية و/أو النفسية - الاجتماعية، ووضع آليات لإجراء عمليات التشاور وتوفير المعلومات عنها في أشكال يسهل الاطلاع عليها للأشخاص ذوي الإعاقة العقلية", "", "" },
                    { 345, null, "R23P1P3", "ت.23.ف.1.ف.3", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", @"Le Comité recommande à l’État partie, conformément à son observation générale no 2 (2014) concernant l’accessibilité : 
                a) De concevoir un plan stratégique visant à assurer l’accessibilité des technologies de l’information et des communications, dans lequel il établira des directives concernant la passation de marchés de biens et de services, et d’associer les personnes handicapées et les organisations qui les représentent à ce processus ; 
                c) De tenir compte des liens entre l’article 9 de la Convention et les cibles 11.2 et 11.7 des objectifs de développement durable, afin d’assurer l’accès de tous à des systèmes de transport sûrs, accessibles et viables, à un coût abordable, notamment en développant les transports publics, une attention particulière devant être accordée aux personnes handicapées, et d’assurer l’accès de tous, en particulier des personnes handicapées, à des espaces verts et à des espaces publics sûrs, inclusifs et accessibles.", @"(أ) وضع خطة استراتيجية لتوفير تكنولوجيا معلومات واتصالات يمكن الوصول إليها، وتحدد فيها المبادئ التوجيهية لشراء السلع والخدمات، وضمان إشراك الأشخاص ذوي الإعاقة والمنظمات التي تمثلهم في هذه العملية؛
                -  (ج) إيلاء اهتمام للصلات القائمة بين المادة 9 من الاتفاقية والغايتين 11-2 و11-7 من أهداف التنمية المستدامة، من أجل إتاحة استفادة الجميع من نظم نقل آمن وفي المتناول وميس�� ومستدام، ولا سيما من خلال توسيع شبكة النقل العام، مع إيلاء اهتمام خاص لاحتياجات الأشخاص ذوي الإعاقة وتعميم الوصول إلى المساحات العامة الآمنة والشاملة والميسرة والخضراء، وبخاصة للأشخاص ذوي الإعاقة.", "", "" },
                    { 346, null, "R39P4", "ت.39.ف.4", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", "Adopter des mesures aux niveaux national et local pour garantir l’accessibilité des services et des équipements sociaux pour toutes les personnes handicapées dans tous les domaines de la vie", "(د)  اعتماد تدابير على الصعيدين الوطني والمحلي لضمان إمكانية وصول الأشخاص ذوي الإعاقة كافة إلى الخدمات والمرافق المجتمعية في جميع مجالات الحياة", "", "" },
                    { 347, null, "R55", "ت.55", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", "Adopter un plan pour garantir l’accessibilité des lieux de vote, notamment par la fourniture de matériel de vote et d’informations électorales dans des formats accessibles à toutes les personnes handicapées, et d’assurer une formation adéquate aux membres du personnel électoral sur les droits des personnes handicapées à toutes les étapes du processus électoral.", "-      اعتماد خطة لضمان إمكانية الوصول إلى مكان الاقتراع، بما في ذلك من خلال توفير المواد الانتخابية والمعلومات في أشكال يسهل الاطلاع عليها لجميع الأشخاص ذوي الإعاقة، وتوفير التدريب الملائم لموظفي الانتخابات بشأن حقوق الأشخاص ذوي الإعاقة في جميع مراحل العملية الانتخابية.", "", "" },
                    { 348, null, "R61", "ت.61", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", "Adopter des mesures visant à assurer la participation effective et l’inclusion et la consultation des personnes handicapées et des organisations qui les représentent dans le cadre des programmes de coopération internationale.", "-      اعتماد تدابير تضمن إشراك واحتواء ومشاورة الأشخاص ذوي الإعاقة والمنظمات التي تمثلهم، فعلياً، في سياق برامج التعاون الدولي.", "", "" },
                    { 349, null, "R63P4", "ت.63.ف.4", "", "En cours", "", 30, 5, null, 8, null, 23, null, "Organes de traités", "Assurer la participation permanente des personnes handicapées, par l’intermédiaire de leurs organisations représentatives, au processus de suivi de la mise œuvre de la Convention, notamment en fournissant les fonds nécessaires.", "-       (د) ضمان المشاركة الدائمة للأشخاص ذوي الإعاقة، من خلال المنظمات التي تمثلهم، في عملية رصد الاتفاقية، بما في ذلك عن طريق توفير التمويل اللازم.", "", "" },
                    { 75, null, "R29P1P2", "ت.29.ف.1.ف.2.", "", "En cours", "", 30, 5, null, 2, null, 22, null, "Organes de traités", @"S’assurer que le Conseil national des droits de l’homme, qui a été désigné pour finaliser les travaux de l’IER, continue de s’efforcer d’élucider les cas de disparitions forcées intervenues entre 1956 et 1999 restés non élucidés, y compris les cas liés au Sahara occidental.
                -            Intensifier les efforts pour assurer aux victimes de torture et de mauvais traitements une réparation sous la forme d’une indemnisation équitable et suffisante et d’une réadaptation aussi complète que possible.", @"التأكد من استمرار المجلس الوطني لحقوق الإنسان، الذي أنيطت به مهمة استكمال أعمال هيئة الإنصاف والمصالحة، في بذل الجهد لتوضيح ملابسات حالات الاختفاء القسري التي وقعت بين عامي 1956 و1999 والتي لم توضح بعد، بما في ذلك القضايا المتعلقة بالصحراء الغربية. 
                - تكثيف الجهود لإنصاف ضحايا التعذيب وسوء المعاملة في شكل تعويض منصف وكاف وإعادة تأهيلهم على أكمل وجه ممكن.", "", "" },
                    { 421, null, "R80", "null", "", "En cours", "", 30, 5, null, null, null, 23, 1, "Procédure spéciale", "-   Renforcer la participation des femmes à l’examen des questions relatives au droit à l’alimentation, en particulier au niveau de la prise de décisions. Il faudrait prévoir la pleine participation des femmes vivant dans des zones reculées à la vie politique.", "null", "", "" },
                    { 453, null, "R79P6", "null", "", "Réalisé", "", 100, 5, null, null, null, 24, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les libertés d’opinion et d’expression", "null", "", "" },
                    { 1111, null, "R144.114P1", "114.144.ج.1", "", "En cours", "", 30, 5, 1, null, 36, 24, null, "Examen périodique universal", "Garantir pleinement les libertés d’expression et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية التعبير ضماناً تاماً واتخاذ جميع التدابير الضرورية بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" },
                    { 1112, null, "R144.115", "115.144", "", "Réalisé", "", 100, 5, 1, null, 74, 24, null, "Examen périodique universal", "Poursuivre les travaux visant à renforcer la liberté d’expression par l’application de la loi portant création du Conseil national de la presse", "مواصلة العمل على تعزيز حرية التعبير عن طريق تنفيذ القانون المنشئ للمجلس الوطني للصحافة", "", "" },
                    { 1113, null, "R144.244", "244.144", "", "Réalisé", "", 100, 5, 1, null, 48, 24, null, "Examen périodique universal", "Élaborer et appliquer des mesures indépendantes et crédibles qui garantissent le plein respect des droits de l’homme au Sahara occidental, notamment la liberté d’expression et de réunion", "وضع وتنفيذ تدابير مستقلة وموثوقة لضمان الاحترام الكامل لحقوق الإنسان في الصحراء الغربية بما فيها حرية التعبير والتجمع", "", "" },
                    { 109, null, "R42", "ت.42", "", "Réalisé", "", 100, 5, null, 3, null, 25, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour mettre un terme aux violations de la liberté d’association et aux pratiques ayant pour effet de restreindre ce droit au-delà des restrictions strictes permises par le paragraphe 2 de l’article 22 du Pacte. 
                - Veiller à ce que les défenseurs des droits de l’homme puissent opérer libres de toute influence indue de l’État partie et sans craindre de représailles ou de restrictions injustifiées de leurs activités.", @"التعجيل باتخاذ التدابير اللازمة لوضع حد لانتهاكات حرية تكوين الجمعيات وللممارسات التي تقيّد هذا الحق تقييداً يتجاوز القيود الصارمة التي تبيحها الفقرة 2 من المادة 22 من العهد. 
                - تمكين المدافعين عن حقوق الإنسان من العمل بمنأى عن أي تأثير من الدولة لا مبرر له ودون خوف من الانتقام أو تقييد أنشطتهم دون مبرر.", "", "" },
                    { 110, null, "R46", "ت.46", "", "Réalisé", "", 100, 5, null, 3, null, 25, null, "Organes de traités", @"s’assurer que la loi relative aux manifestations pacifiques est appliquée conformément aux dispositions du Pacte et que l’exercice de ce droit ne fait pas l’objet de restrictions autres que celles autorisées en vertu du Pacte.
                -  Prendre en considération les propositions formulées en novembre 2015 par le Conseil national des droits de l’homme au sujet des rassemblements publics.", @"التأكد من أن القانون المتعلق بالمظاهرات السلمية ينفذ وفقاً لأحكام العهد، وألا تقيَّد ممارسة هذا الحق إلا بالقيود التي يجيزها العهد. 
                - الأخذ في الحسبان المقترحات التي قدمها المجلس الوطني لحقوق الإنسان في تشرين الثاني/نوفمبر 2015 بشأن التجمعات العامة.", "", "" },
                    { 454, null, "R79P7", "null", "", "Réalisé", "", 100, 5, null, null, null, 25, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne les libertés de réunion pacifique et d’association", "null", "", "" },
                    { 624, null, "R86P5", "ت.86.ف.5", "", "En cours", "", 30, 5, null, null, null, 25, 7, "Procédure spéciale", "Revoir ses pratiques en matière d’enregistrement des associations afin d’assurer le respect intégral du droit à la liberté d’association, sans aucune discrimination", "(ﻫ) استعراض الممارسات المتصلة بتسجيل الجمعيات من أجل ضمان الاحترام التام للحق في حرية تكوين الجمعيات، دون أي تمييز؛", "", "" },
                    { 1114, null, "R144.114P2", "114.144.ج.2", "", "Réalisé", "", 100, 5, 1, null, 36, 25, null, "Examen périodique universal", "Garantir pleinement les libertés d’association et prendre toutes les mesures nécessaires pour veiller à ce que les défenseurs des droits de l’homme puissent s’acquitter de leur mission", "ضمان حرية تكوين الجمعيات ضماناً تاماً بغية كفالة تمكين المدافعين عن حقوق الإنسان من أداء مهماتهم", "", "" },
                    { 1115, null, "R144.121", "121.144", "", "Réalisé", "", 100, 5, 1, null, 89, 25, null, "Examen périodique universal", "Lever les obstacles à l’enregistrement des associations non gouvernementales auprès des autorités", "إزالة العوائق التي تمنع الجمعيات غير الحكومية من التماس تسجيلها من قِبل السلطات", "", "" },
                    { 1116, null, "R144.122", "122.144", "", "En cours", "", 30, 5, 1, null, 34, 25, null, "Examen périodique universal", "Approuver les demandes de licence pour toutes les associations non gouvernementales demandant l’enregistrement conformément à la loi, y compris les organisations qui défendent les membres des populations minoritaires", "الموافقة على طلبات الترخيص لجميع الجمعيات غير الحكومية التي تلتمس التسجيل وفقاً للقانون، بما فيها الجمعيات التي تدافع عن أفراد الأقليات من السكان", "", "" },
                    { 1117, null, "R144.58P1", "58.144. ج.1", "", "Réalisé", "", 100, 5, 1, null, 48, 25, null, "Examen périodique universal", "Veiller à établir des procédures régissant l’enregistrement des organisations de la société civile", "ضمان وضع إجراءات تحكم تسجيل منظمات المجتمع المدني ......", "", "" },
                    { 1118, null, "R144.61P1", "61.144. ج.1", "", "Réalisé", "", 100, 5, 1, null, 65, 25, null, "Examen périodique universal", "Veiller à ce que les procédures régissant l’enregistrement des organisations de la société civile, soient conformes aux normes internationales", "ضمان أن تكون الآليات التي تنظم تسجيل منظمات المجتمع المدني..... متوافقة مع المعايير الدولية", "", "" },
                    { 350, null, "R43P1", "ت.43.ف.1", "", "Non réalisé", "", 0, 5, null, 8, null, 24, null, "Organes de traités", "- a) Adopter des mesures concrètes afin de créer une langue des signes marocaine unifiée qui sera reconnue comme langue officielle des personnes sourdes et enseignée dans les écoles, de constituer un vivier d’interprètes en langue des signes qualifiés et d’enseignants formés à la traduction en format tactile, en braille et en langue facile (Easy Read) et de veiller à ce que les chaînes de télévision diffusent le journal télévisé et des programmes dans des formats accessibles, en particulier pour les personnes sourdes ou malentendantes ;", "-       (أ) اعتماد تدابير محددة لوضع لغة إشارة مغربية موحدة تحظى بالاعتراف بوصفها لغة رسمية للصم وتُدرس في المدارس، وتكوين مجموعة من مترجمي ومدرسي لغة الإشارة المؤهلين والمدربين على استخدام وسائل الاتصال عن طريق اللمس، ومهارات ترجمة النصوص إلى أشكال يسهل الاطلاع عليها وباستخدام طريقة برايل، وضمان تقديم الأخبار والبرامج بالأشكال الميسرة في المحطات التلفزيونية، ولا سيما للصم وضعاف السمع؛", "", "" },
                    { 1086, null, "R144.179", "179.144", "", "Réalisé", "", 100, 4, 1, null, 13, 14, null, "Examen périodique universal", "Examiner et, le cas échéant, adapter les programmes scolaires et préscolaires et l’enseignement et les pratiques scolaires pour favoriser l’élimination de la discrimination fondée sur le sexe et des stéréotypes sexistes, ainsi que pour promouvoir l’autonomisation des filles à un âge précoce", "استعراض المناهج التعليمية وتكييفها عند الضرورة، وكذلك استعراض ممارسات التدريس والمدارس من أجل القضاء على التمييز القائم على نوع الجنس والقوالب النمطية القائمة على نوع الجنس إلى جانب تعزيز تمكين الفتيات منذ سن مبكرة", "", "" },
                    { 1110, null, "R144.105", "105.144", "", "Réalisé", "", 100, 5, 1, null, 51, 21, null, "Examen périodique universal", "Continuer à améliorer les conditions de détention dans les établissements pénitentiaires, réduire la surpopulation et adopter des mesures de substitution à la détention provisoire, et fournir des soins médicaux appropriés aux détenus", "مواصلة تحسين الظروف في السجون والحد من الاكتظاظ واعتماد بدائل عن الاحتجاز قبل المحاكمة وتوفير الرعاية الطبية الكافية للسجناء", "", "" },
                    { 1108, null, "R144.102", "102.144", "", "Réalisé", "", 100, 5, 1, null, 75, 21, null, "Examen périodique universal", "Poursuivre les programmes socioéconomiques pour les détenus aux fins de leur réinsertion socioprofessionnelle à leur sortie de prison, en particulier en faveur des femmes et des jeunes", "مواصلة تنفيذ البرامج الاجتماعية والاقتصادية لصالح المساجين في إطار إعادة إدماجهم اجتماعياً ومهنياً بعد احتجازهم، ولا سيما لفائدة النساء والشباب", "", "" },
                    { 495, null, "R88P10", "ت.88.ف.10", "", "Non réalisé", "", 0, 5, null, null, null, 20, 3, "Procédure spéciale", "Engager des procédures judiciaires au sujet de tous les cas de violations commises par le passé pendant les «années de plomb» (1956-1999) révélées par l’Instance équité et réconciliation", "-          (ي) رفع دعاوى قضائية بشأن جميع الحالات التي كشفت عنها هيئة الإنصاف والمصالحة والمتعلقة بانتهاكات 'سنوات الرّصاص' (1956-1999)؛", "", "" },
                    { 496, null, "R89", "ت.89", "", "Réalisé", "", 100, 5, null, null, null, 20, 3, "Procédure spéciale", "En ce qui concerne les manifestations, le Rapporteur spécial recommande au Gouvernement de se conformer aux normes internationales, telles que les «Principes de base relatifs au recours à la force et l’utilisation des armes à feu par les responsables de l’application des lois», qui, s’agissant du respect de la vie et de l’intégrité physique, sont fondées sur les principes de nécessité et de proportionnalité; et de promouvoir encore plus la prévention des actes de torture ou des mauvais traitements dont sont victimes les manifestants, les enquêtes sur ces actes et les poursuites engagées contre leurs auteurs.", "-          يوصي المقرر الخاص الحكومة بأن تتصرف وفق المعايير الدولية، مثل 'المبادئ الأساسية بشأن استخدام القوة والأسلحة النارية من جانب الموظفين المكلفين بإنفاذ القوانين‏'، التي تقوم على مبدأي الضرورة والتناسب المتعلقين بالحق في الحياة والسلامة الجسدية، إضافة إلى منع تعذيب المحتجين أو إساءة معاملتهم، والتحقيق في هاتين الممارستين.", "", "" },
                    { 497, null, "R96", "ت.96", "", "Réalisé", "", 100, 5, null, null, null, 20, 3, "Procédure spéciale", "-    Agir pour prévenir les représailles, y compris sous la forme d’actes d’intimidation, de mesures disciplinaires et de mauvais traitements, à l’encontre de détenus, de victimes de la torture et de membres de leur famille, d’activistes et d’autres personnes qui se sont entretenus avec le Rapporteur spécial pendant sa visite, et d’enquêter rapidement sur les actes de représailles et de punir leurs auteurs.", "-          يحث المقرر الخاص الحكومة على أن تمنع بالفعل الأعمال الانتقامية، مثل التخويف، والتدابير التأديبية، وسوء المعاملة، في حق السجناء، وضحايا التعذيب وأفراد أسرهم، والمناضلين وغيرهم ممن تحدثوا إلى المقرر الخاص أثناء زيارته، والتعجيل بالتحقيق في تلك الأعمال ومعاقبة مقترفيها.", "", "" },
                    { 498, null, "R97P1", "ت.97.ف.1", "", "Réalisé", "", 100, 5, null, null, null, 20, 3, "Procédure spéciale", @"En ce qui concerne les provinces marocaines du Sud 
                - Enquêter rapidement sur toutes les allégations faisant état d’actes de torture et de mauvais traitements pendant et après les manifestations et à la prison de Laâyoune; 
                - Tenir les auteurs responsables de ces actes et d’accorder une indemnisation aux victimes ;", @"فيما يتعلق بالأقاليم الجنوبية للمملكة المغربية، يوصي المقرر الخاص الحكومة بما يلي:
                - (أ) التحقيق بسرعة في جميع ادعاءات التعذيب وسوء المعاملة أثناء المظاهرات وبعدها وفي سجن العيون؛ 
                مساءلة الجناة؛ وتعويض الضحايا؛", "", "" },
                    { 594, null, "R83P5", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", "-       Prendre toutes les mesures nécessaires pour s’assurer que les condamnations pénales sont fondées sur des preuves autres que les aveux des accusés, en particulier lorsque ces personnes se rétractent lors du procès, et s’assurer que, sauf dans les cas impliquant des accusations de torture, les déclarations faites sous la torture ne sont pas invoquées comme preuve dans une procédure, conformément à l’article 15 de la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "null", "", "" },
                    { 595, null, "R83P6", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", "-       S’assurer que les rapports établis par la police judiciaire au cours de l’enquête restent inadmissibles au cours du procès jusqu’à ce que les preuves de leur véracité et de leur validité juridique soient confirmées conformément au Code de procédure pénale", "null", "", "" },
                    { 596, null, "R83P6", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", "-       S’assurer que les rapports établis par la police judiciaire au cours de l’enquête restent inadmissibles au cours du procès jusqu’à ce que les preuves de leur véracité et de leur validité juridique soient confirmées conformément au Code de procédure pénale", "null", "", "" },
                    { 597, null, "R83P7", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", "-       Réviser les condamnations pénales fondées uniquement sur des aveux afin d’identifier les cas où la condamnation est fondée sur des aveux obtenus par la torture ou des mauvais traitements et prendre les mesures correctives appropriées", "null", "", "" },
                    { 598, null, "R83P8", "null", "", "En cours", "", 30, 5, null, null, null, 20, 6, "Procédure spéciale", "-       Veiller strictement à l’enregistrement dès l’arrestation, en particulier dans les affaires concernant la sécurité nationale et le terrorisme, et faire en sorte que les chefs de poste de police, les agents de la police judiciaire et les fonctionnaires de police, y compris les membres de la DST, soient tenus pénalement responsables de toute détention non reconnue", "null", "", "" },
                    { 599, null, "R83P10", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", "-       Mener des enquêtes efficaces et impartiales sur tous les cas de «transfèrements secrets» dans lesquels l’État pourrait avoir joué un rôle : mettre en lumière les faits entourant ces cas, poursuivre et punir les responsables de ces transfèrements", "null", "", "" },
                    { 600, null, "R83P23", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", @"Prendre des mesures efficaces en vue de prévenir les représailles, y compris l’intimidation, les mesures disciplinaires et les mauvais traitements contre les détenus, victimes de détention arbitraire et leurs familles, et d’autres personnes qui ont parlé au Groupe de travail lors de sa visite ; 
                - Enquêter rapidement et punir les auteurs d’actes de représailles ;", "null", "", "" },
                    { 601, null, "R83P25", "null", "", "Réalisé", "", 100, 5, null, null, null, 20, 6, "Procédure spéciale", "-       En ce qui concerne Laâyoune, au Sahara occidental, enquêter rapidement sur toutes les allégations de torture et de mauvais traitements dans le cadre d’arrestations, pendant et après les manifestations ainsi qu’à la prison de Laâyoune; éviter les cas de privation de liberté arbitraire; tenir les auteurs responsables et indemniser les victimes;", "null", "", "" },
                    { 1100, null, "R144.93", "93.144", "", "Réalisé", "", 100, 5, 1, null, 49, 20, null, "Examen périodique universal", "Intensifier le débat national en vue d’abolir la peine de mort", "تكثيف المناقشات الوطنية بقصد إلغاء عقوبة الإعدام", "", "" },
                    { 1109, null, "R144.104", "104.144", "", "En cours", "", 30, 5, 1, null, 41, 21, null, "Examen périodique universal", "Prendre les mesures nécessaires pour résoudre le problème de la surpopulation carcérale", "اتخاذ التدابير الضرورية لحل مشكلة اكتظاظ السجون", "", "" },
                    { 1101, null, "R144.94 P1", "94.144.ج.1", "", "Réalisé", "", 100, 5, 1, null, 61, 20, null, "Examen périodique universal", "Maintenir le moratoire sur la peine de mort et intensifier le dialogue sur la peine capitale et son impact", "الإبقاء على الوقف الاختياري لعقوبة الإعدام وتكثيف الحوار بشأن عقوبة الإعدام وآثارها..........", "", "" },
                    { 1103, null, "R144.96P1", "96.144. ج.1", "", "Réalisé", "", 100, 5, 1, null, 81, 20, null, "Examen périodique universal", "Maintenir son moratoire de fait sur l’application de la peine de mort", "الإبقاء على الوقف الاختياري بحكم الواقع على استخدام عقوبة الإعدام....", "", "" },
                    { 1104, null, "R144.97", "97.144", "", "Réalisé", "", 100, 5, 1, null, 1, 20, null, "Examen périodique universal", "Poursuivre le débat national sur l’abolition de la peine de mort", "مواصلة النقاش الوطني بشأن إلغاء عقوبة الإعدام", "", "" },
                    { 1105, null, "R144.98", "98.144", "", "Non réalisé", "", 0, 5, 1, null, 95, 20, null, "Examen périodique universal", "Envisager d’officialiser le moratoire de fait sur la peine de mort", "النظر في إضفاء الصفة الرسمية على الوقف الاختياري لتنفيذ عقوبة الإعدام بحكم الواقع", "", "" },
                    { 1106, null, "R144.99", "99.144", "", "Non réalisé", "", 0, 5, 1, null, 63, 20, null, "Examen périodique universal", "Envisager d’abolir la peine capitale", "النظر في إلغاء عقوبة الإعدام", "", "" },
                    { 1107, null, "R144.101P1", "101.144. ج.1", "", "Réalisé", "", 100, 5, 1, null, 8, 20, null, "Examen périodique universal", "Maintenir le moratoire sur la peine de mort", ".........الإبقاء على الوقف الاختياري لعقوبة الإعدام.......", "", "" },
                    { 74, null, "R19P1", "ت.19.ف1", "", "En cours", "", 30, 5, null, 2, null, 21, null, "Organes de traités", "-            Poursuivre l’effort de construction de nouveaux établissements pénitentiaires et de rénovation des anciens, et continuer d’accroître les ressources allouées au fonctionnement des établissements pénitentiaires, notamment pour la nourriture et les soins médicaux.", "-           مواصلة الجهود فيما يتعلق ببناء مرافق احتجاز جديدة وترميم القديم منها، والاستمرار في زيادة الموارد المخصصة لتشغيل مرافق الاحتجاز، لا سيما فيما يتصل بالغذاء والرعاية الطبية لجعل ظروف الاحتجاز في جميع أنحاء الأراضي المغربية موافقة لمجموعة القواعد النموذجية الدنيا لمعاملة السجناء.", "", "" },
                    { 108, null, "R30", "ت.30", "", "En cours", "", 30, 4, null, 3, null, 21, null, "Organes de traités", "Redoubler d’efforts pour remédier au problème de la surpopulation carcérale, notamment en mettant en place une politique de recours aux peines de substitution à la privation de liberté.", "-          بذل المزيد من الجهود لحل مشكلة الاكتظاظ في السجون، لا سيما بوضع سياسة لبدائل سلب الحرية.", "", "" },
                    { 499, null, "R88P1", "ت.88.ف.1", "", "Réalisé", "", 100, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Veiller strictement à l’enregistrement des détenus dès leur arrestation, en particulier dans les affaires concernant la sécurité nationale et le terrorisme, et de faire en sorte que les chefs de poste de police, les agents de la police judiciaire et les fonctionnaires de police, y compris les membres de la DST, soient tenus pénalement responsables de toute détention non reconnue;", "-          (أ) التأكد من التقيد الصارم بالتسجيل منذ الوهلة الأولى من إلقاء القبض، خاصة في حالات الأمن القومي والمشتبه في ارتكابهم أعمالاً إرهابية؛ والتأكد من المساءلة الجنائية لمديري مراكز الشرطة والمحققين والموظفين التنفيذيين، بمن فيهم العاملون في إدارة مراقبة التراب الوطني (المخابرات)، عن أي احتجاز غير معترف به؛", "", "" },
                    { 500, null, "R88P3", "ت.88.ف.3", "", "Réalisé", "", 100, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Mettre un terme à la pratique de l’isolement cellulaire et de la détention secrète, conformément à l’article 23 de la Constitution ;", "-          (ج) إنهاء ممارسة الحبس الانفرادي والاحتجاز السري، عملاً بالمادة 23 من الدستور؛", "", "" },
                    { 501, null, "R93P1", "ت.93.ف.1", "", "En cours", "", 30, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Réduire fortement le taux de surpeuplement", "فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي: (أ) تقليص نسبة الاكتظاظ تقليصاً شديداً؛", "", "" },
                    { 502, null, "R93P2", "ت.93.ف.2", "", "En cours", "", 30, 5, null, null, null, 21, 3, "Procédure spéciale", @"Allouer des ressources budgétaires suffisantes pour assurer des soins de santé convenables ;
                - Améliorer la qualité de la nourriture et faire en sorte que les mineurs soient séparés des adultes et les détenus avant jugement des condamnés ;
                - Renforcer et améliorer le système d’application des peines de façon qu’il vise à assurer la réadaptation et la réinsertion des délinquants ; 
                - Créer des possibilités d’instruction et de travail et des activités récréatives pour les détenus", @"فيما يتعلق بظروف الاحتجاز، يوصي المقرر الخاص الحكومة بما يلي:
                - (ب) تخصيص ميزانية كافية لتوفير الرعاية الصحية، وتحسين نوعية الغذاء، وفصل القُصّر عن البالغين والسجناء الذين لم تصدر بعد في حقهم أحكام عن المدانين؛ وتعزيز وتحسين نظام تطبيق الأحكام الذي يهدف إلى إعادة تأهيل الجناة وإعادة إدماجهم؛ وتوفير فرص تعليمية ومهنية وأنشطة ترفيهية للسجناء؛", "", "" },
                    { 503, null, "R93P3", "ت.93.ف.3", "", "En cours", "", 30, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Transférer les prisonniers condamnés à la peine de mort et ceux qui exécutent une peine de réclusion à perpétuité dans des établissements ouverts ou semi-ouverts ;", "-          (ج) نقل السجناء المحكوم عليهم بالإعدام وبالسجن المؤبّد إلى مرافق مفتوحة أو شبه مفتوحة؛", "", "" },
                    { 504, null, "R93P6", "ت.93.ف.6", "", "En cours", "", 30, 5, null, null, null, 21, 3, "Procédure spéciale", "-    Fournir les soins dentaires et psychiatriques requis et assurer les interventions psychologiques voulues, de manière générale", "-          (و) توفير خدمات طب الأسنان والطب النفسي المناسبة، إضافة إلى التدخلات النفسية، والأخذ بذلك على أنه قاعدة عامة.", "", "" },
                    { 1102, null, "R144.95P1P3", "95.144. ج.1 و ج.3", "", "En cours", "", 30, 5, 1, null, 2, 20, null, "Examen périodique universal", "Poursuivre le débat national en cours relatif à l’abolition de la peine de mort", "مواصلة النقاش الوطني الحالي بشأن إلغاء عقوبة الإعدام....... والنظر في إضفاء الصفة الرسمية على الوقف الاختياري لتنفيذها بحكم الواقع الذي يُطبَّق حالياً", "", "" },
                    { 329, null, "R31P1", "ت.31.ف.1", "", "Non réalisé", "", 0, 3, null, 8, null, 10, null, "Organes de traités", "Abroger les dispositions qui prévoient la privation de liberté d’adultes et d’enfants handicapés en raison de leur handicap, de mettre un terme à cette pratique", "-      إلغاء الأحكام والممارسات التي تجيز حرمان الأشخاص ذوي الإعاقة، أطفالاً وبالغين، من حريتهم بسبب الإعاقة", "", "" },
                    { 87, null, "R34", "ت.34", "", "Réalisé", "", 100, 1, null, 3, null, 1, null, "Organes de traités", @"Garantir et protéger la pleine indépendance et impartialité des juges et s’assurer qu’ils peuvent exercer les fonctions judiciaires sans aucune pression ou interférence ; et 
                 Veiller à ce que toutes les procédures judiciaires soient conduites dans le plein respect des garanties d’un procès équitable inscrites à l’article 14 du Pacte.", @"ضمان وحماية استقلال القضاة وحيادهم على النحو الأكمل، والتأكد من أنهم يستطيعون أداء مهامهم القضائية دون أي ضغط أو تدخل
                    الحرص على اتباع الإجراءات القضائية في ظل احترام ضمانات المحاكمة العادلة المذكورة في المادة 14 من العهد احتراماً كاملاً.", "", "" },
                    { 1073, null, "R144.165", "165.144", "", "En cours", "", 30, 4, 1, null, 100, 14, null, "Examen périodique universal", "Prendre de nouvelles mesures ciblées pour promouvoir l’éducation inclusive pour tous", "اتخاذ مزيد من التدابير المحددة الهدف بغية تعزيز التعليم الجامع", "", "" },
                    { 564, null, "R93P7", "null", "", "En cours", "", 30, 4, null, null, null, 13, 5, "Procédure spéciale", "Assurer l’accès au droit à la santé, y compris aux services de santé sexuelle et reproductive et d’information", "null", "", "" },
                    { 493, null, "R95P3", "ت.95.ف.3", "", "En cours", "", 30, 4, null, null, null, 13, 3, "Procédure spéciale", "-    Rattacher les services de santé destinés aux prisonniers au Ministère de la santé, ce qui devrait contribuer à des soins médicaux de meilleure qualité", "بخصوص الإصلاح المؤسسي، يوصي المقرر الخاص الحكومة بما يلي:  (ج) اتباع الإدارات المعنية بالصحة في السجون لوزارة الصحة، الأمر الذي يُفترض أن يسهم في تقديم خدمات طبية فائقة الجودة؛", "", "" },
                    { 492, null, "R94P1", "ت.94.ف.1", "", "En cours", "", 30, 4, null, null, null, 13, 3, "Procédure spéciale", "-    Pour ce qui est des établissements psychiatriques, appliquer les dispositions des articles 3 et 4 du décret d’application de la loi (no 23/98) sur les prisons, notamment en ce qui concerne le non-recours à la violence contre les prisonniers, et d’interdire l’isolement cellulaire ;", "بخصوص المصحات النفسية، يوصي المقرر الخاص الحكومة بما يلي: ...(أ) تطبيق أحكام المادتين 3 و4 من المرسوم التنفيذي لقانون السجون (رقم 23/98)، لا سيما ما تعلق بالامتناع عن استخدام العنف في حق السجناء، وحظر الحبس الانفرادي؛", "", "" },
                    { 491, null, "R88P8", "ت.88.ف.8", "", "En cours", "", 30, 4, null, null, null, 13, 3, "Procédure spéciale", "-    Investir dans les domaines de la psychiatrie et de la médecine légale ainsi que dans la formation spécialisée d’experts médico-légaux capables de se prononcer sur les cas de torture et de mauvais traitements, conformément aux normes internationales, notamment le Protocole d’Istanbul; de renforcer les moyens médicolégaux du parquet et des tribunaux;", "-          (ح) الاستثمار في الطب النفسي والطب الشرعي، وكذلك في تدريب خبراء الطب الشرعي على تقييم سوء المعاملة والتعذيب، تماشياً مع المعايير الدولية، مثل بروتوكول اسطنبول؛ وتدعيم قدرات الادعاء والقضاء في مجال الطب الشرعي؛", "", "" },
                    { 448, null, "R79P4", "null", "", "Réalisé", "", 100, 4, null, null, null, 13, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’accès aux services de santé", "null", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 413, null, "R90P1", "null", "", "En cours", "", 30, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Faciliter, dans des conditions d’égalité, l’accès aux services de santé primaires, réduire la mortalité maternelle, juvénile et infantile et promouvoir de bonnes pratiques d’allaitement, conformément aux recommandations formulées par le Comité des droits de l’enfant", "null", "", "" },
                    { 412, null, "R84", "null", "", "En cours", "", 30, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Mieux faire appliquer le Code international de commercialisation des substituts du lait maternel et créer un système de suivi indépendant.", "null", "", "" },
                    { 411, null, "R83", "null", "", "En cours", "", 30, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Sensibiliser la population aux meilleures pratiques d’allaitement et aider les femmes et leur famille à adopter les meilleures pratiques en ce qui concerne l’alimentation des nourrissons et des jeunes enfants", "null", "", "" },
                    { 410, null, "R82", "null", "", "En cours", "", 30, 4, null, null, null, 13, 1, "Procédure spéciale", "-   Prendre des mesures pour promouvoir une alimentation saine auprès des femmes et souligner les risques sanitaires associés au surpoids et à l’obésité", "null", "", "" },
                    { 337, null, "R49", "ت.49", "", "Non réalisé", "", 0, 4, null, 8, null, 13, null, "Organes de traités", @"Le comité recommande au Royaume du maroc ce qui suit:
                a) D’adopter une stratégie visant à garantir que les personnes handicapées aient accès aux services de santé et de veiller à ce que cette stratégie couvre notamment le développement d’infrastructures accessibles, la formation des professionnels de la santé aux droits des personnes handicapées et la fourniture d’informations sur les traitements médicaux dans des formats accessibles, notamment pour les personnes présentant un handicap intellectuel ou psychosocial ;
                b) veiller à ce que les informations sur les droits en matière de sexualité et de procréation soient diffusées dans des formats accessibles à toutes les personnes handicapées ; 
                c) Etablir des protocoles visant à garantir aux personnes handicapées le droit au consentement libre et éclairé dans le cadre de la mise en œuvre du plan national relatif à la santé et au handicap pour la période 2015-2021 ;
                d) Tenir compte des liens entre l’article 25 de la Convention et la cible 3.7 des objectifs de développement durable afin d’assurer l’accès de tous à des services de soins de santé sexuelle et procréative", @"توصي اللجنة المملكة المغربية بما يلي: 
                (أ) الخدمات الصحية، تشمل في جملة عناصر إيجاد مرافق يسهل الوصول إليها، وتدريب العاملين في المجال الصحي على حقوق الأشخاص ذوي الإعاقة، وتوفير المعلومات في أشكال يسهل الاطلاع عليها عن العلاجات الصحية، بما في ذلك للأشخاص ذوي الإعاقة العقلية و/أو النفسية - الاجتماعية؛
                (ب) ضمان نشر المعلومات المتعلقة بالحقوق الجنسية والإنجابية بأشكال ميسرة لجميع الأشخاص ذوي الإعاقة؛ 
                (ج) وضع بروتوكولات ترمي إلى ضمان حق الأشخاص ذوي الإعاقة في إعطاء موافقة حرة ومستنيرة في إطار تنفيذ مخطط العمل الوطني للصحة والإعاقة 2015-2021؛
                (د) إيلاء الاهتمام للصلات القائمة بين المادة 25 من الاتفاقية والغاية 3-7 من أهداف التنمية المستدامة، من أجل ضمان حصول الجميع على خدمات الرعاية الصحية الجنسية والإنجابية.‬", "", "" },
                    { 336, null, "R45P2", "ت.45.ف.2", "", "Non réalisé", "", 0, 4, null, 8, null, 13, null, "Organes de traités", "Prendre des mesures pour fournir aux personnes handicapées un accès, dans des formats adaptés, à des programmes d’information sur la santé sexuelle et procréative et la planification familiale", "-       (ب) اتخاذ تدابير ترمي إلى تمكين الأشخاص ذوي الإعاقة من الحصول، في أشكال ملائمة، على المعلومات المتعلقة بالصحة الجنسية والإنجابية وتنظيم الأسرة، .....", "", "" },
                    { 335, null, "R37P1", "ت.37.ف.1", "", "Non réalisé", "", 0, 4, null, 8, null, 13, null, "Organes de traités", "Interdire et d’incriminer la pratique des interventions chirurgicales correctrices pratiquées sur les personnes intersexuées handicapées sans leur consentement préalable et éclairé ainsi que la pratique de la stérilisation forcée, notamment la castration chimique", "-      حظر وتجريم الممارسة المتمثلة في إخضاع الأشخاص ذوي الإعاقة من حاملي صفات الجنسين لعمليات جراحية تصحيحية من دون الحصول على موافقة مسبقة ومستنيرة، وممارسة التعقيم القسري، بما في ذلك الإخصاء الكيميائي القسري", "", "" },
                    { 1069, null, "R144.160", "160.144", "", "En cours", "", 30, 4, 1, null, 15, 13, null, "Examen périodique universal", "Continuer de fournir une couverture médicale de base à sa population, notamment aux personnes âgées", "مواصلة توفير التغطية الطبية الأساسية لجميع سكانه بمن فيهم المسنون", "", "" },
                    { 276, null, "R57P1P3", "ت.57.ف.1.ف.3", "", "En cours", "", 30, 4, null, 7, null, 13, null, "Organes de traités", @"Renvoyant à son Observation générale no 4 (2003) sur la santé et le développement de l’adolescent, le Comité demande instamment au Maroc:
                a) D’adopter une politique globale de la santé sexuelle et génésique des adolescents et de faire en sorte que l’éducation dans ce domaine fasse partie du programme scolaire obligatoire, une attention particulière devant être accordée à la prévention de la grossesse précoce et des infections transmises sexuellement;
                c) De faire face au phénomène de la consommation de drogues par les enfants et les adolescents, notamment en leur fournissant des informations précises et objectives et en leur permettant d’acquérir des compétences pratiques de façon à prévenir la consommation de substances toxiques (y compris le tabac et l’alcool), et de mettre en place des services de traitement de la toxicomanie et de réduction des risques qui soient accessibles et adaptés aux jeunes;", @"تشير اللجنة إلى تعليقها العام رقم 4(2003) بشأن صحة المراهقين ونموهم، وتحث الدولة الطرف على ما يلي:
                -  (أ) اعتماد سياسة شاملة في ميدان الصحة الجنسية والإنجابية للمراهقين، وضمان أن التثقيف في هذا المجال جزء من المقررات الدراسية الإلزامية، مع الاهتمام خاصة بالوقاية من الحمل المبكر والأمراض المنقولة جنسياً؛
                -  (ج) التصدي لظاهرة معاقرة الأطفال والمراهقين المخدرات بوسائل منها إمدادهم بمعلومات صحيحة وموضوعية وتعليمهم مهارات الحياة لتوقي تعاطيهم مواد الإدمان، بما فيها التبغ والكحول، واستحداث علاج لإدمان المخدرات ميسور وملائم للشباب وتوفير خدمات للحد من أضرارها", "", "" },
                    { 274, null, "R53P3", "ت.53.ف.3", "", "En cours", "", 30, 4, null, 7, null, 13, null, "Organes de traités", @"Compte tenu de l’article 23 de la Convention et de son Observation générale no 9 (2006) sur les droits des enfants handicapés, le Comité demande instamment au Maroc d’adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier :
                c) D’adopter sans délai des mesures pour faire en sorte que les enfants handicapés aient accès aux soins de santé, y compris aux programmes de dépistage et d’intervention précoces;", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                -  (ج) اتخاذ تدابير فورية تكفل للأطفال ذوي الإعاقة تلقي الرعاية الصحية، بما فيها برامج الكشف والتدخل المبكرين؛", "", "" },
                    { 225, null, "R33P2", "ت.33.ف.2", "", "En cours", "", 30, 4, null, 6, null, 13, null, "Organes de traités", "Prendre des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention, pour s’assurer que les femmes rurales jouissent de leurs droits politiques, sociaux, économiques et culturels sans aucune discrimination, notamment en ce qui concerne l’accès à la santé.", "اتخاذ تدابير خاصة مؤقتة، على النحو المنصوص عليه في الفقرة 1 من المادة 4 من الاتفاقية، لكفالة تمتع المرأة الريفية بحقوقها السياسية والاجتماعية والاقتصادية والثقافية دونما تمييز، لا سيما فيما يتصل بالحق في والوصول إلى مرافق الرعاية الصحية.", "", "" },
                    { 224, null, "R31P1", "ت.31.ف.1", "", "En cours", "", 30, 4, null, 6, null, 13, null, "Organes de traités", "Améliorer l’accès des femmes aux soins de santé primaires, notamment pour ce qui est de la santé procréative et des moyens de planification de la famille.", "زيادة فرص حصول المرأة على خدمات الرعاية الصحية الأساسية، بما فيها رعاية الصحة الإنجابية ووسائل تنظيم الأسرة.", "", "" },
                    { 179, null, "R30P1", "ت.30ف.1", "", "Réalisé", "", 100, 4, null, 5, null, 13, null, "Organes de traités", "-  Mettre en place des mesures effectives qui assurent aux travailleurs migrants et aux membres de leur famille, y compris ceux en situation irrégulière, l’accès aux soins médicaux d’urgence, ainsi qu’aux services sanitaires de base.", "اعتماد تدابير فعالة تكفل للعمال المهاجرين وأفراد أسرهم، بمن فيهم الموجودون في وضع غير قانوني، الحصول على الرعاية الطبية في حالات الطوارئ وعلى الخدمات الصحية الأساسية", "", "" },
                    { 148, null, "R46P1", "ت.46.ف.1", "", "En cours", "", 30, 4, null, 4, null, 13, null, "Organes de traités", "-            - Fournir à tous des installations, des services, des biens et des informations de qualité pour la santé sexuelle et procréative, en particulier dans les zones rurales, en formant et en augmentant le nombre d’auxiliaires de santé et en sensibilisant les femmes et les hommes aux besoins de santé sexuelle et procréative", "-          تزويد الجميع، لا سيما في المناطق الريفية، بتجهيزات وخدمات وسلع ومعلومات ذات جودة لتوفير خدمات الصحة الجنسية والإنجابية، عن طريق تدريب المعاونين الصحيين وزيادة عددهم، وتوعية النساء والرجال باحتياجات الصحة الجنسية والإنجابية.", "", "" },
                    { 20, null, "R11P3", "·          ت.11.ف.3", "", "Réalisé", "", 100, 4, null, 1, null, 13, null, "Organes de traités", "Prendre les mesures nécessaires pour s’assurer que des amazighs ne soient victimes d’aucune forme de discrimination raciale, notamment dans l’accès aux services de santé.", "اتخاذ التدابير اللازمة لضمان عدم تعرض الأمازيغ لأي شكل من أشكال التمييز العنصري، لا سيما وفي الحصول على الخدمات الصحية.", "", "" },
                    { 1068, null, "R144.236", "236.144", "", "Réalisé", "", 100, 4, 1, null, 84, 12, null, "Examen périodique universal", "Garantir un accès plein et égal aux ressources socioéconomiques (y compris l’accès à l’enseignement supérieur et aux cours de langue traditionnelle) pour les populations amazighes et saharienne/sahraouie", "ضمان الوصول التام والمتساوي إلى الموارد الاجتماعية والاقتصادية (بما في ذلك الحصول على التعليم الجامعي وعلى دروس في اللغات التقليدية) للسكان الأمازيغ والصحراويين", "", "" },
                    { 1067, null, "R144.235", "235.144", "", "Réalisé", "", 100, 4, 1, null, 60, 12, null, "Examen périodique universal", "Continuer d’adopter les mesures législatives et les politiques de protection nécessaires pour assurer l’éducation aux populations amazighes et sahraouies à tous les niveaux, ainsi que la pleine jouissance de leurs droits de manifester et de participer à la vie culturelle du pays, en préservant leurs traditions et leur identité", "مواصلة اعتماد تدابير تشريعية وسياسات الحماية الضرورية لكفالة التعليم للسكان الأمازيغ والصحراويين في جميع المستويات، إلى جانب التمتع الكامل بحقوقهم في التظاهر والمشاركة في الحياة الثقافية في البلد بما يحفظ تقاليدهم وهويتهم", "", "" },
                    { 1066, null, "R144.234", "234.144", "", "En cours", "", 30, 4, 1, null, 16, 12, null, "Examen périodique universal", "Poursuivre les efforts en vue de la promotion et de la préservation du patrimoine culturel saharo-hassani, tel que consacré dans la Constitution de 2011", "مواصلة الجهود باتجاه تعزيز التراث الثقافي الصحراوي الحسّاني والمحافظة عليه، مثلما هو مكرّس في دستور عام 2011", "", "" },
                    { 1065, null, "R144.233", "233.144", "", "En cours", "", 30, 4, 1, null, 16, 12, null, "Examen périodique universal", "Poursuivre les efforts visant à introduire l’enseignement de la langue et de la culture amazighe", "مواصلة جهوده لتوفير تعليم اللغة والثقافة الأمازيغيتين", "", "" },
                    { 1064, null, "R144.232", "232.144", "", "Réalisé", "", 100, 4, 1, null, 11, 12, null, "Examen périodique universal", "Poursuivre ses efforts appréciables en faveur du développement des langues nationales et promouvoir et protéger la langue et les patrimoines culturels amazighs", "مواصلة جهوده المحمودة باتجاه تطوير اللغات الوطنية وتعزيز وحماية اللغة والتراث الثقافي الأمازيغيين", "", "" },
                    { 1063, null, "144.181", "181.144", "", "Réalisé", "", 100, 4, 1, null, 29, 12, null, "Examen périodique universal", "Poursuivre les efforts de promotion des droits culturels par des programmes visant à protéger et revitaliser la diversité du patrimoine culturel constitutif de l’identité marocaine, y compris le patrimoine hassani dans les provinces du sud", "مواصلة الجهود لتعزيز الحقوق الثقافية عن طريق برامج لحماية وإنعاش تنوع التراث الثقافي الذي يشكل الهوية المغربية بما فيه التراث الحساني في الأقاليم الجنوبية", "", "" },
                    { 275, null, "R55", "ت.55", "", "En cours", "", 30, 4, null, 7, null, 13, null, "Organes de traités", @"Le Comité appelle l’attention du Maroc sur son Observation générale no 15 (2013) sur le droit de l’enfant de jouir du meilleur état de santé possible, et lui recommande:
                a) De veiller à ce que des ressources suffisantes soient allouées au secteur de la santé et d’élaborer et d’appliquer des politiques et des programmes complets pour améliorer l’état de santé des enfants et favoriser un accès plus large et dans des conditions d’égalité des mères et des enfants à des services de santé primaires de qualité dans toutes les régions du pays de façon à mettre fin aux disparités dans l’accès aux soins;
                b) De prendre des mesures plus efficaces pour lutter contre la mortalité liée à la maternité et infantile et améliorer le statut nutritionnel des jeunes enfants;
                c) Solliciter à cet égard une assistance financière et technique auprès, entre autres, du Fonds des Nations Unies pour l’enfance (UNICEF) et de l’Organisation mondiale de la Santé.", @"تلفت اللجنة انتباه المملكة المغربية إلى تعليقها العام رقم 15(2013) بشأن حق الطفل في التمتع بأعلى مستوى صحي يمكن بلوغه، وتوصيها بالآتي:
                - (أ) الحرص على تخصيص موارد كافية لقطاع الصحة واستخدامها بفاعلية، ووضع سياسات وبرامج شاملة وتنفيذها لتحسين الوضع الصحي للأطفال وتسهيل تلقي الأمهات والأطفال مزيداً من الخدمات الصحية الأولية الجيدة وعلى قدم المساواة مع غيرهم من الشرائح في جميع مناطق البلاد للحد من التفاوت في الحصول على الخدمات الصحية؛
                - (ب) اتخاذ تدابير أكثر لعالية للتقليل من وفيات الأمهات والرضع ومعالجة الوضع الغذائي للصغار؛
                - (ج) التماس المساعدة المالية والتقنية في هذا الصدد من جهات مثل اليونيسيف ومنظمة الصحة العالمية", "", "" },
                    { 1070, null, "R144.163", "163.144", "", "Réalisé", "", 100, 4, 1, null, 76, 13, null, "Examen périodique universal", "Améliorer l’accès aux services de santé dans les zones rurales, en particulier pour réduire la mortalité et la morbidité maternelles", "زيادة الفرص في الحصول على خدمات الرعاية الصحية في الأرياف لأهداف منها الحد من معدلات وفيات الأمهات واعتلالهن", "", "" },
                    { 1071, null, "R144.164", "164.144", "", "Réalisé", "", 100, 4, 1, null, 91, 13, null, "Examen périodique universal", "Continuer de promouvoir les soins et consultations prénatals pour réduire la nécessité du transport d’urgence au moment de l’accouchement et réduire ainsi le risque de décès chez les mères et les enfants", "زيادة تحسين خدمات الرعاية الصحية قبل الولادة واستشارات الطبيب للحد من ضرورة النقل العاجل عند المخاض ومن ثم الحد من خطر وفيات الأمهات والأطفال", "", "" },
                    { 21, null, "R11P1P5", "·          ت.11.ف.1.ف.5", "", "En cours", "", 30, 4, null, 1, null, 14, null, "Organes de traités", "Intensifier ses efforts en vue de promouvoir la langue et la culture amazighes, notamment par leur enseignement et à assurer également l'alphabétisationdes amazighs dans cette langue", @"بذل المزيد من الجهود بغية تعزيز اللغة والثقافة الأمازيغيتين، لا سيما عن طريق تعليمهما
                 ضمان محو أمية الأمازيغ بلغتهم", "", "" },
                    { 338, null, "R47", "ت.47", "", "En cours", "", 30, 4, null, 8, null, 14, null, "Organes de traités", @"Le comité recommande au Royaume du maroc ce qui suit:
                a) D’adopter une stratégie visant à garantir que les personnes handicapées aient accès aux services de santé et de veiller à ce que cette stratégie couvre notamment le développement d’infrastructures accessibles, la formation des professionnels de la santé aux droits des personnes handicapées et la fourniture d’informations sur les traitements médicaux dans des formats accessibles, notamment pour les personnes présentant un handicap intellectuel ou psychosocial ;
                b) veiller à ce que les informations sur les droits en matière de sexualité et de procréation soient diffusées dans des formats accessibles à toutes les personnes handicapées ; 
                c) Etablir des protocoles visant à garantir aux personnes handicapées le droit au consentement libre et éclairé dans le cadre de la mise en œuvre du plan national relatif à la santé et au handicap pour la période 2015-2021 ;
                d) Tenir compte des liens entre l’article 25 de la Convention et la cible 3.7 des objectifs de développement durable afin d’assurer l’accès de tous à des services de soins de santé sexuelle et procréative", @"توصي اللجنة المملكة المغربية بما يلي: 
                (أ) الخدمات الصحية، تشمل في جملة عناصر إيجاد مرافق يسهل الوصول إليها، وتدريب العاملين في المجال الصحي على حقوق الأشخاص ذوي الإعاقة، وتوفير المعلومات في أشكال يسهل الاطلاع عليها عن العلاجات الصحية، بما في ذلك للأشخاص ذوي الإعاقة العقلية و/أو النفسية - الاجتماعية؛
                (ب) ضمان نشر المعلومات المتعلقة بالحقوق الجنسية والإنجابية بأشكال ميسرة لجميع الأشخاص ذوي الإعاقة؛ 
                (ج) وضع بروتوكولات ترمي إلى ضمان حق الأشخاص ذوي الإعاقة في إعطاء موافقة حرة ومستنيرة في إطار تنفيذ مخطط العمل الوطني للصحة والإعاقة 2015-2021؛
                (د) إيلاء الاهتمام للصلات القائمة بين المادة 25 من الاتفاقية والغاية 3-7 من أهداف التنمية المستدامة، من أجل ضمان حصول الجميع على خدمات الرعاية الصحية الجنسية والإنجابية.‬", "", "" },
                    { 414, null, "R95P1P3", "null", "", "En cours", "", 30, 4, null, null, null, 14, 1, "Procédure spéciale", @"Pour les provinces marocaines du sud :
                -  Veiller à ce que les ressources éducatives profitent à la population locale
                - Elaborer des programmes de formation technique à l’intention des Sahraouis", "null", "", "" },
                    { 415, null, "R96P1", "null", "", "En cours", "", 30, 4, null, null, null, 14, 1, "Procédure spéciale", @"Pour les provinces marocaines du sud :
                - Suivre la mise en œuvre des programmes relatifs à l’éducation", "null", "", "" },
                    { 449, null, "R79P1", "null", "", "Réalisé", "", 100, 4, null, null, null, 14, 2, "Procédure spéciale", "-       Intensifier les efforts pour faire en sorte que les Amazighs ne soient pas victimes de discrimination raciale dans l’exercice de leurs droits fondamentaux, notamment en ce qui concerne l’éducation", "null", "", "" },
                    { 565, null, "R93P8", "null", "", "En cours", "", 30, 4, null, null, null, 14, 5, "Procédure spéciale", "Assurer l’accès à l’éducation pour les filles rurales, y compris par des mesures supplémentaires et efficaces pour faciliter leur participation dans l’enseignement primaire et secondaire.", "null", "", "" },
                    { 621, null, "R86P1-3", "ت.86.ف.1ج3", "", "En cours", "", 30, 4, null, null, null, 14, 7, "Procédure spéciale", "- Renforcer l’appui à la promotion et à la préservation de la culture amazighe en réformant le secteur de l’éducation pour garantir l’utilisation de la langue amazighe dans tous les domaines, et faire figurer des manuels en langue amazighe dans la liste officielle des ouvrages distribués gratuitement dans toutes les écoles établie par le Ministère de l’éducation nationale", @"(أ)  زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                3-إصلاح قطاع التعليم من أجل ضمان استخدام اللغة الأمازيغية في جميع المجالات التعليمية، وإدراج الكتب المدرسية المكتوبة باللغة الأمازيغية في القائمة الرسمية للكتب التي تعدها وزارة التربية لتوزيعها بالمجان في جميع المدارس؛", "", "" },
                    { 622, null, "R86P4-1", "ت.86.ف.4ج1", "", "Non réalisé", "", 0, 4, null, null, null, 14, 7, "Procédure spéciale", "Abroger la circulaire no 122 du 7 janvier 2002 du Ministère de l’éducation nationale stipulant que le nom non arabe d’un certain nombre d’écoles doit être remplacé par un nom arabe, et d’abroger tout autre texte législatif ou réglementaire comparable", "-    (ج) إلغاء مذكرة وزارة التربية رقم 122 المؤرخة 7 كانون الثاني/ يناير 2002 التي تنص على تغيير الأسماء غير العربية لعدد من المدارس بأسماء عربية، وإلغاء أي تشريعات أخرى من هذا القبيل. ....", "", "" },
                    { 623, null, "R86P4", "ت.86.ف.4", "", "En cours", "", 30, 4, null, null, null, 14, 7, "Procédure spéciale", "Réviser les manuels scolaires d’histoire et d’autres disciplines afin de refléter la diversité du pays, en veillant à une représentation adéquate de la diversité culturelle entre les auteurs, ainsi qu’au sein du comité indépendant chargé d’approuver les manuels. De plus, les programmes de formation des enseignants devraient comprendre des méthodologies reflétant la richesse de la diversité culturelle marocaine de la manière la plus interactive et novatrice possible", "-    (د) تنقيح مادة التاريخ وغيرها من المواد في الكتب المدرسية لتعبر عن التنوع الذي يزخر به البلد، مع ضمان تمثيل كافٍ للتنوع الثقافي بين المؤلفين، وكذلك في لجنة الاستعراض المستقلة التي توافق على الكتب المدرسية. وبالإضافة إلى ذلك، ينبغي أن تشمل برامج تدريب المدرسين منهجيات تعبر عن ثراء التنوع الثقافي المغربي بأكثر الأساليب تفاعلاً وابتكاراً.", "", "" },
                    { 1072, null, "R144.162", "162.144", "", "En cours", "", 30, 4, 1, null, 43, 14, null, "Examen périodique universal", "Comme suite aux recommandations issues du deuxième cycle figurant aux paragraphes 129.98, 129.102, 129.111, 129.116, 129.117 et 130.9 du document A/HRC/21/3, accroître les investissements dans l’enseignement public en vue d’augmenter les salaires des enseignants et de mettre en place des programmes de formation professionnelle et technique", "متابعة التوصيات المنبثقة عن الجولة الثانية والواردة في الوثيقة A/HRC/21/3 الفقرات 129-98 و129-102 و129-111 و129-116 و129-117 و130-9، وزيادة الاستثمارات في التعليم العام وذلك بزيادة مرتبات المدرسين واستحداث برامج تدريب مهني وفني", "", "" },
                    { 277, null, "R53P2P4", "ت.53.ف.2.ف.4", "", "En cours", "", 30, 4, null, 7, null, 14, null, "Organes de traités", @"le Comité demande instamment au Maroc d’adopter une approche du handicap fondée sur les droits de l’homme et recommande en particulier:
                b) D’adopter des mesures globales pour développer l’enseignement inclusif et faire en sorte qu’il ait la priorité sur le placement d’enfants dans des institutions et des classes spécialisées. À cette fin, le Comité demande instamment à l’État partie de retirer des centres de sauvegarde les enfants qui y ont été placés;
                d) De former le personnel et les enseignants spécialisés appelés à s’occuper de classes intégrées fournissant un soutien individualisé et toute l’attention voulue aux enfants ayant des difficultés d’apprentissage", @"تحث اللجنة المملكة المغربية، في ضوء المادة 23 من الاتفاقية وتعليقها العام     رقم 9(2006) بشأن حقوق الأطفال ذوي الإعاقة، على انتهاج نهج يقوم على حقوق الإنسان في التعاطي مع الإعاقة، وتوصيها بالآتي تحديداً: 
                -  (ب) اتخاذ تدابير جامعة لتطوير التعليم الشامل وضمان أولويته على إيداع الأطفال في مؤسسات وفصول متخصصة. ولتحقيق هذا الغرض، تحث اللجنة الدولة الطرف على أن تسارع إلى نقل الأطفال ذوي الإعاقة الذين أودعوا مراكز حماية الطفولة؛
                -  (د) تدريب وتعيين معلمين ومهنيين متخصصين في الفصول المدمجة لتقديم دعم فردي وتوجيه كل الاهتمام للأطفال الذين يعانون صعوبات في التعلّم", "", "" },
                    { 1074, null, "R144.166", "166.144", "", "En cours", "", 30, 4, 1, null, 16, 14, null, "Examen périodique universal", "Mettre en œuvre la vision stratégique pour la réforme de l’éducation sur la période 2015-2030", "تنفيذ الرؤية الاستراتيجية لإصلاح التعليم للفترة ما بين عامي 2015 و2030", "", "" },
                    { 1075, null, "R144.168", "168.144", "", "Réalisé", "", 100, 4, 1, null, 58, 14, null, "Examen périodique universal", "Continuer de renforcer le droit à l’éducation", "مواصلة تكريس الحق في التعليم", "", "" },
                    { 1076, null, "R144.169", "169.144", "", "Réalisé", "", 100, 4, 1, null, 64, 14, null, "Examen périodique universal", "Mettre en place une stratégie ou un plan d’action pour lutter contre l’analphabétisme", "وضع استراتيجية أو خطة عمل لمكافحة الأمية", "", "" },
                    { 1077, null, "R144.170", "170.144", "", "Réalisé", "", 100, 4, 1, null, 71, 14, null, "Examen périodique universal", "Envisager d’éliminer les différences en matière de scolarisation entre les villes et les zones rurales, entre filles et garçons et parmi les minorités", "النظر في القضاء على التفاوتات في التعليم ما بين الحواضر والأرياف وما بين الفتيات والفتيان وما بين الأقليات", "", "" },
                    { 1078, null, "R144.171", "171.144", "", "Réalisé", "", 100, 4, 1, null, 73, 14, null, "Examen périodique universal", "Mettre en œuvre des mesures visant à garantir l’éducation inclusive pour tous dans l’enseignement primaire, secondaire et universitaire", "تنفيذ تدابير لضمان حصول الجميع على التعليم في المراحل الابتدائية والثانوية والجامعية", "", "" },
                    { 1079, null, "R144.172", "172.144", "", "Réalisé", "", 100, 4, 1, null, 79, 14, null, "Examen périodique universal", "Prendre des mesures supplémentaires dans le domaine de la promotion des droits économiques, sociaux et culturels, notamment dans le secteur de l’éducation, en mettant un accent particulier sur la scolarisation des filles et des garçons dans les zones rurales", "القيام بخطوات أخرى في مجال تعزيز الحقوق الاقتصادية والاجتماعية والثقافية وخاصة في قطاع التعليم مع التركيز بوجه خاص على تسجيل فتيات وفتيان الأرياف في المدارس", "", "" },
                    { 1080, null, "R144.173", "173.144", "", "Réalisé", "", 100, 4, 1, null, 5, 14, null, "Examen périodique universal", "Soutenir le droit à l’éducation en mettant en œuvre la vision stratégique pour réformer le système éducatif sur la période 2015-2030", "دعم الحق في التعليم عن طريق تنفيذ الرؤية الاستراتيجية لنظام التعليم للفترة ما بين عامي 2015 و2030", "", "" },
                    { 1081, null, "R144.174", "174.144", "", "Réalisé", "", 100, 4, 1, null, 88, 14, null, "Examen périodique universal", "Renforcer et appuyer la promotion de l’éducation des enfants économiquement vulnérables", "دعم تشجيع التعليم لفائدة الأطفال ضعيفي الحالة الاقتصادية", "", "" },
                    { 1082, null, "R144.175", "175.144", "", "Réalisé", "", 100, 4, 1, null, 33, 14, null, "Examen périodique universal", "Poursuivre les efforts pour veiller à ce que tous les enfants soient inscrits à l’école élémentaire et étudier les mesures nécessaires pour toucher les enfants privés d’éducation", "مواصلة الجهود لضمان تسجيل جميع الأطفال في المدرسة الابتدائية والنظر في اتخاذ التدابير الضرورية لمساعدة الأطفال المحرومين من التعليم", "", "" },
                    { 1083, null, "R144.176", "176.144", "", "En cours", "", 30, 4, 1, null, 87, 14, null, "Examen périodique universal", "Poursuivre les efforts visant à promouvoir le droit à l’éducation en luttant contre le phénomène de l’abandon scolaire", "مواصلة الجهود من أجل تعزيز الحق في التعليم عن طريق مكافحة ظاهرة تسرب الأطفال من المدارس", "", "" },
                    { 1084, null, "R144.177", "177.144", "", "Réalisé", "", 100, 4, 1, null, 93, 14, null, "Examen périodique universal", "Poursuivre les efforts visant à réformer le système éducatif public et à améliorer la qualité de l’enseignement public pour instaurer l’égalité des chances entre les classes sociales", "مواصلة الجهود لإصلاح نظام التعليم العام وتحسين نوعية التعليم العام توخياً لتحقيق المساواة في الفرص بين الطبقات الاجتماعية", "", "" },
                    { 1085, null, "R144.178", "178.144", "", "Réalisé", "", 100, 4, 1, null, 94, 14, null, "Examen périodique universal", "Intensifier les efforts pour s’assurer que tous les enfants dont scolarisés aux niveaux primaire et secondaire", "زيادة الجهود المبذولة لضمان تسجيل جميع الأطفال في المدارس في المرحلتين الابتدائية والثانوية", "", "" },
                    { 227, null, "R33P1", "ت.33.ف.1", "", "En cours", "", 30, 4, null, 6, null, 14, null, "Organes de traités", "Prendre des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention, pour s’assurer que les femmes rurales jouissent de leurs droits politiques, sociaux, économiques et culturels sans aucune discrimination, notamment en ce qui concerne l’accès à l’éducation", "اتخاذ تدابير خاصة مؤقتة، على النحو المنصوص عليه في الفقرة 1 من المادة 4 من الاتفاقية، لكفالة تمتع المرأة الريفية بحقوقها السياسية والاجتماعية والاقتصادية والثقافية دونما تمييز، لا سيما فيما يتصل بالحق في الحصول على التعليم", "", "" },
                    { 226, null, "R27P1P2P3", "ت.27.ف.1.ف.2.ف.3", "", "En cours", "", 30, 4, null, 6, null, 14, null, "Organes de traités", @"Prendre des mesures pour garantir l’accès des femmes et des filles à tous les niveaux d’éducation. Ces mesures pourront porter sur les cantines, l’internat, les installations sanitaires, l’eau et l’électricité, qui ont un impact direct sur l’accès à l’éducation, notamment en milieu rural. 
                - Adopter des mesures temporaires spéciales, conformément au paragraphe 1 de l’article 4 de la Convention et à la recommandation générale 25 du Comité,  afin d’assurer la scolarisation régulière et continue des filles. 
                - Poursuivre les efforts visant à améliorer le niveau d’alphabétisation des femmes et des filles grâce à l’adoption de programmes complets d’enseignement scolaire et extrascolaire, d’éducation des adultes et de formation et à mettre l’accent sur le recrutement et la formation d’enseignants supplémentaires, l’élaboration de matériel pédagogique intégrant la problématique hommes-femmes et le suivi et l’évaluation des progrès réalisés par rapport à des objectifs assortis de délais", @"إتاحة فرصة الالتحاق بالتعليم بكافة مراحله للفتيات والنساء. وقد تشمل هذه التدابير توفير المقاصف، ومرافق السكن الدراسي، ومرافق الصرف الصحي الملائمة، وتوافر المياه والكهرباء، وهي أمور لها أثرها المباشر على إعمال حق المرأة في الحصول على التعليم وخاصة في المناطق الريفية. 
                -اعتماد تدابير استثنائية مؤقتة لكفالة إبقاء الفتيات في المدارس وفقا لما جاء في الفقرة 1 من المادة 4 من الاتفاقية وفي التوصية العامة رقم 25 للجنة،
                -مواصلة تعزيز الجهود لتحسين مستوى الإلمام بالقراءة والكتابة لدى الفتيات والنساء، وذلك عن طريق اعتماد برامج شاملة للتعليم النظامي وغير النظامي، وتعليم الكبار وتدريبهم، وزيادة التدريب وفرص العمل المتاحة للمدرسين، ووضع مواد تعليمية مراعية للمنظور الجنساني، ورصد وتقييم التقدم المحرز نحو تحقيق أهداف محددة بأطر زمنية. 
                -رفع مستوى الوعي عموما بأهمية التعليم كحق من حقوق الإنسان وكأساس لتمكين المرأة، وعلى اتخاذ خطوات للتغلب على أنماط السلوك التقليدية التي تعمل على استدامة التمييز", "", "" },
                    { 215, null, "R21P1P2", "ت.21.ف1.ف.2", "", "Réalisé", "", 100, 3, null, 6, null, 14, null, "Organes de traités", @"Promulguer au plus vite, conformément à la recommandation générale no 19, une législation visant la violence à l’égard des femmes et des filles, notamment la violence dans la famille, pour ériger en infraction pénale toutes les formes de violence à l’égard des femmes et veiller à ce que les femmes et les filles victimes de violence aient immédiatement accès à des moyens de protection, y compris à des foyers d’accueil, et puissent obtenir réparation et à ce que les auteurs soient poursuivis et punis comme il convient.
                    
                -Modifier le Code pénal pour criminaliser le viol conjugal et s’assurer que les auteurs de viols n’échappent pas aux poursuites pénales quand ils épousent leur victime", @"إصدار تشريع بشأن العنف ضد النساء والفتيات، بما في ذلك العنف الأسري، بحيث يكفل هذا التشريع تجريم جميع أشكال العنف ضد المرأة، وحصول النساء والفتيات من ضحايا العنف على سبل الحماية الفورية، بما فيها الملاجئ ووسائل الانتصاف، ومحاكمة مرتكبي هذه الجرائم وإنزال العقوبة المناسبة بهم. 
                -إدخال تعديل على قانون العقوبات لضمان تجريم الاغتصاب الزوجي وعدم إيقاف الإجراءات الجنائية ضد الجناة حين يتزوجون ضحاياهم.", "", "" },
                    { 180, null, "R40", "ت.40", "", "Réalisé", "", 100, 4, null, 5, null, 14, null, "Organes de traités", @"Prendre toutes les mesures nécessaires pour s’assurer que les enfants des travailleurs migrants, y compris ceux en situation irrégulière, aient accès à l’éducation sur la base de l’égalité de traitement. 
                Mettre en place des programmes, politiques et des mécanismes pour prévenir la discrimination dans le système scolaire. 

                Prendre toutes les dispositions nécessaires pour faire figurer dans son prochain rapport périodique des données ventilées par sexe, âge et nationalité sur le nombre d’enfants de travailleurs migrants dans les établissements primaires et secondaires, y compris lorsque les enfants ou leurs parents sont en situation irrégulière", @"اتخاذ جميع التدابير اللازمة لضمان حصول أبناء العمال المهاجرين، بمن فيهم الموجودون في وضع غير قانوني، على التعليم على أساس المساواة في المعاملة. 
                وضع برامج وسياسات وآليات لمنع التمييز في النظام المدرسي. وتدعو اللجنة الدولة الطرف إلى اتخاذ جميع التدابير اللازمة لتضمين تقريرها الدوري المقبل بيانات مُصنَّفة بحسب الجنس والسن والجنسية فيما يتعلق بعدد أطفال العمال المهاجرين في مؤسسات التعليم الابتدائي والثانوي، بما يشمل الحالات التي يكون فيها الأطفال أو آباؤهم في وضع غير قانوني.", "", "" },
                    { 149, null, "R48", "ت.48", "", "En cours", "", 30, 4, null, 4, null, 14, null, "Organes de traités", @"Redoubler les efforts pour offrir l’enseignement primaire, secondaire et universitaire en amazigh, augmenter la présence de cette langue dans la télévision et régler définitivement la question des prénoms amazighs.
                - Prendre des mesures pour garantir aux Amazighs et aux Sahraouis la jouissance pleine et sans restriction de leur droit de participer à la vie culturelle.
                - Prendre des mesures additionnelles pour protéger la diversité culturelle et permettre aux Amazighs et aux Sahraouis de préserver, de promouvoir, d’exprimer et de diffuser leur identité, leur histoire, leur culture, leur langue, leurs traditions et leurs coutumes.
                - Continuer à faciliter l’accès à la culture et à la science pour tous, y compris l’accès à Internet, en particulier pour les personnes handicapées et les personnes les plus démunies de sa population.", @"اتخاذ تدابير عاجلة لمعالجة المشاكل المتعلقة بنوعية التعليم العام والتسرب والرسوب المدرسيين. 
                - وضع نظام وبرنامج تعليميين ملائمين مع التركيز على التعليم ما قبل المدرسي، والتعليم أو محو الأمية باللغة الأم، والتدريب المهني، وتوجيه الأطفال المنقطعين عن الدراسة. 
                - اتخاذ تدابير إضافية لتحسين معدل التحاق البنات بالمدارس في المناطق الريفية، ولمنع اتساع نطاق التعليم الخاص بما يؤدي إلى تفاقم عدم المساواة في الحصول على التعليم الجيد. 
                - مراعاة الاحتياجات الخاصة للصحراويين بتوفير تعليم يمكنهم من الاضطلاع بدور فعال في مجتمع حر، وتشجيع التفاهم والتسامح والصداقة بين القوميات والمجموعات الإثنية.", "", "" },
                    { 620, null, "R88P2P4", "ت.88.ف.2.ف.4", "", "En cours", "", 30, 4, null, null, null, 12, 7, "Procédure spéciale", @"Procéder à des investissements pour entretenir les infrastructures et développer les maisons de la culture et des jeunes existantes 
                - Créer les possibilités et les conditions voulues pour que les jeunes, les femmes et les personnes handicapées puissent contribuer à la vie culturelle de la société. Des mesures concertées sont nécessaires pour garantir le financement de projets pour les jeunes, comme le groupe des «filles cavalières» de Khemisset", @"الاستثمار في صيانة الهياكل الأساسية ومواصلة تطوير المراكز الثقافية والشبابية القائمة؛
                - خلق فرص وظروف ملائمة للشباب والمرأة والأشخاص ذوي الإعاقة لكي يساهموا في الحياة الثقافية للمجتمع. ولا بد من تدابير تتضافر فيها الجهود من أجل ضمان الحصول على تمويل للمشاريع الخاصة بالشباب، مثل مشروع الفتيات الفارسات في مدينة الخميسات.", "", "" },
                    { 619, null, "R86P6-1", "ت.86.ف.6ج1", "", "En cours", "", 30, 4, null, null, null, 12, 7, "Procédure spéciale", "Elaborer un plan national d’action pour le développement culturel qui garantisse effectivement l’expression de la diversité culturelle. En particulier, de promouvoir les valeurs positives de la diversité culturelle par l’éducation, dans les médias et au moyen de programmes spéciaux destinés aux personnes handicapées. À cette fin, des ressources adéquates devraient être consacrées à la mise en œuvre des stratégies, politiques et programmes aux niveaux central, régional et local.", "-    (و) وضع خطة عمل وطنية للتنمية الثقافية تضمن بشكل فعال إبراز التنوع الثقافي؛ وعلى الخصوص، ترويج القيم الإيجابية للتنوع الثقافي من خلال التعليم ووسائط الإعلام وبرامج خاصة للأشخاص ذوي الإعاقة. ولتحقيق هذا الهدف، ينبغي تخصيص موارد كافية لتنفيذ الاستراتيجيات والسياسات والبرامج المناسبة على الصعيد المركزي والإقليمي والمحلي.", "", "" },
                    { 618, null, "R86P3-2", "ت.86.ف.3ج2", "", "En cours", "", 30, 4, null, null, null, 12, 7, "Procédure spéciale", "Respecter le droit d’avoir accès au patrimoine culturel de sa propre communauté et à celui des autres et d’en jouir, y compris l’histoire des communautés, leurs figures emblématiques et leur patrimoine linguistique", "-    (ج) ..... ينبغي للمغرب أن يحترم حق الفرد في الوصول إلى التراث الثقافي لجماعته وللآخرين والتمتع به، بما فيه تاريخ المجتمعات المحلية وشخصياتها البارزة وتراثها اللغوي؛", "", "" },
                    { 617, null, "R86P1-2", "ت.86.ف.1ج2", "", "En cours", "", 30, 4, null, null, null, 12, 7, "Procédure spéciale", "Renforcer l’appui à la promotion et à la préservation de la culture amazighe en allouant des subventions aux artistes, théâtres et associations culturelles amazighs, y compris aux groupes d’artistes amazighs qui voyagent à l’étranger et représentent la culture marocaine", @"(أ) زيادة الدعم المقدم من أجل تعزيز الثقافة الأمازيغية والحفاظ عليها من خلال ما يلي:
                - تخصيص إعانات للفنانين الأمازيغ والمسارح والجمعيات الثقافية الأمازيغية، بما في ذلك الفنانون الأمازيغ ضمن الفرق التي تسافر إلى الخارج لتمثيل ثقافة المغرب", "", "" },
                    { 223, null, "R43", "ت.43", "", "En cours", "", 30, 4, null, 6, null, 11, null, "Organes de traités", "Prendre des mesures, dans le cadre de ses efforts d’intégration de la problématique hommes-femmes et de son Initiative nationale pour le développement humain, pour remédier à la vulnérabilité des femmes démunies, notamment en garantissant leur représentation dans les instances participatives qui gèrent les programmes de réduction de la pauvreté. Il exhorte l’État partie à recourir à cet effet à des mesures temporaires spéciales au titre du paragraphe 1 de l’article 4.", "اتخاذ تدابير من خلال الجهود المبذولة في مجال التعميم، وفي المبادرة الوطنية للتنمية البشرية، لمعالجة تعرض المرأة على وجه التحديد لمخاطر الفقر، ومن بينها الجهود الرامية لكفالة تمثيل المرأة في النُهج التشاركية المتبعة في إدارة برامج تخفيف حدة الفقر. وتحث اللجنة الدولة الطرف على أن تستخدم في هذا الصدد التدابير الخاصة المؤقتة عملا بالفقرة 1 من المادة 4 من الاتفاقية والتوصية العامة رقم 25.", "", "" },
                    { 145, null, "R42", "ت.42", "", "En cours", "", 30, 4, null, 4, null, 11, null, "Organes de traités", @"Intensifier les efforts pour réduire la pauvreté, notamment en utilisant une stratégie de réduction de la pauvreté fondée sur les droits de l’homme qui cible spécifiquement les besoins des individus et des groupes défavorisés et marginalisés, en allouant des ressources financières suffisantes ou autres ressources pour sa mise en œuvre et en veillant à ce que ces ressources soient équitablement réparties entre tous ceux touchés par la pauvreté. 
                - le Comité renvoie l’État partie à sa Déclaration sur la pauvreté et le Pacte international relatif aux droits économiques, sociaux et culturels (2001).", @"تكثيف الجهود للحد من الفقر بطرق خاصة منها وضع استراتيجية للحد من الفقر تقوم على حقوق الإنسان وتركز تحديداً على احتياجات المحرومين والمهمشين، أفراداً وجماعات، وذلك بتخصيص ما يكفي من الموارد المالية وغير المالية لتنفيذ هذه الاستراتيجية، 
                - الحرص على توزيع هذه الموارد توزيعاً عادلاً بين جميع ضحايا الفقر.
                - وفي هذا الصدد، تحيل اللجنة الدولة الطرف إلى بيانها بشأن الفقر والعهد الدولي الخاص بالحقوق الاقتصادية والاجتماعية والثقافية (2001).", "", "" },
                    { 144, null, "R36", "ت.36", "", "En cours", "", 30, 4, null, 4, null, 11, null, "Organes de traités", @"Continuer le déploiement du système de sécurité sociale afin de parvenir à une couverture élargie de la population. 
                - Faire respecter l’obligation d’affiliation à la sécurité sociale par les entreprises privées, surtout en milieu rural, et d’améliorer la couverture sociale des salariés du secteur agricole tout en s’assurant que ces mesures se basent sur des institutions solides et des procédures accessibles à tous. 
                - Le Comité renvoie l’État partie à son observation générale no 19 (2007) sur le droit à la sécurité sociale et à sa Déclaration sur les socles de protection sociale (2015).", @"مواصلة توسيع نطاق نظام الضمان الاجتماعي من أجل زيادة عدد السكان المشمولين به. 
                - ضمان التزام الشركات الخاصة بالانخراط في مؤسسات الضمان الاجتماعي، ولا سيما في المناطق الريفية، 
                - تحسين التغطية الاجتماعية للعاملين في القطاع الزراعي مع ضمان الاستناد في هذه التدابير إلى مؤسسات راسخة وإجراءات تكون في متناول الجميع. 
                توجه اللجنة نظر الدولة الطرف إلى تعليقها العام رقم 19(2007) بشأن الحق في الضمان الاجتماعي وإلى إعلانها المتعلق بالأرضيات الوطنية للحماية الاجتماعية (2015).", "", "" },
                    { 143, null, "R26", "ت.26", "", "En cours", "", 30, 4, null, 4, null, 11, null, "Organes de traités", @"Garantir que le salaire minimum national s’applique à tous les secteurs, publics et privés, y compris au sein de l’économie informelle. 
                - Améliorer le salaire minimum agricole afin qu’il garantisse une existence décente aux travailleurs et aux membres de leur famille. 
                - Faire respecter le principe légal de salaire minimum, qui soit régulièrement réexaminé et fixé à un montant suffisant pour permettre à tous les travailleurs et travailleuses et aux membres de leur famille d ’avoir un niveau de vie décent.", @"ضمان تطبيق الحد الأدنى الوطني للأجور في جميع القطاعات، العام منها والخاص، بما في ذلك في الاقتصاد غير النظامي.
                - تحسين الحد الأدنى لأجر العامل الزراعي لكي يضمن العيش الكريم للعمال وأسرهم. 
                - ضمان الالتزام بمبدأ الحد الأدنى للأجر المقرر قانوناً ومراجعته بانتظام وتحديده عند مبلغ يكفي لتوفير مستوى عيش لائق لجميع العمال والعاملات ولأفراد أسرهم.", "", "" },
                    { 142, null, "R14P2P4", "ت.14.ف.2.ف.4", "", "En cours", "", 30, 4, null, 4, null, 11, null, "Organes de traités", @"b) Prendre toutes les mesures nécessaires pour remédier aux disparités régionales qui ne permettent pas à toute la population de jouir sur un pied d’égalité des droits économiques, sociaux et culturels.
                - d) Assurer que les femmes, les personnes handicapées, les demandeurs d’asile, les réfugiés, les migrants, les Sahraouis, les enfants nés hors mariage et les homosexuels puissent jouir des droits reconnus par le Pacte, en particulier l’accès à l’emploi, aux services sociaux, aux soins de santé et à l’éducation.", @"- (ب) اتخاذ جميع التدابير التصحيحية اللازمة لمعالجة الفوارق بين الأقاليم التي تحول دون تمتع جميع السكان بالحقوق الاقتصادية والاجتماعية والثقافية على قدم المساواة؛
                - (د) الحرص على تمكين النساء والأشخاص ذوي الإعاقة وملتمسي اللجوء واللاجئين والمهاجرين، والصحراويين والأطفال غير الشرعيين والمثليين من التمتع بحقوقهم المعترف بها في العهد، بما في ذلك إمكانية الحصول على العمل والخدمات الاجتماعية والرعاية الصحية والتعليم", "", "" },
                    { 1051, null, "R144.240", "240.144", "", "En cours", "", 30, 3, 1, null, 67, 10, null, "Examen périodique universal", "Accélérer l’examen du cadre juridique en matière de migration et d’asile afin de l’aligner sur le Pacte international relatif aux droits civils et politiques", "تسريع استعراض الإطار القانوني المتعلق بالهجرة واللجوء بهدف مواءمته مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 1050, null, "R144.106", "106.144", "", "En cours", "", 30, 3, 1, null, 68, 10, null, "Examen périodique universal", "Accélérer le processus de révision du cadre législatif régissant les prisons en vue de l’harmoniser avec la Constitution de 2011 et les normes internationales", "تسريع عملية مراجعة الإطار التشريعي الذي ينظم السجون بغية مواءمته مع دستور عام 2011 ومع المعايير الدولية", "", "" },
                    { 1049, null, "R144.103", "103.144", "", "Réalisé", "", 100, 3, 1, null, 20, 10, null, "Examen périodique universal", "Accélérer le processus de révision du cadre juridique régissant les prisons afin de l’harmoniser avec les normes internationales", "تسريع عملية مراجعة الإطار القانوني الذي ينظم السجون بهدف مواءمته مع المعايير الدولية", "", "" },
                    { 1048, null, "R144.112", "112.144", "", "Réalisé", "", 100, 3, 1, null, 98, 10, null, "Examen périodique universal", "Veiller à ce que les dispositions pertinentes du Code pénal soient mises en conformité avec les obligations du Maroc en vertu du Pacte international relatif aux droits civils et politiques, en particulier en ce qui concerne la liberté d’expression et d’opinion", "ضمان جعل الأحكام ذات الصلة من قانون المسطرة الجنائية أو من القانون الجنائي متماشية مع التزامات المغرب الناشئة عن العهد الدولي الخاص بالحقوق المدنية والسياسية ولا سيما فيما يتعلق بحرية الكلام والرأي", "", "" },
                    { 1047, null, "R144.36P2", "36.144. ج.2", "", "Réalisé", "", 100, 3, 1, null, 42, 10, null, "Examen périodique universal", "mettre la législation nationale en conformité avec le Statut de Rome de la Cour pénale internationale", "......مواءمة التشريعات مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" },
                    { 1046, null, "R144.15 P2", "15.144. ج.2", "", "Réalisé", "", 100, 3, 1, null, 65, 10, null, "Examen périodique universal", "adapter pleinement sa législation à toutes les obligations énoncées dans le Statut de Rome de la Cour pénale internationale", "...... جعل التشريعات الوطنية متسقة اتساقاً كاملاً مع جميع الالتزامات الناشئة عن نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" },
                    { 1045, null, "R144.14 P2", "14.144ج.2", "", "Réalisé", "", 100, 3, 1, null, 53, 10, null, "Examen périodique universal", "rendre lalégislation nationale pleinement conforme au Statut de Rome de la Cour pénale internationale, comme cela a été recommandé précédemment", "......جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية وفق ما تمّت التوصية به سابقاً", "", "" },
                    { 1044, null, "R144.12 P2", "12.144ج.2", "", "Réalisé", "", 100, 3, 1, null, 8, 10, null, "Examen périodique universal", "mettre la législation nationale en conformité avec les dispositions du Statut de Rome de la Cour pénale internationale", "...... جعل التشريعات الوطنية متسقة مع أحكام نظام روما الأساسي للمحكمة الجنائية الدولية", "", "" },
                    { 1043, null, "R144.116", "116.14", "", "Réalisé", "", 100, 3, 1, null, 70, 10, null, "Examen périodique universal", "Examiner les dispositions du Code pénal relatives à la liberté d’expression à la lumière de l’article 19 du Pacte international relatif aux droits civils et politiques", "استعراض أحكام القانون الجنائي المتعلقة بحرية التعبير بما يتوافق مع المادة 19 من العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 1042, null, "R144.86", "86.144", "", "Réalisé", "", 100, 3, 1, null, 2, 10, null, "Examen périodique universal", "Réviser les dispositions du Code pénal sur le terrorisme en vue de définir précisément les infractions liées au terrorisme et veiller à ce que la législation soit en conformité avec le Pacte international relatif aux droits civils et politiques", "مراجعة أحكام القانون الجنائي المتعلقة بالإرهاب بغية وضع تعريف دقيق للجرائم المرتبطة بالإرهاب، وضمان أن تكون التشريعات متسقة مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 1041, null, "R144.35", "35.144", "", "Réalisé", "", 100, 3, 1, null, 40, 10, null, "Examen périodique universal", "Prendre des mesures pour mettre la définition de la torture en conformité avec celle énoncée dans la Convention contre la torture et autres peines ou traitements cruels, inhumains ou dégradants", "اتخاذ خطوات لجعل تعريف التعذيب متوافقاً مع متطلبات اتفاقية مناهضة التعذيب وغيره من ضروب المعاملة أو العقوبة القاسية أو اللاإنسانية أو المهينة", "", "" },
                    { 1040, null, "R144.31", "31.144", "", "Réalisé", "", 100, 3, 1, null, 32, 10, null, "Examen périodique universal", "Faire en sorte que le Code pénal soit pleinement en conformité avec le Pacte international relatif aux droits civils et politiques", "ضمان أن يكون القانون الجنائي متوافقاً تماماً مع العهد الدولي الخاص بالحقوق المدنية والسياسية", "", "" },
                    { 639, null, "R73P6-2", "null", "", "En cours", "", 30, 3, null, null, null, 10, 8, "Procédure spéciale", "Envisager de faire figurer des dispositions sur la question relative à la mise  en place un cadre de suivi des fonds étrangers reçus par les acteurs de la société civile dans le projet de loi sur la société civile, conformément aux normes internationales relatives aux droits de l’homme mentionnées dans le rapport du Rapporteur spécial sur le droit de réunion pacifique et la liberté d’association (A/HRC/23/39)", "null", "", "" },
                    { 593, null, "R83P24", "null", "", "En cours", "", 30, 3, null, null, null, 10, 6, "Procédure spéciale", "-       Envisager de modifier l’article 134 du Code pénal afin de s’assurer que tous les délinquants souffrant d’une incapacité mentale soient placés dans un établissement psychiatrique, quelle que soit la gravité de l’infraction", "null", "", "" },
                    { 592, null, "R83P21", "null", "", "En cours", "", 30, 3, null, null, null, 10, 6, "Procédure spéciale", "-       Étudier l’amendement de l’article 473 du Code de procédure pénale visant à reculer l’âge auquel un jeune délinquant peut être incarcéré de12à 18 ans, et souligner que l’emprisonnement des jeunes délinquants est une mesure exceptionnelle ;", "null", "", "" },
                    { 591, null, "R83P4", "null", "", "En cours", "", 30, 3, null, null, null, 10, 6, "Procédure spéciale", @"Modifier le Code de procédure pénale pour indiquer qu’en cas d’allégation de torture ou de mauvais traitements, la charge de la preuve incombe à l’accusation qui devra prouver, hors de tout doute raisonnable, que les aveux n’ont pas été obtenus par des moyens illégaux. 
                - Les allégations de torture et de mauvais traitements devraient être admises à n’importe quel stade du procès et les tribunaux devraient être tenus de lancer des enquêtes d’office chaque fois qu’il y a des motifs raisonnables de suspecter des actes de torture ou de mauvais traitements", "null", "", "" },
                    { 590, null, "R83P3", "null", "", "En cours", "", 30, 3, null, null, null, 10, 6, "Procédure spéciale", "-       Modifier la loi antiterroriste (no 03-03) en vue de remédier à la définition vague du crime de terrorisme et de réduire la durée de la garde à vue qui est de quatre-vingt-seize heures renouvelables deux fois", "null", "", "" },
                    { 589, null, "R83P1", "null", "", "En cours", "", 30, 3, null, null, null, 10, 6, "Procédure spéciale", @"Garantir, par des modifications de la législation, que l’accès à un avocat choisi par le suspect lui-même soit accordé dès l’arrestation, sans la présence d’un enquêteur et sans nécessiter l’autorisation du Procureur, y compris dans les affaires touchant à la sécurité nationale et de terrorisme. 
                - Cet accès devrait être garanti par la loi et tout fonctionnaire qui refuserait d’accorder l’accès à un avocat devrait être sanctionné", "null", "", "" },
                    { 563, null, "R89P1", "null", "", "En cours", "", 30, 3, null, null, null, 10, 5, "Procédure spéciale", "Mettre toutes les lois nationales en conformité avec les instruments internationaux relatifs aux droits de l’homme auxquels le Maroc est partie et de modifier ou d’abroger les dispositions discriminatoires qui subsistent dans les lois nationales", "null", "", "" },
                    { 535, null, "R80P1", "null", "", "Réalisé", "", 100, 3, null, null, null, 10, 4, "Procédure spéciale", "-    Veiller à la pleine application, en droit interne, du Protocole additionnel à la Convention des Nations Unies contre la criminalité transnationale organisée visant à prévenir, réprimer et punir la traite des personnes, en particulier des femmes et des enfants, qui impose à l’État de prévenir et de combattre la traite des êtres humains.", "null", "", "" },
                    { 444, null, "R70P1P2", "null", "", "Non réalisé", "", 0, 3, null, null, null, 10, 2, "Procédure spéciale", @"Adopter un cadre juridique et politique global de lutte contre la discrimination qui met en application l’intégralité des dispositions relatives à l’égalité raciale de la Convention internationale sur l’élimination de toutes les formes de discrimination raciale, conformément aux recommandations du Comité pour l’élimination de la discrimination raciale. 
                - Afin de garantir la pleine conformité avec l’article premier de la Convention, réviser la législation existante ou adopter une nouvelle loi de façon à interdire expressément la discrimination raciale telle que définie dans la Convention.", "null", "", "" },
                    { 403, null, "R67P2", "null", "", "En cours", "", 30, 3, null, null, null, 10, 1, "Procédure spéciale", "-   Veiller à ce que les lois en cours de révision soient conformes aux normes internationales relatives aux droits de l’homme.", "null", "", "" },
                    { 272, null, "R51P2", "ت.51.ف.2", "", "En cours", "", 30, 4, null, 7, null, 11, null, "Organes de traités", "b) Empêcher le placement automatique d’enfants nés hors mariage et d’enfants vivant dans la pauvreté sous le régime de la kafalah en fournissant aux mères célibataires et/ou aux parents le soutien nécessaire pour qu’ils puissent prendre en charge leurs enfants;", "-           (ب) منع الكفالة التلقائية للأطفال غير المولودين خارج إطار الزواج والأطفال الفقراء عن طريق إمداد الأمهات غير المتزوجات و/أو الوالدين بما يلزم من دعم لرعاية أطفالهم؛", "", "" },
                    { 279, null, "R65P1", "ت.65.ف.1", "", "En cours", "", 30, 4, null, 7, null, 14, null, "Organes de traités", "a) prendre immédiatement des mesures vigoureuses pour faire cesser l’emploi de filles comme domestiques dans des conditions abusives, d’assurer à ces filles une éducation, notamment une formation professionnelle et de fournir des informations détaillées dans le prochain rapport périodique sur les mesures prises et les résultats obtenus;", "-          (أ) اتخاذ تدابير فورية وحازمة لانتشال الفتيات العاملات خادمات منازل من ظروف العمل الظالمة، وتوفير التعليم لهن، بما فيه التدريب المهني، وإمداد اللجنة في تقريرها الدوري المقبل بمعلومات وافية عن تلك التدابير وما تمخضت عنه من نتائج؛", "", "" },
                    { 273, null, "R59", "ت.59", "", "En cours", "", 30, 4, null, 7, null, 11, null, "Organes de traités", @"Prendre toutes les mesures nécessaires, notamment des mesures de discrimination positives, pour faire face aux disparités économiques dont souffrent les régions rurales et les banlieues urbaines et qui font que des enfants ne jouissent pas de leurs droits sur un pied d’égalité avec les autres. 
                - Mesurer l’incidence des programmes de protection sociale et revoir ces programmes pour faire en sorte qu’ils soient durables et accessibles aux enfants les plus vulnérables et les plus défavorisés;
                - Songer à tenir des consultations ciblées avec les familles, les enfants et les organisations de la société civile qui s’occupent des droits de l’enfant sur la question de la pauvreté des enfants.", @"اتخاذ جميع التدابير اللازمة، بما فيها سياسات التمييز الإيجابي، لتضييق الفوارق الاقتصادية التي تضر بالمناطق الريفية وضواحي المدن والتي تؤدي بعدم تمتع الأطفال بحقوقهم على قدم المساواة. 
                - تقييم آثار برامج الضمان الاجتماعي ومراجعتها بحيث تكون مستدامة وميسّرة لأكثر الأطفال استضعافاً وحرماناً.
                - النظر في عقد مشاورات محددة الغرض مع الأسر والأطفال ومنظمات المجتمع المدني المعنية بحقوق الأطفال لمعالجة قضية فقر الأطفال", "", "" },
                    { 332, null, "R41", "ت.41", "", "En cours", "", 30, 4, null, 8, null, 11, null, "Organes de traités", "Adopter des mesures pour faciliter l’acquisition des aides à la mobilité et des appareils et accessoires fonctionnels, notamment les technologies d’assistance, les aides humaines ou animalières et les services de médiateur, et de mettre en place des mesures concrètes visant à simplifier les procédures administratives s’appliquant aux exemptions fiscales et douanières spéciales accordées pour l’achat de véhicules automobiles adaptés.", "-      اعتماد تدابير لتيسير الحصول على ما يلزم من وسائل وأجهزة مساعدة على التنقل، بما في ذلك التكنولوجيات المساعدة والمساعدة البشرية والوسطاء، ووضع تدابير محددة لتبسيط الإجراءات الإدارية المطبقة بشأن الإعفاءات الجمركية والضريبية الخاصة الممنوحة لشراء المركبات الآلية المعدة للمقعدين.", "", "" },
                    { 616, null, "R85", "ت.85", "", "En cours", "", 30, 4, null, null, null, 12, 7, "Procédure spéciale", "Envisager la diversité culturelle comme une ressource inestimable pour associer chacun à la vie du pays, et à prendre des mesures pour qu’il soit tenu compte de la diversité culturelle et du patrimoine culturel des diverses populations du pays, notamment en assurant la promotion de ces cultures par l’éducation, dans les médias et au moyen d’activités culturelles, en améliorant les compétences interculturelles de toutes les institutions officielles et en encourageant le bilinguisme dans la fonction publique.", "-    النظر إلى التنوع الثقافي كمورد لا يقدر بثمن لإدماج الجميع، واتخاذ تدابير لتعميم التنوع الثقافي والتراث الثقافي لسكان البلد المتنوعين عن طريق جملة أمور منها الترويج لهذه الثقافات من خلال التثقيف ووسائط الإعلام والأنشطة الثقافية، وتعزيز الكفاءات متعددة الثقافات لدى جميع المؤسسات الرسمية وتشجيع المهارات ثنائية اللغة في صفوف الموظفين الحكوميين.", "", "" },
                    { 447, null, "R78P2", "null", "", "En cours", "", 30, 4, null, null, null, 12, 2, "Procédure spéciale", "-       Prendre des mesures provisoires pour prévenir et atténuer toutes les formes de discrimination linguistique et culturelle dans tous les domaines.", "null", "", "" },
                    { 446, null, "R72", "null", "", "En cours", "", 30, 4, null, null, null, 12, 2, "Procédure spéciale", "-       Recueillir au moyen d’indicateurs des données fiables et ventilées qui rendent fidèlement compte de la diversité raciale, culturelle et ethnique de la population marocaine, y compris de la diversité linguistique − dont témoignent bien les indicateurs qui mesurent l’utilisation de la langue orale et le degré d’alphabétisation", "null", "", "" },
                    { 147, null, "R50P2P3P4P5", "ت.50.ف.2.ف.3ف.4.ف.5", "", "En cours", "", 30, 4, null, 4, null, 12, null, "Organes de traités", @"Redoubler les efforts pour offrir l’enseignement primaire, secondaire et universitaire en amazigh, augmenter la présence de cette langue dans la télévision et régler définitivement la question des prénoms amazighs.
                - Prendre des mesures pour garantir aux Amazighs et aux Sahraouis la jouissance pleine et sans restriction de leur droit de participer à la vie culturelle.
                - Prendre des mesures additionnelles pour protéger la diversité culturelle et permettre aux Amazighs et aux Sahraouis de préserver, de promouvoir, d’exprimer et de diffuser leur identité, leur histoire, leur culture, leur langue, leurs traditions et leurs coutumes.
                - Continuer à faciliter l’accès à la culture et à la science pour tous, y compris l’accès à Internet, en particulier pour les personnes handicapées et les personnes les plus démunies de sa population", @"تكثيف الجهود من أجل توفير التعليم الابتدائي والثانوي والجامعي باللغة الأمازيغية، وزيادة الحيز المخصص لها في التلفزيون، وإيجاد حل نهائي لمسألة الأسماء الأمازيغية. 
                - اتخاذ تدابير تكفل للأمازيغ والصحراويين التمتع كلياً بحقهم في المشاركة في الحياة الثقافية دون تقييد. 
                - اتخاذ تدابير إضافية لحماية التنوع الثقافي، وتمكين الأمازيغ والصحراويين من صون هويتهم وتاريخهم وثقافتهم ولغتهم وعاداتهم وتقاليدهم وتعزيزها والتعبير عنها ونشرها. 
                - المضي في تيسير سبل تمتع الجميع بالثقافة والعلوم، بما في ذلك تيسير إمكانية الوصول إلى شبكة الإنترنت، ولا سيما للأشخاص ذوي الإعاقة وللسكان الأشد عوزاً. وفي هذا الصدد، تحيل اللجنة الدولة الطرف إلى تعليقها العام رقم 21(2009) بشأن حق كل فرد في المشاركة في الحياة الثقافية.", "", "" },
                    { 146, null, "R14P3", "ت.14.ف.3", "", "Réalisé", "", 100, 4, null, 4, null, 12, null, "Organes de traités", @"Tenant en compte son observation générale no 20 (2009) sur la non-discrimination dans l’exercice des droits économiques, sociaux et culturels, le Comité appelle à :
                - Prendre des mesures pour assurer aux Amazighs la pleine jouissance de leurs droits consacrés par le Pacte en adoptant si nécessaire des mesures spéciales temporaires", @"رجوعا إلى تعليقها العام رقم 20(2009) بشأن عدم التمييز في الحقوق الاقتصادية والاجتماعية والثقافية، تدعو اللجنة إلى:
                - - (ج) اتخاذ تدابير تكفل للأمازيغ التمتع كلياً بحقوقهم المنصوص عليها في العهد من خلال اعتماد تدابير خاصة مؤقتة عند الاقتضاء؛", "", "" },
                    { 104, null, "R50", "-          ت.50", "", "Réalisé", "", 100, 4, null, 3, null, 12, null, "Organes de traités", "Accélérer ses efforts en vue de l’adoption prochaine d’une loi organique sur la langue amazighe, pour promouvoir l’accès des Amazighs à un enseignement dans leur langue, et permettre l’utilisation de la langue amazighe lors de procédures judiciaires et administratives ainsi que l’enregistrement des prénoms amazighs.", "تسريع جهودها لاعتماد القانون التنظيمي المتعلق باللغة الأمازيغية قريباً، من أجل تشجيع حصول الأمازيغ على التعليم بلغتهم، والسماح باستعمال الأمازيغية في الإجراءات القضائية والإدارية، إضافة إلى تسجيل الأسماء الأمازيغية.", "", "" },
                    { 1062, null, "144.161", "161.144", "", "En cours", "", 30, 4, 1, null, 25, 11, null, "Examen périodique universal", "Améliorer le système de protection sociale en vue d’étendre la couverture sociale et médicale à toute personne", "تحسين نظام الحماية الاجتماعية بهدف توسيع نطاق التغطية الاجتماعية والطبية لتشمل كل فرد", "", "" },
                    { 1061, null, "R144.151", "151.144", "", "En cours", "", 30, 4, 1, null, 33, 11, null, "Examen périodique universal", "Assurer une répartition équitable des ressources entre les zones rurales et les zones urbaines", "ضمان التوزيع المنصف للموارد بين الأرياف والحواضر", "", "" },
                    { 1060, null, "R144.150", "150.144", "", "Réalisé", "", 100, 4, 1, null, 15, 11, null, "Examen périodique universal", "Continuer d’adopter des mesures visant à améliorer la vie des personnes vulnérables dans le pays", "مواصلة اعتماد تدابير لتحسين عيشة ضعاف الحال في البلد", "", "" },
                    { 1059, null, "R144.149", "149.144", "", "Réalisé", "", 100, 4, 1, null, 88, 11, null, "Examen périodique universal", "Partager avec d’autres pays son expérience dans le domaine du développement humain et de la réduction de la pauvreté", "تبادل تجربته مع غيره في مجال التنمية البشرية والحد من الفقر", "", "" },
                    { 1058, null, "R144.148", "148.144", "", "Réalisé", "", 100, 4, 1, null, 68, 11, null, "Examen périodique universal", "Continuer de renforcer les programmes visant à réduire la pauvreté dans le cadre de l’Initiative nationale pour le développement humain", "مواصلة تقوية البرامج للحد من الفقر من خلال المبادرة الوطنية للتنمية البشرية", "", "" },
                    { 1057, null, "R144.147", "147.144", "", "Réalisé", "", 100, 4, 1, null, 78, 11, null, "Examen périodique universal", "Poursuivre les efforts pour réduire la pauvreté et combler l’écart de revenu entre les différentes régions et entre les zones rurales et les zones urbaines", "مواصلة الجهود الرامية إلى الحد من الفقر وسد الفارق في الدخل بين منطقة وأخرى وبين الأرياف والحواضر", "", "" },
                    { 1056, null, "R144.146", "146.144", "", "Réalisé", "", 100, 4, 1, null, 28, 11, null, "Examen périodique universal", "Poursuivre la mise en œuvre de politiques de lutte contre la pauvreté et de promotion du développement économique", "مواصلة تنفيذ السياسات الرامية إلى مكافحة الفقر وتشجيع التنمية الاقتصادية", "", "" },
                    { 1055, null, "R144.145", "145.144", "", "Réalisé", "", 100, 4, 1, null, 22, 11, null, "Examen périodique universal", "Poursuivre les efforts visant à protéger les droits économiques et sociaux par la mise en œuvre de programmes de lutte contre la pauvreté, dans le cadre de l’Initiative nationale de développement humain", "مواصلة الجهود من أجل حماية الحقوق الاقتصادية والاجتماعية عن طريق تنفيذ برامج مكافحة الفقر في إطار المبادرة الوطنية للتنمية البشرية", "", "" },
                    { 1054, null, "R144.144", "144.144", "", "Réalisé", "", 100, 4, 1, null, 4, 11, null, "Examen périodique universal", "Continuer de promouvoir la consolidation de sa politique sociale et lutter contre la pauvreté et les inégalités, qui sont toujours présentes", "مواصلة تشجيع تكامل سياساته الاجتماعية ومكافحة الفقر وعدم المساواة اللذين لا يزالان موجودين", "", "" },
                    { 1053, null, "R144.143", "143.144", "", "Réalisé", "", 100, 4, 1, null, 78, 11, null, "Examen périodique universal", "Améliorer l’identification des bénéficiaires des régimes de protection sociale", "تحسين وسائل تحديد ذوي الأهلية للاستفادة من خطط الحماية الاجتماعية", "", "" },
                    { 1052, null, "R144.140", "140.144", "", "Réalisé", "", 100, 4, 1, null, 96, 11, null, "Examen périodique universal", "Allouer davantage de ressources à la mise en œuvre de politiques nationales en faveur des groupes sociaux vulnérables", "تخصيص مزيد من الموارد لتنفيذ السياسات الوطنية لصالح الفئات الاجتماعية الضعيفة", "", "" },
                    { 536, null, "R94", "null", "", "En cours", "", 30, 4, null, null, null, 11, 4, "Procédure spéciale", "-    En sus des mesures juridiques et des politiques adoptées pour lutter contre la traite des êtres humains, des efforts devraient être faits pour remédier aux causes profondes de ce problème, notamment l’exclusion sociale, la pauvreté, les inégalités et la discrimination.", "null", "", "" },
                    { 445, null, "R73", "null", "", "Réalisé", "", 100, 4, null, null, null, 11, 2, "Procédure spéciale", "-       Envisager l’adoption de mesures spéciales pour garantir aux groupes défavorisés, dans des conditions d’égalité, la pleine jouissance des droits de l’homme et des libertés fondamentales.", "null", "", "" },
                    { 409, null, "R96P3", "null", "", "En cours", "", 30, 4, null, null, null, 11, 1, "Procédure spéciale", @"Pour les provinces marocaines du sud : 
                - Offrir à la population locale les mêmes possibilités d’éducation et d’emploi, en vue de réduire la pauvreté et d’assurer la sécurité alimentaire et nutritionnelle de tous, conformément au droit international.", "null", "", "" },
                    { 408, null, "R94", "null", "", "En cours", "", 30, 4, null, null, null, 11, 1, "Procédure spéciale", @"Pour les provinces marocaines du sud : 
                - Adopter une stratégie de réduction de la pauvreté fondée sur les droits de l’homme qui cible spécifiquement les besoins des individus et des groupes défavorisés et marginalisés, en allouant des ressources financières suffisantes ou autres ressources pour sa mise en œuvre et en veillant à ce que ces ressources soient équitablement réparties entre tous ceux touchés par la pauvreté, conformément aux recommandations du Comité des droits économiques, sociaux et culturels.", "null", "", "" },
                    { 407, null, "R85", "null", "", "En cours", "", 30, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Revoir, examiner et modifier les politiques et les programmes concernant la réduction de la pauvreté afin que les préoccupations relatives au genre soient réellement prises en compte", "null", "", "" },
                    { 406, null, "R75", "null", "", "En cours", "", 30, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Faire des populations urbaines pauvres, des petits agriculteurs et des communautés côtières qui sont particulièrement vulnérables face aux effets des changements climatiques les premiers bénéficiaires des évaluations des vulnérabilités, ainsi que des ressources financières et de l’appui destinés à l’adaptation et à l’atténuation", "null", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "Annee", "CodeRecommendation", "CodeRecommendationAr", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "NomAr", "Observation", "PieceJointe" },
                values: new object[,]
                {
                    { 405, null, "R71", "null", "", "En cours", "", 30, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Élaborer des programmes visant à renforcer les organisations communautaires en leur dispensant les formations voulues et en leur offrant l’appui nécessaire pour les aider à assurer elles-mêmes leur développement et à diversifier les activités agricoles, afin de créer de nouvelles possibilités d’emploi.", "null", "", "" },
                    { 404, null, "R68", "null", "", "En cours", "", 30, 4, null, null, null, 11, 1, "Procédure spéciale", "-   Affecter des ressources suffisantes à la mise en œuvre des mesures de réduction de la pauvreté énoncées dans l’Initiative nationale pour le développement humain, en accordant une attention particulière aux disparités structurelles en matière de mise en œuvre et en ciblant les besoins des personnes et des groupes désavantagés et marginalisés, en particulier de ceux vivant dans des zones reculées.", "null", "", "" },
                    { 334, null, "R53P1", "ت.53.ف.1", "", "En cours", "", 30, 4, null, 8, null, 11, null, "Organes de traités", "a) mettre en place un régime de protection sociale visant à garantir un niveau de vie suffisant aux personnes handicapées, notamment au moyen de systèmes d’indemnisation sous forme d’allocations qui permettront aux personnes handicapées de couvrir les dépenses liées au handicap", "(أ) وضع نظام للحماية الاجتماعية يرمي إلى كفالة تمتع الأشخاص ذوي الإعاقة بمستوى معيشي لائق، بما في ذلك عن طريق أنظمة التعويض على شكل بدلات تمكن الأشخاص ذوي الإعاقة من تغطية النفقات المرتبطة بالإعاقة؛", "", "" },
                    { 333, null, "R45P1", "ت.45.ف.1", "", "En cours", "", 30, 4, null, 8, null, 11, null, "Organes de traités", "Prendre des mesures pour fournir un soutien aux familles de personnes handicapées, notamment aux parents handicapés, afin de leur permettre d’élever leurs enfants à la maison", "-       (أ) اتخاذ تدابير لضمان تقديم الدعم لأسر الأشخاص ذوي الإعاقة، بمن فيهم الآباء ذوو الإعاقة، من أجل تنشئة أطفالهم في المنزل؛", "", "" },
                    { 331, null, "R39P3", "ت.39.ف.3", "", "En cours", "", 30, 4, null, 8, null, 11, null, "Organes de traités", "D’adopter un plan aux niveaux national et régional pour développer, dans les zones urbaines et les zones rurales, des services de soutien communautaire qui comprennent, entre autres, l’assistance personnelle, les subventions et le soutien aux familles d’enfants handicapés et aux parents handicapés, notamment en ce qui concerne la fourniture d’appareils et d’accessoires fonctionnels, de guides et d’interprètes en langue des signes", "-       (ج) اعتماد خطة على الصعيدين الوطني والإقليمي لتطوير خدمات الدعم المجتمعية في المناطق الحضرية والريفية، ويشمل ذلك تقديم المساعدة الشخصية والمنح والدعم لأسر الأطفال ذوي الإعاقة والآباء ذوي الإعاقة، بما في ذلك تقديم الدعم اللازم لتوفير الأجهزة المعينة، والمرشدين ومفسري لغة الإشارة؛", "", "" },
                    { 278, null, "R61", "ت.61", "", "En cours", "", 30, 4, null, 7, null, 14, null, "Organes de traités", @"Le Comité recommande au Maroc:
                a) De redoubler d’efforts pour assurer la scolarisation de tous les enfants aux niveaux primaire et secondaire en prenant des mesures ciblées pour toucher les enfants privés d’enseignement;
                b) De procéder à une évaluation correcte des lacunes du programme d’urgence pour 2009-2012 et d’adopter, sur la base des enseignements tirés de cette évaluation, toutes les mesures nécessaires pour assurer une utilisation et un contrôle effectifs et efficaces des ressources financières allouées au système éducatif;
                c) D’évaluer et de mesurer les conséquences du développement rapide de l’enseignement privé dans l’État partie et d’y faire face et faire en sorte que les enseignants du secteur public contribuent à l’amélioration du système éducatif au Maroc plutôt que d’être utilisés par le secteur privé, en appliquant efficacement la circulaire ministérielle no 109 du 3 septembre 2008;
                d) De prendre les mesures nécessaires pour améliorer la qualité de l’enseignement, notamment en dispensant aux enseignants une formation de qualité, et de développer et promouvoir la qualité de la formation professionnelle pour améliorer les qualifications des enfants et des jeunes, en particulier celles de ceux qui ont abandonné l’école;
                e) D’allouer des ressources financières suffisantes au développement et à l’expansion de l’éducation à la prime enfance dans les zones rurales, selon une approche globale et intégrée du développement et de la prise en charge de la petite enfance", @"توصي اللجنة المملكة المغربية بما يلي:
                (أ) تدعيم جهودها الرامية إلى ضمان التحاق جميع الأطفال بالتعليم الابتدائي والثانوي باتخاذ تدابير محددة الغرض موجهة إلى الأطفال المحرومين من التعليم؛
                - (ب) إجراء تقييم صحيح للثغرات الموجودة في البرنامج  الاستعجالي 2009-2012؛ وفي ضوء العبر المستخلصة، اتخاذ كل ما يلزم من تدابير تكفل استعمال الموارد المالية المخصصة لمنظومة التعليم ومراقبتها بفعالية وكفاءة؛
                - (ج) تقييم عواقب التطور السريع للتعليم الخاص في الدولة الطرف والتعامل معها، وضمان إسهام المعلمين العاملين في القطاع العام في تحسين التعليم في المغرب بدلاً من أن يستخدمهم القطاع الخاص، وذلك بإنفاذ المنشور الوزاري رقم 109  المؤرخ 3 أيلول/سبتمبر 2008 بفعالية؛
                - (د) اتخاذ التدابير اللازمة لتحسين نوعية التعليم، لا سيما بتدريب المعلمين تدريباً جيداً، وتطوير التعليم المهني الجيد وتشجيعه لتعزيز مهارات الأطفال والشباب، خاصة من تسربوا من المدرسة؛
                - (ه) رصد ما يكفي من موارد مالية لتطوير التعليم قبل المدرسة في المناطق الريفية وتوسيع نطاقه اعتماداً على سياسة شاملة وكلية بشأن الرعاية قبل المدرسة وتطويرها.", "", "" }
                });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "DetailAr", "IdRapport", "IdUser", "LienUpload" },
                values: new object[,]
                {
                    { 1, "quasi", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 31, 3, null },
                    { 94, "mollitia", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 26, 1, null },
                    { 65, "nihil", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 1, 1, null },
                    { 6, "quas", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 87, 1, null },
                    { 46, "corrupti", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 87, 3, null },
                    { 96, "amet", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 87, 1, null },
                    { 47, "aut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 66, 3, null },
                    { 18, "repudiandae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 82, 2, null },
                    { 63, "impedit", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 27, 1, null },
                    { 98, "eos", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 27, 1, null },
                    { 58, "possimus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 76, 2, null },
                    { 33, "ea", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 92, 2, null },
                    { 3, "a", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 5, 3, null },
                    { 71, "similique", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 13, 1, null },
                    { 100, "aperiam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 60, 1, null },
                    { 76, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 9, 3, null },
                    { 88, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 9, 3, null },
                    { 30, "molestias", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 72, 1, null },
                    { 91, "ab", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 72, 2, null },
                    { 23, "minus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 67, 3, null },
                    { 90, "harum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 41, 3, null },
                    { 10, "saepe", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 43, 3, null },
                    { 93, "quae", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 52, 2, null },
                    { 81, "rem", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 30, 1, null },
                    { 79, "natus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 47, 1, null },
                    { 48, "autem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 56, 2, null },
                    { 73, "autem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 14, 3, null },
                    { 14, "laboriosam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 2, 2, null },
                    { 21, "quod", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 2, 1, null },
                    { 52, "inventore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 2, 3, null },
                    { 57, "rem", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 2, 2, null },
                    { 75, "sed", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 2, 2, null },
                    { 59, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 80, 3, null },
                    { 66, "fuga", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 80, 1, null },
                    { 15, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 18, 2, null },
                    { 22, "repellat", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 18, 3, null },
                    { 77, "voluptate", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 18, 3, null },
                    { 20, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 22, 1, null },
                    { 45, "iure", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 12, 1, null },
                    { 42, "nesciunt", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 75, 1, null },
                    { 53, "vel", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 86, 1, null },
                    { 78, "quae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 86, 2, null },
                    { 27, "sunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 73, 2, null },
                    { 68, "vitae", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 93, 2, null },
                    { 50, "ut", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 49, 3, null },
                    { 85, "alias", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 49, 2, null },
                    { 54, "deserunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 64, 1, null },
                    { 67, "nam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 14, 1, null },
                    { 89, "expedita", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 14, 2, null },
                    { 95, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 53, 1, null },
                    { 26, "excepturi", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 84, 1, null },
                    { 5, "ut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 55, 1, null },
                    { 44, "fuga", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 17, 3, null },
                    { 40, "illum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 45, 1, null },
                    { 61, "blanditiis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 45, 1, null },
                    { 64, "voluptatem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 45, 2, null },
                    { 84, "nisi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 45, 3, null },
                    { 55, "facere", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 58, 1, null },
                    { 82, "omnis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 58, 3, null },
                    { 36, "consequatur", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 96, 1, null },
                    { 99, "praesentium", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 96, 3, null },
                    { 39, "soluta", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 32, 2, null },
                    { 43, "harum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 32, 3, null },
                    { 31, "quas", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 46, 3, null },
                    { 51, "totam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 46, 3, null },
                    { 32, "impedit", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 42, 2, null },
                    { 25, "aliquid", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 62, 2, null },
                    { 41, "voluptate", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 3, 1, null },
                    { 80, "corrupti", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 48, 2, null },
                    { 16, "aliquam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 97, 2, null },
                    { 86, "delectus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 97, 1, null },
                    { 11, "sed", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 70, 1, null },
                    { 97, "aliquid", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 26, 1, null },
                    { 24, "nemo", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 17, 3, null },
                    { 56, "iusto", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 84, 3, null },
                    { 17, "rem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 90, 3, null },
                    { 83, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 57, 1, null },
                    { 19, "aut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 55, 2, null },
                    { 87, "sit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 68, 1, null },
                    { 13, "soluta", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 100, 3, null },
                    { 69, "saepe", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 29, 3, null },
                    { 49, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 77, 1, null },
                    { 62, "asperiores", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 40, 2, null },
                    { 70, "laboriosam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 51, 2, null },
                    { 2, "sint", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 4, 2, null },
                    { 7, "sint", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 4, 1, null },
                    { 12, "harum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 4, 1, null },
                    { 34, "quis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 4, 3, null },
                    { 4, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 21, 3, null },
                    { 35, "dolor", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 34, 3, null },
                    { 72, "temporibus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 34, 2, null },
                    { 92, "adipisci", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 65, 1, null },
                    { 8, "occaecati", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 85, 1, null },
                    { 28, "dolores", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 85, 3, null },
                    { 29, "veritatis", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 85, 2, null },
                    { 38, "velit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 85, 3, null },
                    { 74, "quas", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 99, 1, null },
                    { 60, "consequatur", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 57, 3, null },
                    { 9, "blanditiis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 90, 2, null },
                    { 37, "impedit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 81, 3, null }
                });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[,]
                {
                    { 92, "/world-class/response/integrate", 3, 11 },
                    { 38, "/mint-green/industrial/withdrawal", 7, 81 },
                    { 36, "/industrial--computers", 5, 65 },
                    { 87, "/open-source/intranet/colorado", 1, 65 },
                    { 99, "/mobility/isle", 2, 65 },
                    { 50, "/e-markets", 6, 96 },
                    { 6, "/buckinghamshire", 3, 47 },
                    { 62, "/borders/facilitate", 6, 47 },
                    { 2, "/assurance", 2, 63 },
                    { 14, "/officer/walk/center", 4, 63 },
                    { 45, "/incredible-wooden-towels", 2, 98 },
                    { 77, "/protocol/embrace", 4, 58 },
                    { 48, "/markets/orchard", 2, 33 },
                    { 75, "/advanced", 6, 33 },
                    { 3, "/agp/borders/supply-chains", 3, 3 },
                    { 11, "/generic/info-mediaries", 6, 100 },
                    { 34, "/interactive/cross-platform", 7, 100 },
                    { 57, "/wooden", 4, 88 },
                    { 5, "/ergonomic-soft-mouse/overriding", 1, 91 },
                    { 23, "/e-business/palladium", 5, 90 },
                    { 79, "/director/invoice", 4, 90 },
                    { 39, "/sports-movies--beauty/som/michigan", 1, 93 },
                    { 24, "/communities/ergonomic-granite-bacon/transmitter", 4, 81 },
                    { 90, "/programming", 2, 48 },
                    { 93, "/small/port", 5, 67 },
                    { 86, "/red", 5, 67 },
                    { 28, "/berkshire", 6, 97 },
                    { 80, "/solutions/communities/blue", 3, 97 },
                    { 20, "/bus/trace", 6, 1 },
                    { 65, "/agent/intelligent-steel-mouse/internal", 6, 14 },
                    { 35, "/relationships/synthesize/one-to-one", 3, 21 },
                    { 44, "/rubber/programming", 7, 52 },
                    { 18, "/refined-metal-soap", 2, 57 },
                    { 37, "/heuristic", 3, 57 },
                    { 9, "/music--games/michigan", 3, 75 },
                    { 89, "/regional/optional/hub", 3, 59 },
                    { 70, "/e-tailers", 2, 93 },
                    { 42, "/connect/incubate", 7, 22 },
                    { 95, "/leone", 7, 77 },
                    { 7, "/shoes/electronics--books/calculate", 7, 20 },
                    { 41, "/us-dollar/intelligent/lane", 7, 20 },
                    { 76, "/representative", 6, 20 },
                    { 98, "/brook", 5, 20 },
                    { 60, "/nebraska/platforms/credit-card-account", 1, 45 },
                    { 64, "/payment", 1, 50 },
                    { 8, "/e-tailers/metal", 2, 54 },
                    { 66, "/invoice", 6, 54 },
                    { 19, "/tasty/uae-dirham", 3, 67 },
                    { 59, "/bus/andorra/interactions", 4, 22 },
                    { 29, "/somoni", 3, 37 },
                    { 88, "/mount/override/plug-and-play", 5, 11 },
                    { 82, "/e-enable/gorgeous/teal", 5, 26 },
                    { 73, "/wooden/action-items/germany", 1, 83 },
                    { 46, "/wireless/new-hampshire/functionalities", 7, 17 },
                    { 61, "/customer/rubber/terrace", 2, 17 },
                    { 10, "/vision-oriented/primary/industrial--industrial", 7, 61 },
                    { 25, "/lempira/credit-card-account/kentucky", 7, 61 },
                    { 17, "/profound/architectures", 1, 64 },
                    { 81, "/investment-account/interactions/portal", 5, 64 },
                    { 31, "/primary/health-games--health", 7, 84 },
                    { 96, "/solutions/index/pines", 6, 55 },
                    { 63, "/exe/infrastructure", 1, 36 },
                    { 58, "/western-sahara", 6, 39 },
                    { 43, "/incremental", 1, 43 },
                    { 51, "/qatar/assurance/international", 1, 43 },
                    { 68, "/saint-helena-pound/green/forward", 4, 31 },
                    { 15, "/granite", 6, 32 },
                    { 47, "/directives/bypassing/uzbekistan-sum", 5, 32 },
                    { 13, "/gold", 4, 25 },
                    { 71, "/invoice/directional", 5, 25 },
                    { 16, "/haptic", 2, 41 },
                    { 72, "/analyzing/usability/input", 2, 16 },
                    { 54, "/incredible-steel-chips/tertiary/definition", 7, 37 },
                    { 49, "/human/small-rubber-sausages", 2, 60 },
                    { 4, "/credit-card-account", 6, 29 },
                    { 40, "/transmitting", 5, 82 },
                    { 33, "/ai", 5, 8 },
                    { 84, "/new-hampshire/orchestration", 1, 26 },
                    { 91, "/legacy/rustic/olive", 3, 8 },
                    { 26, "/berkshire/navigating/sleek-steel-ball", 5, 5 },
                    { 30, "/executive", 4, 5 },
                    { 32, "/avon/club/dynamic", 4, 13 },
                    { 27, "/strategist/generating/practical-cotton-bike", 2, 69 },
                    { 56, "/functionality/program", 3, 69 },
                    { 74, "/incubate", 1, 69 },
                    { 55, "/pci/auto-loan-account/seamless", 3, 49 },
                    { 69, "/practical/web-enabled", 2, 49 },
                    { 83, "/optical/jbod", 4, 49 },
                    { 22, "/phased", 5, 49 },
                    { 94, "/bedfordshire", 7, 92 },
                    { 1, "/global/productivity/responsive", 5, 62 },
                    { 53, "/corporate/holistic/centralized", 4, 2 },
                    { 52, "/ivory", 6, 4 },
                    { 85, "/refined-frozen-tuna/schemas/concrete", 5, 4 },
                    { 100, "/principal/luxembourg", 5, 4 },
                    { 12, "/wireless", 6, 35 },
                    { 67, "/mountains", 2, 72 },
                    { 78, "/paradigm/b2b/handmade-rubber-computer", 3, 72 },
                    { 97, "/national/red/utah", 6, 49 },
                    { 21, "/home-loan-account/parse", 3, 8 }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 1123, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6896) },
                    { 1123, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6899) },
                    { 1123, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6903) },
                    { 1124, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6906) },
                    { 1126, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6921) },
                    { 1125, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6913) },
                    { 1126, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6917) },
                    { 1122, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6891) },
                    { 1125, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6910) },
                    { 1122, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6883) },
                    { 567, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4731) },
                    { 1121, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6876) },
                    { 1120, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6872) },
                    { 1120, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6868) },
                    { 627, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5584) },
                    { 626, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5578) },
                    { 626, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5571) },
                    { 569, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4757) },
                    { 568, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4751) },
                    { 567, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4744) },
                    { 567, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4737) },
                    { 1127, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6924) },
                    { 1122, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6879) },
                    { 1127, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6928) },
                    { 1139, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7014) },
                    { 1128, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6935) },
                    { 1139, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7017) },
                    { 508, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3753) },
                    { 1138, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7010) },
                    { 1138, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7006) },
                    { 1138, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7003) },
                    { 1137, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6999) },
                    { 1136, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6996) },
                    { 1136, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6992) },
                    { 1136, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6988) },
                    { 1136, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6985) },
                    { 1135, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6981) },
                    { 1134, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6978) },
                    { 1134, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6974) },
                    { 1133, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6971) },
                    { 1133, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6967) },
                    { 1132, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6963) },
                    { 1132, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6960) },
                    { 1131, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6956) },
                    { 1131, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6953) },
                    { 1130, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6949) },
                    { 1130, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6946) },
                    { 1129, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6942) },
                    { 1129, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6938) },
                    { 1128, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6931) },
                    { 508, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3747) },
                    { 77, 27, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6597) },
                    { 423, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2569) },
                    { 25, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5318) },
                    { 625, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5564) },
                    { 625, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5558) },
                    { 625, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5553) },
                    { 625, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5548) },
                    { 284, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(638) },
                    { 284, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(631) },
                    { 113, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7440) },
                    { 113, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7433) },
                    { 76, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6575) },
                    { 76, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6570) },
                    { 24, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5311) },
                    { 24, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5304) },
                    { 24, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5298) },
                    { 1119, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6865) },
                    { 455, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2971) },
                    { 455, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2966) },
                    { 455, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2960) },
                    { 112, 24, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7427) },
                    { 112, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7420) },
                    { 112, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7413) },
                    { 185, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8838) },
                    { 185, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8831) },
                    { 25, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5325) },
                    { 507, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3737) },
                    { 25, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5332) },
                    { 77, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6590) },
                    { 423, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2562) },
                    { 422, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2555) },
                    { 352, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1737) },
                    { 352, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1731) },
                    { 352, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1726) },
                    { 351, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1719) },
                    { 351, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1712) },
                    { 155, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8232) },
                    { 116, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7516) },
                    { 116, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7509) },
                    { 116, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7502) },
                    { 116, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7496) },
                    { 115, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7490) },
                    { 115, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7485) },
                    { 115, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7480) },
                    { 115, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7474) },
                    { 115, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7467) },
                    { 115, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7461) },
                    { 114, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7454) },
                    { 114, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7447) },
                    { 77, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6611) },
                    { 77, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6604) },
                    { 1140, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7021) },
                    { 77, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6582) },
                    { 1140, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7024) },
                    { 1151, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7120) },
                    { 1141, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7031) },
                    { 1162, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7213) },
                    { 1162, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7210) },
                    { 1161, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7206) },
                    { 1161, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7203) },
                    { 1160, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7199) },
                    { 1160, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7195) },
                    { 1159, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7191) },
                    { 1159, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7187) },
                    { 1158, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7184) },
                    { 1158, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7180) },
                    { 1157, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7175) },
                    { 1157, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7172) },
                    { 1157, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7168) },
                    { 1156, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7164) },
                    { 1156, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7160) },
                    { 603, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5268) },
                    { 603, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5263) },
                    { 602, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5258) },
                    { 602, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5252) },
                    { 602, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5246) },
                    { 602, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5239) },
                    { 602, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5232) },
                    { 537, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4253) },
                    { 1163, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7217) },
                    { 537, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4246) },
                    { 1163, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7221) },
                    { 1164, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7228) },
                    { 1178, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7312) },
                    { 1178, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7308) },
                    { 1177, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7304) },
                    { 1177, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7301) },
                    { 1176, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7297) },
                    { 1176, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7294) },
                    { 1175, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7290) },
                    { 1174, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7286) },
                    { 1174, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7282) },
                    { 1173, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7278) },
                    { 1173, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7275) },
                    { 1172, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7271) },
                    { 1172, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7268) },
                    { 1171, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7264) },
                    { 1171, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7260) },
                    { 1171, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7257) },
                    { 1171, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7253) },
                    { 1170, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7250) },
                    { 1169, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7246) },
                    { 1168, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7242) },
                    { 1167, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7239) },
                    { 1166, 11, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7235) },
                    { 1165, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7231) },
                    { 1163, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7224) },
                    { 1141, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7028) },
                    { 510, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3788) },
                    { 510, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3778) },
                    { 185, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8824) },
                    { 1151, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7117) },
                    { 1150, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7110) },
                    { 1150, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7107) },
                    { 1149, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7102) },
                    { 1149, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7099) },
                    { 1148, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7095) },
                    { 1148, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7091) },
                    { 1147, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7086) },
                    { 1147, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7082) },
                    { 1147, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7079) },
                    { 1146, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7075) },
                    { 1146, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7071) },
                    { 1145, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7068) },
                    { 1145, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7064) },
                    { 1144, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7060) },
                    { 1144, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7056) },
                    { 1143, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7053) },
                    { 1143, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7049) },
                    { 1143, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7045) },
                    { 1142, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7042) },
                    { 1142, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7038) },
                    { 1142, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7035) },
                    { 1152, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7124) },
                    { 510, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3783) },
                    { 1152, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7127) },
                    { 1153, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7135) },
                    { 509, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3772) },
                    { 509, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3767) },
                    { 509, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3760) },
                    { 425, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2600) },
                    { 425, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2592) },
                    { 424, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2587) },
                    { 424, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2581) },
                    { 424, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2575) },
                    { 354, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1749) },
                    { 353, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1743) },
                    { 233, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9851) },
                    { 233, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9845) },
                    { 233, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9839) },
                    { 186, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8845) },
                    { 117, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7536) },
                    { 117, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7529) },
                    { 117, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7523) },
                    { 1155, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7157) },
                    { 1155, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7153) },
                    { 1155, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7149) },
                    { 1154, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7145) },
                    { 1154, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7142) },
                    { 1154, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7138) },
                    { 1153, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7131) },
                    { 185, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8818) },
                    { 1111, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6831) },
                    { 185, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8804) },
                    { 495, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3568) },
                    { 495, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3562) },
                    { 494, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3556) },
                    { 494, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3549) },
                    { 452, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2931) },
                    { 452, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2924) },
                    { 341, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1585) },
                    { 341, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1579) },
                    { 341, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1572) },
                    { 283, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(624) },
                    { 283, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(617) },
                    { 282, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(611) },
                    { 282, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(605) },
                    { 281, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(596) },
                    { 280, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(590) },
                    { 280, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(584) },
                    { 280, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(578) },
                    { 280, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(572) },
                    { 280, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(565) },
                    { 183, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8755) },
                    { 183, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8749) },
                    { 183, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8742) },
                    { 183, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8735) },
                    { 496, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3573) },
                    { 183, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8728) },
                    { 497, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3578) },
                    { 497, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3592) },
                    { 600, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5190) },
                    { 600, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5184) },
                    { 599, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5178) },
                    { 599, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5171) },
                    { 599, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5164) },
                    { 599, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5157) },
                    { 598, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5150) },
                    { 598, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5143) },
                    { 598, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5138) },
                    { 598, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5133) },
                    { 597, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5128) },
                    { 596, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5116) },
                    { 596, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5110) },
                    { 595, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5104) },
                    { 595, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5097) },
                    { 595, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5090) },
                    { 594, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5084) },
                    { 594, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5077) },
                    { 594, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5071) },
                    { 594, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5066) },
                    { 594, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5060) },
                    { 498, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3605) },
                    { 498, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3599) },
                    { 497, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3583) },
                    { 600, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5196) },
                    { 183, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8721) },
                    { 182, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8707) },
                    { 72, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6472) },
                    { 71, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6465) },
                    { 71, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6458) },
                    { 71, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6452) },
                    { 71, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6445) },
                    { 70, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6438) },
                    { 70, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6431) },
                    { 70, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6426) },
                    { 70, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6421) },
                    { 70, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6415) },
                    { 69, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6409) },
                    { 69, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6403) },
                    { 69, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6396) },
                    { 69, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6390) },
                    { 68, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6383) },
                    { 68, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6376) },
                    { 68, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6369) },
                    { 68, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6362) },
                    { 67, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6356) },
                    { 67, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6350) },
                    { 67, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6345) },
                    { 67, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6340) },
                    { 67, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6335) },
                    { 72, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6479) },
                    { 183, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8714) },
                    { 72, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6486) },
                    { 72, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6500) },
                    { 182, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8700) },
                    { 182, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8693) },
                    { 182, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8687) },
                    { 182, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8681) },
                    { 182, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8676) },
                    { 107, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7350) },
                    { 107, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7343) },
                    { 106, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7337) },
                    { 106, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7330) },
                    { 106, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7323) },
                    { 106, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7316) },
                    { 106, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7310) },
                    { 106, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7302) },
                    { 105, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7294) },
                    { 105, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7287) },
                    { 105, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7281) },
                    { 73, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6548) },
                    { 73, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6541) },
                    { 73, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6535) },
                    { 73, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6528) },
                    { 73, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6521) },
                    { 73, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6514) },
                    { 72, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6507) },
                    { 72, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6493) },
                    { 600, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5201) },
                    { 600, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5218) },
                    { 601, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5225) },
                    { 453, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2937) },
                    { 350, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1679) },
                    { 350, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1674) },
                    { 350, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1668) },
                    { 421, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2549) },
                    { 421, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2543) },
                    { 421, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2536) },
                    { 349, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1662) },
                    { 348, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1655) },
                    { 347, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1648) },
                    { 346, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1641) },
                    { 345, 35, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1634) },
                    { 345, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1627) },
                    { 345, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1620) },
                    { 344, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1615) },
                    { 343, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1610) },
                    { 232, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9832) },
                    { 231, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9825) },
                    { 231, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9818) },
                    { 231, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9811) },
                    { 184, 48, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8774) },
                    { 184, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8768) },
                    { 184, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8762) },
                    { 453, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2943) },
                    { 506, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3731) },
                    { 453, 25, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2950) },
                    { 1111, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6824) },
                    { 185, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8797) },
                    { 185, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8791) },
                    { 185, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8785) },
                    { 185, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8779) },
                    { 111, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7406) },
                    { 111, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7399) },
                    { 111, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7392) },
                    { 111, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7385) },
                    { 1118, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6861) },
                    { 1117, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6857) },
                    { 1116, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6854) },
                    { 1115, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6850) },
                    { 1114, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6847) },
                    { 1114, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6842) },
                    { 624, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5543) },
                    { 454, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2955) },
                    { 110, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7378) },
                    { 110, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7373) },
                    { 109, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7368) },
                    { 1113, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6838) },
                    { 1112, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6835) },
                    { 1178, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7315) },
                    { 1111, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6828) },
                    { 1111, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6820) },
                    { 506, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3726) },
                    { 506, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3721) },
                    { 505, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3715) },
                    { 108, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7361) },
                    { 108, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7356) },
                    { 74, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6554) },
                    { 1107, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6795) },
                    { 1106, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6791) },
                    { 1106, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6787) },
                    { 1106, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6784) },
                    { 1106, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6780) },
                    { 1105, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6776) },
                    { 1104, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6773) },
                    { 1104, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6769) },
                    { 1104, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6766) },
                    { 1104, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6762) },
                    { 1103, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6759) },
                    { 1102, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6754) },
                    { 1102, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6750) },
                    { 1102, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6747) },
                    { 1102, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6743) },
                    { 1101, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6738) },
                    { 1100, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6734) },
                    { 1100, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6731) },
                    { 1100, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6727) },
                    { 1100, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6724) },
                    { 499, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3612) },
                    { 499, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3619) },
                    { 499, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3625) },
                    { 500, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3631) },
                    { 505, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3710) },
                    { 342, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1605) },
                    { 342, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1598) },
                    { 342, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1592) },
                    { 75, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6564) },
                    { 75, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6559) },
                    { 1110, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6817) },
                    { 1110, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6813) },
                    { 1109, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6809) },
                    { 1109, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6806) },
                    { 1108, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6802) },
                    { 185, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8811) },
                    { 1108, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6799) },
                    { 504, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3699) },
                    { 503, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3692) },
                    { 503, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3686) },
                    { 502, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3679) },
                    { 502, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3672) },
                    { 502, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3664) },
                    { 502, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3658) },
                    { 501, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3653) },
                    { 500, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3647) },
                    { 500, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3642) },
                    { 500, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3637) },
                    { 504, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3705) },
                    { 156, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8237) },
                    { 26, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5344) },
                    { 156, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8248) },
                    { 642, 2, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5819) },
                    { 642, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5813) },
                    { 642, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5808) },
                    { 642, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5800) },
                    { 642, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5793) },
                    { 635, 1, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5693) },
                    { 634, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5687) },
                    { 633, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5681) },
                    { 633, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5676) },
                    { 632, 36, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5667) },
                    { 632, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5661) },
                    { 632, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5654) },
                    { 632, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5647) },
                    { 632, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5640) },
                    { 632, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5634) },
                    { 631, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5628) },
                    { 631, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5622) },
                    { 630, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5617) },
                    { 629, 36, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5610) },
                    { 629, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5604) },
                    { 629, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5598) },
                    { 571, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4792) },
                    { 570, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4787) },
                    { 643, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5825) },
                    { 570, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4781) },
                    { 643, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5830) },
                    { 643, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5841) },
                    { 30, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5472) },
                    { 30, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5466) },
                    { 29, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5459) },
                    { 29, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5452) },
                    { 29, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5447) },
                    { 29, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5441) },
                    { 1197, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7510) },
                    { 1197, 9, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7506) },
                    { 1197, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7502) },
                    { 1197, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7499) },
                    { 1197, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7495) },
                    { 1197, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7491) },
                    { 1197, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7487) },
                    { 1196, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7484) },
                    { 1196, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7480) },
                    { 1195, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7477) },
                    { 1195, 9, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7473) },
                    { 1195, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7469) },
                    { 1195, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7466) },
                    { 1195, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7462) },
                    { 1194, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7458) },
                    { 1194, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7455) },
                    { 1194, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7451) },
                    { 643, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5836) },
                    { 30, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5480) },
                    { 570, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4776) },
                    { 570, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4764) },
                    { 462, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3103) },
                    { 462, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3083) },
                    { 434, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2718) },
                    { 433, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2712) },
                    { 433, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2705) },
                    { 433, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2698) },
                    { 432, 47, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2691) },
                    { 431, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2684) },
                    { 430, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2678) },
                    { 430, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2673) },
                    { 430, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2666) },
                    { 430, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2661) },
                    { 430, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2656) },
                    { 429, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2650) },
                    { 429, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2644) },
                    { 429, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2638) },
                    { 428, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2631) },
                    { 428, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2624) },
                    { 428, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2618) },
                    { 427, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2611) },
                    { 364, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2020) },
                    { 364, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2014) },
                    { 364, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2007) },
                    { 462, 11, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3109) },
                    { 570, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4770) },
                    { 462, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3114) },
                    { 462, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3125) },
                    { 544, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4394) },
                    { 544, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4387) },
                    { 543, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4380) },
                    { 543, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4373) },
                    { 543, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4368) },
                    { 543, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4363) },
                    { 543, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4357) },
                    { 542, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4352) },
                    { 542, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4346) },
                    { 542, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4338) },
                    { 542, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4331) },
                    { 542, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4326) },
                    { 542, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4319) },
                    { 514, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3861) },
                    { 514, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3856) },
                    { 514, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3851) },
                    { 514, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3846) },
                    { 514, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3840) },
                    { 514, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3833) },
                    { 514, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3826) },
                    { 464, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3146) },
                    { 463, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3139) },
                    { 462, 25, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3132) },
                    { 462, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3119) },
                    { 364, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2001) },
                    { 30, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5486) },
                    { 82, 27, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6768) },
                    { 371, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2163) },
                    { 370, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2156) },
                    { 370, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2149) },
                    { 369, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2143) },
                    { 368, 20, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2136) },
                    { 368, 35, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2127) },
                    { 368, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2121) },
                    { 368, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2116) },
                    { 368, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2111) },
                    { 368, 23, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2105) },
                    { 368, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2100) },
                    { 367, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2093) },
                    { 367, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2049) },
                    { 367, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2043) },
                    { 366, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2038) },
                    { 366, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2032) },
                    { 365, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2026) },
                    { 296, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(885) },
                    { 295, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(880) },
                    { 295, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(873) },
                    { 295, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(866) },
                    { 294, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(859) },
                    { 294, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(852) },
                    { 371, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2169) },
                    { 294, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(845) },
                    { 372, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2175) }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 372, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2186) },
                    { 1198, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7517) },
                    { 1198, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7513) },
                    { 641, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5785) },
                    { 641, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5778) },
                    { 641, 1, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5772) },
                    { 572, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4824) },
                    { 572, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4817) },
                    { 572, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4810) },
                    { 572, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4803) },
                    { 572, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4797) },
                    { 545, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4419) },
                    { 545, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4413) },
                    { 545, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4407) },
                    { 545, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4401) },
                    { 465, 25, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3194) },
                    { 465, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3187) },
                    { 465, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3182) },
                    { 465, 52, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3177) },
                    { 465, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3171) },
                    { 465, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3165) },
                    { 465, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3159) },
                    { 465, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3153) },
                    { 373, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2191) },
                    { 372, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2180) },
                    { 82, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6760) },
                    { 293, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(838) },
                    { 293, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(823) },
                    { 198, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9161) },
                    { 197, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9154) },
                    { 196, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9146) },
                    { 196, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9139) },
                    { 196, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9133) },
                    { 196, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9126) },
                    { 162, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8410) },
                    { 162, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8404) },
                    { 162, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8398) },
                    { 161, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8393) },
                    { 160, 2, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8387) },
                    { 159, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8369) },
                    { 159, 24, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8363) },
                    { 159, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8356) },
                    { 159, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8348) },
                    { 159, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8343) },
                    { 159, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8337) },
                    { 159, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8332) },
                    { 121, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7613) },
                    { 83, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6796) },
                    { 83, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6789) },
                    { 82, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6782) },
                    { 82, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6775) },
                    { 198, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9168) },
                    { 293, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(830) },
                    { 198, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9175) },
                    { 199, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9188) },
                    { 293, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(816) },
                    { 292, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(809) },
                    { 292, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(802) },
                    { 292, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(795) },
                    { 292, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(788) },
                    { 291, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(781) },
                    { 291, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(774) },
                    { 291, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(768) },
                    { 290, 34, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(762) },
                    { 290, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(757) },
                    { 242, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(22) },
                    { 242, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(17) },
                    { 241, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(11) },
                    { 240, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4) },
                    { 239, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9997) },
                    { 239, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9990) },
                    { 238, 25, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9983) },
                    { 238, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9976) },
                    { 238, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9969) },
                    { 238, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9963) },
                    { 238, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9956) },
                    { 237, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9951) },
                    { 237, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9946) },
                    { 199, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9182) },
                    { 363, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1994) },
                    { 363, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1987) },
                    { 363, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1980) },
                    { 460, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3049) },
                    { 460, 11, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3044) },
                    { 460, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3039) },
                    { 460, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3033) },
                    { 459, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3028) },
                    { 459, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3022) },
                    { 458, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3017) },
                    { 458, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3011) },
                    { 457, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3005) },
                    { 457, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2998) },
                    { 457, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2990) },
                    { 456, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2983) },
                    { 456, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2976) },
                    { 286, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(689) },
                    { 286, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(684) },
                    { 286, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(678) },
                    { 286, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(673) },
                    { 286, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(657) },
                    { 285, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(651) },
                    { 285, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(645) },
                    { 234, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9880) },
                    { 234, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9873) },
                    { 234, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9867) },
                    { 460, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3056) },
                    { 234, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9861) },
                    { 460, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3063) },
                    { 461, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3076) },
                    { 1187, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7354) },
                    { 1187, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7351) },
                    { 1186, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7347) },
                    { 1186, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7344) },
                    { 606, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5347) },
                    { 606, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5340) },
                    { 606, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5332) },
                    { 606, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5325) },
                    { 605, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5318) },
                    { 605, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5312) },
                    { 605, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5305) },
                    { 605, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5298) },
                    { 604, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5292) },
                    { 604, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5285) },
                    { 604, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5279) },
                    { 604, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5274) },
                    { 538, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4266) },
                    { 538, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4260) },
                    { 513, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3819) },
                    { 512, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3812) },
                    { 512, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3806) },
                    { 511, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3799) },
                    { 511, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3793) },
                    { 461, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3070) },
                    { 1187, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7360) },
                    { 234, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9856) },
                    { 190, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8923) },
                    { 26, 23, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5349) },
                    { 26, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5338) },
                    { 1185, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7340) },
                    { 1184, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7337) },
                    { 1183, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7333) },
                    { 1182, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7329) },
                    { 1181, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7326) },
                    { 1180, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7322) },
                    { 1179, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7319) },
                    { 628, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5591) },
                    { 426, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2605) },
                    { 359, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1816) },
                    { 359, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1810) },
                    { 359, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1804) },
                    { 359, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1798) },
                    { 358, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1792) },
                    { 358, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1785) },
                    { 358, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1778) },
                    { 357, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1771) },
                    { 357, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1764) },
                    { 356, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1759) },
                    { 355, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1754) },
                    { 156, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8253) },
                    { 27, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5354) },
                    { 190, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8931) },
                    { 27, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5360) },
                    { 78, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6618) },
                    { 189, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8916) },
                    { 189, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8909) },
                    { 189, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8902) },
                    { 67, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6329) },
                    { 188, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8890) },
                    { 188, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8884) },
                    { 188, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8878) },
                    { 187, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8872) },
                    { 187, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8864) },
                    { 187, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8858) },
                    { 187, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8852) },
                    { 118, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7571) },
                    { 118, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7564) },
                    { 118, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7557) },
                    { 118, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7550) },
                    { 118, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7543) },
                    { 79, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6666) },
                    { 79, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6659) },
                    { 79, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6652) },
                    { 79, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6645) },
                    { 79, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6639) },
                    { 78, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6631) },
                    { 78, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6624) },
                    { 27, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5366) },
                    { 1187, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7364) },
                    { 1187, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7367) },
                    { 1188, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7371) },
                    { 236, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9915) },
                    { 236, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9908) },
                    { 158, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8327) },
                    { 158, 2, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8321) },
                    { 158, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8315) },
                    { 158, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8308) },
                    { 158, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8301) },
                    { 158, 21, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8294) },
                    { 157, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8288) },
                    { 157, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8281) },
                    { 157, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8274) },
                    { 157, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8267) },
                    { 157, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8260) },
                    { 120, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7608) },
                    { 120, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7602) },
                    { 120, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7597) },
                    { 119, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7591) },
                    { 119, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7584) },
                    { 119, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7577) },
                    { 81, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6753) },
                    { 81, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6746) },
                    { 81, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6739) },
                    { 81, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6732) },
                    { 236, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9922) },
                    { 81, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6726) },
                    { 236, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9929) },
                    { 236, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9940) },
                    { 363, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1975) },
                    { 362, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1969) },
                    { 361, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1961) },
                    { 361, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1892) },
                    { 361, 9, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1886) },
                    { 361, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1881) },
                    { 361, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1876) },
                    { 361, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1870) },
                    { 361, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1862) },
                    { 361, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1856) },
                    { 361, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1849) },
                    { 360, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1842) },
                    { 360, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1835) },
                    { 289, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(752) },
                    { 289, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(747) },
                    { 289, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(741) },
                    { 288, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(736) },
                    { 288, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(729) },
                    { 287, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(724) },
                    { 287, 14, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(718) },
                    { 287, 22, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(711) },
                    { 287, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(704) },
                    { 287, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(696) },
                    { 236, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9935) },
                    { 81, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6719) },
                    { 81, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6713) },
                    { 81, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6708) },
                    { 235, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9901) },
                    { 235, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9894) },
                    { 235, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9887) },
                    { 191, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8957) },
                    { 191, 11, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8951) },
                    { 191, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8944) },
                    { 191, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8938) },
                    { 80, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6697) },
                    { 80, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6692) },
                    { 80, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6686) },
                    { 80, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6679) },
                    { 80, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6673) },
                    { 1190, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7414) },
                    { 1190, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7410) },
                    { 1189, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7407) },
                    { 1189, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7403) },
                    { 1189, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7400) },
                    { 1189, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7396) },
                    { 1189, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7393) },
                    { 1188, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7385) },
                    { 1188, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7381) },
                    { 1188, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7378) },
                    { 1188, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7374) },
                    { 539, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4272) },
                    { 539, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4277) },
                    { 539, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4282) },
                    { 539, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4287) },
                    { 81, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6702) },
                    { 28, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5435) },
                    { 28, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5429) },
                    { 28, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5423) },
                    { 28, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5416) },
                    { 28, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5409) },
                    { 28, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5402) },
                    { 28, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5395) },
                    { 28, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5388) },
                    { 28, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5380) },
                    { 28, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5373) },
                    { 156, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8243) },
                    { 1193, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7446) },
                    { 1193, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7439) },
                    { 1192, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7436) },
                    { 1192, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7432) },
                    { 1192, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7428) },
                    { 1191, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7425) },
                    { 1191, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7421) },
                    { 1191, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7418) },
                    { 541, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4312) },
                    { 541, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4305) },
                    { 541, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4298) },
                    { 540, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4293) },
                    { 1193, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(7443) },
                    { 188, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8895) },
                    { 66, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6323) },
                    { 66, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6309) },
                    { 175, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8576) },
                    { 175, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8570) },
                    { 174, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8563) },
                    { 173, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8556) },
                    { 173, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8549) },
                    { 137, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7863) },
                    { 137, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7856) },
                    { 137, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7849) },
                    { 136, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7843) },
                    { 136, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7837) },
                    { 136, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7832) },
                    { 135, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7827) },
                    { 175, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8582) },
                    { 135, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7821) },
                    { 134, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7808) },
                    { 133, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7802) },
                    { 133, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7795) },
                    { 133, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7788) },
                    { 133, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7781) },
                    { 132, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7775) },
                    { 132, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7769) },
                    { 131, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7764) },
                    { 131, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7758) },
                    { 130, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7752) },
                    { 130, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7747) },
                    { 130, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7741) },
                    { 134, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7815) },
                    { 95, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7038) },
                    { 176, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8588) },
                    { 176, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8598) },
                    { 320, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1186) },
                    { 320, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1180) },
                    { 264, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(291) },
                    { 264, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(286) },
                    { 264, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(280) },
                    { 264, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(274) },
                    { 263, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(269) },
                    { 263, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(263) },
                    { 263, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(258) },
                    { 262, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(251) },
                    { 262, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(245) },
                    { 261, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(238) },
                    { 176, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8593) },
                    { 261, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(231) },
                    { 260, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(218) },
                    { 260, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(211) },
                    { 259, 34, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(204) },
                    { 259, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(199) },
                    { 258, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(194) },
                    { 257, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(189) },
                    { 257, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(183) },
                    { 214, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9527) },
                    { 214, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9521) },
                    { 214, 21, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9441) },
                    { 214, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9434) },
                    { 214, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9427) },
                    { 260, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(224) },
                    { 320, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1191) },
                    { 95, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7030) },
                    { 95, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7017) },
                    { 46, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5826) },
                    { 46, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5819) },
                    { 16, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4484) },
                    { 15, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4381) },
                    { 15, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4278) },
                    { 15, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4177) },
                    { 14, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4077) },
                    { 13, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3975) },
                    { 12, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3873) },
                    { 12, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3768) },
                    { 11, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3664) },
                    { 11, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3564) },
                    { 46, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5832) },
                    { 1027, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6194) },
                    { 638, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5717) },
                    { 638, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5710) },
                    { 614, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5416) },
                    { 587, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4977) },
                    { 587, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4971) },
                    { 559, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4637) },
                    { 530, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4129) },
                    { 530, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4123) },
                    { 530, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4116) },
                    { 530, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4110) },
                    { 529, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4103) },
                    { 529, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4096) },
                    { 1026, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6188) },
                    { 95, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7024) },
                    { 47, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5837) },
                    { 47, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5849) },
                    { 95, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7010) },
                    { 94, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7003) },
                    { 94, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6996) },
                    { 94, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6990) },
                    { 93, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6984) },
                    { 93, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6979) },
                    { 93, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6974) },
                    { 93, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6968) },
                    { 51, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5968) },
                    { 51, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5962) },
                    { 51, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5955) },
                    { 51, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5948) },
                    { 47, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5842) },
                    { 50, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5941) },
                    { 50, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5928) },
                    { 50, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5922) },
                    { 50, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5916) },
                    { 49, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5911) },
                    { 49, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5906) },
                    { 49, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5900) },
                    { 49, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5894) },
                    { 48, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5887) },
                    { 48, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5880) },
                    { 48, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5870) },
                    { 48, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5862) },
                    { 47, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5856) },
                    { 50, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5934) },
                    { 529, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4089) },
                    { 321, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1198) },
                    { 321, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1211) },
                    { 1033, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6245) },
                    { 1033, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6242) },
                    { 1032, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6237) },
                    { 1032, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6233) },
                    { 1031, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6230) },
                    { 1031, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6226) },
                    { 1030, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6215) },
                    { 1030, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6209) },
                    { 1029, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6204) },
                    { 1028, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6199) },
                    { 615, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5433) },
                    { 615, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5426) },
                    { 1034, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6257) },
                    { 615, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5421) },
                    { 588, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4982) },
                    { 562, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4692) },
                    { 562, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4686) },
                    { 561, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4680) },
                    { 560, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4673) },
                    { 560, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4665) },
                    { 560, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4658) },
                    { 560, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4653) },
                    { 560, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4648) },
                    { 560, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4642) },
                    { 534, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4204) },
                    { 534, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4199) },
                    { 588, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4988) },
                    { 534, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4193) },
                    { 1034, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6261) },
                    { 1035, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6268) },
                    { 55, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6051) },
                    { 55, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6043) },
                    { 55, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6037) },
                    { 54, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6029) },
                    { 54, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6023) },
                    { 53, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6016) },
                    { 53, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6009) },
                    { 53, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6003) },
                    { 53, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5998) },
                    { 52, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5993) },
                    { 52, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5987) },
                    { 52, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5982) },
                    { 1035, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6265) },
                    { 52, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5975) },
                    { 19, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5218) },
                    { 19, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5210) },
                    { 18, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4927) },
                    { 18, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4792) },
                    { 18, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4689) },
                    { 17, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(4586) },
                    { 1039, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6290) },
                    { 1039, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6286) },
                    { 1038, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6283) },
                    { 1037, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6279) },
                    { 1037, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6275) },
                    { 1036, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6272) },
                    { 19, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5225) },
                    { 321, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1204) },
                    { 534, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4187) },
                    { 533, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4173) },
                    { 481, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3363) },
                    { 481, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3357) },
                    { 481, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3350) },
                    { 480, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3343) },
                    { 480, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3336) },
                    { 480, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3329) },
                    { 443, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2809) },
                    { 443, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2804) },
                    { 442, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2798) },
                    { 442, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2792) },
                    { 402, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2263) },
                    { 401, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2257) },
                    { 482, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3369) },
                    { 401, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2252) },
                    { 401, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2240) },
                    { 401, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2235) },
                    { 324, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1301) },
                    { 324, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1294) },
                    { 324, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1287) },
                    { 323, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1281) },
                    { 323, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1276) },
                    { 323, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1271) },
                    { 323, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1264) },
                    { 322, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1256) },
                    { 322, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1249) },
                    { 322, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1220) },
                    { 401, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2246) },
                    { 534, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4181) },
                    { 482, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3374) },
                    { 483, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3385) },
                    { 532, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4166) },
                    { 532, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4159) },
                    { 532, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4145) },
                    { 531, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4140) },
                    { 531, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4134) },
                    { 490, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3517) },
                    { 489, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3512) },
                    { 489, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3505) },
                    { 489, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3500) },
                    { 488, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3492) },
                    { 488, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3485) },
                    { 488, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3478) },
                    { 482, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3380) },
                    { 487, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3471) },
                    { 487, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3456) },
                    { 486, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3451) },
                    { 486, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3446) },
                    { 486, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3441) },
                    { 485, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3436) },
                    { 485, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3430) },
                    { 485, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3423) },
                    { 484, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3417) },
                    { 484, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3410) },
                    { 484, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3403) },
                    { 483, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3395) },
                    { 483, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3390) },
                    { 487, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3465) },
                    { 479, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3323) },
                    { 479, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3318) },
                    { 479, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3313) },
                    { 202, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9257) },
                    { 202, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9251) },
                    { 202, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9244) },
                    { 201, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9237) },
                    { 201, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9228) },
                    { 201, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9221) },
                    { 201, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9216) },
                    { 200, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9211) },
                    { 200, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9205) },
                    { 200, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9200) },
                    { 200, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9194) },
                    { 166, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8459) },
                    { 202, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9265) },
                    { 166, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8454) },
                    { 165, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8443) },
                    { 125, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7685) },
                    { 125, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7679) },
                    { 125, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7674) },
                    { 90, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6933) },
                    { 90, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6926) },
                    { 90, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6918) },
                    { 90, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6911) },
                    { 89, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6905) },
                    { 89, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6898) },
                    { 89, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6891) },
                    { 89, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6884) },
                    { 165, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8448) },
                    { 88, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6877) },
                    { 202, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9272) },
                    { 203, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9283) },
                    { 1014, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6111) },
                    { 1013, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6106) },
                    { 1012, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6101) },
                    { 637, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5703) },
                    { 613, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5411) },
                    { 586, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4965) },
                    { 558, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4628) },
                    { 558, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4622) },
                    { 558, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4616) },
                    { 557, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4609) },
                    { 557, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4603) },
                    { 528, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4082) },
                    { 203, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9278) },
                    { 528, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4077) },
                    { 400, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2228) },
                    { 315, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1130) },
                    { 248, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(107) },
                    { 247, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(102) },
                    { 247, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(92) },
                    { 246, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(86) },
                    { 246, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(79) },
                    { 246, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(72) },
                    { 245, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(66) },
                    { 203, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9301) },
                    { 203, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9295) },
                    { 203, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9289) },
                    { 477, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3302) },
                    { 1015, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6116) },
                    { 88, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6870) },
                    { 36, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5607) },
                    { 1005, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6049) },
                    { 1004, 9, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6043) },
                    { 1004, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6038) },
                    { 1004, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6033) },
                    { 1003, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6028) },
                    { 585, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4958) },
                    { 1002, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6021) },
                    { 1001, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6015) },
                    { 1001, 2, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6009) },
                    { 1001, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6004) },
                    { 1001, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5996) },
                    { 1000, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5990) },
                    { 556, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4589) },
                    { 584, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4952) },
                    { 583, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4938) },
                    { 476, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3295) },
                    { 476, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3288) },
                    { 475, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3282) },
                    { 474, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3275) },
                    { 439, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2757) },
                    { 438, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2751) },
                    { 124, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7668) },
                    { 124, 2, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7662) },
                    { 124, 21, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7654) },
                    { 87, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6857) },
                    { 87, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6851) },
                    { 584, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4945) },
                    { 88, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6863) },
                    { 556, 4, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4596) },
                    { 611, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5400) },
                    { 36, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5602) },
                    { 36, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5596) },
                    { 36, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5591) },
                    { 35, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5584) },
                    { 35, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5577) },
                    { 35, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5570) },
                    { 35, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5563) },
                    { 34, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5556) },
                    { 34, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5549) },
                    { 34, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5542) },
                    { 34, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5536) },
                    { 33, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5529) },
                    { 611, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5394) },
                    { 33, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5524) },
                    { 2, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(1375) },
                    { 1, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(1139) },
                    { 1, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(336) },
                    { 1011, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6095) },
                    { 1010, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6089) },
                    { 1009, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6084) },
                    { 1008, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6078) },
                    { 1007, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6070) },
                    { 1007, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6065) },
                    { 1006, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6060) },
                    { 1006, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6054) },
                    { 612, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5405) },
                    { 33, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5519) },
                    { 1016, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6121) },
                    { 1017, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6126) },
                    { 1018, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6131) },
                    { 208, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9363) },
                    { 207, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9356) },
                    { 206, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9350) },
                    { 206, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9343) },
                    { 206, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9337) },
                    { 205, 30, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9328) },
                    { 205, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9322) },
                    { 205, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9315) },
                    { 204, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9308) },
                    { 172, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8542) },
                    { 172, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8534) },
                    { 171, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8527) },
                    { 209, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9368) },
                    { 171, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8520) },
                    { 169, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8506) },
                    { 168, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8499) },
                    { 168, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8492) },
                    { 167, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8485) },
                    { 167, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8478) },
                    { 167, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8471) },
                    { 167, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8465) },
                    { 129, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7735) },
                    { 128, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7728) },
                    { 127, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7721) },
                    { 127, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7715) },
                    { 126, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7708) },
                    { 170, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8514) },
                    { 126, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7701) },
                    { 209, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9374) },
                    { 210, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9385) },
                    { 478, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3307) },
                    { 441, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2784) },
                    { 441, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2777) },
                    { 319, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1175) },
                    { 319, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1170) },
                    { 318, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1164) },
                    { 317, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1158) },
                    { 317, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1152) },
                    { 316, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1145) },
                    { 316, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1138) }
                });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[,]
                {
                    { 256, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(177) },
                    { 256, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(171) },
                    { 210, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9379) },
                    { 255, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(164) },
                    { 254, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(150) },
                    { 254, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(144) },
                    { 253, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(137) },
                    { 252, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(130) },
                    { 251, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(123) },
                    { 250, 34, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(118) },
                    { 249, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(113) },
                    { 213, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9420) },
                    { 213, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9411) },
                    { 212, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9404) },
                    { 212, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9397) },
                    { 211, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9390) },
                    { 255, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(157) },
                    { 126, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7695) },
                    { 126, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7690) },
                    { 92, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6962) },
                    { 38, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5633) },
                    { 38, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5625) },
                    { 10, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3346) },
                    { 9, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3242) },
                    { 8, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3136) },
                    { 7, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(3026) },
                    { 6, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(2640) },
                    { 5, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(2492) },
                    { 4, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(2343) },
                    { 4, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(2171) },
                    { 3, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(1988) },
                    { 3, 1, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(1778) },
                    { 38, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5640) },
                    { 3, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(1579) },
                    { 1024, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6175) },
                    { 1023, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6170) },
                    { 1022, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6165) },
                    { 440, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2771) },
                    { 440, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2764) },
                    { 37, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5618) },
                    { 37, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5613) },
                    { 1021, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6157) },
                    { 1020, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6152) },
                    { 1019, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6147) },
                    { 1019, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6141) },
                    { 1018, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6137) },
                    { 1025, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6182) },
                    { 38, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5647) },
                    { 38, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5654) },
                    { 38, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5661) },
                    { 92, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6955) },
                    { 91, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6948) },
                    { 91, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6940) },
                    { 45, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5813) },
                    { 45, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5806) },
                    { 44, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5799) },
                    { 44, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5792) },
                    { 44, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5785) },
                    { 44, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5778) },
                    { 44, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5773) },
                    { 44, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5767) },
                    { 43, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5762) },
                    { 43, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5756) },
                    { 43, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5751) },
                    { 43, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5745) },
                    { 42, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5739) },
                    { 42, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5732) },
                    { 42, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5725) },
                    { 41, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5718) },
                    { 41, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5711) },
                    { 41, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5703) },
                    { 41, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5696) },
                    { 40, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5691) },
                    { 40, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5686) },
                    { 40, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5680) },
                    { 39, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5675) },
                    { 39, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5668) },
                    { 55, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6058) },
                    { 56, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6063) },
                    { 56, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6069) },
                    { 56, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6074) },
                    { 226, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9738) },
                    { 226, 20, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9731) },
                    { 226, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9724) },
                    { 215, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9546) },
                    { 215, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9539) },
                    { 215, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9532) },
                    { 180, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8651) },
                    { 180, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8644) },
                    { 149, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8169) },
                    { 21, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5246) },
                    { 21, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5239) },
                    { 1071, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6540) },
                    { 226, 16, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9745) },
                    { 1070, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6536) },
                    { 564, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4715) },
                    { 493, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3542) },
                    { 493, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3535) },
                    { 492, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3528) },
                    { 491, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(3522) },
                    { 448, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2892) },
                    { 413, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2421) },
                    { 412, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2416) },
                    { 411, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2410) },
                    { 410, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2405) },
                    { 337, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1507) },
                    { 336, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1452) },
                    { 1069, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6533) },
                    { 335, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1447) },
                    { 227, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9751) },
                    { 227, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9763) },
                    { 1076, 43, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6572) },
                    { 1075, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6568) },
                    { 1074, 42, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6565) },
                    { 1074, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6561) },
                    { 1074, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6558) },
                    { 1073, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6554) },
                    { 1072, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6551) },
                    { 1072, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6547) },
                    { 1072, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6543) },
                    { 623, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5537) },
                    { 622, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5531) },
                    { 621, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5525) },
                    { 227, 41, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9757) },
                    { 565, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4720) },
                    { 415, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2437) },
                    { 414, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2432) },
                    { 414, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2427) },
                    { 338, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1527) },
                    { 338, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1522) },
                    { 279, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(558) },
                    { 279, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(552) },
                    { 279, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(545) },
                    { 278, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(538) },
                    { 278, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(530) },
                    { 277, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(523) },
                    { 227, 42, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9768) },
                    { 449, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2897) },
                    { 1076, 24, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6575) },
                    { 276, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(518) },
                    { 276, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(506) },
                    { 616, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5460) },
                    { 616, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5453) },
                    { 616, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5446) },
                    { 616, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5439) },
                    { 447, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2887) },
                    { 447, 7, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2882) },
                    { 446, 1, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2877) },
                    { 446, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2871) },
                    { 147, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8158) },
                    { 147, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8152) },
                    { 147, 42, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8145) },
                    { 147, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8139) },
                    { 617, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5466) },
                    { 146, 21, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8132) },
                    { 146, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8118) },
                    { 146, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8112) },
                    { 146, 10, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8107) },
                    { 104, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7274) },
                    { 1062, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6487) },
                    { 1062, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6482) },
                    { 1061, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6478) },
                    { 1060, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6473) },
                    { 1059, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6469) },
                    { 1059, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6465) },
                    { 1058, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6462) },
                    { 1057, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6458) },
                    { 146, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8125) },
                    { 276, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(512) },
                    { 617, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5471) },
                    { 619, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5484) },
                    { 275, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(500) },
                    { 275, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(495) },
                    { 274, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(489) },
                    { 274, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(483) },
                    { 225, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9717) },
                    { 225, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9711) },
                    { 224, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9704) },
                    { 179, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8637) },
                    { 148, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8164) },
                    { 20, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5232) },
                    { 1068, 42, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6529) },
                    { 1068, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6526) },
                    { 618, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5477) },
                    { 1067, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6522) },
                    { 1065, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6515) },
                    { 1065, 36, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6511) },
                    { 1065, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6508) },
                    { 1064, 36, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6504) },
                    { 1064, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6501) },
                    { 1063, 36, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6497) },
                    { 1063, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6492) },
                    { 620, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5518) },
                    { 620, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5510) },
                    { 619, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5504) },
                    { 619, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5497) },
                    { 619, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5491) },
                    { 1066, 10, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6519) },
                    { 1077, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6579) },
                    { 1078, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6583) },
                    { 1078, 42, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6586) },
                    { 217, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9580) },
                    { 451, 23, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2917) },
                    { 154, 23, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8227) },
                    { 216, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9560) },
                    { 216, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9553) },
                    { 1099, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6720) },
                    { 1098, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6716) },
                    { 1097, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6713) },
                    { 1096, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6709) },
                    { 1095, 45, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6705) },
                    { 1095, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6702) },
                    { 1095, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6698) },
                    { 217, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9586) },
                    { 1094, 45, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6695) },
                    { 1094, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6686) },
                    { 640, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5767) },
                    { 640, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5761) },
                    { 640, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5756) },
                    { 640, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5751) },
                    { 640, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5743) },
                    { 566, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4725) },
                    { 340, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1565) },
                    { 340, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1558) },
                    { 340, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1552) },
                    { 23, 19, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5291) },
                    { 23, 34, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5284) },
                    { 1094, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6690) },
                    { 23, 20, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5277) },
                    { 217, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9592) },
                    { 418, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2499) },
                    { 65, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6303) },
                    { 65, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6295) },
                    { 64, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6289) },
                    { 64, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6282) },
                    { 64, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6276) },
                    { 64, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6271) },
                    { 64, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6265) },
                    { 64, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6260) },
                    { 63, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6255) },
                    { 63, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6248) },
                    { 63, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6241) },
                    { 62, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6234) },
                    { 418, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2493) },
                    { 61, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6228) },
                    { 61, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6214) },
                    { 61, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6207) },
                    { 60, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6200) },
                    { 60, 14, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6193) },
                    { 60, 22, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6186) },
                    { 60, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6179) },
                    { 60, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6172) },
                    { 420, 53, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2530) },
                    { 420, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2525) },
                    { 420, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2520) },
                    { 419, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2513) },
                    { 419, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2506) },
                    { 61, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6221) },
                    { 23, 8, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5272) },
                    { 23, 47, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5267) },
                    { 23, 39, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5261) },
                    { 229, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9791) },
                    { 229, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9784) },
                    { 228, 8, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9779) },
                    { 228, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9774) },
                    { 181, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8670) },
                    { 181, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8664) },
                    { 181, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8658) },
                    { 153, 8, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8221) },
                    { 153, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8214) },
                    { 152, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8207) },
                    { 152, 41, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8200) },
                    { 151, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8194) },
                    { 230, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9798) },
                    { 151, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8187) },
                    { 150, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8174) },
                    { 22, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5251) },
                    { 1087, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6623) },
                    { 1086, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6619) },
                    { 1085, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6615) },
                    { 1084, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6612) },
                    { 1083, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6608) },
                    { 1082, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6605) },
                    { 1081, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6601) },
                    { 1080, 44, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6598) },
                    { 1080, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6594) },
                    { 1079, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6590) },
                    { 150, 21, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8179) },
                    { 230, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9804) },
                    { 339, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1532) },
                    { 339, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1538) },
                    { 23, 17, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(5256) },
                    { 1093, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6682) },
                    { 1093, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6678) },
                    { 1093, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6674) },
                    { 1092, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6670) },
                    { 1092, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6666) },
                    { 1092, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6663) },
                    { 1091, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6659) },
                    { 1091, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6656) },
                    { 1090, 1, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6652) },
                    { 1090, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6648) },
                    { 1090, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6645) },
                    { 1090, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6641) },
                    { 1089, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6637) },
                    { 1089, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6633) },
                    { 1089, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6630) },
                    { 1088, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6626) },
                    { 450, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2910) },
                    { 450, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2903) },
                    { 417, 1, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2486) },
                    { 417, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2479) },
                    { 416, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2472) },
                    { 416, 8, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2465) },
                    { 416, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2458) },
                    { 416, 41, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2451) },
                    { 416, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2444) },
                    { 339, 21, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1545) },
                    { 1057, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6455) },
                    { 66, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6316) },
                    { 1057, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6451) },
                    { 1056, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6444) },
                    { 266, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(332) },
                    { 266, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(325) },
                    { 266, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(319) },
                    { 265, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(312) },
                    { 265, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(305) },
                    { 265, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(298) },
                    { 222, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9687) },
                    { 222, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9682) },
                    { 222, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9675) },
                    { 221, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9669) },
                    { 221, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9662) },
                    { 221, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9655) },
                    { 267, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(338) },
                    { 221, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9648) },
                    { 220, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9635) },
                    { 220, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9628) },
                    { 219, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9621) },
                    { 219, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9614) },
                    { 219, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9608) },
                    { 218, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9603) },
                    { 218, 7, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9598) },
                    { 178, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8631) },
                    { 177, 29, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8624) },
                    { 177, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8617) },
                    { 177, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8610) },
                    { 177, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8603) },
                    { 220, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9642) },
                    { 141, 4, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8003) },
                    { 267, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(344) },
                    { 267, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(355) },
                    { 329, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1396) },
                    { 329, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1389) },
                    { 329, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1382) },
                    { 328, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1376) },
                    { 328, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1369) },
                    { 328, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1364) },
                    { 327, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1359) },
                    { 327, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1353) },
                    { 326, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1348) },
                    { 326, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1342) },
                    { 325, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1335) },
                    { 325, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1308) },
                    { 267, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(350) },
                    { 271, 27, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(448) },
                    { 271, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(435) },
                    { 271, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(430) },
                    { 270, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(421) },
                    { 270, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(415) },
                    { 270, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(406) },
                    { 270, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(400) },
                    { 269, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(393) },
                    { 269, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(386) },
                    { 269, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(380) },
                    { 268, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(373) },
                    { 268, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(366) },
                    { 268, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(361) },
                    { 271, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(441) },
                    { 330, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1403) },
                    { 141, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7997) },
                    { 141, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7984) },
                    { 99, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7143) },
                    { 99, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7136) },
                    { 99, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7129) },
                    { 98, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7122) },
                    { 98, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7115) },
                    { 98, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7110) },
                    { 98, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7105) },
                    { 97, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7099) },
                    { 97, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7093) },
                    { 97, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7086) },
                    { 97, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7080) },
                    { 96, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7073) },
                    { 99, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7150) },
                    { 96, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7066) },
                    { 96, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7052) },
                    { 96, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7045) },
                    { 59, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6164) },
                    { 59, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6159) },
                    { 59, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6153) },
                    { 58, 27, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6146) },
                    { 58, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6113) },
                    { 58, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6106) },
                    { 58, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6099) },
                    { 57, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6093) },
                    { 57, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6086) },
                    { 56, 13, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6080) },
                    { 96, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7059) },
                    { 141, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7990) },
                    { 99, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7156) },
                    { 100, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7170) },
                    { 141, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7978) },
                    { 140, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7971) },
                    { 140, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7963) },
                    { 140, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7956) },
                    { 140, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7949) },
                    { 139, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7943) },
                    { 139, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7899) },
                    { 139, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7894) },
                    { 138, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7889) },
                    { 138, 9, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7883) },
                    { 138, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7876) },
                    { 138, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7869) },
                    { 100, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7163) },
                    { 103, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7267) },
                    { 103, 5, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7245) },
                    { 103, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7240) },
                    { 103, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7234) },
                    { 102, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7229) },
                    { 102, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7224) },
                    { 102, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7218) },
                    { 102, 3, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7211) },
                    { 101, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7204) },
                    { 101, 6, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7197) },
                    { 101, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7191) },
                    { 100, 32, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7184) },
                    { 100, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7177) },
                    { 103, 15, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(7260) },
                    { 330, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1410) },
                    { 330, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1417) },
                    { 403, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2268) },
                    { 407, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2352) },
                    { 407, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2347) },
                    { 407, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2341) },
                    { 407, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2335) },
                    { 406, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2327) },
                    { 406, 47, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2321) },
                    { 406, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2314) },
                    { 405, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2308) },
                    { 404, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2301) },
                    { 334, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1442) },
                    { 333, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1437) },
                    { 332, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1429) },
                    { 408, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2358) },
                    { 331, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(1424) },
                    { 273, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(469) },
                    { 272, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(462) },
                    { 272, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(455) },
                    { 223, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9697) },
                    { 223, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(9692) },
                    { 145, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8102) },
                    { 145, 39, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8096) },
                    { 145, 17, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8091) },
                    { 145, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8085) },
                    { 144, 39, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8078) },
                    { 144, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8072) },
                    { 143, 39, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8065) },
                    { 273, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(476) },
                    { 143, 21, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8058) },
                    { 408, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2365) },
                    { 409, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2379) },
                    { 1056, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6440) },
                    { 1056, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6435) },
                    { 1055, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6432) },
                    { 1055, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6428) },
                    { 1055, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6425) },
                    { 1054, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6421) },
                    { 1054, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6417) },
                    { 1054, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6414) },
                    { 1054, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6410) },
                    { 1053, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6406) },
                    { 1052, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6402) },
                    { 1052, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6399) },
                    { 409, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2372) },
                    { 1052, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6395) },
                    { 536, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4233) },
                    { 536, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4226) },
                    { 445, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2865) },
                    { 445, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2858) },
                    { 445, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2851) },
                    { 445, 40, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2845) },
                    { 445, 18, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2838) },
                    { 445, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2830) },
                    { 445, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2824) },
                    { 409, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2398) },
                    { 409, 39, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2393) },
                    { 409, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2386) },
                    { 536, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4240) },
                    { 143, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8051) },
                    { 142, 18, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8045) },
                    { 142, 33, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8038) },
                    { 1040, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6298) },
                    { 1040, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6293) },
                    { 639, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5736) },
                    { 639, 38, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5730) },
                    { 639, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5723) },
                    { 593, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5055) },
                    { 593, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5050) },
                    { 592, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5044) },
                    { 592, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5038) },
                    { 591, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5032) },
                    { 591, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5025) },
                    { 591, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5018) },
                    { 1041, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6301) },
                    { 590, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5011) },
                    { 589, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4999) },
                    { 589, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4993) },
                    { 563, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4710) },
                    { 563, 12, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4704) },
                    { 563, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4699) },
                    { 535, 6, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4220) },
                    { 535, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4215) },
                    { 535, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(4210) },
                    { 444, 15, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2819) },
                    { 444, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2814) },
                    { 403, 46, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2294) },
                    { 403, 33, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(2287) },
                    { 590, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(5004) },
                    { 1041, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6305) },
                    { 1042, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6308) },
                    { 1042, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6312) },
                    { 142, 40, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8031) },
                    { 142, 26, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8026) },
                    { 142, 8, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8019) },
                    { 142, 39, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8014) },
                    { 142, 12, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(8008) },
                    { 1051, 29, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6392) },
                    { 1051, 3, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6388) },
                    { 1050, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6385) },
                    { 1049, 13, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6381) },
                    { 1048, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6378) },
                    { 1048, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6374) },
                    { 1048, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6370) },
                    { 1047, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6367) },
                    { 1047, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6363) },
                    { 1047, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6360) },
                    { 1046, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6356) },
                    { 1046, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6352) },
                    { 1046, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6349) },
                    { 1045, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6345) },
                    { 1045, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6342) },
                    { 1045, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6338) },
                    { 1044, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6334) },
                    { 1044, 26, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6330) },
                    { 1044, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6327) },
                    { 1043, 32, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6323) },
                    { 1043, 5, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6319) },
                    { 1043, 28, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6316) },
                    { 1057, 17, new DateTime(2020, 12, 2, 15, 33, 35, 730, DateTimeKind.Local).AddTicks(6447) },
                    { 87, 28, new DateTime(2020, 12, 2, 15, 33, 35, 729, DateTimeKind.Local).AddTicks(6846) }
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
