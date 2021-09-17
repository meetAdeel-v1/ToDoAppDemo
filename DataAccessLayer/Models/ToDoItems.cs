using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ToDoItems
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ToDoList")]
        public int ToDoID { get; set; }

    }
}
