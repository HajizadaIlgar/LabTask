namespace LibraryManagementTask;

internal class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();
        Console.WriteLine(book.Genre);

        book.PublicationYear = 24;
        Console.WriteLine(book.CalculateAge());

    }
}

/*
"Library Management System" adlı bir console app yazılacaq.
Person class-ı +
*Id  
*Name
Not:Abstract olmalıdır. Name dəyəri qəbul etmədən ondan miras alan class-ın obyekti yarana bilməməlidir.

Librarian class-ı +
*HireDate(Işə götürülmə tarixi)

Not: Person class-dan miras almalıdır.

LibraryMember +
class-ı
*MembershipDate

Not: Person class-dan miras almalıdır. Və Sealed class olmalıdır.

LibraryItem class-ı +
*Title  
*PublicationYear  

abstract DisplayInfo()  +
Not:Abstract olmalıdır. Title və PublicationYear dəyəri qəbul etmədən ondan miras alan class-ın obyekti yarana bilməməlidir.
Publication Year nullable olmalıdır çünki hər hansısa kitabın buraxılış tarixinin naməlum olma ehtimalı var.

Book, Magazine və DVD class-ları yaradılmalı və hər biri Library Item class-dan miras almalıdır. +
Polymorphism tətbiq edilərək hər bir class üçün Display İnfo method-u özəlləştirilməlidir.

Book class-ı +
*Genre(Janr) 


*LibraryLocation
Not: Fiction, NonFiction, Science, Art janrlarından biri saxlanıla bilər bunun üçün də BookJenre Enum yaradılmalıdır.
LibraryLocation bir struct olmalı və daxilində Aisle(Koridor) və Shelf(Rəf) dəyərlərini saxlamalıdır. Biz beləliklə kitabın harada yerləşdiyini tapmalıyıq.
Hər iki dəyər integer olmalıdır. +

LibraryHelper class-ı
CalculateAge() extension method-u yer alır. Bu Method Libraryİtem-dan törəyən hər bir item üçün buraxılışından neçə ilk keçdiyini hesablayır.+


ToTitleCase()  extension method-u yer alır. Bu Method Libraryİtem-dan törəyən hər bir item üçün Title-larını düzgün hala gətirmək üçün istifadə edilir.+
LibraryCatalog class-ı +
Daxilində hər bir kitabı id ilə gətirən bir indexer-i olmalıdır. +

Not: Əgər Catalogda olmayan bir kitab əldə edilməyə çalışılsa CustomBookError exception işə düşməli və
Daxilin edilən Id-ə sahib kitabın catalogda yer almadığı mesajı verməlidir. +
*/