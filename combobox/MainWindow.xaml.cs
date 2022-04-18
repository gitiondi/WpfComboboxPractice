using System.Collections.Generic;
using System.Windows;

namespace combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> _property;

        public List<string> ComboItemsList
        {
            get => _property;
            set =>  _property = value;
        }

        public MainWindow()
        {
            InitializeComponent();
            _property = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            DataContext = this;
        }
    }
}
