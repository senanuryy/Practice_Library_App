using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practice_Library_App
{
    internal class Books    // Class (Sınıf): 'Books' adında bir sınıf tanımladık. Bu sınıf, kitap nesnelerinin özelliklerini ve davranışlarını (metotlarını) içerir.
    {
        // Property (Özellik): Kitap nesnesinin bilgilerini tutmak için özellikler tanımladık.
        public string BookTitle { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public DateTime RecordDate { get; set; }

        public Books()  // Constructor (Yapıcı Metot): Default constructor. Parametre almaz ve kayıt tarihini o anki tarih olarak atar.
        {
            RecordDate = DateTime.Now;
        }

        public Books(string bookTitle, string authorFirstName, string authorLastName, int pageCount, string publisher)   // Constructor (Yapıcı Metot): Parametreli constructor. Kitap bilgilerini nesne oluşturulurken alır ve ilgili özelliklere atar.
        {
            BookTitle = bookTitle;
            AuthorFirstName = authorFirstName;
            AuthorLastName = authorLastName;
            PageCount = pageCount;   
            Publisher = publisher;
            RecordDate = DateTime.Now;
        }

        public void BookInfo()
        {
            Console.WriteLine($"Book Title : {BookTitle}");
            Console.WriteLine($"Author     : {AuthorFirstName} {AuthorLastName}");
            Console.WriteLine($"Page Count : {PageCount}");
            Console.WriteLine($"Publisher  : {Publisher}");
            Console.WriteLine($"Date       : {RecordDate}\n");
        }        
    }
}
