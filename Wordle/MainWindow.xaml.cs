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
        WordDict.StartGameClick += ViewGame;
        WordDict.ClickMainMenu += ViewMenu;
        
        WordDict.GameLost += FocusGrid;
        WordDict.GameWon += FocusGrid;
        WordDict.LanguageChanged += LanguageChange;
       
    }
    bool languageCheck = true;
    void FocusGrid()
    {
        Debug.WriteLine("FocusGrid");
        GridName.Focus();
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
        if (languageCheck)
        {
            MainContent.Content = new View.UserControls.GameEng();
        }
        else if (!languageCheck)
        {
            MainContent.Content = new View.UserControls.GameGer();

        }
    }
    private void ViewMenu()
    {
        MainContent.Content = new View.UserControls.Menu();
    }
   private void LanguageChange()
    {
        languageCheck = !languageCheck;
    }
}