using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SoundEffect
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            //var assembly = typeof(App).GetTypeInfo().Assembly;
            //Stream audioStream = assembly.GetManifestResourceStream("YourSharedAssemblyName." + "yoursound.wav");
            //var alertSound = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            //alertSound.Load(audioStream);
            //alertSound.Play();
            InitializeComponent();
        }
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("SoundEffect." + filename);

            return stream;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            var folder = "Techno";
            player.Load(GetStreamFromFile($"Audio.{folder}.clap.wav"));
            player.Play();
        }
    }
}
