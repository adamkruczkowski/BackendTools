﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231225212147_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Entities.HistoriaTransakcji", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idOferty")
                        .HasColumnType("int");

                    b.Property<int>("idUzytkownika")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("historieTransakcji");
                });

            modelBuilder.Entity("API.Entities.KomentarzForum", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdPosta")
                        .HasColumnType("int");

                    b.Property<int>("IdUzytkownika")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("komentarzeForum");
                });

            modelBuilder.Entity("API.Entities.KomentarzOferty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdOferty")
                        .HasColumnType("int");

                    b.Property<int>("IdUzytkownika")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("komentarzeOferty");
                });

            modelBuilder.Entity("API.Entities.Konwersacja", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idUzytkownik1")
                        .HasColumnType("int");

                    b.Property<int>("idUzytkownik2")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("konwersacje");
                });

            modelBuilder.Entity("API.Entities.Oferta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float?>("Cena")
                        .HasColumnType("float");

                    b.Property<bool>("CzyZakonczona")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("DataDoKiedy")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataDodaniaOferty")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataOdKiedy")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdOsiedla")
                        .HasColumnType("int");

                    b.Property<int>("IdUzytkownika")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("longtext");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Zdjecie")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("oferty");
                });

            modelBuilder.Entity("API.Entities.PostForum", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDodania")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdAutora")
                        .HasColumnType("int");

                    b.Property<int>("IdOsiedla")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("longtext");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("postyForum");
                });

            modelBuilder.Entity("API.Entities.Uzytkownik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("typ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("uzytkownicy");
                });

            modelBuilder.Entity("API.Entities.UzytkownikWspolnotaAsocjacja", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idUzytkownika")
                        .HasColumnType("int");

                    b.Property<int>("idWspolnoty")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("uzytkownicyWspolnotyAsocjace");
                });

            modelBuilder.Entity("API.Entities.Wiadomosc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idKonwersacji")
                        .HasColumnType("int");

                    b.Property<int>("idWysylajacego")
                        .HasColumnType("int");

                    b.Property<string>("trescWiadomosci")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("wiadomosci");
                });

            modelBuilder.Entity("API.Entities.Wspolnota", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("miasto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("wspolnoty");
                });
#pragma warning restore 612, 618
        }
    }
}
