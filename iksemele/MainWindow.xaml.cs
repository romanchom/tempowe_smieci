using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace iksemele {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		Komis k;
		List<Pracownik> personel;
		public MainWindow() {
			
			InitializeComponent();
			
		}

		private void Wczytaj(object sender, RoutedEventArgs e) {
			Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".xml";
			dlg.Filter = "XML Files (*.xml)|*.xml";

			// Display OpenFileDialog by calling ShowDialog method 
			bool? result = dlg.ShowDialog();

			// Get the selected file name and display in a TextBox 
			if (result == true) {
				// Open document 
				string filename = dlg.FileName;
				XmlSerializer ser = new XmlSerializer(typeof(Komis), "http://www.pkck.com");
				using (StreamReader i = new StreamReader(filename)) {
					k = (Komis)ser.Deserialize(i);
				}
				PersonelDataGrid.ItemsSource = k.dane.content.personel;
				OperacjeDataGrid.ItemsSource = k.dane.content.operacje;
				AktualneDataGrid.ItemsSource = k.dane.content.stan_aktualne;
				ArchiwumDataGrid.ItemsSource = k.dane.content.stan_archiwum;
			}
		}

		private void Zapisz(object sender, RoutedEventArgs e) {
			Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

			// Set filter for file extension and default file extension 
			dlg.DefaultExt = ".xml";
			dlg.Filter = "XML Files (*.xml)|*.xml";

			// Display OpenFileDialog by calling ShowDialog method 
			bool? result = dlg.ShowDialog();

			// Get the selected file name and display in a TextBox 
			if (result == true) {
				// Open document 
				string filename = dlg.FileName;
				XmlSerializer ser = new XmlSerializer(typeof(Komis), "http://www.pkck.com");
				using (StreamWriter o = new StreamWriter(filename)){
					ser.Serialize(o, k);
				}
			}
		}
	}
}
