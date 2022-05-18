using System;
namespace Learning.Model
{
	public abstract class Element
	{
		
		private int mass { get; set; }

		private double density { get; set; }

		private string color;
		
		private string stateOfMatter;

		public string StateOfMatter1
		{
			get => stateOfMatter;
			set => stateOfMatter = value ?? throw new ArgumentNullException(nameof(value));
		}

		private string notes;
		
		public int Conductivity { get; set; }

		public int Magnetism { get; set; }

		public int MeltingPoint { get; set; }

		public int BoilingPoint { get; set; }

		public string Color
		{
			get => color;
			set => color = value ?? throw new ArgumentNullException(nameof(value));
		}

		public string StateOfMatter
		{
			get => stateOfMatter;
			set => stateOfMatter = value ?? throw new ArgumentNullException(nameof(value));
		}

		public string Notes
		{
			get => notes;
			set => notes = value ?? throw new ArgumentNullException(nameof(value));
		}

	}
}

