using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVController
{
	internal class Home
	{
		string address;
		List<Person> residents;

		Home(string address, List<Person> residents)
		{
			this.address = address;
			this.residents = residents;
		}
	}
}
