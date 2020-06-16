using System;
using System.Collections.Generic;
using System.Linq;
using Admin5.Models;
using Admin5.Models.seed;
using Bogus;
using Microsoft.EntityFrameworkCore;

// dotnet ef dbcontext scaffold 
// "data source=DESKTOP-3550K4L\HARMONY;database=rfid;user id=sa; password=123" 
// Microsoft.EntityFrameworkCore.SqlServer 
// -o Model 
// -c "RfidContext"

// dotnet add package Bogus
namespace seed
{
    public static class DataSeeding
    {
        public static int i = 100;
        public static string lang = "fr";
        public static ModelBuilder Profils(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profil>().HasData(new Profil[]{
                new Profil {Id = 1, Label = "Administrateur"},
                new Profil {Id = 2, Label = "Superviseur"},
                new Profil {Id = 3, Label = "Point focal"},
                new Profil {Id = 4, Label = "Propriétaire"},
            });

            return modelBuilder;
        }

        public static ModelBuilder Organismes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organisme>().HasData(new Organisme[]{
                new Organisme {Id = 1, Label = "Ministère des Affaires Étrangères et de la Coopération"},
                new Organisme {Id = 2, Label = "Ministère de la Justice et des Libertés"},
                new Organisme {Id = 3, Label = "Ministère de la Fonction Publique et de la Modernisation de l'Administration"},
                new Organisme {Id = 4, Label = "Ministère de l'Equipement et du Transport"},
                new Organisme {Id = 5, Label = "Ministère de la Communication"},
                new Organisme {Id = 6, Label = "Ministère de la Santé"},
                new Organisme {Id = 7, Label = "Délégation interministérielle aux droits de l'Homme"},
            });

            return modelBuilder;
        }

        public static ModelBuilder Evenements(this ModelBuilder modelBuilder)
        {
            int id = 1;
            var faker = new Faker<Evenement>(DataSeeding.lang)
                .CustomInstantiator(f => new Evenement { Id = id++ })
                .RuleFor(o => o.Title, f => f.Lorem.Word())
                .RuleFor(o => o.Description, f => f.Lorem.Word())
                .RuleFor(o => o.Date, f => f.Date.Past())
                ;
            modelBuilder.Entity<Evenement>().HasData(faker.Generate(10));
            return modelBuilder;
        }

        public static ModelBuilder Users(this ModelBuilder modelBuilder)
        {
            int id = 1;

            var faker = new Faker<User>(DataSeeding.lang)
                .CustomInstantiator(f => new User { Id = id++ })
                .RuleFor(o => o.Nom, f => f.Name.FirstName())
                .RuleFor(o => o.Prenom, f => f.Name.LastName())
                .RuleFor(o => o.Email, (f, u) => f.Internet.Email($"{u.Nom}{f.UniqueIndex}", u.Prenom))
                .RuleFor(o => o.Password, f => f.Internet.Password(6))
                .RuleFor(o => o.Adresse, f => f.Address.FullAddress())
                .RuleFor(o => o.Tel, f => f.Phone.PhoneNumber("(+212)6 ## ##-##-##"))
                .RuleFor(o => o.Fix, f => f.Phone.PhoneNumber("(+212)5 ## ##-##-##"))
                .RuleFor(o => o.Username, (f, u) => f.Internet.UserName(u.Nom, u.Prenom))
                .RuleFor(o => o.Actif, (f, u) => f.Random.Bool())
                .RuleFor(o => o.IdOrganisme, f => f.Random.Number(1, 6))
                .RuleFor(o => o.IdProfil, f => f.Random.Number(2, 4));
            // f.Company.CompanyName()

            // var users = faker.Generate(DataSeeding.i);
            var users = new List<User>();
            users.Add(new User
            {
                Id = id++,
                Nom = "mourabit",
                Prenom = "mohamed",
                Email = "mourabit@angular.io",
                Adresse = "Temara",
                Tel = "06 ## ## ## ##",
                Fix = "05 ## ## ## ##",
                Username = "mourabit",
                Password = "123",
                Actif = true,
                IdOrganisme = 1,
                IdProfil = 1
            });
            users.Add(new User
            {
                Id = id++,
                Nom = "mehdi",
                Prenom = "mehdi",
                Email = "mehdi@angular.io",
                Adresse = "Temara",
                Tel = "06 ## ## ## ##",
                Fix = "05 ## ## ## ##",
                Username = "mehdi",
                Password = "123",
                Actif = true,
                IdOrganisme = 2,
                IdProfil = 2
            });

            users.Add(new User
            {
                Id = id++,
                Nom = "ahmed",
                Prenom = "ahmed",
                Email = "ahmed@angular.io",
                Adresse = "Temara",
                Tel = "06 ## ## ## ##",
                Fix = "05 ## ## ## ##",
                Username = "ahmed",
                Password = "123",
                Actif = true,
                IdOrganisme = 4,
                IdProfil = 4
            });
            users.Add(new User
            {
                Id = id++,
                Nom = "soufiane",
                Prenom = "soufiane",
                Email = "soufiane@angular.io",
                Adresse = "Temara",
                Tel = "06 ## ## ## ##",
                Fix = "05 ## ## ## ##",
                Username = "soufiane",
                Password = "123",
                Actif = true,
                IdOrganisme = 4,
                IdProfil = 3
            });

            modelBuilder.Entity<User>().HasData(users);

            return modelBuilder;
        }

        public static ModelBuilder Visites(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]
            {
                "Visite de la Rapporteuse Spéciale sur les droits fondamentaux des victimes de la Traite des personnes, en particulier les femmes et les enfants",
                "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains",
                "Visit of the United Nations Special Rapporteur on Trafficking in Persons, Especially Women and Children June 17th and 21st, 2013",
                "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر",
             };
            var faker = new Faker<Visite>(DataSeeding.lang)
                .CustomInstantiator(f => new Visite { Id = id++ })
                .RuleFor(o => o.Mandat, f => f.PickRandom(list))
                // .RuleFor(o => o.Mandat, f => $"Mandat-{id}")
                .RuleFor(o => o.Date, (f, u) => f.Date.Past())
                .RuleFor(o => o.LienRapport, f => "")
                .RuleFor(o => o.LienUpload, f => "")
                .RuleFor(o => o.Discours, f => $"")
                ;

            modelBuilder.Entity<Visite>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder Cycles(this ModelBuilder modelBuilder)
        {
            var id = 1;
            int y1 = 2000;
            int y2 = 2005;
            var faker = new Faker<Cycle>(DataSeeding.lang)
                .CustomInstantiator(f => new Cycle { Id = id++ })
                .RuleFor(o => o.Label, f => $"{y1 += 5}-{y2 += 5}");

            modelBuilder.Entity<Cycle>().HasData(faker.Generate(DataSeeding.i - 90));

            return modelBuilder;
        }

        public static ModelBuilder Questionnaires(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]  { "Droits catégoriels", "Droits thématiques" };
            var faker = new Faker<Questionnaire>(DataSeeding.lang)
                .CustomInstantiator(f => new Questionnaire { Id = id++ })
                .RuleFor(o => o.Theme, f => f.PickRandom(list))
                .RuleFor(o => o.SousTheme, f => $"sous theme {id - 1}")
                .RuleFor(o => o.PieceJointe, f => $"");

            modelBuilder.Entity<Questionnaire>().HasData(faker.Generate(15));

            return modelBuilder;
        }

        public static ModelBuilder ParticipationSessions(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var faker = new Faker<ParticipationSession>(DataSeeding.lang)
                .CustomInstantiator(f => new ParticipationSession { Id = id++ })
                .RuleFor(o => o.Session, f => $"Session {id -1}")
                .RuleFor(o => o.Discours, f => $"")
                .RuleFor(o => o.Documents, f => $"");

            modelBuilder.Entity<ParticipationSession>().HasData(faker.Generate(15));

            return modelBuilder;
        }

        public static ModelBuilder Examens(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var faker = new Faker<Examen>(DataSeeding.lang)
                .CustomInstantiator(f => new Examen { Id = id++ })
                .RuleFor(o => o.Libelle, f => $"Examen-{id}")
                .RuleFor(o => o.RapportNational, f => $"")
                .RuleFor(o => o.CompilationHCDH, f => $"")
                .RuleFor(o => o.ObservationFinale, f => $"")
                .RuleFor(o => o.RapportMiParcours, f => $"")
                .RuleFor(o => o.Discours, f => $"")
                ;

            modelBuilder.Entity<Examen>().HasData(faker.Generate(6));

            return modelBuilder;
        }
        static List<Axe> axes = new List<Axe>();

        public static ModelBuilder Organes(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]
            {
                "Comité CEDAW",
                "Comité contre la torture",
                "Comité des disparitions forcées",
                "Comité des droits de l’Homme",
                "Comité des droits de l’enfant",
                "Comité des droits des personnes handicapés",
             };
            var faker = new Faker<Organe>(DataSeeding.lang)
                .CustomInstantiator(f => new Organe { Id = id++ })
                .RuleFor(o => o.Label, f => list[id - 2]);

            modelBuilder.Entity<Organe>().HasData(faker.Generate(6));

            return modelBuilder;
        }
        public static ModelBuilder Axes(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]
            {
                "Démocratie et gouvernance",
                "Droits économiques, sociaux, culturels et environnementaux",
                "Promotion et protection des droits catégoriels",
                "Cadre institutionnel et juridique",
             };
            var faker = new Faker<Axe>(DataSeeding.lang)
                .CustomInstantiator(f => new Axe { Id = id++ })
                .RuleFor(o => o.Label, f => list[id - 2 ]);



            axes = faker.Generate(4);
            modelBuilder.Entity<Axe>().HasData(axes);

            return modelBuilder;
        }

        public static ModelBuilder SousAxes(this ModelBuilder modelBuilder)
        {
            // var id = 1;
            var list = new List<SousAxe>();
            list.Add(new SousAxe { Id = 1, Label = "Démocratie", IdAxe = 1 });
            list.Add(new SousAxe { Id = 2, Label = "Gouvernance", IdAxe = 1 });
            list.Add(new SousAxe { Id = 3, Label = "Droits économiques", IdAxe = 2 });
            list.Add(new SousAxe { Id = 4, Label = "Droits sociaux", IdAxe = 2 });
            list.Add(new SousAxe { Id = 5, Label = "Droits culturels", IdAxe = 2 });
            list.Add(new SousAxe { Id = 6, Label = "Droits environnementaux", IdAxe = 2 });
            list.Add(new SousAxe { Id = 7, Label = "Promotion des droits catégoriels", IdAxe = 3 });
            list.Add(new SousAxe { Id = 8, Label = "Protection des droits catégoriels", IdAxe = 3 });
            list.Add(new SousAxe { Id = 9, Label = "Cadre institutionnel", IdAxe = 4 });
            list.Add(new SousAxe { Id = 10, Label = "Cadre juridique", IdAxe = 4 });

            // var idAxe = 0;
            // var faker = new Faker<SousAxe>(DataSeeding.lang)
            //     .CustomInstantiator(f => new SousAxe { Id = id++ })
            //     .RuleFor(o => o.Label, (f, o) =>
            //     {
            //         var sa = f.PickRandom(list);
            //         idAxe = sa.IdAxe;
            //         return sa.Label;
            //     })
            //     .RuleFor(o => o.IdAxe, f => idAxe)
            //     ;
            modelBuilder.Entity<SousAxe>().HasData(list);

            return modelBuilder;
        }

        public static ModelBuilder Traites(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]
             {
                "Conseil consultatif de la famille et de l'enfance",
                "La lutte contre toutes les formes de discrimination",
                "la lutte contre les troubles mentaux et à la protection des droits des personnes atteintes de ces troubles",
                "le renforcement de la protection juridique des victimes des conflits armés",
             };
            var faker = new Faker<Traite>(DataSeeding.lang)
                .CustomInstantiator(f => new Traite { Id = id++ })
                .RuleFor(o => o.Nom, f => f.PickRandom(list))
                .RuleFor(o => o.DateRatification, f => f.Date.Past())
                .RuleFor(o => o.DateSignature, f => f.Date.Past())
                .RuleFor(o => o.ConventionPiece, "")
                .RuleFor(o => o.MiseOeuvrePiece, "")
                .RuleFor(o => o.ObservationPiece, "")
                .RuleFor(o => o.Discours, f => $"")
                .RuleFor(o => o.AnalytiquePiece, f => $"")

                ;
            modelBuilder.Entity<Traite>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder FicheSyntheses(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var faker = new Faker<FicheSynthese>(DataSeeding.lang)
                .CustomInstantiator(f => new FicheSynthese { Id = id++ })
                .RuleFor(o => o.FicheUrl, f => f.Internet.UrlRootedPath())
                .RuleFor(o => o.IdOrganisme, f => f.Random.Number(1, 7))
                .RuleFor(o => o.IdSynthese, f => f.Random.Number(1, 100))

                ;
            modelBuilder.Entity<FicheSynthese>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder Pays(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pays>().HasData(new Pays[]{
                new Pays {Id = 1, Nom = "Maroc"},
                new Pays {Id = 2, Nom = "France"},
                new Pays {Id = 3, Nom = "Allemagne"},
                new Pays {Id = 4, Nom = "Espagnole"},
            });

            return modelBuilder;
        }

        public static ModelBuilder Rapports(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]
            {
                "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains",
                "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains",
                "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains",
                "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile",
                "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains",
                "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society",
                "زيارة المقررة الخاصة للأمم المتحدة المعنية بالاتجار بالبشر",
                "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society",
             };
            var faker = new Faker<Rapport>(DataSeeding.lang)
                .CustomInstantiator(f => new Rapport { Id = id++ })
                .RuleFor(o => o.Titre, f => f.Lorem.Word())
                .RuleFor(o => o.DateDernierRapport, f => f.Date.Soon())
                .RuleFor(o => o.DateObservation, f => f.Date.Soon())
                .RuleFor(o => o.DateProchaineRapport, f => f.Date.Soon())
                .RuleFor(o => o.Reference, f => f.Internet.Url())
                .RuleFor(o => o.IdTraite, f => f.Random.Number(1, 100))
                .RuleFor(o => o.PieceJointe, f => "")
                
                ;
            modelBuilder.Entity<Rapport>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }



        // public static ModelBuilder UserRapports(this ModelBuilder modelBuilder)
        // {
        //     int i = 1;
        //     var faker = new Faker<UserRapport>(DataSeeding.lang)
        //         .RuleFor(o => o.IdRapport, f => i++)
        //         .RuleFor(o => o.IdUser, f => f.Random.Number(1, 104))
        //         ;
        //     modelBuilder.Entity<UserRapport>().HasData(faker.Generate(DataSeeding.i));

        //     return modelBuilder;
        // }

        public static ModelBuilder Syntheses(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var list = new[]
             {
                "Journée d’étude sur le cadre institutionnel relatif à lutte contre la traite des êtres humains : vers la mise en place de la Commission nationale sur la traite des êtres humains",
                "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains",
                "Investiture des membres de la commission nationale de lutte et de prévention contre la traite des êtres humains",
                "Traite des personnes et trafic des migrants : une journée d’étude en faveur des acteurs institutionnels et de la société civile",
                "Lutte contre la traite des êtres humains au Maroc : Deuxième atelier sous-régional (Mali – Maroc – Niger) sur le trafic illicite de migrants et la traite des êtres humains",
                "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in Favor of Institutional Actors and Civil Society",
                "Combatting Human Trafficking and Immigrant Smuggling: a Study Day in favor of Institutions and Civil Society",
             };
            var faker = new Faker<Synthese>(DataSeeding.lang)
                .CustomInstantiator(f => new Synthese { Id = id++ })
                .RuleFor(o => o.Code, f => f.Lorem.Word())
                .RuleFor(o => o.Detail, f => f.PickRandom(list))
                .RuleFor(o => o.IdRapport, f => f.Random.Number(1, 100))
                .RuleFor(o => o.IdUser, f => f.Random.Number(1, 3));

            modelBuilder.Entity<Synthese>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder Recommendations(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var mecanisme = new[] { "Examen périodique universal", "Organes de traités", "Procédure spéciale" };
            var etat = new[] {  "Réalisé", "En cours", "En continue","Non réalisé" };
            var list = new[]
            {
                "Appui à la Délégation Interministérielle aux Droits de l’Homme (DIDH) pour l’intégration des droits humains dans les politiques publiques",
                "Initiative régionale pour le renforcement des capacités des communes rurales de la région de Tanger Tétouan en matière de genre et d’égalité des chances",
                "Appui à l’amélioration de l’accueil des usagers dans le service publics",
                "Programme d’appui à la mise en œuvre de la stratégie de la Délégation Générale à l’Administration Pénitentiaire et à la Réinsertion",
             };

            var faker = new Faker<Recommendation>(DataSeeding.lang)
                .CustomInstantiator(f => new Recommendation { Id = id++ })
                .RuleFor(o => o.Nom, f => f.PickRandom(list))
                .RuleFor(o => o.CodeRecommendation, f => f.System.Version().ToString())
                .RuleFor(o => o.Mecanisme, f => f.PickRandom(mecanisme))
                .RuleFor(o => o.IdCycle, f => f.Random.Number(1, DataSeeding.i - 90))
                .RuleFor(o => o.IdPays, f => f.Random.Number(1, 4))
                .RuleFor(o => o.IdVisite, f => f.Random.Number(1, DataSeeding.i - 90))
                .RuleFor(o => o.IdOrgane, f => f.Random.Number(1, 6))
                .RuleFor(o => o.IdAxe, f => f.Random.Number(1, 4))
                .RuleFor(o => o.IdSousAxe, f => f.Random.Number(1, 10))
                .RuleFor(o => o.Etat, f => f.PickRandom(etat))
                .RuleFor(o => o.EtatAvancement, f => "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!")
                .RuleFor(o => o.EtatAvancementChiffre, f => f.Random.Number(0, 100))
                .RuleFor(o => o.Observation, f => "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates, excepturi!")
                .RuleFor(o => o.PieceJointe, f => "")
                // .RuleFor(o => o.IdOrganisme, f => f.Random.Number(1, 6))
                ;

            modelBuilder.Entity<Recommendation>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder Notifications(this ModelBuilder modelBuilder)
        {
            var id = 1;
            var tables = new[]
            {
                new { table = "recommandation", notif = "Nouvelle recommandation a été ajoutée"},
                new { table = "visite", notif = "Nouvelle visite a été ajouter"},
                new { table = "traite", notif = "Nouveau traité a été ajoutée"},
                new { table = "synthese", notif = "Nouveau synthèse a été ajoutée"}
            };
            int index = 0;
            var faker = new Faker<Notification>(DataSeeding.lang)
                .CustomInstantiator(f => new Notification { Id = id++ })
                .RuleFor(o => o.IdConcerner, f => id - 1)
                .RuleFor(o => o.IdOrganisme, f => f.Random.Number(1, 6))
                .RuleFor(o => o.TableConcerner, f =>
                {
                    index = f.Random.Number(0, 3);
                    return tables[index].table;
                })
                .RuleFor(o => o.Message, f => tables[index].notif)
                .RuleFor(o => o.Date, f => f.Date.Past())
                .RuleFor(o => o.Destinataire, f => $"{f.Random.Number(0, 1)},{f.Random.Number(2, 3)},{f.Random.Number(4, 6)}")
                .RuleFor(o => o.Vu, f => f.Random.Bool())
                .RuleFor(o => o.Priorite, f => f.Random.Number(1, 4))
                ;
            modelBuilder.Entity<Notification>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder RecomOrgs(this ModelBuilder modelBuilder)
        {
            int i = 1;
            var faker = new Faker<RecomOrg>(DataSeeding.lang)
                .RuleFor(o => o.IdRecommendation, f => i++)
                .RuleFor(o => o.IdOrganisme, f => f.Random.Number(1, 6))
                .RuleFor(o => o.Date, f => f.Date.Past())
                ;
            modelBuilder.Entity<RecomOrg>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

        public static ModelBuilder SyntheseRecommandations(this ModelBuilder modelBuilder)
        {
            var faker = new Faker<SyntheseRecommandation>(DataSeeding.lang)
                .RuleFor(o => o.IdRecommandation, f => f.Random.Number(1, 100))
                .RuleFor(o => o.IdSynthese, f => f.Random.Number(1, 100))
                ;
            modelBuilder.Entity<SyntheseRecommandation>().HasData(faker.Generate(DataSeeding.i));

            return modelBuilder;
        }

    }
}