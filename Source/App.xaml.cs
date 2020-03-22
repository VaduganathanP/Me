using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Me
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    EventManager.RegisterClassHandler(typeof(TextBox), UIElement.GotFocusEvent, new RoutedEventHandler(SelectAllText), true);
        //    base.OnStartup(e);
        //}

        //private static void SelectAllText(object sender, RoutedEventArgs e)
        //{
        //    var textBox = e.OriginalSource as TextBox;
        //    if (textBox != null)
        //        textBox.SelectAll();
        //}
    }
}
