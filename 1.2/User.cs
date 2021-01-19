using System.Collections.Generic;

namespace _1._2
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public System.Collections.Generic.List<string> Languages { get; set; }
        public User()
        {
            Languages = new List<string>();
        }
    }
}
