﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace WcfService1.Classes
{
    [Table(Name = "vDurumCount")]
    public class  vDurumCount : IDisposable
    {
        [Column(Name = "Id")]
        public int Id { get; set; }

        [Column(Name = "Adi")]
        public string Adi { get; set; } 

        [Column(Name = "DurumCount")]
        public int DurumCount { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vTalepMalzemeler")]
    public class vTalepMalzemeler : IDisposable
    {
        [Column(Name = "TalepId")]
        public int TalepId { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public double Miktar { get; set; }

        [Column]
        public int BirimId { get; set; }

        [Column]
        public string BirimAdi { get; set; }

        [Column]
        public string MalzemeKodu { get; set; }

        [Column]
        public string MalzemeAdi { get; set; }

        [Column]
        public int DurumId { get; set; }

        [Column]
        public int TalepEdenId { get; set; }

        [Column]
        public string TalepEdenKodu { get; set; }

        [Column]
        public string TalepEdenAdi { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public string Detay { get; set; }

        [Column]
        public int BolumId { get; set; }

        [Column]
        public string FabrikaBolumAdi { get; set; }

        public bool HepsiKarsilandiMi { get; set; }

        [Column]
        public double? KarsilananMiktar { get; set; }

        [Column]
        public int? KarsilananBirimId { get; set; }

        [Column]
        public string KarsilananBirim { get; set; }

        [Column]
        public string RenkAdi { get; set; }


        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vMalzemeOrtFiyatlar")]
    public class vMalzemeOrtFiyatlar : IDisposable
    {
        [Column]
        public int TedarikciId { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public string TedarikciAdi { get; set; }

        [Column]
        public double OrtFiyat { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vTalepKarsilama")]
    public class vTalepKarsilama : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string No { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public int TedarikciId { get; set; }

        [Column]
        public string TedarikciKodu { get; set; }

        [Column]
        public string TedarikciAdi { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public string PersonelKodu { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        [Column]
        public int DurumId { get; set; }

        [Column]
        public string OdemeSekli { get; set; }

        [Column]
        public DateTime? TerminTarihi { get; set; }

        public static tblTalepKarsilama ViewToTable(vTalepKarsilama view)
        {
            return new tblTalepKarsilama()
            {
                DurumId = view.DurumId,
                FirmaId = view.TedarikciId,
                Id = view.Id,
                No = view.No,
                PersonelId = view.PersonelId,
                Tarih = view.Tarih,
                OdemeSekli = view.OdemeSekli,
                TerminTarihi = view.TerminTarihi

            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vTalepKarsilamaAct")]
    public class vTalepKarsilamaAct : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int TalepKarsilamaId { get; set; }

        [Column]
        public int TalepId { get; set; }

        [Column]
        public int DurumId { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public double Miktar { get; set; }

        [Column]
        public int BirimId { get; set; }

        [Column]
        public string BirimAdi { get; set; }

        [Column]
        public double Fiyat { get; set; }

        [Column]
        public int TedarikciId { get; set; }

        [Column]
        public string MalzemeKodu { get; set; }
        
        [Column]
        public string MalzemeAdi { get; set; }

        [Column]
        public string TedarikciKodu { get; set; }

        [Column]
        public string TedarikciAdi { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public int DovizId { get; set; }

        [Column]
        public string Doviz { get; set; }

        [Column]
        public double Kur { get; set; }

        public double FiyatTL
        {
            get { return Fiyat * Kur; }
        }

        [Column]
        public int BolumId { get; set; }

        [Column]
        public string BolumAdi { get; set; }

        [Column]
        public string Detay { get; set; }

        [Column]
        public int MalzemeBagId { get; set; }

        [Column]
        public string RenkKodu { get; set; }

        [Column]
        public string RenkAdi { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vMalzemeBirimleri")]
    public class vMalzemeBirimleri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public string MalzemeAdi { get; set; }

        [Column]
        public string BirimAdi { get; set; }

        [Column]
        public double BirimCarpan { get; set; }

        [Column]
        public double AnaCarpan { get; set; }

        [Column]
        public bool AnaBirimMi { get; set; }

        [Column]
        public int BirimAyarId { get; set; }

        public vMalzemeBirimleri GetMalzemeAnaBirim(int malId)
        {
            return new DBEvents().GetGeneric<vMalzemeBirimleri>(c => c.AnaBirimMi == true && c.MalzemeId == malId).First();
        }

        public List<vMalzemeBirimleri> GetMalzemeBirimleri(int malId)
        {
            return new DBEvents().GetGeneric<vMalzemeBirimleri>(c => c.MalzemeId == malId).ToList();
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vModulDurumlari")]
    public class vModulDurumlari : IDisposable
    {
        [Column]
        public int AyarUstId { get; set; }

        [Column]
        public string AyarUstAdi { get; set; }

        [Column]
        public int DurumId { get; set; }

        [Column]
        public string DurumAdi { get; set; }

        [Column]
        public int Sira { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class vMalzemeler : tblMalzemeler
    {
        private DBEvents db = new DBEvents();
        public double MevcutStok { get; set; }
        public string GelecekStok { get; set; }

        public List<tblMalzemeler> GruptakiMalzemeleriGetir(int GrupID, bool birimlerGelsinMi = false)
        {
            List<tblMalzemeler> list = db.GetGeneric<tblMalzemeler>(c => c.BaglantiId == GrupID && c.AktifMi == true);

            return list;
        }

        public List<vMalzemeler> ArananMalzemeGetir(string Filtre, int GrupId)
        {
            List<tblMalzemeler> list = db.GetGeneric<tblMalzemeler>(c => c.Adi.Contains(Filtre) && c.BaglantiId == GrupId);

            List<vMalzemeler> vList = list.ConvertAll(new Converter<tblMalzemeler, vMalzemeler>(vMalzemeler.tblMalzemelerTovMalzemeler));

            return vList;
        }

        public List<vMalzemeler> ArananMalzemeGetir(int malzemeId)
        {
            List<tblMalzemeler> list = db.GetGeneric<tblMalzemeler>(c => c.Id == malzemeId);

            List<vMalzemeler> vList = list.ConvertAll(new Converter<tblMalzemeler, vMalzemeler>(vMalzemeler.tblMalzemelerTovMalzemeler));

            return vList;
        }

        public List<tblMalzemeler> ArananMalzemeleriGetir(string Filtre, int GrupId)
        {
            List<tblMalzemeler> list = db.GetGeneric<tblMalzemeler>(c => c.Adi.Contains(Filtre) && c.BaglantiId == GrupId);

            return list;
        }

        public List<tblMalzemeler> MalzemeGruplariGetir()
        {
            return db.GetGeneric<tblMalzemeler>(c => c.BaglantiId == -1);
        }

        public static vMalzemeler tblMalzemelerTovMalzemeler(tblMalzemeler malzeme)
        {
            return new vMalzemeler()
            {
                Adi = malzeme.Adi,
                BaglantiId = malzeme.BaglantiId,
                Birimleri = new DBEvents().GetGeneric<vMalzemeBirimleri>(c => c.MalzemeId == malzeme.Id),
                Id = malzeme.Id,
                Kodu = malzeme.Kodu,
                MevcutStok = new Stok().StokMiktariGetir(malzeme.Id),
                GelecekStok = new Stok().StokGelecekMiktariGetir(malzeme.Id)
            };
                
        }

        public static vMalzemeler tblMalzemelerTovMalzemeler(tblMalzemeler malzeme, bool stokHesaplamaz)
        {
            return new vMalzemeler()
            {
                Adi = malzeme.Adi,
                BaglantiId = malzeme.BaglantiId,
                Birimleri = new DBEvents().GetGeneric<vMalzemeBirimleri>(c => c.MalzemeId == malzeme.Id),
                Id = malzeme.Id,
                Kodu = malzeme.Kodu
            };

        }

        public static List<vMalzemeler> tblMalzemelerTovMalzemeler(List<tblMalzemeler> malzemeler, bool stokMiktarlariHesaplansin = false)
        {
            List<vMalzemeler> newList = new List<vMalzemeler>();
            foreach (tblMalzemeler item in malzemeler)
            {
                if (stokMiktarlariHesaplansin) newList.Add(vMalzemeler.tblMalzemelerTovMalzemeler(item));
                else newList.Add(vMalzemeler.tblMalzemelerTovMalzemeler(item, true));
            }

            return newList;
        }

        public List<tblMalzemeler> IplikleriGetir()
        {
            return GruptakiMalzemeleriGetir(39);
        }

        public tblMalzemeler IplikGetir(int iplikId)
        {
            return db.GetGeneric<tblMalzemeler>(c => c.Id == iplikId).FirstOrDefault();
        }

        /// <summary>
        /// Verilen list'deki malzemeleri kaydeder. Listenin içinde id'si 0 olan kayıtlar insert edilirken id'si 0'dan farklı olan kayıtlar update edilir.
        /// Dönüş true ise kaydetme başarılıdır. false ise kaydetme başarısızdır.
        /// </summary>
        /// <param name="malzemeler"></param>
        /// <returns></returns>
        public bool MalzemeKaydet(List<tblMalzemeler> malzemeler)
        {
            bool snc = true;
            List<tblMalzemeler> toSaveList = malzemeler.FindAll(c => c.Id == 0);
            List<tblMalzemeler> toUpdList = malzemeler.FindAll(c => c.Id != 0);

            if (toSaveList.Count > 0) if (db.SaveGeneric<tblMalzemeler>(toSaveList) == false) snc = false;
            if (toUpdList.Count > 0) if (db.UpdateGeneric<tblMalzemeler>(toUpdList) == false) snc = false;

            return snc;
        }

        public List<vMalzemeBirimleri> Birimleri { get; set; }
    }

    [Table(Name = "vAyarlar")]
    public class vAyarlar : tblAyarlar
    {
        DBEvents db = new DBEvents();

        public vAyarlar AyarGetir(int id)
        {
            return db.GetGeneric<tblAyarlar>(c => c.Id == id).ConvertAll<vAyarlar>(new Converter<tblAyarlar, vAyarlar>(tblAyarlarToVAyarlar)).FirstOrDefault();
        }

        public List<vAyarlar> DovizleriGetir()
        {
            tblAyarlar dovizTanim = db.GetGeneric<tblAyarlar>(c=>c.Adi == "Doviz").FirstOrDefault();
            return dovizTanim != null ? db.GetGeneric<tblAyarlar>(c=>c.BaglantiId == dovizTanim.Id).ConvertAll<vAyarlar>(new Converter<tblAyarlar,vAyarlar>(tblAyarlarToVAyarlar))
                                      : new List<vAyarlar>();
        }

        public static vAyarlar tblAyarlarToVAyarlar(tblAyarlar ayar)
        {
            return new vAyarlar()
            {
                Aciklama = ayar.Aciklama,
                Adi = ayar.Adi,
                BaglantiId = ayar.BaglantiId,
                BosGecilebilirMi = ayar.BosGecilebilirMi,
                Deger = ayar.Deger,
                GosterilsinMi = ayar.GosterilsinMi,
                Id = ayar.Id, 
                KontrolMu = ayar.KontrolMu,
                Sira = ayar.Sira
            };
        }
    }

    [Table(Name = "tblPersonelBolumleri")]
    public class vPersonelBolumleri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string Kodu { get; set; }

        [Column]
        public string Adi { get; set; }

        public List<vPersonelBolumleri> PersonelBolumleriGetir()
        {
            List<vPersonelBolumleri> list = new DBEvents().GetGeneric<vPersonelBolumleri>().ToList();
            return list == null ? new List<vPersonelBolumleri>() : list;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vMalzemeStokDurum")]
    public class vMalzemeStokDurum : IDisposable
    {
        [Column(Name = "MalzemeId", IsDbGenerated = true, IsPrimaryKey = true)]
        public int MalzemeId { get; set; }

        [Column]
        public int MalzemeBagId { get; set; }        

        [Column]
        public string MalzemeKodu { get; set; }

        [Column]
        public string MalzemeAdi { get; set; }

        [Column]
        public double MinStok { get; set; }

        [Column]
        public double MevcutStok { get; set; }

        public double GelecekStok { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vKullanicilar")]
    public class vKullanicilar : IDisposable
    {
        [Column]
        public int Id { get; set; }
        
        [Column]
        public string KulAdi { get; set; }

        [Column]
        public string Sifre { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        [Column]
        public int? BolumId { get; set; }

        [Column]
        public bool AktifMi { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vBakimOnarim")]
    public class vBakimOnarim : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int MakinaId { get; set; }

        [Column]
        public string MakinaAdi { get; set; }

        [Column]
        public DateTime BasTarih { get; set; }

        [Column]
        public DateTime BitisTarih { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public string Vardiya { get; set; }

        [Column]
        public double HarcananSure { get; set; }

        [Column]
        public string Turu { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public DateTime OlusturmaTarihi { get; set; }

        internal static tblBakimOnarim ViewToTable(vBakimOnarim view)
        {
            return new tblBakimOnarim()
            {
                Aciklama = view.Aciklama,
                BasTarih = view.BasTarih,
                BitisTarih = view.BitisTarih,
                HarcananSure = view.HarcananSure,
                Id = view.Id,
                MakinaId = view.MakinaId,
                OlusturmaTarihi = view.OlusturmaTarihi == null ? DateTime.Now : view.OlusturmaTarihi,
                PersonelId = view.PersonelId,
                Turu = view.Turu,
                Vardiya = view.Vardiya
            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vBakimOnarimAct")]
    public class vBakimOnarimAct : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int BakimOnarimId { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public string MalzemeAdi { get; set; }

        [Column]
        public string MalzemeKodu { get; set; }
        
        [Column]
        public double Miktar { get; set; }

        [Column]
        public int BirimId { get; set; }

        [Column]
        public string BirimAdi { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public DateTime OlusturmaTarihi { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        internal static tblBakimOnarimAct ViewToTable(vBakimOnarimAct view)
        {
            return new tblBakimOnarimAct()
            {
                BakimOnarimId = view.BakimOnarimId,
                BirimId = view.BirimId,
                Id = view.Id,
                MalzemeId = view.MalzemeId,
                Miktar = view.Miktar,
                OlusturmaTarihi = view.OlusturmaTarihi,
                PersonelId = view.PersonelId    
            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vMakinaBakimTarihleri")]
    public class vMakinaBakimTarihleri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string Adi { get; set; }

        [Column]
        public int BakimPeriyodu { get; set; }

        [Column]
        public DateTime? SonrakiBakimTarihi { get; set; }

        [Column]
        public int KalanGun { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vSayacGirisleriDgaz")]
    public class vSayacGirisleriDgaz : IDisposable
    {
        [Column(Name = "SayacGirisId", IsDbGenerated = true, IsPrimaryKey = true)]
        public int SayacGirisId { get; set; }

        [Column]
        public int SarfiyatId { get; set; }

        [Column]
        public int BolumId { get; set; }

        [Column]
        public string BolumAdi { get; set; }

        [Column]
        public int SayacId { get; set; }

        [Column]
        public string SayacAdi { get; set; }

        [Column]
        public double m3 { get; set; }

        [Column]
        public double sm3 { get; set; }

        [Column]
        public double kwh { get; set; }        

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public double BirimFiyat { get; set; }

        [Column]
        public double Maliyet { get; set; }

        [Column]
        public int? PersonelId { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vSayacGirisleriSu")]
    public class vSayacGirisleriSu : IDisposable
    {
        [Column(Name = "SayacGirisId", IsDbGenerated = true, IsPrimaryKey = true)]
        public int SayacGirisId { get; set; }

        [Column]
        public int SarfiyatId { get; set; }

        [Column]
        public int BolumId { get; set; }

        [Column]
        public string BolumAdi { get; set; }

        [Column]
        public int SayacId { get; set; }

        [Column]
        public string SayacAdi { get; set; }

        [Column]
        public double ton { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public double BirimFiyat { get; set; }

        [Column]
        public double Maliyet { get; set; }

        [Column]
        public int? PersonelId { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vSayacGirisleriElk")]
    public class vSayacGirisleriElk : IDisposable
    {
        [Column(Name = "SayacGirisId", IsDbGenerated = true, IsPrimaryKey = true)]
        public int SayacGirisId { get; set; }

        [Column]
        public int SarfiyatId { get; set; }

        [Column]
        public int BolumId { get; set; }

        [Column]
        public string BolumAdi { get; set; }

        [Column]
        public int SayacId { get; set; }

        [Column]
        public string SayacAdi { get; set; }

        [Column]
        public double kwh { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public double BirimFiyat { get; set; }

        [Column]
        public double Maliyet { get; set; }

        [Column]
        public int? PersonelId { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class vSayacGiris
    {
        public int BolumId { get; set; }
        public double kwh { get; set; }
        public double ton { get; set; }
        public double m3 { get; set; }
        public double sm3 { get; set; }
        public string BolumAdi { get; set; }
        public DateTime Tarih { get; set; }
        public double BirimFiyat { get; set; }
        public double Maliyet { get; set; }
        public int PersonelId { get; set; }
    }

    [Table(Name = "vFiyatListeleri")]
    public class vFiyatListeleri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int? MusteriId { get; set; }

        [Column]
        public int? ProcessId { get; set; }

        [Column]
        public string MusteriKodu { get; set; }

        [Column]
        public string MusteriAdi { get; set; }

        [Column]
        public string Tip { get; set; }

        [Column]
        public int DovizId { get; set; }

        [Column]
        public double Fiyat { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public string Grup { get; set; }

        [Column]
        public double? En { get; set; }

        [Column]
        public double? Gr { get; set; }

        [Column]
        public string Kompozisyon { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public int Ay { get; set; }

        [Column]
        public int Yil { get; set; }

        [Column]
        public bool AktifMi { get; set; }

        [Column]
        public int OlusturanPersonelId { get; set; }

        public List<vAyarlar> Dovizler { get; set; }
        public List<tblProses> Prosesler { get; set; }

        public static tblFiyatListeleri ViewToTable(vFiyatListeleri fiyat)
        {
            return new tblFiyatListeleri()
                {
                    Aciklama = fiyat.Aciklama,
                    AktifMi = fiyat.AktifMi,
                    Ay = fiyat.Ay,
                    DovizId = fiyat.DovizId,
                    En = fiyat.En,
                    Fiyat = fiyat.Fiyat,
                    Gr = fiyat.Gr,
                    Grup = fiyat.Grup,
                    Id = fiyat.Id,
                    Kompozisyon = fiyat.Kompozisyon,
                    MusteriId = fiyat.MusteriId,
                    OlusturanPersonelId = fiyat.OlusturanPersonelId,
                    ProcessId = fiyat.ProcessId,
                    Tarih = fiyat.Tarih,
                    Tip = fiyat.Tip,
                    Yil = fiyat.Yil
                };
        }

        public static List<tblFiyatListeleri> ViewToTable(List<vFiyatListeleri> fiyatListesi)
        {
            List<tblFiyatListeleri> tblList = new List<tblFiyatListeleri>();

            foreach (vFiyatListeleri viewItem in fiyatListesi)
            {
                tblList.Add(ViewToTable(viewItem));
            }

            return tblList;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vKur")]
    public class vKur : IDisposable
    {
        [Column(Name = "Id")]
        public int Id { get; set; }
        
        [Column]
        public int BaglantiId { get; set; }

        [Column]
        public string DovizAdi { get; set; }

        [Column]
        public string DovizSimge { get; set; }

        [Column]
        public Int16 LogoDovizId { get; set; }

        [Column]
        public int LogoKurId { get; set; }

        [Column]
        public double LogoDovizAlis { get; set; }
        
        [Column]
        public double LogoDovizSatis { get; set; }

        [Column]
        public double LogoEfektifAlis { get; set; }

        [Column]
        public double LogoEfektifSatis { get; set; }

        [Column]
        public DateTime LogoTarih { get; set; }

        public vKur DovizKuruGetir(int dovizId)
        {
            return new DBEvents().GetGeneric<vKur>(c => c.Id == dovizId).FirstOrDefault();
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vSiparisler")]
    public class vSiparisler : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int BaglantiId { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public int FirmaId { get; set; }

        [Column]
        public string FirmaAdi { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public string SipTipi { get; set; }

        [Column]
        public string Durum { get; set; }

        [Column]
        public string KarsiReferansNo { get; set; }     

        [Column]
        public string SipVeren { get; set; }

        [Column]
        public string SevkYeri { get; set; }

        [Column]
        public DateTime TerminTarihi { get; set; }

        [Column]
        public string BelgeTuru { get; set; }

        [Column]
        public int OlusturanPersId { get; set; }

        [Column]
        public string OlusturanPersAdi { get; set; }

        [Column]
        public string SipOnaylayan { get; set; }

        [Column]
        public int GuncelleyenPersId { get; set; }

        [Column]
        public string GuncelleyenPersAdi { get; set; }

        [Column]
        public double TopMiktar { get; set; }

        public double SevkMiktari { get; set; }

        public double IadeMiktari { get; set; }

        public double KalanMiktar { get; set; }

        public static tblSiparisler ViewToTable(vSiparisler view)
        {
            return new tblSiparisler()
                {
                    BaglantiId = view.BaglantiId,
                    BelgeTuru = view.BelgeTuru,
                    Durum = view.Durum,
                    FirmaId = view.FirmaId,
                    GuncelleyenPersId = view.GuncelleyenPersId,
                    Id = view.Id,
                    KarsiReferansNo = view.KarsiReferansNo,
                    OlusturanPersId = view.OlusturanPersId,
                    SipOnaylayan = view.SipOnaylayan,
                    SevkYeri = view.SevkYeri,
                    SipVeren = view.SipVeren,
                    SozlesmeNo = view.SozlesmeNo,
                    Tarih = view.Tarih,
                    TerminTarihi = view.TerminTarihi
                };
        }

        public static List<tblSiparisler> ViewToTable(List<vSiparisler> view)
        {
            List<tblSiparisler> tbl = new List<tblSiparisler>();
            foreach (vSiparisler viewItem in view)
            {
                tbl.Add(ViewToTable(viewItem));    
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vSiparisAct")]
    public class vSiparisAct : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int SiparisId { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public int? TipMalzemeId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string TipAdi { get; set; }

        [Column]
        public int RenkId { get; set; }

        [Column]
        public string RenkNo { get; set; }

        [Column]
        public double Miktar { get; set; }

        [Column]
        public double BirimFiyat { get; set; }

        [Column]
        public int DovizId { get; set; }

        [Column]
        public string Doviz { get; set; }

        [Column]
        public double TopMetre { get; set; }

        [Column]
        public string ParcaliTop { get; set; }

        [Column]
        public string LabRenkNo { get; set; }

        [Column]
        public DateTime TerminTarihi { get; set; }

        [Column]
        public string FinishOzellikleri { get; set; }

        [Column]
        public string SevkDurumu { get; set; }

        [Column]
        public double SevkMiktar { get; set; }

        [Column]
        public string BoyaNotu { get; set; }

        [Column]
        public string DokumaNotu { get; set; }

        [Column]
        public string SevkiyatNotu { get; set; }

        [Column]
        public string PlanlamaNotu { get; set; }

        [Column]
        public string IcTicaretNotu { get; set; }

        [Column]
        public string DisTicaretNotu { get; set; }

        [Column]
        public string MuhasebeNotu { get; set; }

        [Column]
        public string NumuneNotu { get; set; }

        [Column]
        public string TerminNotu { get; set; }

        [Column]
        public bool NorApre { get; set; }

        [Column]
        public bool SuYagApre { get; set; }

        [Column]
        public bool SirtApre { get; set; }

        [Column]
        public bool NorYanmazApre { get; set; }

        [Column]
        public bool YumApre { get; set; }

        [Column]
        public bool AntiStatik { get; set; }

        [Column]
        public bool Apresiz { get; set; }

        [Column]
        public int Sira { get; set; }

        [Column]
        public string Durum { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public int? FinishGrupId { get; set; }

        [Column]
        public string FinishAdi { get; set; }

        [Column]
        public int? TestId { get; set; }

        [Column]
        public double CozguMetre { get; set; }

        [Column]
        public double PlanMetre { get; set; }

        public double RezerveMetre { get; set; }

        [Column]
        public int FirmaId { get; set; }

        [Column]
        public string FirmaKodu { get; set; }

        [Column]
        public string FirmaAdi { get; set; }

        [Column]
        public int? PartiId { get; set; }

        [Column]
        public double PartilenenMetre { get; set; }

        public List<vAyarlar> ListDoviz { get; set; }
        public List<tblMalzemeler> ListMamuller { get; set; }

        public tblSiparisTestleri Testler { get; set; }

        public static tblSiparisAct ViewToTable(vSiparisAct view)
        {
            return new tblSiparisAct() { 
                AntiStatik = view.AntiStatik,
                Apresiz = view.Apresiz,
                BirimFiyat = view.BirimFiyat,
                BoyaNotu = view.BoyaNotu,
                DisTicaretNotu = view.DisTicaretNotu,
                DokumaNotu = view.DokumaNotu,
                DovizId = view.DovizId,
                FinishOzellikleri = view.FinishOzellikleri,
                IcTicaretNotu = view.IcTicaretNotu,
                Id = view.Id,
                LabRenkNo = view.LabRenkNo,
                Miktar = view.Miktar,
                MuhasebeNotu = view.MuhasebeNotu,
                NorApre = view.NorApre,
                NorYanmazApre = view.NorYanmazApre,
                NumuneNotu = view.NumuneNotu,
                ParcaliTop = view.ParcaliTop,
                PlanlamaNotu = view.PlanlamaNotu,
                SevkDurumu = view.SevkDurumu,
                SevkiyatNotu = view.SevkiyatNotu,
                SevkMiktar = view.SevkMiktar,
                SiparisId = view.SiparisId,
                SirtApre = view.SirtApre,
                SuYagApre = view.SuYagApre,
                TerminNotu = view.TerminNotu,
                TerminTarihi = view.TerminTarihi,
                TopMetre = view.TopMetre,
                TipId = view.TipId,
                YumApre = view.YumApre,
                Sira = view.Sira,
                FinishGrupId = view.FinishGrupId,
                TestId = view.TestId,
                RenkId = view.RenkId,
                TipMalzemeId = view.TipMalzemeId
            };
        }

        public static List<tblSiparisAct> ViewToTable(List<vSiparisAct> view)
        {
            List<tblSiparisAct> tbl = new List<tblSiparisAct>();

            foreach (vSiparisAct item in view)
            {
                tbl.Add(ViewToTable(item));
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "tblKumas")]
    public class vKumas : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string TipAdi { get; set; }

        [Column]
        public double? KumasEn { get; set; }

        [Column]
        public double? KumasAgirlik { get; set; }

        [Column]
        public double? KumasAgirlik2 { get; set; }

        [Column]
        public string HavKomp { get; set; }

        [Column]
        public string TotalKomp { get; set; }

        [Column]
        public string KulAlani { get; set; }

        [Column]
        public string Martindale { get; set; }

        [Column]
        public bool? Yik1 { get; set; }

        [Column]
        public bool? Yik2 { get; set; }

        [Column]
        public bool? Yik3 { get; set; }

        [Column]
        public bool? Yik4 { get; set; }

        [Column]
        public bool? Yik5 { get; set; }

        [Column]
        public string YikamaTalNot { get; set; }

        [Column]
        public string MukavemetAtki { get; set; }

        [Column]
        public string MukavemetCözgü { get; set; }

        [Column]
        public string DikisSiyrikAtki { get; set; }

        [Column]
        public string DikSiyrikCozgu { get; set; }

        [Column]
        public double? Fiyat { get; set; }

        [Column]
        public int? DovizId { get; set; }

        [Column]
        public int? EntId { get; set; }

        [Column]
        public string RenkHaslikAcik { get; set; }

        [Column]
        public string RenkHaslikOrta { get; set; }

        [Column]
        public string RenkHaslikKoyu { get; set; }

        [Column]
        public string SurtmeHaslikYasAcik { get; set; }

        [Column]
        public string SurtmeHaslikYasOrta { get; set; }

        [Column]
        public string SurtmeHaslikYasKoyu { get; set; }

        [Column]
        public string SurtmeHaslikKuruAcik { get; set; }

        [Column]
        public string SurtmeHaslikKuruOrta { get; set; }

        [Column]
        public string SurtmeHaslikKuruKoyu { get; set; }

        [Column]
        public bool? Dosemelik { get; set; }

        [Column]
        public bool? Perdelik { get; set; }

        [Column]
        public bool? Elbiselik { get; set; }

        [Column]
        public bool? Likrali { get; set; }

        [Column]
        public double? HavSevki { get; set; }

        [Column]
        public double? ZeminSevki { get; set; }

        [Column]
        public double? ZeminCozguTel { get; set; }

        [Column]
        public double? KenarCozguTel { get; set; }
        
        [Column]
        public double? HavCozguTel { get; set; }
        
        [Column]
        public int? Atki1 { get; set; }        

        [Column]
        public int? Atki2 { get; set; }

        [Column]
        public int? Atki3 { get; set; }

        [Column]
        public int? Atki4 { get; set; }

        [Column]
        public double? Atki1UstuGr { get; set; }

        [Column]
        public double? Atki2UstuGr { get; set; }

        [Column]
        public double? Atki3UstuGr { get; set; }

        [Column]
        public double? Atki4UstuGr { get; set; }

        [Column]
        public int? Zemin1 { get; set; }

        [Column]
        public int? Zemin2 { get; set; }

        [Column]
        public int? Zemin3 { get; set; }

        [Column]
        public int? Zemin4 { get; set; }

        [Column]
        public double? Zemin1UstuGr { get; set; }

        [Column]
        public double? Zemin2UstuGr { get; set; }

        [Column]
        public double? Zemin3UstuGr { get; set; }

        [Column]
        public double? Zemin4UstuGr { get; set; }

        [Column]
        public int? Hav1 { get; set; }

        [Column]
        public int? Hav2 { get; set; }

        [Column]
        public int? Hav3 { get; set; }

        [Column]
        public int? Hav4 { get; set; }

        [Column]
        public double? Hav1UstuGr { get; set; }

        [Column]
        public double? Hav2UstuGr { get; set; }

        [Column]
        public double? Hav3UstuGr { get; set; }

        [Column]
        public double? Hav4UstuGr { get; set; }

        public List<vAyarlar> Dovizler { get; set; }

        public static tblKumas ViewToTable(vKumas view)
        {
            return new tblKumas()
            {
                DikisSiyrikAtki = view.DikisSiyrikAtki,
                DikSiyrikCozgu = view.DikSiyrikCozgu,
                DovizId = view.DovizId,
                EntId = view.EntId,
                Fiyat = view.Fiyat,
                HavKomp = view.HavKomp,
                Id = view.Id,
                KulAlani = view.KulAlani,
                KumasAgirlik = view.KumasAgirlik,
                KumasAgirlik2 = view.KumasAgirlik2,
                KumasEn = view.KumasEn,
                Martindale = view.Martindale,
                MukavemetAtki = view.MukavemetAtki,
                MukavemetCözgü = view.MukavemetCözgü,
                RenkHaslikAcik = view.RenkHaslikAcik,
                RenkHaslikKoyu = view.RenkHaslikKoyu,
                RenkHaslikOrta = view.RenkHaslikOrta,
                SurtmeHaslikKuruAcik = view.SurtmeHaslikKuruAcik,
                SurtmeHaslikKuruKoyu = view.SurtmeHaslikKuruKoyu,
                SurtmeHaslikKuruOrta = view.SurtmeHaslikKuruOrta,
                SurtmeHaslikYasAcik = view.SurtmeHaslikYasAcik,
                SurtmeHaslikYasKoyu = view.SurtmeHaslikYasKoyu,
                SurtmeHaslikYasOrta = view.SurtmeHaslikYasOrta,
                TipAdi = view.TipAdi,
                TipNo = view.TipNo,
                TotalKomp = view.TotalKomp,
                Yik1 = view.Yik1,
                Yik2 = view.Yik2,
                Yik3 = view.Yik3,
                Yik4 = view.Yik4,
                Yik5 = view.Yik5,
                YikamaTalNot = view.YikamaTalNot,
                Dosemelik = view.Dosemelik,
                Perdelik = view.Perdelik,
                Elbiselik = view.Elbiselik,
                Likrali = view.Likrali
                
            };
        }

        public static List<tblKumas> ViewToTable(List<vKumas> view)
        {
            List<tblKumas> tbl = new List<tblKumas>();

            foreach (vKumas item in view) tbl.Add(ViewToTable(item));

            return tbl;
        }

        public static vKumas TipGetir(int id)
        {
            return new DBEvents().GetGeneric<vKumas>(c => c.Id == id).FirstOrDefault();
        }

        public static List<vKumas> KumaslariGetir()
        {
            return new DBEvents().GetGeneric<vKumas>();
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vYetkiTanim")]
    public class vYetkiTanim : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int MenuId { get; set; }

        [Column]
        public int MenuBagId { get; set; }

        [Column]
        public string Adi { get; set; }

        [Column]
        public string Aciklama { get; set; }

        public List<vYetkiTanim> AltYetkiler { get; set; }
        private bool? _YetkiliMi = true;
        public bool? YetkiliMi
        {
            get
            {
                return _YetkiliMi;
            }
            set
            {
                _YetkiliMi = value;
            }
        }

        //private static List<vYetkiTanim> YetkiTanimlariGetir()
        //{
        //    List<vYetkiTanim> yetkiler = new DBEvents().GetGeneric<vYetkiTanim>();
        //    List<vYetkiTanim> ToReturnList = new List<vYetkiTanim>();

        //    foreach (vYetkiTanim item in yetkiler.FindAll(c=>c.MenuBagId == 1))
        //    {
        //        item.AltYetkiler = yetkiler.FindAll(c=>c.MenuBagId == item.MenuId);
        //        ToReturnList.Add(item);
        //    }
        //    return ToReturnList;
        //}

        //public static List<vYetkiTanim> YetkileriGetir(int bolumId = 0, int kullaniciId = 0)
        //{
        //    if (bolumId == 0 && kullaniciId == 0) return null;

        //    var query = PredicateBuilder.True<tblYetkiler>();
        //    query = query.And(c => c.BolumId == bolumId);
        //    if (kullaniciId != 0) query = query.Or(c => c.KullaniciId == kullaniciId);

        //    List<tblYetkiler> kullaniciYetki = new DBEvents().GetGeneric<tblYetkiler>(query);
        //    //mevcut tüm yetkiler getiriliyor
        //    List<vYetkiTanim> yetkiler = YetkiTanimlariGetir();
            
        //    //bölümlerin ya da kullanıcıların yetkileri atanıyor
        //    for (int i = 0; i < yetkiler.Count; i++)
        //    {
        //        if (yetkiler[i].AltYetkiler.Count == 0)
        //        {
        //            //kullanıcıya özgü yetki varsa yetki kullanıcının yetkisinden alınır.
        //            tblYetkiler yetki = kullaniciYetki.Find(c => c.YetkiId == yetkiler[i].Id && c.KullaniciId == kullaniciId);
        //            //kullanıcıya özgü yetki yoksa, yetki kulanıcının bölümünün yetkisinden alınır.
        //            if (yetki == null)
        //            {
        //                yetki = kullaniciYetki.Find(c => c.YetkiId == yetkiler[i].Id && c.BolumId == bolumId);
        //            }
        //            yetkiler[i].YetkiliMi = yetki == null ? true : yetki.YetkiVarMi;
        //        }

        //        else
        //        {
        //            for (int j = 0; j < yetkiler[i].AltYetkiler.Count; j++)
        //            {
        //                tblYetkiler yetkiAlt = kullaniciYetki.Find(c => c.YetkiId == yetkiler[i].AltYetkiler[j].Id && c.KullaniciId == kullaniciId);
        //                if (yetkiAlt == null) yetkiAlt = kullaniciYetki.Find(c => c.YetkiId == yetkiler[i].AltYetkiler[j].Id && c.BolumId == bolumId);
        //                yetkiler[i].AltYetkiler[j].YetkiliMi = yetkiAlt == null ? true : yetkiAlt.YetkiVarMi;
        //            }

        //            if (yetkiler[i].AltYetkiler.Count == yetkiler[i].AltYetkiler.Count(c => c.YetkiliMi == true)) yetkiler[i].YetkiliMi = true;
        //            else yetkiler[i].YetkiliMi = null;
        //        }
        //    }

        //    return yetkiler;
        //}

        //private static bool YetkiKaydet(List<tblYetkiler> yetkiler)
        //{
        //    List<tblYetkiler> toSaveList = yetkiler.FindAll(c => c.Id == 0);
        //    List<tblYetkiler> toUpdList = yetkiler.FindAll(c => c.Id != 0);

        //    bool sonuc = true;
        //    if (toSaveList.Count > 0) if (new DBEvents().SaveGeneric<tblYetkiler>(toSaveList) == false) sonuc = false;
        //    if (toUpdList.Count > 0) if (new DBEvents().UpdateGeneric<tblYetkiler>(toUpdList) == false) sonuc = false;

        //    return sonuc;
        //}

        //public static bool YetkiKaydet(List<vYetkiTanim> yetkiler, int bolumId = 0, int kullaniciId = 0)
        //{
        //    List<tblYetkiler> yetkiTbl = new List<tblYetkiler>();

        //    //Bölüm için yetki tanımlama
        //    if (bolumId != 0)
        //    {
        //        foreach (vYetkiTanim yetkiTanim in yetkiler)
        //        {
        //            tblYetkiler yetki = new DBEvents().GetGeneric<tblYetkiler>(c => c.BolumId == bolumId && c.YetkiId == yetkiTanim.Id).FirstOrDefault();
        //            if (yetki == null)
        //            {
        //                yetki = new tblYetkiler()
        //                {
        //                    BolumId = bolumId,
        //                    KullaniciId = null,
        //                    YetkiId = yetkiTanim.Id,
        //                    YetkiVarMi = yetkiTanim.YetkiliMi.Value
        //                };
        //            }
        //            else yetki.YetkiVarMi = yetkiTanim.YetkiliMi.Value;
        //            yetkiTbl.Add(yetki);
        //        }
        //    }
        //    //kullanıcı için yetki tanımlama
        //    else
        //    {
        //        foreach (vYetkiTanim yetkiTanim in yetkiler)
        //        {
        //            tblYetkiler yetki = new DBEvents().GetGeneric<tblYetkiler>(c => c.KullaniciId == kullaniciId && c.YetkiId == yetkiTanim.Id).FirstOrDefault();
        //            if (yetki == null)
        //            {
        //                yetki = new tblYetkiler()
        //                {
        //                    KullaniciId = kullaniciId,
        //                    BolumId = null,
        //                    YetkiId = yetkiTanim.Id,
        //                    YetkiVarMi = yetkiTanim.YetkiliMi.Value
        //                };
        //            }
        //            yetkiTbl.Add(yetki);
        //        }
        //    }

        //    return vYetkiTanim.YetkiKaydet(yetkiTbl);
        //}

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vTezgahPlanlama")]
    public class vTezgahPlanlama : IDisposable
    {
        [Column]
        public int TezgahId { get; set; }

        [Column]
        public string Tezgah { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public double? Tarih1 { get; set; }

        [Column]
        public double? Tarih2 { get; set; }

        [Column]
        public double? Tarih3 { get; set; }

        [Column]
        public double? Tarih4 { get; set; }

        [Column]
        public double? Tarih5 { get; set; }

        [Column]
        public double? Tarih6 { get; set; }

        [Column]
        public double? Tarih7 { get; set; }

        [Column]
        public double? Tarih8 { get; set; }

        [Column]
        public double? Tarih9 { get; set; }

        [Column]
        public double? Tarih10 { get; set; }

        [Column]
        public double? Tarih11 { get; set; }

        [Column]
        public double? Tarih12 { get; set; }

        [Column]
        public double? Tarih13 { get; set; }

        [Column]
        public double? Tarih14 { get; set; }

        [Column]
        public double? Tarih15 { get; set; }

        [Column]
        public double? Tarih16 { get; set; }

        [Column]
        public double? Tarih17 { get; set; }

        [Column]
        public double? Tarih18 { get; set; }

        [Column]
        public double? Tarih19 { get; set; }

        [Column]
        public double? Tarih20 { get; set; }

        [Column]
        public double? Tarih21 { get; set; }

        [Column]
        public double? Tarih22 { get; set; }

        [Column]
        public double? Tarih23 { get; set; }

        [Column]
        public double? Tarih24 { get; set; }

        [Column]
        public double? Tarih25 { get; set; }

        [Column]
        public double? Tarih26 { get; set; }

        [Column]
        public double? Tarih27 { get; set; }

        [Column]
        public double? Tarih28 { get; set; }

        [Column]
        public double? Tarih29 { get; set; }

        [Column]
        public double? Tarih30 { get; set; }

        [Column]
        public double? Tarih31 { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vPlanlama")]
    public class vPlanlama : IDisposable
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int TezgahId { get; set; }

        [Column]
        public string TezgahAdi { get; set; }

        [Column]
        public DateTime? Tarih { get; set; }

        [Column]
        public int SiparisActId { get; set; }

        [Column]
        public double? Miktar { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public int SiparisId { get; set; }

        internal tblPlanlama ViewToTbl()
        {
            return new tblPlanlama()
            {
                Id = this.Id,
                Miktar = this.Miktar,
                SiparisActId = this.SiparisActId,
                Tarih = this.Tarih.Value,
                TezgahId = this.TezgahId,
                TipId = this.TipId
            };
        }

        internal List<tblPlanlama> ViewToTbl(List<vPlanlama> view)
        {
            List<tblPlanlama> tbl = new List<tblPlanlama>();

            foreach (vPlanlama vItem in view)
            {
                tbl.Add(vItem.ViewToTbl());
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vCozgu")]
    public class vCozgu : IDisposable
    {
        [Column]
        public int TipId { get; set; }

        [Column]
        public double Miktar { get; set; }

        [Column]
        public string Tip { get; set; }

        //public tblCozgu ViewToTbl()
        //{
        //    return new tblCozgu()
        //    {
        //        Miktar = this.Miktar,
        //        TipId = this.TipId
        //    };
        //}

        //public List<tblCozgu> ViewToTbl(List<vCozgu> view)
        //{
        //    List<tblCozgu> tbl = new List<tblCozgu>();

        //    foreach (vCozgu item in view) tbl.Add(item.ViewToTbl());

        //    return tbl;
        //}

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vIplikStok")]
    public class vIplikStok : IDisposable
    {
        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public string Kodu { get; set; }

        [Column]
        public string Adi { get; set; }

        [Column]
        public string LotNo { get; set; }

        [Column]
        public int RenkId { get; set; }

        [Column]
        public string RenkAdi { get; set; }

        [Column]
        public string Ambalaj { get; set; }

        [Column(Name="KalanNetKg")]
        public double NetKg { get; set; }

        [Column(Name="KalanBobinSayisi")]
        public double BobinSayisi { get; set; }

        [Column]
        public bool? LeventteGor { get; set; }

        [Column]
        public int IplikNo { get; set; }

        [Column]
        public int SaticiId { get; set; }

        [Column]
        public string Satici { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public static class vRenkler
    {
        public static List<tblRenkler> RenkleriGetir()
        {
            return new DBEvents().GetGeneric<tblRenkler>(c => c.AktifMi == true);
        }
    }

    [Table(Name = "vLeventHareket")]
    public class vLeventHareket : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public long SetId { get; set; }

        [Column]
        public string LeventNo { get; set; }

        [Column]
        public int CekenPersonelId { get; set; }

        [Column]
        public string CekenPersonel { get; set; }

        [Column]
        public int TezgahId { get; set; }

        [Column]
        public string TezgahAdi { get; set; }

        [Column]
        public string Cozgu { get; set; }

        [Column]
        public double? Metre { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public int RenkId { get; set; }

        //[Column]
        public string SaticiAdi { get; set; }

        [Column]
        public double? LeventEni { get; set; }

        [Column(Name="TelAdedi")]
        private double? _TelAdedi;
        
        public double? TelAdedi
        {
            get
            {
                return _TelAdedi;
            }
            set
            {
                _TelAdedi = value;
                if (BobinAdedi.HasValue && BobinAdedi.Value != 0)
                {
                    BantSayisi = Math.Round((1 + (value.Value / BobinAdedi.Value)), 2);
                    if (BantSayisiChanged != null) BantSayisiChanged();
                }
                else BantSayisi = null;
            }
        }

        #region Events
        public delegate void BantSayisiEvent();
        public event BantSayisiEvent BantSayisiChanged;        
        #endregion

        [Column(Name="BobinAdedi")]
        private double? _BobinAdedi;

        public double? BobinAdedi
        {
            get
            {
                return _BobinAdedi;
            }
            set
            {
                _BobinAdedi = value;
                if (TelAdedi.HasValue && TelAdedi.Value != 0)
                {
                    BantSayisi = Math.Round((1 + (TelAdedi.Value / value.Value)), 2);
                    if (BantSayisiChanged != null) BantSayisiChanged();
                }
                else BantSayisi = null;
            }
        }

        [Column]
        public double? BobinMetre { get; set; }

        [Column]
        public double? ResteMetre { get; set; }

        [Column]
        public double? BantSayisi { get; set; }

        [Column]
        public int Durum { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public double? KullanilanMetre { get; set; }

        [Column]
        public string RenkKodu { get; set; }

        internal tblLeventHareket TblLevent()
        {
            return new tblLeventHareket()
            {
                BantSayisi = this.BantSayisi,
                BobinAdedi = this.BobinAdedi,
                BobinMetre = this.BobinMetre,
                CekenPersonelId = this.CekenPersonelId,
                Cozgu = this.Cozgu,
                Durum = this.Durum,
                Id = this.Id,
                LeventEni = this.LeventEni,
                LeventNo = this.LeventNo,
                Metre = this.Metre,
                RenkId = this.RenkId,
                ResteMetre = this.ResteMetre,
                SetId = this.SetId,
                TelAdedi = this.TelAdedi,
                TezgahId = this.TezgahId,
                TipId = this.TipId,
                Aciklama = this.Aciklama
            };
        }

        public static List<tblLeventHareket> ViewToTbl(List<vLeventHareket> view)
        {
            List<tblLeventHareket> tbl = new List<tblLeventHareket>();

            foreach (vLeventHareket item in view) tbl.Add(item.TblLevent());

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vLeventIplik")]
    public class vLeventIplik : IDisposable
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public long SetId { get; set; }

        [Column]
        public int SetHareketId { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public double BobinSayisi { get; set; }

        [Column]
        public double NetKg { get; set; }

        [Column]
        public string Ambalaj { get; set; }

        [Column]
        public string LotNo { get; set; }

        [Column]
        public int RenkId { get; set; }

        [Column]
        public int SaticiId { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public string IplikKodu { get; set; }

        [Column]
        public string IplikAdi { get; set; }

        [Column]
        public string RenkAdi { get; set; }

        [Column]
        public string Satici { get; set; }

        public tblMalzemeCikis TblMalzemeCikis
        {
            get
            {
                return new tblMalzemeCikis()
                {
                    Ambalaj = this.Ambalaj,
                    BirimId = null,
                    BobinSayisi = this.BobinSayisi,
                    CikisTanim = null,
                    CikisTanimId = null,
                    Id = this.Id,
                    LotNo = this.LotNo,
                    MalzemeId = this.MalzemeId,
                    Miktar = null,
                    NetKg = this.NetKg,
                    PersonelId = this.PersonelId,
                    RenkId = this.RenkId,
                    SaticiId = this.SaticiId,
                    SetHareketId = this.SetHareketId,
                    SetId = this.SetId,
                    Tarih = DateTime.Now
                };
            }
        }

        public static List<tblMalzemeCikis> ViewToTblCikis(List<vLeventIplik> view)
        {
            List<tblMalzemeCikis> yeniList = new List<tblMalzemeCikis>();

            foreach (vLeventIplik item in view) yeniList.Add(item.TblMalzemeCikis);

            return yeniList;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vIplikGiris")]
    public class vIplikGiris : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public string Kodu { get; set; }

        [Column]
        public string Adi { get; set; }

        [Column]
        public string LotNo { get; set; }

        [Column]
        public int? RenkId { get; set; }

        public string RenkAdi { get; set; }

        [Column]
        public int? SaticiId { get; set; }

        [Column]
        public string SaticiAdi { get; set; }

        [Column]
        public double? BobinSayisi { get; set; }        

        [Column]
        public string Ambalaj { get; set; }

        [Column]
        public double? BrutKg { get; set; }

        [Column]
        public double? NetKg { get; set; }

        [Column]
        public string GirisTanim { get; set; }

        [Column]
        public int? GirisTanimId { get; set; }

        [Column]
        public string FasonAdi { get; set; }

        [Column]
        public int? PersonelId { get; set; }

        [Column]
        public string PersonelKodu { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        [Column]
        public DateTime? Tarih { get; set; }

        [Column]
        public string IrsaliyeNo { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public double? Metre { get; set; }

        public tblMalzemeGiris ViewToTbl()
        {
            return new tblMalzemeGiris()
            {
                Ambalaj = this.Ambalaj,
                BirimId = null,
                BobinSayisi = this.BobinSayisi,
                BrutKg = this.BrutKg,
                GirisTanim = this.GirisTanim,
                GirisTanimId = this.GirisTanimId,
                Id = this.Id,
                KarsilamaActId = null,
                LotNo = this.LotNo,
                MalzemeId = this.MalzemeId,
                Miktar = null,
                NetKg = this.NetKg,
                PersonelId = this.PersonelId.Value,
                RenkId = this.RenkId,
                Aciklama = this.Aciklama,
                Tarih = this.Tarih,
                Metre = this.Metre,
                IrsaliyeNo = this.IrsaliyeNo,
                 SaticiId = this.SaticiId
            };
        }

        public static List<tblMalzemeGiris> ViewToTbl(List<vIplikGiris> view)
        {
            List<tblMalzemeGiris> tbl = new List<tblMalzemeGiris>();

            foreach (vIplikGiris item in view) tbl.Add(item.ViewToTbl());

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vIplikCikis")]
    public class vIplikCikis : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public int MalzemeId { get; set; }

        [Column]
        public string Kodu { get; set; }

        [Column]
        public string Adi { get; set; }

        [Column]
        public string LotNo { get; set; }

        [Column]
        public int RenkId { get; set; }

        [Column]
        public string RenkAdi { get; set; }

        [Column]
        public double? BobinSayisi { get; set; }

        [Column]
        public string Ambalaj { get; set; }

        [Column]
        public double? BrutKg { get; set; }

        [Column]
        public double? NetKg { get; set; }

        [Column]
        public int? SaticiId { get; set; }

        [Column]
        public string SaticiAdi { get; set; }

        [Column]
        public string CikisTanim { get; set; }

        [Column]
        public int? CikisTanimId { get; set; }

        [Column]
        public string FasonAdi { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public string PersonelKodu { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public DateTime? Tarih { get; set; }

        public tblMalzemeCikis ViewToTbl()
        {
            return new tblMalzemeCikis()
            {
                Ambalaj = this.Ambalaj,
                BirimId = null,
                BobinSayisi = this.BobinSayisi,
                BrutKg = this.BrutKg,
                CikisTanim = this.CikisTanim,
                CikisTanimId = this.CikisTanimId,
                Id = this.Id,
                LotNo = this.LotNo,
                MalzemeId = this.MalzemeId,
                Miktar = null,
                NetKg = this.NetKg,
                PersonelId = this.PersonelId,
                RenkId = this.RenkId,
                Aciklama = this.Aciklama,
                Tarih = this.Tarih,
                SaticiId = this.SaticiId
            };
        }

        public static List<tblMalzemeCikis> ViewToTbl(List<vIplikCikis> view)
        {
            List<tblMalzemeCikis> tbl = new List<tblMalzemeCikis>();

            foreach (vIplikCikis item in view) tbl.Add(item.ViewToTbl());

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    public class vHamHatalar : IDisposable
    {
        public int Id { get; set; }

        public string HataKodu { get; set; }

        public string HataAdi { get; set; }

        public double Uzunluk { get; set; }

        public double Metresi { get; set; }

        public int TurId { get; set; }

        public double UstMu { get; set; }

        public double AltMi { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vHamKumaslar")]
    public class vHamKumaslar : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public string Barkod { get; set; }

        [Column]
        public int? SiparisId { get; set; }

        [Column]
        public int MusteriId { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public int TezgahId { get; set; }

        [Column]
        public string TezgahNo { get; set; }

        [Column]
        public int DokumaciId { get; set; }

        [Column]
        public string DokumaciAdi { get; set; }

        [Column]
        public int KaliteciId { get; set; }

        [Column]
        public string KaliteciAdi { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public string Varyant { get; set; }

        [Column]
        public double Metre { get; set; }

        [Column]
        public double Kg { get; set; }

        [Column]
        public double Gramaj { get; set; }

        [Column]
        public double NetMetre { get; set; }

        [Column]
        public int? HavLeventId { get; set; }

        [Column]
        public int? ZeminAltLeventId { get; set; }

        [Column]
        public int? ZeminUstLeventId { get; set; }

        [Column]
        public int HataAdet { get; set; }

        [Column]
        public double HataPuan { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public double KaliteAdetDeger { get; set; }

        [Column]
        public string KaliteAdet { get; set; }

        [Column]
        public double KalitePuanDeger { get; set; }

        [Column]
        public string KalitePuan { get; set; }

        [Column]
        public string Tur { get; set; }

        [Column]
        public int? PartiId { get; set; }

        public tblHamKumaslar ViewToTbl()
        {
            return new tblHamKumaslar()
            {
                Aciklama = this.Aciklama,
                Barkod = this.Barkod,
                DokumaciId = this.DokumaciId,
                Gramaj = this.Gramaj,
                HataAdet = this.HataAdet,
                HataPuan = this.HataPuan,
                HavLeventId = this.HavLeventId,
                Id = this.Id,
                KaliteAdet = this.KaliteAdet,
                KaliteAdetDeger = this.KaliteAdetDeger,
                KaliteciId = this.KaliteciId,
                KalitePuan = this.KalitePuan,
                KalitePuanDeger = this.KalitePuanDeger,
                Kg = this.Kg,
                Metre = this.Metre,
                NetMetre = this.NetMetre,
                SiparisId = this.SiparisId,
                Tarih = this.Tarih,
                TezgahId = this.TezgahId,
                TipId = this.TipId,
                Tur = this.Tur,
                Varyant = this.Varyant,
                ZeminAltLeventId = this.ZeminAltLeventId,
                ZeminUstLeventId = this.ZeminUstLeventId,
                PartiId = this.PartiId,
            };
        }

        public static List<tblHamKumaslar> ViewToTbl(List<vHamKumaslar> view)
        {
            List<tblHamKumaslar> tbl = new List<tblHamKumaslar>();

            foreach (vHamKumaslar item in view) tbl.Add(item.ViewToTbl());

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vGrupProcess")]
    public class vGrupProcess : IDisposable
    {
        [Column]
        public int GrupId { get; set; }

        [Column]
        public int GrupActId { get; set; }

        [Column]
        public string GrupAdi { get; set; }

        [Column]
        public int ProcessId { get; set; }

        [Column]
        public string ProcessAdi { get; set; }

        [Column]
        public int Sira { get; set; }

        [Column]
        public bool? AktifMi { get; set; }

        public vPartiProcessleri GrupProcessToPartiProcess(int partiId)
        {
            return new vPartiProcessleri()
            {
                PartiId = partiId,
                ProcessAdi = this.ProcessAdi,
                ProcessId = this.ProcessId,
                Sira = this.Sira
            };
        }

        public static List<vPartiProcessleri> GrupProcessToPartiProcess(List<vGrupProcess> grupProcess, int partiId)
        {
            List<vPartiProcessleri> partiProc = new List<vPartiProcessleri>();

            foreach (vGrupProcess item in grupProcess) partiProc.Add(item.GrupProcessToPartiProcess(partiId));

            return partiProc;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vPartiProcessleri")]
    public class vPartiProcessleri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public int PartiId { get; set; }

        [Column]
        public int ProcessId { get; set; }

        [Column]
        public string ProcessKodu { get; set; }

        [Column]
        public string ProcessAdi { get; set; }

        [Column]
        public int Sira { get; set; }


        public tblPartiProsesleri ViewToTbl()
        {
            return new tblPartiProsesleri()
            {
                Id = this.Id,
                PartiId = this.PartiId,
                ProcessId = this.ProcessId,
                Sira = this.Sira
            };
        }

        public static List<tblPartiProsesleri> ViewToTbl(List<vPartiProcessleri> view)
        {
            List<tblPartiProsesleri> tbl = new List<tblPartiProsesleri>();

            foreach (vPartiProcessleri item in view) tbl.Add(item.ViewToTbl());

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vPartiler")]
    public class vPartiler : IDisposable
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int PartiNo { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public int PlanlayanId { get; set; }

        [Column]
        public string PlanlayanAdi { get; set; }

        [Column]
        public int MusteriId { get; set; }

        [Column]
        public string MusteriAdi { get; set; }

        [Column]
        public int SiparisId { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string DigerTipNo1 { get; set; }

        [Column]
        public string DigerTipNo2 { get; set; }

        [Column]
        public string DigerTipNo3 { get; set; }

        [Column]
        public double PartiMetre { get; set; }

        [Column]
        public string Tipi { get; set; }

        [Column]
        public string Makina { get; set; }

        [Column]
        public string RenkNo { get; set; }

        [Column]
        public string RenkVaryant { get; set; }

        [Column]
        public string TipVaryant { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public int? OnaylayanId { get; set; }

        [Column]
        public DateTime BoyamaTarihi { get; set; }

        [Column]
        public bool BoyahaneOnay { get; set; }

        [Column]
        public string BoyahaneNot { get; set; }

        [Column]
        public bool FarkliSiparisKabul { get; set; }

        [Column]
        public int FinishKodId { get; set; }

        [Column]
        public string FinishKodu { get; set; }

        [Column]
        public double AcilmisMetre { get; set; }

        [Column]
        public bool? ReProcessVarMi { get; set; }

        [Column]
        public bool? ProcessOkumaHizliMi { get; set; }

        [Column]
        public int SiparisActId { get; set; }

        public tblPartiler ViewToTbl()
        {
            return new tblPartiler()
            {
                Aciklama = this.Aciklama,
                BoyahaneNot = this.BoyahaneNot,
                BoyahaneOnay = this.BoyahaneOnay,
                BoyamaTarihi = this.BoyamaTarihi,
                DigerTipNo1 = this.DigerTipNo1,
                DigerTipNo2 = this.DigerTipNo2,
                DigerTipNo3 = this.DigerTipNo3,
                FarkliSiparisKabul = this.FarkliSiparisKabul,
                FinishKodId = this.FinishKodId,
                Id = this.Id,
                Makina = this.Makina,
                MusteriId = this.MusteriId,
                OnaylayanId = this.OnaylayanId,
                PartiMetre = this.PartiMetre,
                PartiNo = this.PartiNo,
                PlanlayanId = this.PlanlayanId,
                RenkNo = this.RenkNo,
                RenkVaryant = this.RenkVaryant,
                //SiparisId = this.SiparisId,
                Tarih = this.Tarih,
                Tipi = this.Tipi,
                //TipId = this.TipId,
                TipVaryant = this.TipVaryant,
                ProcessOkumaHizliMi = this.ProcessOkumaHizliMi,
                ReProcessVarMi = this.ReProcessVarMi,
                SiparisActId = this.SiparisActId
            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vBoyahaneProcess")]
    public class vBoyahaneProcess : IDisposable
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int PartiId { get; set; }

        [Column]
        public int PartiNo { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public DateTime Saat { get; set; }

        [Column]
        public int ProcessId { get; set; }

        [Column]
        public string ProcessKodu { get; set; }

        [Column]
        public string ProcessAdi { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public string PersonelKodu { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        [Column]
        public double Metre { get; set; }

        [Column]
        public double AcilmisMetre { get; set; }

        [Column]
        public int Sira { get; set; }

        [Column]
        public bool? ReProcess { get; set; }

        [Column]
        public string Aciklama { get; set; }

        public tblBoyahaneProcess ViewToTbl()
        {
            return new tblBoyahaneProcess()
            {
                Id = this.Id,
                Metre = this.Metre,
                PartiId = this.PartiId,
                PersonelId = this.PersonelId,
                ProcessId = this.ProcessId,
                Saat = this.Saat,
                Sira = this.Sira,
                Tarih = this.Tarih,
                ReProcess = this.ReProcess,
                Aciklama = this.Aciklama
            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vKimyasalRecete")]
    public class vKimyasalRecete : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string ReceteNo { get; set; }

        [Column]
        public string Makina { get; set; }

        [Column]
        public string Program { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public string PersonelAdi { get; set; }

        [Column]
        public int RenkId { get; set; }

        [Column]
        public string RenkKodu { get; set; }

        [Column]
        public string RenkAdi { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public bool AktifMi { get; set; }

        public tblKimyasalRecete ViewToTbl()
        {
            return new tblKimyasalRecete()
            {
                Id = this.Id,
                Makina = this.Makina,
                PersonelId = this.PersonelId,
                Program = this.Program,
                ReceteNo = this.ReceteNo,
                RenkId = this.RenkId,
                Tarih = this.Tarih,
                Aciklama = this.Aciklama,
                AktifMi = this.AktifMi
            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vKimyasalRecetePartileri")]
    public class vKimyasalRecetePartileri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public int ReceteId { get; set; }

        [Column]
        public int PartiId { get; set; }

        [Column]
        public int PartiNo { get; set; }

        [Column]
        public double TartilanKg { get; set; }

        [Column]
        public double AcilmisMetre { get; set; }

        public tblKimyasalRecetePartileri ViewToTbl()
        {
            return new tblKimyasalRecetePartileri()
            {
                Id = this.Id,
                PartiId = this.PartiId,
                ReceteId = this.ReceteId,
                TartilanKg = this.TartilanKg
            };
        }

        public static List<tblKimyasalRecetePartileri> ViewToTbl(List<vKimyasalRecetePartileri> view)
        {
            List<tblKimyasalRecetePartileri> tbl = new List<tblKimyasalRecetePartileri>();

            foreach (vKimyasalRecetePartileri item in view)
            {
                tbl.Add(item.ViewToTbl());
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vKimyasalReceteAct")]
    public class vKimyasalReceteAct : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public int ReceteId { get; set; }

        [Column]
        public double? Oran { get; set; }

        [Column]
        public int KimyasalId { get; set; }

        [Column]
        public string GrLtOran { get; set; }

        [Column]
        public double Miktar { get; set; }

        [Column]
        public string KimyasalKodu { get; set; }

        [Column]
        public string KimyasalAdi { get; set; }

        [Column]
        public string Tip { get; set; }

        [Column]
        public double Flote { get; set; }

        public List<tblMalzemeler> ListKimyasallar { get; set; }

        public tblKimyasalReceteAct ViewToTable()
        {
            return new tblKimyasalReceteAct()
            {
                GrLtOran = this.GrLtOran,
                Id = this.Id,
                KimyasalId = this.KimyasalId,
                Miktar = this.Miktar,
                Oran = this.Oran,
                ReceteId = this.ReceteId,
                Tip = this.Tip,
                Flote = this.Flote
            };
        }

        public static List<tblKimyasalReceteAct> ViewToTable(List<vKimyasalReceteAct> view)
        {
            List<tblKimyasalReceteAct> table = new List<tblKimyasalReceteAct>();

            foreach (vKimyasalReceteAct item in view)
            {
                table.Add(item.ViewToTable());
            }

            return table;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vKumasRenkAct")]
    public class vKumasRenkAct : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        
        [Column]
        public int RenkId { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public string BoyaKimya { get; set; }

        [Column]
        public string GrOran { get; set; }

        [Column]
        public double Miktar { get; set; }

        [Column]
        public int KimyasalId { get; set; }

        [Column]
        public string KimyasalKodu { get; set; }

        [Column]
        public string KimyasalAdi { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vLaboratuvarTest")]
    public class vLaboratuvarTest : IDisposable
    {        
        [Column]
        public int PartiId { get; set; }

        [Column]
        public int PartiNo { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string RenkNo { get; set; }

        [Column]
        public int TestId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public bool TestYapildiMi { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vMamulKumaslar")]
    public class vMamulKumaslar : IDisposable
    {
        [Column]
        public int Id { get; set; }
        
        [Column]
        public string Barkod { get; set; }

        [Column]
        public int PartiId { get; set; }

        [Column]
        public int PartiNo { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string TipAdi { get; set; }

        [Column]
        public int MusteriId { get; set; }

        [Column]
        public string MusteriKodu { get; set; }

        [Column]
        public string MusteriAdi { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public string Finish { get; set; }

        [Column]
        public double Metre { get; set; }

        [Column]
        public double NetMetre { get; set; }

        [Column]
        public double En { get; set; }

        [Column]
        public int HataAdet { get; set; }

        [Column]
        public double HataPuan { get; set; }

        [Column]
        public double KaliteAdetDeger { get; set; }

        [Column]
        public string KaliteAdet { get; set; }

        [Column]
        public double KalitePuanDeger { get; set; }

        [Column]
        public string KalitePuan { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        [Column]
        public int KaliteciId { get; set; }

        [Column]
        public string KaliteciKodu { get; set; }

        [Column]
        public string KaliteciAdi { get; set; }

        [Column]
        public string Tur { get; set; }

        [Column]
        public double TopMetre { get; set; }

        [Column]
        public string RenkNo { get; set; }

        [Column]
        public string RenkVaryant { get; set; }

        [Column]
        public string TipVaryant { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public string SevkiyatNotu { get; set; }

        [Column]
        public int HamId { get; set; }

        [Column]
        public string HamBarkod { get; set; }

        [Column]
        public string FasonTipi { get; set; }

        [Column]
        public int? SevkId { get; set; }

        public double ToplamKalan { get; set; }
        public double HamKalan { get; set; }

        public tblMamulKumaslar ViewToTable()
        {
            return new tblMamulKumaslar()
            {
                Barkod = this.Barkod,
                HataAdet = this.HataAdet,
                HataPuan = this.HataPuan,
                Id = this.Id,
                KaliteAdet = this.KaliteAdet,
                KaliteAdetDeger = this.KaliteAdetDeger,
                KalitePuan = this.KalitePuan,
                KalitePuanDeger = this.KalitePuanDeger,
                Metre = this.Metre,
                PartiId = this.PartiId,
                KaliteciId = this.KaliteciId,
                Tarih = this.Tarih,
                Tur = this.Tur,
                Aciklama = this.Aciklama,
                SevkiyatNotu = this.SevkiyatNotu,
                Finish = this.Finish,
                HamId = this.HamId,
                En = this.En
            };
        }

        public static List<tblMamulKumaslar> ViewToTable(List<vMamulKumaslar> view)
        {
            List<tblMamulKumaslar> tbl = new List<tblMamulKumaslar>();

            foreach (vMamulKumaslar item in view)
            {
                tbl.Add(item.ViewToTable());
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vMamuleHazirPartiler")]
    public class vMamuleHazirPartiler : IDisposable
    {
        [Column]
        public int PartiId { get; set; }

        [Column]
        public int PartiNo { get; set; }

        [Column]
        public int ProcessId { get; set; }

        [Column]
        public int MusteriId { get; set; }

        [Column]
        public string MusteriKodu { get; set; }

        [Column]
        public string MusteriAdi { get; set; }

        [Column]
        public int SiparisId { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string RenkNo { get; set; }

        [Column]
        public int FinishKodId { get; set; }

        [Column]
        public string FinishNo { get; set; }

        [Column]
        public string RenkVaryant { get; set; }

        [Column]
        public string TipVaryant { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vHataTanim")]
    public class vHataTanim : IDisposable
    {
        [Column]
        public int HataYerBagId { get; set; }

        [Column]
        public int HataSebepBagId { get; set; }

        [Column]
        public string Kodu { get; set; }

        [Column]
        public string Adi { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vSevk")]
    public class vSevk : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public string BelgeNo { get; set; }

        [Column]
        public DateTime Tarih { get; set; }
        
        [Column]
        public string Aciklama { get; set; }

        [Column]
        public int SevkEdenId { get; set; }

        [Column]
        public string SevkEdenKodu { get; set; }

        [Column]
        public string SevkEdenAdi { get; set; }

        [Column]
        public int MusteriId { get; set; }

        [Column]
        public string MusteriKodu { get; set; }

        [Column]
        public string MusteriAdi { get; set; }

        [Column]
        public int SiparisId { get; set; }

        [Column]
        public string SozlesmeNo { get; set; }

        [Column]
        public bool FarkliSiparisOkut { get; set; }

        [Column]
        public bool LogoAktarildiMi { get; set; }

        public tblSevk ViewToTbl()
        {
            return new tblSevk()
            {
                Aciklama = this.Aciklama,
                FarkliSiparisOkut = this.FarkliSiparisOkut,
                Id = this.Id,
                LogoAktarildiMi= this.LogoAktarildiMi,
                MusteriId= this.MusteriId,
                SevkEdenId = this.SevkEdenId,
                SiparisId = this.SiparisId,
                Tarih = this.Tarih,
                BelgeNo = this.BelgeNo
            };
        }

        public static List<tblSevk> ViewToTbl(List<vSevk> view)
        {
            List<tblSevk> tbl = new List<tblSevk>();

            foreach (vSevk item in view)
            {
                tbl.Add(item.ViewToTbl());
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vYetkiMenu")]
    public class vYetkiMenu : IDisposable
    {
        [Column]
        public int Id { get; set; }
        
        [Column]
        public int BaglantiId { get; set; }

        [Column]
        public string Adi { get; set; }

        [Column]
        public string Deger { get; set; }

        [Column]
        public string Aciklama { get; set; }

        [Column]
        public bool? GosterilsinMi { get; set; }

        [Column]
        public bool BosGecilebilirMi { get; set; }

        [Column]
        public int Sira { get; set; }

        [Column]
        public bool? KontrolMu { get; set; }

        [Column]
        public int? BolumId { get; set; }

        [Column]
        public int? PersonelId { get; set; }

        [Column]
        public int YetkiId { get; set; }

        [Column]
        public int MenuId { get; set; }

        [Column]
        public bool YetkiVarMi { get; set; }

        public List<vYetkiMenu> MenuItems { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vCozguIsEmri")]
    public class vCozguIsEmri : IDisposable
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [Column]
        public DateTime Tarih { get; set; }
        
        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public int TezgahId { get; set; }

        [Column]
        public string TezgahAdi { get; set; }

        [Column]
        public string Cozgu { get; set; }

        [Column]
        public double Metre { get; set; }

        [Column]
        public double DokumaMetre { get; set; }

        [Column]
        public int PersonelId { get; set; }

        [Column]
        public int? IplikId { get; set; }

        [Column]
        public double? IplikTelAdedi { get; set; }

        [Column]
        public string IplikKodu { get; set; }

        [Column]
        public string IplikAdi { get; set; }

        [Column]
        public long Islem { get; set; }

        public double HavMetre { get; set; }
        public double AltZeminMetre { get; set; }
        public double UstZeminMetre { get; set; }

        public List<tblMakinalar> Tezgahlar { get; set; }

        public tblCozguIsEmri ViewToTbl()
        {
            return new tblCozguIsEmri()
            {
                Cozgu = this.Cozgu,
                Id = this.Id,
                Metre = this.Metre,
                TipId = this.TipId,
                Tarih = this.Tarih,
                TezgahId = this.TezgahId,
                DokumaMetre =this.DokumaMetre,
                PersonelId = this.PersonelId,
                Islem = this.Islem
            };
        }

        public static List<tblCozguIsEmri> ViewToTbl(List<vCozguIsEmri> view)
        {
            List<tblCozguIsEmri> tbl = new List<tblCozguIsEmri>();

            foreach (vCozguIsEmri item in view)
            {
                tbl.Add(item.ViewToTbl());
            }

            return tbl;
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vPlanRezerveUygunlar")]
    public class vPlanRezerveUygunlar : IDisposable
    {
        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public string TipAdi { get; set; }

        [Column]
        public string KalitePuan { get; set; }

        [Column]
        public double Metre { get; set; }

        private string _Firma = "LK";
        public string Firma { get { return _Firma; } }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    [Table(Name = "vPlanRezerveler")]
    public class vPlanRezerveler : IDisposable
    {
        [Column]
        public int Id { get; set; }

        [Column]
        public int TipId { get; set; }

        [Column]
        public string TipNo { get; set; }

        [Column]
        public int MusteriId { get; set; }

        [Column]
        public string MusteriAdi { get; set; }

        [Column]
        public string KalitePuan { get; set; }

        [Column]
        public double RezerveMetre { get; set; }

        [Column]
        public DateTime Tarih { get; set; }

        public tblPlanRezerve ViewToTbl()
        {
            return new tblPlanRezerve()
            {
                Id = this.Id,
                KalitePuan = this.KalitePuan,
                MusteriId = this.MusteriId,
                RezerveMetre = this.RezerveMetre,
                Tarih = this.Tarih,
                TipId = this.TipId
            };
        }

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }

    //[Table(Name = "")]
    //public class  : IDisposable
    //{
    //    [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true)]
    //    public int Id { get; set; }

    //    [Column]
    //    public string  { get; set; }

    //    #region IDisposable Members

    //    public void Dispose()
    //    {
    //        GC.SuppressFinalize(this);
    //    }

    //    #endregion
    //}
}
