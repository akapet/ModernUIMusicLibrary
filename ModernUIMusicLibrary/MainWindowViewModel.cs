namespace ModernUIMusicLibrary
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Songs = GetSongs();
        }

        public Songs Songs { get; set; }

        public Songs GetSongs()
        {
            return new Songs {
                new Song { Name = "Closer", Artist = "The Chainsmokers Ft. Halsey", Duration = "4:04", Album = "Closer" },
                new Song { Name = "Rendezvous", Artist = "Craig David", Duration = "3:46", Album = "Born To Do It" },
                new Song { Name = "Change Clothes ft. Pharrell", Artist = "Jay Z", Duration = "4:42", Album = "The Black Album" },
                new Song { Name = "Up & Up", Artist = "Coldplay", Duration = "4:00", Album = "A Head Full of Dreams" },
                new Song { Name = "Can't Stop The Feeling!", Artist = "Justin Timberlake", Duration = "3:56", Album = "Trolls" },
                new Song { Name = "Singles", Artist = "Bruno Mars", Duration = "3:56", Album = "24K Magic" },
            };
        }
    }
}
