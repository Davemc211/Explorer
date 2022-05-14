using System;
namespace Learning.Model
{
	public class FieldJournal
	{
		private List<SolidElement> KnownElements = new List<SolidElement>();
		private List<Creatures> KnownCreatures = new List<Creatures>();
		

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

