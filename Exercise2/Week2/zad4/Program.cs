using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class UserSettings
    {
        public string Language { get; set; }
        public string Threme { get; set; }
        public string Font{ get; set; }
    }

     static void UpdateProfile(ref UserSettings user1, UserSettings user2)
    {
        user1.Language = user2.Language;
        user1.Threme = user2.Threme;
        user1.Font = user2.Font;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserSettings profile = new UserSettings { Language = "English", Threme = "Dark", Font = "Arial" };

        }
    }
}
