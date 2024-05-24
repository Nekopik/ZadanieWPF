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
using System.Windows.Shapes;
using ZadanieWPF.Access;
using ZadanieWPF.Model;
using ZadanieWPF.Service;

namespace ZadanieWPF
{
    
    /// <summary>
    /// Interaction logic for ReadNoteWindow.xaml
    /// </summary>
    public partial class ReadNoteWindow : Window
    {
        // var noteFromDatabase = YourDatabase.ReadNote();
        // Note = new ObservableCollection<NoteDto>(noteFromDatabase);
        public ReadNoteWindow()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
