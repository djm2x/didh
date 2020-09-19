using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using seed;

namespace Admin5.Models
{
    public partial class AdminContext : DbContext
    {
        public AdminContext()
        {
            // dotnet tool install -g dotnet-aspnet-codegenerator
            // dotnet tool update -g dotnet-aspnet-codegenerator
            // dotnet aspnet-codegenerator --project . controller -name HelloController -m Author -dc WebAPIDataContext
            // dotnet tool install --global dotnet-ef --version 3.0.0
            // scafolding to db
            // dotnet ef migrations add secondMG
            // dotnet ef database update
            // dotnet ef migrations remove
            // dotnet ef database update LastGoodMigration
            // dotnet ef migrations script
        }

        public AdminContext(DbContextOptions<AdminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Organisme> Organismes { get; set; }
        public virtual DbSet<Recommendation> Recommendations { get; set; }
        public virtual DbSet<Profil> Profils { get; set; }
        public virtual DbSet<Rapport> Rapports { get; set; }
        public virtual DbSet<Traite> Traites { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Visite> Visites { get; set; }
        public virtual DbSet<Axe> Axes { get; set; }
        public virtual DbSet<SousAxe> SousAxes { get; set; }
        public virtual DbSet<Cycle> Cycles { get; set; }
        public virtual DbSet<Synthese> Syntheses { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<FicheSynthese> FicheSyntheses { get; set; }
        public virtual DbSet<SyntheseRecommandation> SyntheseRecommandations { get; set; }
        public virtual DbSet<RecomOrg> RecomOrgs { get; set; }
        public virtual DbSet<Organe> Organes { get; set; }
        public virtual DbSet<Examen> Examens { get; set; }
        public virtual DbSet<SituationReserve> SituationReserves { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<ParticipationSession> ParticipationSessions { get; set; }
        public virtual DbSet<Evenement> Evenements { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SituationReserve>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Url);
            });

            modelBuilder.Entity<Examen>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Id).ValueGeneratedOnAdd();

               entity.Property(e => e.Libelle);
               entity.Property(e => e.RapportNational);
               entity.Property(e => e.Discours);
               entity.Property(e => e.CompilationHCDH);
               entity.Property(e => e.ObservationFinale);
               entity.Property(e => e.RapportMiParcours);
           });

            modelBuilder.Entity<Organisme>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Adresse);
                entity.Property(e => e.Label);
                entity.Property(e => e.Tel);
                entity.HasMany(d => d.RecomOrgs).WithOne(p => p.Organisme).HasForeignKey(d => d.IdOrganisme);
                entity.HasMany(d => d.FicheSynthese).WithOne(p => p.Organisme).HasForeignKey(d => d.IdOrganisme);
            });

            modelBuilder.Entity<Pays>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nom);
                entity.HasMany(d => d.Recommendations).WithOne(p => p.Pays).HasForeignKey(d => d.IdPays);
            });



            modelBuilder.Entity<RecomOrg>(entity =>
            {
                entity.HasKey(e => new { e.IdRecommendation, e.IdOrganisme });
                entity.Property(e => e.Date).IsRequired();
                entity.HasOne(d => d.Recommendation).WithMany(p => p.RecomOrgs).HasForeignKey(d => d.IdRecommendation);
                entity.HasOne(d => d.Organisme).WithMany(p => p.RecomOrgs).HasForeignKey(d => d.IdOrganisme);
            });

            modelBuilder.Entity<Profil>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Label);
            });

            modelBuilder.Entity<Traite>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Id).ValueGeneratedOnAdd();

               entity.Property(e => e.DateRatification);
               entity.Property(e => e.Discours);
               entity.Property(e => e.AnalytiquePiece);
               entity.Property(e => e.DateSignature);
               entity.Property(e => e.ConventionPiece);
               entity.Property(e => e.MiseOeuvrePiece);
               entity.Property(e => e.ObservationPiece);
               entity.HasMany(d => d.Rapports).WithOne(p => p.Traite).HasForeignKey(d => d.IdTraite);
           });

            modelBuilder.Entity<Rapport>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Titre);
                entity.Property(e => e.DateDernierRapport);
                entity.Property(e => e.DateDernierRapport).IsRequired();
                entity.Property(e => e.DateObservation).IsRequired();
                entity.Property(e => e.DateProchaineRapport).IsRequired();
                entity.Property(e => e.Reference).IsRequired();
                entity.Property(e => e.IdTraite).IsRequired();

                entity.Property(e => e.PieceJointe).IsRequired(false);
                entity.HasOne(d => d.Traite).WithMany(p => p.Rapports).HasForeignKey(d => d.IdTraite);
                entity.HasMany(d => d.Syntheses).WithOne(p => p.Rapport).HasForeignKey(d => d.IdRapport);
            });

            modelBuilder.Entity<FicheSynthese>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FicheUrl).IsRequired();
                entity.Property(e => e.IdOrganisme).IsRequired();
                entity.Property(e => e.IdSynthese).IsRequired();
                entity.HasOne(e => e.Organisme).WithMany(e => e.FicheSynthese).HasForeignKey(e => e.IdOrganisme);
                entity.HasOne(e => e.Synthese).WithMany(e => e.FicheSyntheses).HasForeignKey(e => e.IdSynthese);
            });

            modelBuilder.Entity<Synthese>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Code).IsRequired();
                entity.Property(e => e.Detail).IsRequired();
                entity.Property(e => e.IdRapport);

                entity.HasOne(d => d.Rapport).WithMany(p => p.Syntheses).HasForeignKey(d => d.IdRapport);
                entity.HasMany(d => d.SyntheseRecommandations).WithOne(p => p.Synthese).HasForeignKey(d => d.IdSynthese);
                entity.HasMany(d => d.FicheSyntheses).WithOne(p => p.Synthese).HasForeignKey(d => d.IdSynthese);

            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.IdConcerner).IsRequired();
                entity.Property(e => e.TableConcerner).IsRequired();
                entity.Property(e => e.Message).IsRequired();
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.Destinataire).IsRequired();
                entity.Property(e => e.Vu).IsRequired();
                entity.Property(e => e.Priorite).IsRequired();
            });

            modelBuilder.Entity<SyntheseRecommandation>(entity =>
            {
                entity.HasKey(e => new { e.IdRecommandation, e.IdSynthese });
                entity.Property(e => e.IdRecommandation).IsRequired();
                entity.Property(e => e.IdSynthese).IsRequired();
                entity.HasOne(d => d.Recommendation).WithMany(p => p.SyntheseRecommandations).HasForeignKey(d => d.IdRecommandation);
                entity.HasOne(d => d.Synthese).WithMany(p => p.SyntheseRecommandations).HasForeignKey(d => d.IdSynthese);
            });

            modelBuilder.Entity<Recommendation>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Nom);
                entity.Property(e => e.CodeRecommendation);
                entity.Property(e => e.Mecanisme);
                entity.Property(e => e.IdCycle);
                entity.Property(e => e.IdVisite);
                entity.Property(e => e.IdOrgane);
                entity.Property(e => e.EtatAvancement);
                entity.Property(e => e.EtatAvancementChiffre);
                entity.Property(e => e.IdAxe);
                entity.Property(e => e.IdSousAxe);
                entity.Property(e => e.Annee);
                entity.Property(e => e.Etat);
                // entity.Property(e => e.IdOrganisme).IsRequired();
                // entity.HasOne(d => d.Organisme).WithMany(p => p.Recommendations).HasForeignKey(d => d.IdOrganisme);
                entity.HasOne(d => d.Axe).WithMany(p => p.Recommendations).HasForeignKey(d => d.IdAxe);

                entity.HasOne(d => d.SousAxe).WithMany(p => p.Recommendations).HasForeignKey(d => d.IdSousAxe)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(d => d.Cycle).WithMany(p => p.Recommendations).HasForeignKey(d => d.IdCycle);
                entity.HasMany(d => d.SyntheseRecommandations).WithOne(p => p.Recommendation).HasForeignKey(d => d.IdRecommandation);
                entity.HasMany(d => d.RecomOrgs).WithOne(p => p.Recommendation).HasForeignKey(d => d.IdRecommendation)
                .OnDelete(DeleteBehavior.NoAction);

            });

            modelBuilder.Entity<RecomOrg>(entity =>
            {
                entity.HasKey(e => new { e.IdRecommendation, e.IdOrganisme });
                entity.Property(e => e.Date).IsRequired();
                entity.HasOne(d => d.Recommendation).WithMany(p => p.RecomOrgs).HasForeignKey(d => d.IdRecommendation);
                entity.HasOne(d => d.Organisme).WithMany(p => p.RecomOrgs).HasForeignKey(d => d.IdOrganisme);

            });

            modelBuilder.Entity<Cycle>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Label);
                entity.HasMany(d => d.Recommendations).WithOne(p => p.Cycle).HasForeignKey(d => d.IdCycle)
                // .OnDelete(DeleteBehavior.Cascade)
                ;
            });

            modelBuilder.Entity<Organe>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Id).ValueGeneratedOnAdd();
               entity.Property(e => e.Label);
               entity.Property(e => e.Abv);
               entity.Property(e => e.AbvAr);
               entity.HasMany(d => d.Recommendations).WithOne(p => p.Organe).HasForeignKey(d => d.IdOrgane)
               // .OnDelete(DeleteBehavior.Cascade)
               ;
           });

            modelBuilder.Entity<Axe>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Label);
                entity.HasMany(d => d.Recommendations).WithOne(p => p.Axe)
                .HasForeignKey(d => d.IdAxe)
                .OnDelete(DeleteBehavior.Cascade);
                entity.Property(e => e.Abv);
                entity.Property(e => e.AbvAr);
                entity.HasMany(d => d.SousAxes).WithOne(p => p.Axe).HasForeignKey(d => d.IdAxe)
                // .OnDelete(DeleteBehavior.Cascade)
                ;
            });

            modelBuilder.Entity<SousAxe>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Label);
                entity.Property(e => e.IdAxe);
                entity.HasOne(d => d.Axe).WithMany(p => p.SousAxes).HasForeignKey(d => d.IdAxe);
                entity.HasMany(d => d.Recommendations).WithOne(p => p.SousAxe).HasForeignKey(d => d.IdSousAxe)
                ;
            });



            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.Actif);
                entity.Property(e => e.Adresse).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Fix).IsRequired();
                entity.Property(e => e.Nom).IsRequired();
                entity.Property(e => e.IdOrganisme).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.Prenom).IsRequired();
                entity.Property(e => e.IdProfil).IsRequired();
                entity.Property(e => e.Tel).IsRequired();
                entity.Property(e => e.Username).IsRequired();
                entity.HasOne(d => d.Organisme).WithMany(p => p.User).HasForeignKey(d => d.IdOrganisme);
                entity.HasOne(d => d.Profil).WithMany(p => p.User).HasForeignKey(d => d.IdProfil);
                entity.HasMany(d => d.Syntheses).WithOne(p => p.User).HasForeignKey(d => d.IdUser).OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Visite>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Discours);
                entity.Property(e => e.Date);
                entity.Property(e => e.LienRapport).IsRequired(false);
                entity.Property(e => e.LienUpload).IsRequired(false);
                entity.Property(e => e.Mandat);
                // entity.Property(e => e.Objet);
                entity.HasMany(d => d.Recommendations).WithOne(p => p.Visite).HasForeignKey(d => d.IdVisite);
            });

             modelBuilder.Entity<Evenement>(entity => 
            {entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Title);
            entity.Property(e => e.Description);
            entity.Property(e => e.Date);
            });

            OnModelCreatingPartial(modelBuilder);

            modelBuilder
                .Profils()
                .Users()
                .Visites()
                .Cycles()
                .Organes()
                .Axes()
                .Pays()
                .SousAxes()
                .Organismes()
                .Recommendations()

                .Traites()
                .Rapports()
                .Syntheses()
                .FicheSyntheses()
                .Questionnaires()
                .ParticipationSessions()
                .Examens()
                 .Evenements()



                .RecomOrgs()


                // .Notifications()
            ;



        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
