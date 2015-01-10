using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iksemele {
	public class Samochod {
		[XmlElement("dane_ogólne")]
		public DaneOgolne daneOgolne;
		[XmlElement("dane_sprzedaży")]
		public DaneSprzedazy daneSprzedazy;
		[XmlElement("dane_techniczne")]
		public DaneTechniczne daneTechniczne;
		[XmlAttribute("nr_katalogowy")]
		public String numerKatalogowy;
	}
}
