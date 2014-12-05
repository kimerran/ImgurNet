using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likja.ImgurNet.Models
{
    public class TagVote : Vote
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
