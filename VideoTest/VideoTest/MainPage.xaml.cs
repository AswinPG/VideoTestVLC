using LibVLCSharp.Forms.Sample.MediaPlayerElement;
using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VideoTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((MainViewModel)BindingContext).OnAppearing();
        }

        private void VideoView_MediaPlayerChanged(object sender, MediaPlayerChangedEventArgs e)
        {
            //((MainViewModel)BindingContext).OnVideoViewInitialized();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MainVideoPlayer.MediaPlayer.ToggleFullscreen();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (MainVideoPlayer.MediaPlayer.IsPlaying)
            {
                MainVideoPlayer.MediaPlayer.Pause();
            }
            else MainVideoPlayer.MediaPlayer.Play();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

            MainVideoPlayer.MediaPlayer.Position = MainVideoPlayer.MediaPlayer.Position + 0.1F;
        }
    }
}
