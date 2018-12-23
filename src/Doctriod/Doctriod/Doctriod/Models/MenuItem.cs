

namespace Doctriod.Models
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string Page { get; set; }
        public bool IsActive { get; set; }

        public bool IsNotActive
        {
            get { return !IsActive; }
        }

        public bool IsFirst { get; set; }

        public bool MustBeLoggedIn { get; set; }
    }
}
