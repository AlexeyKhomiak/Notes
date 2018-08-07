using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Notes.Model
{
    class NoteRepository:IDisposable
    {
        public NoteContext context;

        public NoteRepository(string conn)
        {
            context = new NoteContext(conn);
        }
        public List<Note> GetNoteList()
        {
            return context.Notes.ToList();
        }
       
        public Note GetNote(int id)
        {
            return context.Notes.FirstOrDefault(x => x.Id == id);
        }
        public Note Create(Note item)
        {
            return context.Notes.Add(item);
        }


        public void Delete(int id)
        {
            Note b = context.Notes.Find(id);
            if (b != null)
                context.Notes.Remove(b);
        }

        public void Save()
        {
            context.SaveChanges();

        }

        public void Update(Note item)
        {
            context.Entry(item).State = EntityState.Modified;
        }



        public void Dispose()
        {
            context?.Dispose();
        }
    }
}
