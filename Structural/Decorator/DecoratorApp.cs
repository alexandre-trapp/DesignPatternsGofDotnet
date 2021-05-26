using System;

namespace DesignPatternsGofDotnet.Structural.Decorator
{
    static class DecoratorApp
    {
        public static void Execute()
        {
            // Create book
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Exibir();

            // Create video
            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Exibir();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Exibir();
        }
    }
}
