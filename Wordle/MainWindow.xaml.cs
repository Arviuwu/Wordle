using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using Wordle.Classes;

namespace Wordle;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
        MainContent.Content = new View.UserControls.Menu();
        WordDict.InitializeDict();
        
        WordDict.StartGameClick += ViewGame;
        WordDict.ClickMainMenu += ViewMenu;

    }
    
    private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {
        
        if (e.Key == Key.Tab)
        {
            e.Handled = true;
        }
        
    }
    private void ViewGame()
    {
        MainContent.Content = new View.UserControls.GameEng();
    }

    private void ViewMenu()
    {
        MainContent.Content = new View.UserControls.Menu();
    }
    
}