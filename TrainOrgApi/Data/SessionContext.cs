using Microsoft.EntityFrameworkCore;
using TrainOrgApi.Models;
using TrainOrgApi.Dtos;

namespace TrainOrgApi.Data
{
    public class SessionContext : DbContext
    {
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<ExerciseRow> ExerciseRows { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        
        private readonly string _dbConnectionString;
        public SessionContext()
        {
        }
        public SessionContext(string connection)
        {
            _dbConnectionString = connection;
        }
        public SessionContext(DbContextOptions<SessionContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql(_dbConnectionString).LogTo(Console.WriteLine);//UseLazyLoadingProxies().
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=trainorg;Username=postgres;Password=example").LogTo(Console.WriteLine);//UseLazyLoadingProxies().

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("sessions");

                entity.HasKey(x => x.Id).HasName("sessions_pk");

                entity.Property(x => x.StartTime).HasColumnName("starttime");
                entity.Property(x => x.EndTime).HasColumnName("endtime");

                entity.HasOne(p => p.User)
                      .WithMany()
                      .HasForeignKey(p => p.UserId);

            });

            //modelBuilder.Entity<Session>(entity =>
            //{
            //    entity.ToTable("sessions");

            //    entity.HasKey(x => x.Id).HasName("sessions_pk");

            //    entity.Property(x => x.StartTime).HasColumnName("starttime");//.HasMaxLength(25);
            //    entity.Property(x => x.EndTime).HasColumnName("endtime");
            //    //entity.Property(x => x.User).HasColumnName("user");
            //    //entity.Property(x => x.Trainer).HasColumnName("trainer");
            //    //entity.Property(x => x.RoleId).HasConversion<int>();
            //    //entity.HasMany(x => x.Exercises)
            //    //                  .WithOne(x => x.Session)
            //    //                  .HasForeignKey(x => x.SessionId);
            //    entity.HasMany(x => x.Exercises)
            //      .WithOne(x => x.Session)
            //      .HasForeignKey(x => x.SessionId);

            //    entity.HasOne(p => p.User)
            //        .WithMany()
            //        //.WithMany(p => p.UserSessions)
            //        .HasForeignKey(p => p.UserId);
            //    entity.HasOne(p => p.Trainer)
            //        .WithMany()   
            //        //.WithMany(p => p.TrainerSessions)
            //        .HasForeignKey(p => p.TrainerId);
            //    //entity.HasOne(x => x.Sessions).WithMany(x => x.Exercises).HasForeignKey(x => x.RoleId);
            //});

            modelBuilder.Entity<ExerciseRow>(entity =>
            {
                entity.ToTable("exerciserows");

                entity.HasKey(x => x.Id).HasName("exerciserows_pk");
                //.HasConversion<int>();
                entity.Property(x => x.CountReps);
                entity.Property(x => x.CountTrips);

                entity.HasOne(p => p.Exercise)
                    .WithMany(p => p.ExerciseRow)
                    .HasForeignKey(p => p.ExerciseId);
                //entity.HasOne(x => x.Exercise)
                //  .WithOne(x => x.ExerciseRow)
                //  .HasForeignKey(x => x.SessionId);
            });
            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.ToTable("exercises");

                entity.HasKey(x => x.Id).HasName("exercise_pk");

                entity.Property(x => x.Name);//.HasConversion<int>();

            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasKey(x => x.Id).HasName("user_pk");

                entity.Property(x => x.Name)
                    .HasColumnName("name")
                    .HasMaxLength(25);
                entity.HasIndex(x => x.Name).IsUnique();
                entity.Property(x => x.Password).HasColumnName("password");
                entity.Property(x => x.Salt).HasColumnName("salt");

                entity.Property(x => x.RoleId).HasConversion<int>();

                entity.HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(x => x.RoleId).HasConversion<int>();
                entity.HasData(Enum.GetValues(typeof(RoleId)).Cast<RoleId>().Select(x => new Role() { RoleId = x, Name = x.ToString() }));
            });
        }


    }
}
