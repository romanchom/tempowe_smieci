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
			XmlSerializer ser = new XmlSerializer(typeof(Komis), "http://www.pkck.com");
			using (StreamReader i = new StreamReader("komis.xml")) {
				k = (Komis)ser.Deserialize(i);
				System.Console.Write("ASDSADA");
			}
			InitializeComponent();
			PersonelDataGrid.ItemsSource = k.dane.content.personel;
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			System.Console.Write("ASDSADA");

		}
	}
}
