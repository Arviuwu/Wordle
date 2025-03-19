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
        WordDict.InitializeDict();
        
    }

    private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
    {
        if(e.Key == Key.Enter)
        {
            Debug.WriteLine("window word guess: " + Inputline0.WordGuess);
            
        }
        
    }
    
}