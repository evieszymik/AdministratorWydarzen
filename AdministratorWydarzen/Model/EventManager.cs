using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdministratorWydarzen.Model
{
    internal class EventManager:IEventManager
    {
        private List<Event> eventsList;
        private List<Event> eventsListPriorityLow;
        private List<Event> eventsListPriorityMedium;
        private List<Event> eventsListPriorityHigh;
        private List<Event> eventsListWithout;
        public EventManager()
        {
            eventsList = new List<Event>();
            eventsListWithout= new List<Event>();
        }
        public List<Event> GetAll()
        {
            
            var eList = new List<Event>();

            foreach (var ev in eventsList)
            {
                eList.Add(ev);
            }

            return eList;
        }

        public void Add(Event e)
        {
            eventsList.Add(e);
        }
        public void Add2(Event e)
        {
            eventsListWithout.Add(e);

        }
        public void Delete(int index)
        {
            Event e = eventsList[index];
            eventsList.Remove(e);
            eventsListWithout.Remove(e);
        }
        public void saveToTxtFile(List<Event> list)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik TXT|*.txt|Wszystkie pliki|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Event e in list)
                    {
                        string value = e.ToString();
                        writer.Write(value);
                        writer.Write('\n');
                    }
                }
            }
        }
        public List<Event> readFromTxtFile()
        {
            List<Event> list = new List<Event>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string linia;
                    while ((linia = reader.ReadLine()) != null)
                    {

                        string[] splitValue = linia.Split(';');
                        string[] s = splitValue[0].Split(": ");
                        string title = s[1];
                        s = splitValue[1].Split(": ");
                        string description = s[1];
                        s = splitValue[2].Split(": ");
                        DateTime date = DateTime.Parse(s[1]);
                        s = splitValue[3].Split(": ");
                        string type = s[1];
                        s = splitValue[4].Split(": ");
                        string priority = s[1];

                        Event e = new Event(title,description,date,type,priority);
                        eventsList.Add(e);

                    }
                }
            }
            return list;
        }

        public string GetDescription(Event e)
        {
            return e.description;
        }
        public string GetType(Event e)
        {
            return e.type;
        }

        public Color getRowColor(string type)
        {
            
            Color color;
            if(type=="Health")
            {
                color = Color.LightGreen;
            }
            else if (type == "Work")
            {
                color = Color.Red;
            }
            else if (type == "Family")
            {
                color = Color.Yellow;
            }
            else if (type == "Entertainment")
            {
                color = Color.HotPink;
            }
            else if (type == "Sport")
            {
                color = Color.LightSkyBlue;
            }
            else
            {
                color = Color.Blue;
            }
            return color;
        }
    }
}
