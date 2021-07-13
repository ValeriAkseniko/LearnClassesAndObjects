using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects.Boxes
{
    public class Box
    {
        public int Id { get; set; }
        public Size Size { get; set; }
        public ColorBox Color { get; set; }
        public FormBox Form { get; set; }

    }

}
