using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace HaloWaypoint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            PopulateNewsPosts();
        }

        private void PopulateNewsPosts()
        {
            List<NewsPost> newsPosts = new List<NewsPost>();
            newsPosts.Add(new NewsPost()
            {
                Title = "INSIDE INFINITE",
                Type = "HALO INFINITE",
                TypeId = 1,
                Author = "BY " + "343 INDUSTRIES",
                DatePosted = new DateTime(2021, 10, 28),
                Thumbnail = "Assets/insideInfinite.jpg",
                Text = "Welcome to our latest installment of Inside Infinite – our monthly blog series devoted to celebrating some of the tremendous work happening to bring Halo Infinite to life. So much has happened since we kicked this off back in December and we’re so grateful to have you with us on this journey. We’ve covered a lot of ground together over the past 9 months digging into Halo Infinite’s development and getting to know some of the talented people across the team. We’re super eager to be in the final stretch now, with our December 8 launch quickly approaching, but there are still stories to be told."
            });

            news.Source = newsPosts;
        }
    }

    public class News
    {
        public News()
        {
            NewsPosts = new ObservableCollection<NewsPost>();
        }

        public ObservableCollection<NewsPost> NewsPosts { get; private set; }
    }

    public class NewsPost
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public string Text { get; set; }
        public string Thumbnail { get; set; }
    }
}