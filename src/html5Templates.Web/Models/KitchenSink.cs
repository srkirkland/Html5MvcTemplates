using System.ComponentModel.DataAnnotations;

namespace html5Templates.Web.Models
{
    public class KitchenSink
    {
        public string RegularString { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType("Search")]
        public string Search { get; set; }
    }
}