using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace iksemele {
	public class Komis {
		[XmlArray]
		[XmlArrayItem(ElementName = "student")]
		public List<String> authors { get; set; }
		public Dane dane { get; set; }
	}
}
