using System;
using System.Data.SqlClient;
using Learning.Model;

namespace Learning.DAO
{
	public interface IJournalDAO
	{
		public List<SolidElement> GetKnownElements();
		public void AddNewElement(SolidElement newElement);

		public List<Creatures> GetKnownCreatures();
		public void AddNewCreature(Creatures newCreature);

		public List<Flora> GetKnownFlora();
		public void AddNewFlora(Flora newPlant);

		public List<GaseousElement> GetKnownGases();
		public void AddNewGas(GaseousElement newGas);

		public List<LiquidElement> GetKnownLiquids();
		public void AddNewLiquid(LiquidElement newLiquid);
		
	}
}

