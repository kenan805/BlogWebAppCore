using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Models
{
    public class WriterRegisterViewModel
    {
        public List<City> Cities { get; set; }
        public Writer Writer { get; set; }
    }
}
