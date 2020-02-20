1.1 Programın Çalışma Sistemi
Programa kullanıcı adı ve şifre ile giriş yapıldıktan sonra ana ekrana ulaşılır. Anasayfa da hem otomatik hem de manuel bir şekilde işlemler gerçekleşebilir .Genel olarak program bakarsak okul web sayfasındaki duyuruları çekerek önceden atılmış duyurular ile karşılaştırarak  yeni gelen duyuruları tespit eder ve twitter api kullanrak duyurular tweet atılır.

1.2 Teknik Detay
Programımızın C#  yazılım dili kullanarak geliştirildi.Programımız 2 ana bölümden oluşuşmaktadır;

1)Kullanıcı Giriş Ekranı
Programda kullanıcı adı ve şifre sistem yöneticisi tarafından oluşturulur. Kullanıcı giriş ekranında kullanıcı adı ve şifre girildikten sonra bilgiler veri tabanındaki  bilgiler ile karşılaştırılır  bilgiler doğru ise  Tweet Atma Paneline yönlendirilir eğre bilgiler yanlış girilmiş ise kullanıcıdan tekrar  kulanıcı adı ve şifre isteyerek çalışır.

2)Tweet Atma Paneli
Tweet Atma Paneli sisteminin çalışma yapısı öncelikle  duyuruları okulun web sitesinden  HtmlAgilityPack Kütüphanesi kullanılarak taglere göre çekilerek liste yapısında depolanır ve sonrasında önceden atılmış duyurular  veri tabanından çekilerek liste yapısına getirilir .Oluşturulan iki  liste karşılaştırılarak  yeni gelen duyurular ve önceden tweet atılmış duyurular olarak listelenir .Duyuruların  çekilme işleminden sonra TweetinviAPI  Kütüphanesi ve Twitter Api kullanılarak duyurular tweet atılır.Tweet atma işlemi token denilen bağlantı cümleleriyle twitter’a bağlandıktan sonra tweet atılabilir. Tweet atılan  duyurular veri tabanına eklenerek   aynı tweetin tekrar  atılmaması sağlanır. Programımız hem otomatik hem de manuel olarak çalışabilir. Otomatik çalışma sistemi 5 dakika da bir duyuruları kontrol ederek tweet atılmasını sağlar ,manuel sistem ise her şeyin kontrolü kullanıcıdadır kullanıcı öncelikle duyuruları çekip  ardından tweet atma işlemlerini gerçekleştirilebilir ve manuel sistemde işlem yapılınca otomatik sistemde süreyi tutan sayaç sıfırlanır.Programda ayrıca duyuru dışında istenilen bir  yazıyı tweet atabilen bir bölüm de bulunmaktadır.

1.3 Proje Yapımında Kullanılan Teknolojiler
	C#
	Microsoft Sql
	Twitter Api
	HtmlAgilityPack Kütüphanesi
	TweetinviAPI  Kütüphanesi
