using SpotifyUI.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Color = Xamarin.Forms.Color;

namespace SpotifyUI
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private ObservableCollection<Artist> _artists;
        public ObservableCollection<Artist> Artists
        {
            get { return _artists; }
            set
            {
                _artists = value;
                OnPropertyChanged("Artists");
            }
        }

        private ObservableCollection<Artist> _somethingNew;
        public ObservableCollection<Artist> SomethingNew
        {
            get { return _somethingNew; }
            set
            {
                _somethingNew = value;
                OnPropertyChanged("SomethingNew");
            }
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            Artists = new ObservableCollection<Artist>()
            {
                new Artist{ImageUrl = "https://bit.ly/3B22R1J", Name = "Maroon 5 mix" , Contributors = "Christina Aguilera, Jason Mraz, Clean Bandit, Beyonce and may others", AlbumColor = Color.AliceBlue },
                new Artist{ImageUrl =  "https://cutt.ly/HRud7vq", Name = "RnB" , Contributors = "Turn to one, lil wayne, the weekened Beyonce and many others",  AlbumColor = Color.YellowGreen},
                 new Artist{ImageUrl = "https://cutt.ly/1RufjXC", Name = "New Hip hop" , Contributors = "Da Baby , wiz Kid, Burna Boy, Davido, and may others",  AlbumColor = Color.Wheat},
                 new Artist{ImageUrl =  "https://cutt.ly/QRufrwI", Name = "Hip hop mix" , Contributors = "Kanye west, Jay cole, Jay z , Nas and may others",  AlbumColor = Color.LightCyan},
            };

            SomethingNew = new ObservableCollection<Artist>()
            {
                new Artist{ImageUrl = "https://bit.ly/3B22R1J", Name = "Soft Pop" , Contributors = "Sandy Leah, The design, spanky, bobby & Blumm and many others", AlbumColor = Color.AliceBlue },
                new Artist{ImageUrl =  "https://cutt.ly/HRud7vq", Name = "Reggae" , Contributors = "Damian Marley, Bob marley, vibes Kartel, buffalo Soldier and many others",  AlbumColor = Color.YellowGreen},
                 new Artist{ImageUrl = "https://cutt.ly/1RufjXC", Name = "Classic Hip hop" , Contributors = "Dr Dre, 50 cent, Eminem, Biggy Small, Tupac and many others",  AlbumColor = Color.Wheat},
                 new Artist{ImageUrl =  "https://cutt.ly/QRufrwI", Name = "New School" , Contributors = "Lil baby, lil yatchy, da baby, jack harlow and many others",  AlbumColor = Color.LightCyan},
            };
        }

    }
}
