using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Accessibility
{
    public partial class listpage : ContentPage
    {
        public listpage()
        {
            InitializeComponent();
            ObservableCollection<DetailEvent> names = new ObservableCollection<DetailEvent>();
            for (int i = 0; i < 10; i++)
            {
                names.Add(new DetailEvent
                {
                    Name = "items" + i.ToString()
                });
            }
            stringlist.ItemsSource = names;
        }

        void SwipeItemView_Invoked(System.Object sender, System.EventArgs e)
        {
        }
    }

    public class DetailEvent : INotifyPropertyChanged
    {

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
