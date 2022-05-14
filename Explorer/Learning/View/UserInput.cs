using System;

//All calls to the user should be processed through this class

namespace Learning.View
{
	public class UserInput
	{	
		public UserInput()
		{

		}
		public static String NewElementPrompt()
        {
			String elementName = "";
			while (elementName.Length <= 0)
				try
				{
					Console.WriteLine("You have found a new element! Name it so you can add it to your field journal: ");
					String name = Console.ReadLine();
					Console.WriteLine($"Is {name} correct? [Y/N]");
					String choice = Console.ReadLine().ToUpper();
					if(choice == "Y")
                    {
						elementName = name;
                    }

				}catch (Exception ex)
                {
					Console.Write("Please enter a valid name or number");
                }
			return elementName;
        }
	}
}

