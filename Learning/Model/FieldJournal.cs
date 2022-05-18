using System;
namespace Learning.Model
{
	public class FieldJournal
	{
		private List<SolidElement> KnownElements = new List<SolidElement>();
		private List<Creatures> KnownCreatures = new List<Creatures>();
		private List<LiquidElement> KnownLiquids = new List<LiquidElement>();
		private List<GaseousElement> KnownGases = new List<GaseousElement>();
		private List<Flora> KnownFlorae = new List<Flora>();
		

		public List<SolidElement> GetKnownElements()
        {
			return KnownElements;
        }
		public void SetKnownElements(SolidElement newElement)
        {
			KnownElements.Add(newElement);
        }

		public FieldJournal()
		{
		
		}
	}

	
}

