using Microsoft.EntityFrameworkCore;
using Turnos.Models;

namespace Turnos.Data
{
    public class TurnosContext : DbContext
    {
        public TurnosContext(DbContextOptions<TurnosContext> options) : base(options)
        { }

        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Login> Login { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidad>(entidad =>
            {
                entidad.ToTable("Especialidades");

                entidad.HasKey(e => e.IdEspecialidad);

                entidad.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            });

            modelBuilder.Entity<Paciente>(entidad =>
            {
                entidad.ToTable("Pacientes");

                entidad.HasKey(p => p.IdPaciente);

                entidad.Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entidad.Property(p => p.Apellido)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entidad.Property(p => p.Direccion)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

                entidad.Property(p => p.Telefono)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

                entidad.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Medico>(entidad =>
            {
                entidad.ToTable("Medicos");

                entidad.HasKey(m => m.IdMedico);

                entidad.Property(m => m.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entidad.Property(m => m.Apellido)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entidad.Property(m => m.Direccion)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

                entidad.Property(m => m.Telefono)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

                entidad.Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

                entidad.Property(m => m.HoraAtencionDesde)
                .IsRequired()
                .IsUnicode(false);

                entidad.Property(m => m.HoraAtencionHasta)
                .IsRequired()
                .IsUnicode(false);

                entidad.Property(m => m.IdEspecialidad)
                .IsRequired()
                .IsUnicode(false);
            });

            modelBuilder.Entity<Medico>().HasOne(x => x.Especialidad)
            .WithMany(p => p.MedicoLista)
            .HasForeignKey(p => p.IdEspecialidad);


            modelBuilder.Entity<Turno>(entidad =>
            {
                entidad.ToTable("Turnos");

                entidad.HasKey(t => t.IdTurno);

                entidad.Property(t => t.IdPaciente)
                .IsRequired()
                .IsUnicode(false);

                entidad.Property(t => t.IdMedico)
                .IsRequired()
                .IsUnicode(false);

                entidad.Property(t => t.FechaHoraInicio)
                .IsRequired()
                .IsUnicode(false);

                entidad.Property(t => t.FechaHoraFin)
                .IsRequired()
                .IsUnicode(false);
            });


            modelBuilder.Entity<Turno>().HasOne(x => x.Paciente)
            .WithMany(p => p.TurnoLista)
            .HasForeignKey(p => p.IdPaciente);

            modelBuilder.Entity<Turno>().HasOne(x => x.Medico)
            .WithMany(p => p.TurnoLista)
            .HasForeignKey(p => p.IdMedico);

            modelBuilder.Entity<Login>(entidad =>
            {
                entidad.ToTable("Login");

                entidad.HasKey(l => l.IdLogin);

                entidad.Property(l => l.Usuario)
                .IsRequired()
                .HasMaxLength(20);

                entidad.Property(l => l.Password)
                .IsRequired()
                .HasMaxLength(250);
            });
        }
    }
}