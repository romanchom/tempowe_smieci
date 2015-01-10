using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace iksemele {
	public class Content {
		[XmlArrayItem(ElementName = "pracownik")]
		public List<Pracownik> personel { get; set; }


		[XmlArray("stan-aktualne")]
		[XmlArrayItem(ElementName = "samochód")]
		public List<Samochod> stan_aktualne { get; set; }

		[XmlArray("stan-archiwum")]
		[XmlArrayItem(ElementName = "samochód")]
		public List<Samochod> stan_archiwum { get; set; }

		[XmlArray("operacje")]
		[XmlArrayItem(ElementName = "wpis")]
		public List<Wpis> operacje { get; set; }
	}
}
