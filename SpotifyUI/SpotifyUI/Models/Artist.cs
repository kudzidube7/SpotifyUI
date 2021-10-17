using Xamarin.Forms;

namespace SpotifyUI.Models
{
    public class Artist
    {
        public string ImageUrl {get;set;}
        public string Name { get; set; }
        //The below property will be used later
        public Color AlbumColor { get; set; }
        public string Contributors { get; set; }
    }
}
