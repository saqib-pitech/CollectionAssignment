using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    public class Customer
    {
		// CustomerName, City, Country
		private string customerName;

		public string CustomerName
		{
			get { return customerName; }
			set { customerName = value; }
		}
		private string city;

		public string City
		{
			get { return city; }
			set { city = value; }
		}
		private string country;


		public string Country
		{
			get { return country; }
			set { country = value; }
		}
		#region ctor
		public Customer(string pcustomerName, string pcity, string pcountry)
		{
			this.CustomerName = pcustomerName;
			this.City = pcity;
			this.Country = pcountry;
		}
		#endregion
		public override string ToString()
		{
			return string.Format($"{CustomerName}, {City}, {Country}");
		}

	}


}
