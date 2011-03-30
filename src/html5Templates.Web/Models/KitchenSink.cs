using System;
using System.ComponentModel.DataAnnotations;

namespace html5Templates.Web.Models
{
    public class KitchenSink
    {
        /* Note: [DataType("TemplateName")] and Mvc's [UIHint("TemplateName")] are equivalent for our purposes */

        public string RegularString { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType("Search")]
        public string Search { get; set; }

        //[DataType(DataType.DateTime)] //Redundant
        public DateTime DateTime { get; set; }
        
        [DataType("DateTime-Local")]
        public DateTime DateTimeLocal { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOnly { get; set; }

        [DataType(DataType.Time)]
        public string TimeOnly { get; set; }

        [DataType("Month")]
        public string Month { get; set; }

        [DataType("Week")]
        public string Week { get; set; }

        [DataType("Number")] //On Opera number uses a spinbox, so this will only work with integers
        public int Number { get; set; }

        [DataType("Color")]
        public string Color { get; set; }
    }
}