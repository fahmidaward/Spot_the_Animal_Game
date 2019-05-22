using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class game
    {



        public String ImagePath
        {
            get
            {
                return "C:/Users/fahmi/source/repos/WebApplication1/WebApplication1/Content/images";
            }

        }
        public int Id {get; set;}
        public string Str { get; set; }
        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public int Count { get; set; }
        public int Totalcount { get; set; }
        public int Round { get; set; }
    }
}