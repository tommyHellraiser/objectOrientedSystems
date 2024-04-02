using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVController
{
	internal class Television
	{
		private string brand;
		private string model;
		private int inches;
		private bool power;
		private int current_channel;
		internal List<Person> owners { get; set; }
		internal HomeData home_data { get; set; }

		public Television(string brand, string model, int inches, List<Person> owners, HomeData home_data)
		{
			this.brand = brand;
			this.model = model;
			this.inches = inches;
			this.power = false;
			this.current_channel = 1;
			this.owners = owners;
			this.home_data = home_data;
		}

		/// <summary>
		/// Returns the current channel of the tv
		/// </summary>
		public int getCurrentChannel()
		{
			return this.current_channel;
		}

		/// <summary>
		/// Increments the channel by one. If it reaches the limit of 150 channels, returns to number 1 to continue
		/// </summary>
		public void incrementChannel()
		{
			if (this.current_channel == 150)
			{
				this.current_channel = 1;
			}
			else
			{
				this.current_channel++;
			}
		}

		/// <summary>
		/// Changes channel using parameter new_channel
		/// </summary>
		/// <param name="new_channel"></param>
		public bool changeToChannel(int new_channel)
		{
			if (new_channel > 150 || new_channel < 1)
			{
				throw new ArgumentException("Invalid channel number. Please enter a valid number");
			}

			this.current_channel = new_channel;

			return true;
		}

		/// <summary>
		/// Returns true if TV is turned on, returns false otherwise
		/// </summary>
		public bool isTvOn()
		{
			return this.power;
		}

		public void togglePower()
		{
			if (this.power)
			{
				this.power = false;
			} else
			{
				this.power = true;
			}
		}

		public Person getPersonByName(string name)
		{
			foreach (Person person in owners)
			{
				if (person.name == name)
				{
					return person;
				}
			}

			throw new IndexOutOfRangeException($"No owner found for name: {name}");
		}
	}
}
