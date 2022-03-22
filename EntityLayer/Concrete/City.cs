using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Concrete
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
    }
}