Public Class Turistik_Tesis
    Inherits Emlak
    Private Tip_ID As Byte
    Private Otel_Yildiz_Sayisi As Byte
    Private Apart_Sayisi As Short
    Private Oda_Sayisi As Short
    Private Yatak_Sayisi As Short
    Private Kat_Sayisi As Byte
    Private Bina_Yasi As Byte
    Private Acik_Alan As Integer
    Private Kapali_Alan As Integer
    Private Zemin_Etudu? As Boolean
    Private Yapi_Durumu? As Boolean
    Private Krediye_Uygun? As Boolean
    Private Mocamp_Toplam_Arazi As Short
    Private Plaj_Buyukluk As Short
    Private Plaj_Kapasite As Short
    Public Property TipID As Byte
        Get
            Return Tip_ID
        End Get
        Set(value As Byte)
            Tip_ID = value
        End Set
    End Property
    Public Property OtelYildizSayisi As Byte
        Get
            Return Otel_Yildiz_Sayisi
        End Get
        Set(value As Byte)
            Otel_Yildiz_Sayisi = value
        End Set
    End Property
    Public Property ApartSayisi As Short
        Get
            Return Apart_Sayisi
        End Get
        Set(value As Short)
            Apart_Sayisi = value
        End Set
    End Property
    Public Property OdaSayisi As Short
        Get
            Return Oda_Sayisi
        End Get
        Set(value As Short)
            Oda_Sayisi = value
        End Set
    End Property
    Public Property YatakSayisi As Short
        Get
            Return Yatak_Sayisi
        End Get
        Set(value As Short)
            Yatak_Sayisi = value
        End Set
    End Property
    Public Property KatSayisi As Byte
        Get
            Return Kat_Sayisi
        End Get
        Set(value As Byte)
            Kat_Sayisi = value
        End Set
    End Property
    Public Property BinaYasi As Byte
        Get
            Return Bina_Yasi
        End Get
        Set(value As Byte)
            Bina_Yasi = value
        End Set
    End Property
    Public Property AcikAlan As Integer
        Get
            Return Acik_Alan
        End Get
        Set(value As Integer)
            Acik_Alan = value
        End Set
    End Property
    Public Property KapaliAlan As Integer
        Get
            Return Kapali_Alan
        End Get
        Set(value As Integer)
            Kapali_Alan = value
        End Set
    End Property
    Public Property ZeminEtudu As Boolean?
        Get
            Return Zemin_Etudu
        End Get
        Set(value? As Boolean)
            Zemin_Etudu = value
        End Set
    End Property
    Public Property YapiDurumu As Boolean?
        Get
            Return Yapi_Durumu
        End Get
        Set(value? As Boolean)
            Yapi_Durumu = value
        End Set
    End Property
    Public Property KrediyeUygun As Boolean?
        Get
            Return Krediye_Uygun
        End Get
        Set(value? As Boolean)
            Krediye_Uygun = value
        End Set
    End Property
    Public Property MocampToplamArazi As Short
        Get
            Return Mocamp_Toplam_Arazi
        End Get
        Set(value As Short)
            Mocamp_Toplam_Arazi = value
        End Set
    End Property
    Public Property PlajBuyukluk As Short
        Get
            Return Plaj_Buyukluk
        End Get
        Set(value As Short)
            Plaj_Buyukluk = value
        End Set
    End Property
    Public Property PlajKapasite As Short
        Get
            Return Plaj_Kapasite
        End Get
        Set(value As Short)
            Plaj_Kapasite = value
        End Set
    End Property
End Class
