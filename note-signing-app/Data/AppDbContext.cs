using System;
using System.Collections.Generic;
using note_signing_app.Models;
using Microsoft.EntityFrameworkCore;

namespace note_signing_app.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sa1010> Sa1010s { get; set; }

    public virtual DbSet<Sf2010> Sf2010s { get; set; }

    public virtual DbSet<Zxo010> Zxo010s { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("PRODATA_2")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Sa1010>(entity =>
        {
            entity.HasKey(e => e.RECNO).HasName("SA1010_PK");

            entity.ToTable("SA1010");

            entity.HasIndex(e => new { e.A1Filial, e.A1Cod, e.A1Loja, e.RECNO, e.DELET }, "SA10101");

            entity.HasIndex(e => new { e.A1Filial, e.A1Nome, e.A1Loja, e.RECNO, e.DELET }, "SA10102");

            entity.HasIndex(e => new { e.A1Filial, e.A1Cgc, e.RECNO, e.DELET }, "SA10103");

            entity.HasIndex(e => new { e.A1Filial, e.A1Tel, e.A1Ddd, e.A1Ddi, e.RECNO, e.DELET }, "SA10104");

            entity.HasIndex(e => new { e.A1Filial, e.A1Nreduz, e.RECNO, e.DELET }, "SA10105");

            entity.HasIndex(e => new { e.A1Filial, e.A1Grpven, e.RECNO, e.DELET }, "SA10106");

            entity.HasIndex(e => new { e.A1Filial, e.A1Numra, e.RECNO, e.DELET }, "SA10107");

            entity.HasIndex(e => new { e.A1Filial, e.A1Vinculo, e.RECNO, e.DELET }, "SA10108");

            entity.HasIndex(e => new { e.A1Filial, e.A1Idhist, e.RECNO, e.DELET }, "SA10109");

            entity.HasIndex(e => new { e.A1Filial, e.A1Vend, e.A1Cod, e.A1Loja, e.RECNO, e.DELET }, "SA1010A");

            entity.HasIndex(e => new { e.A1Filial, e.A1Clipri, e.A1Lojpri, e.A1Cod, e.A1Loja, e.RECNO, e.DELET }, "SA1010B");

            entity.HasIndex(e => new { e.A1Filial, e.A1Situa, e.RECNO, e.DELET }, "SA1010C");

            entity.HasIndex(e => new { e.A1Filial, e.A1Conta, e.RECNO, e.DELET }, "SA1010D");

            entity.HasIndex(e => new { e.A1Filial, e.A1Cod, e.A1Loja, e.RECDEL }, "SA1010_UNQ").IsUnique();

            entity.Property(e => e.RECNO)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("R_E_C_N_O_");
            entity.Property(e => e.A1Abatimp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ABATIMP");
            entity.Property(e => e.A1Abics)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("'    ' ")
                .IsFixedLength()
                .HasColumnName("A1_ABICS");
            entity.Property(e => e.A1Agreg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("'    ' ")
                .IsFixedLength()
                .HasColumnName("A1_AGREG");
            entity.Property(e => e.A1Alifixa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ALIFIXA");
            entity.Property(e => e.A1Aliqir)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_ALIQIR");
            entity.Property(e => e.A1Asstec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ASSTEC");
            entity.Property(e => e.A1Atend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ATEND");
            entity.Property(e => e.A1Ativida)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("'       ' ")
                .IsFixedLength()
                .HasColumnName("A1_ATIVIDA");
            entity.Property(e => e.A1Atr)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_ATR");
            entity.Property(e => e.A1B2b)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_B2B");
            entity.Property(e => e.A1Bairro)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'                              ' ")
                .IsFixedLength()
                .HasColumnName("A1_BAIRRO");
            entity.Property(e => e.A1Bairroc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'                              ' ")
                .IsFixedLength()
                .HasColumnName("A1_BAIRROC");
            entity.Property(e => e.A1Bairroe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_BAIRROE");
            entity.Property(e => e.A1Bco1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_BCO1");
            entity.Property(e => e.A1Bco2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_BCO2");
            entity.Property(e => e.A1Bco3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_BCO3");
            entity.Property(e => e.A1Bco4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_BCO4");
            entity.Property(e => e.A1Bco5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_BCO5");
            entity.Property(e => e.A1Blemail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_BLEMAIL");
            entity.Property(e => e.A1Boleto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_BOLETO");
            entity.Property(e => e.A1Calcsuf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CALCSUF");
            entity.Property(e => e.A1Cargo1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_CARGO1");
            entity.Property(e => e.A1Cargo2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_CARGO2");
            entity.Property(e => e.A1Cargo3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_CARGO3");
            entity.Property(e => e.A1Cbairre)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CBAIRRE");
            entity.Property(e => e.A1Cbo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("'       ' ")
                .IsFixedLength()
                .HasColumnName("A1_CBO");
            entity.Property(e => e.A1Cdrdes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CDRDES");
            entity.Property(e => e.A1Ceinss)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("'              ' ")
                .IsFixedLength()
                .HasColumnName("A1_CEINSS");
            entity.Property(e => e.A1Cep)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_CEP");
            entity.Property(e => e.A1Cepc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_CEPC");
            entity.Property(e => e.A1Cepe)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_CEPE");
            entity.Property(e => e.A1Cgc)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("'              ' ")
                .IsFixedLength()
                .HasColumnName("A1_CGC");
            entity.Property(e => e.A1Chqdevo)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_CHQDEVO");
            entity.Property(e => e.A1Chvcam)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("'              ' ")
                .IsFixedLength()
                .HasColumnName("A1_CHVCAM");
            entity.Property(e => e.A1Classe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CLASSE");
            entity.Property(e => e.A1Clasven)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CLASVEN");
            entity.Property(e => e.A1Clicnv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CLICNV");
            entity.Property(e => e.A1Clifat)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CLIFAT");
            entity.Property(e => e.A1Clipri)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CLIPRI");
            entity.Property(e => e.A1Cnae)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("A1_CNAE");
            entity.Property(e => e.A1Cod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_COD");
            entity.Property(e => e.A1CodMun)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_COD_MUN");
            entity.Property(e => e.A1Codage)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODAGE");
            entity.Property(e => e.A1Codfid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                        ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODFID");
            entity.Property(e => e.A1Codfor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODFOR");
            entity.Property(e => e.A1Codhist)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODHIST");
            entity.Property(e => e.A1Codloc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODLOC");
            entity.Property(e => e.A1Codmarc)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODMARC");
            entity.Property(e => e.A1Codmemb)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("'              ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODMEMB");
            entity.Property(e => e.A1Codmun)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODMUN");
            entity.Property(e => e.A1Codmune)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODMUNE");
            entity.Property(e => e.A1Codpais)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODPAIS");
            entity.Property(e => e.A1Codseg)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODSEG");
            entity.Property(e => e.A1Codsiaf)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("'    ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODSIAF");
            entity.Property(e => e.A1Codter)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_CODTER");
            entity.Property(e => e.A1Comage)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_COMAGE");
            entity.Property(e => e.A1Comis)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_COMIS");
            entity.Property(e => e.A1Compent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_COMPENT");
            entity.Property(e => e.A1Complem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_COMPLEM");
            entity.Property(e => e.A1Cond)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_COND");
            entity.Property(e => e.A1Condpag)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_CONDPAG");
            entity.Property(e => e.A1Condpct)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_CONDPCT");
            entity.Property(e => e.A1Conta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_CONTA");
            entity.Property(e => e.A1Contab)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_CONTAB");
            entity.Property(e => e.A1Contato)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'                              ' ")
                .IsFixedLength()
                .HasColumnName("A1_CONTATO");
            entity.Property(e => e.A1Contrib)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CONTRIB");
            entity.Property(e => e.A1Crdma)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CRDMA");
            entity.Property(e => e.A1Ctare)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_CTARE");
            entity.Property(e => e.A1Cxposta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_CXPOSTA");
            entity.Property(e => e.A1Ddd)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_DDD");
            entity.Property(e => e.A1Ddi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_DDI");
            entity.Property(e => e.A1Decmun)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_DECMUN");
            entity.Property(e => e.A1Desc)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_DESC");
            entity.Property(e => e.A1Dest1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_DEST_1");
            entity.Property(e => e.A1Dest2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_DEST_2");
            entity.Property(e => e.A1Dest3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_DEST_3");
            entity.Property(e => e.A1Diaspag)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_DIASPAG");
            entity.Property(e => e.A1Dscreg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_DSCREG");
            entity.Property(e => e.A1Dtcad)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_DTCAD");
            entity.Property(e => e.A1Dtfimv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_DTFIMV");
            entity.Property(e => e.A1Dtiniv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_DTINIV");
            entity.Property(e => e.A1Dtnasc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_DTNASC");
            entity.Property(e => e.A1Dtulchq)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_DTULCHQ");
            entity.Property(e => e.A1Dtultit)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_DTULTIT");
            entity.Property(e => e.A1Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_EMAIL");
            entity.Property(e => e.A1End)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_END");
            entity.Property(e => e.A1Endcob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ENDCOB");
            entity.Property(e => e.A1Endent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ENDENT");
            entity.Property(e => e.A1Endnot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ENDNOT");
            entity.Property(e => e.A1Endrec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                        ' ")
                .IsFixedLength()
                .HasColumnName("A1_ENDREC");
            entity.Property(e => e.A1Entid)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ENTID");
            entity.Property(e => e.A1Entori)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_ENTORI");
            entity.Property(e => e.A1Est)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_EST");
            entity.Property(e => e.A1Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_ESTADO");
            entity.Property(e => e.A1Estc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ESTC");
            entity.Property(e => e.A1Este)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ESTE");
            entity.Property(e => e.A1Fax)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_FAX");
            entity.Property(e => e.A1Fildeb)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_FILDEB");
            entity.Property(e => e.A1Filial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_FILIAL");
            entity.Property(e => e.A1Filtrf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_FILTRF");
            entity.Property(e => e.A1Fomezer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_FOMEZER");
            entity.Property(e => e.A1Formvis)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_FORMVIS");
            entity.Property(e => e.A1Fretiss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_FRETISS");
            entity.Property(e => e.A1Frota)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_FROTA");
            entity.Property(e => e.A1Garagem)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_GARAGEM");
            entity.Property(e => e.A1Grptrib)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_GRPTRIB");
            entity.Property(e => e.A1Grpven)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_GRPVEN");
            entity.Property(e => e.A1Guiche)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_GUICHE");
            entity.Property(e => e.A1Hpage)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'                              ' ")
                .IsFixedLength()
                .HasColumnName("A1_HPAGE");
            entity.Property(e => e.A1Hrcad)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_HRCAD");
            entity.Property(e => e.A1Hrexpo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_HREXPO");
            entity.Property(e => e.A1Hrtrans)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_HRTRANS");
            entity.Property(e => e.A1Ibge)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("'           ' ")
                .IsFixedLength()
                .HasColumnName("A1_IBGE");
            entity.Property(e => e.A1Idestn)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'                              ' ")
                .IsFixedLength()
                .HasColumnName("A1_IDESTN");
            entity.Property(e => e.A1Idhist)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_IDHIST");
            entity.Property(e => e.A1Iencont)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_IENCONT");
            entity.Property(e => e.A1Imgumov)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                                                                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_IMGUMOV");
            entity.Property(e => e.A1Inciss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_INCISS");
            entity.Property(e => e.A1Incltmg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_INCLTMG");
            entity.Property(e => e.A1Incult)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_INCULT");
            entity.Property(e => e.A1Indret)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_INDRET");
            entity.Property(e => e.A1Inovaut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_INOVAUT");
            entity.Property(e => e.A1Inscr)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("'                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_INSCR");
            entity.Property(e => e.A1Inscrm)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("'                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_INSCRM");
            entity.Property(e => e.A1Inscrur)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("'                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_INSCRUR");
            entity.Property(e => e.A1Ipweb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_IPWEB");
            entity.Property(e => e.A1Irbax)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_IRBAX");
            entity.Property(e => e.A1Issrslc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ISSRSLC");
            entity.Property(e => e.A1Lc)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_LC");
            entity.Property(e => e.A1Lcfin)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_LCFIN");
            entity.Property(e => e.A1Loccons)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_LOCCONS");
            entity.Property(e => e.A1Loja)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_LOJA");
            entity.Property(e => e.A1Lojpri)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_LOJPRI");
            entity.Property(e => e.A1Maidupl)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_MAIDUPL");
            entity.Property(e => e.A1Matfun)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_MATFUN");
            entity.Property(e => e.A1Matr)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_MATR");
            entity.Property(e => e.A1Mcompra)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_MCOMPRA");
            entity.Property(e => e.A1Mensage)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_MENSAGE");
            entity.Property(e => e.A1Metr)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_METR");
            entity.Property(e => e.A1Minirf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_MINIRF");
            entity.Property(e => e.A1Moedalc)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_MOEDALC");
            entity.Property(e => e.A1Msaldo)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_MSALDO");
            entity.Property(e => e.A1Msblql)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_MSBLQL");
            entity.Property(e => e.A1Msexp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_MSEXP");
            entity.Property(e => e.A1Mun)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                            ' ")
                .IsFixedLength()
                .HasColumnName("A1_MUN");
            entity.Property(e => e.A1Munc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_MUNC");
            entity.Property(e => e.A1Mune)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                            ' ")
                .IsFixedLength()
                .HasColumnName("A1_MUNE");
            entity.Property(e => e.A1Naturez)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("A1_NATUREZ");
            entity.Property(e => e.A1Nif)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                        ' ")
                .IsFixedLength()
                .HasColumnName("A1_NIF");
            entity.Property(e => e.A1Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_NOME");
            entity.Property(e => e.A1Nreduz)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("A1_NREDUZ");
            entity.Property(e => e.A1Nrocom)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_NROCOM");
            entity.Property(e => e.A1Nropag)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_NROPAG");
            entity.Property(e => e.A1Numra)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_NUMRA");
            entity.Property(e => e.A1Nvestn)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_NVESTN");
            entity.Property(e => e.A1Obs)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_OBS");
            entity.Property(e => e.A1Observ)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                        ' ")
                .IsFixedLength()
                .HasColumnName("A1_OBSERV");
            entity.Property(e => e.A1Obsfis)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                                                                                                                                                                                                                          ' ")
                .IsFixedLength()
                .HasColumnName("A1_OBSFIS");
            entity.Property(e => e.A1Origct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ORIGCT");
            entity.Property(e => e.A1Origem)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_ORIGEM");
            entity.Property(e => e.A1Outrmun)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("A1_OUTRMUN");
            entity.Property(e => e.A1Pagatr)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_PAGATR");
            entity.Property(e => e.A1Pais)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_PAIS");
            entity.Property(e => e.A1Percatm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_PERCATM");
            entity.Property(e => e.A1Perfecp)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_PERFECP");
            entity.Property(e => e.A1Perfil)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_PERFIL");
            entity.Property(e => e.A1Pessoa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_PESSOA");
            entity.Property(e => e.A1Pfisica)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("'                  ' ")
                .IsFixedLength()
                .HasColumnName("A1_PFISICA");
            entity.Property(e => e.A1PrfCod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_PRF_COD");
            entity.Property(e => e.A1PrfObs)
                .HasColumnType("BLOB")
                .HasColumnName("A1_PRF_OBS");
            entity.Property(e => e.A1PrfVld)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_PRF_VLD");
            entity.Property(e => e.A1Pricom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_PRICOM");
            entity.Property(e => e.A1Prior)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_PRIOR");
            entity.Property(e => e.A1Prstser)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_PRSTSER");
            entity.Property(e => e.A1Reccofi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECCOFI");
            entity.Property(e => e.A1Reccsll)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECCSLL");
            entity.Property(e => e.A1Recfet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECFET");
            entity.Property(e => e.A1Recfmd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECFMD");
            entity.Property(e => e.A1Recinss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECINSS");
            entity.Property(e => e.A1Recirrf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECIRRF");
            entity.Property(e => e.A1Reciss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECISS");
            entity.Property(e => e.A1Recpis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RECPIS");
            entity.Property(e => e.A1Regesim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_REGESIM");
            entity.Property(e => e.A1Regiao)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_REGIAO");
            entity.Property(e => e.A1Regpb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_REGPB");
            entity.Property(e => e.A1Reserve)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RESERVE");
            entity.Property(e => e.A1Resfat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RESFAT");
            entity.Property(e => e.A1Rfabov)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RFABOV");
            entity.Property(e => e.A1Rfacs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RFACS");
            entity.Property(e => e.A1Rfasemt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RFASEMT");
            entity.Property(e => e.A1Rfundes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RFUNDES");
            entity.Property(e => e.A1Rg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_RG");
            entity.Property(e => e.A1Rimamt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RIMAMT");
            entity.Property(e => e.A1Risco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_RISCO");
            entity.Property(e => e.A1Rtec)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_RTEC");
            entity.Property(e => e.A1Saldup)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALDUP");
            entity.Property(e => e.A1Saldupm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALDUPM");
            entity.Property(e => e.A1Salfin)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALFIN");
            entity.Property(e => e.A1Salfinm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALFINM");
            entity.Property(e => e.A1Salped)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALPED");
            entity.Property(e => e.A1Salpedb)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALPEDB");
            entity.Property(e => e.A1Salpedl)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_SALPEDL");
            entity.Property(e => e.A1Sativ1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV1");
            entity.Property(e => e.A1Sativ2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV2");
            entity.Property(e => e.A1Sativ3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV3");
            entity.Property(e => e.A1Sativ4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV4");
            entity.Property(e => e.A1Sativ5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV5");
            entity.Property(e => e.A1Sativ6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV6");
            entity.Property(e => e.A1Sativ7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV7");
            entity.Property(e => e.A1Sativ8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SATIV8");
            entity.Property(e => e.A1Simples)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_SIMPLES");
            entity.Property(e => e.A1Simpnac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_SIMPNAC");
            entity.Property(e => e.A1Situa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_SITUA");
            entity.Property(e => e.A1Subcod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_SUBCOD");
            entity.Property(e => e.A1Suframa)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("A1_SUFRAMA");
            entity.Property(e => e.A1Super)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_SUPER");
            entity.Property(e => e.A1Tabela)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("A1_TABELA");
            entity.Property(e => e.A1Tda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TDA");
            entity.Property(e => e.A1Tel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("A1_TEL");
            entity.Property(e => e.A1Telex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("A1_TELEX");
            entity.Property(e => e.A1Temvis)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_TEMVIS");
            entity.Property(e => e.A1Timekee)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_TIMEKEE");
            entity.Property(e => e.A1Tipcli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TIPCLI");
            entity.Property(e => e.A1Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TIPO");
            entity.Property(e => e.A1Tipocli)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_TIPOCLI");
            entity.Property(e => e.A1Tipper)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_TIPPER");
            entity.Property(e => e.A1Tipprfl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TIPPRFL");
            entity.Property(e => e.A1Titprot)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_TITPROT");
            entity.Property(e => e.A1Tmpstd)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_TMPSTD");
            entity.Property(e => e.A1Tmpvis)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("A1_TMPVIS");
            entity.Property(e => e.A1Tpcamp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPCAMP");
            entity.Property(e => e.A1Tpdp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPDP");
            entity.Property(e => e.A1Tpessoa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPESSOA");
            entity.Property(e => e.A1Tpfret)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPFRET");
            entity.Property(e => e.A1Tpissrs)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPISSRS");
            entity.Property(e => e.A1Tpj)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPJ");
            entity.Property(e => e.A1Tpmemb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPMEMB");
            entity.Property(e => e.A1Tpnfse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPNFSE");
            entity.Property(e => e.A1Tpreg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TPREG");
            entity.Property(e => e.A1Transf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TRANSF");
            entity.Property(e => e.A1Transp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_TRANSP");
            entity.Property(e => e.A1Tribfav)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_TRIBFAV");
            entity.Property(e => e.A1Ultcom)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_ULTCOM");
            entity.Property(e => e.A1Ultvis)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_ULTVIS");
            entity.Property(e => e.A1Unidven)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_UNIDVEN");
            entity.Property(e => e.A1Usadda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_USADDA");
            entity.Property(e => e.A1Usaldoi)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_USALDOI");
            entity.Property(e => e.A1Userlga)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("'                 ' ")
                .IsFixedLength()
                .HasColumnName("A1_USERLGA");
            entity.Property(e => e.A1Userlgi)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("'                 ' ")
                .IsFixedLength()
                .HasColumnName("A1_USERLGI");
            entity.Property(e => e.A1Vacum)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("A1_VACUM");
            entity.Property(e => e.A1Venclc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("A1_VENCLC");
            entity.Property(e => e.A1Vend)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("A1_VEND");
            entity.Property(e => e.A1Vinculo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("A1_VINCULO");
            entity.Property(e => e.A1Zirrf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ZIRRF");
            entity.Property(e => e.A1Ziss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("A1_ZISS");
            entity.Property(e => e.DELET)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("D_E_L_E_T_");
            entity.Property(e => e.RECDEL)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("R_E_C_D_E_L_");
        });

        modelBuilder.Entity<Sf2010>(entity =>
        {
            entity.HasKey(e => e.RECNO).HasName("SF2010_PK");

            entity.ToTable("SF2010");

            entity.HasIndex(e => new { e.F2Ok, e.F2Filial, e.F2Emissao, e.F2Serie, e.F2Doc, e.DELET }, "IDX_SF2010_001");

            entity.HasIndex(e => new { e.F2Fimp, e.F2Filial, e.F2Chvnfe, e.F2Especie, e.F2Emissao, e.DELET }, "IDX_SF2010_002");

            entity.HasIndex(e => new { e.F2Tipo, e.F2Filial, e.F2Doc, e.F2Serie, e.F2Cliente, e.F2Loja, e.DELET }, "IDX_SF2010_003");

            entity.HasIndex(e => new { e.F2Doc, e.F2Serie, e.F2Cliente, e.F2Loja, e.F2Filial, e.F2Tipo, e.DELET }, "IDX_SF2010_004");

            entity.HasIndex(e => new { e.F2Filial, e.F2Doc, e.F2Serie, e.F2Cliente, e.F2Loja, e.F2Formul, e.F2Tipo, e.RECNO, e.DELET }, "SF20101");

            entity.HasIndex(e => new { e.F2Filial, e.F2Cliente, e.F2Loja, e.F2Doc, e.F2Serie, e.F2Tipo, e.F2Especie, e.RECNO, e.DELET }, "SF20102");

            entity.HasIndex(e => new { e.F2Filial, e.F2Ecf, e.F2Emissao, e.F2Pdv, e.F2Serie, e.F2Mapa, e.F2Doc, e.RECNO, e.DELET }, "SF20103");

            entity.HasIndex(e => new { e.F2Filial, e.F2Serie, e.F2Emissao, e.F2Doc, e.F2Cliente, e.F2Loja, e.RECNO, e.DELET }, "SF20104");

            entity.HasIndex(e => new { e.F2Filial, e.F2Carga, e.F2Seqcar, e.F2Serie, e.F2Doc, e.F2Cliente, e.F2Loja, e.RECNO, e.DELET }, "SF20105");

            entity.HasIndex(e => new { e.F2Filial, e.F2Seriori, e.F2Nfori, e.RECNO, e.DELET }, "SF20106");

            entity.HasIndex(e => new { e.F2Filial, e.F2Hawb, e.RECNO, e.DELET }, "SF20107");

            entity.HasIndex(e => new { e.F2Filial, e.F2Nfeletr, e.F2Eminfe, e.F2Cliente, e.F2Loja, e.RECNO, e.DELET }, "SF20108");

            entity.HasIndex(e => new { e.F2Filial, e.F2Nodia, e.RECNO, e.DELET }, "SF20109");

            entity.HasIndex(e => new { e.F2Filial, e.F2Doc, e.F2Sdoc, e.F2Cliente, e.F2Loja, e.F2Formul, e.F2Tipo, e.RECNO, e.DELET }, "SF2010B");

            entity.HasIndex(e => new { e.F2Filial, e.F2Cliente, e.F2Loja, e.F2Doc, e.F2Sdoc, e.RECNO, e.DELET }, "SF2010C");

            entity.HasIndex(e => new { e.F2Filial, e.F2Ecf, e.F2Emissao, e.F2Pdv, e.F2Sdoc, e.F2Mapa, e.F2Doc, e.RECNO, e.DELET }, "SF2010D");

            entity.HasIndex(e => new { e.F2Filial, e.F2Sdoc, e.F2Emissao, e.F2Doc, e.F2Cliente, e.F2Loja, e.RECNO, e.DELET }, "SF2010E");

            entity.HasIndex(e => new { e.F2Filial, e.F2Carga, e.F2Seqcar, e.F2Sdoc, e.F2Doc, e.F2Cliente, e.F2Loja, e.RECNO, e.DELET }, "SF2010F");

            entity.HasIndex(e => new { e.F2Filial, e.F2Sdocori, e.F2Nfori, e.RECNO, e.DELET }, "SF2010G");

            entity.HasIndex(e => new { e.F2Filial, e.F2Emissao, e.F2Hora, e.RECNO, e.DELET }, "SF2010H");

            entity.HasIndex(e => new { e.F2Filial, e.F2Idnf, e.RECNO, e.DELET }, "SF2010J");

            entity.HasIndex(e => new { e.F2Chvnfe, e.DELET }, "SF2010_001");

            entity.HasIndex(e => e.F2Msuidt, "SF2010_F2_MSUIDT_UUID");

            entity.HasIndex(e => e.STAMP, "SF2010_ST");

            entity.HasIndex(e => new { e.F2Filial, e.F2Doc, e.F2Serie, e.F2Cliente, e.F2Loja, e.RECDEL }, "SF2010_UNQ").IsUnique();

            entity.Property(e => e.RECNO)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("R_E_C_N_O_");
            entity.Property(e => e.DELET)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("D_E_L_E_T_");
            entity.Property(e => e.F2Bascofi)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASCOFI");
            entity.Property(e => e.F2Bascsll)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASCSLL");
            entity.Property(e => e.F2Basecf3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASECF3");
            entity.Property(e => e.F2Basecpm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASECPM");
            entity.Property(e => e.F2Basefmp)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEFMP");
            entity.Property(e => e.F2Basefun)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEFUN");
            entity.Property(e => e.F2Baseicm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEICM");
            entity.Property(e => e.F2Baseina)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEINA");
            entity.Property(e => e.F2Baseins)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEINS");
            entity.Property(e => e.F2Baseipi)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEIPI");
            entity.Property(e => e.F2Baseirr)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEIRR");
            entity.Property(e => e.F2Baseiss)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEISS");
            entity.Property(e => e.F2Baseps3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASEPS3");
            entity.Property(e => e.F2Basetst)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASETST");
            entity.Property(e => e.F2Basfecp)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASFECP");
            entity.Property(e => e.F2Basimp1)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASIMP1");
            entity.Property(e => e.F2Basimp2)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASIMP2");
            entity.Property(e => e.F2Basimp3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASIMP3");
            entity.Property(e => e.F2Basimp4)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASIMP4");
            entity.Property(e => e.F2Basimp5)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASIMP5");
            entity.Property(e => e.F2Basimp6)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASIMP6");
            entity.Property(e => e.F2Baspis)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BASPIS");
            entity.Property(e => e.F2Bricms)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BRICMS");
            entity.Property(e => e.F2Bsfccmp)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BSFCCMP");
            entity.Property(e => e.F2Bsfcpst)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BSFCPST");
            entity.Property(e => e.F2Bsrein)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_BSREIN");
            entity.Property(e => e.F2Carga)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CARGA");
            entity.Property(e => e.F2Cgccli)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("'              ' ")
                .IsFixedLength()
                .HasColumnName("F2_CGCCLI");
            entity.Property(e => e.F2Chvcle)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("'              ' ")
                .IsFixedLength()
                .HasColumnName("F2_CHVCLE");
            entity.Property(e => e.F2Chvnfe)
                .HasMaxLength(44)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                            ' ")
                .IsFixedLength()
                .HasColumnName("F2_CHVNFE");
            entity.Property(e => e.F2Cleok)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("'    ' ")
                .IsFixedLength()
                .HasColumnName("F2_CLEOK");
            entity.Property(e => e.F2Client)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CLIENT");
            entity.Property(e => e.F2Cliente)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CLIENTE");
            entity.Property(e => e.F2Clirem)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CLIREM");
            entity.Property(e => e.F2Cliret)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CLIRET");
            entity.Property(e => e.F2Cmunde)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("F2_CMUNDE");
            entity.Property(e => e.F2Cmunor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("F2_CMUNOR");
            entity.Property(e => e.F2Cno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CNO");
            entity.Property(e => e.F2Coda1u)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_CODA1U");
            entity.Property(e => e.F2Codmoed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_CODMOED");
            entity.Property(e => e.F2Codnfe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                  ' ")
                .IsFixedLength()
                .HasColumnName("F2_CODNFE");
            entity.Property(e => e.F2Codrgs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_CODRGS");
            entity.Property(e => e.F2Cond)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_COND");
            entity.Property(e => e.F2Contsoc)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_CONTSOC");
            entity.Property(e => e.F2Crednfe)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_CREDNFE");
            entity.Property(e => e.F2Dautnfe)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DAUTNFE");
            entity.Property(e => e.F2Desccab)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_DESCCAB");
            entity.Property(e => e.F2Descont)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_DESCONT");
            entity.Property(e => e.F2Desczfr)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_DESCZFR");
            entity.Property(e => e.F2Despach)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("'           ' ")
                .IsFixedLength()
                .HasColumnName("F2_DESPACH");
            entity.Property(e => e.F2Despesa)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_DESPESA");
            entity.Property(e => e.F2Diactb)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_DIACTB");
            entity.Property(e => e.F2Doc)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_DOC");
            entity.Property(e => e.F2Dtbase0)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTBASE0");
            entity.Property(e => e.F2Dtbase1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTBASE1");
            entity.Property(e => e.F2Dtdigit)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTDIGIT");
            entity.Property(e => e.F2Dtentr)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTENTR");
            entity.Property(e => e.F2Dteserv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTESERV");
            entity.Property(e => e.F2Dtexp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTEXP");
            entity.Property(e => e.F2Dtlanc)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTLANC");
            entity.Property(e => e.F2Dtreaj)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTREAJ");
            entity.Property(e => e.F2Dttxref)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_DTTXREF");
            entity.Property(e => e.F2Dupl)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_DUPL");
            entity.Property(e => e.F2Ecf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_ECF");
            entity.Property(e => e.F2Eminfe)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_EMINFE");
            entity.Property(e => e.F2Emissao)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_EMISSAO");
            entity.Property(e => e.F2Especi1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_ESPECI1");
            entity.Property(e => e.F2Especi2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_ESPECI2");
            entity.Property(e => e.F2Especi3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_ESPECI3");
            entity.Property(e => e.F2Especi4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_ESPECI4");
            entity.Property(e => e.F2Especie)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("F2_ESPECIE");
            entity.Property(e => e.F2Est)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_EST");
            entity.Property(e => e.F2Estcred)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_ESTCRED");
            entity.Property(e => e.F2Estpres)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_ESTPRES");
            entity.Property(e => e.F2Evenflg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_EVENFLG");
            entity.Property(e => e.F2Fatorb0)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_FATORB0");
            entity.Property(e => e.F2Fatorb1)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_FATORB1");
            entity.Property(e => e.F2Fildest)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_FILDEST");
            entity.Property(e => e.F2Filial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_FILIAL");
            entity.Property(e => e.F2Fimp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_FIMP");
            entity.Property(e => e.F2Flagdev)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_FLAGDEV");
            entity.Property(e => e.F2Flagrgs)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("'    ' ")
                .IsFixedLength()
                .HasColumnName("F2_FLAGRGS");
            entity.Property(e => e.F2Fordes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_FORDES");
            entity.Property(e => e.F2Formdes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_FORMDES");
            entity.Property(e => e.F2Formul)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_FORMUL");
            entity.Property(e => e.F2Fretaut)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_FRETAUT");
            entity.Property(e => e.F2Frete)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_FRETE");
            entity.Property(e => e.F2Frtcfop)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("F2_FRTCFOP");
            entity.Property(e => e.F2Gnrdif)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_GNRDIF");
            entity.Property(e => e.F2Gnrfecp)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_GNRFECP");
            entity.Property(e => e.F2Govoper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_GOVOPER");
            entity.Property(e => e.F2Hautnfe)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("F2_HAUTNFE");
            entity.Property(e => e.F2Hawb)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("F2_HAWB");
            entity.Property(e => e.F2Hora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("'     ' ")
                .IsFixedLength()
                .HasColumnName("F2_HORA");
            entity.Property(e => e.F2Hornfe)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_HORNFE");
            entity.Property(e => e.F2Icmauto)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_ICMAUTO");
            entity.Property(e => e.F2Icmfret)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_ICMFRET");
            entity.Property(e => e.F2Icmsdif)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_ICMSDIF");
            entity.Property(e => e.F2Icmsret)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_ICMSRET");
            entity.Property(e => e.F2Idcce)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                       '")
                .IsFixedLength()
                .HasColumnName("F2_IDCCE");
            entity.Property(e => e.F2Idcle)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDCLE");
            entity.Property(e => e.F2Idnf)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                    ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDNF");
            entity.Property(e => e.F2Idrecop)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDRECOP");
            entity.Property(e => e.F2Idrgs)
                .HasMaxLength(54)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                      ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDRGS");
            entity.Property(e => e.F2Idsa1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDSA1");
            entity.Property(e => e.F2Idsa2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDSA2");
            entity.Property(e => e.F2Idsed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("F2_IDSED");
            entity.Property(e => e.F2Loja)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_LOJA");
            entity.Property(e => e.F2Lojades)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_LOJADES");
            entity.Property(e => e.F2Lojarem)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_LOJAREM");
            entity.Property(e => e.F2Lojaret)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_LOJARET");
            entity.Property(e => e.F2Lojent)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_LOJENT");
            entity.Property(e => e.F2Lote)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_LOTE");
            entity.Property(e => e.F2Ltran)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                         ' ")
                .IsFixedLength()
                .HasColumnName("F2_LTRAN");
            entity.Property(e => e.F2Mapa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_MAPA");
            entity.Property(e => e.F2Mennota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                                            ' ")
                .IsFixedLength()
                .HasColumnName("F2_MENNOTA");
            entity.Property(e => e.F2Moeda)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_MOEDA");
            entity.Property(e => e.F2Msuidt)
                .HasDefaultValueSql("SYS_GUID()")
                .HasColumnName("F2_MSUIDT");
            entity.Property(e => e.F2Munpres)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("'       ' ")
                .IsFixedLength()
                .HasColumnName("F2_MUNPRES");
            entity.Property(e => e.F2Nextdoc)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_NEXTDOC");
            entity.Property(e => e.F2Nextser)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_NEXTSER");
            entity.Property(e => e.F2Nfcupom)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_NFCUPOM");
            entity.Property(e => e.F2Nfeacrs)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_NFEACRS");
            entity.Property(e => e.F2Nfeletr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'                    ' ")
                .IsFixedLength()
                .HasColumnName("F2_NFELETR");
            entity.Property(e => e.F2Nficmst)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_NFICMST");
            entity.Property(e => e.F2Nfori)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_NFORI");
            entity.Property(e => e.F2Nfsubst)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_NFSUBST");
            entity.Property(e => e.F2Nodia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_NODIA");
            entity.Property(e => e.F2Ntfecp)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_NTFECP");
            entity.Property(e => e.F2Numexp)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("'            ' ")
                .IsFixedLength()
                .HasColumnName("F2_NUMEXP");
            entity.Property(e => e.F2Nummdf)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_NUMMDF");
            entity.Property(e => e.F2Numorc)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_NUMORC");
            entity.Property(e => e.F2Ok)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("'    ' ")
                .IsFixedLength()
                .HasColumnName("F2_OK");
            entity.Property(e => e.F2Ordpago)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_ORDPAGO");
            entity.Property(e => e.F2Ordsep)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_ORDSEP");
            entity.Property(e => e.F2Pafmd5)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValueSql("'                                ' ")
                .IsFixedLength()
                .HasColumnName("F2_PAFMD5");
            entity.Property(e => e.F2Pbruto)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_PBRUTO");
            entity.Property(e => e.F2Pdv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("F2_PDV");
            entity.Property(e => e.F2Pedpend)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_PEDPEND");
            entity.Property(e => e.F2Pliqui)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_PLIQUI");
            entity.Property(e => e.F2Prefixo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_PREFIXO");
            entity.Property(e => e.F2Prefori)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_PREFORI");
            entity.Property(e => e.F2Reajust)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_REAJUST");
            entity.Property(e => e.F2Recfaut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_RECFAUT");
            entity.Property(e => e.F2Reciss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_RECISS");
            entity.Property(e => e.F2Recopi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_RECOPI");
            entity.Property(e => e.F2Redesp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_REDESP");
            entity.Property(e => e.F2Refmoed)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_REFMOED");
            entity.Property(e => e.F2Reftaxa)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_REFTAXA");
            entity.Property(e => e.F2Regiao)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_REGIAO");
            entity.Property(e => e.F2Sdoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SDOC");
            entity.Property(e => e.F2Sdocman)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SDOCMAN");
            entity.Property(e => e.F2Sdocmdf)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SDOCMDF");
            entity.Property(e => e.F2Sdocnxt)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SDOCNXT");
            entity.Property(e => e.F2Sdocori)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SDOCORI");
            entity.Property(e => e.F2Sdocsub)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SDOCSUB");
            entity.Property(e => e.F2Seguro)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_SEGURO");
            entity.Property(e => e.F2Seqcar)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_SEQCAR");
            entity.Property(e => e.F2Seqent)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_SEQENT");
            entity.Property(e => e.F2Serie)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SERIE");
            entity.Property(e => e.F2Seriori)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SERIORI");
            entity.Property(e => e.F2Sermdf)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SERMDF");
            entity.Property(e => e.F2Sersat)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_SERSAT");
            entity.Property(e => e.F2Sersubs)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_SERSUBS");
            entity.Property(e => e.F2Status)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("F2_STATUS");
            entity.Property(e => e.F2Tipimp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TIPIMP");
            entity.Property(e => e.F2Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TIPO");
            entity.Property(e => e.F2Tipocli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TIPOCLI");
            entity.Property(e => e.F2Tipodoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_TIPODOC");
            entity.Property(e => e.F2Tiporem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TIPOREM");
            entity.Property(e => e.F2Tiporet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TIPORET");
            entity.Property(e => e.F2Totest)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_TOTEST");
            entity.Property(e => e.F2Totfed)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_TOTFED");
            entity.Property(e => e.F2Totimp)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_TOTIMP");
            entity.Property(e => e.F2Totmun)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_TOTMUN");
            entity.Property(e => e.F2Tpcompl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TPCOMPL");
            entity.Property(e => e.F2Tpfrete)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TPFRETE");
            entity.Property(e => e.F2Tpnfexp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("F2_TPNFEXP");
            entity.Property(e => e.F2Transp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_TRANSP");
            entity.Property(e => e.F2Txmoeda)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_TXMOEDA");
            entity.Property(e => e.F2Txref)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_TXREF");
            entity.Property(e => e.F2Uctproj)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("F2_UCTPROJ");
            entity.Property(e => e.F2Ufdest)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_UFDEST");
            entity.Property(e => e.F2Uforig)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("F2_UFORIG");
            entity.Property(e => e.F2Userlga)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("'                 ' ")
                .IsFixedLength()
                .HasColumnName("F2_USERLGA");
            entity.Property(e => e.F2Userlgi)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasDefaultValueSql("'                 ' ")
                .IsFixedLength()
                .HasColumnName("F2_USERLGI");
            entity.Property(e => e.F2Valacrs)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALACRS");
            entity.Property(e => e.F2Valbrut)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALBRUT");
            entity.Property(e => e.F2Valcf3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALCF3");
            entity.Property(e => e.F2Valcofi)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALCOFI");
            entity.Property(e => e.F2Valcsll)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALCSLL");
            entity.Property(e => e.F2Valfab)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFAB");
            entity.Property(e => e.F2Valfac)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFAC");
            entity.Property(e => e.F2Valfase)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFASE");
            entity.Property(e => e.F2Valfat)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFAT");
            entity.Property(e => e.F2Valfds)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFDS");
            entity.Property(e => e.F2Valfet)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFET");
            entity.Property(e => e.F2Valfmd)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFMD");
            entity.Property(e => e.F2Valfmp)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFMP");
            entity.Property(e => e.F2Valfund)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALFUND");
            entity.Property(e => e.F2Valicm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALICM");
            entity.Property(e => e.F2Valima)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMA");
            entity.Property(e => e.F2Valimp1)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMP1");
            entity.Property(e => e.F2Valimp2)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMP2");
            entity.Property(e => e.F2Valimp3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMP3");
            entity.Property(e => e.F2Valimp4)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMP4");
            entity.Property(e => e.F2Valimp5)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMP5");
            entity.Property(e => e.F2Valimp6)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIMP6");
            entity.Property(e => e.F2Valina)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALINA");
            entity.Property(e => e.F2Valinss)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALINSS");
            entity.Property(e => e.F2Valipi)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIPI");
            entity.Property(e => e.F2Valirrf)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALIRRF");
            entity.Property(e => e.F2Valiss)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALISS");
            entity.Property(e => e.F2Valmerc)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALMERC");
            entity.Property(e => e.F2Valpis)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALPIS");
            entity.Property(e => e.F2Valps3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALPS3");
            entity.Property(e => e.F2Valtst)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VALTST");
            entity.Property(e => e.F2Variac)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VARIAC");
            entity.Property(e => e.F2Veicul1)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEICUL1");
            entity.Property(e => e.F2Veicul2)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEICUL2");
            entity.Property(e => e.F2Veicul3)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEICUL3");
            entity.Property(e => e.F2Vend1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEND1");
            entity.Property(e => e.F2Vend2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEND2");
            entity.Property(e => e.F2Vend3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEND3");
            entity.Property(e => e.F2Vend4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEND4");
            entity.Property(e => e.F2Vend5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("F2_VEND5");
            entity.Property(e => e.F2Vlcpm)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VLCPM");
            entity.Property(e => e.F2Vldespc)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VLDESPC");
            entity.Property(e => e.F2VlrFrt)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VLR_FRT");
            entity.Property(e => e.F2Vlsenar)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VLSENAR");
            entity.Property(e => e.F2Volume1)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VOLUME1");
            entity.Property(e => e.F2Volume2)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VOLUME2");
            entity.Property(e => e.F2Volume3)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VOLUME3");
            entity.Property(e => e.F2Volume4)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VOLUME4");
            entity.Property(e => e.F2Vreint)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("F2_VREINT");
            entity.Property(e => e.RECDEL)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("R_E_C_D_E_L_");
            entity.Property(e => e.STAMP)
                .HasPrecision(6)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("sys_extract_utc(systimestamp)")
                .HasColumnName("S_T_A_M_P_");
        });

        modelBuilder.Entity<Zxo010>(entity =>
        {
            entity.HasKey(e => e.RECNO).HasName("ZXO010_PK");

            entity.ToTable("ZXO010");

            entity.HasIndex(e => new { e.ZxoFilial, e.ZxoDoc, e.ZxoSerie, e.RECNO, e.DELET }, "ZXO0101");

            entity.HasIndex(e => new { e.ZxoFilial, e.ZxoClient, e.ZxoLoja, e.ZxoDoc, e.RECNO, e.DELET }, "ZXO0102");

            entity.HasIndex(e => new { e.ZxoFilial, e.ZxoData, e.ZxoDoc, e.ZxoSerie, e.RECNO, e.DELET }, "ZXO0103");

            entity.HasIndex(e => new { e.ZxoFilial, e.ZxoData, e.ZxoClient, e.RECNO, e.DELET }, "ZXO0104");

            entity.Property(e => e.RECNO)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("R_E_C_N_O_");
            entity.Property(e => e.DELET)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("' ' ")
                .IsFixedLength()
                .HasColumnName("D_E_L_E_T_");
            entity.Property(e => e.RECDEL)
                .HasDefaultValueSql("0.0 ")
                .HasColumnType("NUMBER")
                .HasColumnName("R_E_C_D_E_L_");
            entity.Property(e => e.ZxoClient)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("'      ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_CLIENT");
            entity.Property(e => e.ZxoData)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("'        ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_DATA");
            entity.Property(e => e.ZxoDoc)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("'         ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_DOC");
            entity.Property(e => e.ZxoFilial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_FILIAL");
            entity.Property(e => e.ZxoHora)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("'          ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_HORA");
            entity.Property(e => e.ZxoLoja)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("'  ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_LOJA");
            entity.Property(e => e.ZxoNome)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("'                              ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_NOME");
            entity.Property(e => e.ZxoRg)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("'               ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_RG");
            entity.Property(e => e.ZxoSerie)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'   ' ")
                .IsFixedLength()
                .HasColumnName("ZXO_SERIE");
        });
        modelBuilder.HasSequence("A1F6579CCF2B61004099F_SEQ");
        modelBuilder.HasSequence("A1N010_SEQ");
        modelBuilder.HasSequence("A1O010_SEQ");
        modelBuilder.HasSequence("A1P010_SEQ");
        modelBuilder.HasSequence("A1Q010_SEQ");
        modelBuilder.HasSequence("A1R010_SEQ");
        modelBuilder.HasSequence("A6E5D07DCF4161004_01_SEQ");
        modelBuilder.HasSequence("A6E5D07DCF4161004_02_SEQ");
        modelBuilder.HasSequence("AA0010_SEQ");
        modelBuilder.HasSequence("AB0010_SEQ");
        modelBuilder.HasSequence("AF5C026ACF7391004_01_SEQ");
        modelBuilder.HasSequence("AF5C026ACF7391004_02_SEQ");
        modelBuilder.HasSequence("C01020_SEQ");
        modelBuilder.HasSequence("C01030_SEQ");
        modelBuilder.HasSequence("C02020_SEQ");
        modelBuilder.HasSequence("C02030_SEQ");
        modelBuilder.HasSequence("C03020_SEQ");
        modelBuilder.HasSequence("C03030_SEQ");
        modelBuilder.HasSequence("C04020_SEQ");
        modelBuilder.HasSequence("C04030_SEQ");
        modelBuilder.HasSequence("C05020_SEQ");
        modelBuilder.HasSequence("C05030_SEQ");
        modelBuilder.HasSequence("C06020_SEQ");
        modelBuilder.HasSequence("C06030_SEQ");
        modelBuilder.HasSequence("C07020_SEQ");
        modelBuilder.HasSequence("C07030_SEQ");
        modelBuilder.HasSequence("C08010_SEQ");
        modelBuilder.HasSequence("C08020_SEQ");
        modelBuilder.HasSequence("C08030_SEQ");
        modelBuilder.HasSequence("C09020_SEQ");
        modelBuilder.HasSequence("C09030_SEQ");
        modelBuilder.HasSequence("C0A010_SEQ");
        modelBuilder.HasSequence("C0A020_SEQ");
        modelBuilder.HasSequence("C0A030_SEQ");
        modelBuilder.HasSequence("C0B020_SEQ");
        modelBuilder.HasSequence("C0B030_SEQ");
        modelBuilder.HasSequence("C0C020_SEQ");
        modelBuilder.HasSequence("C0C030_SEQ");
        modelBuilder.HasSequence("C0D020_SEQ");
        modelBuilder.HasSequence("C0D030_SEQ");
        modelBuilder.HasSequence("C0E020_SEQ");
        modelBuilder.HasSequence("C0E030_SEQ");
        modelBuilder.HasSequence("C0F020_SEQ");
        modelBuilder.HasSequence("C0F030_SEQ");
        modelBuilder.HasSequence("C0G020_SEQ");
        modelBuilder.HasSequence("C0G030_SEQ");
        modelBuilder.HasSequence("C0H020_SEQ");
        modelBuilder.HasSequence("C0H030_SEQ");
        modelBuilder.HasSequence("C0I020_SEQ");
        modelBuilder.HasSequence("C0I030_SEQ");
        modelBuilder.HasSequence("C0J020_SEQ");
        modelBuilder.HasSequence("C0J030_SEQ");
        modelBuilder.HasSequence("C0K020_SEQ");
        modelBuilder.HasSequence("C0K030_SEQ");
        modelBuilder.HasSequence("C0L020_SEQ");
        modelBuilder.HasSequence("C0L030_SEQ");
        modelBuilder.HasSequence("C0M020_SEQ");
        modelBuilder.HasSequence("C0M030_SEQ");
        modelBuilder.HasSequence("C0N020_SEQ");
        modelBuilder.HasSequence("C0N030_SEQ");
        modelBuilder.HasSequence("C0O020_SEQ");
        modelBuilder.HasSequence("C0O030_SEQ");
        modelBuilder.HasSequence("C0Q020_SEQ");
        modelBuilder.HasSequence("C0R020_SEQ");
        modelBuilder.HasSequence("C0S020_SEQ");
        modelBuilder.HasSequence("C0S030_SEQ");
        modelBuilder.HasSequence("C0T020_SEQ");
        modelBuilder.HasSequence("C0U020_SEQ");
        modelBuilder.HasSequence("C0U030_SEQ");
        modelBuilder.HasSequence("C0V020_SEQ");
        modelBuilder.HasSequence("C0V030_SEQ");
        modelBuilder.HasSequence("C0W020_SEQ");
        modelBuilder.HasSequence("C0X020_SEQ");
        modelBuilder.HasSequence("C0X030_SEQ");
        modelBuilder.HasSequence("C0Y020_SEQ");
        modelBuilder.HasSequence("C0Y030_SEQ");
        modelBuilder.HasSequence("C0Z020_SEQ");
        modelBuilder.HasSequence("C0Z030_SEQ");
        modelBuilder.HasSequence("C10020_SEQ");
        modelBuilder.HasSequence("C10030_SEQ");
        modelBuilder.HasSequence("C11020_SEQ");
        modelBuilder.HasSequence("C11030_SEQ");
        modelBuilder.HasSequence("C12020_SEQ");
        modelBuilder.HasSequence("C12030_SEQ");
        modelBuilder.HasSequence("C13020_SEQ");
        modelBuilder.HasSequence("C13030_SEQ");
        modelBuilder.HasSequence("C14020_SEQ");
        modelBuilder.HasSequence("C14030_SEQ");
        modelBuilder.HasSequence("C15020_SEQ");
        modelBuilder.HasSequence("C15030_SEQ");
        modelBuilder.HasSequence("C16020_SEQ");
        modelBuilder.HasSequence("C16030_SEQ");
        modelBuilder.HasSequence("C17020_SEQ");
        modelBuilder.HasSequence("C17030_SEQ");
        modelBuilder.HasSequence("C18020_SEQ");
        modelBuilder.HasSequence("C18030_SEQ");
        modelBuilder.HasSequence("C19020_SEQ");
        modelBuilder.HasSequence("C19030_SEQ");
        modelBuilder.HasSequence("C1A010_SEQ");
        modelBuilder.HasSequence("C1A020_SEQ");
        modelBuilder.HasSequence("C1A030_SEQ");
        modelBuilder.HasSequence("C1B020_SEQ");
        modelBuilder.HasSequence("C1B030_SEQ");
        modelBuilder.HasSequence("C1C020_SEQ");
        modelBuilder.HasSequence("C1C030_SEQ");
        modelBuilder.HasSequence("C1D020_SEQ");
        modelBuilder.HasSequence("C1D030_SEQ");
        modelBuilder.HasSequence("C1E010_SEQ");
        modelBuilder.HasSequence("C1E030_SEQ");
        modelBuilder.HasSequence("C1F020_SEQ");
        modelBuilder.HasSequence("C1F030_SEQ");
        modelBuilder.HasSequence("C1G010_SEQ");
        modelBuilder.HasSequence("C1G020_SEQ");
        modelBuilder.HasSequence("C1H020_SEQ");
        modelBuilder.HasSequence("C1I020_SEQ");
        modelBuilder.HasSequence("C1J020_SEQ");
        modelBuilder.HasSequence("C1K020_SEQ");
        modelBuilder.HasSequence("C1L020_SEQ");
        modelBuilder.HasSequence("C1M020_SEQ");
        modelBuilder.HasSequence("C1N020_SEQ");
        modelBuilder.HasSequence("C1O020_SEQ");
        modelBuilder.HasSequence("C1P020_SEQ");
        modelBuilder.HasSequence("C1Q020_SEQ");
        modelBuilder.HasSequence("C1Q030_SEQ");
        modelBuilder.HasSequence("C1R020_SEQ");
        modelBuilder.HasSequence("C1R030_SEQ");
        modelBuilder.HasSequence("C1S020_SEQ");
        modelBuilder.HasSequence("C1S030_SEQ");
        modelBuilder.HasSequence("C1T020_SEQ");
        modelBuilder.HasSequence("C1T030_SEQ");
        modelBuilder.HasSequence("C1U020_SEQ");
        modelBuilder.HasSequence("C1U030_SEQ");
        modelBuilder.HasSequence("C1V020_SEQ");
        modelBuilder.HasSequence("C1V030_SEQ");
        modelBuilder.HasSequence("C1W020_SEQ");
        modelBuilder.HasSequence("C1W030_SEQ");
        modelBuilder.HasSequence("C1X020_SEQ");
        modelBuilder.HasSequence("C1X030_SEQ");
        modelBuilder.HasSequence("C1Y020_SEQ");
        modelBuilder.HasSequence("C1Y030_SEQ");
        modelBuilder.HasSequence("C1Z020_SEQ");
        modelBuilder.HasSequence("C20010_SEQ");
        modelBuilder.HasSequence("C20020_SEQ");
        modelBuilder.HasSequence("C21020_SEQ");
        modelBuilder.HasSequence("C22020_SEQ");
        modelBuilder.HasSequence("C23020_SEQ");
        modelBuilder.HasSequence("C24020_SEQ");
        modelBuilder.HasSequence("C25020_SEQ");
        modelBuilder.HasSequence("C26020_SEQ");
        modelBuilder.HasSequence("C27020_SEQ");
        modelBuilder.HasSequence("C28020_SEQ");
        modelBuilder.HasSequence("C29020_SEQ");
        modelBuilder.HasSequence("C2A020_SEQ");
        modelBuilder.HasSequence("C2B020_SEQ");
        modelBuilder.HasSequence("C2C020_SEQ");
        modelBuilder.HasSequence("C2D020_SEQ");
        modelBuilder.HasSequence("C2E020_SEQ");
        modelBuilder.HasSequence("C2F020_SEQ");
        modelBuilder.HasSequence("C2G020_SEQ");
        modelBuilder.HasSequence("C2H020_SEQ");
        modelBuilder.HasSequence("C2I020_SEQ");
        modelBuilder.HasSequence("C2J020_SEQ");
        modelBuilder.HasSequence("C2K020_SEQ");
        modelBuilder.HasSequence("C2L020_SEQ");
        modelBuilder.HasSequence("C2M020_SEQ");
        modelBuilder.HasSequence("C2M030_SEQ");
        modelBuilder.HasSequence("C2N020_SEQ");
        modelBuilder.HasSequence("C2O020_SEQ");
        modelBuilder.HasSequence("C2P020_SEQ");
        modelBuilder.HasSequence("C2Q020_SEQ");
        modelBuilder.HasSequence("C2Q030_SEQ");
        modelBuilder.HasSequence("C2R020_SEQ");
        modelBuilder.HasSequence("C2R030_SEQ");
        modelBuilder.HasSequence("C2S020_SEQ");
        modelBuilder.HasSequence("C2T010_SEQ");
        modelBuilder.HasSequence("C2T020_SEQ");
        modelBuilder.HasSequence("C2U010_SEQ");
        modelBuilder.HasSequence("C2U020_SEQ");
        modelBuilder.HasSequence("C2V010_SEQ");
        modelBuilder.HasSequence("C2V020_SEQ");
        modelBuilder.HasSequence("C2X020_SEQ");
        modelBuilder.HasSequence("C2Z020_SEQ");
        modelBuilder.HasSequence("C30020_SEQ");
        modelBuilder.HasSequence("C31020_SEQ");
        modelBuilder.HasSequence("C32020_SEQ");
        modelBuilder.HasSequence("C33020_SEQ");
        modelBuilder.HasSequence("C34020_SEQ");
        modelBuilder.HasSequence("C35020_SEQ");
        modelBuilder.HasSequence("C36020_SEQ");
        modelBuilder.HasSequence("C37020_SEQ");
        modelBuilder.HasSequence("C38020_SEQ");
        modelBuilder.HasSequence("C39020_SEQ");
        modelBuilder.HasSequence("C3A020_SEQ");
        modelBuilder.HasSequence("C3B020_SEQ");
        modelBuilder.HasSequence("C3C020_SEQ");
        modelBuilder.HasSequence("C3D020_SEQ");
        modelBuilder.HasSequence("C3D030_SEQ");
        modelBuilder.HasSequence("C3E020_SEQ");
        modelBuilder.HasSequence("C3E030_SEQ");
        modelBuilder.HasSequence("C3F020_SEQ");
        modelBuilder.HasSequence("C3G020_SEQ");
        modelBuilder.HasSequence("C3H020_SEQ");
        modelBuilder.HasSequence("C3I020_SEQ");
        modelBuilder.HasSequence("C3J020_SEQ");
        modelBuilder.HasSequence("C3K020_SEQ");
        modelBuilder.HasSequence("C3L020_SEQ");
        modelBuilder.HasSequence("C3M020_SEQ");
        modelBuilder.HasSequence("C3N020_SEQ");
        modelBuilder.HasSequence("C3O020_SEQ");
        modelBuilder.HasSequence("C3P020_SEQ");
        modelBuilder.HasSequence("C3P030_SEQ");
        modelBuilder.HasSequence("C3Q020_SEQ");
        modelBuilder.HasSequence("C3R020_SEQ");
        modelBuilder.HasSequence("C3S020_SEQ");
        modelBuilder.HasSequence("C3S030_SEQ");
        modelBuilder.HasSequence("C3T020_SEQ");
        modelBuilder.HasSequence("C3T030_SEQ");
        modelBuilder.HasSequence("C3U020_SEQ");
        modelBuilder.HasSequence("C3U030_SEQ");
        modelBuilder.HasSequence("C3V020_SEQ");
        modelBuilder.HasSequence("C3V030_SEQ");
        modelBuilder.HasSequence("C3X020_SEQ");
        modelBuilder.HasSequence("C3X030_SEQ");
        modelBuilder.HasSequence("C3Z010_SEQ");
        modelBuilder.HasSequence("C3Z020_SEQ");
        modelBuilder.HasSequence("C3Z030_SEQ");
        modelBuilder.HasSequence("C40020_SEQ");
        modelBuilder.HasSequence("C41020_SEQ");
        modelBuilder.HasSequence("C41030_SEQ");
        modelBuilder.HasSequence("C42020_SEQ");
        modelBuilder.HasSequence("C42030_SEQ");
        modelBuilder.HasSequence("C43020_SEQ");
        modelBuilder.HasSequence("C44020_SEQ");
        modelBuilder.HasSequence("C45020_SEQ");
        modelBuilder.HasSequence("C46020_SEQ");
        modelBuilder.HasSequence("C47020_SEQ");
        modelBuilder.HasSequence("C48020_SEQ");
        modelBuilder.HasSequence("C49020_SEQ");
        modelBuilder.HasSequence("C4A020_SEQ");
        modelBuilder.HasSequence("C4B020_SEQ");
        modelBuilder.HasSequence("C4C020_SEQ");
        modelBuilder.HasSequence("C4D020_SEQ");
        modelBuilder.HasSequence("C4D030_SEQ");
        modelBuilder.HasSequence("C4E020_SEQ");
        modelBuilder.HasSequence("C4F020_SEQ");
        modelBuilder.HasSequence("C4G020_SEQ");
        modelBuilder.HasSequence("C4H020_SEQ");
        modelBuilder.HasSequence("C4I020_SEQ");
        modelBuilder.HasSequence("C4J020_SEQ");
        modelBuilder.HasSequence("C4K020_SEQ");
        modelBuilder.HasSequence("C4K030_SEQ");
        modelBuilder.HasSequence("C4L020_SEQ");
        modelBuilder.HasSequence("C4M020_SEQ");
        modelBuilder.HasSequence("C4N020_SEQ");
        modelBuilder.HasSequence("C4O020_SEQ");
        modelBuilder.HasSequence("C4P020_SEQ");
        modelBuilder.HasSequence("C4Q020_SEQ");
        modelBuilder.HasSequence("C4R020_SEQ");
        modelBuilder.HasSequence("C4S020_SEQ");
        modelBuilder.HasSequence("C4T020_SEQ");
        modelBuilder.HasSequence("C4U020_SEQ");
        modelBuilder.HasSequence("C4V020_SEQ");
        modelBuilder.HasSequence("C4X020_SEQ");
        modelBuilder.HasSequence("C4Z020_SEQ");
        modelBuilder.HasSequence("C4Z030_SEQ");
        modelBuilder.HasSequence("C50020_SEQ");
        modelBuilder.HasSequence("C51020_SEQ");
        modelBuilder.HasSequence("C52020_SEQ");
        modelBuilder.HasSequence("C52030_SEQ");
        modelBuilder.HasSequence("C53020_SEQ");
        modelBuilder.HasSequence("C54020_SEQ");
        modelBuilder.HasSequence("C55020_SEQ");
        modelBuilder.HasSequence("C56020_SEQ");
        modelBuilder.HasSequence("C57020_SEQ");
        modelBuilder.HasSequence("C58020_SEQ");
        modelBuilder.HasSequence("C59020_SEQ");
        modelBuilder.HasSequence("C5A020_SEQ");
        modelBuilder.HasSequence("C5B020_SEQ");
        modelBuilder.HasSequence("C5C020_SEQ");
        modelBuilder.HasSequence("C5D020_SEQ");
        modelBuilder.HasSequence("C5D030_SEQ");
        modelBuilder.HasSequence("C5E020_SEQ");
        modelBuilder.HasSequence("C5F020_SEQ");
        modelBuilder.HasSequence("C5G020_SEQ");
        modelBuilder.HasSequence("C5H020_SEQ");
        modelBuilder.HasSequence("C5I020_SEQ");
        modelBuilder.HasSequence("C5J020_SEQ");
        modelBuilder.HasSequence("C5K020_SEQ");
        modelBuilder.HasSequence("C5L020_SEQ");
        modelBuilder.HasSequence("C5M020_SEQ");
        modelBuilder.HasSequence("C5N020_SEQ");
        modelBuilder.HasSequence("C5O020_SEQ");
        modelBuilder.HasSequence("C5P020_SEQ");
        modelBuilder.HasSequence("C5P030_SEQ");
        modelBuilder.HasSequence("C5Q020_SEQ");
        modelBuilder.HasSequence("C5R020_SEQ");
        modelBuilder.HasSequence("C5S020_SEQ");
        modelBuilder.HasSequence("C5T020_SEQ");
        modelBuilder.HasSequence("C5U020_SEQ");
        modelBuilder.HasSequence("C5V020_SEQ");
        modelBuilder.HasSequence("C5V030_SEQ");
        modelBuilder.HasSequence("C5X020_SEQ");
        modelBuilder.HasSequence("C5X030_SEQ");
        modelBuilder.HasSequence("C5Z020_SEQ");
        modelBuilder.HasSequence("C6C020_SEQ");
        modelBuilder.HasSequence("C6C030_SEQ");
        modelBuilder.HasSequence("C6D020_SEQ");
        modelBuilder.HasSequence("C6E020_SEQ");
        modelBuilder.HasSequence("C6F020_SEQ");
        modelBuilder.HasSequence("C6G020_SEQ");
        modelBuilder.HasSequence("C6H020_SEQ");
        modelBuilder.HasSequence("C6I020_SEQ");
        modelBuilder.HasSequence("C6J020_SEQ");
        modelBuilder.HasSequence("C6K020_SEQ");
        modelBuilder.HasSequence("C6L020_SEQ");
        modelBuilder.HasSequence("C6M020_SEQ");
        modelBuilder.HasSequence("C6N020_SEQ");
        modelBuilder.HasSequence("C6O020_SEQ");
        modelBuilder.HasSequence("C6P020_SEQ");
        modelBuilder.HasSequence("C6Q020_SEQ");
        modelBuilder.HasSequence("C6R020_SEQ");
        modelBuilder.HasSequence("C6R030_SEQ");
        modelBuilder.HasSequence("C6S020_SEQ");
        modelBuilder.HasSequence("C6S030_SEQ");
        modelBuilder.HasSequence("C6T020_SEQ");
        modelBuilder.HasSequence("C6T030_SEQ");
        modelBuilder.HasSequence("C6U010_SEQ");
        modelBuilder.HasSequence("C6U020_SEQ");
        modelBuilder.HasSequence("C6U030_SEQ");
        modelBuilder.HasSequence("C6V020_SEQ");
        modelBuilder.HasSequence("C6W020_SEQ");
        modelBuilder.HasSequence("C6X020_SEQ");
        modelBuilder.HasSequence("C6Y020_SEQ");
        modelBuilder.HasSequence("C6Z020_SEQ");
        modelBuilder.HasSequence("C70020_SEQ");
        modelBuilder.HasSequence("C71020_SEQ");
        modelBuilder.HasSequence("C72020_SEQ");
        modelBuilder.HasSequence("C73020_SEQ");
        modelBuilder.HasSequence("C74020_SEQ");
        modelBuilder.HasSequence("C75020_SEQ");
        modelBuilder.HasSequence("C76020_SEQ");
        modelBuilder.HasSequence("C77020_SEQ");
        modelBuilder.HasSequence("C78020_SEQ");
        modelBuilder.HasSequence("C79020_SEQ");
        modelBuilder.HasSequence("C7A020_SEQ");
        modelBuilder.HasSequence("C7B020_SEQ");
        modelBuilder.HasSequence("C7C020_SEQ");
        modelBuilder.HasSequence("C7D020_SEQ");
        modelBuilder.HasSequence("C7E020_SEQ");
        modelBuilder.HasSequence("C7F020_SEQ");
        modelBuilder.HasSequence("C7G020_SEQ");
        modelBuilder.HasSequence("C7H020_SEQ");
        modelBuilder.HasSequence("C7I020_SEQ");
        modelBuilder.HasSequence("C7J020_SEQ");
        modelBuilder.HasSequence("C7K020_SEQ");
        modelBuilder.HasSequence("C7L020_SEQ");
        modelBuilder.HasSequence("C7M020_SEQ");
        modelBuilder.HasSequence("C7N020_SEQ");
        modelBuilder.HasSequence("C7O020_SEQ");
        modelBuilder.HasSequence("C7P020_SEQ");
        modelBuilder.HasSequence("C7Q020_SEQ");
        modelBuilder.HasSequence("C7R020_SEQ");
        modelBuilder.HasSequence("C7S020_SEQ");
        modelBuilder.HasSequence("C7T020_SEQ");
        modelBuilder.HasSequence("C7U020_SEQ");
        modelBuilder.HasSequence("C7V020_SEQ");
        modelBuilder.HasSequence("C7X020_SEQ");
        modelBuilder.HasSequence("C7Z020_SEQ");
        modelBuilder.HasSequence("C80020_SEQ");
        modelBuilder.HasSequence("C81020_SEQ");
        modelBuilder.HasSequence("C82020_SEQ");
        modelBuilder.HasSequence("C83020_SEQ");
        modelBuilder.HasSequence("C84020_SEQ");
        modelBuilder.HasSequence("C85020_SEQ");
        modelBuilder.HasSequence("C86020_SEQ");
        modelBuilder.HasSequence("C86030_SEQ");
        modelBuilder.HasSequence("C87020_SEQ");
        modelBuilder.HasSequence("C87030_SEQ");
        modelBuilder.HasSequence("C88020_SEQ");
        modelBuilder.HasSequence("C88030_SEQ");
        modelBuilder.HasSequence("C89020_SEQ");
        modelBuilder.HasSequence("C89030_SEQ");
        modelBuilder.HasSequence("C8A010_SEQ");
        modelBuilder.HasSequence("C8A020_SEQ");
        modelBuilder.HasSequence("C8A030_SEQ");
        modelBuilder.HasSequence("C8B020_SEQ");
        modelBuilder.HasSequence("C8C020_SEQ");
        modelBuilder.HasSequence("C8C030_SEQ");
        modelBuilder.HasSequence("C8D020_SEQ");
        modelBuilder.HasSequence("C8D030_SEQ");
        modelBuilder.HasSequence("C8E020_SEQ");
        modelBuilder.HasSequence("C8E030_SEQ");
        modelBuilder.HasSequence("C8F020_SEQ");
        modelBuilder.HasSequence("C8F030_SEQ");
        modelBuilder.HasSequence("C8G020_SEQ");
        modelBuilder.HasSequence("C8G030_SEQ");
        modelBuilder.HasSequence("C8H020_SEQ");
        modelBuilder.HasSequence("C8H030_SEQ");
        modelBuilder.HasSequence("C8I020_SEQ");
        modelBuilder.HasSequence("C8I030_SEQ");
        modelBuilder.HasSequence("C8J020_SEQ");
        modelBuilder.HasSequence("C8J030_SEQ");
        modelBuilder.HasSequence("C8K020_SEQ");
        modelBuilder.HasSequence("C8K030_SEQ");
        modelBuilder.HasSequence("C8L020_SEQ");
        modelBuilder.HasSequence("C8L030_SEQ");
        modelBuilder.HasSequence("C8M020_SEQ");
        modelBuilder.HasSequence("C8M030_SEQ");
        modelBuilder.HasSequence("C8N020_SEQ");
        modelBuilder.HasSequence("C8N030_SEQ");
        modelBuilder.HasSequence("C8O020_SEQ");
        modelBuilder.HasSequence("C8O030_SEQ");
        modelBuilder.HasSequence("C8P020_SEQ");
        modelBuilder.HasSequence("C8P030_SEQ");
        modelBuilder.HasSequence("C8Q020_SEQ");
        modelBuilder.HasSequence("C8R010_SEQ");
        modelBuilder.HasSequence("C8S020_SEQ");
        modelBuilder.HasSequence("C8S030_SEQ");
        modelBuilder.HasSequence("C8T020_SEQ");
        modelBuilder.HasSequence("C8T030_SEQ");
        modelBuilder.HasSequence("C8U020_SEQ");
        modelBuilder.HasSequence("C8U030_SEQ");
        modelBuilder.HasSequence("C8V020_SEQ");
        modelBuilder.HasSequence("C8W020_SEQ");
        modelBuilder.HasSequence("C8X020_SEQ");
        modelBuilder.HasSequence("C8Y020_SEQ");
        modelBuilder.HasSequence("C8Z010_SEQ");
        modelBuilder.HasSequence("C8Z020_SEQ");
        modelBuilder.HasSequence("C8Z030_SEQ");
        modelBuilder.HasSequence("C90020_SEQ");
        modelBuilder.HasSequence("C91020_SEQ");
        modelBuilder.HasSequence("C92010_SEQ");
        modelBuilder.HasSequence("C92020_SEQ");
        modelBuilder.HasSequence("C94020_SEQ");
        modelBuilder.HasSequence("C94030_SEQ");
        modelBuilder.HasSequence("C95020_SEQ");
        modelBuilder.HasSequence("C95030_SEQ");
        modelBuilder.HasSequence("C96020_SEQ");
        modelBuilder.HasSequence("C96030_SEQ");
        modelBuilder.HasSequence("C97020_SEQ");
        modelBuilder.HasSequence("C97030_SEQ");
        modelBuilder.HasSequence("C98020_SEQ");
        modelBuilder.HasSequence("C98030_SEQ");
        modelBuilder.HasSequence("C99010_SEQ");
        modelBuilder.HasSequence("C99020_SEQ");
        modelBuilder.HasSequence("C9B020_SEQ");
        modelBuilder.HasSequence("C9J020_SEQ");
        modelBuilder.HasSequence("C9K020_SEQ");
        modelBuilder.HasSequence("C9L020_SEQ");
        modelBuilder.HasSequence("C9M020_SEQ");
        modelBuilder.HasSequence("C9N020_SEQ");
        modelBuilder.HasSequence("C9O010_SEQ");
        modelBuilder.HasSequence("C9O020_SEQ");
        modelBuilder.HasSequence("C9P010_SEQ");
        modelBuilder.HasSequence("C9P020_SEQ");
        modelBuilder.HasSequence("C9Q020_SEQ");
        modelBuilder.HasSequence("C9R010_SEQ");
        modelBuilder.HasSequence("C9R020_SEQ");
        modelBuilder.HasSequence("C9V010_SEQ");
        modelBuilder.HasSequence("C9V020_SEQ");
        modelBuilder.HasSequence("C9W010_SEQ");
        modelBuilder.HasSequence("C9W020_SEQ");
        modelBuilder.HasSequence("C9Y020_SEQ");
        modelBuilder.HasSequence("CA0020_SEQ");
        modelBuilder.HasSequence("CA0030_SEQ");
        modelBuilder.HasSequence("CA2020_SEQ");
        modelBuilder.HasSequence("CA3020_SEQ");
        modelBuilder.HasSequence("CA4020_SEQ");
        modelBuilder.HasSequence("CA5020_SEQ");
        modelBuilder.HasSequence("CA6020_SEQ");
        modelBuilder.HasSequence("CA7020_SEQ");
        modelBuilder.HasSequence("CA8020_SEQ");
        modelBuilder.HasSequence("CA9020_SEQ");
        modelBuilder.HasSequence("CAA020_SEQ");
        modelBuilder.HasSequence("CAB020_SEQ");
        modelBuilder.HasSequence("CAC020_SEQ");
        modelBuilder.HasSequence("CAD020_SEQ");
        modelBuilder.HasSequence("CAE020_SEQ");
        modelBuilder.HasSequence("CAF020_SEQ");
        modelBuilder.HasSequence("CAG020_SEQ");
        modelBuilder.HasSequence("CAH020_SEQ");
        modelBuilder.HasSequence("CAH030_SEQ");
        modelBuilder.HasSequence("CAI020_SEQ");
        modelBuilder.HasSequence("CAJ020_SEQ");
        modelBuilder.HasSequence("CAJ030_SEQ");
        modelBuilder.HasSequence("CAK020_SEQ");
        modelBuilder.HasSequence("CAK030_SEQ");
        modelBuilder.HasSequence("CAL020_SEQ");
        modelBuilder.HasSequence("CAL030_SEQ");
        modelBuilder.HasSequence("CAP020_SEQ");
        modelBuilder.HasSequence("CAQ020_SEQ");
        modelBuilder.HasSequence("CAR020_SEQ");
        modelBuilder.HasSequence("CAROL_3C_QUEUE_SEQ").IsCyclic();
        modelBuilder.HasSequence("CAS020_SEQ");
        modelBuilder.HasSequence("CAT020_SEQ");
        modelBuilder.HasSequence("CAX020_SEQ");
        modelBuilder.HasSequence("CAX030_SEQ");
        modelBuilder.HasSequence("CAY020_SEQ");
        modelBuilder.HasSequence("CAZ020_SEQ");
        modelBuilder.HasSequence("CEA020_SEQ");
        modelBuilder.HasSequence("CEB020_SEQ");
        modelBuilder.HasSequence("CEC020_SEQ");
        modelBuilder.HasSequence("CEG020_SEQ");
        modelBuilder.HasSequence("CEH020_SEQ");
        modelBuilder.HasSequence("CEI020_SEQ");
        modelBuilder.HasSequence("CEJ020_SEQ");
        modelBuilder.HasSequence("CEK020_SEQ");
        modelBuilder.HasSequence("CEM020_SEQ");
        modelBuilder.HasSequence("CEN020_SEQ");
        modelBuilder.HasSequence("CEO020_SEQ");
        modelBuilder.HasSequence("CEP020_SEQ");
        modelBuilder.HasSequence("CEQ020_SEQ");
        modelBuilder.HasSequence("CER020_SEQ");
        modelBuilder.HasSequence("CES020_SEQ");
        modelBuilder.HasSequence("CET020_SEQ");
        modelBuilder.HasSequence("CEU020_SEQ");
        modelBuilder.HasSequence("CEV020_SEQ");
        modelBuilder.HasSequence("CEX020_SEQ");
        modelBuilder.HasSequence("CEY020_SEQ");
        modelBuilder.HasSequence("CEZ020_SEQ");
        modelBuilder.HasSequence("CFI020_SEQ");
        modelBuilder.HasSequence("CFK020_SEQ");
        modelBuilder.HasSequence("CFL020_SEQ");
        modelBuilder.HasSequence("CFL030_SEQ");
        modelBuilder.HasSequence("CFM020_SEQ");
        modelBuilder.HasSequence("CFM030_SEQ");
        modelBuilder.HasSequence("CFQ020_SEQ");
        modelBuilder.HasSequence("CFR020_SEQ");
        modelBuilder.HasSequence("CFS020_SEQ");
        modelBuilder.HasSequence("CFT020_SEQ");
        modelBuilder.HasSequence("CFU020_SEQ");
        modelBuilder.HasSequence("CFU030_SEQ");
        modelBuilder.HasSequence("CFV020_SEQ");
        modelBuilder.HasSequence("CFX020_SEQ");
        modelBuilder.HasSequence("CFY020_SEQ");
        modelBuilder.HasSequence("CFZ020_SEQ");
        modelBuilder.HasSequence("CG0020_SEQ");
        modelBuilder.HasSequence("CG2020_SEQ");
        modelBuilder.HasSequence("CG3020_SEQ");
        modelBuilder.HasSequence("CG5020_SEQ");
        modelBuilder.HasSequence("CGI020_SEQ");
        modelBuilder.HasSequence("CGJ020_SEQ");
        modelBuilder.HasSequence("CGK020_SEQ");
        modelBuilder.HasSequence("CGL020_SEQ");
        modelBuilder.HasSequence("CGM020_SEQ");
        modelBuilder.HasSequence("CGN020_SEQ");
        modelBuilder.HasSequence("CGN030_SEQ");
        modelBuilder.HasSequence("CGO020_SEQ");
        modelBuilder.HasSequence("CGP020_SEQ");
        modelBuilder.HasSequence("CGQ020_SEQ");
        modelBuilder.HasSequence("CGR020_SEQ");
        modelBuilder.HasSequence("CGS020_SEQ");
        modelBuilder.HasSequence("CGT020_SEQ");
        modelBuilder.HasSequence("CGU020_SEQ");
        modelBuilder.HasSequence("CGV020_SEQ");
        modelBuilder.HasSequence("CGW020_SEQ");
        modelBuilder.HasSequence("CGX020_SEQ");
        modelBuilder.HasSequence("CGY020_SEQ");
        modelBuilder.HasSequence("CGZ020_SEQ");
        modelBuilder.HasSequence("CH0020_SEQ");
        modelBuilder.HasSequence("CH0030_SEQ");
        modelBuilder.HasSequence("CH1020_SEQ");
        modelBuilder.HasSequence("CH2020_SEQ");
        modelBuilder.HasSequence("CH6020_SEQ");
        modelBuilder.HasSequence("CH6030_SEQ");
        modelBuilder.HasSequence("CH8020_SEQ");
        modelBuilder.HasSequence("CH8030_SEQ");
        modelBuilder.HasSequence("CH9020_SEQ");
        modelBuilder.HasSequence("CHA020_SEQ");
        modelBuilder.HasSequence("CHA030_SEQ");
        modelBuilder.HasSequence("CHB020_SEQ");
        modelBuilder.HasSequence("CHC020_SEQ");
        modelBuilder.HasSequence("CHD020_SEQ");
        modelBuilder.HasSequence("CHE020_SEQ");
        modelBuilder.HasSequence("CHF020_SEQ");
        modelBuilder.HasSequence("CHG020_SEQ");
        modelBuilder.HasSequence("CHI020_SEQ");
        modelBuilder.HasSequence("CHI030_SEQ");
        modelBuilder.HasSequence("CHJ020_SEQ");
        modelBuilder.HasSequence("CHJ030_SEQ");
        modelBuilder.HasSequence("CHK020_SEQ");
        modelBuilder.HasSequence("CHK030_SEQ");
        modelBuilder.HasSequence("CHL020_SEQ");
        modelBuilder.HasSequence("CHM020_SEQ");
        modelBuilder.HasSequence("CHN020_SEQ");
        modelBuilder.HasSequence("CHO020_SEQ");
        modelBuilder.HasSequence("CHP020_SEQ");
        modelBuilder.HasSequence("CHQ020_SEQ");
        modelBuilder.HasSequence("CHR020_SEQ");
        modelBuilder.HasSequence("CHS020_SEQ");
        modelBuilder.HasSequence("CHT020_SEQ");
        modelBuilder.HasSequence("CHU020_SEQ");
        modelBuilder.HasSequence("CHV020_SEQ");
        modelBuilder.HasSequence("CHW020_SEQ");
        modelBuilder.HasSequence("CHW030_SEQ");
        modelBuilder.HasSequence("CHY020_SEQ");
        modelBuilder.HasSequence("CHY030_SEQ");
        modelBuilder.HasSequence("CI1010_SEQ");
        modelBuilder.HasSequence("CJL010_SEQ");
        modelBuilder.HasSequence("CJL020_SEQ");
        modelBuilder.HasSequence("CJN010_SEQ");
        modelBuilder.HasSequence("CJP010_SEQ");
        modelBuilder.HasSequence("CJV010_SEQ");
        modelBuilder.HasSequence("CJV020_SEQ");
        modelBuilder.HasSequence("CJW010_SEQ");
        modelBuilder.HasSequence("CJW020_SEQ");
        modelBuilder.HasSequence("CK4010_SEQ");
        modelBuilder.HasSequence("CK4020_SEQ");
        modelBuilder.HasSequence("CK7010_SEQ");
        modelBuilder.HasSequence("CKA010_SEQ");
        modelBuilder.HasSequence("CKA020_SEQ");
        modelBuilder.HasSequence("CKC010_SEQ");
        modelBuilder.HasSequence("CKG010_SEQ");
        modelBuilder.HasSequence("CKG020_SEQ");
        modelBuilder.HasSequence("CM0020_SEQ");
        modelBuilder.HasSequence("CM5020_SEQ");
        modelBuilder.HasSequence("CM6010_SEQ");
        modelBuilder.HasSequence("CM6020_SEQ");
        modelBuilder.HasSequence("CM7020_SEQ");
        modelBuilder.HasSequence("CM8020_SEQ");
        modelBuilder.HasSequence("CM9020_SEQ");
        modelBuilder.HasSequence("CMA020_SEQ");
        modelBuilder.HasSequence("CMB020_SEQ");
        modelBuilder.HasSequence("CMD020_SEQ");
        modelBuilder.HasSequence("CMF020_SEQ");
        modelBuilder.HasSequence("CMH020_SEQ");
        modelBuilder.HasSequence("CMH030_SEQ");
        modelBuilder.HasSequence("CMI020_SEQ");
        modelBuilder.HasSequence("CMI030_SEQ");
        modelBuilder.HasSequence("CMJ020_SEQ");
        modelBuilder.HasSequence("CML020_SEQ");
        modelBuilder.HasSequence("CML030_SEQ");
        modelBuilder.HasSequence("CMM020_SEQ");
        modelBuilder.HasSequence("CMM030_SEQ");
        modelBuilder.HasSequence("CMN020_SEQ");
        modelBuilder.HasSequence("CMR020_SEQ");
        modelBuilder.HasSequence("CMY020_SEQ");
        modelBuilder.HasSequence("CMY030_SEQ");
        modelBuilder.HasSequence("CR9020_SEQ");
        modelBuilder.HasSequence("CR9030_SEQ");
        modelBuilder.HasSequence("CRA020_SEQ");
        modelBuilder.HasSequence("CRC020_SEQ");
        modelBuilder.HasSequence("CRE020_SEQ");
        modelBuilder.HasSequence("CRF020_SEQ");
        modelBuilder.HasSequence("CRG020_SEQ");
        modelBuilder.HasSequence("CRH020_SEQ");
        modelBuilder.HasSequence("CRI020_SEQ");
        modelBuilder.HasSequence("CRL010_SEQ");
        modelBuilder.HasSequence("CRL020_SEQ");
        modelBuilder.HasSequence("CRM020_SEQ");
        modelBuilder.HasSequence("CRM030_SEQ");
        modelBuilder.HasSequence("CRN020_SEQ");
        modelBuilder.HasSequence("CRO020_SEQ");
        modelBuilder.HasSequence("CRQ020_SEQ");
        modelBuilder.HasSequence("CRR020_SEQ");
        modelBuilder.HasSequence("CRS020_SEQ");
        modelBuilder.HasSequence("CRV020_SEQ");
        modelBuilder.HasSequence("CU0020_SEQ");
        modelBuilder.HasSequence("CUA020_SEQ");
        modelBuilder.HasSequence("CUA030_SEQ");
        modelBuilder.HasSequence("CUB020_SEQ");
        modelBuilder.HasSequence("CUB030_SEQ");
        modelBuilder.HasSequence("CUC020_SEQ");
        modelBuilder.HasSequence("CUC030_SEQ");
        modelBuilder.HasSequence("CUE020_SEQ");
        modelBuilder.HasSequence("CUE030_SEQ");
        modelBuilder.HasSequence("CUF020_SEQ");
        modelBuilder.HasSequence("CUF030_SEQ");
        modelBuilder.HasSequence("CUM020_SEQ");
        modelBuilder.HasSequence("CUM030_SEQ");
        modelBuilder.HasSequence("CUN020_SEQ");
        modelBuilder.HasSequence("CUN030_SEQ");
        modelBuilder.HasSequence("CUO020_SEQ");
        modelBuilder.HasSequence("CUP020_SEQ");
        modelBuilder.HasSequence("CUQ020_SEQ");
        modelBuilder.HasSequence("CUQ030_SEQ");
        modelBuilder.HasSequence("CUR020_SEQ");
        modelBuilder.HasSequence("CUR030_SEQ");
        modelBuilder.HasSequence("CUU020_SEQ");
        modelBuilder.HasSequence("CUV020_SEQ");
        modelBuilder.HasSequence("CUV030_SEQ");
        modelBuilder.HasSequence("CUW020_SEQ");
        modelBuilder.HasSequence("CUW030_SEQ");
        modelBuilder.HasSequence("CUX020_SEQ");
        modelBuilder.HasSequence("CUY020_SEQ");
        modelBuilder.HasSequence("CUY030_SEQ");
        modelBuilder.HasSequence("CUZ020_SEQ");
        modelBuilder.HasSequence("CUZ030_SEQ");
        modelBuilder.HasSequence("CW4020_SEQ");
        modelBuilder.HasSequence("CW4030_SEQ");
        modelBuilder.HasSequence("CW5020_SEQ");
        modelBuilder.HasSequence("CW5030_SEQ");
        modelBuilder.HasSequence("CW6020_SEQ");
        modelBuilder.HasSequence("CW6030_SEQ");
        modelBuilder.HasSequence("CW9020_SEQ");
        modelBuilder.HasSequence("CW9030_SEQ");
        modelBuilder.HasSequence("CWZ010_SEQ");
        modelBuilder.HasSequence("CWZ020_SEQ");
        modelBuilder.HasSequence("CWZ030_SEQ");
        modelBuilder.HasSequence("CZM020_SEQ");
        modelBuilder.HasSequence("CZR020_SEQ");
        modelBuilder.HasSequence("CZR030_SEQ");
        modelBuilder.HasSequence("CZS020_SEQ");
        modelBuilder.HasSequence("CZS030_SEQ");
        modelBuilder.HasSequence("CZT010_SEQ");
        modelBuilder.HasSequence("CZT020_SEQ");
        modelBuilder.HasSequence("CZU020_SEQ");
        modelBuilder.HasSequence("CZU030_SEQ");
        modelBuilder.HasSequence("CZV020_SEQ");
        modelBuilder.HasSequence("CZV030_SEQ");
        modelBuilder.HasSequence("D32010_SEQ");
        modelBuilder.HasSequence("D34010_SEQ");
        modelBuilder.HasSequence("D38010_SEQ");
        modelBuilder.HasSequence("D39010_SEQ");
        modelBuilder.HasSequence("D3A010_SEQ");
        modelBuilder.HasSequence("D3B010_SEQ");
        modelBuilder.HasSequence("D3C010_SEQ");
        modelBuilder.HasSequence("D3F010_SEQ");
        modelBuilder.HasSequence("D3G010_SEQ");
        modelBuilder.HasSequence("D3G020_SEQ");
        modelBuilder.HasSequence("D3H010_SEQ");
        modelBuilder.HasSequence("D3H020_SEQ");
        modelBuilder.HasSequence("D3I010_SEQ");
        modelBuilder.HasSequence("D3I020_SEQ");
        modelBuilder.HasSequence("D3J010_SEQ");
        modelBuilder.HasSequence("D3J020_SEQ");
        modelBuilder.HasSequence("D3L010_SEQ");
        modelBuilder.HasSequence("D3L020_SEQ");
        modelBuilder.HasSequence("D3M010_SEQ");
        modelBuilder.HasSequence("D3M020_SEQ");
        modelBuilder.HasSequence("D3N010_SEQ");
        modelBuilder.HasSequence("D3N020_SEQ");
        modelBuilder.HasSequence("D3O010_SEQ");
        modelBuilder.HasSequence("D3O020_SEQ");
        modelBuilder.HasSequence("D3P010_SEQ");
        modelBuilder.HasSequence("D3P020_SEQ");
        modelBuilder.HasSequence("D3Q010_SEQ");
        modelBuilder.HasSequence("D3Q020_SEQ");
        modelBuilder.HasSequence("D3R010_SEQ");
        modelBuilder.HasSequence("D3R020_SEQ");
        modelBuilder.HasSequence("D3S010_SEQ");
        modelBuilder.HasSequence("D3S020_SEQ");
        modelBuilder.HasSequence("D3T010_SEQ");
        modelBuilder.HasSequence("D3T020_SEQ");
        modelBuilder.HasSequence("D3U010_SEQ");
        modelBuilder.HasSequence("D3U020_SEQ");
        modelBuilder.HasSequence("D3W010_SEQ");
        modelBuilder.HasSequence("D3W020_SEQ");
        modelBuilder.HasSequence("D3X010_SEQ");
        modelBuilder.HasSequence("D3X020_SEQ");
        modelBuilder.HasSequence("D3Y010_SEQ");
        modelBuilder.HasSequence("D3Y020_SEQ");
        modelBuilder.HasSequence("D4A010_SEQ");
        modelBuilder.HasSequence("D4A020_SEQ");
        modelBuilder.HasSequence("D4B010_SEQ");
        modelBuilder.HasSequence("D4B020_SEQ");
        modelBuilder.HasSequence("D4C010_SEQ");
        modelBuilder.HasSequence("D4H010_SEQ");
        modelBuilder.HasSequence("D4H020_SEQ");
        modelBuilder.HasSequence("DH0010_SEQ");
        modelBuilder.HasSequence("DH0020_SEQ");
        modelBuilder.HasSequence("DH0030_SEQ");
        modelBuilder.HasSequence("DH1010_SEQ");
        modelBuilder.HasSequence("DH4010_SEQ");
        modelBuilder.HasSequence("DH5010_SEQ");
        modelBuilder.HasSequence("DH6010_SEQ");
        modelBuilder.HasSequence("DH7010_SEQ");
        modelBuilder.HasSequence("DH9010_SEQ");
        modelBuilder.HasSequence("DHB010_SEQ");
        modelBuilder.HasSequence("DHB020_SEQ");
        modelBuilder.HasSequence("DHB030_SEQ");
        modelBuilder.HasSequence("DHC010_SEQ");
        modelBuilder.HasSequence("DHE010_SEQ");
        modelBuilder.HasSequence("DHG010_SEQ");
        modelBuilder.HasSequence("DHR010_SEQ");
        modelBuilder.HasSequence("DHR020_SEQ");
        modelBuilder.HasSequence("DHS010_SEQ");
        modelBuilder.HasSequence("DHS020_SEQ");
        modelBuilder.HasSequence("DHT010_SEQ");
        modelBuilder.HasSequence("DHT020_SEQ");
        modelBuilder.HasSequence("DHV010_SEQ");
        modelBuilder.HasSequence("DKA010_SEQ");
        modelBuilder.HasSequence("DKA020_SEQ");
        modelBuilder.HasSequence("DKB010_SEQ");
        modelBuilder.HasSequence("DKB020_SEQ");
        modelBuilder.HasSequence("DKC010_SEQ");
        modelBuilder.HasSequence("DKC020_SEQ");
        modelBuilder.HasSequence("DKD010_SEQ");
        modelBuilder.HasSequence("DKD020_SEQ");
        modelBuilder.HasSequence("DKE010_SEQ");
        modelBuilder.HasSequence("DKE020_SEQ");
        modelBuilder.HasSequence("DKM010_SEQ");
        modelBuilder.HasSequence("DKM020_SEQ");
        modelBuilder.HasSequence("DKN010_SEQ");
        modelBuilder.HasSequence("DKN020_SEQ");
        modelBuilder.HasSequence("DNF010_SEQ");
        modelBuilder.HasSequence("DNF020_SEQ");
        modelBuilder.HasSequence("DNG010_SEQ");
        modelBuilder.HasSequence("DNG020_SEQ");
        modelBuilder.HasSequence("EKR010_SEQ");
        modelBuilder.HasSequence("EKS010_SEQ");
        modelBuilder.HasSequence("EKU010_SEQ");
        modelBuilder.HasSequence("EKV010_SEQ");
        modelBuilder.HasSequence("EKX010_SEQ");
        modelBuilder.HasSequence("ENV_ADDRESS_SEQ");
        modelBuilder.HasSequence("ENV_CONFIG_SEQ");
        modelBuilder.HasSequence("ENV_INFO_SEQ");
        modelBuilder.HasSequence("ENV_RECEIVE_SEQ");
        modelBuilder.HasSequence("F79010_SEQ");
        modelBuilder.HasSequence("F7A010_SEQ");
        modelBuilder.HasSequence("F7A020_SEQ");
        modelBuilder.HasSequence("F7G010_SEQ");
        modelBuilder.HasSequence("F7G020_SEQ");
        modelBuilder.HasSequence("F7Q010_SEQ");
        modelBuilder.HasSequence("FM3010_SEQ");
        modelBuilder.HasSequence("FM4010_SEQ");
        modelBuilder.HasSequence("FW_SV_CUSTOM_SEQ");
        modelBuilder.HasSequence("FW_TREP_CONTROLLER_SEQ");
        modelBuilder.HasSequence("H_2016123101_04_SEQ");
        modelBuilder.HasSequence("H_2017123101_04_SEQ");
        modelBuilder.HasSequence("H_2017123102_03_SEQ");
        modelBuilder.HasSequence("H_2018123101_01_SEQ");
        modelBuilder.HasSequence("H_2018123101_02_SEQ");
        modelBuilder.HasSequence("H_2018123101_03_SEQ");
        modelBuilder.HasSequence("H_2018123101_04_SEQ");
        modelBuilder.HasSequence("H_2018123101_06_SEQ");
        modelBuilder.HasSequence("H_2018123101_07_SEQ");
        modelBuilder.HasSequence("H_2018123101_08_SEQ");
        modelBuilder.HasSequence("H_2018123102_01_SEQ");
        modelBuilder.HasSequence("H_2018123102_02_SEQ");
        modelBuilder.HasSequence("H_2018123102_03_SEQ");
        modelBuilder.HasSequence("H_2018123102_04_SEQ");
        modelBuilder.HasSequence("H_2019123101_01_SEQ");
        modelBuilder.HasSequence("H_2019123101_02_SEQ");
        modelBuilder.HasSequence("H_2019123101_03_SEQ");
        modelBuilder.HasSequence("H_2019123101_04_SEQ");
        modelBuilder.HasSequence("H_2019123102_01_SEQ");
        modelBuilder.HasSequence("H_2019123102_02_SEQ");
        modelBuilder.HasSequence("H_2019123102_03_SEQ");
        modelBuilder.HasSequence("H_2019123102_04_SEQ");
        modelBuilder.HasSequence("H_2020123101_01_SEQ");
        modelBuilder.HasSequence("H_2020123101_02_SEQ");
        modelBuilder.HasSequence("H_2020123101_03_SEQ");
        modelBuilder.HasSequence("H_2020123101_04_SEQ");
        modelBuilder.HasSequence("H_2020123102_01_SEQ");
        modelBuilder.HasSequence("H_2020123102_02_SEQ");
        modelBuilder.HasSequence("H_2020123102_03_SEQ");
        modelBuilder.HasSequence("H_2020123102_04_SEQ");
        modelBuilder.HasSequence("H_2021123101_01_SEQ");
        modelBuilder.HasSequence("H_2021123101_02_SEQ");
        modelBuilder.HasSequence("H_2021123101_03_SEQ");
        modelBuilder.HasSequence("H_2021123101_04_SEQ");
        modelBuilder.HasSequence("H_2021123102_01_SEQ");
        modelBuilder.HasSequence("H_2021123102_02_SEQ");
        modelBuilder.HasSequence("H_2021123102_03_SEQ");
        modelBuilder.HasSequence("H_2021123102_04_SEQ");
        modelBuilder.HasSequence("H_2022123101_01_SEQ");
        modelBuilder.HasSequence("H_2022123101_02_SEQ");
        modelBuilder.HasSequence("H_2022123101_03_SEQ");
        modelBuilder.HasSequence("H_2022123101_04_SEQ");
        modelBuilder.HasSequence("H_2022123102_01_SEQ");
        modelBuilder.HasSequence("H_2022123102_02_SEQ");
        modelBuilder.HasSequence("H_2022123102_03_SEQ");
        modelBuilder.HasSequence("H_2022123102_04_SEQ");
        modelBuilder.HasSequence("H_2023123101_01_SEQ");
        modelBuilder.HasSequence("H_2023123101_02_SEQ");
        modelBuilder.HasSequence("H_2023123101_03_SEQ");
        modelBuilder.HasSequence("H_2023123101_04_SEQ");
        modelBuilder.HasSequence("H_2023123102_01_SEQ");
        modelBuilder.HasSequence("H_2023123102_02_SEQ");
        modelBuilder.HasSequence("H_2023123102_03_SEQ");
        modelBuilder.HasSequence("H_2023123102_04_SEQ");
        modelBuilder.HasSequence("H_2024123101_01_SEQ");
        modelBuilder.HasSequence("H_2024123101_02_SEQ");
        modelBuilder.HasSequence("H_2024123101_03_SEQ");
        modelBuilder.HasSequence("H_2024123101_04_SEQ");
        modelBuilder.HasSequence("H_2024123101_09_SEQ");
        modelBuilder.HasSequence("H_2024123102_01_SEQ");
        modelBuilder.HasSequence("H_2024123102_02_SEQ");
        modelBuilder.HasSequence("H_2024123102_03_SEQ");
        modelBuilder.HasSequence("H_2024123102_04_SEQ");
        modelBuilder.HasSequence("H_2025123101_01_SEQ");
        modelBuilder.HasSequence("H_2025123101_02_SEQ");
        modelBuilder.HasSequence("H_2025123101_03_SEQ");
        modelBuilder.HasSequence("H_2025123101_04_SEQ");
        modelBuilder.HasSequence("H_2025123102_01_SEQ");
        modelBuilder.HasSequence("H_2025123102_02_SEQ");
        modelBuilder.HasSequence("H_2025123102_03_SEQ");
        modelBuilder.HasSequence("H_2025123102_04_SEQ");
        modelBuilder.HasSequence("HRG010_SEQ");
        modelBuilder.HasSequence("HW9010_SEQ");
        modelBuilder.HasSequence("HW9020_SEQ");
        modelBuilder.HasSequence("HWF010_SEQ");
        modelBuilder.HasSequence("HWY010_SEQ");
        modelBuilder.HasSequence("HWY020_SEQ");
        modelBuilder.HasSequence("LE5010_SEQ");
        modelBuilder.HasSequence("LE5020_SEQ");
        modelBuilder.HasSequence("LE5030_SEQ");
        modelBuilder.HasSequence("LE7010_SEQ");
        modelBuilder.HasSequence("LE7020_SEQ");
        modelBuilder.HasSequence("LE7030_SEQ");
        modelBuilder.HasSequence("LEE010_SEQ");
        modelBuilder.HasSequence("LEE020_SEQ");
        modelBuilder.HasSequence("LEE030_SEQ");
        modelBuilder.HasSequence("LF0010_SEQ");
        modelBuilder.HasSequence("LF0020_SEQ");
        modelBuilder.HasSequence("LF0030_SEQ");
        modelBuilder.HasSequence("MIN010_SEQ");
        modelBuilder.HasSequence("MIN020_SEQ");
        modelBuilder.HasSequence("MP_CUSTOM_METRICS_EXP_SEQ");
        modelBuilder.HasSequence("MP_SYSTEM_PROFILE_SEQ");
        modelBuilder.HasSequence("MP_SYSTEM_WORKROLE_SEQ");
        modelBuilder.HasSequence("MPMENU_FUNCTION_SEQ");
        modelBuilder.HasSequence("MPMENU_I18N_SEQ");
        modelBuilder.HasSequence("MPMENU_ITEM_SEQ");
        modelBuilder.HasSequence("MPMENU_KEY_WORDS_SEQ");
        modelBuilder.HasSequence("MPMENU_MENU_SEQ");
        modelBuilder.HasSequence("MPMENU_RW_SEQ");
        modelBuilder.HasSequence("QLD010_SEQ");
        modelBuilder.HasSequence("QLD020_SEQ");
        modelBuilder.HasSequence("QLE010_SEQ");
        modelBuilder.HasSequence("QLE020_SEQ");
        modelBuilder.HasSequence("QLI010_SEQ");
        modelBuilder.HasSequence("QLI020_SEQ");
        modelBuilder.HasSequence("QLJ010_SEQ");
        modelBuilder.HasSequence("QLJ020_SEQ");
        modelBuilder.HasSequence("QNSXE_SEQ");
        modelBuilder.HasSequence("QNSXF_SEQ");
        modelBuilder.HasSequence("REQ010_SEQ");
        modelBuilder.HasSequence("REQ020_SEQ");
        modelBuilder.HasSequence("RET010_SEQ");
        modelBuilder.HasSequence("RI4010_SEQ");
        modelBuilder.HasSequence("RI4020_SEQ");
        modelBuilder.HasSequence("RRE010_SEQ");
        modelBuilder.HasSequence("RU0010_SEQ");
        modelBuilder.HasSequence("RU0020_SEQ");
        modelBuilder.HasSequence("RU1010_SEQ");
        modelBuilder.HasSequence("RU1020_SEQ");
        modelBuilder.HasSequence("RU2010_SEQ");
        modelBuilder.HasSequence("RU2020_SEQ");
        modelBuilder.HasSequence("RU3010_SEQ");
        modelBuilder.HasSequence("RU3020_SEQ");
        modelBuilder.HasSequence("RU6010_SEQ");
        modelBuilder.HasSequence("RU6020_SEQ");
        modelBuilder.HasSequence("RU8010_SEQ");
        modelBuilder.HasSequence("RU9010_SEQ");
        modelBuilder.HasSequence("RUD010_SEQ");
        modelBuilder.HasSequence("RUE010_SEQ");
        modelBuilder.HasSequence("RUE020_SEQ");
        modelBuilder.HasSequence("RUF010_SEQ");
        modelBuilder.HasSequence("RUJ010_SEQ");
        modelBuilder.HasSequence("RUJ020_SEQ");
        modelBuilder.HasSequence("RUM010_SEQ");
        modelBuilder.HasSequence("RUO010_SEQ");
        modelBuilder.HasSequence("RUO020_SEQ");
        modelBuilder.HasSequence("RUX010_SEQ");
        modelBuilder.HasSequence("RUX020_SEQ");
        modelBuilder.HasSequence("RUZ010_SEQ");
        modelBuilder.HasSequence("RUZ020_SEQ");
        modelBuilder.HasSequence("SCAQEFN0_SEQ");
        modelBuilder.HasSequence("SCAQEFP0_SEQ");
        modelBuilder.HasSequence("SCBQCBO0_SEQ");
        modelBuilder.HasSequence("SCBQCBW0_SEQ");
        modelBuilder.HasSequence("SCFWZPP0_SEQ");
        modelBuilder.HasSequence("SCFWZPT0_SEQ");
        modelBuilder.HasSequence("SCFWZXT0_SEQ");
        modelBuilder.HasSequence("SCFWZXW0_SEQ");
        modelBuilder.HasSequence("SCFX2180_SEQ");
        modelBuilder.HasSequence("SCFX2210_SEQ");
        modelBuilder.HasSequence("SCFXC650_SEQ");
        modelBuilder.HasSequence("SCFXC690_SEQ");
        modelBuilder.HasSequence("SCFYBF70_SEQ");
        modelBuilder.HasSequence("SCFYBFA0_SEQ");
        modelBuilder.HasSequence("SCFYJ980_SEQ");
        modelBuilder.HasSequence("SCFYJ990_SEQ");
        modelBuilder.HasSequence("SCGAFBA0_SEQ");
        modelBuilder.HasSequence("SCGAFBC0_SEQ");
        modelBuilder.HasSequence("SCGAFIF0_SEQ");
        modelBuilder.HasSequence("SCGAFII0_SEQ");
        modelBuilder.HasSequence("SH__698B22870317_SEQ");
        modelBuilder.HasSequence("SH__698B22870318_SEQ");
        modelBuilder.HasSequence("SH__698B252A031F_SEQ");
        modelBuilder.HasSequence("SH__698B252A0320_SEQ");
        modelBuilder.HasSequence("SH__698B26740323_SEQ");
        modelBuilder.HasSequence("SH__698B26740324_SEQ");
        modelBuilder.HasSequence("SH__698B28380329_SEQ");
        modelBuilder.HasSequence("SH__698B2838032A_SEQ");
        modelBuilder.HasSequence("SH__698B39BE0331_SEQ");
        modelBuilder.HasSequence("SH__698B39BE0332_SEQ");
        modelBuilder.HasSequence("SH__698B3CDB0339_SEQ");
        modelBuilder.HasSequence("SH__698B3CDB033A_SEQ");
        modelBuilder.HasSequence("SIX_SEQ");
        modelBuilder.HasSequence("SMB010_SEQ");
        modelBuilder.HasSequence("SMB020_SEQ");
        modelBuilder.HasSequence("SMQ010_SEQ");
        modelBuilder.HasSequence("SMQ020_SEQ");
        modelBuilder.HasSequence("SNU010_SEQ");
        modelBuilder.HasSequence("SNU020_SEQ");
        modelBuilder.HasSequence("SWY010_SEQ");
        modelBuilder.HasSequence("SWY020_SEQ");
        modelBuilder.HasSequence("SX1_SEQ");
        modelBuilder.HasSequence("SX2_SEQ");
        modelBuilder.HasSequence("SX3_SEQ");
        modelBuilder.HasSequence("SX3010_SEQ");
        modelBuilder.HasSequence("SX3020_SEQ");
        modelBuilder.HasSequence("SX4010_SEQ");
        modelBuilder.HasSequence("SX4020_SEQ");
        modelBuilder.HasSequence("SX5_SEQ");
        modelBuilder.HasSequence("SX6_SEQ");
        modelBuilder.HasSequence("SX7_SEQ");
        modelBuilder.HasSequence("SX7010_SEQ");
        modelBuilder.HasSequence("SX7020_SEQ");
        modelBuilder.HasSequence("SX9_SEQ");
        modelBuilder.HasSequence("SXA_SEQ");
        modelBuilder.HasSequence("SXB_SEQ");
        modelBuilder.HasSequence("SXB010_SEQ");
        modelBuilder.HasSequence("SXB020_SEQ");
        modelBuilder.HasSequence("SXD_SEQ");
        modelBuilder.HasSequence("SXD010_SEQ");
        modelBuilder.HasSequence("SXD020_SEQ");
        modelBuilder.HasSequence("SXG_SEQ");
        modelBuilder.HasSequence("SXK010_SEQ");
        modelBuilder.HasSequence("SXK020_SEQ");
        modelBuilder.HasSequence("SXO010_SEQ");
        modelBuilder.HasSequence("SXO020_SEQ");
        modelBuilder.HasSequence("SXOFFICE_SEQ");
        modelBuilder.HasSequence("SXP010_SEQ");
        modelBuilder.HasSequence("SXP020_SEQ");
        modelBuilder.HasSequence("SXQ_SEQ");
        modelBuilder.HasSequence("SXQ010_SEQ");
        modelBuilder.HasSequence("SXQ020_SEQ");
        modelBuilder.HasSequence("SXR_SEQ");
        modelBuilder.HasSequence("SXS010_SEQ");
        modelBuilder.HasSequence("SXS020_SEQ");
        modelBuilder.HasSequence("SXT010_SEQ");
        modelBuilder.HasSequence("SXT020_SEQ");
        modelBuilder.HasSequence("SXU010_SEQ");
        modelBuilder.HasSequence("SXU020_SEQ");
        modelBuilder.HasSequence("SXV010_SEQ");
        modelBuilder.HasSequence("SXV020_SEQ");
        modelBuilder.HasSequence("SYS_APP_PARAM_SEQ");
        modelBuilder.HasSequence("SYS_BATCH_UPDATE_SEQ");
        modelBuilder.HasSequence("SYS_BATCH_UPDATE_SET_SEQ");
        modelBuilder.HasSequence("SYS_COMPANY_CFG_SEQ");
        modelBuilder.HasSequence("SYS_COMPANY_CFGIT_SEQ");
        modelBuilder.HasSequence("SYS_COMPANY_SEQ");
        modelBuilder.HasSequence("SYS_GRP_ACCESS_SEQ");
        modelBuilder.HasSequence("SYS_GRP_ACCRESTRIC_SEQ");
        modelBuilder.HasSequence("SYS_GRP_ACESSIB_SEQ");
        modelBuilder.HasSequence("SYS_GRP_FILIAL_SEQ");
        modelBuilder.HasSequence("SYS_GRP_GROUP_SEQ");
        modelBuilder.HasSequence("SYS_GRP_MODULE_SEQ");
        modelBuilder.HasSequence("SYS_GRP_PANEIS_SEQ");
        modelBuilder.HasSequence("SYS_GRP_PRINTER_SEQ");
        modelBuilder.HasSequence("SYS_GRP_WORK_PAPER_SEQ");
        modelBuilder.HasSequence("SYS_POL_COMMUNIC_SEQ");
        modelBuilder.HasSequence("SYS_POL_FLG_IDENTY_SEQ");
        modelBuilder.HasSequence("SYS_POL_OAUTH_SEQ");
        modelBuilder.HasSequence("SYS_POL_PAINEIS_SEQ");
        modelBuilder.HasSequence("SYS_POL_POLICE_SEQ");
        modelBuilder.HasSequence("SYS_POL_PROTHEUS_SEQ");
        modelBuilder.HasSequence("SYS_POL_RULES_VIOL_SEQ");
        modelBuilder.HasSequence("SYS_POL_SAML_SEQ");
        modelBuilder.HasSequence("SYS_PROJECT_MENU_01_SEQ");
        modelBuilder.HasSequence("SYS_REFERENCE_VAL_R_SEQ");
        modelBuilder.HasSequence("SYS_REFERENCE_VAL_SEQ");
        modelBuilder.HasSequence("SYS_RULES_BUTTONS_SEQ");
        modelBuilder.HasSequence("SYS_RULES_FEATURES_SEQ");
        modelBuilder.HasSequence("SYS_RULES_GRP_GLO_SEQ");
        modelBuilder.HasSequence("SYS_RULES_GRP_RULES_SEQ");
        modelBuilder.HasSequence("SYS_RULES_SEQ");
        modelBuilder.HasSequence("SYS_RULES_TRANSACT_SEQ");
        modelBuilder.HasSequence("SYS_RULES_USR_GLO_SEQ");
        modelBuilder.HasSequence("SYS_RULES_USR_RULES_SEQ");
        modelBuilder.HasSequence("SYS_TEMP_OPT_HEAD_01_SEQ");
        modelBuilder.HasSequence("SYS_TEMP_OPT_ITEM_01_SEQ");
        modelBuilder.HasSequence("SYS_UPDATE_LOG_HEAD_SEQ");
        modelBuilder.HasSequence("SYS_UPDATE_LOG_ITEM_SEQ");
        modelBuilder.HasSequence("SYS_USR_ACCESS_SEQ");
        modelBuilder.HasSequence("SYS_USR_ACCRESTRIC_SEQ");
        modelBuilder.HasSequence("SYS_USR_ACESSIB_SEQ");
        modelBuilder.HasSequence("SYS_USR_FILIAL_SEQ");
        modelBuilder.HasSequence("SYS_USR_GROUPS_SEQ");
        modelBuilder.HasSequence("SYS_USR_LOGCFG_SEQ");
        modelBuilder.HasSequence("SYS_USR_LOGIN_SEQ");
        modelBuilder.HasSequence("SYS_USR_MODULE_SEQ");
        modelBuilder.HasSequence("SYS_USR_OAUTH_SEQ");
        modelBuilder.HasSequence("SYS_USR_PANEIS_SEQ");
        modelBuilder.HasSequence("SYS_USR_PAPER_SEQ");
        modelBuilder.HasSequence("SYS_USR_PRINTER_SEQ");
        modelBuilder.HasSequence("SYS_USR_SEQ");
        modelBuilder.HasSequence("SYS_USR_SSIGNON_SEQ");
        modelBuilder.HasSequence("SYS_USR_SUPER_SEQ");
        modelBuilder.HasSequence("SYS_USR_VINCFUNC_SEQ");
        modelBuilder.HasSequence("T03010_SEQ");
        modelBuilder.HasSequence("T03020_SEQ");
        modelBuilder.HasSequence("T04010_SEQ");
        modelBuilder.HasSequence("T04020_SEQ");
        modelBuilder.HasSequence("T05010_SEQ");
        modelBuilder.HasSequence("T05020_SEQ");
        modelBuilder.HasSequence("T06010_SEQ");
        modelBuilder.HasSequence("T06020_SEQ");
        modelBuilder.HasSequence("T0I010_SEQ");
        modelBuilder.HasSequence("T0I020_SEQ");
        modelBuilder.HasSequence("T0I030_SEQ");
        modelBuilder.HasSequence("T0K010_SEQ");
        modelBuilder.HasSequence("T0K020_SEQ");
        modelBuilder.HasSequence("T0K030_SEQ");
        modelBuilder.HasSequence("T0L010_SEQ");
        modelBuilder.HasSequence("T0L020_SEQ");
        modelBuilder.HasSequence("T0L030_SEQ");
        modelBuilder.HasSequence("T0M010_SEQ");
        modelBuilder.HasSequence("T0M020_SEQ");
        modelBuilder.HasSequence("T0V010_SEQ");
        modelBuilder.HasSequence("T0V020_SEQ");
        modelBuilder.HasSequence("T0V030_SEQ");
        modelBuilder.HasSequence("T10010_SEQ");
        modelBuilder.HasSequence("T10020_SEQ");
        modelBuilder.HasSequence("T11010_SEQ");
        modelBuilder.HasSequence("T11020_SEQ");
        modelBuilder.HasSequence("T12010_SEQ");
        modelBuilder.HasSequence("T12020_SEQ");
        modelBuilder.HasSequence("T12030_SEQ");
        modelBuilder.HasSequence("T13010_SEQ");
        modelBuilder.HasSequence("T13020_SEQ");
        modelBuilder.HasSequence("T13030_SEQ");
        modelBuilder.HasSequence("T15010_SEQ");
        modelBuilder.HasSequence("T15020_SEQ");
        modelBuilder.HasSequence("T16010_SEQ");
        modelBuilder.HasSequence("T16020_SEQ");
        modelBuilder.HasSequence("T17010_SEQ");
        modelBuilder.HasSequence("T17020_SEQ");
        modelBuilder.HasSequence("T18010_SEQ");
        modelBuilder.HasSequence("T18020_SEQ");
        modelBuilder.HasSequence("T19010_SEQ");
        modelBuilder.HasSequence("T19020_SEQ");
        modelBuilder.HasSequence("T1C010_SEQ");
        modelBuilder.HasSequence("T1C020_SEQ");
        modelBuilder.HasSequence("T1T010_SEQ");
        modelBuilder.HasSequence("T1T020_SEQ");
        modelBuilder.HasSequence("T1T030_SEQ");
        modelBuilder.HasSequence("T20010_SEQ");
        modelBuilder.HasSequence("T20020_SEQ");
        modelBuilder.HasSequence("T21010_SEQ");
        modelBuilder.HasSequence("T21020_SEQ");
        modelBuilder.HasSequence("T22010_SEQ");
        modelBuilder.HasSequence("T22020_SEQ");
        modelBuilder.HasSequence("T23010_SEQ");
        modelBuilder.HasSequence("T23020_SEQ");
        modelBuilder.HasSequence("T24010_SEQ");
        modelBuilder.HasSequence("T24020_SEQ");
        modelBuilder.HasSequence("T25010_SEQ");
        modelBuilder.HasSequence("T25020_SEQ");
        modelBuilder.HasSequence("T26_SEQ");
        modelBuilder.HasSequence("T26010_SEQ");
        modelBuilder.HasSequence("T26020_SEQ");
        modelBuilder.HasSequence("T26030_SEQ");
        modelBuilder.HasSequence("T27_SEQ");
        modelBuilder.HasSequence("T27020_SEQ");
        modelBuilder.HasSequence("T28_SEQ");
        modelBuilder.HasSequence("T28020_SEQ");
        modelBuilder.HasSequence("T29_SEQ");
        modelBuilder.HasSequence("T29020_SEQ");
        modelBuilder.HasSequence("T2D010_SEQ");
        modelBuilder.HasSequence("T2D020_SEQ");
        modelBuilder.HasSequence("T2D030_SEQ");
        modelBuilder.HasSequence("T2T010_SEQ");
        modelBuilder.HasSequence("T2T020_SEQ");
        modelBuilder.HasSequence("T2T030_SEQ");
        modelBuilder.HasSequence("T30010_SEQ");
        modelBuilder.HasSequence("T30020_SEQ");
        modelBuilder.HasSequence("T31010_SEQ");
        modelBuilder.HasSequence("T31020_SEQ");
        modelBuilder.HasSequence("T32010_SEQ");
        modelBuilder.HasSequence("T32020_SEQ");
        modelBuilder.HasSequence("T33010_SEQ");
        modelBuilder.HasSequence("T33020_SEQ");
        modelBuilder.HasSequence("T34010_SEQ");
        modelBuilder.HasSequence("T34020_SEQ");
        modelBuilder.HasSequence("T34030_SEQ");
        modelBuilder.HasSequence("T35010_SEQ");
        modelBuilder.HasSequence("T35020_SEQ");
        modelBuilder.HasSequence("T36010_SEQ");
        modelBuilder.HasSequence("T36020_SEQ");
        modelBuilder.HasSequence("T37010_SEQ");
        modelBuilder.HasSequence("T37020_SEQ");
        modelBuilder.HasSequence("T37030_SEQ");
        modelBuilder.HasSequence("T38010_SEQ");
        modelBuilder.HasSequence("T38020_SEQ");
        modelBuilder.HasSequence("T39010_SEQ");
        modelBuilder.HasSequence("T39020_SEQ");
        modelBuilder.HasSequence("T3A010_SEQ");
        modelBuilder.HasSequence("T3A020_SEQ");
        modelBuilder.HasSequence("T3B010_SEQ");
        modelBuilder.HasSequence("T3B020_SEQ");
        modelBuilder.HasSequence("T3C010_SEQ");
        modelBuilder.HasSequence("T3D010_SEQ");
        modelBuilder.HasSequence("T3E010_SEQ");
        modelBuilder.HasSequence("T3E020_SEQ");
        modelBuilder.HasSequence("T3E030_SEQ");
        modelBuilder.HasSequence("T3G010_SEQ");
        modelBuilder.HasSequence("T3G020_SEQ");
        modelBuilder.HasSequence("T3H010_SEQ");
        modelBuilder.HasSequence("T3H020_SEQ");
        modelBuilder.HasSequence("T3I010_SEQ");
        modelBuilder.HasSequence("T3I020_SEQ");
        modelBuilder.HasSequence("T3J010_SEQ");
        modelBuilder.HasSequence("T3J020_SEQ");
        modelBuilder.HasSequence("T3L010_SEQ");
        modelBuilder.HasSequence("T3L020_SEQ");
        modelBuilder.HasSequence("T3M010_SEQ");
        modelBuilder.HasSequence("T3M020_SEQ");
        modelBuilder.HasSequence("T54010_SEQ");
        modelBuilder.HasSequence("T54020_SEQ");
        modelBuilder.HasSequence("T54030_SEQ");
        modelBuilder.HasSequence("T55010_SEQ");
        modelBuilder.HasSequence("T55020_SEQ");
        modelBuilder.HasSequence("T55030_SEQ");
        modelBuilder.HasSequence("T58010_SEQ");
        modelBuilder.HasSequence("T58020_SEQ");
        modelBuilder.HasSequence("T58030_SEQ");
        modelBuilder.HasSequence("T59010_SEQ");
        modelBuilder.HasSequence("T59020_SEQ");
        modelBuilder.HasSequence("T59030_SEQ");
        modelBuilder.HasSequence("T5A010_SEQ");
        modelBuilder.HasSequence("T5A020_SEQ");
        modelBuilder.HasSequence("T5A030_SEQ");
        modelBuilder.HasSequence("T5B010_SEQ");
        modelBuilder.HasSequence("T5B020_SEQ");
        modelBuilder.HasSequence("T5B030_SEQ");
        modelBuilder.HasSequence("T5C010_SEQ");
        modelBuilder.HasSequence("T5C020_SEQ");
        modelBuilder.HasSequence("T5C030_SEQ");
        modelBuilder.HasSequence("T5D010_SEQ");
        modelBuilder.HasSequence("T5D020_SEQ");
        modelBuilder.HasSequence("T5D030_SEQ");
        modelBuilder.HasSequence("T5E010_SEQ");
        modelBuilder.HasSequence("T5E020_SEQ");
        modelBuilder.HasSequence("T5E030_SEQ");
        modelBuilder.HasSequence("T5F010_SEQ");
        modelBuilder.HasSequence("T5F020_SEQ");
        modelBuilder.HasSequence("T5F030_SEQ");
        modelBuilder.HasSequence("T5G010_SEQ");
        modelBuilder.HasSequence("T5G020_SEQ");
        modelBuilder.HasSequence("T5G030_SEQ");
        modelBuilder.HasSequence("T5H010_SEQ");
        modelBuilder.HasSequence("T5H020_SEQ");
        modelBuilder.HasSequence("T5H030_SEQ");
        modelBuilder.HasSequence("T5O010_SEQ");
        modelBuilder.HasSequence("T5O020_SEQ");
        modelBuilder.HasSequence("T5O030_SEQ");
        modelBuilder.HasSequence("T71010_SEQ");
        modelBuilder.HasSequence("T71020_SEQ");
        modelBuilder.HasSequence("T71030_SEQ");
        modelBuilder.HasSequence("T81010_SEQ");
        modelBuilder.HasSequence("T81020_SEQ");
        modelBuilder.HasSequence("T82010_SEQ");
        modelBuilder.HasSequence("T82020_SEQ");
        modelBuilder.HasSequence("T83010_SEQ");
        modelBuilder.HasSequence("T83020_SEQ");
        modelBuilder.HasSequence("T84010_SEQ");
        modelBuilder.HasSequence("T84020_SEQ");
        modelBuilder.HasSequence("T85010_SEQ");
        modelBuilder.HasSequence("T85020_SEQ");
        modelBuilder.HasSequence("T8D010_SEQ");
        modelBuilder.HasSequence("T8D020_SEQ");
        modelBuilder.HasSequence("T8E010_SEQ");
        modelBuilder.HasSequence("T8E020_SEQ");
        modelBuilder.HasSequence("T8G010_SEQ");
        modelBuilder.HasSequence("T8G020_SEQ");
        modelBuilder.HasSequence("T8H010_SEQ");
        modelBuilder.HasSequence("T8H020_SEQ");
        modelBuilder.HasSequence("T8I010_SEQ");
        modelBuilder.HasSequence("T8I020_SEQ");
        modelBuilder.HasSequence("T8J010_SEQ");
        modelBuilder.HasSequence("T8J020_SEQ");
        modelBuilder.HasSequence("T8K010_SEQ");
        modelBuilder.HasSequence("T8K020_SEQ");
        modelBuilder.HasSequence("T8L010_SEQ");
        modelBuilder.HasSequence("T8L020_SEQ");
        modelBuilder.HasSequence("T8M010_SEQ");
        modelBuilder.HasSequence("T8M020_SEQ");
        modelBuilder.HasSequence("T8N010_SEQ");
        modelBuilder.HasSequence("T8N020_SEQ");
        modelBuilder.HasSequence("T9A010_SEQ");
        modelBuilder.HasSequence("T9A020_SEQ");
        modelBuilder.HasSequence("T9B010_SEQ");
        modelBuilder.HasSequence("T9B020_SEQ");
        modelBuilder.HasSequence("TAFECF_01_SEQ");
        modelBuilder.HasSequence("TAFECF_02_SEQ");
        modelBuilder.HasSequence("TAFGERCTL_SEQ");
        modelBuilder.HasSequence("TAFSPED_01_SEQ");
        modelBuilder.HasSequence("TAFSPED_02_SEQ");
        modelBuilder.HasSequence("TAFST1_SEQ");
        modelBuilder.HasSequence("TAFST2_SEQ");
        modelBuilder.HasSequence("TAFXERP_SEQ");
        modelBuilder.HasSequence("TEF010_SP_SEQ");
        modelBuilder.HasSequence("TEF020_SP_SEQ");
        modelBuilder.HasSequence("TR201SP_SEQ");
        modelBuilder.HasSequence("TR202SP_SEQ");
        modelBuilder.HasSequence("TRA01SP_SEQ");
        modelBuilder.HasSequence("TRA02SP_SEQ");
        modelBuilder.HasSequence("TRB010_SPMATA280_SEQ");
        modelBuilder.HasSequence("TRB01SP_SEQ");
        modelBuilder.HasSequence("TRB01SPSG1_SEQ");
        modelBuilder.HasSequence("TRB020_SPMATA280_SEQ");
        modelBuilder.HasSequence("TRB02SP_SEQ");
        modelBuilder.HasSequence("TRB02SPSG1_SEQ");
        modelBuilder.HasSequence("TRC010_SP_SEQ");
        modelBuilder.HasSequence("TRC01SP_SEQ");
        modelBuilder.HasSequence("TRC020_SP_SEQ");
        modelBuilder.HasSequence("TRC02SP_SEQ");
        modelBuilder.HasSequence("TRD01SP_SEQ");
        modelBuilder.HasSequence("TRD02SP_SEQ");
        modelBuilder.HasSequence("TRJ010_SP_SEQ");
        modelBuilder.HasSequence("TRJ020_SP_SEQ");
        modelBuilder.HasSequence("TRK010_SP_SEQ");
        modelBuilder.HasSequence("TRK020_SP_SEQ");
        modelBuilder.HasSequence("TRR01SP09_SEQ");
        modelBuilder.HasSequence("TRR02SP09_SEQ");
        modelBuilder.HasSequence("TRT01SP_SEQ");
        modelBuilder.HasSequence("TRT02SP_SEQ");
        modelBuilder.HasSequence("TRX01SP_SEQ");
        modelBuilder.HasSequence("TRX02SP_SEQ");
        modelBuilder.HasSequence("TRZ010_SP_SEQ");
        modelBuilder.HasSequence("TRZ020_SP_SEQ");
        modelBuilder.HasSequence("TSC00_1002359361_SEQ");
        modelBuilder.HasSequence("TSC00_1004295401_SEQ");
        modelBuilder.HasSequence("TSC00_11445411_SEQ");
        modelBuilder.HasSequence("TSC00_1148214931_SEQ");
        modelBuilder.HasSequence("TSC00_121474141_SEQ");
        modelBuilder.HasSequence("TSC00_1218267101_SEQ");
        modelBuilder.HasSequence("TSC00_1219357771_SEQ");
        modelBuilder.HasSequence("TSC00_1222591741_SEQ");
        modelBuilder.HasSequence("TSC00_123298061_SEQ");
        modelBuilder.HasSequence("TSC00_1233626211_SEQ");
        modelBuilder.HasSequence("TSC00_1236196131_SEQ");
        modelBuilder.HasSequence("TSC00_1240263941_SEQ");
        modelBuilder.HasSequence("TSC00_1241599651_SEQ");
        modelBuilder.HasSequence("TSC00_1248573361_SEQ");
        modelBuilder.HasSequence("TSC00_1249616251_SEQ");
        modelBuilder.HasSequence("TSC00_12599551_SEQ");
        modelBuilder.HasSequence("TSC00_1456591431_SEQ");
        modelBuilder.HasSequence("TSC00_1469350581_SEQ");
        modelBuilder.HasSequence("TSC00_147835291_SEQ");
        modelBuilder.HasSequence("TSC00_1489539561_SEQ");
        modelBuilder.HasSequence("TSC00_16414621_SEQ");
        modelBuilder.HasSequence("TSC00_1697111441_SEQ");
        modelBuilder.HasSequence("TSC00_170715021_SEQ");
        modelBuilder.HasSequence("TSC00_17091571_SEQ");
        modelBuilder.HasSequence("TSC00_1713560741_SEQ");
        modelBuilder.HasSequence("TSC00_1718501161_SEQ");
        modelBuilder.HasSequence("TSC00_1722602951_SEQ");
        modelBuilder.HasSequence("TSC00_1724495621_SEQ");
        modelBuilder.HasSequence("TSC00_172948891_SEQ");
        modelBuilder.HasSequence("TSC00_18522331_SEQ");
        modelBuilder.HasSequence("TSC00_1917581_SEQ");
        modelBuilder.HasSequence("TSC00_1955173961_SEQ");
        modelBuilder.HasSequence("TSC00_1966500601_SEQ");
        modelBuilder.HasSequence("TSC00_1970431441_SEQ");
        modelBuilder.HasSequence("TSC00_1978365981_SEQ");
        modelBuilder.HasSequence("TSC00_200339771_SEQ");
        modelBuilder.HasSequence("TSC00_207653571_SEQ");
        modelBuilder.HasSequence("TSC00_2090541651_SEQ");
        modelBuilder.HasSequence("TSC00_2090553491_SEQ");
        modelBuilder.HasSequence("TSC00_21119691_SEQ");
        modelBuilder.HasSequence("TSC00_2195311361_SEQ");
        modelBuilder.HasSequence("TSC00_2201261011_SEQ");
        modelBuilder.HasSequence("TSC00_2211404771_SEQ");
        modelBuilder.HasSequence("TSC00_22361951_SEQ");
        modelBuilder.HasSequence("TSC00_2272341551_SEQ");
        modelBuilder.HasSequence("TSC00_242816451_SEQ");
        modelBuilder.HasSequence("TSC00_243166191_SEQ");
        modelBuilder.HasSequence("TSC00_2435435411_SEQ");
        modelBuilder.HasSequence("TSC00_2443642791_SEQ");
        modelBuilder.HasSequence("TSC00_2445315471_SEQ");
        modelBuilder.HasSequence("TSC00_2452115311_SEQ");
        modelBuilder.HasSequence("TSC00_259164921_SEQ");
        modelBuilder.HasSequence("TSC00_264205731_SEQ");
        modelBuilder.HasSequence("TSC00_2668459881_SEQ");
        modelBuilder.HasSequence("TSC00_2675129221_SEQ");
        modelBuilder.HasSequence("TSC00_268395611_SEQ");
        modelBuilder.HasSequence("TSC00_271495231_SEQ");
        modelBuilder.HasSequence("TSC00_274291831_SEQ");
        modelBuilder.HasSequence("TSC00_279440631_SEQ");
        modelBuilder.HasSequence("TSC00_2851568451_SEQ");
        modelBuilder.HasSequence("TSC00_2910367661_SEQ");
        modelBuilder.HasSequence("TSC00_293941621_SEQ");
        modelBuilder.HasSequence("TSC00_2943469331_SEQ");
        modelBuilder.HasSequence("TSC00_294425491_SEQ");
        modelBuilder.HasSequence("TSC00_3155265081_SEQ");
        modelBuilder.HasSequence("TSC00_3158420511_SEQ");
        modelBuilder.HasSequence("TSC00_3166645731_SEQ");
        modelBuilder.HasSequence("TSC00_3173409291_SEQ");
        modelBuilder.HasSequence("TSC00_3175251811_SEQ");
        modelBuilder.HasSequence("TSC00_3177416951_SEQ");
        modelBuilder.HasSequence("TSC00_36222711_SEQ");
        modelBuilder.HasSequence("TSC00_3635573861_SEQ");
        modelBuilder.HasSequence("TSC00_3656201281_SEQ");
        modelBuilder.HasSequence("TSC00_37566391_SEQ");
        modelBuilder.HasSequence("TSC00_491551011_SEQ");
        modelBuilder.HasSequence("TSC00_492186421_SEQ");
        modelBuilder.HasSequence("TSC00_498290291_SEQ");
        modelBuilder.HasSequence("TSC00_508196181_SEQ");
        modelBuilder.HasSequence("TSC00_510472581_SEQ");
        modelBuilder.HasSequence("TSC00_521586981_SEQ");
        modelBuilder.HasSequence("TSC00_52392191_SEQ");
        modelBuilder.HasSequence("TSC00_52578651_SEQ");
        modelBuilder.HasSequence("TSC00_7385911_SEQ");
        modelBuilder.HasSequence("TSC00_7444411_SEQ");
        modelBuilder.HasSequence("TSC00_751330891_SEQ");
        modelBuilder.HasSequence("TSC00_759551451_SEQ");
        modelBuilder.HasSequence("TSC00_766253551_SEQ");
        modelBuilder.HasSequence("TSC00_977161661_SEQ");
        modelBuilder.HasSequence("TSC00_978603631_SEQ");
        modelBuilder.HasSequence("TSC00_980229371_SEQ");
        modelBuilder.HasSequence("TSC00_985265431_SEQ");
        modelBuilder.HasSequence("TSC01_1233626211_SEQ");
        modelBuilder.HasSequence("TSC01_1236196131_SEQ");
        modelBuilder.HasSequence("TSC01_1241599651_SEQ");
        modelBuilder.HasSequence("TSC01_14132071_SEQ");
        modelBuilder.HasSequence("TSC01_16414621_SEQ");
        modelBuilder.HasSequence("TSC01_1955173961_SEQ");
        modelBuilder.HasSequence("TSC01_1966500601_SEQ");
        modelBuilder.HasSequence("TSC01_1978365981_SEQ");
        modelBuilder.HasSequence("TSC01_2445315471_SEQ");
        modelBuilder.HasSequence("TSC01_2943469331_SEQ");
        modelBuilder.HasSequence("TSC01_3177416951_SEQ");
        modelBuilder.HasSequence("TSC01_3635573861_SEQ");
        modelBuilder.HasSequence("TSC01_7444411_SEQ");
        modelBuilder.HasSequence("TSC01_978603631_SEQ");
        modelBuilder.HasSequence("TSC02_1233626211_SEQ");
        modelBuilder.HasSequence("TSC02_1236196131_SEQ");
        modelBuilder.HasSequence("TSC02_1241599651_SEQ");
        modelBuilder.HasSequence("TSC02_1955173961_SEQ");
        modelBuilder.HasSequence("TSC02_1978365981_SEQ");
        modelBuilder.HasSequence("TSC02_3635573861_SEQ");
        modelBuilder.HasSequence("TSC02_5158871_SEQ");
        modelBuilder.HasSequence("TSC02_582311051_SEQ");
        modelBuilder.HasSequence("TSC02_7444411_SEQ");
        modelBuilder.HasSequence("TSC02_773300271_SEQ");
        modelBuilder.HasSequence("TSC03_1233626211_SEQ");
        modelBuilder.HasSequence("TSC03_1241599651_SEQ");
        modelBuilder.HasSequence("TSC03_1955173961_SEQ");
        modelBuilder.HasSequence("TSC03_1978365981_SEQ");
        modelBuilder.HasSequence("TSC03_7444411_SEQ");
        modelBuilder.HasSequence("TSC04_1233626211_SEQ");
        modelBuilder.HasSequence("TSC04_1241599651_SEQ");
        modelBuilder.HasSequence("TSC04_1955173961_SEQ");
        modelBuilder.HasSequence("TSC04_1978365981_SEQ");
        modelBuilder.HasSequence("TSC04_7444411_SEQ");
        modelBuilder.HasSequence("TSC05_1233626211_SEQ");
        modelBuilder.HasSequence("TSC05_1241599651_SEQ");
        modelBuilder.HasSequence("TSC05_1955173961_SEQ");
        modelBuilder.HasSequence("TSC05_1978365981_SEQ");
        modelBuilder.HasSequence("TSC05_7444411_SEQ");
        modelBuilder.HasSequence("TSC06_1233626211_SEQ");
        modelBuilder.HasSequence("TSC06_1241599651_SEQ");
        modelBuilder.HasSequence("TSC06_1955173961_SEQ");
        modelBuilder.HasSequence("TSC06_1978365981_SEQ");
        modelBuilder.HasSequence("TSC07_14559351_SEQ");
        modelBuilder.HasSequence("TSC07_1955173961_SEQ");
        modelBuilder.HasSequence("TSC07_1978365981_SEQ");
        modelBuilder.HasSequence("TSC08_1978365981_SEQ");
        modelBuilder.HasSequence("TSC09_1978365981_SEQ");
        modelBuilder.HasSequence("TSC12_7444411_SEQ");
        modelBuilder.HasSequence("TSC13_7444411_SEQ");
        modelBuilder.HasSequence("TSC31_2201261011_SEQ");
        modelBuilder.HasSequence("TSCB0_37566391_SEQ");
        modelBuilder.HasSequence("TSS0004_SEQ");
        modelBuilder.HasSequence("TSSTR3_SEQ");
        modelBuilder.HasSequence("V15010_SEQ");
        modelBuilder.HasSequence("V15020_SEQ");
        modelBuilder.HasSequence("V17010_SEQ");
        modelBuilder.HasSequence("V17020_SEQ");
        modelBuilder.HasSequence("V18010_SEQ");
        modelBuilder.HasSequence("V18020_SEQ");
        modelBuilder.HasSequence("V1P010_SEQ");
        modelBuilder.HasSequence("V1P020_SEQ");
        modelBuilder.HasSequence("V26010_SEQ");
        modelBuilder.HasSequence("V26020_SEQ");
        modelBuilder.HasSequence("V27010_SEQ");
        modelBuilder.HasSequence("V27020_SEQ");
        modelBuilder.HasSequence("V28010_SEQ");
        modelBuilder.HasSequence("V28020_SEQ");
        modelBuilder.HasSequence("V29010_SEQ");
        modelBuilder.HasSequence("V29020_SEQ");
        modelBuilder.HasSequence("V2K010_SEQ");
        modelBuilder.HasSequence("V2K020_SEQ");
        modelBuilder.HasSequence("V2L010_SEQ");
        modelBuilder.HasSequence("V2L020_SEQ");
        modelBuilder.HasSequence("V2M010_SEQ");
        modelBuilder.HasSequence("V2M020_SEQ");
        modelBuilder.HasSequence("V3A010_SEQ");
        modelBuilder.HasSequence("V3A020_SEQ");
        modelBuilder.HasSequence("V3F010_SEQ");
        modelBuilder.HasSequence("V3F020_SEQ");
        modelBuilder.HasSequence("V3K010_SEQ");
        modelBuilder.HasSequence("V3K020_SEQ");
        modelBuilder.HasSequence("V3O010_SEQ");
        modelBuilder.HasSequence("V3Q010_SEQ");
        modelBuilder.HasSequence("V4E010_SEQ");
        modelBuilder.HasSequence("V50010_SEQ");
        modelBuilder.HasSequence("V50020_SEQ");
        modelBuilder.HasSequence("V51010_SEQ");
        modelBuilder.HasSequence("V51020_SEQ");
        modelBuilder.HasSequence("V52010_SEQ");
        modelBuilder.HasSequence("V52020_SEQ");
        modelBuilder.HasSequence("V53010_SEQ");
        modelBuilder.HasSequence("V53020_SEQ");
        modelBuilder.HasSequence("V54010_SEQ");
        modelBuilder.HasSequence("V54020_SEQ");
        modelBuilder.HasSequence("V55010_SEQ");
        modelBuilder.HasSequence("V55020_SEQ");
        modelBuilder.HasSequence("V57010_SEQ");
        modelBuilder.HasSequence("V57020_SEQ");
        modelBuilder.HasSequence("V5L010_SEQ");
        modelBuilder.HasSequence("V5L020_SEQ");
        modelBuilder.HasSequence("V5O010_SEQ");
        modelBuilder.HasSequence("V5O020_SEQ");
        modelBuilder.HasSequence("V5W010_SEQ");
        modelBuilder.HasSequence("V5W020_SEQ");
        modelBuilder.HasSequence("V5X010_SEQ");
        modelBuilder.HasSequence("V5X020_SEQ");
        modelBuilder.HasSequence("V5Y010_SEQ");
        modelBuilder.HasSequence("V5Y020_SEQ");
        modelBuilder.HasSequence("V5Z010_SEQ");
        modelBuilder.HasSequence("V5Z020_SEQ");
        modelBuilder.HasSequence("V60010_SEQ");
        modelBuilder.HasSequence("V60020_SEQ");
        modelBuilder.HasSequence("V61010_SEQ");
        modelBuilder.HasSequence("V61020_SEQ");
        modelBuilder.HasSequence("V62010_SEQ");
        modelBuilder.HasSequence("V62020_SEQ");
        modelBuilder.HasSequence("V63010_SEQ");
        modelBuilder.HasSequence("V63020_SEQ");
        modelBuilder.HasSequence("V64010_SEQ");
        modelBuilder.HasSequence("V64020_SEQ");
        modelBuilder.HasSequence("V65010_SEQ");
        modelBuilder.HasSequence("V65020_SEQ");
        modelBuilder.HasSequence("V66010_SEQ");
        modelBuilder.HasSequence("V66020_SEQ");
        modelBuilder.HasSequence("V67010_SEQ");
        modelBuilder.HasSequence("V67020_SEQ");
        modelBuilder.HasSequence("V68010_SEQ");
        modelBuilder.HasSequence("V68020_SEQ");
        modelBuilder.HasSequence("V69010_SEQ");
        modelBuilder.HasSequence("V69020_SEQ");
        modelBuilder.HasSequence("V6A010_SEQ");
        modelBuilder.HasSequence("V6A020_SEQ");
        modelBuilder.HasSequence("V6T010_SEQ");
        modelBuilder.HasSequence("V6T020_SEQ");
        modelBuilder.HasSequence("V6U010_SEQ");
        modelBuilder.HasSequence("V6U020_SEQ");
        modelBuilder.HasSequence("V6Z010_SEQ");
        modelBuilder.HasSequence("V6Z020_SEQ");
        modelBuilder.HasSequence("V72010_SEQ");
        modelBuilder.HasSequence("V72020_SEQ");
        modelBuilder.HasSequence("V73010_SEQ");
        modelBuilder.HasSequence("V73020_SEQ");
        modelBuilder.HasSequence("V75010_SEQ");
        modelBuilder.HasSequence("V75020_SEQ");
        modelBuilder.HasSequence("V76010_SEQ");
        modelBuilder.HasSequence("V76020_SEQ");
        modelBuilder.HasSequence("V77010_SEQ");
        modelBuilder.HasSequence("V77020_SEQ");
        modelBuilder.HasSequence("V78010_SEQ");
        modelBuilder.HasSequence("V78020_SEQ");
        modelBuilder.HasSequence("V7C010_SEQ");
        modelBuilder.HasSequence("V7C020_SEQ");
        modelBuilder.HasSequence("V7J010_SEQ");
        modelBuilder.HasSequence("V7J020_SEQ");
        modelBuilder.HasSequence("V7K010_SEQ");
        modelBuilder.HasSequence("V7K020_SEQ");
        modelBuilder.HasSequence("V7M010_SEQ");
        modelBuilder.HasSequence("V7M020_SEQ");
        modelBuilder.HasSequence("V7N010_SEQ");
        modelBuilder.HasSequence("V7N020_SEQ");
        modelBuilder.HasSequence("V7U010_SEQ");
        modelBuilder.HasSequence("V7U020_SEQ");
        modelBuilder.HasSequence("V7W010_SEQ");
        modelBuilder.HasSequence("V7W020_SEQ");
        modelBuilder.HasSequence("V7X010_SEQ");
        modelBuilder.HasSequence("V7X020_SEQ");
        modelBuilder.HasSequence("V7Y010_SEQ");
        modelBuilder.HasSequence("V7Y020_SEQ");
        modelBuilder.HasSequence("V7Z010_SEQ");
        modelBuilder.HasSequence("V7Z020_SEQ");
        modelBuilder.HasSequence("V81010_SEQ");
        modelBuilder.HasSequence("V81020_SEQ");
        modelBuilder.HasSequence("V83010_SEQ");
        modelBuilder.HasSequence("V83020_SEQ");
        modelBuilder.HasSequence("V84010_SEQ");
        modelBuilder.HasSequence("V84020_SEQ");
        modelBuilder.HasSequence("V85010_SEQ");
        modelBuilder.HasSequence("V85020_SEQ");
        modelBuilder.HasSequence("V86010_SEQ");
        modelBuilder.HasSequence("V86020_SEQ");
        modelBuilder.HasSequence("V89010_SEQ");
        modelBuilder.HasSequence("V89020_SEQ");
        modelBuilder.HasSequence("V8A010_SEQ");
        modelBuilder.HasSequence("V8A020_SEQ");
        modelBuilder.HasSequence("V8B010_SEQ");
        modelBuilder.HasSequence("V8B020_SEQ");
        modelBuilder.HasSequence("V8C010_SEQ");
        modelBuilder.HasSequence("V8C020_SEQ");
        modelBuilder.HasSequence("V8D010_SEQ");
        modelBuilder.HasSequence("V8D020_SEQ");
        modelBuilder.HasSequence("V8E010_SEQ");
        modelBuilder.HasSequence("V8E020_SEQ");
        modelBuilder.HasSequence("V8F010_SEQ");
        modelBuilder.HasSequence("V8F020_SEQ");
        modelBuilder.HasSequence("V8G010_SEQ");
        modelBuilder.HasSequence("V8G020_SEQ");
        modelBuilder.HasSequence("V8H010_SEQ");
        modelBuilder.HasSequence("V8H020_SEQ");
        modelBuilder.HasSequence("V8J010_SEQ");
        modelBuilder.HasSequence("V8J020_SEQ");
        modelBuilder.HasSequence("V8T010_SEQ");
        modelBuilder.HasSequence("V8T020_SEQ");
        modelBuilder.HasSequence("V8V010_SEQ");
        modelBuilder.HasSequence("V8V020_SEQ");
        modelBuilder.HasSequence("V90010_SEQ");
        modelBuilder.HasSequence("V90020_SEQ");
        modelBuilder.HasSequence("V93010_SEQ");
        modelBuilder.HasSequence("V93020_SEQ");
        modelBuilder.HasSequence("V94010_SEQ");
        modelBuilder.HasSequence("V94020_SEQ");
        modelBuilder.HasSequence("V95010_SEQ");
        modelBuilder.HasSequence("V95020_SEQ");
        modelBuilder.HasSequence("V96010_SEQ");
        modelBuilder.HasSequence("V96020_SEQ");
        modelBuilder.HasSequence("V97010_SEQ");
        modelBuilder.HasSequence("V98010_SEQ");
        modelBuilder.HasSequence("V99010_SEQ");
        modelBuilder.HasSequence("V9A010_SEQ");
        modelBuilder.HasSequence("V9B010_SEQ");
        modelBuilder.HasSequence("V9B020_SEQ");
        modelBuilder.HasSequence("V9D010_SEQ");
        modelBuilder.HasSequence("V9D020_SEQ");
        modelBuilder.HasSequence("V9F010_SEQ");
        modelBuilder.HasSequence("V9F020_SEQ");
        modelBuilder.HasSequence("V9G010_SEQ");
        modelBuilder.HasSequence("V9G020_SEQ");
        modelBuilder.HasSequence("V9H010_SEQ");
        modelBuilder.HasSequence("V9H020_SEQ");
        modelBuilder.HasSequence("V9K010_SEQ");
        modelBuilder.HasSequence("V9K020_SEQ");
        modelBuilder.HasSequence("V9L010_SEQ");
        modelBuilder.HasSequence("V9L020_SEQ");
        modelBuilder.HasSequence("V9N010_SEQ");
        modelBuilder.HasSequence("V9O010_SEQ");
        modelBuilder.HasSequence("V9Q010_SEQ");
        modelBuilder.HasSequence("V9Q020_SEQ");
        modelBuilder.HasSequence("V9R010_SEQ");
        modelBuilder.HasSequence("V9R020_SEQ");
        modelBuilder.HasSequence("V9S010_SEQ");
        modelBuilder.HasSequence("V9S020_SEQ");
        modelBuilder.HasSequence("V9T010_SEQ");
        modelBuilder.HasSequence("V9T020_SEQ");
        modelBuilder.HasSequence("V9U010_SEQ");
        modelBuilder.HasSequence("V9U020_SEQ");
        modelBuilder.HasSequence("XA1_SEQ");
        modelBuilder.HasSequence("XA2_SEQ");
        modelBuilder.HasSequence("XA3_SEQ");
        modelBuilder.HasSequence("XA4_SEQ");
        modelBuilder.HasSequence("XA5_SEQ");
        modelBuilder.HasSequence("XA6_SEQ");
        modelBuilder.HasSequence("XA7_SEQ");
        modelBuilder.HasSequence("XA8_SEQ");
        modelBuilder.HasSequence("XA9_SEQ");
        modelBuilder.HasSequence("XAA_SEQ");
        modelBuilder.HasSequence("XAB010_SEQ");
        modelBuilder.HasSequence("XAB020_SEQ");
        modelBuilder.HasSequence("XAC_SEQ");
        modelBuilder.HasSequence("XAL_SEQ");
        modelBuilder.HasSequence("XAL0_SEQ");
        modelBuilder.HasSequence("XAL010_SEQ");
        modelBuilder.HasSequence("XAL020_SEQ");
        modelBuilder.HasSequence("XAM_SEQ");
        modelBuilder.HasSequence("XAM0_SEQ");
        modelBuilder.HasSequence("XAM010_SEQ");
        modelBuilder.HasSequence("XAM020_SEQ");
        modelBuilder.HasSequence("XAN_SEQ");
        modelBuilder.HasSequence("XAN010_SEQ");
        modelBuilder.HasSequence("XAN020_SEQ");
        modelBuilder.HasSequence("XAO_SEQ");
        modelBuilder.HasSequence("XAO010_SEQ");
        modelBuilder.HasSequence("XAO020_SEQ");
        modelBuilder.HasSequence("XAP_SEQ");
        modelBuilder.HasSequence("XAP010_SEQ");
        modelBuilder.HasSequence("XAP020_SEQ");
        modelBuilder.HasSequence("XAS_SEQ");
        modelBuilder.HasSequence("XAS010_SEQ");
        modelBuilder.HasSequence("XAS020_SEQ");
        modelBuilder.HasSequence("XAT_SEQ");
        modelBuilder.HasSequence("XAU_SEQ");
        modelBuilder.HasSequence("XB2_SEQ");
        modelBuilder.HasSequence("XB3_SEQ");
        modelBuilder.HasSequence("XB4_SEQ");
        modelBuilder.HasSequence("XB5_SEQ");
        modelBuilder.HasSequence("XBA_SEQ");
        modelBuilder.HasSequence("XRZ010_SEQ");
        modelBuilder.HasSequence("XTT_SEQ");
        modelBuilder.HasSequence("XTU_SEQ");
        modelBuilder.HasSequence("XX6010_SEQ");
        modelBuilder.HasSequence("XX6020_SEQ");
        modelBuilder.HasSequence("XX7010_SEQ");
        modelBuilder.HasSequence("XX7020_SEQ");
        modelBuilder.HasSequence("XXA_SEQ");
        modelBuilder.HasSequence("XXC_SEQ");
        modelBuilder.HasSequence("XXH_SEQ");
        modelBuilder.HasSequence("XXP_SEQ");
        modelBuilder.HasSequence("XXT_SEQ");
        modelBuilder.HasSequence("XXX_SEQ");
        modelBuilder.HasSequence("XXZ_SEQ");
        modelBuilder.HasSequence("XZ1_SEQ");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
