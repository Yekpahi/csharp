using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WFPHelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Je suis ici pour la paix ";
            textBlock.Inlines.Add("This is added using Inlines!");
            textBlock.Inlines.Add(new Run(" Run text that I added in Code behind")
            {
                Foreground = Brushes.Red,
                TextDecorations = TextDecorations.Underline
            });
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Foreground = Brushes.BurlyWood;
            this.Content = textBlock;
        }

    }
}
