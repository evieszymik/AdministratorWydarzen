using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen.Model
{
    internal interface IEventManager
    {
        void Add(Event e);
        void Add2(Event e);
        void Delete(int index);
        void saveToTxtFile(List<Event> list);
        List<Event> readFromTxtFile();

        List<Event> GetAll();

        public string GetDescription(Event e);
        public string GetType(Event e);
        public Color getRowColor(string type);

    }
}
