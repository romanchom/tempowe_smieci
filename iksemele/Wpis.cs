using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iksemele {
	public class Wpis {
		[XmlIgnore]
		private DateTime data { get; set; }
		[XmlElement("data")]
		public string psudoData {
			get {
				return data.ToString("yyyy-MM-dd");
			}
			set {
				data = DateTime.Parse(value);
			}
		}
		public decimal kwota { get; set; }
		public String uwagi { get; set; }
		[XmlAttribute("typ")]
		public String typ { get; set; }
		[XmlAttribute]
		public String id_pracownika { get; set; }
		[XmlAttribute]
		public String nr_katalogowy { get; set; }
		/*
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
		}*/
	}
}
