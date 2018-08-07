using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Model
{
   public class NoteContext: DbContext
        {
            public NoteContext(string conn) : base(conn)
            {
                Database.SetInitializer<NoteContext>(new MyInitializer());
            }
            public DbSet<Note> Notes { get; set; }
        }

        class MyInitializer : CreateDatabaseIfNotExists<NoteContext>
        {
            protected override void Seed(NoteContext context)
            {

                context.Notes.Add(new Note { Title = "Д/З", TextNote = "Сделать домашку по WPF", Image = "\\Images\\03.jpg" });
                context.Notes.Add(new Note { Title = "Экзамен", TextNote = "Подготовиться к экзамену по ADO.NET", Image = "\\Images\\04.jpg" });
                context.Notes.Add(new Note { Title = "Каникулы", TextNote = "Каникулы с 06.18 по 07.18", Image = "\\Images\\07.jpg" });

                context.SaveChanges();
            }
        }
    }
