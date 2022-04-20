using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using combobox.Annotations;

namespace combobox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private List<string> _property;
        private string _dummyText;

        public List<string> ComboItemsList
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(ComboItemsList));
            }
        }

        public int SelectedIndex { get; set; } = 3;

        public string DummyText
        {
            get => _dummyText;
            set
            {
                _dummyText = value;
                OnPropertyChanged(nameof(DummyText));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _property = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            DummyText = "Blah";
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
