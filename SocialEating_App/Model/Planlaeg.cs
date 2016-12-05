using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialEating_App.Model
{
   public class Planlaeg
    {
        public string Ret { get; set; }
        public string ChefKok { get; set; }
        public string Hjaelper { get; set; }
        public string Oprydder { get; set; }

        public override string ToString()
        {
            return Ret + " \n" + ChefKok + " \n" + Hjaelper + " \n" + Oprydder + "\n";
        }
    }
}
