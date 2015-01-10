using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iksemele {
	public class DaneTechniczne {
		public Paliwo paliwo;
		public double pojemnoscSilnika;
		public String typ;
		public int rocznik;
	}

	public enum Paliwo {
		benzyna,
		diesel,
		lpg
	}
}
