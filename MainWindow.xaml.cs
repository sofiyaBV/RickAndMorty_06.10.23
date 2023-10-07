
using RickAndMorty_API_CORE.Data.API;
using RickAndMorty_API_CORE.Domain.Models;
using RickAndMorty_API_CORE.Domain.ProviderJson;
using System.Collections.Generic;
using System.Windows;

namespace RickAndMorty_06._10._23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //    private int page = 1;
        //    private RAM_API_ENGINE engine { set; get; }
        //    private List<Character> character { get; set; }
        //    public MainWindow()
        //    {
        //        InitializeComponent();
        //        engine = new RAM_API_ENGINE();
        //    }
        //    private async void UpdatePage()
        //    {
        //        LV.ItemsSource = null;
        //        var pageResult = engine.GetPage(this.page);
        //        character = JsonProvider.FromJsonToCharacterList(pageResult);
        //        LV.ItemsSource = character;
        //        LV.Items.Refresh();
        //    }

        //    private void Window_Loaded(object sender, RoutedEventArgs e)
        //    {
        //        UpdatePage();
        //    }

        //    private void Button_Click_Prev(object sender, RoutedEventArgs e)
        //    {
        //        if (page != 1)
        //        {
        //            page--;
        //            UpdatePage();
        //        }
        //    }

        //    private void Button_Click_Next(object sender, RoutedEventArgs e)
        //    {
        //        page++;
        //        UpdatePage();
        //    }
        //}
    }
}
