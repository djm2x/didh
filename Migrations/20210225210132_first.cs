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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbvAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Axes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evenements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Examens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibelleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RapportNational = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompilationHCDH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObservationFinale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RapportMiParcours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiseOeuvrePiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RapportINDH = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdConcerner = table.Column<int>(type: "int", nullable: false),
                    IdOrganisme = table.Column<int>(type: "int", nullable: false),
                    TableConcerner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destinataire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vu = table.Column<bool>(type: "bit", nullable: false),
                    Priorite = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbvAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organismes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbrAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organismes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipationSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documents = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipationSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    Theme = table.Column<int>(type: "int", nullable: false),
                    SousTheme = table.Column<int>(type: "int", nullable: false),
                    Reporter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReporterAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PieceJointe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SituationReserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituationReserves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Traites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConventionPiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiseOeuvrePiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObservationPiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnalytiquePiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RapportParallelePiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RapportINDH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvisPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRatification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateSignature = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mandat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MandatAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LienRapport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiseOeuvrePiece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LienUpload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SousAxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAxe = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actif = table.Column<bool>(type: "bit", nullable: true),
                    IdOrganisme = table.Column<int>(type: "int", nullable: false),
                    IdProfil = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDernierRapport = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateObservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateProchaineRapport = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PieceJointe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdTraite = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeRecommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeRecommendationAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mecanisme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCycle = table.Column<int>(type: "int", nullable: true),
                    Axes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SousAxes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdOrgane = table.Column<int>(type: "int", nullable: true),
                    IdVisite = table.Column<int>(type: "int", nullable: true),
                    IdPays = table.Column<int>(type: "int", nullable: true),
                    Etat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtatAvancement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EtatAvancementChiffre = table.Column<int>(type: "int", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PieceJointe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Annee = table.Column<int>(type: "int", nullable: true),
                    AnneeDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnneeDisplayAr = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LienUpload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRapport = table.Column<int>(type: "int", nullable: true),
                    IdUser = table.Column<int>(type: "int", nullable: false)
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
                    IdRecommendation = table.Column<int>(type: "int", nullable: false),
                    IdOrganisme = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdOrganisme = table.Column<int>(type: "int", nullable: false),
                    IdSynthese = table.Column<int>(type: "int", nullable: false)
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
                    IdRecommandation = table.Column<int>(type: "int", nullable: false),
                    IdSynthese = table.Column<int>(type: "int", nullable: false)
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
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "DescriptionAr", "Title", "TitleAr" },
                values: new object[,]
                {
                    { 1, "الفئة 1", new DateTime(2020, 6, 29, 4, 37, 57, 103, DateTimeKind.Local).AddTicks(8075), "Quia iure ut vel quam. Quia iure iure cum nihil. Enim sint assumenda autem blanditiis aut quo natus incidunt tempore. Distinctio nemo dolorem ratione hic sit aperiam. Qui a consequatur quibusdam veritatis totam eum reprehenderit reprehenderit est. Veniam possimus tempora ut saepe et commodi. Quos magnam aliquam officia qui ducimus voluptas labore molestias aliquam. Quis quia aliquid nihil. Et earum sed nihil voluptates et porro quia quo. Reprehenderit temporibus iusto sapiente enim labore officia amet.", "أو الخامس كتيّب الخامس الخامس. المطابع منذ بمثابة عشوائي ولذلك. لهذه لم استخدام. أخرى الشكل التركيز والتنضيد ولذلك نسخ على بمعنى بمعنى. انتشر تعطي يتم مثبتة إيبسوم وهي تعطي وبشكله انتشر. هناك حتى ظهور الأحرف مع ويُستخدم حتى مرجع. حوت شكلي والتنضيد عشوائي هذا يقرأها. مؤخراَ للنص خمسة. زمن من كان لم حقيقة النشر مطبعة. الأحرف في الغاية شكل التركيز عشر هو. قرون كبير استخدام المقروء. بمعنى ليتراسيت عشوائي نسخ إيبسوم.", "ut", "الإلكتروني" },
                    { 2, "الفئة 1", new DateTime(2020, 8, 17, 10, 3, 23, 105, DateTimeKind.Local).AddTicks(2364), "Dolores temporibus aut earum molestiae deleniti enim aliquam provident quam. Et beatae sit distinctio dolorem libero dicta et placeat. Fugit ut culpa laboriosam id est at nam. Dolores voluptas porro reprehenderit doloribus veniam est non enim. Accusamus voluptatem doloremque sed sapiente consequatur reiciendis. Expedita deserunt nisi sunt et. Eius sit iste. Animi consectetur temporibus praesentium deserunt assumenda et. Consectetur est nisi. Reprehenderit quod omnis necessitatibus aut unde. Optio dolorum ut. Nihil velit architecto nihil et cumque laborum ipsum ut. Et voluptas sed facere voluptate iste voluptatem laborum.", "يقرأها برص الشكلي ليتراسيت طويل. الخامس مؤخراَ ولذلك عن. مقاطع تقضي دليل مطبعة الأصلي كتيّب طبيعياَ لهذه مع الأصلي. مرة ودور الزمن مرة المطابع. توزيعاَ لصفحة هي أيضاً زمن بل. التي الخارجي المقروء في الطباعة مرجع. نص التركيز لتكوّن مثل برامج لهذه ودور. التي البلاستيكية حتى. حقيقة كبير تحوي شكلي للنص المطابع نص. ظهور ويُستخدم حقيقة النشر ما طريقة التركيز لتكوّن لينتشر.", "dolores", "الخارجي" },
                    { 3, "الفئة 1", new DateTime(2020, 11, 19, 17, 19, 26, 568, DateTimeKind.Local).AddTicks(706), "Perferendis suscipit autem vel. Ut facere quia tenetur et totam voluptatem consectetur. Earum ullam qui et maiores quos et qui. Dicta quia eos est occaecati aut qui reprehenderit quod dolorum. Omnis eius eum labore voluptatum ipsum. Et qui non enim eveniet. Enim molestiae ipsa qui eveniet rerum quis error. Esse nihil quidem at. Incidunt occaecati iste sint. Rerum repellendus non quisquam rem qui sequi illum. Velit explicabo nihil omnis. Numquam blanditiis deserunt voluptas sunt. At dolore voluptas sunt aut quia.", "بمعنى الصفحة كان مثل إصدار مطبعة عن لتكوّن منذ ستينيّات. حوت الغاية كان دليل. بايج يقرأها دليل. زمن وعاد نسخ توزيعاَ هو التركيز خمسة يتم. التي كتيّب توزيعاَ الطباعة توضع. مجموعة يقرأها إيبسوم للنص. بمثابة ويُستخدم مرجع. لتكوّن أيضاً مثبتة هي. انه الشكل للنص عشر توزيعاَ المطابع. النشر المعيار ظهور بايج التركيز التي. من القرن قامت القرن المعيار إيبسوم الغاية كان ألدوس والتي. برص ظهور مطبعة كبير مرة.", "officiis", "ليتراسيت" },
                    { 4, "الفئة 1", new DateTime(2020, 6, 24, 3, 20, 19, 958, DateTimeKind.Local).AddTicks(5469), "Debitis qui sequi placeat ut facere. Magni quod sit atque sequi iusto consequuntur sunt. Dicta sed id et ea nemo reprehenderit praesentium saepe impedit. Sequi animi provident voluptate fuga omnis. Odit totam et quas tempore et. Earum molestiae quis magnam amet. Omnis dolorem culpa error qui atque dolore inventore sunt. Eligendi at fugiat nostrum qui provident. Et vero id voluptatibus. Fuga voluptates culpa. Quia autem laudantium aut voluptatem quia nihil eos voluptates.", "ظهور المطابع الأحرف خمسة والتنضيد نص أو لينتشر سيلهي المطابع. الزمن القرن هذا لهذه إصدار عن والتنضيد الإلكتروني. توزيعاَ التركيز بشكل النص رقائق برامج الزمن حتى. لأنها مرجع رقائق وبشكله. عندما مايكر الأحرف إصدار. إصدار والتنضيد ولذلك هو نص المحتوى. أخرى ستينيّات المقروء. لوريم مرجع هذا. توزيعاَ المقروء ما القارئ طويل. مقاطع شكل مستخدماً التركيز نسخ الشكل الفقرات تعطي منذ.", "dicta", "توزيعاَ" },
                    { 5, "الفئة 1", new DateTime(2020, 12, 4, 17, 31, 21, 469, DateTimeKind.Local).AddTicks(9202), "A eos ab. Ad aliquid perspiciatis doloremque quo libero accusantium delectus alias. Neque aliquam et necessitatibus. Repellendus quidem a est et sequi. Perferendis voluptatem soluta commodi qui. Qui suscipit corrupti non recusandae ut iste dolores aliquam. Temporibus eius rem ut facere earum id est omnis. Eum corrupti voluptate alias quos dolorum est asperiores laboriosam. Aliquid voluptatum non amet labore libero. Tenetur quia praesentium sit a provident qui dolorem. Sapiente magnam non quasi velit tenetur.", "عندما يقرأها صار. بشكل مجموعة كبير النشر عن بل بشكل برامج. أخرى هي برص مثبتة قرون. النص التركيز استخدام إصدار ما. أخرى تقضي بل. توزيعاَ خمسة شكل ولايزال ولايزال. حوت ولايزال عشر لوريم ولايزال هناك طويل ظهور بمثابة عن. مؤخراَ إصدار هذا زمن مقاطع انتشر مجهولة الفقرات. مجموعة كتيّب مرة أخرى. القارئ وليس توضع الخارجي الغاية لم وبشكله المحتوى. لتكوّن المحتوى انتشر خمسة المطابع برامج الغاية برص.", "veniam", "إصدار" },
                    { 6, "الفئة 1", new DateTime(2021, 1, 11, 1, 7, 56, 390, DateTimeKind.Local).AddTicks(2829), "Nulla perferendis voluptatum ex nulla et ad aperiam quo in. In aliquid sit libero ut et quis. Incidunt error molestiae aut nobis vitae. Dolores numquam et consequatur. Cum nisi tempore. Vitae quam sint modi consequatur labore beatae hic itaque officia. Quae aut sit ipsum voluptatum itaque unde dicta quam et. Autem ad eligendi atque veritatis delectus impedit quis voluptas ut. Sit officia atque quis et dolorum asperiores corrupti. Quia explicabo aut odit voluptas velit eveniet non quia consequuntur. Aliquam beatae dolor et et.", "المحتوى عندما مرة أيضاً. أو انه تقضي برامج للنص التركيز يقرأها الشكل. يتم والتي مثل كان إصدار النشر التركيز الغاية ولايزال المحتوى. تعطي لم قامت قرون عن شكلي الإلكتروني من. مرجع والتي الطباعة كتيّب أو حوت القارئ هناك منذ. الأحرف الشكلي كان عشوائي صناعات. يقرأها هي ولذلك كان بشكل نص. الإلكتروني نص نسخ. القرن هو لصفحة ودور أخذتها وعاد برص انتشر منذ منذ. زمن القارئ الأحرف وليس عن. وهي الأصلي المقروء وليس ويُستخدم طريقة يقرأها طريقة ليتراسيت.", "reiciendis", "الطباعة" },
                    { 7, "الفئة 1", new DateTime(2020, 11, 10, 13, 29, 7, 97, DateTimeKind.Local).AddTicks(6979), "Maiores nemo et autem harum maxime eum consectetur. Error necessitatibus assumenda et et in nostrum sunt et numquam. Modi minus cupiditate earum. Aut veritatis ut sit qui molestias voluptas eius ut. Quae ipsum illo libero. Voluptatum est eum hic molestiae. Adipisci quisquam aliquid tempore excepturi. Exercitationem sequi ducimus magnam repellendus. Hic provident nobis deleniti aut dolore illo quia. Eum sit non quia aperiam adipisci eos. In et sunt perferendis sint et laboriosam unde.", "انه أن وليس لأنها. صار المحتوى المطابع أخرى طبيعياَ. إصدار توضع وهي مثبتة المقروء مثل لصفحة انتشر. أن تقضي هذا التركيز كتيّب منذ. تقضي مقاطع كتيّب ولذلك مستخدماً ببساطة وهي مرة. مجموعة شكلي مجهولة مقاطع يقرأها بمعنى. ألدوس ولذلك عشوائي ظهور. والتي الشكل لينتشر مايكر. حوت المعيار نص تحوي الخامس مقاطع شكلي ما مؤخراَ الأصلي. أن المطابع كبير الشكل ودور.", "molestias", "وبشكله" },
                    { 8, "الفئة 1", new DateTime(2020, 3, 3, 0, 39, 36, 804, DateTimeKind.Local).AddTicks(3048), "Et omnis aut incidunt quod non accusantium. Blanditiis cumque provident nihil quia sed nostrum. Laborum accusamus veritatis nihil modi quibusdam aliquam. Debitis facilis quibusdam voluptas deserunt inventore odio. Doloribus ipsum eaque amet quia consequatur debitis. Mollitia sint autem aut voluptatibus. At id ut totam ut nihil praesentium. Sit quia ullam totam. Explicabo magni voluptatem itaque qui. Sapiente quo eaque et aut. Aut asperiores voluptas eum impedit nihil. Natus voluptatem autem adipisci et.", "المحتوى هناك سيلهي. توضع بايج النص مثبتة كان أخذتها مع تعطي بايج هو. المقروء المحتوى النشر هو حوت تقضي مثل خمسة مقاطع مثل. الصفحة الشكل الأحرف. هناك المقروء شكل عندما القارئ استخدام الشكلي إصدار القرن والتي. منذ ليتراسيت مستخدماً صناعات هذا. والتنضيد دليل تعطي الشكل لتكوّن المحتوى حقيقة. الزمن دليل القرن القرن التركيز طويل دليل. الخامس ستينيّات هناك وليس انه ولايزال. تحوي الطباعة يتم مجموعة لهذه الخامس الشكل الفقرات صار قامت. أو والتي عشوائي القارئ تقضي ألدوس. مرة تقضي إصدار.", "cupiditate", "في" },
                    { 9, "الفئة 1", new DateTime(2020, 6, 18, 15, 32, 47, 933, DateTimeKind.Local).AddTicks(6738), "Maiores est autem non consequatur aliquid sunt commodi voluptate ea. Reprehenderit illum iure commodi voluptas laudantium quisquam. Quam molestiae harum nesciunt autem dolores illo doloribus qui quod. Quidem voluptatem id aliquid ea. Porro aut quia ut commodi aut. Delectus veniam eaque necessitatibus porro. Odit quia quaerat voluptate molestiae. Ex error alias autem enim commodi ut. Aperiam est esse repellendus totam maiores et. Corrupti animi inventore illo quam nemo adipisci. Explicabo dolorem enim.", "أو حوت ظهور القارئ. ولذلك بايج ولايزال. الإلكتروني وليس لهذه مجموعة عندما التركيز قامت لم والتي. صار وعاد أخرى كتيّب التركيز الشكل. أو الصفحة مثل. الشكل والتي توزيعاَ زمن. مؤخراَ المحتوى تحوي ولذلك يقرأها. بشكل زمن الأصلي استخدام نص هو استخدام القرن سيلهي أيضاً. المحتوى المطابع البلاستيكية بايج لهذه وهي هناك. كبير وهي انه. هذا دليل خمسة مستخدماً توضع الشكلي ودور طويل. مستخدماً رقائق عشوائي الخارجي ما الصفحة شكلي ببساطة لم.", "quis", "والتنضيد" },
                    { 10, "الفئة 1", new DateTime(2020, 9, 29, 6, 32, 12, 913, DateTimeKind.Local).AddTicks(9568), "Et pariatur quia quidem minima exercitationem vero. Consequatur sunt fugiat quia quasi deserunt rerum sint inventore voluptatem. Earum quod est perspiciatis exercitationem quo error eveniet. Aut eos fugit dolorum ut ut id perspiciatis. Aliquam sint pariatur rerum et. Quas corrupti facere omnis. Velit excepturi commodi libero nesciunt. Aut voluptatem corporis debitis et porro. Voluptatem a tempora reiciendis non vero. Vero explicabo consectetur et. Nulla repellat debitis.", "هي طويل مع من النص حقيقة هذا النص وهي. بايج عندما هذا. الشكلي هذا طويل الصفحة الفقرات الطباعة. توضع رقائق بل عشوائي عشوائي. كبير بشكل النص يقرأها الإلكتروني مطبعة الغاية. التي لصفحة القارئ مستخدماً هذا الطباعة أيضاً شكلي. المطابع القارئ حوت. الفقرات خمسة الشكلي لأنها مع. والتنضيد للنص منذ ويُستخدم تعطي المطابع منذ. ودور كتيّب كان ولايزال تعطي مرجع حوت مجموعة مقاطع يتم.", "vero", "انه" }
                });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "LibelleAr", "MiseOeuvrePiece", "ObservationFinale", "RapportINDH", "RapportMiParcours", "RapportNational" },
                values: new object[,]
                {
                    { 6, "", "", "Examen-7", "مراجعة-7", "", "", null, "", "" },
                    { 5, "", "", "Examen-6", "مراجعة-6", "", "", null, "", "" },
                    { 4, "", "", "Examen-5", "مراجعة-5", "", "", null, "", "" },
                    { 2, "", "", "Examen-3", "مراجعة-3", "", "", null, "", "" },
                    { 1, "", "", "Examen-2", "مراجعة-2", "", "", null, "", "" },
                    { 3, "", "", "Examen-4", "مراجعة-4", "", "", null, "", "" }
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
                    { 5, 2020, "", "", "Session 5", "جلسة 5" },
                    { 7, 2020, "", "", "Session 7", "جلسة 7" },
                    { 6, 2020, "", "", "Session 6", "جلسة 6" },
                    { 4, 2020, "", "", "Session 4", "جلسة 4" },
                    { 3, 2020, "", "", "Session 3", "جلسة 3" },
                    { 2, 2020, "", "", "Session 2", "جلسة 2" },
                    { 1, 2020, "", "", "Session 1", "جلسة 1" },
                    { 8, 2020, "", "", "Session 8", "جلسة 8" }
                });

            migrationBuilder.InsertData(
                table: "Profils",
                columns: new[] { "Id", "Label", "LabelAr" },
                values: new object[,]
                {
                    { 4, "Propriétaire", "مالك" },
                    { 3, "Point focal", "	المخاطب الرئيسي" },
                    { 2, "Superviseur", "مشرف" },
                    { 1, "Administrateur", "مدير" }
                });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "Reporter", "ReporterAr", "SousTheme", "Theme" },
                values: new object[,]
                {
                    { 9, 2020, "", "Reporter 10", "10 مقرر", 3, 2 },
                    { 14, 2020, "", "Reporter 15", "15 مقرر", 2, 1 },
                    { 13, 2020, "", "Reporter 14", "14 مقرر", 3, 2 },
                    { 12, 2020, "", "Reporter 13", "13 مقرر", 1, 1 },
                    { 11, 2020, "", "Reporter 12", "12 مقرر", 4, 2 },
                    { 10, 2020, "", "Reporter 11", "11 مقرر", 1, 1 },
                    { 8, 2020, "", "Reporter 9", "9 مقرر", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "Reporter", "ReporterAr", "SousTheme", "Theme" },
                values: new object[,]
                {
                    { 15, 2020, "", "Reporter 16", "16 مقرر", 3, 2 },
                    { 6, 2020, "", "Reporter 7", "7 مقرر", 2, 1 },
                    { 5, 2020, "", "Reporter 6", "6 مقرر", 4, 2 },
                    { 4, 2020, "", "Reporter 5", "5 مقرر", 1, 1 },
                    { 3, 2020, "", "Reporter 4", "4 مقرر", 4, 2 },
                    { 2, 2020, "", "Reporter 3", "3 مقرر", 2, 1 },
                    { 1, 2020, "", "Reporter 2", "2 مقرر", 4, 2 },
                    { 7, 2020, "", "Reporter 8", "8 مقرر", 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "AvisPosition", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportINDH", "RapportParallelePiece" },
                values: new object[,]
                {
                    { 65, "", null, "", new DateTime(2020, 10, 7, 6, 2, 27, 959, DateTimeKind.Local).AddTicks(6642), new DateTime(2021, 1, 29, 11, 50, 49, 648, DateTimeKind.Local).AddTicks(1130), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 66, "", null, "", new DateTime(2020, 2, 28, 0, 3, 44, 657, DateTimeKind.Local).AddTicks(9323), new DateTime(2020, 5, 7, 21, 37, 40, 877, DateTimeKind.Local).AddTicks(9040), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 67, "", null, "", new DateTime(2020, 10, 17, 1, 53, 46, 894, DateTimeKind.Local).AddTicks(5061), new DateTime(2021, 1, 23, 18, 5, 52, 554, DateTimeKind.Local).AddTicks(1932), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 68, "", null, "", new DateTime(2021, 2, 22, 13, 27, 39, 87, DateTimeKind.Local).AddTicks(2195), new DateTime(2021, 1, 26, 15, 19, 20, 197, DateTimeKind.Local).AddTicks(6471), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 71, "", null, "", new DateTime(2020, 7, 18, 10, 15, 53, 941, DateTimeKind.Local).AddTicks(5370), new DateTime(2020, 3, 26, 4, 25, 25, 762, DateTimeKind.Local).AddTicks(5258), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 70, "", null, "", new DateTime(2021, 1, 31, 11, 43, 29, 871, DateTimeKind.Local).AddTicks(5488), new DateTime(2020, 10, 7, 4, 38, 42, 868, DateTimeKind.Local).AddTicks(380), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 64, "", null, "", new DateTime(2020, 3, 2, 11, 44, 13, 334, DateTimeKind.Local).AddTicks(6294), new DateTime(2020, 12, 26, 19, 51, 2, 201, DateTimeKind.Local).AddTicks(4797), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 72, "", null, "", new DateTime(2020, 11, 29, 14, 54, 5, 759, DateTimeKind.Local).AddTicks(4382), new DateTime(2020, 7, 5, 20, 28, 27, 248, DateTimeKind.Local).AddTicks(987), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 69, "", null, "", new DateTime(2021, 1, 22, 8, 5, 31, 850, DateTimeKind.Local).AddTicks(6240), new DateTime(2020, 8, 4, 11, 6, 22, 290, DateTimeKind.Local).AddTicks(6294), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 63, "", null, "", new DateTime(2020, 10, 18, 19, 19, 23, 67, DateTimeKind.Local).AddTicks(6610), new DateTime(2020, 12, 3, 11, 11, 2, 695, DateTimeKind.Local).AddTicks(925), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 60, "", null, "", new DateTime(2020, 7, 1, 14, 42, 32, 379, DateTimeKind.Local).AddTicks(5113), new DateTime(2020, 3, 7, 15, 38, 46, 75, DateTimeKind.Local).AddTicks(4770), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 61, "", null, "", new DateTime(2020, 11, 9, 7, 25, 41, 970, DateTimeKind.Local).AddTicks(1085), new DateTime(2021, 1, 23, 16, 53, 13, 592, DateTimeKind.Local).AddTicks(1862), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 73, "", null, "", new DateTime(2021, 1, 4, 2, 2, 33, 324, DateTimeKind.Local).AddTicks(6933), new DateTime(2020, 6, 9, 14, 44, 32, 177, DateTimeKind.Local).AddTicks(2365), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 59, "", null, "", new DateTime(2020, 3, 3, 23, 14, 26, 364, DateTimeKind.Local).AddTicks(7702), new DateTime(2020, 7, 19, 15, 19, 3, 407, DateTimeKind.Local).AddTicks(3371), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 58, "", null, "", new DateTime(2020, 7, 12, 9, 26, 58, 814, DateTimeKind.Local).AddTicks(8851), new DateTime(2020, 7, 26, 10, 33, 25, 46, DateTimeKind.Local).AddTicks(1728), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 57, "", null, "", new DateTime(2020, 9, 12, 18, 33, 31, 400, DateTimeKind.Local).AddTicks(2566), new DateTime(2020, 4, 17, 7, 53, 49, 914, DateTimeKind.Local).AddTicks(4373), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 56, "", null, "", new DateTime(2020, 6, 22, 8, 44, 46, 988, DateTimeKind.Local).AddTicks(7418), new DateTime(2020, 4, 2, 14, 35, 32, 34, DateTimeKind.Local).AddTicks(1682), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 55, "", null, "", new DateTime(2020, 3, 2, 21, 1, 53, 342, DateTimeKind.Local).AddTicks(8798), new DateTime(2020, 8, 13, 9, 48, 8, 431, DateTimeKind.Local).AddTicks(5711), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 54, "", null, "", new DateTime(2020, 2, 28, 17, 8, 50, 480, DateTimeKind.Local).AddTicks(7551), new DateTime(2020, 9, 17, 8, 3, 34, 528, DateTimeKind.Local).AddTicks(4005), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 53, "", null, "", new DateTime(2021, 1, 13, 14, 23, 30, 326, DateTimeKind.Local).AddTicks(3887), new DateTime(2021, 2, 5, 12, 52, 55, 794, DateTimeKind.Local).AddTicks(8901), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 52, "", null, "", new DateTime(2020, 3, 1, 1, 6, 23, 425, DateTimeKind.Local).AddTicks(6113), new DateTime(2020, 8, 14, 17, 46, 4, 819, DateTimeKind.Local).AddTicks(1467), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 62, "", null, "", new DateTime(2021, 2, 17, 21, 55, 6, 445, DateTimeKind.Local).AddTicks(272), new DateTime(2020, 8, 5, 22, 33, 48, 70, DateTimeKind.Local).AddTicks(4969), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 74, "", null, "", new DateTime(2021, 1, 6, 10, 51, 24, 442, DateTimeKind.Local).AddTicks(3190), new DateTime(2020, 11, 3, 6, 31, 34, 637, DateTimeKind.Local).AddTicks(1115), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 78, "", null, "", new DateTime(2020, 7, 25, 19, 4, 55, 68, DateTimeKind.Local).AddTicks(912), new DateTime(2020, 4, 12, 19, 26, 28, 253, DateTimeKind.Local).AddTicks(4336), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 76, "", null, "", new DateTime(2020, 7, 1, 19, 22, 56, 993, DateTimeKind.Local).AddTicks(9035), new DateTime(2020, 4, 15, 17, 49, 40, 466, DateTimeKind.Local).AddTicks(8240), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 51, "", null, "", new DateTime(2020, 7, 14, 16, 28, 26, 865, DateTimeKind.Local).AddTicks(4494), new DateTime(2021, 2, 24, 9, 11, 30, 22, DateTimeKind.Local).AddTicks(6059), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 98, "", null, "", new DateTime(2021, 1, 21, 10, 45, 42, 831, DateTimeKind.Local).AddTicks(3005), new DateTime(2020, 6, 21, 23, 5, 50, 957, DateTimeKind.Local).AddTicks(2973), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 97, "", null, "", new DateTime(2020, 3, 13, 3, 55, 6, 618, DateTimeKind.Local).AddTicks(5866), new DateTime(2020, 12, 8, 12, 0, 52, 374, DateTimeKind.Local).AddTicks(912), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 96, "", null, "", new DateTime(2020, 3, 13, 15, 18, 29, 131, DateTimeKind.Local).AddTicks(254), new DateTime(2020, 6, 24, 10, 32, 31, 388, DateTimeKind.Local).AddTicks(1947), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 95, "", null, "", new DateTime(2020, 4, 15, 15, 28, 57, 818, DateTimeKind.Local).AddTicks(1389), new DateTime(2020, 3, 7, 13, 14, 11, 812, DateTimeKind.Local).AddTicks(1453), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 94, "", null, "", new DateTime(2020, 10, 5, 11, 1, 8, 10, DateTimeKind.Local).AddTicks(5838), new DateTime(2020, 10, 9, 6, 22, 40, 482, DateTimeKind.Local).AddTicks(6916), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 93, "", null, "", new DateTime(2020, 6, 17, 8, 10, 51, 967, DateTimeKind.Local).AddTicks(5788), new DateTime(2020, 5, 17, 10, 33, 29, 229, DateTimeKind.Local).AddTicks(5970), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 92, "", null, "", new DateTime(2020, 11, 5, 19, 4, 14, 355, DateTimeKind.Local).AddTicks(2009), new DateTime(2020, 4, 10, 19, 32, 26, 672, DateTimeKind.Local).AddTicks(5970), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 91, "", null, "", new DateTime(2020, 9, 11, 19, 44, 29, 194, DateTimeKind.Local).AddTicks(2846), new DateTime(2020, 12, 22, 22, 55, 47, 290, DateTimeKind.Local).AddTicks(1497), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" }
                });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "AvisPosition", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportINDH", "RapportParallelePiece" },
                values: new object[,]
                {
                    { 90, "", null, "", new DateTime(2020, 7, 13, 20, 0, 55, 150, DateTimeKind.Local).AddTicks(7943), new DateTime(2020, 11, 2, 19, 10, 43, 103, DateTimeKind.Local).AddTicks(4816), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 75, "", null, "", new DateTime(2021, 2, 17, 13, 30, 51, 65, DateTimeKind.Local).AddTicks(6314), new DateTime(2020, 11, 8, 21, 3, 28, 449, DateTimeKind.Local).AddTicks(7437), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 89, "", null, "", new DateTime(2021, 2, 23, 10, 5, 57, 361, DateTimeKind.Local).AddTicks(6626), new DateTime(2021, 1, 1, 9, 15, 47, 355, DateTimeKind.Local).AddTicks(9804), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 87, "", null, "", new DateTime(2021, 2, 2, 2, 33, 35, 650, DateTimeKind.Local).AddTicks(2042), new DateTime(2020, 8, 27, 11, 28, 56, 429, DateTimeKind.Local).AddTicks(6461), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 86, "", null, "", new DateTime(2020, 6, 20, 18, 0, 14, 311, DateTimeKind.Local).AddTicks(8045), new DateTime(2020, 5, 12, 18, 54, 42, 490, DateTimeKind.Local).AddTicks(4588), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 85, "", null, "", new DateTime(2020, 11, 4, 8, 33, 7, 316, DateTimeKind.Local).AddTicks(4276), new DateTime(2020, 12, 26, 16, 54, 7, 905, DateTimeKind.Local).AddTicks(6750), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 84, "", null, "", new DateTime(2020, 8, 20, 11, 59, 7, 433, DateTimeKind.Local).AddTicks(147), new DateTime(2021, 1, 1, 16, 1, 37, 702, DateTimeKind.Local).AddTicks(3603), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 83, "", null, "", new DateTime(2021, 1, 31, 8, 21, 24, 256, DateTimeKind.Local).AddTicks(4672), new DateTime(2021, 1, 25, 12, 59, 37, 608, DateTimeKind.Local).AddTicks(5369), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 82, "", null, "", new DateTime(2020, 7, 27, 0, 28, 10, 243, DateTimeKind.Local).AddTicks(7358), new DateTime(2020, 8, 12, 2, 10, 13, 807, DateTimeKind.Local).AddTicks(4668), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 81, "", null, "", new DateTime(2020, 4, 10, 20, 34, 50, 587, DateTimeKind.Local).AddTicks(935), new DateTime(2021, 1, 23, 21, 48, 58, 480, DateTimeKind.Local).AddTicks(6529), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 80, "", null, "", new DateTime(2020, 10, 15, 22, 45, 1, 669, DateTimeKind.Local).AddTicks(5717), new DateTime(2020, 6, 24, 3, 7, 57, 974, DateTimeKind.Local).AddTicks(1105), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 79, "", null, "", new DateTime(2020, 2, 28, 14, 1, 29, 622, DateTimeKind.Local).AddTicks(2734), new DateTime(2020, 3, 20, 6, 49, 9, 870, DateTimeKind.Local).AddTicks(7454), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 77, "", null, "", new DateTime(2021, 1, 16, 4, 10, 37, 723, DateTimeKind.Local).AddTicks(5786), new DateTime(2020, 10, 27, 12, 17, 43, 586, DateTimeKind.Local).AddTicks(6753), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 88, "", null, "", new DateTime(2020, 5, 12, 1, 33, 23, 500, DateTimeKind.Local).AddTicks(1730), new DateTime(2020, 9, 26, 5, 8, 10, 706, DateTimeKind.Local).AddTicks(1185), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 50, "", null, "", new DateTime(2020, 7, 24, 22, 20, 21, 651, DateTimeKind.Local).AddTicks(1912), new DateTime(2021, 2, 14, 5, 36, 15, 182, DateTimeKind.Local).AddTicks(7313), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 25, "", null, "", new DateTime(2021, 2, 19, 4, 44, 32, 213, DateTimeKind.Local).AddTicks(1936), new DateTime(2020, 8, 5, 6, 7, 46, 151, DateTimeKind.Local).AddTicks(5888), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 48, "", null, "", new DateTime(2020, 11, 13, 9, 24, 46, 557, DateTimeKind.Local).AddTicks(1253), new DateTime(2020, 11, 4, 5, 13, 11, 166, DateTimeKind.Local).AddTicks(3355), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 21, "", null, "", new DateTime(2021, 1, 21, 14, 44, 10, 725, DateTimeKind.Local).AddTicks(746), new DateTime(2021, 2, 3, 5, 15, 49, 37, DateTimeKind.Local).AddTicks(6888), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 20, "", null, "", new DateTime(2020, 6, 28, 6, 51, 31, 883, DateTimeKind.Local).AddTicks(9488), new DateTime(2020, 8, 27, 12, 10, 52, 443, DateTimeKind.Local).AddTicks(1564), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 19, "", null, "", new DateTime(2020, 4, 13, 18, 33, 28, 323, DateTimeKind.Local).AddTicks(8813), new DateTime(2020, 6, 14, 22, 1, 14, 567, DateTimeKind.Local).AddTicks(8370), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 18, "", null, "", new DateTime(2020, 8, 22, 5, 10, 27, 313, DateTimeKind.Local).AddTicks(5378), new DateTime(2020, 5, 4, 6, 9, 51, 290, DateTimeKind.Local).AddTicks(9096), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 17, "", null, "", new DateTime(2020, 6, 1, 22, 7, 21, 133, DateTimeKind.Local).AddTicks(6582), new DateTime(2020, 4, 4, 22, 9, 20, 161, DateTimeKind.Local).AddTicks(2971), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 16, "", null, "", new DateTime(2021, 1, 3, 13, 3, 13, 415, DateTimeKind.Local).AddTicks(2504), new DateTime(2020, 6, 10, 0, 17, 47, 37, DateTimeKind.Local).AddTicks(5411), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 15, "", null, "", new DateTime(2020, 10, 28, 18, 46, 28, 53, DateTimeKind.Local).AddTicks(8636), new DateTime(2020, 10, 23, 21, 59, 22, 607, DateTimeKind.Local).AddTicks(3427), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 14, "", null, "", new DateTime(2020, 12, 18, 1, 5, 13, 402, DateTimeKind.Local).AddTicks(5864), new DateTime(2020, 7, 1, 13, 19, 5, 282, DateTimeKind.Local).AddTicks(1426), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 13, "", null, "", new DateTime(2020, 5, 1, 0, 32, 32, 417, DateTimeKind.Local).AddTicks(5653), new DateTime(2020, 4, 7, 5, 29, 22, 727, DateTimeKind.Local).AddTicks(7291), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 12, "", null, "", new DateTime(2021, 1, 28, 4, 29, 37, 745, DateTimeKind.Local).AddTicks(380), new DateTime(2020, 8, 30, 1, 23, 20, 800, DateTimeKind.Local).AddTicks(7491), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 11, "", null, "", new DateTime(2020, 2, 26, 22, 33, 21, 93, DateTimeKind.Local).AddTicks(8047), new DateTime(2020, 12, 31, 11, 38, 41, 997, DateTimeKind.Local).AddTicks(3638), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 10, "", null, "", new DateTime(2020, 5, 17, 3, 46, 33, 370, DateTimeKind.Local).AddTicks(749), new DateTime(2020, 5, 24, 3, 5, 32, 331, DateTimeKind.Local).AddTicks(8438), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 9, "", null, "", new DateTime(2020, 3, 7, 21, 0, 28, 64, DateTimeKind.Local).AddTicks(1195), new DateTime(2020, 12, 8, 18, 35, 7, 140, DateTimeKind.Local).AddTicks(245), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 8, "", null, "", new DateTime(2020, 6, 6, 11, 5, 29, 70, DateTimeKind.Local).AddTicks(9710), new DateTime(2020, 3, 18, 19, 16, 4, 730, DateTimeKind.Local).AddTicks(8378), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 7, "", null, "", new DateTime(2020, 12, 26, 9, 35, 1, 732, DateTimeKind.Local).AddTicks(4306), new DateTime(2020, 4, 9, 22, 45, 49, 474, DateTimeKind.Local).AddTicks(4906), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 6, "", null, "", new DateTime(2020, 5, 14, 4, 57, 30, 270, DateTimeKind.Local).AddTicks(4560), new DateTime(2021, 1, 19, 1, 20, 4, 475, DateTimeKind.Local).AddTicks(2691), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 5, "", null, "", new DateTime(2021, 2, 17, 6, 25, 7, 275, DateTimeKind.Local).AddTicks(4970), new DateTime(2020, 7, 6, 6, 4, 38, 17, DateTimeKind.Local).AddTicks(1473), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 4, "", null, "", new DateTime(2020, 11, 25, 4, 26, 37, 950, DateTimeKind.Local).AddTicks(8664), new DateTime(2020, 3, 30, 4, 36, 6, 260, DateTimeKind.Local).AddTicks(6391), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 3, "", null, "", new DateTime(2020, 5, 1, 5, 38, 22, 737, DateTimeKind.Local).AddTicks(8165), new DateTime(2020, 8, 13, 14, 37, 51, 503, DateTimeKind.Local).AddTicks(8836), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 2, "", null, "", new DateTime(2020, 12, 6, 11, 29, 2, 61, DateTimeKind.Local).AddTicks(8443), new DateTime(2020, 5, 8, 5, 30, 52, 958, DateTimeKind.Local).AddTicks(4390), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 1, "", null, "", new DateTime(2020, 10, 27, 7, 16, 37, 740, DateTimeKind.Local).AddTicks(7218), new DateTime(2021, 1, 28, 4, 23, 25, 149, DateTimeKind.Local).AddTicks(7121), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 22, "", null, "", new DateTime(2020, 7, 5, 15, 21, 48, 923, DateTimeKind.Local).AddTicks(1688), new DateTime(2020, 11, 26, 2, 19, 7, 780, DateTimeKind.Local).AddTicks(1603), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 23, "", null, "", new DateTime(2020, 12, 14, 23, 19, 23, 281, DateTimeKind.Local).AddTicks(4607), new DateTime(2020, 12, 26, 15, 30, 37, 244, DateTimeKind.Local).AddTicks(7474), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 24, "", null, "", new DateTime(2020, 4, 25, 4, 41, 5, 227, DateTimeKind.Local).AddTicks(2293), new DateTime(2020, 9, 21, 20, 49, 28, 673, DateTimeKind.Local).AddTicks(1548), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 99, "", null, "", new DateTime(2020, 9, 3, 15, 20, 43, 712, DateTimeKind.Local).AddTicks(759), new DateTime(2020, 6, 10, 12, 7, 57, 614, DateTimeKind.Local).AddTicks(7979), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" }
                });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "AvisPosition", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "NomAr", "ObservationPiece", "RapportINDH", "RapportParallelePiece" },
                values: new object[,]
                {
                    { 47, "", null, "", new DateTime(2021, 2, 18, 22, 33, 15, 943, DateTimeKind.Local).AddTicks(9488), new DateTime(2020, 4, 4, 3, 12, 21, 989, DateTimeKind.Local).AddTicks(3960), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 46, "", null, "", new DateTime(2020, 4, 6, 8, 3, 36, 368, DateTimeKind.Local).AddTicks(8908), new DateTime(2020, 4, 27, 2, 14, 45, 363, DateTimeKind.Local).AddTicks(8848), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 45, "", null, "", new DateTime(2020, 12, 3, 16, 49, 58, 917, DateTimeKind.Local).AddTicks(1718), new DateTime(2021, 2, 17, 7, 14, 14, 535, DateTimeKind.Local).AddTicks(1443), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 44, "", null, "", new DateTime(2021, 1, 13, 7, 39, 48, 752, DateTimeKind.Local).AddTicks(9728), new DateTime(2020, 7, 10, 22, 17, 55, 726, DateTimeKind.Local).AddTicks(4041), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 43, "", null, "", new DateTime(2020, 9, 27, 2, 56, 6, 69, DateTimeKind.Local).AddTicks(9178), new DateTime(2020, 4, 3, 23, 29, 33, 777, DateTimeKind.Local).AddTicks(5231), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 42, "", null, "", new DateTime(2020, 5, 19, 13, 22, 39, 525, DateTimeKind.Local).AddTicks(6102), new DateTime(2020, 9, 9, 18, 24, 18, 787, DateTimeKind.Local).AddTicks(7776), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 41, "", null, "", new DateTime(2020, 7, 19, 1, 56, 11, 147, DateTimeKind.Local).AddTicks(6292), new DateTime(2020, 11, 29, 15, 58, 29, 317, DateTimeKind.Local).AddTicks(1847), "", "", "La lutte contre toutes les formes de discrimination", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 40, "", null, "", new DateTime(2020, 3, 30, 11, 38, 0, 409, DateTimeKind.Local).AddTicks(2294), new DateTime(2020, 6, 1, 10, 26, 7, 824, DateTimeKind.Local).AddTicks(8947), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 39, "", null, "", new DateTime(2020, 10, 31, 13, 5, 45, 500, DateTimeKind.Local).AddTicks(5674), new DateTime(2021, 2, 13, 21, 35, 4, 867, DateTimeKind.Local).AddTicks(5964), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 38, "", null, "", new DateTime(2020, 12, 21, 0, 48, 55, 243, DateTimeKind.Local).AddTicks(6630), new DateTime(2021, 1, 23, 3, 43, 56, 659, DateTimeKind.Local).AddTicks(1281), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 49, "", null, "", new DateTime(2021, 2, 3, 19, 22, 0, 494, DateTimeKind.Local).AddTicks(4222), new DateTime(2020, 10, 30, 11, 29, 18, 44, DateTimeKind.Local).AddTicks(2657), "", "", "La lutte contre toutes les formes de discrimination", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 37, "", null, "", new DateTime(2020, 7, 20, 18, 24, 4, 291, DateTimeKind.Local).AddTicks(8902), new DateTime(2020, 9, 8, 4, 16, 28, 254, DateTimeKind.Local).AddTicks(536), "", "", "Conseil consultatif de la famille et de l'enfance", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 35, "", null, "", new DateTime(2020, 3, 4, 3, 11, 22, 711, DateTimeKind.Local).AddTicks(2806), new DateTime(2020, 8, 7, 18, 26, 54, 194, DateTimeKind.Local).AddTicks(8884), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 34, "", null, "", new DateTime(2020, 3, 3, 16, 49, 5, 789, DateTimeKind.Local).AddTicks(3371), new DateTime(2020, 7, 11, 11, 34, 9, 769, DateTimeKind.Local).AddTicks(296), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 33, "", null, "", new DateTime(2020, 8, 18, 8, 31, 25, 98, DateTimeKind.Local).AddTicks(4207), new DateTime(2021, 1, 1, 9, 20, 38, 284, DateTimeKind.Local).AddTicks(1746), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 32, "", null, "", new DateTime(2020, 8, 20, 17, 19, 18, 993, DateTimeKind.Local).AddTicks(4201), new DateTime(2020, 5, 10, 9, 45, 51, 877, DateTimeKind.Local).AddTicks(98), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 31, "", null, "", new DateTime(2020, 4, 23, 2, 12, 25, 939, DateTimeKind.Local).AddTicks(653), new DateTime(2020, 10, 28, 18, 48, 28, 757, DateTimeKind.Local).AddTicks(4032), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 30, "", null, "", new DateTime(2021, 1, 1, 9, 29, 43, 283, DateTimeKind.Local).AddTicks(2639), new DateTime(2020, 11, 7, 23, 19, 35, 8, DateTimeKind.Local).AddTicks(1855), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 29, "", null, "", new DateTime(2020, 8, 16, 2, 6, 26, 821, DateTimeKind.Local).AddTicks(8375), new DateTime(2020, 11, 28, 12, 14, 17, 740, DateTimeKind.Local).AddTicks(1884), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "تعزيز الحماية القانونية لضحايا النزاعات المسلحة", "", null, "" },
                    { 28, "", null, "", new DateTime(2020, 12, 8, 3, 44, 24, 508, DateTimeKind.Local).AddTicks(9677), new DateTime(2020, 10, 7, 23, 58, 27, 152, DateTimeKind.Local).AddTicks(7250), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "مكافحة جميع أشكال التمييز", "", null, "" },
                    { 27, "", null, "", new DateTime(2020, 7, 1, 11, 57, 51, 655, DateTimeKind.Local).AddTicks(2487), new DateTime(2021, 2, 13, 22, 36, 12, 431, DateTimeKind.Local).AddTicks(2673), "", "", "Conseil consultatif de la famille et de l'enfance", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 26, "", null, "", new DateTime(2020, 4, 21, 20, 55, 0, 828, DateTimeKind.Local).AddTicks(6288), new DateTime(2020, 5, 28, 20, 11, 39, 505, DateTimeKind.Local).AddTicks(8236), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "المجلس الاستشاري للأسرة والطفل", "", null, "" },
                    { 36, "", null, "", new DateTime(2020, 8, 1, 10, 38, 10, 379, DateTimeKind.Local).AddTicks(5278), new DateTime(2020, 8, 5, 14, 54, 26, 954, DateTimeKind.Local).AddTicks(7521), "", "", "Conseil consultatif de la famille et de l'enfance", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" },
                    { 100, "", null, "", new DateTime(2020, 9, 19, 4, 36, 44, 135, DateTimeKind.Local).AddTicks(6037), new DateTime(2020, 6, 5, 22, 16, 14, 770, DateTimeKind.Local).AddTicks(3445), "", "", "La lutte contre toutes les formes de discrimination", "مكافحة الاضطرابات النفسية وحماية حقوق الأشخاص الذين يعانون من هذه الاضطرابات", "", null, "" }
                });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[,]
                {
                    { 44, new DateTime(2021, 2, 26, 1, 29, 53, 194, DateTimeKind.Local).AddTicks(9895), new DateTime(2021, 2, 26, 8, 15, 20, 860, DateTimeKind.Local).AddTicks(8342), new DateTime(2021, 2, 26, 12, 37, 41, 977, DateTimeKind.Local).AddTicks(6741), 43, "", "https://thibert.eu", "possimus" },
                    { 31, new DateTime(2021, 2, 26, 12, 26, 49, 214, DateTimeKind.Local).AddTicks(3451), new DateTime(2021, 2, 26, 5, 5, 44, 676, DateTimeKind.Local).AddTicks(7679), new DateTime(2021, 2, 26, 21, 31, 22, 344, DateTimeKind.Local).AddTicks(6844), 71, "", "https://éloïse.org", "doloribus" },
                    { 68, new DateTime(2021, 2, 26, 6, 52, 53, 882, DateTimeKind.Local).AddTicks(9048), new DateTime(2021, 2, 26, 16, 40, 36, 494, DateTimeKind.Local).AddTicks(1903), new DateTime(2021, 2, 26, 20, 29, 33, 859, DateTimeKind.Local).AddTicks(4356), 67, "", "https://delphin.eu", "blanditiis" },
                    { 45, new DateTime(2021, 2, 26, 8, 16, 55, 57, DateTimeKind.Local).AddTicks(1086), new DateTime(2021, 2, 26, 8, 47, 58, 200, DateTimeKind.Local).AddTicks(3336), new DateTime(2021, 2, 26, 2, 49, 4, 123, DateTimeKind.Local).AddTicks(7646), 66, "", "https://thaïs.com", "fugiat" },
                    { 3, new DateTime(2021, 2, 26, 0, 49, 16, 694, DateTimeKind.Local).AddTicks(1072), new DateTime(2021, 2, 26, 15, 54, 6, 389, DateTimeKind.Local).AddTicks(4438), new DateTime(2021, 2, 25, 22, 19, 42, 563, DateTimeKind.Local).AddTicks(3397), 66, "", "https://alice.com", "amet" },
                    { 80, new DateTime(2021, 2, 26, 8, 47, 46, 721, DateTimeKind.Local).AddTicks(9774), new DateTime(2021, 2, 26, 2, 43, 27, 986, DateTimeKind.Local).AddTicks(146), new DateTime(2021, 2, 26, 16, 8, 27, 491, DateTimeKind.Local).AddTicks(5499), 65, "", "http://claudien.eu", "temporibus" },
                    { 86, new DateTime(2021, 2, 26, 0, 31, 12, 556, DateTimeKind.Local).AddTicks(9811), new DateTime(2021, 2, 26, 18, 21, 43, 353, DateTimeKind.Local).AddTicks(8629), new DateTime(2021, 2, 26, 2, 22, 30, 144, DateTimeKind.Local).AddTicks(4633), 63, "", "https://vivien.eu", "laborum" },
                    { 76, new DateTime(2021, 2, 26, 0, 20, 4, 1, DateTimeKind.Local).AddTicks(8416), new DateTime(2021, 2, 26, 15, 40, 59, 61, DateTimeKind.Local).AddTicks(9685), new DateTime(2021, 2, 26, 8, 48, 34, 931, DateTimeKind.Local).AddTicks(4757), 63, "", "http://emma.net", "expedita" },
                    { 66, new DateTime(2021, 2, 26, 5, 9, 36, 201, DateTimeKind.Local).AddTicks(2411), new DateTime(2021, 2, 26, 6, 0, 15, 697, DateTimeKind.Local).AddTicks(6918), new DateTime(2021, 2, 26, 11, 52, 55, 166, DateTimeKind.Local).AddTicks(1145), 63, "", "https://marius.name", "iusto" },
                    { 65, new DateTime(2021, 2, 26, 9, 53, 34, 607, DateTimeKind.Local).AddTicks(9618), new DateTime(2021, 2, 26, 10, 49, 24, 938, DateTimeKind.Local).AddTicks(8964), new DateTime(2021, 2, 26, 12, 26, 14, 956, DateTimeKind.Local).AddTicks(9533), 63, "", "http://timothée.eu", "exercitationem" },
                    { 82, new DateTime(2021, 2, 26, 7, 42, 36, 798, DateTimeKind.Local).AddTicks(2314), new DateTime(2021, 2, 26, 20, 53, 19, 153, DateTimeKind.Local).AddTicks(8392), new DateTime(2021, 2, 26, 4, 18, 11, 688, DateTimeKind.Local).AddTicks(4508), 61, "", "http://agathange.fr", "at" },
                    { 56, new DateTime(2021, 2, 26, 4, 41, 48, 377, DateTimeKind.Local).AddTicks(3708), new DateTime(2021, 2, 26, 7, 45, 22, 115, DateTimeKind.Local).AddTicks(2636), new DateTime(2021, 2, 26, 20, 46, 55, 480, DateTimeKind.Local).AddTicks(3264), 71, "", "http://johan.eu", "perferendis" },
                    { 38, new DateTime(2021, 2, 26, 17, 31, 46, 127, DateTimeKind.Local).AddTicks(1728), new DateTime(2021, 2, 26, 11, 49, 37, 877, DateTimeKind.Local).AddTicks(537), new DateTime(2021, 2, 26, 19, 49, 16, 512, DateTimeKind.Local).AddTicks(5218), 60, "", "http://auxane.name", "voluptatem" },
                    { 62, new DateTime(2021, 2, 26, 1, 25, 47, 531, DateTimeKind.Local).AddTicks(3468), new DateTime(2021, 2, 26, 3, 34, 9, 589, DateTimeKind.Local).AddTicks(3936), new DateTime(2021, 2, 26, 18, 37, 27, 528, DateTimeKind.Local).AddTicks(4784), 56, "", "https://corentin.eu", "autem" },
                    { 26, new DateTime(2021, 2, 26, 14, 6, 3, 698, DateTimeKind.Local).AddTicks(3816), new DateTime(2021, 2, 26, 0, 3, 31, 137, DateTimeKind.Local).AddTicks(9175), new DateTime(2021, 2, 26, 19, 50, 48, 170, DateTimeKind.Local).AddTicks(7894), 56, "", "https://didier.com", "autem" },
                    { 23, new DateTime(2021, 2, 26, 6, 22, 5, 653, DateTimeKind.Local).AddTicks(8965), new DateTime(2021, 2, 26, 12, 26, 56, 134, DateTimeKind.Local).AddTicks(5284), new DateTime(2021, 2, 25, 23, 7, 7, 549, DateTimeKind.Local).AddTicks(7378), 55, "", "https://célien.fr", "autem" },
                    { 98, new DateTime(2021, 2, 26, 15, 46, 45, 81, DateTimeKind.Local).AddTicks(3936), new DateTime(2021, 2, 26, 4, 26, 45, 991, DateTimeKind.Local).AddTicks(1447), new DateTime(2021, 2, 26, 3, 37, 57, 858, DateTimeKind.Local).AddTicks(8469), 54, "", "https://aquilin.com", "quas" },
                    { 84, new DateTime(2021, 2, 25, 23, 30, 13, 868, DateTimeKind.Local).AddTicks(9496), new DateTime(2021, 2, 26, 20, 33, 12, 936, DateTimeKind.Local).AddTicks(86), new DateTime(2021, 2, 26, 2, 50, 57, 268, DateTimeKind.Local).AddTicks(4885), 54, "", "http://marc.eu", "deserunt" },
                    { 96, new DateTime(2021, 2, 26, 21, 24, 39, 545, DateTimeKind.Local).AddTicks(5948), new DateTime(2021, 2, 25, 23, 31, 8, 348, DateTimeKind.Local).AddTicks(4119), new DateTime(2021, 2, 26, 0, 12, 45, 973, DateTimeKind.Local).AddTicks(5708), 47, "", "https://élise.fr", "at" },
                    { 89, new DateTime(2021, 2, 26, 17, 23, 34, 391, DateTimeKind.Local).AddTicks(3065), new DateTime(2021, 2, 26, 6, 29, 40, 528, DateTimeKind.Local).AddTicks(141), new DateTime(2021, 2, 26, 12, 5, 8, 448, DateTimeKind.Local).AddTicks(7827), 46, "", "http://adalbert.net", "sapiente" },
                    { 97, new DateTime(2021, 2, 26, 12, 21, 9, 515, DateTimeKind.Local).AddTicks(2606), new DateTime(2021, 2, 26, 2, 45, 19, 286, DateTimeKind.Local).AddTicks(6748), new DateTime(2021, 2, 26, 3, 49, 11, 138, DateTimeKind.Local).AddTicks(2728), 45, "", "http://waleran.com", "veniam" },
                    { 11, new DateTime(2021, 2, 26, 0, 46, 17, 209, DateTimeKind.Local).AddTicks(5859), new DateTime(2021, 2, 26, 17, 20, 13, 215, DateTimeKind.Local).AddTicks(8177), new DateTime(2021, 2, 26, 21, 38, 53, 227, DateTimeKind.Local).AddTicks(6006), 45, "", "http://libère.name", "delectus" },
                    { 70, new DateTime(2021, 2, 26, 21, 12, 9, 905, DateTimeKind.Local).AddTicks(6891), new DateTime(2021, 2, 26, 9, 38, 40, 469, DateTimeKind.Local).AddTicks(2418), new DateTime(2021, 2, 26, 9, 59, 25, 886, DateTimeKind.Local).AddTicks(8690), 44, "", "https://clotaire.eu", "sit" },
                    { 85, new DateTime(2021, 2, 26, 6, 40, 42, 199, DateTimeKind.Local).AddTicks(9646), new DateTime(2021, 2, 25, 23, 43, 50, 137, DateTimeKind.Local).AddTicks(3503), new DateTime(2021, 2, 26, 20, 36, 15, 280, DateTimeKind.Local).AddTicks(662), 58, "", "https://raphaëlle.net", "placeat" },
                    { 22, new DateTime(2021, 2, 26, 7, 44, 40, 43, DateTimeKind.Local).AddTicks(6776), new DateTime(2021, 2, 26, 0, 34, 36, 41, DateTimeKind.Local).AddTicks(2426), new DateTime(2021, 2, 26, 12, 28, 33, 238, DateTimeKind.Local).AddTicks(5236), 44, "", "https://armand.info", "iure" },
                    { 60, new DateTime(2021, 2, 26, 19, 22, 19, 73, DateTimeKind.Local).AddTicks(7983), new DateTime(2021, 2, 26, 18, 42, 33, 694, DateTimeKind.Local).AddTicks(7024), new DateTime(2021, 2, 26, 12, 52, 7, 570, DateTimeKind.Local).AddTicks(9205), 72, "", "http://paulette.fr", "alias" },
                    { 51, new DateTime(2021, 2, 26, 15, 38, 3, 647, DateTimeKind.Local).AddTicks(354), new DateTime(2021, 2, 26, 13, 51, 47, 522, DateTimeKind.Local).AddTicks(2531), new DateTime(2021, 2, 26, 4, 43, 49, 828, DateTimeKind.Local).AddTicks(5510), 75, "", "http://ernestine.info", "ea" },
                    { 39, new DateTime(2021, 2, 26, 14, 18, 52, 520, DateTimeKind.Local).AddTicks(8271), new DateTime(2021, 2, 26, 12, 4, 14, 140, DateTimeKind.Local).AddTicks(187), new DateTime(2021, 2, 26, 5, 16, 11, 175, DateTimeKind.Local).AddTicks(7216), 98, "", "https://agneflète.net", "suscipit" },
                    { 69, new DateTime(2021, 2, 26, 3, 42, 47, 310, DateTimeKind.Local).AddTicks(8169), new DateTime(2021, 2, 26, 7, 46, 38, 974, DateTimeKind.Local).AddTicks(7324), new DateTime(2021, 2, 25, 23, 25, 32, 86, DateTimeKind.Local).AddTicks(1436), 97, "", "http://laure.fr", "consequuntur" },
                    { 99, new DateTime(2021, 2, 26, 8, 56, 43, 94, DateTimeKind.Local).AddTicks(8939), new DateTime(2021, 2, 26, 6, 22, 27, 69, DateTimeKind.Local).AddTicks(8591), new DateTime(2021, 2, 26, 15, 2, 58, 555, DateTimeKind.Local).AddTicks(3511), 96, "", "http://janine.fr", "amet" },
                    { 1, new DateTime(2021, 2, 25, 22, 22, 40, 449, DateTimeKind.Local).AddTicks(1343), new DateTime(2021, 2, 26, 13, 42, 10, 936, DateTimeKind.Local).AddTicks(8216), new DateTime(2021, 2, 26, 20, 26, 34, 266, DateTimeKind.Local).AddTicks(9175), 96, "", "http://mérovée.info", "delectus" },
                    { 33, new DateTime(2021, 2, 26, 16, 15, 23, 696, DateTimeKind.Local).AddTicks(4005), new DateTime(2021, 2, 26, 4, 12, 55, 227, DateTimeKind.Local).AddTicks(3813), new DateTime(2021, 2, 26, 11, 25, 28, 964, DateTimeKind.Local).AddTicks(8331), 94, "", "https://alcime.com", "suscipit" },
                    { 94, new DateTime(2021, 2, 26, 8, 25, 37, 367, DateTimeKind.Local).AddTicks(8748), new DateTime(2021, 2, 26, 0, 40, 40, 279, DateTimeKind.Local).AddTicks(9904), new DateTime(2021, 2, 26, 6, 54, 20, 278, DateTimeKind.Local).AddTicks(8528), 93, "", "http://noé.org", "modi" },
                    { 59, new DateTime(2021, 2, 26, 13, 22, 39, 983, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 2, 26, 21, 29, 43, 799, DateTimeKind.Local).AddTicks(2205), new DateTime(2021, 2, 26, 3, 37, 27, 504, DateTimeKind.Local).AddTicks(7427), 93, "", "http://lucas.eu", "unde" },
                    { 21, new DateTime(2021, 2, 26, 5, 1, 46, 183, DateTimeKind.Local).AddTicks(9478), new DateTime(2021, 2, 26, 11, 15, 5, 469, DateTimeKind.Local).AddTicks(220), new DateTime(2021, 2, 26, 10, 38, 21, 628, DateTimeKind.Local).AddTicks(6719), 93, "", "http://angélina.info", "modi" },
                    { 55, new DateTime(2021, 2, 26, 8, 11, 25, 762, DateTimeKind.Local).AddTicks(988), new DateTime(2021, 2, 26, 9, 37, 4, 489, DateTimeKind.Local).AddTicks(2080), new DateTime(2021, 2, 26, 19, 56, 29, 159, DateTimeKind.Local).AddTicks(9822), 91, "", "http://fortunée.com", "mollitia" },
                    { 87, new DateTime(2021, 2, 25, 22, 33, 4, 70, DateTimeKind.Local).AddTicks(7878), new DateTime(2021, 2, 26, 12, 33, 40, 373, DateTimeKind.Local).AddTicks(9879), new DateTime(2021, 2, 26, 13, 3, 23, 905, DateTimeKind.Local).AddTicks(8964), 90, "", "http://florent,.eu", "magnam" },
                    { 6, new DateTime(2021, 2, 26, 0, 18, 20, 927, DateTimeKind.Local).AddTicks(6041), new DateTime(2021, 2, 26, 14, 6, 10, 34, DateTimeKind.Local).AddTicks(399), new DateTime(2021, 2, 26, 5, 39, 11, 865, DateTimeKind.Local).AddTicks(791), 74, "", "https://tancrède.org", "magni" },
                    { 90, new DateTime(2021, 2, 26, 0, 37, 54, 128, DateTimeKind.Local).AddTicks(7506), new DateTime(2021, 2, 26, 8, 23, 32, 577, DateTimeKind.Local).AddTicks(9489), new DateTime(2021, 2, 26, 14, 31, 41, 65, DateTimeKind.Local).AddTicks(2718), 89, "", "https://yolande.org", "non" },
                    { 30, new DateTime(2021, 2, 26, 13, 9, 5, 786, DateTimeKind.Local).AddTicks(7024), new DateTime(2021, 2, 26, 5, 38, 12, 126, DateTimeKind.Local).AddTicks(3498), new DateTime(2021, 2, 26, 14, 6, 18, 354, DateTimeKind.Local).AddTicks(2867), 85, "", "http://bérangère.net", "sit" },
                    { 19, new DateTime(2021, 2, 26, 17, 47, 13, 487, DateTimeKind.Local).AddTicks(6140), new DateTime(2021, 2, 26, 12, 2, 50, 399, DateTimeKind.Local).AddTicks(4815), new DateTime(2021, 2, 26, 18, 33, 52, 994, DateTimeKind.Local).AddTicks(2985), 84, "", "http://apolline.name", "quas" },
                    { 15, new DateTime(2021, 2, 26, 18, 17, 51, 692, DateTimeKind.Local).AddTicks(697), new DateTime(2021, 2, 26, 10, 45, 13, 510, DateTimeKind.Local).AddTicks(1757), new DateTime(2021, 2, 26, 3, 1, 28, 807, DateTimeKind.Local).AddTicks(2135), 81, "", "https://germaine.net", "adipisci" }
                });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[,]
                {
                    { 91, new DateTime(2021, 2, 26, 3, 3, 59, 190, DateTimeKind.Local).AddTicks(9333), new DateTime(2021, 2, 26, 9, 8, 55, 709, DateTimeKind.Local).AddTicks(300), new DateTime(2021, 2, 26, 16, 23, 45, 305, DateTimeKind.Local).AddTicks(1696), 80, "", "http://honorine.fr", "et" },
                    { 50, new DateTime(2021, 2, 26, 15, 20, 16, 920, DateTimeKind.Local).AddTicks(1269), new DateTime(2021, 2, 26, 19, 36, 50, 870, DateTimeKind.Local).AddTicks(9159), new DateTime(2021, 2, 26, 2, 49, 10, 829, DateTimeKind.Local).AddTicks(8868), 80, "", "http://adeline.eu", "dolore" },
                    { 34, new DateTime(2021, 2, 26, 20, 30, 43, 615, DateTimeKind.Local).AddTicks(7705), new DateTime(2021, 2, 26, 19, 51, 26, 187, DateTimeKind.Local).AddTicks(762), new DateTime(2021, 2, 26, 5, 2, 22, 738, DateTimeKind.Local).AddTicks(2282), 80, "", "https://hippolyte.net", "aut" },
                    { 54, new DateTime(2021, 2, 26, 11, 38, 54, 671, DateTimeKind.Local).AddTicks(8439), new DateTime(2021, 2, 26, 5, 13, 56, 677, DateTimeKind.Local).AddTicks(9072), new DateTime(2021, 2, 26, 3, 53, 12, 992, DateTimeKind.Local).AddTicks(9325), 79, "", "http://hector.net", "quasi" },
                    { 2, new DateTime(2021, 2, 26, 0, 3, 0, 411, DateTimeKind.Local).AddTicks(1443), new DateTime(2021, 2, 26, 12, 28, 58, 439, DateTimeKind.Local).AddTicks(3700), new DateTime(2021, 2, 26, 12, 49, 16, 592, DateTimeKind.Local).AddTicks(4502), 79, "", "http://léonne.name", "fuga" },
                    { 47, new DateTime(2021, 2, 26, 3, 41, 0, 224, DateTimeKind.Local).AddTicks(718), new DateTime(2021, 2, 26, 7, 25, 19, 563, DateTimeKind.Local).AddTicks(4262), new DateTime(2021, 2, 26, 4, 43, 32, 774, DateTimeKind.Local).AddTicks(4308), 77, "", "https://régis.com", "tempora" },
                    { 27, new DateTime(2021, 2, 26, 8, 57, 5, 834, DateTimeKind.Local).AddTicks(3735), new DateTime(2021, 2, 26, 15, 51, 24, 110, DateTimeKind.Local).AddTicks(2149), new DateTime(2021, 2, 25, 23, 15, 10, 658, DateTimeKind.Local).AddTicks(5420), 76, "", "https://edmond.info", "repudiandae" },
                    { 71, new DateTime(2021, 2, 26, 7, 42, 17, 620, DateTimeKind.Local).AddTicks(8976), new DateTime(2021, 2, 26, 8, 7, 11, 86, DateTimeKind.Local).AddTicks(1035), new DateTime(2021, 2, 25, 23, 53, 51, 863, DateTimeKind.Local).AddTicks(1336), 86, "", "https://agnan.name", "quam" },
                    { 73, new DateTime(2021, 2, 26, 17, 12, 6, 854, DateTimeKind.Local).AddTicks(5891), new DateTime(2021, 2, 26, 7, 35, 7, 966, DateTimeKind.Local).AddTicks(9107), new DateTime(2021, 2, 26, 5, 54, 7, 116, DateTimeKind.Local).AddTicks(9825), 43, "", "https://marceau.eu", "aperiam" },
                    { 49, new DateTime(2021, 2, 26, 3, 25, 41, 78, DateTimeKind.Local).AddTicks(6338), new DateTime(2021, 2, 26, 4, 46, 2, 789, DateTimeKind.Local).AddTicks(4378), new DateTime(2021, 2, 26, 4, 18, 5, 38, DateTimeKind.Local).AddTicks(8113), 99, "", "http://maximilien.name", "cupiditate" },
                    { 37, new DateTime(2021, 2, 26, 6, 10, 14, 683, DateTimeKind.Local).AddTicks(9295), new DateTime(2021, 2, 26, 13, 53, 21, 997, DateTimeKind.Local).AddTicks(4759), new DateTime(2021, 2, 26, 2, 39, 14, 588, DateTimeKind.Local).AddTicks(7635), 41, "", "https://acacie.fr", "ea" },
                    { 63, new DateTime(2021, 2, 25, 22, 44, 6, 108, DateTimeKind.Local).AddTicks(7714), new DateTime(2021, 2, 26, 9, 51, 8, 766, DateTimeKind.Local).AddTicks(9421), new DateTime(2021, 2, 26, 12, 22, 12, 194, DateTimeKind.Local).AddTicks(1090), 14, "", "https://perceval.net", "veniam" },
                    { 57, new DateTime(2021, 2, 26, 8, 4, 18, 841, DateTimeKind.Local).AddTicks(5508), new DateTime(2021, 2, 26, 12, 23, 27, 779, DateTimeKind.Local).AddTicks(3487), new DateTime(2021, 2, 26, 12, 8, 50, 744, DateTimeKind.Local).AddTicks(6772), 14, "", "https://philothée.fr", "soluta" },
                    { 53, new DateTime(2021, 2, 26, 19, 6, 39, 254, DateTimeKind.Local).AddTicks(792), new DateTime(2021, 2, 26, 3, 59, 0, 310, DateTimeKind.Local).AddTicks(7785), new DateTime(2021, 2, 26, 1, 29, 57, 58, DateTimeKind.Local).AddTicks(9415), 14, "", "http://réjean.info", "hic" },
                    { 83, new DateTime(2021, 2, 26, 20, 13, 33, 209, DateTimeKind.Local).AddTicks(1088), new DateTime(2021, 2, 26, 2, 49, 53, 915, DateTimeKind.Local).AddTicks(1760), new DateTime(2021, 2, 26, 2, 32, 51, 532, DateTimeKind.Local).AddTicks(2282), 13, "", "http://oury.net", "perferendis" },
                    { 24, new DateTime(2021, 2, 26, 19, 3, 32, 399, DateTimeKind.Local).AddTicks(7581), new DateTime(2021, 2, 26, 12, 4, 46, 841, DateTimeKind.Local).AddTicks(6016), new DateTime(2021, 2, 26, 16, 12, 7, 42, DateTimeKind.Local).AddTicks(4266), 13, "", "https://sigebert.info", "et" },
                    { 10, new DateTime(2021, 2, 26, 3, 4, 46, 682, DateTimeKind.Local).AddTicks(7990), new DateTime(2021, 2, 26, 19, 59, 37, 736, DateTimeKind.Local).AddTicks(1769), new DateTime(2021, 2, 26, 21, 7, 33, 926, DateTimeKind.Local).AddTicks(995), 13, "", "https://germaine.fr", "dolor" },
                    { 61, new DateTime(2021, 2, 26, 9, 38, 48, 242, DateTimeKind.Local).AddTicks(2828), new DateTime(2021, 2, 26, 4, 51, 54, 575, DateTimeKind.Local).AddTicks(1927), new DateTime(2021, 2, 26, 18, 37, 54, 762, DateTimeKind.Local).AddTicks(7662), 11, "", "https://betty.org", "suscipit" },
                    { 18, new DateTime(2021, 2, 26, 17, 6, 8, 330, DateTimeKind.Local).AddTicks(8325), new DateTime(2021, 2, 26, 21, 34, 46, 311, DateTimeKind.Local).AddTicks(9333), new DateTime(2021, 2, 26, 9, 50, 7, 130, DateTimeKind.Local).AddTicks(8986), 11, "", "http://quentin.eu", "consequatur" },
                    { 12, new DateTime(2021, 2, 26, 6, 16, 44, 889, DateTimeKind.Local).AddTicks(7424), new DateTime(2021, 2, 26, 14, 32, 49, 511, DateTimeKind.Local).AddTicks(921), new DateTime(2021, 2, 25, 23, 15, 26, 406, DateTimeKind.Local).AddTicks(831), 11, "", "https://raphaël.org", "distinctio" },
                    { 100, new DateTime(2021, 2, 26, 18, 45, 39, 847, DateTimeKind.Local).AddTicks(6442), new DateTime(2021, 2, 26, 21, 15, 40, 470, DateTimeKind.Local).AddTicks(3641), new DateTime(2021, 2, 26, 17, 51, 15, 18, DateTimeKind.Local).AddTicks(4403), 10, "", "https://célestin.name", "molestias" },
                    { 67, new DateTime(2021, 2, 26, 6, 45, 29, 644, DateTimeKind.Local).AddTicks(304), new DateTime(2021, 2, 26, 6, 19, 8, 102, DateTimeKind.Local).AddTicks(4577), new DateTime(2021, 2, 25, 22, 1, 32, 804, DateTimeKind.Local).AddTicks(3126), 8, "", "https://maguelone.org", "unde" },
                    { 25, new DateTime(2021, 2, 25, 23, 7, 52, 262, DateTimeKind.Local).AddTicks(5187), new DateTime(2021, 2, 26, 19, 32, 28, 622, DateTimeKind.Local).AddTicks(3321), new DateTime(2021, 2, 26, 2, 45, 25, 899, DateTimeKind.Local).AddTicks(9501), 8, "", "http://jacinthe.name", "ex" },
                    { 79, new DateTime(2021, 2, 26, 9, 12, 45, 583, DateTimeKind.Local).AddTicks(3671), new DateTime(2021, 2, 26, 17, 3, 15, 657, DateTimeKind.Local).AddTicks(8998), new DateTime(2021, 2, 26, 15, 50, 37, 360, DateTimeKind.Local).AddTicks(1538), 7, "", "https://agrippine.eu", "voluptatum" },
                    { 92, new DateTime(2021, 2, 26, 2, 35, 33, 247, DateTimeKind.Local).AddTicks(9874), new DateTime(2021, 2, 26, 17, 48, 10, 89, DateTimeKind.Local).AddTicks(9755), new DateTime(2021, 2, 26, 19, 13, 47, 528, DateTimeKind.Local).AddTicks(9805), 5, "", "http://aquiline.com", "eligendi" },
                    { 58, new DateTime(2021, 2, 26, 16, 23, 55, 214, DateTimeKind.Local).AddTicks(1196), new DateTime(2021, 2, 26, 5, 3, 49, 470, DateTimeKind.Local).AddTicks(5575), new DateTime(2021, 2, 26, 1, 30, 53, 277, DateTimeKind.Local).AddTicks(465), 5, "", "https://claire.net", "fuga" },
                    { 4, new DateTime(2021, 2, 26, 13, 38, 43, 561, DateTimeKind.Local).AddTicks(9284), new DateTime(2021, 2, 26, 1, 23, 17, 694, DateTimeKind.Local).AddTicks(3897), new DateTime(2021, 2, 25, 22, 8, 28, 90, DateTimeKind.Local).AddTicks(8013), 5, "", "https://simone.info", "assumenda" },
                    { 9, new DateTime(2021, 2, 26, 21, 22, 49, 777, DateTimeKind.Local).AddTicks(2519), new DateTime(2021, 2, 26, 18, 51, 23, 855, DateTimeKind.Local).AddTicks(8610), new DateTime(2021, 2, 26, 12, 46, 45, 144, DateTimeKind.Local).AddTicks(9107), 4, "", "http://euphrasie.net", "dolorum" },
                    { 13, new DateTime(2021, 2, 26, 7, 15, 42, 577, DateTimeKind.Local).AddTicks(2592), new DateTime(2021, 2, 26, 9, 10, 55, 409, DateTimeKind.Local).AddTicks(6528), new DateTime(2021, 2, 26, 2, 22, 45, 393, DateTimeKind.Local).AddTicks(2515), 3, "", "https://almine.com", "aperiam" },
                    { 93, new DateTime(2021, 2, 26, 14, 58, 42, 119, DateTimeKind.Local).AddTicks(6988), new DateTime(2021, 2, 26, 11, 30, 40, 671, DateTimeKind.Local).AddTicks(6423), new DateTime(2021, 2, 26, 14, 16, 29, 919, DateTimeKind.Local).AddTicks(8346), 2, "", "http://armance.com", "laboriosam" },
                    { 75, new DateTime(2021, 2, 26, 2, 44, 4, 339, DateTimeKind.Local).AddTicks(6064), new DateTime(2021, 2, 26, 7, 8, 53, 657, DateTimeKind.Local).AddTicks(4131), new DateTime(2021, 2, 26, 18, 25, 38, 722, DateTimeKind.Local).AddTicks(4027), 1, "", "http://ansberte.fr", "quia" },
                    { 36, new DateTime(2021, 2, 26, 3, 8, 41, 835, DateTimeKind.Local).AddTicks(974), new DateTime(2021, 2, 26, 9, 0, 36, 44, DateTimeKind.Local).AddTicks(8641), new DateTime(2021, 2, 26, 21, 36, 57, 897, DateTimeKind.Local).AddTicks(7062), 1, "", "https://bon.org", "a" },
                    { 77, new DateTime(2021, 2, 26, 4, 20, 45, 318, DateTimeKind.Local).AddTicks(509), new DateTime(2021, 2, 26, 21, 27, 44, 702, DateTimeKind.Local).AddTicks(8637), new DateTime(2021, 2, 26, 10, 34, 15, 160, DateTimeKind.Local).AddTicks(6222), 98, "", "https://gontran.name", "sit" },
                    { 32, new DateTime(2021, 2, 26, 6, 57, 33, 757, DateTimeKind.Local).AddTicks(4236), new DateTime(2021, 2, 26, 7, 43, 31, 751, DateTimeKind.Local).AddTicks(3978), new DateTime(2021, 2, 26, 12, 20, 7, 311, DateTimeKind.Local).AddTicks(6825), 18, "", "https://jeannot.com", "eum" },
                    { 78, new DateTime(2021, 2, 26, 11, 55, 14, 709, DateTimeKind.Local).AddTicks(7673), new DateTime(2021, 2, 26, 5, 26, 6, 289, DateTimeKind.Local).AddTicks(2667), new DateTime(2021, 2, 26, 5, 34, 13, 417, DateTimeKind.Local).AddTicks(3836), 15, "", "http://fulbert.net", "esse" },
                    { 29, new DateTime(2021, 2, 25, 23, 4, 56, 489, DateTimeKind.Local).AddTicks(9640), new DateTime(2021, 2, 26, 4, 37, 19, 419, DateTimeKind.Local).AddTicks(7424), new DateTime(2021, 2, 26, 17, 23, 52, 469, DateTimeKind.Local).AddTicks(6720), 20, "", "https://barnabé.eu", "corrupti" },
                    { 8, new DateTime(2021, 2, 26, 13, 29, 52, 4, DateTimeKind.Local).AddTicks(9844), new DateTime(2021, 2, 25, 23, 1, 53, 181, DateTimeKind.Local).AddTicks(2633), new DateTime(2021, 2, 26, 10, 48, 28, 598, DateTimeKind.Local).AddTicks(3614), 41, "", "https://axelle.info", "ad" },
                    { 81, new DateTime(2021, 2, 26, 15, 38, 25, 837, DateTimeKind.Local).AddTicks(5145), new DateTime(2021, 2, 26, 3, 17, 39, 784, DateTimeKind.Local).AddTicks(9090), new DateTime(2021, 2, 26, 21, 11, 54, 718, DateTimeKind.Local).AddTicks(926), 40, "", "https://gabriel.fr", "odit" },
                    { 40, new DateTime(2021, 2, 26, 18, 41, 17, 58, DateTimeKind.Local).AddTicks(1315), new DateTime(2021, 2, 26, 20, 27, 53, 9, DateTimeKind.Local).AddTicks(4821), new DateTime(2021, 2, 26, 11, 16, 14, 96, DateTimeKind.Local).AddTicks(2998), 39, "", "https://douce.fr", "recusandae" },
                    { 74, new DateTime(2021, 2, 26, 17, 48, 5, 142, DateTimeKind.Local).AddTicks(5860), new DateTime(2021, 2, 26, 20, 29, 10, 242, DateTimeKind.Local).AddTicks(2894), new DateTime(2021, 2, 26, 6, 33, 37, 11, DateTimeKind.Local).AddTicks(9589), 37, "", "http://almine.org", "eveniet" },
                    { 64, new DateTime(2021, 2, 26, 0, 38, 37, 602, DateTimeKind.Local).AddTicks(3867), new DateTime(2021, 2, 25, 23, 8, 0, 370, DateTimeKind.Local).AddTicks(380), new DateTime(2021, 2, 26, 21, 3, 9, 150, DateTimeKind.Local).AddTicks(3982), 37, "", "https://isabelle.info", "veniam" },
                    { 43, new DateTime(2021, 2, 26, 20, 22, 12, 852, DateTimeKind.Local).AddTicks(9815), new DateTime(2021, 2, 26, 6, 39, 13, 716, DateTimeKind.Local).AddTicks(8110), new DateTime(2021, 2, 26, 15, 29, 0, 939, DateTimeKind.Local).AddTicks(5425), 37, "", "http://angoustan.eu", "quis" }
                });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[,]
                {
                    { 14, new DateTime(2021, 2, 26, 12, 20, 15, 497, DateTimeKind.Local).AddTicks(9540), new DateTime(2021, 2, 26, 10, 25, 27, 954, DateTimeKind.Local).AddTicks(9035), new DateTime(2021, 2, 25, 23, 48, 56, 799, DateTimeKind.Local).AddTicks(7356), 37, "", "https://daniel.eu", "autem" },
                    { 95, new DateTime(2021, 2, 26, 20, 54, 31, 363, DateTimeKind.Local).AddTicks(5242), new DateTime(2021, 2, 25, 22, 20, 15, 392, DateTimeKind.Local).AddTicks(2742), new DateTime(2021, 2, 26, 13, 53, 39, 835, DateTimeKind.Local).AddTicks(6632), 36, "", "http://aldegonde.info", "deserunt" },
                    { 35, new DateTime(2021, 2, 26, 8, 34, 21, 184, DateTimeKind.Local).AddTicks(1183), new DateTime(2021, 2, 26, 6, 10, 41, 135, DateTimeKind.Local).AddTicks(3968), new DateTime(2021, 2, 26, 8, 43, 17, 570, DateTimeKind.Local).AddTicks(8703), 18, "", "https://irène.org", "dolores" },
                    { 16, new DateTime(2021, 2, 26, 3, 0, 6, 546, DateTimeKind.Local).AddTicks(9110), new DateTime(2021, 2, 26, 0, 34, 40, 500, DateTimeKind.Local).AddTicks(1726), new DateTime(2021, 2, 26, 19, 10, 43, 147, DateTimeKind.Local).AddTicks(4561), 31, "", "http://émérance.org", "est" },
                    { 52, new DateTime(2021, 2, 25, 23, 48, 24, 584, DateTimeKind.Local).AddTicks(4753), new DateTime(2021, 2, 26, 15, 49, 15, 252, DateTimeKind.Local).AddTicks(7722), new DateTime(2021, 2, 25, 23, 30, 43, 876, DateTimeKind.Local).AddTicks(7310), 32, "", "http://adeline.com", "consequatur" },
                    { 17, new DateTime(2021, 2, 26, 8, 23, 52, 950, DateTimeKind.Local).AddTicks(7884), new DateTime(2021, 2, 26, 0, 5, 46, 973, DateTimeKind.Local).AddTicks(6306), new DateTime(2021, 2, 26, 8, 18, 24, 242, DateTimeKind.Local).AddTicks(4938), 30, "", "https://quentin.fr", "beatae" },
                    { 88, new DateTime(2021, 2, 26, 21, 52, 29, 2, DateTimeKind.Local).AddTicks(1246), new DateTime(2021, 2, 26, 18, 54, 32, 848, DateTimeKind.Local).AddTicks(8033), new DateTime(2021, 2, 26, 2, 54, 4, 641, DateTimeKind.Local).AddTicks(9025), 28, "", "http://chantal.com", "nemo" },
                    { 42, new DateTime(2021, 2, 25, 22, 40, 52, 955, DateTimeKind.Local).AddTicks(9109), new DateTime(2021, 2, 26, 12, 46, 45, 424, DateTimeKind.Local).AddTicks(2440), new DateTime(2021, 2, 26, 1, 0, 12, 665, DateTimeKind.Local).AddTicks(8731), 28, "", "https://antigone.name", "eum" },
                    { 28, new DateTime(2021, 2, 26, 16, 12, 59, 780, DateTimeKind.Local).AddTicks(6006), new DateTime(2021, 2, 26, 4, 50, 8, 833, DateTimeKind.Local).AddTicks(9915), new DateTime(2021, 2, 26, 16, 4, 34, 370, DateTimeKind.Local).AddTicks(3877), 27, "", "http://ansbert.name", "sint" },
                    { 46, new DateTime(2021, 2, 25, 22, 46, 56, 218, DateTimeKind.Local).AddTicks(4937), new DateTime(2021, 2, 26, 12, 8, 16, 558, DateTimeKind.Local).AddTicks(7323), new DateTime(2021, 2, 26, 13, 34, 39, 340, DateTimeKind.Local).AddTicks(6819), 25, "", "https://job.net", "aspernatur" },
                    { 5, new DateTime(2021, 2, 25, 22, 32, 33, 883, DateTimeKind.Local).AddTicks(5274), new DateTime(2021, 2, 26, 4, 16, 30, 587, DateTimeKind.Local).AddTicks(5354), new DateTime(2021, 2, 26, 1, 22, 22, 23, DateTimeKind.Local).AddTicks(821), 25, "", "http://vigile.org", "quasi" },
                    { 72, new DateTime(2021, 2, 26, 14, 10, 1, 367, DateTimeKind.Local).AddTicks(9136), new DateTime(2021, 2, 26, 13, 17, 21, 883, DateTimeKind.Local).AddTicks(987), new DateTime(2021, 2, 26, 2, 56, 54, 170, DateTimeKind.Local).AddTicks(4626), 23, "", "http://morgan.org", "iste" },
                    { 41, new DateTime(2021, 2, 26, 16, 16, 7, 804, DateTimeKind.Local).AddTicks(4259), new DateTime(2021, 2, 25, 22, 56, 30, 227, DateTimeKind.Local).AddTicks(9107), new DateTime(2021, 2, 26, 5, 40, 18, 762, DateTimeKind.Local).AddTicks(861), 23, "", "http://émérencie.org", "delectus" },
                    { 7, new DateTime(2021, 2, 26, 9, 56, 8, 978, DateTimeKind.Local).AddTicks(2480), new DateTime(2021, 2, 26, 6, 41, 22, 603, DateTimeKind.Local).AddTicks(66), new DateTime(2021, 2, 26, 19, 15, 54, 596, DateTimeKind.Local).AddTicks(141), 22, "", "https://simon.org", "dolor" },
                    { 20, new DateTime(2021, 2, 26, 10, 29, 13, 724, DateTimeKind.Local).AddTicks(134), new DateTime(2021, 2, 26, 4, 54, 8, 28, DateTimeKind.Local).AddTicks(1505), new DateTime(2021, 2, 26, 8, 29, 54, 608, DateTimeKind.Local).AddTicks(4269), 21, "", "https://armandine.fr", "ipsa" },
                    { 48, new DateTime(2021, 2, 26, 0, 16, 50, 216, DateTimeKind.Local).AddTicks(2851), new DateTime(2021, 2, 26, 12, 32, 58, 670, DateTimeKind.Local).AddTicks(6389), new DateTime(2021, 2, 26, 16, 46, 7, 468, DateTimeKind.Local).AddTicks(2054), 30, "", "http://médéric.net", "ipsum" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Actif", "Adresse", "Email", "Fix", "IdOrganisme", "IdProfil", "Nom", "Password", "Prenom", "Tel", "Username" },
                values: new object[,]
                {
                    { 3, true, "Temara", "ahmed@angular.io", "05 ## ## ## ##", 4, 4, "ahmed", "123", "ahmed", "06 ## ## ## ##", "ahmed" },
                    { 4, true, "Temara", "soufiane@angular.io", "05 ## ## ## ##", 4, 3, "soufiane", "123", "soufiane", "06 ## ## ## ##", "soufiane" },
                    { 2, true, "Temara", "mehdi@angular.io", "05 ## ## ## ##", 2, 2, "mehdi", "123", "mehdi", "06 ## ## ## ##", "mehdi" },
                    { 1, true, "Temara", "mourabit@angular.io", "05 ## ## ## ##", 1, 1, "mourabit", "123", "mohamed", "06 ## ## ## ##", "mourabit" }
                });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "DetailAr", "IdRapport", "IdUser", "LienUpload" },
                values: new object[,]
                {
                    { 95, "at", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 36, 2, null },
                    { 1, "possimus", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 27, 3, null },
                    { 49, "natus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 56, 3, null },
                    { 69, "non", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 31, 3, null },
                    { 61, "sint", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 31, 3, null },
                    { 59, "sapiente", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 31, 2, null },
                    { 45, "blanditiis", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 31, 3, null },
                    { 23, "illo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 31, 1, null },
                    { 47, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 68, 2, null },
                    { 94, "modi", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 45, 1, null },
                    { 89, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 3, 2, null },
                    { 27, "delectus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 76, 2, null },
                    { 35, "nam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 66, 2, null },
                    { 7, "voluptate", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 65, 2, null },
                    { 46, "illo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 38, 1, null },
                    { 36, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 85, 2, null },
                    { 73, "adipisci", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 98, 1, null },
                    { 65, "soluta", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 96, 1, null },
                    { 68, "voluptatem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 89, 3, null },
                    { 76, "sit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 97, 3, null },
                    { 58, "ut", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 97, 2, null },
                    { 34, "labore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 97, 3, null },
                    { 9, "eos", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 27, 1, null },
                    { 26, "et", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 97, 2, null },
                    { 44, "error", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 27, 1, null },
                    { 52, "hic", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 27, 3, null },
                    { 8, "fuga", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 39, 2, null },
                    { 22, "debitis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 69, 3, null },
                    { 78, "perspiciatis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 94, 3, null },
                    { 30, "illo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 94, 3, null },
                    { 97, "vel", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 59, 3, null },
                    { 20, "sint", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 59, 2, null },
                    { 93, "consectetur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 21, 1, null },
                    { 67, "et", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 87, 2, null },
                    { 39, "sed", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 87, 1, null },
                    { 53, "sint", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 71, 2, null },
                    { 14, "rem", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 71, 1, null },
                    { 83, "sed", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 30, 2, null },
                    { 19, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 19, 2, null },
                    { 11, "fugiat", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 19, 1, null },
                    { 79, "unde", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 15, 2, null },
                    { 55, "recusandae", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 15, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "DetailAr", "IdRapport", "IdUser", "LienUpload" },
                values: new object[,]
                {
                    { 82, "quia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 34, 3, null },
                    { 75, "dolore", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 34, 1, null },
                    { 66, "aperiam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 54, 2, null },
                    { 13, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 54, 3, null },
                    { 80, "illo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 27, 1, null },
                    { 48, "deleniti", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 27, 1, null },
                    { 98, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 11, 2, null },
                    { 84, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 11, 2, null },
                    { 43, "vel", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 70, 2, null },
                    { 12, "ab", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 63, 1, null },
                    { 88, "magni", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 53, 3, null },
                    { 71, "distinctio", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 53, 3, null },
                    { 100, "similique", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 83, 1, null },
                    { 72, "rerum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 24, 3, null },
                    { 10, "voluptas", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 24, 3, null },
                    { 33, "modi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 10, 3, null },
                    { 18, "quis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 61, 2, null },
                    { 92, "nostrum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 12, 1, null },
                    { 41, "dolore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 100, 1, null },
                    { 74, "eveniet", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 67, 2, null },
                    { 57, "dolorem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 67, 2, null },
                    { 25, "molestiae", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 25, 2, null },
                    { 90, "unde", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 79, 1, null },
                    { 51, "totam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 9, 3, null },
                    { 64, "deleniti", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 13, 2, null },
                    { 60, "eaque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 93, 2, null },
                    { 29, "temporibus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 93, 2, null },
                    { 21, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 93, 3, null },
                    { 86, "accusamus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 75, 1, null },
                    { 2, "quia", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 75, 1, null },
                    { 38, "culpa", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 63, 2, null },
                    { 91, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 78, 3, null },
                    { 16, "ex", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 32, 1, null },
                    { 17, "earum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 32, 2, null },
                    { 63, "ea", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 22, 3, null },
                    { 40, "laudantium", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 22, 1, null },
                    { 3, "cum", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 22, 3, null },
                    { 4, "odio", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 81, 2, null },
                    { 96, "voluptatem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 40, 2, null },
                    { 28, "ipsam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 64, 2, null },
                    { 99, "sit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 52, 2, null },
                    { 70, "eos", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح الجهات المؤسسية والمجتمع المدني", 52, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "DetailAr", "IdRapport", "IdUser", "LienUpload" },
                values: new object[,]
                {
                    { 62, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "مكافحة الاتجار بالبشر وتهريب المهاجرين: يوم دراسي لصالح المؤسسات والمجتمع المدني", 52, 2, null },
                    { 24, "quo", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 16, 1, null },
                    { 42, "quo", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 77, 1, null },
                    { 56, "quae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 48, 1, null },
                    { 87, "impedit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 88, 3, null },
                    { 31, "placeat", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 28, 1, null },
                    { 81, "sunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 5, 3, null },
                    { 77, "iure", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 41, 3, null },
                    { 6, "est", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 20, 1, null },
                    { 37, "magnam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 29, 3, null },
                    { 32, "eligendi", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 29, 3, null },
                    { 54, "incidunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "يوم دراسي عن الإطار المؤسسي المتعلق بمكافحة الاتجار بالبشر: نحو إنشاء اللجنة الوطنية المعنية بالاتجار بالبشر", 35, 1, null },
                    { 50, "tempore", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "استثمار أعضاء اللجنة الوطنية لمكافحة ومنع الاتجار بالبشر", 35, 3, null },
                    { 5, "veritatis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", "مكافحة الاتجار بالبشر في المغرب: ورشة العمل دون الإقليمية الثانية (مالي - المغرب - النيجر) حول تهريب المهاجرين والاتجار بالبشر", 35, 2, null },
                    { 15, "velit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 48, 2, null },
                    { 85, "ipsam", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", "الاتجار بالأشخاص وتهريب المهاجرين: يوم دراسي للجهات الفاعلة المؤسسية والمجتمع المدني", 77, 3, null }
                });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[,]
                {
                    { 34, "/optimization", 7, 95 },
                    { 73, "/mountains/practical-rubber-towels/navigating", 4, 47 },
                    { 45, "/senior/ports", 3, 47 },
                    { 43, "/tcp/auto-loan-account", 6, 47 },
                    { 36, "/connecting/lead/handmade-metal-mouse", 6, 47 },
                    { 96, "/pink/virtual", 3, 94 },
                    { 7, "/liaison", 4, 89 },
                    { 69, "/intelligent-soft-ball/ohio/small-granite-salad", 4, 36 },
                    { 18, "/awesome/programming", 6, 73 },
                    { 12, "/computers-computers--jewelery/credit-card-account/shoes--home", 5, 73 },
                    { 75, "/supply-chains/roi/indigo", 2, 65 },
                    { 6, "/matrix/bottom-line/e-tailers", 4, 65 },
                    { 27, "/awesome-frozen-fish", 6, 68 },
                    { 51, "/netherlands-antillian-guilder/checking-account/neck", 6, 76 },
                    { 49, "/solomon-islands-dollar/outdoors--jewelery/virtual", 6, 76 },
                    { 9, "/investment-account/awesome-wooden-gloves", 2, 76 },
                    { 57, "/circuit", 3, 58 },
                    { 79, "/berkshire", 3, 26 },
                    { 8, "/reboot/redefine/iowa", 4, 98 },
                    { 59, "/e-enable", 4, 84 },
                    { 74, "/bedfordshire/fresh", 6, 43 },
                    { 44, "/lead/overriding", 7, 43 },
                    { 95, "/users", 4, 47 },
                    { 13, "/navigate/collaborative", 2, 40 },
                    { 68, "/frozen", 6, 23 },
                    { 31, "/wisconsin/outdoors", 5, 59 },
                    { 82, "/borders", 1, 20 },
                    { 97, "/industrial-movies--sports/reduced", 1, 93 },
                    { 71, "/connect/handmade/convergence", 2, 93 },
                    { 76, "/spurs/cambridgeshire/internal", 5, 53 },
                    { 14, "/rustic-fresh-sausages", 2, 53 },
                    { 11, "/object-oriented", 7, 53 },
                    { 55, "/rustic-soft-hat", 3, 14 },
                    { 47, "/ai/calculate/turn-key", 5, 14 },
                    { 63, "/crest/sensor", 2, 11 },
                    { 40, "/personal-loan-account/florida", 5, 79 },
                    { 87, "/optical", 6, 52 },
                    { 20, "/courts/vista", 1, 52 },
                    { 23, "/index/program", 3, 48 },
                    { 93, "/terrace", 1, 44 },
                    { 91, "/web-services/calculate", 5, 44 },
                    { 30, "/synergized/compress/orchestrate", 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[,]
                {
                    { 50, "/bus", 7, 1 },
                    { 38, "/bluetooth/yuan-renminbi", 5, 1 },
                    { 83, "/action-items/street", 4, 49 },
                    { 35, "/turquoise/ram/massachusetts", 5, 69 },
                    { 92, "/generic-frozen-pizza/fault-tolerant/multi-byte", 7, 61 },
                    { 86, "/vermont", 3, 45 },
                    { 60, "/pound-sterling/deposit", 3, 3 },
                    { 4, "/human/international/support", 6, 3 },
                    { 25, "/hryvnia/grocery--home", 4, 96 },
                    { 90, "/kazakhstan", 1, 100 },
                    { 89, "/accountability/contingency", 1, 33 },
                    { 5, "/plum", 2, 33 },
                    { 88, "/hack/cotton/creative", 5, 41 },
                    { 32, "/enable/exe", 4, 41 },
                    { 16, "/circuit", 1, 41 },
                    { 2, "/tactics/turquoise/portals", 1, 74 },
                    { 81, "/investment-account/payment/camp", 6, 57 },
                    { 48, "/automotive-clothing--games", 3, 57 },
                    { 15, "/gorgeous-concrete-fish", 1, 57 },
                    { 39, "/metrics/transparent", 6, 25 },
                    { 58, "/computers", 1, 90 },
                    { 72, "/sleek", 6, 51 },
                    { 70, "/sexy/plastic/plastic", 3, 51 },
                    { 29, "/handmade/object-based/massachusetts", 6, 51 },
                    { 80, "/developer", 2, 64 },
                    { 3, "/stravenue/dynamic", 6, 60 },
                    { 42, "/west-virginia/brand", 6, 29 },
                    { 65, "/24365", 1, 2 },
                    { 62, "/berkshire/vermont/optimize", 3, 2 },
                    { 56, "/system-worthy/open-source/refined-wooden-gloves", 5, 2 },
                    { 33, "/marshall-islands/unbranded/arizona", 5, 88 },
                    { 41, "/initiatives/fantastic/enhance", 5, 12 },
                    { 61, "/contextually-based", 2, 38 },
                    { 78, "/moderator", 5, 38 },
                    { 84, "/sky-blue/primary/violet", 6, 70 },
                    { 53, "/bosnia-and-herzegovina", 1, 62 },
                    { 28, "/monitor/awesome-rubber-table/red", 7, 62 },
                    { 99, "/executive/wyoming", 3, 56 },
                    { 85, "/persistent/bandwidth/home-health--grocery", 1, 56 },
                    { 46, "/copy/program", 6, 56 },
                    { 66, "/feed/boliviano-boliviano/transparent", 5, 15 },
                    { 1, "/cambridgeshire", 4, 31 }
                });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[,]
                {
                    { 64, "/sleek", 7, 81 },
                    { 26, "/object-oriented/berkshire/ford", 5, 81 },
                    { 10, "/mindshare/transmitting/officer", 4, 30 },
                    { 94, "/exclusive/withdrawal", 1, 6 },
                    { 37, "/transmitter/generic-granite-table/security", 6, 37 },
                    { 22, "/incredible/invoice", 1, 37 },
                    { 19, "/transmitting", 5, 37 },
                    { 21, "/delaware/proactive", 4, 32 },
                    { 17, "/fantastic-cotton-car", 4, 32 },
                    { 98, "/savings-account/holistic", 3, 54 },
                    { 77, "/refined-soft-sausages/copying/generic-cotton-sausages", 2, 5 },
                    { 24, "/mobility", 2, 5 },
                    { 52, "/awesome-soft-shoes/system/mindshare", 6, 17 },
                    { 54, "/sexy/com/initiatives", 1, 91 },
                    { 100, "/capacitor", 4, 37 },
                    { 67, "/hill/ability/auxiliary", 6, 85 }
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
                name: "SousAxes");

            migrationBuilder.DropTable(
                name: "SyntheseRecommandations");

            migrationBuilder.DropTable(
                name: "Axes");

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
                name: "Visites");

            migrationBuilder.DropTable(
                name: "Rapports");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Traites");

            migrationBuilder.DropTable(
                name: "Organismes");

            migrationBuilder.DropTable(
                name: "Profils");
        }
    }
}
