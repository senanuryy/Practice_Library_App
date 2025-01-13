using System.Diagnostics.Metrics;
using Practice_Library_App;

Books book1 = new Books()   // New (Nesne Oluşturma): 'new' anahtar kelimesiyle 'Books' sınıfından nesneler oluşturuyoruz.
{
    BookTitle = "To Kill A Mockingbird",
    AuthorFirstName = "Harper",
    AuthorLastName = "Lee",
    PageCount = 281,
    Publisher = "J.B. Lippincott & Co.",
};

Books book2 = new Books()
{
    BookTitle = "1984",
    AuthorFirstName = "George",
    AuthorLastName = "Orwell",
    PageCount = 328,
    Publisher = "Secker & Warburg",
};

Books book3 = new Books("Pride and Prejudice", "Jane", "Austen", 432, "T. Egerton") // New (Nesne Oluşturma): Bu kez parametreli constructor ile nesne oluşturuyoruz.
{

};

book1.BookInfo();
book2.BookInfo();
book3.BookInfo();

//Class(Sınıf):
//Sınıf, nesne yönelimli programlamada bir tür şablondur. İçerisinde özellikler (properties) ve metotlar barındırır. Sınıflar, bir nesnenin davranışlarını ve verilerini tanımlamak için kullanılır.
//Örneğin: Books adındaki sınıf, bir kitabın bilgilerini (ad, yazar, yayınevi vb.) tutan ve onunla ilgili işlemleri yapan bir şablondur.


//Property(Özellik):
//Özellikler, sınıf içinde tanımlanan ve o sınıfın nesnelerine ait verileri depolamak veya erişmek için kullanılan değişkenlerdir. get ve set metotlarıyla kontrol edilir.
//Örneğin: BookTitle, bir kitabın adını tutmak için kullanılır. Kullanıcı, bu özelliği ayarlayabilir (set) veya okuyabilir (get).


//New(Nesne Oluşturma):
//new anahtar kelimesi, bir sınıftan yeni bir nesne oluşturmak için kullanılır. Bir sınıfın gerçek bir örneğini (instance) oluşturur.
//Örneğin: Books book1 = new Books(); ifadesi, Books sınıfından book1 adlı bir nesne oluşturur.


//Constructor(Yapıcı Metot):
//Constructor, bir sınıftan nesne oluşturulurken çalışan özel bir metottur. Sınıfın özelliklerini başlatmak veya varsayılan değerler atamak için kullanılır. Aynı sınıfta birden fazla constructor tanımlanabilir (overloading).
//Örneğin:
//Default Constructor: Books() metodu, nesne oluşturulurken parametre almadan özelliklere varsayılan değerler atar.
//Parametreli Constructor: Books(string bookTitle, string authorFirstName, ...) metodu, nesne oluşturulurken kitap bilgilerini parametre olarak alır ve özelliklere atar.