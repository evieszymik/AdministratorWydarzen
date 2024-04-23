using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdministratorWydarzen.Model
{
    internal class EventManager:IEventManager
    {
        private List<Event> eventsList; 
        private List<Event> eventsListWithout;
        
        public EventManager()
        {
            eventsList = new List<Event>();
            eventsListWithout = new List<Event>();
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
        public List<Event> Filter(string s,DateTime date)
        {
            List<Event> eventsFiltered=new List<Event>();
            
            switch (s)
            {
                case "Priority Low":
                    foreach (Event e in eventsList)
                    {
                        if (e.priority == "Low")
                        {
                            eventsFiltered.Add(e);
                        }
                    }
                    break;
                case "Priority Medium":
                    foreach (Event e in eventsList)
                    {
                        if (e.priority == "Medium")
                        {
                            eventsFiltered.Add(e);
                        }
                    }
                    break;
                case "Priority High":
                    foreach (Event e in eventsList)
                    {
                        if (e.priority == "High")
                        {
                            eventsFiltered.Add(e);
                        }     
                    }   
                    break;
                case "Type Sport":
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Sport")
                        {
                            eventsFiltered.Add(e);
                        }
                    } 
                    break;
                case "Type Health":
                    foreach (Event e in eventsList)
                    {
                         if (e.type == "Health")
                        {
                            eventsFiltered.Add(e);
                        } 
                    }  
                    break;
                case "Type Work":
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Work")
                        {
                            eventsFiltered.Add(e);
                        } 
                    } 
                    break;
                case "Type Family":
                    foreach (Event e in eventsList)
                    { 
                        if (e.type == "Family")
                        {
                            eventsFiltered.Add(e);
                        }  
                    }
                    break;
                case "Type Entertainment":
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Entertainment")
                        {
                            eventsFiltered.Add(e);
                        }
                    }
                    break;
                case "Date":
                    foreach (Event e in eventsList)
                    {
                        if (e.date == date)
                        {
                            eventsFiltered.Add(e);
                        }
                    }
                    break;
                default:
                    return eventsList; 
            }
            return eventsFiltered;
        }

        public List<Event> Sort(string s)
        {
            List<Event> eventsSorted = new List<Event>();

            switch (s)
            {
                case "Priority":
                    foreach (Event e in eventsList)
                    {
                        if (e.priority == "High")
                            eventsSorted.Add(e);
                    }
                    foreach (Event e in eventsList)
                    {
                        if (e.priority == "Medium")
                            eventsSorted.Add(e);
                    }
                    foreach (Event e in eventsList)
                    {
                        if (e.priority == "Low")
                            eventsSorted.Add(e);
                    }
                    break;
                case "Type":
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Health")
                            eventsSorted.Add(e);
                    }
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Work")
                            eventsSorted.Add(e);
                    }
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Family")
                            eventsSorted.Add(e);
                    }
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Sport")
                            eventsSorted.Add(e);
                    }
                    foreach (Event e in eventsList)
                    {
                        if (e.type == "Entertainment")
                            eventsSorted.Add(e);
                    } 
                    break;
                case "Date":
                    foreach (Event e in eventsList)
                    {
                            eventsSorted.Add(e);
                    }

                    Event temp;

                    for(int i=0;i<eventsSorted.Count-1;i++)
                    {
                        for(int j=i+1;j<eventsSorted.Count;j++)
                        {
                            if (eventsSorted[i].date > eventsSorted[j].date)
                            {
                                temp = eventsSorted[i];
                                eventsSorted[i] = eventsSorted[j];
                                eventsSorted[j] = temp;

                            }
                        }
                    }
                    
                    break;
                default:
                    return eventsList;
                
            }  
            return eventsSorted;
        }
    }
}
