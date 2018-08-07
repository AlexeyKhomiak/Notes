using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Model;
using System.Windows.Input;
using Notes.Infrastructure;

namespace Notes.ViewModel
{
    class ViewModel
    {
        public ObservableCollection<Note> Notes { get; set; }
        public Note Current { get; set; }

        NoteRepository repo;

        public ViewModel()
        {
            repo = new NoteRepository("ConnStrNotes");
            Notes = new ObservableCollection<Note>(repo.GetNoteList());

            Save = new RelayCommand(x =>
            {
                repo.Save();
            });

            Add = new RelayCommand(x =>
            {
                Note newNote = new Note();
                newNote = repo.Create(newNote);
                repo.Save();
                Notes.Add(newNote);
                
            });

            Remove = new RelayCommand(x =>
            {
                int id = Current.Id;
                Notes.Remove(Current);
                repo.Delete(id);
                repo.Save();
            },
            x => Notes.Count > 0);
        }

        public ICommand Save { get; set; }
        public ICommand Remove { get; set; }
        public ICommand Add { get; set; }

    }
}
