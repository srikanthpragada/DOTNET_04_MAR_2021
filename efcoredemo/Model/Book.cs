using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Author { get; set; }
        public int Price { get; set; }

        public virtual List<Chapter> Chapters { get; set; }
    }


}
