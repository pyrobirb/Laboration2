using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2
{
    public interface IKurs
    {
        List<Student> ListaAllaDeltagandeStudenter();
        List<Lärare> ListaAllaDeltagandeLärare();
        
    }
}
