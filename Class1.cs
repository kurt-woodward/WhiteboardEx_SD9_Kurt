using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9_Kurt
{
	public class Class1
	{ 
		public int publicField = 0;
		private int privateField = 0;

		public Class1()
		{
			this.publicField = 0;
			this.privateField = 0;

		}

		public Class1(int arg1, int arg2)
		{
			this.publicField = arg1;
			this.privateField = arg2;
		}
		public void Deconstruct(out int publicField, out int privateField)
		{
            publicField = this.publicField;
			privateField = this.privateField;
		}
	}
}
