# Yamato's Adventure

# Proje Bilgileri
Proje Adı: Yamato’s Adventures <br>
Ders Adı: Oyun Programlama Dersi

# Kullanılan Teknolojiler
Oyun Motoru: Unity 2020.3.19f1<br>
Programlama Dili: C#<br>
Kodlama Editörü: Visual Studio <br>

# Hareketli Platform
Oyunda farklı yüksekliklerdeki yollara ulaşabilmek adına ve  zeminler arasında ilerleyebilmek için üzerinden geçilmesi gereken hareketli platform oluşturulmuştur. Oyuna zorluk eklemek açısından zemin üzerinde oyuncunun da birlikte hareket etmesi istenmektedir.

![Screenshot_1](https://user-images.githubusercontent.com/61601855/160918659-13dd9cc1-5b20-49df-992f-74b89a0a41c6.jpg)

# Menü – Oyun İçi Menü
-Oyunun girişinde oyuncuyu karşılayan ve isteğini alan ana menü tasarlanmıştır. Bunun yanında oyun içerisinde “Esc” tuşu ile tetiklenen ve oyunu duraklatıp menü ekranı açan kod ve UI tasarımını yaptım. 

![Screenshot_1](https://user-images.githubusercontent.com/61601855/160918816-c86d6d20-4037-4a88-9124-c21f4a7a5c2e.png)

-İç menü kısmında ise canvas’ın içine eklediğim panel sayesinde enable ve disable metotlarını true, false ile kod kısmına kullanarak “ESC” tuşuna basıldığı andan itibaren oyunun duraklatılıp oyu içi menünün ekrana gelmesini sağlıyoruz.

![Screenshot_3](https://user-images.githubusercontent.com/61601855/160919083-fed607ba-728e-4aa2-bb7b-3728fc9cc813.png)

# Yerden Para Toplama
Oyunda para sistemi bulunmakta oyunun ilerleyen versiyonlarında her iki level de bir market açılacak olup yerden kazandığımız paralar ile oyun içi can yükseltme ve  hasar arttırıcı ekipmanlar alınacaktır. Oyunda başlangıç paramız sıfır olup topladığımız her para için sayaç 1 artmaktadır.Aynı zamanda canvas ile oyunumuzun sol üst köşesinde değerlerin kalmasını sağladım.

![Screenshot_4](https://user-images.githubusercontent.com/61601855/160919227-c6bfb903-1d97-4b92-8a0e-1a6176ef5903.png)

# Hareketli Düşman ve Animasyonları
Oyuna düşman ekleyerek oyunun daha zor ve eğlenceli olmasını sağladım, eklediğim düşman iki koordinat arasında sürekli olarak hareket edip ve noktalara ulaştığında anlık olarak sakin pozisyonda(IDLE) bekleyip daha sonra tekrardan saldırı hareketine geçiyor.
Ana oyuncu eğer düşman askerinin görüş alanına girerse saldırması için gereken kodları oyunuma entegre ettim, ve bunların yanı sıra hasar yeme ve ölme animasyonlarını da düşman karakterime ekledim.
Bu animasyonlar aşağıda gözükmektedir.

![Screenshot_5](https://user-images.githubusercontent.com/61601855/160919434-71d75ed5-0f27-42ce-b7a4-cce4ad9ee011.png)
