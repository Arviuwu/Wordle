using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Wordle;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();   
        
    }

    private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {
        if(e.Key == Key.Enter)
        {
            Debug.WriteLine("window word guess: " + Inputline0.WordGuess);
            Inputline0.
        }
        
    }
}