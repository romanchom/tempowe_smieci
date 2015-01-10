using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iksemele {
	public class DaneTechniczne {
		public Paliwo paliwo;
		[XmlElement("pojemność_silnika")]
		public decimal pojemnoscSilnika;
		public String typ;
		public int rocznik;
	}

	public enum Paliwo {
		benzyna,
		diesel,
		lpg
	}
}
