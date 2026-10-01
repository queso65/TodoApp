using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
		private bool myVar;

		public bool MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

	}
}
