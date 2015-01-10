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
		public String numerKatalogowy { get; set; }
	
		[XmlIgnore]
		public String marka { get { return daneOgolne.marka; } set { daneOgolne.marka = value; } }
		[XmlIgnore]
		public String model { get { return daneOgolne.model; } set { daneOgolne.model = value; } }
		[XmlIgnore]
		public String kolor { get { return daneOgolne.kolor; } set { daneOgolne.kolor = value; } }


		[XmlIgnore]
		public decimal cena { get { return daneSprzedazy.cena; } set { daneSprzedazy.cena = value; } }
		[XmlIgnore]
		public NaRaty naRaty { get { return daneSprzedazy.naRaty; } set { daneSprzedazy.naRaty = value; } }


		[XmlIgnore]
		public Paliwo paliwo { get { return daneTechniczne.paliwo; } set { daneTechniczne.paliwo = value; } }
		[XmlIgnore]
		public decimal pojemnoscSilnika { get { return daneTechniczne.pojemnoscSilnika; } set { daneTechniczne.pojemnoscSilnika = value; } }
		[XmlIgnore]
		public String typ { get { return daneTechniczne.typ; } set { daneTechniczne.typ = value; } }
		[XmlIgnore]
		public int rocznik { get { return daneTechniczne.rocznik; } set { daneTechniczne.rocznik = value; } }
	}
}
