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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
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

		private void Wczytaj(object sender, RoutedEventArgs ev) {
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
				XDocument doc = XDocument.Load(filename);
				
				if (!Validate(doc)) return;

				using (XmlReader reader = doc.CreateReader()) {
					XmlSerializer ser = new XmlSerializer(typeof(Komis), "http://www.pkck.com");
					k = (Komis)ser.Deserialize(reader);
				}
				PersonelDataGrid.ItemsSource = k.dane.content.personel;
				OperacjeDataGrid.ItemsSource = k.dane.content.operacje;
				AktualneDataGrid.ItemsSource = k.dane.content.stan_aktualne;
				ArchiwumDataGrid.ItemsSource = k.dane.content.stan_archiwum;
			}
		}

		private void Zapisz(object sender, RoutedEventArgs ev) {
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
				XDocument doc = new XDocument();
				using(XmlWriter writer = doc.CreateWriter()){
					XmlSerializer ser = new XmlSerializer(typeof(Komis), "http://www.pkck.com");
					ser.Serialize(writer, k);
				}
				if (!Validate(doc)) return;
				doc.Save(filename);
			}
		}

		private bool Validate(XDocument doc) {
			XmlSchemaSet schemas = new XmlSchemaSet();
			using (StreamReader schema = new StreamReader("komis.xsd")) {
				schemas.Add("http://www.pkck.com", XmlReader.Create(schema));
			}
			bool hasErrors = false;
			doc.Validate(schemas, (o, e) => {
				if (e.Severity == XmlSeverityType.Error) {
					MessageBox.Show(e.Message, "Schema validation error", MessageBoxButton.OK, MessageBoxImage.Error);
					hasErrors = true;
				}
				else {
					MessageBox.Show(e.Message, "Schema validation warning", MessageBoxButton.OK, MessageBoxImage.Warning);
				}
			});
			if (hasErrors) {
				MessageBox.Show("Xml ma błędy.", "Błąd.", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			return !hasErrors;
		}
	}
}
