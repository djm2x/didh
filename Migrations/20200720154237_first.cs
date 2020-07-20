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
                    Date = table.Column<DateTime>(nullable: true),
                    LienRapport = table.Column<string>(nullable: true),
                    MiseOeuvrePiece = table.Column<string>(nullable: true),
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
                values: new object[] { 10, "Categorie 1", new DateTime(2020, 5, 11, 9, 57, 10, 310, DateTimeKind.Local).AddTicks(8612), "Voluptate ullam necessitatibus inventore. Aliquid reprehenderit et. Ut officia et qui et voluptatem dignissimos minus ipsam possimus. Et sit esse. Et dolor quos vel. Qui autem sed velit saepe exercitationem id eaque. In animi quod quo itaque modi eaque minus qui. Voluptatem ipsam sunt et temporibus odit maiores tempora. Quo quaerat debitis vero culpa eos et vero illo quam. Sit expedita voluptate tenetur repudiandae nesciunt voluptatem ea dolore.", "unde" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 9, "Categorie 1", new DateTime(2019, 8, 13, 23, 15, 30, 197, DateTimeKind.Local).AddTicks(6376), "Et voluptas alias ullam ad in impedit culpa. Officiis impedit aliquam dolore. Esse ipsum optio. Repellendus eius et tempora. Perspiciatis tempore molestiae. Sit dolorem autem similique est impedit dolores aut consequatur. Aut voluptatem qui accusamus tempora nihil consequuntur enim vitae. Sed nihil ut non quo. Hic magni rerum dolorem blanditiis et. Unde autem velit omnis nemo.", "et" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 8, "Categorie 1", new DateTime(2020, 7, 4, 8, 30, 58, 119, DateTimeKind.Local).AddTicks(6380), "Maxime dolorum cumque quos placeat rem soluta. Iure fugit nihil. Sequi aut dolorem expedita vero error nemo facere. Dolorem illum eos corrupti qui dolores. At voluptatem ipsa et. Voluptates et quam temporibus sit error consequatur deleniti. Blanditiis labore repellat. Sit aut aut maxime pariatur officiis aut. Consequuntur culpa aut error alias sit. Omnis tempora quia architecto fuga.", "velit" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 7, "Categorie 1", new DateTime(2020, 2, 12, 0, 45, 0, 968, DateTimeKind.Local).AddTicks(5910), "Ea vel nostrum eos reprehenderit eum ipsa qui velit. Eaque saepe qui quo quisquam recusandae consequuntur sed sed. Error placeat ex et et eaque temporibus. Et maxime ullam fugiat placeat omnis. Recusandae sit quos adipisci hic inventore dolor nulla quis aliquam. Quasi enim adipisci explicabo incidunt facere autem. Enim et blanditiis vero suscipit. Mollitia quidem quos libero occaecati. Ratione commodi officiis repellendus. Harum consequatur ipsum natus dolor et maiores quia aliquam ut. Non vel excepturi unde ipsa corrupti. Enim deleniti neque nesciunt voluptas ex nihil. Quia at ab ea nihil.", "voluptates" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 6, "Categorie 1", new DateTime(2019, 8, 6, 20, 45, 6, 54, DateTimeKind.Local).AddTicks(5724), "Sed numquam asperiores aut incidunt amet omnis aut. Perferendis tempora et laudantium excepturi. Aliquam architecto delectus sapiente nisi iure enim fugit quod. Animi in velit ea perferendis. Quidem voluptatem commodi sit sint quasi. Cupiditate facere velit totam et possimus temporibus qui quisquam. Aut perspiciatis est et dolore recusandae quia recusandae. Magnam maxime et. Commodi placeat nemo harum officia suscipit aspernatur. Quaerat amet exercitationem odio. Ratione sint accusantium ea.", "quia" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 4, "Categorie 1", new DateTime(2020, 1, 22, 19, 21, 44, 327, DateTimeKind.Local).AddTicks(7916), "Adipisci similique sunt. Et recusandae excepturi occaecati est non cupiditate. Dolor rerum tempore tempora ut. Hic et molestias ab fugit provident temporibus earum voluptates. Ut voluptatem amet. Accusamus nostrum explicabo ea voluptate et. Aut quibusdam alias et et magnam. Nihil tenetur accusamus quos. Ex officia in occaecati qui blanditiis iste. Quia voluptatem dignissimos veniam dolorum laboriosam consequuntur iusto.", "sed" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 3, "Categorie 1", new DateTime(2020, 6, 10, 12, 47, 55, 92, DateTimeKind.Local).AddTicks(6380), "Unde sint perferendis totam totam qui et tempore. Assumenda aliquid voluptatem. Magnam ut asperiores dignissimos earum autem reprehenderit nesciunt est praesentium. Quis ut consequatur saepe possimus est dolor molestiae asperiores. Voluptatibus incidunt optio ullam. Sit odio praesentium molestiae. Earum illo earum quo qui vel non. Sed rem rem dolorem praesentium amet aspernatur ut. Quisquam repudiandae ipsam doloribus molestiae doloremque maxime enim. Ullam ratione consequatur est tenetur. Ullam recusandae rerum ipsam nostrum ut dolores rerum. Ipsa nemo occaecati eligendi sequi est molestias. Eveniet ut porro unde.", "repudiandae" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 2, "Categorie 1", new DateTime(2019, 11, 14, 0, 12, 4, 420, DateTimeKind.Local).AddTicks(9328), "Aut in facilis voluptas blanditiis. Exercitationem eligendi soluta. Porro quia dolorem nulla. Neque voluptatibus et autem eaque provident maiores tenetur. Accusamus fuga sint et incidunt nisi nemo. Autem cum dolores repudiandae iste ut dignissimos labore occaecati ut. Debitis nihil dolor est impedit non unde molestiae. Nostrum et possimus sed ducimus dicta. Eum similique et laudantium laboriosam at autem provident voluptatem quo. Id quidem illo dolores sint exercitationem nostrum beatae at. Itaque consequatur expedita.", "libero" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 1, "Categorie 1", new DateTime(2019, 8, 10, 10, 1, 27, 548, DateTimeKind.Local).AddTicks(1429), "Ut sit est perferendis dolorem molestiae cumque rem qui impedit. Perferendis voluptatem deserunt a quia impedit cumque cumque. At et atque accusamus natus consequatur dignissimos est et. Quidem rerum architecto molestias nisi. Dolores maxime laudantium iure dolorum. Animi nesciunt illo harum iusto voluptate corporis qui. Vitae asperiores commodi explicabo in cumque at blanditiis ea. Reiciendis aut qui quasi possimus earum facere dolore officia quasi. Labore ipsam sed fugit ut voluptas illum molestiae autem aperiam. Odit sint omnis necessitatibus impedit velit.", "eligendi" });

            migrationBuilder.InsertData(
                table: "Evenements",
                columns: new[] { "Id", "Categorie", "Date", "Description", "Title" },
                values: new object[] { 5, "Categorie 1", new DateTime(2020, 5, 5, 5, 19, 15, 83, DateTimeKind.Local).AddTicks(9953), "Ut aliquam voluptas qui quas magni atque veniam qui. Tenetur velit maxime sunt fugiat consequatur totam. Hic rerum at nihil quis dicta aliquid quisquam ullam. Quia assumenda non odit animi. Eaque aspernatur placeat in perferendis perferendis ut enim. Id quasi dolore sed. Molestias voluptatem delectus. Eveniet quia delectus fugiat rerum facere totam repellendus. Adipisci neque illum officia nulla mollitia architecto sed minus. Necessitatibus possimus itaque. Culpa error assumenda perferendis odit sit aliquam repellendus et et.", "pariatur" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 5, "", "", "Examen-6", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 6, "", "", "Examen-7", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 4, "", "", "Examen-5", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 1, "", "", "Examen-2", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 2, "", "", "Examen-3", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Examens",
                columns: new[] { "Id", "CompilationHCDH", "Discours", "Libelle", "MiseOeuvrePiece", "ObservationFinale", "RapportMiParcours", "RapportNational" },
                values: new object[] { 3, "", "", "Examen-4", "", "", "", "" });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 73, new DateTime(2020, 7, 13, 11, 44, 54, 272, DateTimeKind.Local).AddTicks(1974), "1,3,6", 73, 2, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 72, new DateTime(2019, 12, 13, 1, 1, 15, 101, DateTimeKind.Local).AddTicks(9265), "0,2,6", 72, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 71, new DateTime(2019, 7, 24, 23, 34, 43, 228, DateTimeKind.Local).AddTicks(9355), "0,2,6", 71, 5, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 70, new DateTime(2019, 8, 26, 10, 7, 43, 867, DateTimeKind.Local).AddTicks(5196), "0,3,6", 70, 3, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 69, new DateTime(2020, 3, 31, 16, 9, 56, 248, DateTimeKind.Local).AddTicks(7833), "0,3,4", 69, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 68, new DateTime(2020, 2, 7, 19, 14, 3, 718, DateTimeKind.Local).AddTicks(930), "1,3,6", 68, 3, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 67, new DateTime(2019, 8, 3, 21, 9, 15, 135, DateTimeKind.Local).AddTicks(8457), "1,2,5", 67, 4, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 66, new DateTime(2020, 5, 11, 3, 19, 14, 685, DateTimeKind.Local).AddTicks(7292), "0,3,4", 66, 1, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 65, new DateTime(2020, 4, 4, 4, 47, 13, 927, DateTimeKind.Local).AddTicks(1401), "1,3,5", 65, 2, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 64, new DateTime(2020, 5, 28, 7, 9, 53, 310, DateTimeKind.Local).AddTicks(446), "1,2,4", 64, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 63, new DateTime(2020, 7, 1, 13, 42, 44, 651, DateTimeKind.Local).AddTicks(4420), "1,2,4", 63, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 61, new DateTime(2020, 4, 27, 9, 36, 55, 142, DateTimeKind.Local).AddTicks(127), "1,3,6", 61, 3, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 60, new DateTime(2020, 6, 25, 18, 15, 19, 998, DateTimeKind.Local).AddTicks(3350), "1,3,4", 60, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 59, new DateTime(2020, 7, 15, 14, 4, 42, 255, DateTimeKind.Local).AddTicks(7907), "0,2,4", 59, 5, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 58, new DateTime(2020, 7, 11, 21, 47, 29, 402, DateTimeKind.Local).AddTicks(8765), "1,2,4", 58, 2, "Nouveau traité a été ajoutée", 1, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 57, new DateTime(2019, 12, 24, 16, 54, 6, 800, DateTimeKind.Local).AddTicks(7586), "0,2,5", 57, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 56, new DateTime(2020, 4, 17, 12, 3, 48, 921, DateTimeKind.Local).AddTicks(7364), "1,2,5", 56, 5, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 55, new DateTime(2019, 7, 25, 1, 47, 58, 772, DateTimeKind.Local).AddTicks(4651), "0,2,5", 55, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 54, new DateTime(2019, 12, 13, 11, 49, 15, 31, DateTimeKind.Local).AddTicks(9594), "1,2,4", 54, 6, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 53, new DateTime(2020, 2, 29, 2, 38, 3, 119, DateTimeKind.Local).AddTicks(1099), "1,3,4", 53, 3, "Nouveau traité a été ajoutée", 4, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 74, new DateTime(2020, 1, 11, 16, 33, 38, 224, DateTimeKind.Local).AddTicks(7522), "1,3,4", 74, 5, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 62, new DateTime(2020, 4, 17, 2, 36, 45, 257, DateTimeKind.Local).AddTicks(4199), "0,3,4", 62, 6, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 75, new DateTime(2019, 7, 27, 22, 25, 14, 798, DateTimeKind.Local).AddTicks(3265), "0,3,4", 75, 3, "Nouvelle visite a été ajouter", 1, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 93, new DateTime(2020, 6, 26, 17, 2, 13, 63, DateTimeKind.Local).AddTicks(3454), "0,2,6", 93, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 77, new DateTime(2019, 11, 1, 8, 49, 27, 252, DateTimeKind.Local).AddTicks(555), "1,3,5", 77, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 100, new DateTime(2020, 6, 11, 18, 42, 57, 558, DateTimeKind.Local).AddTicks(1640), "1,3,6", 100, 4, "Nouvelle visite a été ajouter", 3, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 99, new DateTime(2019, 11, 23, 2, 41, 43, 903, DateTimeKind.Local).AddTicks(9102), "0,2,6", 99, 3, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 98, new DateTime(2020, 1, 16, 14, 48, 16, 210, DateTimeKind.Local).AddTicks(3893), "0,2,6", 98, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 97, new DateTime(2020, 4, 15, 15, 13, 48, 376, DateTimeKind.Local).AddTicks(8496), "1,3,4", 97, 3, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 96, new DateTime(2020, 7, 6, 8, 33, 55, 296, DateTimeKind.Local).AddTicks(4341), "1,2,5", 96, 1, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 95, new DateTime(2019, 9, 19, 20, 52, 39, 572, DateTimeKind.Local).AddTicks(273), "1,2,5", 95, 6, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 94, new DateTime(2019, 10, 29, 5, 45, 25, 891, DateTimeKind.Local).AddTicks(9535), "1,2,5", 94, 1, "Nouveau traité a été ajoutée", 3, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 52, new DateTime(2020, 4, 10, 22, 4, 35, 310, DateTimeKind.Local).AddTicks(2084), "0,3,4", 52, 3, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 92, new DateTime(2019, 8, 2, 4, 34, 54, 877, DateTimeKind.Local).AddTicks(5179), "1,2,6", 92, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 91, new DateTime(2019, 8, 24, 15, 6, 55, 268, DateTimeKind.Local).AddTicks(6720), "1,2,4", 91, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 76, new DateTime(2019, 9, 29, 5, 57, 59, 692, DateTimeKind.Local).AddTicks(5191), "1,3,5", 76, 6, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 90, new DateTime(2019, 11, 20, 19, 25, 42, 935, DateTimeKind.Local).AddTicks(8917), "1,2,6", 90, 6, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 88, new DateTime(2020, 4, 26, 13, 47, 5, 679, DateTimeKind.Local).AddTicks(4316), "1,3,6", 88, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 87, new DateTime(2019, 9, 25, 22, 37, 17, 789, DateTimeKind.Local).AddTicks(7334), "1,3,6", 87, 1, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 86, new DateTime(2020, 3, 27, 22, 57, 27, 399, DateTimeKind.Local).AddTicks(4243), "1,3,4", 86, 1, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 85, new DateTime(2020, 2, 10, 2, 12, 53, 368, DateTimeKind.Local).AddTicks(3734), "0,3,5", 85, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 83, new DateTime(2020, 6, 25, 22, 31, 32, 695, DateTimeKind.Local).AddTicks(4757), "1,3,6", 83, 3, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 82, new DateTime(2020, 2, 7, 22, 50, 54, 590, DateTimeKind.Local).AddTicks(4788), "0,3,4", 82, 2, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 81, new DateTime(2020, 2, 28, 14, 46, 55, 879, DateTimeKind.Local).AddTicks(500), "1,2,5", 81, 1, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 80, new DateTime(2019, 8, 27, 21, 58, 12, 105, DateTimeKind.Local).AddTicks(3516), "0,2,6", 80, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 79, new DateTime(2019, 11, 2, 10, 10, 54, 593, DateTimeKind.Local).AddTicks(2873), "1,3,5", 79, 5, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 78, new DateTime(2020, 4, 11, 19, 38, 45, 260, DateTimeKind.Local).AddTicks(6818), "1,2,4", 78, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 89, new DateTime(2019, 9, 11, 6, 33, 26, 189, DateTimeKind.Local).AddTicks(6544), "1,3,5", 89, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 51, new DateTime(2020, 2, 4, 17, 56, 8, 720, DateTimeKind.Local).AddTicks(6845), "0,2,6", 51, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 84, new DateTime(2020, 6, 8, 6, 47, 46, 495, DateTimeKind.Local).AddTicks(6153), "1,3,6", 84, 4, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 49, new DateTime(2019, 11, 22, 15, 17, 42, 884, DateTimeKind.Local).AddTicks(5660), "1,2,6", 49, 3, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 22, new DateTime(2020, 3, 21, 9, 56, 34, 940, DateTimeKind.Local).AddTicks(4664), "0,2,5", 22, 6, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 21, new DateTime(2020, 3, 29, 14, 13, 12, 755, DateTimeKind.Local).AddTicks(8), "1,3,5", 21, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 20, new DateTime(2020, 1, 6, 9, 8, 22, 67, DateTimeKind.Local).AddTicks(1944), "0,2,6", 20, 1, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 19, new DateTime(2020, 3, 12, 0, 28, 2, 849, DateTimeKind.Local).AddTicks(4265), "1,2,4", 19, 2, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 18, new DateTime(2019, 10, 14, 6, 0, 44, 323, DateTimeKind.Local).AddTicks(2972), "0,2,5", 18, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 17, new DateTime(2019, 10, 26, 1, 42, 47, 151, DateTimeKind.Local).AddTicks(4725), "0,2,4", 17, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 15, new DateTime(2019, 9, 11, 19, 24, 18, 693, DateTimeKind.Local).AddTicks(4168), "1,3,4", 15, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 14, new DateTime(2020, 5, 7, 4, 44, 8, 23, DateTimeKind.Local).AddTicks(6902), "0,2,4", 14, 5, "Nouveau synthèse a été ajoutée", 3, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 13, new DateTime(2020, 7, 17, 21, 27, 47, 239, DateTimeKind.Local).AddTicks(4287), "0,3,4", 13, 2, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 12, new DateTime(2020, 1, 13, 20, 43, 32, 799, DateTimeKind.Local).AddTicks(9901), "1,3,4", 12, 5, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 23, new DateTime(2019, 12, 23, 13, 11, 49, 403, DateTimeKind.Local).AddTicks(8711), "1,2,6", 23, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 11, new DateTime(2019, 8, 19, 10, 1, 33, 784, DateTimeKind.Local).AddTicks(6377), "1,2,5", 11, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 9, new DateTime(2020, 3, 8, 11, 44, 33, 857, DateTimeKind.Local).AddTicks(1688), "1,2,6", 9, 1, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 8, new DateTime(2019, 8, 25, 11, 40, 12, 130, DateTimeKind.Local).AddTicks(800), "0,3,5", 8, 6, "Nouveau synthèse a été ajoutée", 1, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 7, new DateTime(2020, 2, 10, 22, 46, 49, 60, DateTimeKind.Local).AddTicks(4848), "1,2,4", 7, 4, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 6, new DateTime(2020, 6, 19, 19, 31, 56, 346, DateTimeKind.Local).AddTicks(4290), "0,2,4", 6, 5, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 5, new DateTime(2020, 1, 30, 21, 25, 25, 497, DateTimeKind.Local).AddTicks(5465), "0,3,6", 5, 2, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 4, new DateTime(2019, 9, 19, 21, 50, 42, 568, DateTimeKind.Local).AddTicks(1729), "1,3,5", 4, 6, "Nouvelle recommandation a été ajoutée", 2, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 3, new DateTime(2020, 4, 16, 4, 46, 52, 149, DateTimeKind.Local).AddTicks(6223), "0,2,5", 3, 4, "Nouvelle recommandation a été ajoutée", 4, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 2, new DateTime(2020, 3, 26, 10, 17, 44, 38, DateTimeKind.Local).AddTicks(4359), "1,3,5", 2, 4, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 1, new DateTime(2019, 9, 5, 20, 24, 55, 641, DateTimeKind.Local).AddTicks(2272), "1,3,5", 1, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 50, new DateTime(2019, 12, 27, 1, 37, 47, 861, DateTimeKind.Local).AddTicks(8631), "1,3,6", 50, 4, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 10, new DateTime(2020, 4, 14, 5, 15, 11, 648, DateTimeKind.Local).AddTicks(5337), "1,2,4", 10, 4, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 24, new DateTime(2020, 3, 2, 22, 0, 7, 922, DateTimeKind.Local).AddTicks(9219), "1,3,6", 24, 5, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 16, new DateTime(2019, 10, 22, 6, 1, 53, 204, DateTimeKind.Local).AddTicks(4304), "1,2,5", 16, 6, "Nouvelle visite a été ajouter", 3, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 26, new DateTime(2020, 7, 18, 19, 22, 43, 379, DateTimeKind.Local).AddTicks(5825), "1,3,6", 26, 3, "Nouvelle recommandation a été ajoutée", 2, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 48, new DateTime(2019, 11, 22, 1, 44, 42, 218, DateTimeKind.Local).AddTicks(5318), "0,3,5", 48, 4, "Nouveau traité a été ajoutée", 1, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 47, new DateTime(2019, 11, 11, 12, 32, 16, 441, DateTimeKind.Local).AddTicks(7968), "0,2,4", 47, 4, "Nouveau traité a été ajoutée", 2, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 46, new DateTime(2019, 8, 4, 9, 10, 6, 573, DateTimeKind.Local).AddTicks(8457), "1,3,5", 46, 2, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 25, new DateTime(2020, 4, 1, 21, 18, 30, 864, DateTimeKind.Local).AddTicks(4099), "1,2,6", 25, 6, "Nouvelle visite a été ajouter", 4, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 44, new DateTime(2019, 7, 28, 18, 44, 17, 311, DateTimeKind.Local).AddTicks(1132), "0,3,4", 44, 4, "Nouveau synthèse a été ajoutée", 1, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 43, new DateTime(2019, 12, 30, 2, 2, 34, 236, DateTimeKind.Local).AddTicks(7625), "1,3,6", 43, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 42, new DateTime(2020, 6, 26, 15, 34, 8, 658, DateTimeKind.Local).AddTicks(5183), "0,2,6", 42, 2, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 41, new DateTime(2019, 11, 2, 16, 47, 53, 900, DateTimeKind.Local).AddTicks(549), "0,2,5", 41, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 40, new DateTime(2019, 8, 2, 21, 36, 28, 596, DateTimeKind.Local).AddTicks(5686), "0,2,6", 40, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 39, new DateTime(2020, 5, 2, 1, 2, 59, 138, DateTimeKind.Local).AddTicks(5377), "0,2,6", 39, 5, "Nouveau synthèse a été ajoutée", 4, "synthese", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 38, new DateTime(2020, 3, 14, 4, 31, 50, 484, DateTimeKind.Local).AddTicks(4908), "0,3,5", 38, 6, "Nouvelle visite a été ajouter", 2, "visite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 37, new DateTime(2019, 9, 9, 14, 49, 21, 280, DateTimeKind.Local).AddTicks(5624), "1,2,5", 37, 6, "Nouvelle visite a été ajouter", 2, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 45, new DateTime(2019, 9, 16, 0, 52, 34, 45, DateTimeKind.Local).AddTicks(3060), "1,3,5", 45, 4, "Nouvelle visite a été ajouter", 1, "visite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 35, new DateTime(2019, 9, 21, 9, 14, 14, 24, DateTimeKind.Local).AddTicks(96), "0,3,5", 35, 5, "Nouveau traité a été ajoutée", 2, "traite", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 34, new DateTime(2020, 7, 8, 13, 56, 57, 606, DateTimeKind.Local).AddTicks(9580), "1,3,6", 34, 1, "Nouvelle recommandation a été ajoutée", 3, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 33, new DateTime(2020, 1, 28, 14, 17, 53, 201, DateTimeKind.Local).AddTicks(3523), "1,2,6", 33, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 27, new DateTime(2019, 10, 31, 23, 29, 25, 188, DateTimeKind.Local).AddTicks(3833), "0,2,6", 27, 4, "Nouvelle recommandation a été ajoutée", 1, "recommandation", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 32, new DateTime(2020, 1, 16, 2, 59, 29, 626, DateTimeKind.Local).AddTicks(3332), "0,3,4", 32, 3, "Nouvelle recommandation a été ajoutée", 3, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 31, new DateTime(2019, 7, 24, 22, 27, 3, 397, DateTimeKind.Local).AddTicks(1018), "0,2,6", 31, 1, "Nouveau synthèse a été ajoutée", 2, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 30, new DateTime(2020, 6, 9, 16, 19, 32, 581, DateTimeKind.Local).AddTicks(8713), "0,3,5", 30, 1, "Nouveau traité a été ajoutée", 3, "traite", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 29, new DateTime(2020, 1, 22, 20, 48, 50, 603, DateTimeKind.Local).AddTicks(1457), "1,2,4", 29, 2, "Nouveau synthèse a été ajoutée", 3, "synthese", true });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 28, new DateTime(2020, 4, 23, 22, 43, 12, 8, DateTimeKind.Local).AddTicks(2145), "1,2,6", 28, 2, "Nouvelle recommandation a été ajoutée", 1, "recommandation", false });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Date", "Destinataire", "IdConcerner", "IdOrganisme", "Message", "Priorite", "TableConcerner", "Vu" },
                values: new object[] { 36, new DateTime(2020, 1, 17, 23, 48, 55, 773, DateTimeKind.Local).AddTicks(82), "0,3,4", 36, 6, "Nouvelle recommandation a été ajoutée", 4, "recommandation", false });

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
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 15, 2020, "", "", "Session 15", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 14, 2020, "", "", "Session 14", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 9, 2020, "", "", "Session 9", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 12, 2020, "", "", "Session 12", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 11, 2020, "", "", "Session 11", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 10, 2020, "", "", "Session 10", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 8, 2020, "", "", "Session 8", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 13, 2020, "", "", "Session 13", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 6, 2020, "", "", "Session 6", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 5, 2020, "", "", "Session 5", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 4, 2020, "", "", "Session 4", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 3, 2020, "", "", "Session 3", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 2, 2020, "", "", "Session 2", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 1, 2020, "", "", "Session 1", null });

            migrationBuilder.InsertData(
                table: "ParticipationSessions",
                columns: new[] { "Id", "Annee", "Discours", "Documents", "Session", "SessionAr" },
                values: new object[] { 7, 2020, "", "", "Session 7", null });

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
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 9, 2020, "", "sous theme 9", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 15, 2020, "", "sous theme 15", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 14, 2020, "", "sous theme 14", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 13, 2020, "", "sous theme 13", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 11, 2020, "", "sous theme 11", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 10, 2020, "", "sous theme 10", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 8, 2020, "", "sous theme 8", "Droits thématiques" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 12, 2020, "", "sous theme 12", "Droits catégoriels" });

            migrationBuilder.InsertData(
                table: "Questionnaires",
                columns: new[] { "Id", "Annee", "PieceJointe", "SousTheme", "Theme" },
                values: new object[] { 6, 2020, "", "sous theme 6", "Droits catégoriels" });

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
                values: new object[] { 3, 2020, "", "sous theme 3", "Droits thématiques" });

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
                values: new object[] { 66, "", "", new DateTime(2020, 2, 15, 7, 33, 41, 154, DateTimeKind.Local).AddTicks(4587), new DateTime(2019, 10, 16, 5, 7, 25, 188, DateTimeKind.Local).AddTicks(1359), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 67, "", "", new DateTime(2020, 2, 1, 10, 45, 58, 819, DateTimeKind.Local).AddTicks(9087), new DateTime(2020, 3, 18, 19, 56, 6, 682, DateTimeKind.Local).AddTicks(7322), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 68, "", "", new DateTime(2019, 8, 12, 11, 1, 2, 320, DateTimeKind.Local).AddTicks(5851), new DateTime(2019, 9, 23, 1, 51, 37, 898, DateTimeKind.Local).AddTicks(2850), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 69, "", "", new DateTime(2020, 6, 28, 17, 32, 53, 111, DateTimeKind.Local).AddTicks(7234), new DateTime(2020, 3, 19, 17, 53, 58, 878, DateTimeKind.Local).AddTicks(8685), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 72, "", "", new DateTime(2019, 8, 5, 19, 15, 31, 920, DateTimeKind.Local).AddTicks(7356), new DateTime(2019, 9, 6, 12, 24, 38, 422, DateTimeKind.Local).AddTicks(9842), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 71, "", "", new DateTime(2020, 3, 28, 11, 20, 13, 682, DateTimeKind.Local).AddTicks(3238), new DateTime(2020, 3, 29, 22, 24, 25, 415, DateTimeKind.Local).AddTicks(4510), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 65, "", "", new DateTime(2019, 12, 29, 17, 39, 26, 629, DateTimeKind.Local).AddTicks(287), new DateTime(2019, 8, 7, 21, 48, 34, 203, DateTimeKind.Local).AddTicks(2406), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 73, "", "", new DateTime(2020, 7, 8, 22, 17, 23, 969, DateTimeKind.Local).AddTicks(1402), new DateTime(2020, 1, 4, 4, 34, 22, 44, DateTimeKind.Local).AddTicks(6996), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 74, "", "", new DateTime(2019, 8, 9, 4, 37, 34, 791, DateTimeKind.Local).AddTicks(1922), new DateTime(2020, 7, 6, 12, 3, 20, 409, DateTimeKind.Local).AddTicks(2418), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 70, "", "", new DateTime(2020, 1, 26, 0, 1, 39, 327, DateTimeKind.Local).AddTicks(2384), new DateTime(2020, 4, 16, 11, 25, 21, 905, DateTimeKind.Local).AddTicks(3532), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 64, "", "", new DateTime(2019, 12, 4, 12, 18, 17, 572, DateTimeKind.Local).AddTicks(9215), new DateTime(2020, 7, 2, 3, 50, 54, 917, DateTimeKind.Local).AddTicks(7128), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 62, "", "", new DateTime(2020, 4, 23, 15, 38, 53, 660, DateTimeKind.Local).AddTicks(3223), new DateTime(2020, 3, 21, 2, 35, 15, 715, DateTimeKind.Local).AddTicks(876), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 53, "", "", new DateTime(2020, 1, 5, 0, 5, 24, 136, DateTimeKind.Local).AddTicks(2263), new DateTime(2019, 12, 11, 14, 13, 41, 515, DateTimeKind.Local).AddTicks(9844), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 61, "", "", new DateTime(2020, 6, 15, 1, 51, 10, 168, DateTimeKind.Local).AddTicks(2171), new DateTime(2019, 10, 8, 18, 5, 49, 837, DateTimeKind.Local).AddTicks(2483), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 60, "", "", new DateTime(2020, 4, 26, 18, 23, 35, 3, DateTimeKind.Local).AddTicks(3444), new DateTime(2020, 7, 5, 14, 58, 36, 320, DateTimeKind.Local).AddTicks(985), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 59, "", "", new DateTime(2020, 1, 28, 9, 7, 35, 62, DateTimeKind.Local).AddTicks(5660), new DateTime(2019, 8, 2, 23, 43, 48, 823, DateTimeKind.Local).AddTicks(7371), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 58, "", "", new DateTime(2019, 7, 28, 13, 17, 59, 831, DateTimeKind.Local).AddTicks(9299), new DateTime(2020, 7, 12, 18, 49, 47, 495, DateTimeKind.Local).AddTicks(9975), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 57, "", "", new DateTime(2019, 8, 2, 17, 40, 43, 393, DateTimeKind.Local).AddTicks(7865), new DateTime(2019, 9, 24, 20, 49, 3, 994, DateTimeKind.Local).AddTicks(4569), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 56, "", "", new DateTime(2020, 2, 13, 21, 11, 26, 863, DateTimeKind.Local).AddTicks(2914), new DateTime(2019, 9, 25, 23, 28, 22, 872, DateTimeKind.Local).AddTicks(2021), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 55, "", "", new DateTime(2019, 10, 8, 3, 30, 39, 422, DateTimeKind.Local).AddTicks(4468), new DateTime(2020, 4, 22, 1, 20, 46, 488, DateTimeKind.Local).AddTicks(7728), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 54, "", "", new DateTime(2019, 8, 1, 21, 33, 12, 308, DateTimeKind.Local).AddTicks(6293), new DateTime(2020, 3, 14, 7, 18, 55, 772, DateTimeKind.Local).AddTicks(9450), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 75, "", "", new DateTime(2020, 1, 30, 6, 7, 17, 184, DateTimeKind.Local).AddTicks(4535), new DateTime(2020, 3, 18, 22, 5, 2, 103, DateTimeKind.Local).AddTicks(4462), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 63, "", "", new DateTime(2020, 2, 28, 1, 50, 42, 736, DateTimeKind.Local).AddTicks(6279), new DateTime(2019, 9, 27, 10, 14, 51, 39, DateTimeKind.Local).AddTicks(1203), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 76, "", "", new DateTime(2019, 12, 22, 14, 4, 23, 540, DateTimeKind.Local).AddTicks(3637), new DateTime(2020, 2, 17, 12, 21, 9, 485, DateTimeKind.Local).AddTicks(4854), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 91, "", "", new DateTime(2019, 12, 9, 13, 41, 30, 279, DateTimeKind.Local).AddTicks(3394), new DateTime(2020, 5, 29, 8, 44, 55, 924, DateTimeKind.Local).AddTicks(7531), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 78, "", "", new DateTime(2020, 1, 26, 18, 0, 3, 741, DateTimeKind.Local).AddTicks(5709), new DateTime(2019, 10, 14, 0, 20, 12, 466, DateTimeKind.Local).AddTicks(260), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 52, "", "", new DateTime(2019, 10, 25, 3, 50, 20, 685, DateTimeKind.Local).AddTicks(3532), new DateTime(2020, 1, 7, 5, 58, 46, 261, DateTimeKind.Local).AddTicks(8280), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 100, "", "", new DateTime(2020, 3, 17, 22, 23, 13, 701, DateTimeKind.Local).AddTicks(7450), new DateTime(2020, 7, 5, 12, 59, 29, 971, DateTimeKind.Local).AddTicks(5324), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 99, "", "", new DateTime(2020, 6, 20, 19, 51, 3, 725, DateTimeKind.Local).AddTicks(4697), new DateTime(2020, 5, 23, 20, 59, 36, 471, DateTimeKind.Local).AddTicks(7021), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 98, "", "", new DateTime(2020, 1, 30, 5, 10, 12, 426, DateTimeKind.Local).AddTicks(7551), new DateTime(2019, 11, 3, 9, 56, 6, 445, DateTimeKind.Local).AddTicks(8902), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 97, "", "", new DateTime(2020, 2, 24, 3, 52, 19, 646, DateTimeKind.Local).AddTicks(5029), new DateTime(2020, 3, 14, 21, 59, 31, 779, DateTimeKind.Local).AddTicks(5754), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 96, "", "", new DateTime(2019, 7, 26, 10, 45, 56, 774, DateTimeKind.Local).AddTicks(7868), new DateTime(2020, 3, 6, 19, 51, 32, 98, DateTimeKind.Local).AddTicks(1902), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 95, "", "", new DateTime(2019, 7, 24, 4, 19, 53, 795, DateTimeKind.Local).AddTicks(1191), new DateTime(2019, 9, 20, 4, 37, 39, 287, DateTimeKind.Local).AddTicks(5506), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 94, "", "", new DateTime(2020, 7, 11, 4, 14, 15, 857, DateTimeKind.Local).AddTicks(978), new DateTime(2020, 1, 2, 23, 21, 42, 46, DateTimeKind.Local).AddTicks(1274), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 93, "", "", new DateTime(2020, 2, 6, 7, 6, 38, 981, DateTimeKind.Local).AddTicks(9273), new DateTime(2020, 6, 27, 22, 11, 49, 693, DateTimeKind.Local).AddTicks(1227), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 92, "", "", new DateTime(2019, 8, 20, 6, 46, 50, 220, DateTimeKind.Local).AddTicks(754), new DateTime(2020, 7, 6, 3, 35, 47, 77, DateTimeKind.Local).AddTicks(2988), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 77, "", "", new DateTime(2020, 2, 12, 10, 41, 23, 349, DateTimeKind.Local).AddTicks(6578), new DateTime(2020, 7, 2, 18, 16, 30, 190, DateTimeKind.Local).AddTicks(6946), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 90, "", "", new DateTime(2019, 9, 8, 20, 55, 11, 841, DateTimeKind.Local).AddTicks(1233), new DateTime(2019, 9, 18, 11, 3, 32, 763, DateTimeKind.Local).AddTicks(9721), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 88, "", "", new DateTime(2019, 10, 20, 13, 27, 23, 807, DateTimeKind.Local).AddTicks(4781), new DateTime(2020, 7, 3, 6, 2, 52, 260, DateTimeKind.Local).AddTicks(2011), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 87, "", "", new DateTime(2020, 5, 16, 13, 1, 34, 163, DateTimeKind.Local).AddTicks(7775), new DateTime(2020, 1, 25, 20, 11, 5, 853, DateTimeKind.Local).AddTicks(9772), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 86, "", "", new DateTime(2019, 10, 12, 19, 37, 39, 942, DateTimeKind.Local).AddTicks(4628), new DateTime(2020, 1, 31, 21, 36, 21, 418, DateTimeKind.Local).AddTicks(7461), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 85, "", "", new DateTime(2020, 6, 10, 14, 51, 7, 926, DateTimeKind.Local).AddTicks(259), new DateTime(2020, 1, 12, 22, 51, 0, 311, DateTimeKind.Local).AddTicks(3293), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 84, "", "", new DateTime(2019, 12, 12, 22, 46, 20, 344, DateTimeKind.Local).AddTicks(7489), new DateTime(2020, 2, 27, 1, 58, 53, 467, DateTimeKind.Local).AddTicks(9282), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 83, "", "", new DateTime(2020, 7, 9, 7, 25, 17, 776, DateTimeKind.Local).AddTicks(8751), new DateTime(2019, 12, 13, 15, 6, 30, 990, DateTimeKind.Local).AddTicks(8997), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 82, "", "", new DateTime(2020, 2, 22, 0, 38, 3, 773, DateTimeKind.Local).AddTicks(9666), new DateTime(2020, 3, 27, 17, 40, 40, 173, DateTimeKind.Local).AddTicks(2013), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 81, "", "", new DateTime(2019, 8, 23, 17, 44, 23, 996, DateTimeKind.Local).AddTicks(5259), new DateTime(2019, 8, 22, 18, 31, 39, 691, DateTimeKind.Local).AddTicks(9900), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 80, "", "", new DateTime(2019, 8, 30, 6, 15, 4, 327, DateTimeKind.Local).AddTicks(165), new DateTime(2020, 5, 15, 14, 48, 36, 831, DateTimeKind.Local).AddTicks(1965), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 79, "", "", new DateTime(2020, 6, 7, 0, 54, 35, 439, DateTimeKind.Local).AddTicks(3899), new DateTime(2020, 5, 23, 7, 32, 44, 130, DateTimeKind.Local).AddTicks(2266), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 89, "", "", new DateTime(2020, 3, 8, 4, 21, 10, 85, DateTimeKind.Local).AddTicks(914), new DateTime(2019, 9, 20, 10, 2, 46, 223, DateTimeKind.Local).AddTicks(3763), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 51, "", "", new DateTime(2020, 3, 27, 14, 29, 22, 428, DateTimeKind.Local).AddTicks(2352), new DateTime(2019, 9, 16, 12, 35, 48, 313, DateTimeKind.Local).AddTicks(6339), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 8, "", "", new DateTime(2020, 1, 19, 1, 0, 53, 985, DateTimeKind.Local).AddTicks(9019), new DateTime(2020, 6, 13, 22, 32, 23, 192, DateTimeKind.Local).AddTicks(5896), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 49, "", "", new DateTime(2019, 10, 13, 0, 24, 57, 263, DateTimeKind.Local).AddTicks(4668), new DateTime(2019, 12, 17, 15, 36, 58, 365, DateTimeKind.Local).AddTicks(1541), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 22, "", "", new DateTime(2019, 12, 23, 3, 51, 14, 96, DateTimeKind.Local).AddTicks(2362), new DateTime(2020, 1, 6, 12, 16, 2, 545, DateTimeKind.Local).AddTicks(5236), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 21, "", "", new DateTime(2019, 7, 21, 6, 29, 20, 329, DateTimeKind.Local).AddTicks(8372), new DateTime(2020, 6, 4, 23, 7, 8, 121, DateTimeKind.Local).AddTicks(2130), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 20, "", "", new DateTime(2020, 1, 12, 22, 41, 6, 497, DateTimeKind.Local).AddTicks(5726), new DateTime(2020, 2, 13, 15, 3, 10, 301, DateTimeKind.Local).AddTicks(7931), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 19, "", "", new DateTime(2019, 12, 16, 12, 44, 21, 639, DateTimeKind.Local).AddTicks(6179), new DateTime(2019, 12, 7, 4, 20, 26, 653, DateTimeKind.Local).AddTicks(6913), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 18, "", "", new DateTime(2020, 4, 21, 9, 34, 27, 186, DateTimeKind.Local).AddTicks(7082), new DateTime(2020, 3, 17, 12, 41, 12, 381, DateTimeKind.Local).AddTicks(1772), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 17, "", "", new DateTime(2019, 10, 12, 4, 26, 7, 867, DateTimeKind.Local).AddTicks(1224), new DateTime(2020, 4, 5, 16, 32, 36, 428, DateTimeKind.Local).AddTicks(4638), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 16, "", "", new DateTime(2020, 1, 14, 14, 48, 56, 965, DateTimeKind.Local).AddTicks(4305), new DateTime(2019, 11, 20, 3, 9, 37, 913, DateTimeKind.Local).AddTicks(6195), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 15, "", "", new DateTime(2019, 10, 2, 23, 34, 40, 759, DateTimeKind.Local).AddTicks(1830), new DateTime(2020, 7, 4, 15, 4, 13, 289, DateTimeKind.Local).AddTicks(3259), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 14, "", "", new DateTime(2019, 12, 10, 17, 27, 36, 978, DateTimeKind.Local).AddTicks(6882), new DateTime(2019, 9, 22, 21, 19, 38, 450, DateTimeKind.Local).AddTicks(8411), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 13, "", "", new DateTime(2019, 9, 6, 3, 36, 19, 107, DateTimeKind.Local).AddTicks(2188), new DateTime(2019, 12, 4, 14, 33, 14, 706, DateTimeKind.Local).AddTicks(4007), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 12, "", "", new DateTime(2019, 7, 29, 10, 54, 18, 820, DateTimeKind.Local).AddTicks(2075), new DateTime(2020, 3, 31, 22, 14, 24, 779, DateTimeKind.Local).AddTicks(2195), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 11, "", "", new DateTime(2020, 7, 16, 13, 27, 27, 108, DateTimeKind.Local).AddTicks(8541), new DateTime(2020, 5, 29, 9, 48, 15, 721, DateTimeKind.Local).AddTicks(6431), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 10, "", "", new DateTime(2020, 1, 15, 10, 24, 55, 522, DateTimeKind.Local).AddTicks(197), new DateTime(2019, 11, 22, 14, 21, 52, 156, DateTimeKind.Local).AddTicks(5629), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 9, "", "", new DateTime(2020, 1, 4, 23, 46, 35, 307, DateTimeKind.Local).AddTicks(2104), new DateTime(2020, 5, 20, 7, 30, 40, 554, DateTimeKind.Local).AddTicks(7016), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 7, "", "", new DateTime(2019, 11, 9, 15, 32, 1, 782, DateTimeKind.Local).AddTicks(5246), new DateTime(2020, 5, 19, 3, 11, 34, 358, DateTimeKind.Local).AddTicks(7861), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 6, "", "", new DateTime(2019, 11, 4, 15, 33, 37, 472, DateTimeKind.Local).AddTicks(45), new DateTime(2020, 2, 29, 1, 33, 41, 392, DateTimeKind.Local).AddTicks(7679), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 5, "", "", new DateTime(2019, 10, 27, 11, 31, 24, 299, DateTimeKind.Local).AddTicks(2441), new DateTime(2019, 10, 2, 22, 6, 43, 923, DateTimeKind.Local).AddTicks(3185), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 4, "", "", new DateTime(2020, 1, 2, 9, 0, 53, 371, DateTimeKind.Local).AddTicks(9584), new DateTime(2020, 2, 6, 13, 9, 23, 648, DateTimeKind.Local).AddTicks(8872), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 3, "", "", new DateTime(2019, 11, 30, 16, 49, 27, 360, DateTimeKind.Local).AddTicks(8155), new DateTime(2019, 8, 2, 0, 14, 53, 44, DateTimeKind.Local).AddTicks(9966), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 2, "", "", new DateTime(2019, 7, 30, 22, 7, 9, 326, DateTimeKind.Local).AddTicks(5651), new DateTime(2020, 6, 21, 10, 29, 17, 396, DateTimeKind.Local).AddTicks(6382), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 50, "", "", new DateTime(2019, 10, 6, 2, 49, 45, 9, DateTimeKind.Local).AddTicks(5113), new DateTime(2019, 10, 14, 10, 6, 10, 952, DateTimeKind.Local).AddTicks(3828), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 23, "", "", new DateTime(2019, 8, 15, 18, 16, 7, 189, DateTimeKind.Local).AddTicks(9687), new DateTime(2019, 10, 18, 17, 19, 41, 761, DateTimeKind.Local).AddTicks(4589), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 24, "", "", new DateTime(2020, 2, 11, 2, 17, 40, 846, DateTimeKind.Local).AddTicks(7025), new DateTime(2019, 9, 18, 4, 39, 54, 647, DateTimeKind.Local).AddTicks(2108), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 1, "", "", new DateTime(2020, 6, 6, 12, 38, 44, 355, DateTimeKind.Local).AddTicks(8648), new DateTime(2020, 1, 11, 17, 26, 18, 844, DateTimeKind.Local).AddTicks(3116), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 26, "", "", new DateTime(2020, 3, 14, 15, 20, 34, 36, DateTimeKind.Local).AddTicks(6447), new DateTime(2019, 11, 5, 18, 8, 49, 509, DateTimeKind.Local).AddTicks(1499), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 25, "", "", new DateTime(2019, 10, 10, 4, 56, 54, 825, DateTimeKind.Local).AddTicks(4661), new DateTime(2020, 6, 19, 14, 47, 1, 86, DateTimeKind.Local).AddTicks(2643), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 47, "", "", new DateTime(2019, 8, 20, 2, 39, 10, 229, DateTimeKind.Local).AddTicks(3201), new DateTime(2020, 1, 11, 2, 35, 45, 770, DateTimeKind.Local).AddTicks(8040), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 46, "", "", new DateTime(2019, 12, 17, 11, 13, 42, 771, DateTimeKind.Local).AddTicks(3925), new DateTime(2020, 5, 7, 4, 11, 28, 206, DateTimeKind.Local).AddTicks(1621), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 45, "", "", new DateTime(2020, 1, 1, 21, 22, 35, 441, DateTimeKind.Local).AddTicks(9297), new DateTime(2020, 1, 14, 20, 9, 11, 191, DateTimeKind.Local).AddTicks(3051), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 44, "", "", new DateTime(2019, 11, 27, 0, 22, 1, 860, DateTimeKind.Local).AddTicks(7821), new DateTime(2019, 12, 25, 7, 23, 36, 845, DateTimeKind.Local).AddTicks(2188), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 43, "", "", new DateTime(2019, 12, 25, 4, 12, 58, 564, DateTimeKind.Local).AddTicks(2220), new DateTime(2019, 12, 13, 12, 55, 45, 954, DateTimeKind.Local).AddTicks(7507), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 42, "", "", new DateTime(2019, 9, 27, 22, 40, 57, 301, DateTimeKind.Local).AddTicks(304), new DateTime(2020, 1, 25, 15, 57, 33, 14, DateTimeKind.Local).AddTicks(9245), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 41, "", "", new DateTime(2020, 1, 16, 22, 56, 40, 869, DateTimeKind.Local).AddTicks(2351), new DateTime(2019, 10, 12, 20, 26, 18, 782, DateTimeKind.Local).AddTicks(183), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 40, "", "", new DateTime(2019, 8, 12, 4, 46, 21, 442, DateTimeKind.Local).AddTicks(7887), new DateTime(2020, 6, 2, 15, 51, 22, 835, DateTimeKind.Local).AddTicks(7553), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 39, "", "", new DateTime(2020, 2, 21, 15, 20, 10, 483, DateTimeKind.Local).AddTicks(3233), new DateTime(2020, 3, 4, 15, 31, 2, 154, DateTimeKind.Local).AddTicks(1409), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 38, "", "", new DateTime(2020, 3, 9, 4, 8, 22, 31, DateTimeKind.Local).AddTicks(6088), new DateTime(2019, 8, 2, 23, 44, 17, 22, DateTimeKind.Local).AddTicks(6761), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 48, "", "", new DateTime(2020, 1, 3, 15, 55, 28, 328, DateTimeKind.Local).AddTicks(299), new DateTime(2020, 4, 13, 22, 14, 48, 905, DateTimeKind.Local).AddTicks(8943), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 36, "", "", new DateTime(2019, 8, 18, 18, 49, 18, 54, DateTimeKind.Local).AddTicks(6499), new DateTime(2020, 1, 30, 21, 20, 8, 643, DateTimeKind.Local).AddTicks(7052), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 27, "", "", new DateTime(2019, 12, 30, 15, 39, 25, 757, DateTimeKind.Local).AddTicks(3655), new DateTime(2020, 7, 11, 1, 40, 14, 624, DateTimeKind.Local).AddTicks(2139), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 37, "", "", new DateTime(2019, 8, 29, 9, 0, 12, 67, DateTimeKind.Local).AddTicks(348), new DateTime(2020, 4, 22, 14, 6, 23, 885, DateTimeKind.Local).AddTicks(4391), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 29, "", "", new DateTime(2020, 2, 9, 4, 42, 27, 542, DateTimeKind.Local).AddTicks(9560), new DateTime(2019, 10, 14, 20, 35, 36, 204, DateTimeKind.Local).AddTicks(5856), "", "", "La lutte contre toutes les formes de discrimination", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 30, "", "", new DateTime(2020, 5, 23, 14, 32, 24, 690, DateTimeKind.Local).AddTicks(4300), new DateTime(2020, 3, 2, 14, 52, 33, 463, DateTimeKind.Local).AddTicks(341), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 31, "", "", new DateTime(2019, 8, 6, 3, 2, 44, 114, DateTimeKind.Local).AddTicks(2608), new DateTime(2020, 3, 13, 21, 37, 48, 892, DateTimeKind.Local).AddTicks(938), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 28, "", "", new DateTime(2019, 12, 6, 7, 40, 54, 458, DateTimeKind.Local).AddTicks(1682), new DateTime(2019, 10, 23, 22, 41, 23, 937, DateTimeKind.Local).AddTicks(3342), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 33, "", "", new DateTime(2019, 10, 9, 0, 39, 33, 473, DateTimeKind.Local).AddTicks(9146), new DateTime(2020, 4, 30, 12, 26, 2, 945, DateTimeKind.Local).AddTicks(4005), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 34, "", "", new DateTime(2020, 7, 5, 12, 12, 50, 848, DateTimeKind.Local).AddTicks(5521), new DateTime(2019, 12, 19, 13, 15, 26, 57, DateTimeKind.Local).AddTicks(9187), "", "", "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 35, "", "", new DateTime(2020, 2, 18, 20, 12, 2, 534, DateTimeKind.Local).AddTicks(5009), new DateTime(2020, 3, 20, 18, 51, 3, 302, DateTimeKind.Local).AddTicks(8799), "", "", "le renforcement de la protection juridique des victimes des conflits armés", "", "" });

            migrationBuilder.InsertData(
                table: "Traites",
                columns: new[] { "Id", "AnalytiquePiece", "ConventionPiece", "DateRatification", "DateSignature", "Discours", "MiseOeuvrePiece", "Nom", "ObservationPiece", "RapportParallelePiece" },
                values: new object[] { 32, "", "", new DateTime(2020, 5, 17, 8, 43, 45, 153, DateTimeKind.Local).AddTicks(2012), new DateTime(2019, 12, 10, 3, 40, 52, 931, DateTimeKind.Local).AddTicks(3018), "", "", "Conseil consultatif de la famille et de l'enfance", "", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 65, new DateTime(2019, 9, 27, 19, 19, 38, 118, DateTimeKind.Local).AddTicks(1090), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 72, new DateTime(2019, 9, 5, 19, 11, 51, 671, DateTimeKind.Local).AddTicks(863), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 71, new DateTime(2020, 6, 28, 2, 47, 6, 403, DateTimeKind.Local).AddTicks(9704), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 70, new DateTime(2020, 4, 1, 16, 2, 9, 985, DateTimeKind.Local).AddTicks(1150), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 69, new DateTime(2020, 6, 1, 23, 28, 37, 650, DateTimeKind.Local).AddTicks(5297), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 68, new DateTime(2020, 2, 13, 20, 21, 14, 520, DateTimeKind.Local).AddTicks(9605), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 67, new DateTime(2020, 2, 22, 23, 11, 9, 87, DateTimeKind.Local).AddTicks(1519), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 66, new DateTime(2020, 5, 9, 17, 48, 19, 454, DateTimeKind.Local).AddTicks(6447), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 64, new DateTime(2020, 2, 17, 4, 16, 5, 276, DateTimeKind.Local).AddTicks(3866), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 53, new DateTime(2019, 9, 22, 16, 40, 39, 968, DateTimeKind.Local).AddTicks(2044), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 62, new DateTime(2019, 9, 14, 21, 11, 47, 218, DateTimeKind.Local).AddTicks(1578), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 61, new DateTime(2020, 4, 13, 9, 39, 48, 485, DateTimeKind.Local).AddTicks(8629), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 60, new DateTime(2019, 11, 24, 1, 15, 20, 999, DateTimeKind.Local).AddTicks(9286), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 59, new DateTime(2020, 5, 18, 11, 26, 30, 115, DateTimeKind.Local).AddTicks(1502), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 58, new DateTime(2020, 3, 14, 17, 15, 39, 541, DateTimeKind.Local).AddTicks(1368), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 57, new DateTime(2019, 8, 6, 17, 1, 14, 435, DateTimeKind.Local).AddTicks(8286), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 56, new DateTime(2020, 5, 19, 15, 47, 35, 748, DateTimeKind.Local).AddTicks(1843), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 55, new DateTime(2019, 10, 19, 20, 28, 22, 616, DateTimeKind.Local).AddTicks(2565), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 54, new DateTime(2019, 8, 12, 16, 11, 48, 63, DateTimeKind.Local).AddTicks(4979), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 73, new DateTime(2020, 1, 10, 23, 2, 28, 124, DateTimeKind.Local).AddTicks(4299), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 52, new DateTime(2020, 4, 13, 7, 14, 3, 599, DateTimeKind.Local).AddTicks(7783), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 63, new DateTime(2020, 1, 2, 17, 32, 40, 616, DateTimeKind.Local).AddTicks(1162), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 74, new DateTime(2020, 5, 3, 13, 55, 59, 825, DateTimeKind.Local).AddTicks(7385), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 85, new DateTime(2019, 11, 5, 9, 48, 58, 84, DateTimeKind.Local).AddTicks(5432), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 76, new DateTime(2019, 10, 11, 3, 55, 20, 484, DateTimeKind.Local).AddTicks(7336), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 98, new DateTime(2019, 7, 21, 15, 23, 37, 592, DateTimeKind.Local).AddTicks(426), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 51, new DateTime(2019, 11, 14, 15, 26, 1, 114, DateTimeKind.Local).AddTicks(769), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 97, new DateTime(2019, 11, 4, 1, 28, 29, 293, DateTimeKind.Local).AddTicks(4591), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 96, new DateTime(2019, 9, 17, 12, 21, 47, 947, DateTimeKind.Local).AddTicks(4862), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 95, new DateTime(2019, 12, 17, 7, 22, 30, 352, DateTimeKind.Local).AddTicks(8649), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 94, new DateTime(2020, 6, 30, 18, 4, 51, 98, DateTimeKind.Local).AddTicks(8931), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 93, new DateTime(2020, 5, 30, 1, 34, 24, 571, DateTimeKind.Local).AddTicks(9905), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 92, new DateTime(2019, 12, 14, 19, 57, 47, 724, DateTimeKind.Local).AddTicks(5774), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 91, new DateTime(2019, 8, 26, 22, 40, 22, 303, DateTimeKind.Local).AddTicks(2538), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 90, new DateTime(2020, 7, 17, 23, 23, 59, 985, DateTimeKind.Local).AddTicks(5340), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 75, new DateTime(2020, 3, 14, 0, 50, 20, 16, DateTimeKind.Local).AddTicks(5512), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 89, new DateTime(2020, 5, 16, 4, 36, 17, 294, DateTimeKind.Local).AddTicks(5301), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 87, new DateTime(2020, 6, 14, 12, 57, 35, 129, DateTimeKind.Local).AddTicks(2638), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 86, new DateTime(2019, 12, 27, 12, 46, 30, 176, DateTimeKind.Local).AddTicks(7627), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 84, new DateTime(2020, 7, 19, 20, 8, 35, 969, DateTimeKind.Local).AddTicks(6065), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 83, new DateTime(2019, 12, 2, 7, 55, 27, 579, DateTimeKind.Local).AddTicks(6538), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 82, new DateTime(2020, 7, 8, 12, 43, 7, 339, DateTimeKind.Local).AddTicks(1500), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 81, new DateTime(2020, 7, 20, 6, 14, 2, 454, DateTimeKind.Local).AddTicks(2944), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 80, new DateTime(2020, 4, 30, 23, 34, 40, 468, DateTimeKind.Local).AddTicks(9435), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 79, new DateTime(2020, 6, 2, 18, 53, 17, 133, DateTimeKind.Local).AddTicks(9555), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 78, new DateTime(2019, 11, 18, 5, 51, 39, 332, DateTimeKind.Local).AddTicks(5040), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 77, new DateTime(2019, 12, 5, 20, 35, 10, 228, DateTimeKind.Local).AddTicks(8591), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 88, new DateTime(2020, 5, 7, 15, 47, 49, 544, DateTimeKind.Local).AddTicks(4365), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 50, new DateTime(2020, 5, 19, 13, 13, 10, 513, DateTimeKind.Local).AddTicks(2083), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 26, new DateTime(2020, 6, 9, 22, 59, 4, 599, DateTimeKind.Local).AddTicks(2618), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 48, new DateTime(2020, 3, 18, 9, 23, 6, 605, DateTimeKind.Local).AddTicks(7734), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 20, new DateTime(2019, 7, 21, 6, 26, 10, 994, DateTimeKind.Local).AddTicks(7717), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 19, new DateTime(2020, 3, 25, 0, 28, 28, 663, DateTimeKind.Local).AddTicks(5361), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 18, new DateTime(2019, 9, 25, 14, 52, 34, 639, DateTimeKind.Local).AddTicks(7557), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 17, new DateTime(2020, 4, 25, 4, 44, 35, 22, DateTimeKind.Local).AddTicks(6357), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 16, new DateTime(2019, 12, 18, 21, 49, 12, 292, DateTimeKind.Local).AddTicks(2238), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 15, new DateTime(2020, 4, 27, 16, 41, 28, 774, DateTimeKind.Local).AddTicks(5369), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 14, new DateTime(2019, 8, 27, 22, 57, 39, 295, DateTimeKind.Local).AddTicks(1310), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 13, new DateTime(2020, 2, 1, 14, 26, 2, 464, DateTimeKind.Local).AddTicks(5527), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 12, new DateTime(2020, 7, 17, 10, 55, 42, 991, DateTimeKind.Local).AddTicks(9349), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 11, new DateTime(2019, 7, 23, 20, 33, 14, 603, DateTimeKind.Local).AddTicks(8759), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 10, new DateTime(2019, 12, 18, 4, 48, 2, 869, DateTimeKind.Local).AddTicks(7729), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 9, new DateTime(2020, 5, 7, 14, 39, 16, 701, DateTimeKind.Local).AddTicks(3944), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 8, new DateTime(2019, 12, 16, 0, 59, 40, 913, DateTimeKind.Local).AddTicks(217), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 7, new DateTime(2019, 10, 21, 14, 52, 18, 719, DateTimeKind.Local).AddTicks(8800), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 6, new DateTime(2020, 4, 22, 17, 2, 52, 17, DateTimeKind.Local).AddTicks(4858), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 5, new DateTime(2019, 12, 10, 10, 6, 34, 846, DateTimeKind.Local).AddTicks(8136), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 4, new DateTime(2020, 2, 21, 3, 55, 35, 24, DateTimeKind.Local).AddTicks(7108), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 3, new DateTime(2019, 8, 12, 5, 34, 6, 773, DateTimeKind.Local).AddTicks(7347), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 2, new DateTime(2019, 12, 31, 6, 39, 6, 116, DateTimeKind.Local).AddTicks(3535), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 1, new DateTime(2020, 2, 13, 13, 23, 17, 17, DateTimeKind.Local).AddTicks(6652), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 99, new DateTime(2020, 6, 9, 16, 48, 31, 416, DateTimeKind.Local).AddTicks(4395), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 21, new DateTime(2019, 9, 25, 16, 43, 14, 24, DateTimeKind.Local).AddTicks(8754), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 22, new DateTime(2020, 3, 13, 2, 58, 2, 468, DateTimeKind.Local).AddTicks(1009), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 23, new DateTime(2020, 5, 9, 10, 30, 2, 979, DateTimeKind.Local).AddTicks(4315), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 24, new DateTime(2019, 11, 9, 20, 1, 34, 671, DateTimeKind.Local).AddTicks(8645), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 47, new DateTime(2020, 4, 14, 10, 20, 40, 360, DateTimeKind.Local).AddTicks(9685), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 46, new DateTime(2020, 1, 8, 1, 59, 16, 588, DateTimeKind.Local).AddTicks(6224), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 45, new DateTime(2019, 9, 6, 8, 52, 31, 870, DateTimeKind.Local).AddTicks(3549), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 44, new DateTime(2019, 7, 24, 11, 26, 35, 443, DateTimeKind.Local).AddTicks(9571), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 43, new DateTime(2020, 2, 17, 5, 59, 59, 8, DateTimeKind.Local).AddTicks(1338), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 42, new DateTime(2019, 11, 8, 16, 2, 42, 78, DateTimeKind.Local).AddTicks(5842), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 41, new DateTime(2019, 8, 8, 21, 12, 20, 664, DateTimeKind.Local).AddTicks(6834), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 40, new DateTime(2020, 5, 8, 2, 37, 48, 734, DateTimeKind.Local).AddTicks(8705), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 39, new DateTime(2019, 8, 6, 10, 22, 43, 787, DateTimeKind.Local).AddTicks(6810), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 38, new DateTime(2019, 9, 8, 18, 43, 46, 887, DateTimeKind.Local).AddTicks(7552), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 49, new DateTime(2020, 6, 1, 8, 38, 58, 809, DateTimeKind.Local).AddTicks(5146), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 37, new DateTime(2019, 11, 25, 12, 46, 18, 529, DateTimeKind.Local).AddTicks(9703), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 35, new DateTime(2020, 4, 29, 11, 8, 43, 213, DateTimeKind.Local).AddTicks(7445), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 34, new DateTime(2019, 11, 17, 13, 20, 34, 484, DateTimeKind.Local).AddTicks(1321), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 33, new DateTime(2020, 4, 15, 11, 26, 1, 647, DateTimeKind.Local).AddTicks(542), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 32, new DateTime(2020, 1, 10, 11, 34, 46, 298, DateTimeKind.Local).AddTicks(8838), "", "", "", "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 31, new DateTime(2020, 6, 14, 16, 50, 0, 308, DateTimeKind.Local).AddTicks(7924), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 30, new DateTime(2020, 4, 20, 15, 49, 39, 471, DateTimeKind.Local).AddTicks(7394), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 29, new DateTime(2019, 7, 26, 5, 36, 15, 888, DateTimeKind.Local).AddTicks(3232), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 28, new DateTime(2020, 5, 23, 2, 3, 16, 529, DateTimeKind.Local).AddTicks(6688), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 27, new DateTime(2019, 7, 22, 10, 37, 41, 412, DateTimeKind.Local).AddTicks(3588), "", "", "", "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 25, new DateTime(2019, 9, 15, 10, 31, 29, 521, DateTimeKind.Local).AddTicks(303), "", "", "", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 36, new DateTime(2020, 4, 9, 17, 25, 47, 621, DateTimeKind.Local).AddTicks(7191), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Visites",
                columns: new[] { "Id", "Date", "Discours", "LienRapport", "LienUpload", "Mandat", "MiseOeuvrePiece" },
                values: new object[] { 100, new DateTime(2020, 2, 22, 1, 21, 6, 25, DateTimeKind.Local).AddTicks(3001), "", "", "", "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants", "" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 86, new DateTime(2020, 7, 21, 7, 39, 36, 101, DateTimeKind.Local).AddTicks(4561), new DateTime(2020, 7, 21, 11, 38, 30, 599, DateTimeKind.Local).AddTicks(6129), new DateTime(2020, 7, 20, 21, 23, 28, 113, DateTimeKind.Local).AddTicks(3029), 40, "", "http://océane.name", "eaque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 26, new DateTime(2020, 7, 21, 7, 13, 15, 702, DateTimeKind.Local).AddTicks(1738), new DateTime(2020, 7, 21, 11, 12, 44, 355, DateTimeKind.Local).AddTicks(7278), new DateTime(2020, 7, 21, 12, 49, 18, 399, DateTimeKind.Local).AddTicks(2186), 70, "", "https://romain.com", "dolores" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 90, new DateTime(2020, 7, 20, 20, 19, 44, 319, DateTimeKind.Local).AddTicks(198), new DateTime(2020, 7, 21, 5, 33, 2, 953, DateTimeKind.Local).AddTicks(469), new DateTime(2020, 7, 20, 20, 5, 3, 68, DateTimeKind.Local).AddTicks(6012), 69, "", "http://benjamin.org", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 59, new DateTime(2020, 7, 20, 22, 53, 52, 837, DateTimeKind.Local).AddTicks(3477), new DateTime(2020, 7, 21, 10, 52, 22, 168, DateTimeKind.Local).AddTicks(8605), new DateTime(2020, 7, 21, 5, 40, 46, 287, DateTimeKind.Local).AddTicks(7616), 68, "", "https://thomas.info", "quidem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 42, new DateTime(2020, 7, 20, 18, 29, 9, 891, DateTimeKind.Local).AddTicks(274), new DateTime(2020, 7, 21, 5, 15, 6, 571, DateTimeKind.Local).AddTicks(7557), new DateTime(2020, 7, 21, 7, 5, 54, 489, DateTimeKind.Local).AddTicks(2716), 68, "", "https://jeanne.fr", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 91, new DateTime(2020, 7, 20, 23, 56, 27, 383, DateTimeKind.Local).AddTicks(8886), new DateTime(2020, 7, 21, 5, 59, 35, 194, DateTimeKind.Local).AddTicks(7499), new DateTime(2020, 7, 21, 2, 10, 17, 439, DateTimeKind.Local).AddTicks(6347), 67, "", "http://mattéo.com", "explicabo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 19, new DateTime(2020, 7, 21, 5, 26, 23, 196, DateTimeKind.Local).AddTicks(2489), new DateTime(2020, 7, 20, 21, 13, 10, 919, DateTimeKind.Local).AddTicks(3293), new DateTime(2020, 7, 21, 15, 42, 21, 232, DateTimeKind.Local).AddTicks(1767), 65, "", "https://noah.name", "omnis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 30, new DateTime(2020, 7, 20, 19, 41, 13, 331, DateTimeKind.Local).AddTicks(9874), new DateTime(2020, 7, 21, 1, 58, 29, 709, DateTimeKind.Local).AddTicks(4797), new DateTime(2020, 7, 20, 19, 4, 19, 530, DateTimeKind.Local).AddTicks(8801), 62, "", "https://julien.info", "sit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 65, new DateTime(2020, 7, 21, 11, 15, 36, 623, DateTimeKind.Local).AddTicks(2563), new DateTime(2020, 7, 20, 23, 37, 30, 331, DateTimeKind.Local).AddTicks(5417), new DateTime(2020, 7, 21, 2, 28, 32, 599, DateTimeKind.Local).AddTicks(1995), 61, "", "http://camille.info", "assumenda" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 21, new DateTime(2020, 7, 21, 1, 59, 14, 29, DateTimeKind.Local).AddTicks(7564), new DateTime(2020, 7, 21, 14, 2, 34, 612, DateTimeKind.Local).AddTicks(2745), new DateTime(2020, 7, 20, 18, 0, 19, 784, DateTimeKind.Local).AddTicks(9572), 59, "", "http://noah.com", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 12, new DateTime(2020, 7, 21, 5, 9, 35, 997, DateTimeKind.Local).AddTicks(3452), new DateTime(2020, 7, 21, 14, 41, 43, 486, DateTimeKind.Local).AddTicks(1229), new DateTime(2020, 7, 21, 8, 46, 5, 839, DateTimeKind.Local).AddTicks(662), 59, "", "https://ethan.org", "commodi" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 60, new DateTime(2020, 7, 21, 12, 14, 6, 121, DateTimeKind.Local).AddTicks(2270), new DateTime(2020, 7, 20, 22, 19, 22, 106, DateTimeKind.Local).AddTicks(6429), new DateTime(2020, 7, 21, 14, 19, 59, 497, DateTimeKind.Local).AddTicks(5226), 58, "", "http://arthur.fr", "quas" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 72, new DateTime(2020, 7, 21, 2, 47, 35, 142, DateTimeKind.Local).AddTicks(5956), new DateTime(2020, 7, 21, 10, 16, 53, 115, DateTimeKind.Local).AddTicks(2372), new DateTime(2020, 7, 21, 16, 31, 54, 897, DateTimeKind.Local).AddTicks(6033), 70, "", "http://juliette.name", "recusandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 73, new DateTime(2020, 7, 21, 16, 19, 4, 36, DateTimeKind.Local).AddTicks(878), new DateTime(2020, 7, 20, 17, 21, 59, 61, DateTimeKind.Local).AddTicks(7623), new DateTime(2020, 7, 20, 19, 47, 33, 441, DateTimeKind.Local).AddTicks(8709), 57, "", "http://pauline.info", "reprehenderit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 78, new DateTime(2020, 7, 21, 12, 45, 59, 359, DateTimeKind.Local).AddTicks(8160), new DateTime(2020, 7, 21, 1, 11, 4, 768, DateTimeKind.Local).AddTicks(475), new DateTime(2020, 7, 21, 10, 13, 44, 424, DateTimeKind.Local).AddTicks(1277), 54, "", "https://lucie.fr", "aspernatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 29, new DateTime(2020, 7, 21, 0, 23, 10, 946, DateTimeKind.Local).AddTicks(1207), new DateTime(2020, 7, 21, 4, 23, 1, 492, DateTimeKind.Local).AddTicks(7364), new DateTime(2020, 7, 20, 21, 11, 17, 73, DateTimeKind.Local).AddTicks(9484), 54, "", "http://hugo.info", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 88, new DateTime(2020, 7, 21, 3, 31, 23, 41, DateTimeKind.Local).AddTicks(9096), new DateTime(2020, 7, 20, 23, 58, 15, 577, DateTimeKind.Local).AddTicks(9715), new DateTime(2020, 7, 21, 7, 55, 48, 641, DateTimeKind.Local).AddTicks(1176), 52, "", "http://lena.net", "sint" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 62, new DateTime(2020, 7, 21, 5, 20, 29, 508, DateTimeKind.Local).AddTicks(6618), new DateTime(2020, 7, 21, 16, 32, 42, 158, DateTimeKind.Local).AddTicks(3118), new DateTime(2020, 7, 21, 15, 23, 39, 402, DateTimeKind.Local).AddTicks(648), 51, "", "http://clément.eu", "cumque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 28, new DateTime(2020, 7, 21, 11, 25, 3, 670, DateTimeKind.Local).AddTicks(2981), new DateTime(2020, 7, 20, 19, 26, 19, 304, DateTimeKind.Local).AddTicks(1945), new DateTime(2020, 7, 21, 2, 32, 43, 483, DateTimeKind.Local).AddTicks(9246), 50, "", "http://juliette.net", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 25, new DateTime(2020, 7, 21, 2, 12, 55, 422, DateTimeKind.Local).AddTicks(5127), new DateTime(2020, 7, 20, 21, 49, 53, 708, DateTimeKind.Local).AddTicks(9924), new DateTime(2020, 7, 21, 12, 45, 35, 703, DateTimeKind.Local).AddTicks(148), 50, "", "http://lilou.org", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 61, new DateTime(2020, 7, 20, 21, 50, 13, 804, DateTimeKind.Local).AddTicks(3623), new DateTime(2020, 7, 20, 18, 34, 19, 52, DateTimeKind.Local).AddTicks(7070), new DateTime(2020, 7, 20, 16, 59, 13, 917, DateTimeKind.Local).AddTicks(7680), 47, "", "https://mathis.net", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 10, new DateTime(2020, 7, 21, 1, 41, 51, 210, DateTimeKind.Local).AddTicks(7814), new DateTime(2020, 7, 20, 20, 26, 34, 391, DateTimeKind.Local).AddTicks(7138), new DateTime(2020, 7, 20, 22, 50, 44, 951, DateTimeKind.Local).AddTicks(9993), 46, "", "http://clara.fr", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 3, new DateTime(2020, 7, 21, 10, 54, 52, 768, DateTimeKind.Local).AddTicks(1604), new DateTime(2020, 7, 20, 21, 53, 11, 503, DateTimeKind.Local).AddTicks(2436), new DateTime(2020, 7, 21, 6, 5, 5, 268, DateTimeKind.Local).AddTicks(2194), 46, "", "http://mohamed.eu", "explicabo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 52, new DateTime(2020, 7, 20, 21, 58, 45, 809, DateTimeKind.Local).AddTicks(8928), new DateTime(2020, 7, 21, 8, 55, 53, 560, DateTimeKind.Local).AddTicks(853), new DateTime(2020, 7, 20, 17, 17, 7, 757, DateTimeKind.Local).AddTicks(3464), 45, "", "https://théo.eu", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 94, new DateTime(2020, 7, 21, 12, 1, 16, 163, DateTimeKind.Local).AddTicks(1314), new DateTime(2020, 7, 21, 0, 11, 4, 297, DateTimeKind.Local).AddTicks(781), new DateTime(2020, 7, 21, 8, 24, 58, 112, DateTimeKind.Local).AddTicks(7002), 43, "", "http://mattéo.net", "repudiandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 95, new DateTime(2020, 7, 21, 7, 34, 29, 569, DateTimeKind.Local).AddTicks(421), new DateTime(2020, 7, 21, 5, 38, 58, 619, DateTimeKind.Local).AddTicks(2269), new DateTime(2020, 7, 21, 13, 14, 18, 111, DateTimeKind.Local).AddTicks(4524), 56, "", "http://pierre.com", "iste" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 36, new DateTime(2020, 7, 21, 7, 14, 47, 937, DateTimeKind.Local).AddTicks(306), new DateTime(2020, 7, 21, 2, 13, 19, 53, DateTimeKind.Local).AddTicks(3639), new DateTime(2020, 7, 21, 6, 19, 48, 127, DateTimeKind.Local).AddTicks(2085), 72, "", "http://lena.com", "accusantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 37, new DateTime(2020, 7, 21, 7, 56, 51, 207, DateTimeKind.Local).AddTicks(5204), new DateTime(2020, 7, 20, 22, 8, 6, 204, DateTimeKind.Local).AddTicks(3801), new DateTime(2020, 7, 20, 22, 55, 22, 470, DateTimeKind.Local).AddTicks(7525), 73, "", "http://gabriel.net", "placeat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 35, new DateTime(2020, 7, 21, 4, 43, 16, 552, DateTimeKind.Local).AddTicks(1733), new DateTime(2020, 7, 21, 11, 58, 19, 987, DateTimeKind.Local).AddTicks(1039), new DateTime(2020, 7, 21, 8, 51, 39, 472, DateTimeKind.Local).AddTicks(9573), 75, "", "https://mélissa.name", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 50, new DateTime(2020, 7, 20, 21, 41, 20, 408, DateTimeKind.Local).AddTicks(1867), new DateTime(2020, 7, 21, 13, 18, 18, 733, DateTimeKind.Local).AddTicks(6993), new DateTime(2020, 7, 20, 16, 47, 9, 171, DateTimeKind.Local).AddTicks(2320), 97, "", "https://mohamed.org", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 18, new DateTime(2020, 7, 21, 8, 5, 27, 710, DateTimeKind.Local).AddTicks(8013), new DateTime(2020, 7, 21, 9, 37, 39, 178, DateTimeKind.Local).AddTicks(4885), new DateTime(2020, 7, 21, 14, 18, 56, 336, DateTimeKind.Local).AddTicks(5222), 97, "", "http://maxence.name", "ipsa" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 55, new DateTime(2020, 7, 21, 3, 31, 18, 968, DateTimeKind.Local).AddTicks(9253), new DateTime(2020, 7, 21, 6, 15, 4, 545, DateTimeKind.Local).AddTicks(6909), new DateTime(2020, 7, 20, 23, 58, 23, 154, DateTimeKind.Local).AddTicks(4522), 96, "", "https://lilou.name", "ut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 84, new DateTime(2020, 7, 21, 9, 55, 46, 837, DateTimeKind.Local).AddTicks(113), new DateTime(2020, 7, 21, 9, 21, 42, 797, DateTimeKind.Local).AddTicks(4044), new DateTime(2020, 7, 21, 11, 41, 18, 30, DateTimeKind.Local).AddTicks(1147), 94, "", "http://maxence.info", "ipsam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 22, new DateTime(2020, 7, 21, 11, 57, 10, 260, DateTimeKind.Local).AddTicks(9747), new DateTime(2020, 7, 21, 8, 55, 1, 982, DateTimeKind.Local).AddTicks(9297), new DateTime(2020, 7, 21, 0, 4, 19, 873, DateTimeKind.Local).AddTicks(8347), 94, "", "https://anaïs.org", "amet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 2, new DateTime(2020, 7, 21, 4, 11, 54, 453, DateTimeKind.Local).AddTicks(2962), new DateTime(2020, 7, 20, 20, 48, 7, 261, DateTimeKind.Local).AddTicks(1665), new DateTime(2020, 7, 21, 0, 20, 52, 847, DateTimeKind.Local).AddTicks(5018), 94, "", "http://adrien.fr", "adipisci" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 82, new DateTime(2020, 7, 21, 2, 4, 31, 283, DateTimeKind.Local).AddTicks(1312), new DateTime(2020, 7, 20, 21, 54, 43, 784, DateTimeKind.Local).AddTicks(8970), new DateTime(2020, 7, 21, 7, 22, 48, 57, DateTimeKind.Local).AddTicks(93), 93, "", "https://rayan.info", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 100, new DateTime(2020, 7, 21, 10, 57, 14, 348, DateTimeKind.Local).AddTicks(4826), new DateTime(2020, 7, 21, 9, 1, 6, 174, DateTimeKind.Local).AddTicks(4475), new DateTime(2020, 7, 20, 16, 54, 6, 122, DateTimeKind.Local).AddTicks(9212), 91, "", "http://alice.net", "non" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 93, new DateTime(2020, 7, 20, 23, 22, 26, 591, DateTimeKind.Local).AddTicks(1085), new DateTime(2020, 7, 21, 0, 20, 44, 254, DateTimeKind.Local).AddTicks(6181), new DateTime(2020, 7, 21, 12, 26, 49, 307, DateTimeKind.Local).AddTicks(4168), 91, "", "http://nathan.info", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 31, new DateTime(2020, 7, 21, 3, 35, 2, 918, DateTimeKind.Local).AddTicks(5001), new DateTime(2020, 7, 20, 19, 44, 25, 486, DateTimeKind.Local).AddTicks(127), new DateTime(2020, 7, 21, 10, 24, 32, 867, DateTimeKind.Local).AddTicks(5622), 89, "", "https://clément.eu", "est" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 49, new DateTime(2020, 7, 20, 19, 17, 15, 560, DateTimeKind.Local).AddTicks(6385), new DateTime(2020, 7, 21, 0, 17, 1, 294, DateTimeKind.Local).AddTicks(1123), new DateTime(2020, 7, 21, 8, 17, 10, 194, DateTimeKind.Local).AddTicks(5142), 88, "", "http://julie.info", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 39, new DateTime(2020, 7, 21, 14, 56, 38, 360, DateTimeKind.Local).AddTicks(4079), new DateTime(2020, 7, 21, 2, 36, 27, 445, DateTimeKind.Local).AddTicks(8539), new DateTime(2020, 7, 20, 17, 27, 33, 748, DateTimeKind.Local).AddTicks(5935), 88, "", "https://zoe.com", "reiciendis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 16, new DateTime(2020, 7, 21, 13, 49, 30, 465, DateTimeKind.Local).AddTicks(4844), new DateTime(2020, 7, 20, 17, 12, 49, 154, DateTimeKind.Local).AddTicks(4647), new DateTime(2020, 7, 21, 2, 21, 5, 151, DateTimeKind.Local).AddTicks(5491), 88, "", "http://noémie.fr", "veniam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 81, new DateTime(2020, 7, 21, 7, 21, 15, 474, DateTimeKind.Local).AddTicks(9641), new DateTime(2020, 7, 21, 3, 21, 8, 107, DateTimeKind.Local).AddTicks(4399), new DateTime(2020, 7, 21, 7, 32, 6, 741, DateTimeKind.Local).AddTicks(2387), 87, "", "http://pauline.name", "eius" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 67, new DateTime(2020, 7, 21, 10, 14, 51, 974, DateTimeKind.Local).AddTicks(5199), new DateTime(2020, 7, 20, 20, 23, 23, 742, DateTimeKind.Local).AddTicks(9418), new DateTime(2020, 7, 21, 14, 32, 15, 437, DateTimeKind.Local).AddTicks(918), 87, "", "https://pierre.net", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 68, new DateTime(2020, 7, 20, 23, 1, 58, 720, DateTimeKind.Local).AddTicks(9539), new DateTime(2020, 7, 20, 19, 26, 48, 424, DateTimeKind.Local).AddTicks(8516), new DateTime(2020, 7, 21, 11, 31, 22, 732, DateTimeKind.Local).AddTicks(4105), 86, "", "https://pauline.org", "cum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 1, new DateTime(2020, 7, 20, 21, 32, 32, 638, DateTimeKind.Local).AddTicks(3860), new DateTime(2020, 7, 20, 20, 44, 49, 61, DateTimeKind.Local).AddTicks(2366), new DateTime(2020, 7, 21, 11, 3, 34, 820, DateTimeKind.Local).AddTicks(1954), 86, "", "http://mélissa.fr", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 40, new DateTime(2020, 7, 20, 22, 15, 42, 751, DateTimeKind.Local).AddTicks(4703), new DateTime(2020, 7, 20, 22, 43, 8, 129, DateTimeKind.Local).AddTicks(2704), new DateTime(2020, 7, 20, 22, 20, 57, 178, DateTimeKind.Local).AddTicks(509), 85, "", "http://louise.net", "cumque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 5, new DateTime(2020, 7, 20, 17, 12, 34, 271, DateTimeKind.Local).AddTicks(7051), new DateTime(2020, 7, 21, 5, 42, 9, 3, DateTimeKind.Local).AddTicks(2395), new DateTime(2020, 7, 21, 12, 30, 7, 213, DateTimeKind.Local).AddTicks(5103), 85, "", "http://thomas.name", "aut" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 46, new DateTime(2020, 7, 21, 1, 45, 9, 938, DateTimeKind.Local).AddTicks(7532), new DateTime(2020, 7, 20, 23, 59, 23, 712, DateTimeKind.Local).AddTicks(5823), new DateTime(2020, 7, 21, 6, 54, 22, 979, DateTimeKind.Local).AddTicks(6319), 83, "", "http://manon.org", "officia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 17, new DateTime(2020, 7, 21, 6, 29, 18, 83, DateTimeKind.Local).AddTicks(3449), new DateTime(2020, 7, 21, 0, 23, 48, 63, DateTimeKind.Local).AddTicks(7222), new DateTime(2020, 7, 21, 3, 47, 59, 164, DateTimeKind.Local).AddTicks(1661), 83, "", "http://noémie.name", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 63, new DateTime(2020, 7, 21, 5, 58, 45, 57, DateTimeKind.Local).AddTicks(6348), new DateTime(2020, 7, 21, 5, 50, 53, 769, DateTimeKind.Local).AddTicks(232), new DateTime(2020, 7, 21, 11, 29, 14, 103, DateTimeKind.Local).AddTicks(2606), 82, "", "https://valentin.info", "placeat" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 77, new DateTime(2020, 7, 21, 6, 6, 44, 374, DateTimeKind.Local).AddTicks(6226), new DateTime(2020, 7, 20, 17, 52, 22, 128, DateTimeKind.Local).AddTicks(9079), new DateTime(2020, 7, 21, 5, 7, 0, 310, DateTimeKind.Local).AddTicks(1363), 78, "", "https://océane.org", "nemo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 34, new DateTime(2020, 7, 20, 22, 11, 27, 147, DateTimeKind.Local).AddTicks(7456), new DateTime(2020, 7, 21, 8, 4, 14, 783, DateTimeKind.Local).AddTicks(7703), new DateTime(2020, 7, 21, 15, 15, 38, 37, DateTimeKind.Local).AddTicks(3964), 76, "", "https://léa.net", "rerum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 32, new DateTime(2020, 7, 21, 12, 36, 41, 585, DateTimeKind.Local).AddTicks(9014), new DateTime(2020, 7, 21, 9, 5, 58, 45, DateTimeKind.Local).AddTicks(3026), new DateTime(2020, 7, 21, 9, 2, 52, 770, DateTimeKind.Local).AddTicks(1063), 76, "", "https://adrien.eu", "temporibus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 54, new DateTime(2020, 7, 20, 18, 46, 43, 836, DateTimeKind.Local).AddTicks(3076), new DateTime(2020, 7, 20, 22, 52, 33, 902, DateTimeKind.Local).AddTicks(355), new DateTime(2020, 7, 21, 15, 11, 57, 845, DateTimeKind.Local).AddTicks(4454), 42, "", "http://adrien.name", "veritatis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 44, new DateTime(2020, 7, 21, 1, 4, 22, 385, DateTimeKind.Local).AddTicks(9707), new DateTime(2020, 7, 21, 6, 6, 33, 11, DateTimeKind.Local).AddTicks(4368), new DateTime(2020, 7, 20, 21, 14, 7, 525, DateTimeKind.Local).AddTicks(2720), 42, "", "https://manon.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 83, new DateTime(2020, 7, 20, 18, 13, 21, 80, DateTimeKind.Local).AddTicks(3986), new DateTime(2020, 7, 21, 1, 11, 0, 326, DateTimeKind.Local).AddTicks(3836), new DateTime(2020, 7, 21, 6, 27, 5, 554, DateTimeKind.Local).AddTicks(5650), 100, "", "https://louis.name", "distinctio" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 99, new DateTime(2020, 7, 21, 12, 34, 20, 368, DateTimeKind.Local).AddTicks(9801), new DateTime(2020, 7, 20, 20, 51, 22, 184, DateTimeKind.Local).AddTicks(2266), new DateTime(2020, 7, 21, 7, 49, 58, 793, DateTimeKind.Local).AddTicks(9653), 39, "", "http://yanis.com", "iste" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 85, new DateTime(2020, 7, 20, 19, 41, 8, 682, DateTimeKind.Local).AddTicks(7820), new DateTime(2020, 7, 21, 4, 57, 45, 750, DateTimeKind.Local).AddTicks(9371), new DateTime(2020, 7, 20, 20, 46, 13, 382, DateTimeKind.Local).AddTicks(250), 21, "", "http://camille.fr", "laudantium" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 48, new DateTime(2020, 7, 20, 20, 2, 58, 169, DateTimeKind.Local).AddTicks(3740), new DateTime(2020, 7, 21, 2, 43, 49, 275, DateTimeKind.Local).AddTicks(2223), new DateTime(2020, 7, 21, 15, 5, 58, 159, DateTimeKind.Local).AddTicks(9290), 20, "", "http://maxime.com", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 69, new DateTime(2020, 7, 21, 14, 52, 51, 740, DateTimeKind.Local).AddTicks(5570), new DateTime(2020, 7, 20, 20, 53, 57, 5, DateTimeKind.Local).AddTicks(6336), new DateTime(2020, 7, 21, 5, 20, 46, 814, DateTimeKind.Local).AddTicks(4318), 19, "", "https://elisa.fr", "hic" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 87, new DateTime(2020, 7, 21, 8, 30, 6, 717, DateTimeKind.Local).AddTicks(9771), new DateTime(2020, 7, 21, 14, 35, 12, 268, DateTimeKind.Local).AddTicks(3729), new DateTime(2020, 7, 20, 21, 22, 33, 471, DateTimeKind.Local).AddTicks(8841), 13, "", "https://lena.info", "labore" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 51, new DateTime(2020, 7, 21, 10, 17, 36, 217, DateTimeKind.Local).AddTicks(2536), new DateTime(2020, 7, 20, 22, 6, 45, 381, DateTimeKind.Local).AddTicks(2553), new DateTime(2020, 7, 21, 2, 29, 52, 328, DateTimeKind.Local).AddTicks(4245), 100, "", "https://lou.fr", "consequatur" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 15, new DateTime(2020, 7, 21, 12, 23, 48, 285, DateTimeKind.Local).AddTicks(2395), new DateTime(2020, 7, 21, 7, 43, 23, 371, DateTimeKind.Local).AddTicks(2617), new DateTime(2020, 7, 21, 9, 56, 31, 110, DateTimeKind.Local).AddTicks(8010), 12, "", "https://quentin.info", "deleniti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 89, new DateTime(2020, 7, 20, 23, 21, 46, 683, DateTimeKind.Local).AddTicks(2310), new DateTime(2020, 7, 20, 20, 12, 37, 555, DateTimeKind.Local).AddTicks(1249), new DateTime(2020, 7, 21, 6, 44, 18, 674, DateTimeKind.Local).AddTicks(2087), 11, "", "https://romain.net", "debitis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 33, new DateTime(2020, 7, 20, 23, 15, 32, 556, DateTimeKind.Local).AddTicks(9747), new DateTime(2020, 7, 21, 16, 8, 16, 575, DateTimeKind.Local).AddTicks(2343), new DateTime(2020, 7, 20, 23, 23, 30, 528, DateTimeKind.Local).AddTicks(8790), 11, "", "https://lou.eu", "officiis" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 80, new DateTime(2020, 7, 21, 10, 32, 0, 960, DateTimeKind.Local).AddTicks(1357), new DateTime(2020, 7, 21, 6, 39, 35, 309, DateTimeKind.Local).AddTicks(8418), new DateTime(2020, 7, 21, 6, 24, 3, 434, DateTimeKind.Local).AddTicks(3094), 23, "", "http://alexandre.eu", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 23, new DateTime(2020, 7, 20, 18, 10, 13, 115, DateTimeKind.Local).AddTicks(4865), new DateTime(2020, 7, 21, 7, 40, 35, 600, DateTimeKind.Local).AddTicks(6427), new DateTime(2020, 7, 21, 13, 51, 4, 504, DateTimeKind.Local).AddTicks(3036), 11, "", "https://axel.fr", "dolor" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 97, new DateTime(2020, 7, 20, 23, 36, 22, 523, DateTimeKind.Local).AddTicks(1937), new DateTime(2020, 7, 21, 0, 42, 55, 794, DateTimeKind.Local).AddTicks(1943), new DateTime(2020, 7, 20, 17, 17, 8, 9, DateTimeKind.Local).AddTicks(5115), 6, "", "http://théo.fr", "odit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 56, new DateTime(2020, 7, 21, 0, 20, 1, 293, DateTimeKind.Local).AddTicks(8256), new DateTime(2020, 7, 21, 13, 33, 6, 962, DateTimeKind.Local).AddTicks(1147), new DateTime(2020, 7, 20, 21, 6, 4, 642, DateTimeKind.Local).AddTicks(7174), 5, "", "http://sacha.org", "quo" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 43, new DateTime(2020, 7, 20, 19, 25, 58, 903, DateTimeKind.Local).AddTicks(8062), new DateTime(2020, 7, 21, 6, 53, 12, 515, DateTimeKind.Local).AddTicks(8200), new DateTime(2020, 7, 21, 3, 27, 38, 806, DateTimeKind.Local).AddTicks(6526), 5, "", "http://maëlle.com", "minima" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 57, new DateTime(2020, 7, 21, 2, 42, 9, 422, DateTimeKind.Local).AddTicks(9169), new DateTime(2020, 7, 21, 9, 1, 17, 51, DateTimeKind.Local).AddTicks(8275), new DateTime(2020, 7, 21, 6, 2, 56, 210, DateTimeKind.Local).AddTicks(7304), 4, "", "https://maëlys.net", "eos" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 41, new DateTime(2020, 7, 21, 14, 54, 53, 109, DateTimeKind.Local).AddTicks(3325), new DateTime(2020, 7, 20, 21, 14, 53, 461, DateTimeKind.Local).AddTicks(7148), new DateTime(2020, 7, 21, 14, 45, 32, 787, DateTimeKind.Local).AddTicks(4890), 4, "", "http://jade.eu", "tempora" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 9, new DateTime(2020, 7, 21, 14, 23, 22, 488, DateTimeKind.Local).AddTicks(8135), new DateTime(2020, 7, 20, 21, 40, 59, 965, DateTimeKind.Local).AddTicks(8376), new DateTime(2020, 7, 21, 1, 55, 1, 833, DateTimeKind.Local).AddTicks(8066), 4, "", "https://romain.info", "mollitia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 7, new DateTime(2020, 7, 21, 10, 56, 44, 142, DateTimeKind.Local).AddTicks(817), new DateTime(2020, 7, 21, 16, 23, 46, 739, DateTimeKind.Local).AddTicks(4198), new DateTime(2020, 7, 21, 2, 17, 49, 489, DateTimeKind.Local).AddTicks(583), 3, "", "https://laura.name", "natus" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 6, new DateTime(2020, 7, 20, 19, 46, 19, 892, DateTimeKind.Local).AddTicks(3670), new DateTime(2020, 7, 20, 20, 59, 8, 975, DateTimeKind.Local).AddTicks(5720), new DateTime(2020, 7, 21, 11, 11, 5, 476, DateTimeKind.Local).AddTicks(890), 1, "", "http://mathis.eu", "ea" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 64, new DateTime(2020, 7, 20, 16, 44, 50, 423, DateTimeKind.Local).AddTicks(3345), new DateTime(2020, 7, 20, 17, 57, 12, 236, DateTimeKind.Local).AddTicks(9630), new DateTime(2020, 7, 21, 13, 50, 28, 624, DateTimeKind.Local).AddTicks(3939), 7, "", "https://pauline.name", "eveniet" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 13, new DateTime(2020, 7, 21, 12, 23, 16, 274, DateTimeKind.Local).AddTicks(121), new DateTime(2020, 7, 20, 20, 51, 31, 548, DateTimeKind.Local).AddTicks(8929), new DateTime(2020, 7, 21, 0, 36, 47, 42, DateTimeKind.Local).AddTicks(7610), 24, "", "https://justine.com", "recusandae" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 74, new DateTime(2020, 7, 21, 15, 50, 59, 609, DateTimeKind.Local).AddTicks(8246), new DateTime(2020, 7, 21, 13, 59, 28, 7, DateTimeKind.Local).AddTicks(9770), new DateTime(2020, 7, 21, 10, 46, 24, 68, DateTimeKind.Local).AddTicks(3500), 12, "", "http://julien.eu", "atque" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 92, new DateTime(2020, 7, 21, 1, 52, 3, 397, DateTimeKind.Local).AddTicks(7358), new DateTime(2020, 7, 20, 22, 42, 59, 923, DateTimeKind.Local).AddTicks(7936), new DateTime(2020, 7, 21, 10, 13, 47, 270, DateTimeKind.Local).AddTicks(9585), 25, "", "http://chloé.com", "expedita" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 66, new DateTime(2020, 7, 20, 23, 41, 33, 130, DateTimeKind.Local).AddTicks(9547), new DateTime(2020, 7, 21, 12, 49, 45, 713, DateTimeKind.Local).AddTicks(4063), new DateTime(2020, 7, 21, 16, 11, 5, 148, DateTimeKind.Local).AddTicks(3560), 39, "", "http://sarah.eu", "provident" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 45, new DateTime(2020, 7, 20, 22, 40, 53, 731, DateTimeKind.Local).AddTicks(5605), new DateTime(2020, 7, 21, 4, 2, 51, 91, DateTimeKind.Local).AddTicks(9301), new DateTime(2020, 7, 21, 5, 57, 8, 986, DateTimeKind.Local).AddTicks(2995), 39, "", "http://mael.com", "veniam" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 53, new DateTime(2020, 7, 20, 19, 25, 23, 14, DateTimeKind.Local).AddTicks(6701), new DateTime(2020, 7, 21, 11, 2, 28, 837, DateTimeKind.Local).AddTicks(4263), new DateTime(2020, 7, 20, 18, 24, 16, 30, DateTimeKind.Local).AddTicks(2955), 25, "", "http://romain.eu", "quia" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 14, new DateTime(2020, 7, 21, 15, 27, 14, 364, DateTimeKind.Local).AddTicks(1440), new DateTime(2020, 7, 20, 22, 57, 30, 183, DateTimeKind.Local).AddTicks(620), new DateTime(2020, 7, 20, 23, 14, 0, 133, DateTimeKind.Local).AddTicks(2360), 39, "", "https://julien.net", "velit" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 24, new DateTime(2020, 7, 21, 8, 50, 53, 971, DateTimeKind.Local).AddTicks(5335), new DateTime(2020, 7, 20, 20, 22, 13, 769, DateTimeKind.Local).AddTicks(7799), new DateTime(2020, 7, 20, 23, 42, 52, 108, DateTimeKind.Local).AddTicks(5534), 36, "", "https://lisa.org", "earum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 8, new DateTime(2020, 7, 21, 9, 42, 41, 665, DateTimeKind.Local).AddTicks(1170), new DateTime(2020, 7, 20, 23, 21, 27, 611, DateTimeKind.Local).AddTicks(8356), new DateTime(2020, 7, 21, 1, 12, 30, 309, DateTimeKind.Local).AddTicks(4767), 36, "", "https://ambre.fr", "voluptates" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 71, new DateTime(2020, 7, 21, 8, 35, 40, 603, DateTimeKind.Local).AddTicks(8071), new DateTime(2020, 7, 21, 2, 13, 47, 695, DateTimeKind.Local).AddTicks(5295), new DateTime(2020, 7, 21, 12, 47, 31, 349, DateTimeKind.Local).AddTicks(1329), 35, "", "https://eva.eu", "fuga" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 98, new DateTime(2020, 7, 21, 8, 21, 57, 102, DateTimeKind.Local).AddTicks(1196), new DateTime(2020, 7, 21, 4, 12, 17, 880, DateTimeKind.Local).AddTicks(9277), new DateTime(2020, 7, 21, 8, 1, 30, 457, DateTimeKind.Local).AddTicks(2757), 34, "", "http://kylian.eu", "eum" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 96, new DateTime(2020, 7, 21, 4, 11, 10, 356, DateTimeKind.Local).AddTicks(5962), new DateTime(2020, 7, 21, 14, 56, 15, 786, DateTimeKind.Local).AddTicks(8682), new DateTime(2020, 7, 21, 5, 38, 1, 830, DateTimeKind.Local).AddTicks(7675), 34, "", "http://lucas.org", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 27, new DateTime(2020, 7, 20, 19, 26, 8, 852, DateTimeKind.Local).AddTicks(9460), new DateTime(2020, 7, 21, 11, 1, 56, 376, DateTimeKind.Local).AddTicks(4687), new DateTime(2020, 7, 21, 12, 27, 40, 436, DateTimeKind.Local).AddTicks(7618), 39, "", "http://alice.name", "dolorem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 70, new DateTime(2020, 7, 21, 15, 16, 21, 620, DateTimeKind.Local).AddTicks(7867), new DateTime(2020, 7, 20, 22, 40, 36, 122, DateTimeKind.Local).AddTicks(7346), new DateTime(2020, 7, 21, 3, 17, 40, 665, DateTimeKind.Local).AddTicks(7633), 33, "", "https://camille.net", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 11, new DateTime(2020, 7, 20, 19, 52, 12, 370, DateTimeKind.Local).AddTicks(5152), new DateTime(2020, 7, 21, 13, 39, 15, 862, DateTimeKind.Local).AddTicks(1850), new DateTime(2020, 7, 21, 14, 25, 20, 207, DateTimeKind.Local).AddTicks(9656), 33, "", "https://kylian.name", "qui" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 58, new DateTime(2020, 7, 21, 16, 10, 34, 858, DateTimeKind.Local).AddTicks(3818), new DateTime(2020, 7, 21, 1, 0, 50, 932, DateTimeKind.Local).AddTicks(8987), new DateTime(2020, 7, 21, 4, 35, 26, 700, DateTimeKind.Local).AddTicks(2826), 32, "", "https://romain.info", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 20, new DateTime(2020, 7, 20, 18, 6, 28, 658, DateTimeKind.Local).AddTicks(7878), new DateTime(2020, 7, 20, 17, 50, 6, 860, DateTimeKind.Local).AddTicks(9755), new DateTime(2020, 7, 21, 15, 21, 46, 331, DateTimeKind.Local).AddTicks(959), 31, "", "https://lisa.net", "enim" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 75, new DateTime(2020, 7, 21, 11, 40, 27, 459, DateTimeKind.Local).AddTicks(8567), new DateTime(2020, 7, 20, 20, 34, 24, 379, DateTimeKind.Local).AddTicks(6854), new DateTime(2020, 7, 21, 0, 15, 34, 764, DateTimeKind.Local).AddTicks(4825), 29, "", "http://hugo.fr", "et" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 38, new DateTime(2020, 7, 20, 17, 8, 25, 196, DateTimeKind.Local).AddTicks(6972), new DateTime(2020, 7, 20, 19, 2, 14, 461, DateTimeKind.Local).AddTicks(2886), new DateTime(2020, 7, 21, 9, 26, 50, 432, DateTimeKind.Local).AddTicks(5206), 29, "", "http://maxence.eu", "voluptatem" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 76, new DateTime(2020, 7, 21, 12, 35, 52, 967, DateTimeKind.Local).AddTicks(8782), new DateTime(2020, 7, 21, 6, 58, 59, 583, DateTimeKind.Local).AddTicks(9255), new DateTime(2020, 7, 21, 2, 26, 55, 746, DateTimeKind.Local).AddTicks(2884), 28, "", "http://jules.net", "unde" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 4, new DateTime(2020, 7, 20, 17, 7, 2, 599, DateTimeKind.Local).AddTicks(9492), new DateTime(2020, 7, 20, 20, 5, 47, 883, DateTimeKind.Local).AddTicks(3620), new DateTime(2020, 7, 21, 3, 4, 26, 321, DateTimeKind.Local).AddTicks(5426), 27, "", "https://maeva.org", "corrupti" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 47, new DateTime(2020, 7, 21, 6, 29, 56, 238, DateTimeKind.Local).AddTicks(7684), new DateTime(2020, 7, 21, 15, 39, 47, 680, DateTimeKind.Local).AddTicks(9600), new DateTime(2020, 7, 21, 1, 33, 44, 322, DateTimeKind.Local).AddTicks(8062), 26, "", "http://quentin.info", "sapiente" });

            migrationBuilder.InsertData(
                table: "Rapports",
                columns: new[] { "Id", "DateDernierRapport", "DateObservation", "DateProchaineRapport", "IdTraite", "PieceJointe", "Reference", "Titre" },
                values: new object[] { 79, new DateTime(2020, 7, 21, 7, 32, 42, 803, DateTimeKind.Local).AddTicks(3084), new DateTime(2020, 7, 21, 4, 29, 40, 205, DateTimeKind.Local).AddTicks(8638), new DateTime(2020, 7, 21, 8, 24, 44, 616, DateTimeKind.Local).AddTicks(6343), 34, "", "https://mattéo.fr", "illo" });

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
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 2, "2.3.8.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 2, 7, null, null, 4, 1, 10, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 33, "3.7.9.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 18, 3, null, 1, 1, 4, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 30, "8.3.9.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 7, null, 5, 4, 4, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 23, "9.5.2.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 84, 6, null, null, 4, 4, 9, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 11, "0.0.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 4, null, null, 3, 4, 7, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 8, "0.0.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 3, null, null, 4, 4, 4, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 7, "7.0.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 7, 1, null, 1, 4, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 6, "2.0.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 59, 1, null, 1, 1, 4, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 4, "8.7.7.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 81, 3, 7, null, 2, 4, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 96, "7.6.2.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 37, 2, null, 1, 3, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 93, "0.9.2.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 12, 6, null, 1, 3, 10, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 66, "3.2.3.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 1, null, 6, 1, 10, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 60, "3.9.8.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 6, null, 5, 3, 10, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 56, "8.2.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 3, null, null, 2, 10, 9, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 50, "4.5.4.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 3, null, null, 1, 10, 2, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 42, "5.9.6.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 20, 4, null, 4, 4, 10, null, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 40, "6.5.6.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 35, 2, 10, null, 1, 10, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 32, "1.2.7.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 75, 3, null, null, 3, 10, 2, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 25, "0.8.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 2, 5, null, 4, 10, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 22, "1.8.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 45, 7, 4, null, 1, 10, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 92, "6.2.4.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 53, 1, null, null, 4, 9, 1, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 81, "9.5.2.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 7, null, 6, 2, 9, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 49, "7.1.1.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 4, 5, null, 4, 4, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 69, "8.6.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 4, null, 3, 4, 4, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 74, "3.2.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 7, null, null, 3, 4, 8, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 83, "6.1.4.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 50, 7, null, null, 3, 4, 2, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 78, "6.6.6.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 3, null, 6, 3, 6, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 70, "9.4.3.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 8, 5, 10, null, 3, 6, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 65, "0.8.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 1, null, null, 1, 6, 4, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 63, "9.1.6.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 1, null, 5, 4, 6, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 36, "0.4.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 43, 4, null, 4, 1, 6, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 12, "6.9.4.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 4, null, 3, 3, 6, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 10, "8.5.6.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 55, 5, 1, null, 2, 6, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 89, "1.5.3.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 33, 7, null, null, 3, 5, 4, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 84, "4.9.1.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 16, 1, null, 1, 1, 5, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 73, "9.1.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 28, 3, 9, null, 1, 5, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 76, "7.6.2.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 73, 4, 10, null, 2, 9, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 61, "6.0.5.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 6, 2, null, 1, 5, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 52, "2.9.1.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 62, 5, 8, null, 4, 5, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 43, "0.8.6.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 0, 1, 1, null, 4, 5, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 41, "3.8.5.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 70, 1, null, null, 4, 5, 7, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 28, "1.5.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 74, 5, 4, null, 4, 5, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 18, "8.6.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 1, null, 3, 4, 5, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 13, "1.5.2.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 44, 5, 3, null, 1, 5, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 3, "4.2.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 48, 6, null, 1, 1, 5, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 1, "8.0.7.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 1, 3, null, 3, 5, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 95, "4.2.7.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 54, 1, null, null, 4, 4, 2, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 91, "4.4.3.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 1, 3, null, 2, 4, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 57, "7.1.8.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 49, 2, null, 3, 4, 5, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 72, "6.8.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 5, 5, null, 2, 2, 9, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 87, "9.3.3.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 5, null, 1, 3, 6, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 59, "4.6.0.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 22, 3, null, null, 4, 9, 8, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 86, "0.9.2.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 5, null, null, 2, 3, 5, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 85, "0.6.1.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 49, 7, 2, null, 2, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 64, "7.0.6.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 30, 1, 2, null, 2, 3, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 27, "3.0.8.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 7, null, 1, 2, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 19, "3.7.8.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 45, 5, 9, null, 2, 3, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 14, "8.1.4.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 71, 4, null, null, 1, 3, 6, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 99, "7.4.2.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 95, 6, null, 5, 3, 2, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 54, "1.9.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 87, 5, null, 1, 1, 2, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 38, "0.7.3.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 1, 4, null, null, 1, 2, 5, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 35, "5.8.6.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 72, 4, null, null, 1, 2, 10, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 17, "3.6.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 42, 7, null, null, 3, 2, 9, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 9, "5.4.2.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 7, null, 4, 2, 2, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 5, "2.7.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 80, 6, null, null, 3, 2, 9, "Examen périodique universal", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 88, "4.2.1.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 57, 7, 4, null, 4, 1, null, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 82, "1.7.8.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 91, 5, 8, null, 2, 1, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 79, "4.5.0.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 21, 7, 7, null, 3, 1, null, "Procédure spéciale", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 77, "5.5.9.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 4, null, null, 2, 1, 9, "Organes de traités", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 67, "6.6.1.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 63, 7, 9, null, 2, 1, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 62, "7.1.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 13, 5, null, null, 4, 1, 6, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 47, "2.0.3.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 64, 4, null, null, 1, 1, 3, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 71, "9.3.3.8", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 45, 1, null, null, 1, 9, 1, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 90, "1.5.9.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 55, 3, null, 2, 2, 3, null, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 97, "0.1.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 88, 6, 7, null, 1, 3, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 53, "1.8.6.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 14, 7, null, null, 1, 2, 9, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 26, "8.2.3.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 75, 3, null, null, 1, 7, 8, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 16, "8.8.5.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 88, 2, 6, null, 1, 7, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 44, "6.5.2.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 78, 4, null, null, 3, 9, 9, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 34, "0.0.2.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 4, 8, null, 1, 9, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 29, "6.0.7.2", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 3, null, null, 2, 9, 2, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 24, "5.9.6.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 68, 2, null, 6, 1, 9, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 21, "7.1.6.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 98, 1, null, 6, 1, 9, null, "Procédure spéciale", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 20, "1.6.9.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 3, null, null, 4, 9, 6, "Examen périodique universal", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 80, "2.7.9.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 99, 7, null, null, 4, 8, 7, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 51, "4.9.4.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 79, 4, null, 1, 2, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 48, "1.0.5.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 89, 3, null, 6, 3, 8, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 45, "0.0.8.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 17, 2, null, 1, 2, 8, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 15, "4.3.0.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 92, 6, null, 1, 2, 9, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 46, "1.6.9.4", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 47, 5, 10, null, 2, 9, null, "Procédure spéciale", "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 39, "7.1.9.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 39, 3, null, 4, 1, 8, null, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 55, "9.7.9.0", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 94, 6, 7, null, 3, 7, null, "Procédure spéciale", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 58, "2.6.5.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 51, 6, 8, null, 2, 7, null, "Organes de traités", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 68, "9.5.4.3", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "Non réalisé", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 40, 6, null, null, 3, 7, 3, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 75, "8.8.0.9", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 90, 4, null, 1, 3, 7, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 37, "5.4.3.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 66, 7, 2, null, 3, 7, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 98, "0.4.2.1", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 7, 5, null, null, 4, 7, 6, "Examen périodique universal", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 100, "6.5.7.7", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 27, 6, 3, null, 4, 7, null, "Examen périodique universal", "Appui à l’amélioration de l’accueil des usagers dans le service publics", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 31, "1.1.1.5", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En cours", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 100, 7, 4, null, 2, 8, null, "Organes de traités", "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "CodeRecommendation", "Complement", "Etat", "EtatAvancement", "EtatAvancementChiffre", "IdAxe", "IdCycle", "IdOrgane", "IdPays", "IdSousAxe", "IdVisite", "Mecanisme", "Nom", "Observation", "PieceJointe" },
                values: new object[] { 94, "2.9.5.6", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "En continue", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", 56, 1, 8, null, 4, 7, null, "Organes de traités", "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion", "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!", "" });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 56, "id", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 30, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 6, "voluptas", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 34, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 79, "omnis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 35, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 10, "non", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 35, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 63, "esse", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 72, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 50, "voluptatibus", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 26, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 49, "tenetur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 59, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 37, "enim", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 42, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 55, "quia", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 19, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 69, "est", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 21, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 35, "repellat", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 10, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 21, "quas", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 21, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 11, "qui", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 21, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 22, "aliquam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 95, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 8, "reprehenderit", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 95, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 91, "laboriosam", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 25, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 52, "at", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 25, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 41, "vel", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 25, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 2, "doloribus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 25, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 97, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 10, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 24, "qui", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 77, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 48, "officiis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 21, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 77, "minus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 63, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 45, "quasi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 50, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 89, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 17, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 16, "doloribus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 10, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 98, "blanditiis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 18, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 66, "rerum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 55, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 1, "rerum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 55, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 83, "in", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 2, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 81, "dolores", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 2, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 61, "ducimus", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 2, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 87, "non", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 82, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 73, "officiis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 82, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 7, "ad", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 82, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 34, "illum", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 17, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 86, "hic", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 100, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 78, "reprehenderit", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 39, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 23, "excepturi", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 39, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 57, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 16, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 60, "quo", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 81, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 19, "magnam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 68, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 64, "aliquam", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 1, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 36, "nesciunt", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 40, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 59, "doloribus", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 47, "dolor", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 5, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 85, "neque", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 46, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 94, "eveniet", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 39, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 76, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 44, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 3, "nihil", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 3, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 65, "a", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 17, "sed", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 75, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 72, "reprehenderit", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 38, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 20, "sit", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 76, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 26, "soluta", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 4, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 99, "rem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 92, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 70, "et", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 92, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 32, "consequuntur", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 92, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 82, "ut", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 80, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 39, "asperiores", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 85, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 74, "temporibus", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 87, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 96, "sit", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 18, "quod", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 74, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 53, "molestiae", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 15, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 4, "earum", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 56, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 92, "praesentium", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 43, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 80, "rerum", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 43, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 40, "modi", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 57, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 33, "rem", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 57, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 14, "hic", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 7, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 68, "earum", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 51, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 46, "voluptatem", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 51, "provident", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 20, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 9, "quo", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 70, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 15, "facilis", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 70, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 100, "ipsam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 94, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 13, "non", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 94, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 93, "facilis", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 54, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 29, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 54, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 84, "incidunt", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 44, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 31, "amet", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 86, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 67, "repudiandae", "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile", 99, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 25, "deserunt", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 99, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 5, "architecto", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 99, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 12, "neque", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 45, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 42, "ut", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 3, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 27, "veniam", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 27, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 90, "ipsa", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 14, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 38, "omnis", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 14, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 75, "cupiditate", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 8, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 88, "pariatur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 71, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 28, "aut", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 71, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 71, "minima", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 98, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 58, "et", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 98, 2 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 30, "et", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society", 98, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 62, "consequatur", "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains", 96, 3 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 43, "soluta", "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains", 96, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 95, "animi", "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains", 14, 1 });

            migrationBuilder.InsertData(
                table: "Syntheses",
                columns: new[] { "Id", "Code", "Detail", "IdRapport", "IdUser" },
                values: new object[] { 54, "est", "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society", 83, 2 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 95, "/invoice/concrete/clicks-and-mortar", 4, 54 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 10, "/technician", 2, 84 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 97, "/bi-directional/extended", 6, 84 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 78, "/orange", 4, 13 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 56, "/aggregate/bahraini-dinar", 3, 100 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 13, "/bandwidth/isle", 4, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 46, "/hacking/integrated", 7, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 66, "/handmade-concrete-cheese/scsi", 1, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 76, "/deposit/awesome-fresh-computer", 5, 3 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 52, "/specialist/organic", 6, 42 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 23, "/generic-plastic-computer/optical/context-sensitive", 1, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 38, "/iowa/us-dollar", 5, 76 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 41, "/matrix/forward", 4, 16 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 25, "/valleys/home-computers--garden", 3, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 36, "/village", 5, 35 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 9, "/1080p", 5, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 15, "/turquoise/synergized", 2, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 30, "/multi-byte/cambridgeshire", 7, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 47, "/rhode-island/re-engineered", 7, 97 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 37, "/arizona/user-facing/transform", 2, 52 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 84, "/interactions", 3, 91 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 74, "/integrated/oklahoma", 5, 8 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 93, "/lek", 6, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 5, "/operative/credit-card-account/data-warehouse", 7, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 62, "/jbod/fantastic/rustic", 4, 31 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 17, "/sky-blue/north-dakota/kids", 3, 90 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 49, "/navigate", 4, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 77, "/beauty/deposit/back-end", 7, 92 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 34, "/syndicate", 5, 74 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 85, "/coves/cross-platform/forward", 5, 39 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 48, "/investment-account", 3, 32 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 61, "/oregon", 6, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 68, "/borders/iterate/applications", 6, 99 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 6, "/blockchains/productize/intelligent", 1, 26 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 14, "/innovative", 2, 72 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 7, "/payment/libyan-arab-jamahiriya", 4, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 90, "/points", 2, 17 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 82, "/red/web-services/norway", 1, 65 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 55, "/netherlands-antillian-guilder/spurs/steel", 5, 9 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 11, "/ai/industrial", 1, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 27, "/teal/new-leu", 3, 43 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 45, "/redefine/e-services/lebanon", 5, 44 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 81, "/generate", 1, 62 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 44, "/california", 4, 30 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 99, "/way/licensed", 3, 58 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 4, "/automotive--games/money-market-account/scale", 7, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 71, "/247", 5, 88 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 19, "/falls/trace/handmade-cotton-bike", 1, 5 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 32, "/investment-account/gold", 2, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 51, "/automotive/invoice/front-line", 5, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 59, "/cotton/wall/back-end", 4, 22 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 57, "/assistant/com/pixel", 5, 36 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 69, "/connect", 6, 64 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 60, "/senior", 4, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 87, "/png", 3, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 89, "/css", 4, 60 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 21, "/rand", 6, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 39, "/interactive/seamless", 4, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 67, "/open-source/transmitting", 7, 57 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 16, "/hacking/checking-account", 2, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 63, "/pricing-structure/plum", 7, 23 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 35, "/unbranded/utah/copy", 6, 78 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 22, "/generic-soft-pants/sports", 7, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 100, "/forge", 4, 86 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 50, "/maroon/shore", 6, 7 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 86, "/ai/index", 4, 87 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 3, "/buckinghamshire/uic-franc/applications", 5, 81 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 70, "/generic/hack/advanced", 7, 83 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 64, "/forges", 1, 1 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 2, "/css", 5, 66 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 79, "/tunisia/gorgeous-wooden-bacon/wyoming", 2, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 92, "/south-carolina/mall/bahraini-dinar", 2, 98 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 72, "/reboot", 2, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 29, "/configurable", 1, 59 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 26, "/bi-directional", 4, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 20, "/handcrafted-fresh-hat", 6, 47 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 33, "/arizona/incredible-rubber-ball", 6, 11 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 12, "/wooden", 2, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 98, "/practical-plastic-hat/ergonomic-rubber-pants", 4, 21 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 54, "/michigan/synthesizing", 5, 48 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 42, "/forges", 5, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 53, "/reboot/intelligent-plastic-tuna/encryption", 2, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 96, "/progressive", 7, 69 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 28, "/transmitter/romania/incredible-steel-fish", 7, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 65, "/sleek/optimal/actuating", 7, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 80, "/designer", 4, 56 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 8, "/open-source/configuration", 6, 14 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 18, "/pixel/rustic-soft-chair/hack", 3, 55 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 31, "/codes-specifically-reserved-for-testing-purposes/facilitator", 1, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 73, "/grocery-toys--baby/passage/ssl", 5, 10 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 1, "/refined-soft-shirt", 4, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 43, "/avon/circles", 5, 24 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 58, "/oregon/licensed-rubber-mouse", 5, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 91, "/pci/avon/product", 6, 77 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 83, "/concept", 1, 34 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 24, "/supply-chains/bedfordshire/core", 3, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 40, "/group/exe", 6, 89 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 94, "/chief", 3, 85 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 75, "/ouguiya/alarm/burg", 5, 37 });

            migrationBuilder.InsertData(
                table: "FicheSyntheses",
                columns: new[] { "Id", "FicheUrl", "IdOrganisme", "IdSynthese" },
                values: new object[] { 88, "/hill", 1, 68 });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 87, 2, new DateTime(2020, 3, 19, 14, 57, 46, 815, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 70, 3, new DateTime(2020, 4, 29, 20, 26, 48, 119, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 37, 4, new DateTime(2020, 5, 14, 20, 30, 28, 73, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 55, 5, new DateTime(2019, 8, 24, 10, 34, 18, 498, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 58, 6, new DateTime(2020, 1, 6, 15, 45, 51, 758, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 68, 1, new DateTime(2020, 4, 4, 23, 23, 47, 75, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 75, 2, new DateTime(2020, 1, 19, 10, 13, 35, 379, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 94, 1, new DateTime(2020, 4, 16, 14, 15, 33, 139, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 98, 6, new DateTime(2020, 1, 3, 17, 30, 31, 477, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 100, 1, new DateTime(2020, 4, 1, 0, 37, 59, 478, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 31, 1, new DateTime(2020, 1, 31, 10, 45, 42, 293, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 39, 4, new DateTime(2020, 3, 15, 22, 50, 19, 986, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 45, 1, new DateTime(2019, 12, 8, 16, 9, 26, 657, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 48, 1, new DateTime(2020, 6, 23, 23, 1, 58, 307, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 51, 2, new DateTime(2019, 9, 21, 15, 34, 48, 904, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 80, 2, new DateTime(2019, 12, 20, 11, 39, 33, 231, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 15, 1, new DateTime(2020, 2, 11, 1, 2, 35, 294, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 20, 2, new DateTime(2020, 5, 26, 5, 25, 31, 374, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 21, 4, new DateTime(2019, 9, 13, 2, 18, 34, 423, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 24, 1, new DateTime(2020, 1, 18, 8, 41, 36, 336, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 29, 5, new DateTime(2020, 5, 1, 9, 40, 48, 564, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 34, 6, new DateTime(2020, 5, 8, 3, 36, 31, 619, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 44, 3, new DateTime(2019, 11, 19, 18, 6, 50, 407, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 26, 1, new DateTime(2019, 8, 24, 16, 5, 59, 248, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 46, 5, new DateTime(2019, 8, 12, 7, 35, 46, 483, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 16, 5, new DateTime(2019, 10, 25, 15, 10, 51, 367, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 90, 4, new DateTime(2019, 10, 14, 4, 29, 24, 269, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 47, 6, new DateTime(2020, 5, 11, 20, 57, 15, 401, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 62, 1, new DateTime(2019, 10, 28, 22, 30, 28, 479, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 67, 3, new DateTime(2020, 3, 9, 6, 34, 30, 198, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 77, 3, new DateTime(2020, 5, 28, 16, 9, 59, 108, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 79, 5, new DateTime(2020, 2, 11, 21, 39, 1, 700, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 82, 1, new DateTime(2020, 3, 2, 11, 49, 34, 111, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 88, 2, new DateTime(2019, 7, 27, 11, 25, 59, 894, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 5, 3, new DateTime(2020, 2, 15, 8, 53, 17, 181, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 9, 6, new DateTime(2019, 10, 26, 2, 21, 34, 554, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 17, 6, new DateTime(2019, 9, 1, 3, 14, 14, 23, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 35, 3, new DateTime(2019, 10, 4, 15, 30, 24, 694, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 38, 3, new DateTime(2019, 8, 13, 20, 45, 47, 288, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 53, 5, new DateTime(2020, 5, 21, 1, 13, 41, 323, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 54, 3, new DateTime(2020, 5, 5, 2, 38, 33, 216, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 99, 1, new DateTime(2020, 1, 22, 8, 35, 3, 367, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 14, 1, new DateTime(2020, 3, 14, 13, 11, 54, 961, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 19, 1, new DateTime(2019, 8, 6, 19, 54, 59, 581, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 27, 3, new DateTime(2020, 4, 12, 8, 44, 39, 33, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 64, 6, new DateTime(2020, 3, 7, 12, 33, 11, 166, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 85, 4, new DateTime(2019, 12, 24, 9, 47, 7, 490, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 86, 1, new DateTime(2020, 4, 6, 20, 2, 18, 33, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 97, 5, new DateTime(2019, 9, 17, 20, 8, 42, 659, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 78, 2, new DateTime(2020, 7, 7, 5, 14, 24, 676, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 59, 2, new DateTime(2019, 12, 4, 21, 21, 22, 970, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 72, 6, new DateTime(2020, 5, 30, 11, 27, 38, 718, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 83, 1, new DateTime(2019, 9, 5, 2, 6, 31, 723, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 91, 5, new DateTime(2020, 1, 2, 23, 20, 13, 237, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 95, 2, new DateTime(2020, 7, 3, 16, 14, 15, 24, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 1, 5, new DateTime(2019, 10, 20, 10, 44, 54, 35, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 3, 1, new DateTime(2020, 5, 9, 1, 55, 42, 32, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 13, 4, new DateTime(2020, 5, 27, 8, 2, 7, 522, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 18, 5, new DateTime(2020, 1, 4, 3, 29, 30, 273, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 28, 6, new DateTime(2020, 6, 29, 1, 21, 18, 92, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 41, 1, new DateTime(2019, 12, 21, 13, 48, 1, 459, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 43, 3, new DateTime(2019, 9, 8, 20, 16, 14, 651, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 52, 1, new DateTime(2020, 3, 28, 18, 15, 48, 418, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 57, 4, new DateTime(2019, 12, 7, 23, 59, 20, 780, DateTimeKind.Local).AddTicks(5898) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 61, 1, new DateTime(2020, 4, 24, 5, 56, 37, 369, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 73, 2, new DateTime(2020, 4, 7, 6, 30, 13, 181, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 84, 1, new DateTime(2020, 5, 8, 8, 34, 42, 317, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 89, 3, new DateTime(2020, 7, 14, 20, 14, 44, 663, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 10, 3, new DateTime(2020, 7, 12, 18, 42, 17, 725, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 12, 6, new DateTime(2020, 2, 24, 3, 35, 26, 691, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 36, 1, new DateTime(2019, 9, 1, 4, 16, 13, 508, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 63, 1, new DateTime(2020, 5, 21, 22, 31, 10, 201, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 65, 1, new DateTime(2020, 2, 22, 12, 0, 27, 797, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 74, 3, new DateTime(2020, 3, 10, 15, 32, 14, 235, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 71, 4, new DateTime(2020, 6, 1, 15, 31, 5, 841, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 69, 3, new DateTime(2019, 8, 13, 11, 17, 42, 411, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 33, 4, new DateTime(2020, 2, 3, 18, 58, 55, 813, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 76, 6, new DateTime(2020, 2, 12, 17, 52, 27, 121, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 81, 2, new DateTime(2019, 7, 29, 20, 10, 10, 494, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 92, 1, new DateTime(2019, 11, 27, 10, 25, 14, 536, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 22, 1, new DateTime(2019, 12, 13, 15, 3, 40, 0, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 25, 1, new DateTime(2019, 9, 14, 14, 9, 51, 137, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 32, 5, new DateTime(2019, 8, 8, 6, 57, 15, 397, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 40, 4, new DateTime(2020, 3, 11, 6, 31, 52, 765, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 42, 2, new DateTime(2020, 5, 20, 15, 51, 10, 342, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 50, 6, new DateTime(2020, 4, 5, 14, 4, 54, 829, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 56, 3, new DateTime(2020, 2, 5, 0, 8, 23, 42, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 60, 4, new DateTime(2019, 10, 3, 2, 22, 37, 610, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 66, 6, new DateTime(2019, 12, 26, 13, 26, 12, 711, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 93, 4, new DateTime(2020, 2, 10, 13, 47, 19, 56, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 96, 4, new DateTime(2019, 7, 27, 22, 7, 18, 559, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 4, 5, new DateTime(2019, 9, 29, 17, 5, 45, 812, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 6, 2, new DateTime(2019, 9, 16, 0, 47, 8, 238, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 7, 1, new DateTime(2020, 7, 15, 6, 2, 50, 906, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 8, 3, new DateTime(2020, 4, 16, 21, 15, 42, 752, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 11, 5, new DateTime(2019, 12, 5, 15, 15, 58, 980, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 23, 5, new DateTime(2020, 5, 15, 9, 6, 40, 842, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 30, 6, new DateTime(2019, 7, 26, 22, 1, 41, 565, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 49, 1, new DateTime(2020, 6, 30, 22, 30, 9, 925, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.InsertData(
                table: "RecomOrgs",
                columns: new[] { "IdRecommendation", "IdOrganisme", "Date" },
                values: new object[] { 2, 4, new DateTime(2020, 1, 13, 20, 1, 58, 173, DateTimeKind.Local).AddTicks(3323) });

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
