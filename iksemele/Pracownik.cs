using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iksemele {
	public class Pracownik {
		public String imie{ get; set; }
		public String nazwisko { get; set; }
		[XmlAttribute]
		public String id_pracownika { get; set; }
	}
}
