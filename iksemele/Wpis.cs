using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iksemele {
	public class Wpis {
		public DateTime data;
		public decimal kwota;
		public String uwagi;
		[XmlAttribute("typ")]
		public String typ;
		[XmlAttribute]
		public String id_pracownika;
		[XmlAttribute]
		public String nr_katalogowy;

		private Pracownik m_pracownik;
		[XmlIgnore]
		public Pracownik pracownik{
			get{
				return m_pracownik;
			}
			set{
				m_pracownik = value;
				id_pracownika = value.id_pracownika;
			}
		}

		private Samochod m_samochod;
		[XmlIgnore]
		public Samochod samochod {
			get {
				return m_samochod;
			}
			set {
				m_samochod = value;
				nr_katalogowy = value.numerKatalogowy;
			}
		}
	}
}
