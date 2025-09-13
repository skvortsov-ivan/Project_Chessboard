//X När programmet startar ska användaren få mata in en siffra N (3–50). Validera inmatningen.
//X Skriv ut ett N×N "schackbräde" med så många rader och kolumner som användaren angav.
//X Brädet skriver du ut genom att låta varje svart ruta representeras av tecknet ◼︎ och varje vit ruta av tecknet ◻︎.
//X Strukturera koden med minst två egna metoder, t.ex. ReadSize() och RenderBoard(int n).
//X Git-flöde: arbeta på en separat branch (t.ex. feature/board) och skapa minst 1 Pull Request med en kort beskrivning av lösningen och en kort reflektion i PR-texten.
//Lägg till en README som beskriver hur man kör programmet.
//X Använd ett AI-verktyg (t.ex. ChatGPT eller GitHub Copilot) för att:
//1. Få exempel på hur man kan strukturera koden.
//2. Be AI:n förklara delar av koden du är osäker på.
//3. Få tips på förbättringar.
//Lägg in kommentarer i koden där du beskriver: 
//1. Vilket AI-verktyg du använde.
//2. Vilka frågor du ställde.
//3. Hur du använde svaren.
//4. Vilka ändringar du gjorde jämfört med AI:ns förslag och varför.

// Comments that have an initial number are the ones corresponding to an AI question, suggested improvement and a solution.
using System;
namespace Project_Chessboard
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // 3 My Chessboard() method was printing ??? instead of the desired squares so Copilot suggested me to enable UTF-8 encoding and it worked.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Reading chessboard size
            int size = ReadSize();
            Console.WriteLine($"Selected size: {size}");

            // Printing Chessboard
            var board = new RenderBoard();
            board.Chessboard(size);
        }
    }
}
