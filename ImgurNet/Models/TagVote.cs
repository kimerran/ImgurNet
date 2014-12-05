using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurNet.Models
{
    public class TagVote : Vote
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
