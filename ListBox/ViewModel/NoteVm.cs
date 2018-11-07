using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListBox.Model;

namespace ListBox.ViewModel
{
    class NoteVm
    {
        public ObservableCollection<Note> ListNote { get; set; }

        public NoteVm()
        {
            ListNote = new ObservableCollection<Note>()
            {
                new Note("Item1"),
                new Note("Item2")
            };
        }

        public void AddNewNote(string newNote)
        {
            ListNote.Add(new Note(newNote));
        }

    }
}
