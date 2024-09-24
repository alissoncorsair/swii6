using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

// Alisson de Sousa Vieira
// Leonardo de Fontes

namespace TP01.Interface
{
    public interface IBookRepository
    {
        ICollection<Book> getAll();
        void add(Book book);
    }
}
