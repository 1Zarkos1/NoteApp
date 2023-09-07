using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace NoteApp
{
    class MainApp
    {
        public static void Main()
        {
            List<Note> notes = new List<Note>();    

            while (true)
            {
                int index = 1;
                Console.WriteLine("\nType your note below:");
                var noteText = Console.ReadLine();
                if (noteText != null)
                {
                    notes.Add(new Note(noteText));
                    foreach (var note in notes)
                    {
                        Console.WriteLine($"{index}. {note}");
                        ++index;
                    }
                } else { 
                    break; 
                }
            }
        }
    }
}