

using System.ComponentModel;
using System.Runtime.CompilerServices;
using Doctriod.Annotations;
using Prism.Mvvm;

namespace Doctriod.Models
{
    public class MenuItem: INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string Page { get; set; }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                IsNotActive = !value;
                OnPropertyChanged(nameof(IsActive));
            }
        }

        private bool _isNotActive;
        public bool IsNotActive
        {
            get { return _isNotActive; }
            set
            {
                _isNotActive = value;
                OnPropertyChanged(nameof(IsNotActive));
            }
        }
        
        public bool IsFirst { get; set; }

        public bool MustBeLoggedIn { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
