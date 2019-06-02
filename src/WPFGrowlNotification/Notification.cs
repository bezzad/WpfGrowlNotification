using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFGrowlNotification
{
    public class Notification : INotifyPropertyChanged
    {
        private string _message;
        public string Message
        {
            get => _message;

            set
            {
                if (_message == value) return;
                _message = value;
                OnPropertyChanged("Message");
            }
        }

        private int _id;
        public int Id
        {
            get => _id;

            set
            {
                if (_id == value) return;
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;

            set
            {
                if (_imageUrl == value) return;
                _imageUrl = value;
                OnPropertyChanged("ImageUrl");
            }
        }

        private string _title;
        public string Title
        {
            get => _title;

            set
            {
                if (_title == value) return;
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class Notifications : ObservableCollection<Notification> { }
}