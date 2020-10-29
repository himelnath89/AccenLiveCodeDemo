using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FunFridayAPI.DataAccess
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
