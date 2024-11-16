# Müşteri ve Sipariş Bilgilerini Görüntüleme - ASP.NET Core MVC

Bu proje, **ASP.NET Core MVC** kullanarak bir müşteri ve sipariş bilgilerini görüntüleyen bir uygulama geliştirmeyi amaçlamaktadır. Proje, MVC (Model-View-Controller) tasarım desenine dayalı olarak geliştirilmiştir.

## Proje Yapısı

Bu uygulama, aşağıdaki temel yapıları içermektedir:

1. **Model:** Müşteri ve Sipariş bilgilerini tutan sınıflar.
2. **ViewModel:** Müşteri ve Sipariş bilgilerini bir arada tutan sınıf.
3. **Controller:** Kullanıcıdan gelen istekleri işleyen ve model verilerini view'a ileten sınıf.
4. **View:** Kullanıcıya verileri görsel olarak sunan sayfa.

## Adımlar

### 1. Model Oluşturma

**Customer Modeli:**

Müşteri bilgilerini tutan bir sınıf oluşturulmuştur. Bu sınıf aşağıdaki özellikleri içerir:

- `Id`: Müşterinin benzersiz kimliği
- `FirstName`: Müşterinin adı
- `LastName`: Müşterinin soyadı
- `Email`: Müşterinin e-posta adresi

**Order Modeli:**

Sipariş bilgilerini tutan bir sınıf oluşturulmuştur. Bu sınıf aşağıdaki özelliklere sahiptir:

- `Id`: Siparişin benzersiz kimliği
- `ProductName`: Ürünün adı
- `Price`: Ürünün fiyatı
- `Quantity`: Sipariş edilen ürün miktarı

### 2. ViewModel Oluşturma

`CustomerOrderViewModel` sınıfı, bir müşteri ve o müşteriye ait siparişlerin bilgilerini tutar. Bu sınıfın iki ana özelliği vardır:

- `Customer`: Bir `Customer` nesnesi
- `Orders`: Bir liste halinde `Order` nesneleri

### 3. Controller Oluşturma

**CustomerOrdersController**:

Bu controller, müşteri ve sipariş bilgilerini alır, birleştirir ve view'a iletir. `Index` metodunda, müşteri bilgileri ve birkaç sipariş örneği oluşturulur ve bir `CustomerOrderViewModel` nesnesi oluşturulup view'a aktarılır.

### 4. View Oluşturma

**Index View**:

`Views/CustomerOrders/Index.cshtml` dosyasına yerleştirilen view, aşağıdaki verileri görüntüler:

- Müşteri bilgileri (ID, Adı, Soyadı, E-Posta)
- Siparişlerin listesi (Sipariş ID'si, Ürün Adı, Fiyat ve Miktar)

View'de Razor syntax'ı kullanılarak veriler dinamik olarak render edilir.

### 5. Çalıştırma

Projeyi çalıştırmak için şu adımları izleyebilirsiniz:

1. Projeyi **Visual Studio** veya **Visual Studio Code** gibi bir IDE ile açın.
2. `CustomerOrdersController` ve `Index` action metodunun doğru yapılandırıldığından emin olun.
3. Projeyi çalıştırarak tarayıcıda **https://localhost:5001/CustomerOrders/Index** adresine gidin.
4. Müşteri bilgileri ve siparişler görüntülenecektir.

## Kullanılan Teknolojiler

- **ASP.NET Core MVC**: Web uygulamalarında kullanılan, Model-View-Controller tasarım desenini izleyen bir framework.
- **C#**: Uygulama geliştirmek için kullanılan ana programlama dili.
- **Razor**: View'lar içinde dinamik içerik üretmek için kullanılan bir şablon motoru.

## Proje Yapısı

