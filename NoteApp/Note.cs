using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    class Note
    {
        private string _text;
        private bool _completed;
        public readonly DateTime DateCreated;
        public string Text { get => _text; set => _text = value; }
        public bool Completed { get => _completed; set => _completed = value; }

        public Note(string text, bool completed = false) 
        {
            Text = text;
            DateCreated = DateTime.Now;
            Completed = completed;
        }

        public override string ToString()
        {
            return $"{Text}; on: {DateCreated}";
        }
    }
}
