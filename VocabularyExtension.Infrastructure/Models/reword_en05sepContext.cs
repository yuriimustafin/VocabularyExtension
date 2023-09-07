using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VocabularyExtension.Infrastructure.Models
{
    public partial class reword_en05sepContext : DbContext
    {
        public reword_en05sepContext()
        {
        }

        public reword_en05sepContext(DbContextOptions<reword_en05sepContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AndroidMetadatum> AndroidMetadata { get; set; }
        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<DailyGoal> DailyGoals { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<WordAudio> WordAudios { get; set; }
        public virtual DbSet<WordCategory> WordCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=D:\\__Projects\\GitHub\\VocabularyExtension\\VocabularyExtension\\VocabularyExtension.Infrastructure\\DatabaseFiles\\reword_en05sep.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AndroidMetadatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("android_metadata");

                entity.Property(e => e.Locale).HasColumnName("locale");
            });

            modelBuilder.Entity<Audio>(entity =>
            {
                entity.ToTable("AUDIO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnName("CONTENT");

                entity.Property(e => e.IsCustom).HasColumnName("IS_CUSTOM");

                entity.Property(e => e.Var).HasColumnName("VAR");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomIcon).HasColumnName("CUSTOM_ICON");

                entity.Property(e => e.IsCustom).HasColumnName("IS_CUSTOM");

                entity.Property(e => e.IsSelected).HasColumnName("IS_SELECTED");

                entity.Property(e => e.NameAra).HasColumnName("NAME_ARA");

                entity.Property(e => e.NameDeu).HasColumnName("NAME_DEU");

                entity.Property(e => e.NameFra).HasColumnName("NAME_FRA");

                entity.Property(e => e.NameIta).HasColumnName("NAME_ITA");

                entity.Property(e => e.NameJpn).HasColumnName("NAME_JPN");

                entity.Property(e => e.NameKor).HasColumnName("NAME_KOR");

                entity.Property(e => e.NamePor).HasColumnName("NAME_POR");

                entity.Property(e => e.NameRus).HasColumnName("NAME_RUS");

                entity.Property(e => e.NameSpa).HasColumnName("NAME_SPA");

                entity.Property(e => e.NameTur).HasColumnName("NAME_TUR");

                entity.Property(e => e.NameUkr).HasColumnName("NAME_UKR");

                entity.Property(e => e.NameZho).HasColumnName("NAME_ZHO");

                entity.Property(e => e.NameZhs).HasColumnName("NAME_ZHS");

                entity.Property(e => e.NameZht).HasColumnName("NAME_ZHT");

                entity.Property(e => e.Progress).HasColumnName("PROGRESS");
            });

            modelBuilder.Entity<DailyGoal>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("DAILY_GOAL");

                entity.Property(e => e.Date).HasColumnName("DATE");

                entity.Property(e => e.AdjustedGoal).HasColumnName("ADJUSTED_GOAL");

                entity.Property(e => e.Goal).HasColumnName("GOAL");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("LOG");

                entity.HasIndex(e => e.LocalDate, "IDX_LOG_LOCAL_DATE");

                entity.HasIndex(e => e.Timestamp, "IDX_LOG_TIMESTAMP");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");

                entity.Property(e => e.LocalDate).HasColumnName("LOCAL_DATE");

                entity.Property(e => e.Repetition).HasColumnName("REPETITION");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("2");

                entity.Property(e => e.Timestamp).HasColumnName("TIMESTAMP");

                entity.Property(e => e.WordId).HasColumnName("WORD_ID");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("PICTURE");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnName("CONTENT");

                entity.Property(e => e.IsCustom).HasColumnName("IS_CUSTOM");

                entity.Property(e => e.Source).HasColumnName("SOURCE");

                entity.Property(e => e.SourceId).HasColumnName("SOURCE_ID");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("SETTINGS");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<Word>(entity =>
            {
                entity.ToTable("WORD");

                entity.HasIndex(e => new { e.ExtSource, e.ExtSourceId }, "IDX_WORD_EXT_SOURCE_EXT_SOURCE_ID")
                    .IsUnique();

                entity.HasIndex(e => e.Status, "IDX_WORD_STATUS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ara).HasColumnName("ARA");

                entity.Property(e => e.CountRepeated).HasColumnName("COUNT_REPEATED");

                entity.Property(e => e.Deu).HasColumnName("DEU");

                entity.Property(e => e.ExamplesAra).HasColumnName("EXAMPLES_ARA");

                entity.Property(e => e.ExamplesDeu).HasColumnName("EXAMPLES_DEU");

                entity.Property(e => e.ExamplesFra).HasColumnName("EXAMPLES_FRA");

                entity.Property(e => e.ExamplesIta).HasColumnName("EXAMPLES_ITA");

                entity.Property(e => e.ExamplesJpn).HasColumnName("EXAMPLES_JPN");

                entity.Property(e => e.ExamplesKor).HasColumnName("EXAMPLES_KOR");

                entity.Property(e => e.ExamplesPor).HasColumnName("EXAMPLES_POR");

                entity.Property(e => e.ExamplesRus).HasColumnName("EXAMPLES_RUS");

                entity.Property(e => e.ExamplesSpa).HasColumnName("EXAMPLES_SPA");

                entity.Property(e => e.ExamplesTur).HasColumnName("EXAMPLES_TUR");

                entity.Property(e => e.ExamplesUkr).HasColumnName("EXAMPLES_UKR");

                entity.Property(e => e.ExamplesZho).HasColumnName("EXAMPLES_ZHO");

                entity.Property(e => e.ExamplesZhs).HasColumnName("EXAMPLES_ZHS");

                entity.Property(e => e.ExamplesZht).HasColumnName("EXAMPLES_ZHT");

                entity.Property(e => e.ExtSource).HasColumnName("EXT_SOURCE");

                entity.Property(e => e.ExtSourceId).HasColumnName("EXT_SOURCE_ID");

                entity.Property(e => e.Fra).HasColumnName("FRA");

                entity.Property(e => e.Ita).HasColumnName("ITA");

                entity.Property(e => e.Jpn).HasColumnName("JPN");

                entity.Property(e => e.Kor).HasColumnName("KOR");

                entity.Property(e => e.OffsetToNextDisplay).HasColumnName("OFFSET_TO_NEXT_DISPLAY");

                entity.Property(e => e.PictureId).HasColumnName("PICTURE_ID");

                entity.Property(e => e.Por).HasColumnName("POR");

                entity.Property(e => e.Pos).HasColumnName("POS");

                entity.Property(e => e.Reg).HasColumnName("REG");

                entity.Property(e => e.Rus).HasColumnName("RUS");

                entity.Property(e => e.Spa).HasColumnName("SPA");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Transcription)
                    .IsRequired()
                    .HasColumnName("TRANSCRIPTION");

                entity.Property(e => e.TranscriptionBr)
                    .IsRequired()
                    .HasColumnName("TRANSCRIPTION_BR")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TranscriptionUs)
                    .IsRequired()
                    .HasColumnName("TRANSCRIPTION_US")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TsLastDisplayed).HasColumnName("TS_LAST_DISPLAYED");

                entity.Property(e => e.Tur).HasColumnName("TUR");

                entity.Property(e => e.Ukr).HasColumnName("UKR");

                entity.Property(e => e.Word1)
                    .IsRequired()
                    .HasColumnName("WORD");

                entity.Property(e => e.Zho).HasColumnName("ZHO");

                entity.Property(e => e.Zhs).HasColumnName("ZHS");

                entity.Property(e => e.Zht).HasColumnName("ZHT");
            });

            modelBuilder.Entity<WordAudio>(entity =>
            {
                entity.ToTable("WORD_AUDIO");

                entity.HasIndex(e => e.WordId, "IDX_WORD_AUDIO_WORD_ID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AudioId)
                    .IsRequired()
                    .HasColumnName("AUDIO_ID");

                entity.Property(e => e.Ord).HasColumnName("ORD");

                entity.Property(e => e.WordId).HasColumnName("WORD_ID");
            });

            modelBuilder.Entity<WordCategory>(entity =>
            {
                entity.ToTable("WORD_CATEGORY");

                entity.HasIndex(e => new { e.WordId, e.CategoryId }, "IDX_WORD_CATEGORY_WORD_ID_CATEGORY_ID")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .IsRequired()
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.WordId).HasColumnName("WORD_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
