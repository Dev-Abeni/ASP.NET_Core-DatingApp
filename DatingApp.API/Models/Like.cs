using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Models
{
    public class Like
    {
        public User Liker { get; set; }
        public int LikerId { get; set; }
        public User Likee { get; set; }
        public int LikeeId { get; set; }
    }
}
