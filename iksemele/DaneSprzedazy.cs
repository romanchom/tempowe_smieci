using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iksemele {
	public class DaneSprzedazy {
		public decimal cena;
		[XmlElement("na_raty")]
		public NaRaty naRaty;
	}

	public enum NaRaty {
		tak,
		nie
	}
}
