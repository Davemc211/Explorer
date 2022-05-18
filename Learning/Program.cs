using Learning.Model;

FieldJournal journal = new FieldJournal();
SolidElement newElement = new SolidElement();

newElement.MakeRandomElement(journal);
foreach (var element in journal.GetKnownElements())
{
    Console.Write(element.ToString());
}


