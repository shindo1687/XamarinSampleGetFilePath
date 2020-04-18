using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SampleGetFilePath
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            System.Console.WriteLine("FileSystem.CacheDirectory=" + FileSystem.CacheDirectory);
            System.Console.WriteLine("FileSystem.AppDataDirectory=" + FileSystem.AppDataDirectory);

            System.Console.WriteLine("Environment.SpecialFolder.AdminTools=" + Environment.GetFolderPath(Environment.SpecialFolder.AdminTools));
            System.Console.WriteLine("Environment.SpecialFolder.ApplicationData=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            System.Console.WriteLine("Environment.SpecialFolder.CDBurning=" + Environment.GetFolderPath(Environment.SpecialFolder.CDBurning));
            System.Console.WriteLine("Environment.SpecialFolder.CommonAdminTools=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools));
            System.Console.WriteLine("Environment.SpecialFolder.CommonDesktopDirectory=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
            System.Console.WriteLine("Environment.SpecialFolder.CommonDocuments=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
            System.Console.WriteLine("Environment.SpecialFolder.CommonMusic=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
            System.Console.WriteLine("Environment.SpecialFolder.CommonOemLinks=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonOemLinks));
            System.Console.WriteLine("Environment.SpecialFolder.CommonPictures=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
            System.Console.WriteLine("Environment.SpecialFolder.CommonProgramFiles=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
            System.Console.WriteLine("Environment.SpecialFolder.CommonProgramFilesX86=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
            System.Console.WriteLine("Environment.SpecialFolder.CommonPrograms=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
            System.Console.WriteLine("Environment.SpecialFolder.CommonStartMenu=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu));
            System.Console.WriteLine("Environment.SpecialFolder.CommonStartup=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup));
            System.Console.WriteLine("Environment.SpecialFolder.CommonTemplates=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates));
            System.Console.WriteLine("Environment.SpecialFolder.CommonVideos=" + Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
            System.Console.WriteLine("Environment.SpecialFolder.Cookies=" + Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            System.Console.WriteLine("Environment.SpecialFolder.Desktop=" + Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            System.Console.WriteLine("Environment.SpecialFolder.DesktopDirectory=" + Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            System.Console.WriteLine("Environment.SpecialFolder.Favorites=" + Environment.GetFolderPath(Environment.SpecialFolder.Favorites));
            System.Console.WriteLine("Environment.SpecialFolder.Fonts=" + Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
            System.Console.WriteLine("Environment.SpecialFolder.History=" + Environment.GetFolderPath(Environment.SpecialFolder.History));
            System.Console.WriteLine("Environment.SpecialFolder.InternetCache=" + Environment.GetFolderPath(Environment.SpecialFolder.InternetCache));
            System.Console.WriteLine("Environment.SpecialFolder.LocalApplicationData=" + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            System.Console.WriteLine("Environment.SpecialFolder.LocalizedResources=" + Environment.GetFolderPath(Environment.SpecialFolder.LocalizedResources));
            System.Console.WriteLine("Environment.SpecialFolder.MyComputer=" + Environment.GetFolderPath(Environment.SpecialFolder.MyComputer));
            System.Console.WriteLine("Environment.SpecialFolder.MyDocuments=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            System.Console.WriteLine("Environment.SpecialFolder.MyMusic=" + Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            System.Console.WriteLine("Environment.SpecialFolder.MyPictures=" + Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            System.Console.WriteLine("Environment.SpecialFolder.MyVideos=" + Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
            System.Console.WriteLine("Environment.SpecialFolder.NetworkShortcuts=" + Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts));
            System.Console.WriteLine("Environment.SpecialFolder.Personal=" + Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            System.Console.WriteLine("Environment.SpecialFolder.PrinterShortcuts=" + Environment.GetFolderPath(Environment.SpecialFolder.PrinterShortcuts));
            System.Console.WriteLine("Environment.SpecialFolder.ProgramFiles=" + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            System.Console.WriteLine("Environment.SpecialFolder.ProgramFilesX86=" + Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            System.Console.WriteLine("Environment.SpecialFolder.Programs=" + Environment.GetFolderPath(Environment.SpecialFolder.Programs));
            System.Console.WriteLine("Environment.SpecialFolder.Recent=" + Environment.GetFolderPath(Environment.SpecialFolder.Recent));
            System.Console.WriteLine("Environment.SpecialFolder.Resources=" + Environment.GetFolderPath(Environment.SpecialFolder.Resources));
            System.Console.WriteLine("Environment.SpecialFolder.SendTo=" + Environment.GetFolderPath(Environment.SpecialFolder.SendTo));
            System.Console.WriteLine("Environment.SpecialFolder.StartMenu=" + Environment.GetFolderPath(Environment.SpecialFolder.StartMenu));
            System.Console.WriteLine("Environment.SpecialFolder.Startup=" + Environment.GetFolderPath(Environment.SpecialFolder.Startup));
            System.Console.WriteLine("Environment.SpecialFolder.System=" + Environment.GetFolderPath(Environment.SpecialFolder.System));
            System.Console.WriteLine("Environment.SpecialFolder.SystemX86=" + Environment.GetFolderPath(Environment.SpecialFolder.SystemX86));
            System.Console.WriteLine("Environment.SpecialFolder.Templates=" + Environment.GetFolderPath(Environment.SpecialFolder.Templates));
            System.Console.WriteLine("Environment.SpecialFolder.UserProfile=" + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            System.Console.WriteLine("Environment.SpecialFolder.Windows=" + Environment.GetFolderPath(Environment.SpecialFolder.Windows));
        }
    }
}
