using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smert
{
    class Event
    {
        [Key]
        public int e_id { get; set; }

        private string style, date, time, teacher, type;

        public string Style {
            get { return style; }    
            set { style = value; }  
            }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Event() { }

        public Event( string style, string date, string time, string teacher, string type)
        {
            this.style = style;
            this.date = date;
            this.time = time;
            this.teacher = teacher;
            this.type = type;
        }   

    }
}
