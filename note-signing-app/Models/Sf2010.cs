using System;
using System.Collections.Generic;

namespace note_signing_app.Models;

public partial class Sf2010
{
    public string F2Doc { get; set; } = null!;

    public string F2Serie { get; set; } = null!;

    public string F2Cliente { get; set; } = null!;

    public string F2Loja { get; set; } = null!;

    public string F2Cond { get; set; } = null!;

    public string F2Dupl { get; set; } = null!;

    public string F2Emissao { get; set; } = null!;

    public string F2Est { get; set; } = null!;

    public decimal F2Frete { get; set; }

    public decimal F2Seguro { get; set; }

    public decimal F2Icmfret { get; set; }

    public string F2Tipocli { get; set; } = null!;

    public decimal F2Valbrut { get; set; }

    public decimal F2Valicm { get; set; }

    public decimal F2Baseicm { get; set; }

    public decimal F2Valipi { get; set; }

    public decimal F2Baseipi { get; set; }

    public decimal F2Valmerc { get; set; }

    public string F2Nfori { get; set; } = null!;

    public decimal F2Descont { get; set; }

    public string F2Seriori { get; set; } = null!;

    public string F2Tipo { get; set; } = null!;

    public string F2Especi1 { get; set; } = null!;

    public string F2Especi2 { get; set; } = null!;

    public string F2Especi3 { get; set; } = null!;

    public string F2Especi4 { get; set; } = null!;

    public decimal F2Volume1 { get; set; }

    public decimal F2Volume2 { get; set; }

    public decimal F2Volume3 { get; set; }

    public decimal F2Volume4 { get; set; }

    public decimal F2Icmsret { get; set; }

    public decimal F2Pliqui { get; set; }

    public decimal F2Pbruto { get; set; }

    public string F2Transp { get; set; } = null!;

    public string F2Redesp { get; set; } = null!;

    public string F2Vend1 { get; set; } = null!;

    public string F2Vend2 { get; set; } = null!;

    public string F2Vend3 { get; set; } = null!;

    public string F2Vend4 { get; set; } = null!;

    public string F2Vend5 { get; set; } = null!;

    public string F2Ok { get; set; } = null!;

    public string F2Fimp { get; set; } = null!;

    public string F2Dtlanc { get; set; } = null!;

    public string F2Dtreaj { get; set; } = null!;

    public string F2Reajust { get; set; } = null!;

    public string F2Dtbase0 { get; set; } = null!;

    public decimal F2Fatorb0 { get; set; }

    public string F2Dtbase1 { get; set; } = null!;

    public decimal F2Fatorb1 { get; set; }

    public decimal F2Variac { get; set; }

    public string F2Filial { get; set; } = null!;

    public decimal F2Baseiss { get; set; }

    public decimal F2Valiss { get; set; }

    public decimal F2Valfat { get; set; }

    public decimal F2Contsoc { get; set; }

    public decimal F2Bricms { get; set; }

    public decimal F2Fretaut { get; set; }

    public decimal F2Icmauto { get; set; }

    public decimal F2Despesa { get; set; }

    public string F2Nextdoc { get; set; } = null!;

    public string F2Nextser { get; set; } = null!;

    public string F2Especie { get; set; } = null!;

    public string F2Pdv { get; set; } = null!;

    public string F2Mapa { get; set; } = null!;

    public string F2Ecf { get; set; } = null!;

    public string F2Prefixo { get; set; } = null!;

    public decimal F2Basimp1 { get; set; }

    public decimal F2Basimp2 { get; set; }

    public decimal F2Basimp3 { get; set; }

    public decimal F2Basimp4 { get; set; }

    public decimal F2Basimp5 { get; set; }

    public decimal F2Basimp6 { get; set; }

    public decimal F2Valimp1 { get; set; }

    public decimal F2Valimp2 { get; set; }

    public decimal F2Valimp3 { get; set; }

    public decimal F2Valimp4 { get; set; }

    public decimal F2Valimp5 { get; set; }

    public decimal F2Valimp6 { get; set; }

    public string F2Ordpago { get; set; } = null!;

    public string F2Nfcupom { get; set; } = null!;

    public decimal F2Valinss { get; set; }

    public string F2Hora { get; set; } = null!;

    public decimal F2Moeda { get; set; }

    public string F2Regiao { get; set; } = null!;

    public decimal F2Valcsll { get; set; }

    public decimal F2Valcofi { get; set; }

    public decimal F2Valpis { get; set; }

    public string F2Lote { get; set; } = null!;

    public decimal F2Txmoeda { get; set; }

    public string F2Cleok { get; set; } = null!;

    public string F2Chvcle { get; set; } = null!;

    public string F2Idcle { get; set; } = null!;

    public decimal F2Valirrf { get; set; }

    public string F2Recfaut { get; set; } = null!;

    public string F2Carga { get; set; } = null!;

    public string F2Seqcar { get; set; } = null!;

    public decimal F2Baseins { get; set; }

    public string F2Pedpend { get; set; } = null!;

    public decimal F2Desccab { get; set; }

    public string F2Dtentr { get; set; } = null!;

    public string F2Formul { get; set; } = null!;

    public string F2Tipodoc { get; set; } = null!;

    public string F2Nfeacrs { get; set; } = null!;

    public string F2Tiporem { get; set; } = null!;

    public string F2Seqent { get; set; } = null!;

    public decimal F2Icmsdif { get; set; }

    public decimal F2Valacrs { get; set; }

    public string F2Reciss { get; set; } = null!;

    public decimal F2Valcf3 { get; set; }

    public string F2Ordsep { get; set; } = null!;

    public string F2Hornfe { get; set; } = null!;

    public string F2Chvnfe { get; set; } = null!;

    public string F2Flagdev { get; set; } = null!;

    public string F2Tpfrete { get; set; } = null!;

    public string F2Nfeletr { get; set; } = null!;

    public decimal F2Basecf3 { get; set; }

    public string F2Uctproj { get; set; } = null!;

    public string F2Veicul2 { get; set; } = null!;

    public string F2Nodia { get; set; } = null!;

    public decimal F2Baseps3 { get; set; }

    public string F2Eminfe { get; set; } = null!;

    public decimal F2Estcred { get; set; }

    public string F2Hawb { get; set; } = null!;

    public decimal F2Valps3 { get; set; }

    public decimal F2Baseirr { get; set; }

    public string F2Codnfe { get; set; } = null!;

    public decimal F2Baspis { get; set; }

    public decimal F2Crednfe { get; set; }

    public string F2Tiporet { get; set; } = null!;

    public string F2Diactb { get; set; } = null!;

    public string F2Veicul1 { get; set; } = null!;

    public string F2Recopi { get; set; } = null!;

    public string F2Fildest { get; set; } = null!;

    public decimal F2Valtst { get; set; }

    public decimal F2Vlsenar { get; set; }

    public decimal F2Bascsll { get; set; }

    public string F2Nfsubst { get; set; } = null!;

    public string F2Client { get; set; } = null!;

    public string F2Nficmst { get; set; } = null!;

    public string F2Sersubs { get; set; } = null!;

    public string F2Ntfecp { get; set; } = null!;

    public decimal F2Basetst { get; set; }

    public decimal F2Reftaxa { get; set; }

    public decimal F2VlrFrt { get; set; }

    public decimal F2Bascofi { get; set; }

    public decimal F2Basefun { get; set; }

    public decimal F2Refmoed { get; set; }

    public string F2Veicul3 { get; set; } = null!;

    public string F2Dtdigit { get; set; } = null!;

    public string F2Prefori { get; set; } = null!;

    public string F2Lojent { get; set; } = null!;

    public decimal F2Valfds { get; set; }

    public decimal F2Vreint { get; set; }

    public decimal F2Bsrein { get; set; }

    public decimal F2Valfab { get; set; }

    public decimal F2Valfac { get; set; }

    public decimal F2Valfet { get; set; }

    public decimal F2Valina { get; set; }

    public decimal F2Baseina { get; set; }

    public decimal F2Desczfr { get; set; }

    public string F2Evenflg { get; set; } = null!;

    public string F2Idcce { get; set; } = null!;

    public string F2Flagrgs { get; set; } = null!;

    public string F2Idrgs { get; set; } = null!;

    public string F2Codrgs { get; set; } = null!;

    public string F2Dautnfe { get; set; } = null!;

    public string F2Hautnfe { get; set; } = null!;

    public string F2Tpnfexp { get; set; } = null!;

    public string F2Userlgi { get; set; } = null!;

    public string F2Userlga { get; set; } = null!;

    public decimal F2Totimp { get; set; }

    public string F2Tipimp { get; set; } = null!;

    public string DELET { get; set; } = null!;

    public decimal RECNO { get; set; }

    public decimal RECDEL { get; set; }

    public string F2Idrecop { get; set; } = null!;

    public decimal F2Totfed { get; set; }

    public decimal F2Totest { get; set; }

    public decimal F2Totmun { get; set; }

    public string F2Mennota { get; set; } = null!;

    public decimal F2Vlcpm { get; set; }

    public decimal F2Basecpm { get; set; }

    public decimal F2Valfmp { get; set; }

    public decimal F2Basefmp { get; set; }

    public decimal F2Valfmd { get; set; }

    public string F2Formdes { get; set; } = null!;

    public string F2Numorc { get; set; } = null!;

    public string F2Idsa1 { get; set; } = null!;

    public string F2Idsa2 { get; set; } = null!;

    public string F2Idsed { get; set; } = null!;

    public string F2Lojades { get; set; } = null!;

    public string F2Fordes { get; set; } = null!;

    public string F2Dttxref { get; set; } = null!;

    public decimal F2Txref { get; set; }

    public string F2Gnrfecp { get; set; } = null!;

    public string F2Gnrdif { get; set; } = null!;

    public string F2Dteserv { get; set; } = null!;

    public decimal F2Valfund { get; set; }

    public decimal F2Valima { get; set; }

    public decimal F2Valfase { get; set; }

    public string F2Numexp { get; set; } = null!;

    public string F2Despach { get; set; } = null!;

    public string F2Dtexp { get; set; } = null!;

    public decimal F2Vldespc { get; set; }

    public string F2Codmoed { get; set; } = null!;

    public string F2Status { get; set; } = null!;

    public string F2Sersat { get; set; } = null!;

    public string F2Ltran { get; set; } = null!;

    public string F2Tpcompl { get; set; } = null!;

    public string F2Nummdf { get; set; } = null!;

    public string F2Cno { get; set; } = null!;

    public string F2Sdocsub { get; set; } = null!;

    public string F2Sdocman { get; set; } = null!;

    public string F2Sdocori { get; set; } = null!;

    public string F2Sdocmdf { get; set; } = null!;

    public string F2Sdocnxt { get; set; } = null!;

    public string F2Sdoc { get; set; } = null!;

    public string F2Sermdf { get; set; } = null!;

    public decimal F2Bsfccmp { get; set; }

    public decimal F2Basfecp { get; set; }

    public decimal F2Bsfcpst { get; set; }

    public string F2Cliret { get; set; } = null!;

    public string F2Lojaret { get; set; } = null!;

    public string F2Munpres { get; set; } = null!;

    public string F2Estpres { get; set; } = null!;

    public string F2Frtcfop { get; set; } = null!;

    public string F2Pafmd5 { get; set; } = null!;

    public string F2Cmunor { get; set; } = null!;

    public string F2Cmunde { get; set; } = null!;

    public string F2Idnf { get; set; } = null!;

    public string F2Ufdest { get; set; } = null!;

    public string F2Uforig { get; set; } = null!;

    public string F2Clirem { get; set; } = null!;

    public string F2Lojarem { get; set; } = null!;

    public string F2Coda1u { get; set; } = null!;

    public DateTime? STAMP { get; set; }

    public Guid? F2Msuidt { get; set; }

    public string F2Cgccli { get; set; } = null!;

    public string F2Govoper { get; set; } = null!;
}
