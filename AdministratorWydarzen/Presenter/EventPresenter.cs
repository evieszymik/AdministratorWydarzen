using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdministratorWydarzen.Presenter
{
    class EventPresenter
    {
        private EventView _view;
        private Model.Event _model;
        private Model.IEventManager _eventManager;
        private BindingSource _eventsBindingSource;
        private List<Model.Event> _eventList;
        
        public EventPresenter(EventView view, Model.IEventManager manager)
        {
            _view = view;
            _eventManager = manager;
            _eventsBindingSource = new BindingSource();
            _view.Add += Add;
            _view.Delete += Delete;
            _view.Save += Save;
            _view.Read += Read;
            _view.DetailedDescription += DetailedDescription;
            _view.RowColorChange += RowColorChange;
            _view.Filter += Filter;
            _view.Sort += Sort;
            

            _view.SetEventListBindingSource(_eventsBindingSource);

            LoadEventList();
        }
        private void LoadEventList()
        {
            _eventList = _eventManager.GetAll();
            _eventsBindingSource.DataSource = _eventList;
        }
        private void Add()
        {
            var e = new Model.Event(_view.Title,_view.Description,_view.Date,_view.Type,_view.Priority);
            var ev = new Model.Event(_view.Title, _view.Date, _view.Priority);
            _eventManager.Add(e);
            _eventManager.Add2(ev);
            LoadEventList();

            _view.Title = "";
            _view.Description = "";
            _view.Priority = "";
            _view.Type = "";

        }
        private void Delete(int index)
        {   
            _eventManager.Delete(index);
            
            LoadEventList();

           

        }
        private void Save()
        {
            _eventList = _eventManager.GetAll();
            _eventManager.saveToTxtFile(_eventList);

        }

        private void Read()
        {
            _eventList = _eventManager.readFromTxtFile();
            foreach (var e in _eventList)
            {
                _eventManager.Add(e);
            }
            LoadEventList();
        }

        private string DetailedDescription(int index)
        {
            _eventList = _eventManager.GetAll();
            var e = _eventList[index];
            string d = _eventManager.GetDescription(e);
            return d;

        }

        public void RowColorChange()
        {
            Color color;
            string type;
            int index = 0;
            foreach(var e in _eventManager.GetAll())
            {
                type = _eventManager.GetType(e);
                color = _eventManager.getRowColor(type);
                _view.SetRowColor(index,color);
                index++;
            }
            
            
        }
        public void Filter(string s,DateTime date)


        {
            _eventList=_eventManager.Filter(s,date);
            _eventsBindingSource.DataSource = _eventList;

            Color color;
            string type;
            int index = 0;
            foreach (var e in _eventList)
            {
                type = _eventManager.GetType(e);
                color = _eventManager.getRowColor(type);
                _view.SetRowColor(index, color);
                index++;
            }

        }
        public void Sort(string s)
        {
            _eventList = _eventManager.Sort(s);
            _eventsBindingSource.DataSource = _eventList;

            Color color;
            string type;
            int index = 0;
            foreach (var e in _eventList)
            {
                type = _eventManager.GetType(e);
                color = _eventManager.getRowColor(type);
                _view.SetRowColor(index, color);
                index++;
            }
        }
    }
}
