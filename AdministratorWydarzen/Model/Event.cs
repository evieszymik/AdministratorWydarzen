using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorWydarzen.Model
{
    public class Event
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
        public string type { get; set; }
        public string priority { get; set; }
        public override string ToString()
        {
            return $"Title: {title}; description: {description}; date: {date.ToShortDateString()}; type: {type}; priority: {priority}";
        }
        public Event(string ti, string des, DateTime da, string ty, string p)
        {
            title = ti;
            description = des;
            date = da;
            type = ty;
            priority = p;
            
        }
       
        public Event(string ti, DateTime da, string p)
        {
            title = ti;
            date = da;
            priority = p;

        }
        public Event() { }
        
    }
    
}
