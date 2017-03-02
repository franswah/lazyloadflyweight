using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LazyLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            groups.Add(new Group("Penapple"));
            groups.Add(new Group("Scribblers"));
            String s;

            do
            {
                Console.WriteLine("Enter 1 for Lazy Load demo, 2 for Flyweight demo:");
                s = Console.ReadLine();

                try
                {
                    if (int.Parse(s) == 1)
                    {
                        do
                        {
                            Console.Write("Available groups: ");
                            groups.ForEach(g => Console.Write(g.id + " "));
                            Console.WriteLine("\nEnter group name to see messages or 0 to go back: ");
                            s = Console.ReadLine();

                            Group choice = groups.Find(g => g.id == s.Trim());

                            if (choice != null)
                            {
                                Console.WriteLine("Getting messages...\n");
                                choice.getMessages().ForEach(Console.WriteLine);
                            }
                        } while (s != "0" && s != null);
                        
                    }
                    else if (int.Parse(s) == 2)
                    {
                        CharacterFactory factory = new CharacterFactory();
                        List<IFWCharacter> characters = new List<IFWCharacter>();
                        List<Boolean> uppers = new List<bool>();
                        Console.WriteLine("Compose a message (no punctuation):");
                        s = Console.ReadLine();
                        foreach (Char c in s)
                        {
                            characters.Add(factory.getCharacter(c));
                            uppers.Add(Char.IsUpper(c));
                        }

                        do
                        {
                            Console.WriteLine("\nEnter 1 to print message back, 2 to display number of Character objects created, 0 to go back.");
                            s = Console.ReadLine();
                            try
                            {
                                if (int.Parse(s) == 1)
                                {
                                    int idx = 0;
                                    foreach (IFWCharacter cobj in characters) {
                                        cobj.print(uppers[idx++]);
                                    }
                                    Console.WriteLine();
                                }
                                else if (int.Parse(s) == 2)
                                {
                                    Console.WriteLine("Number of Character objects created: " + factory.objectCount);
                                }
                            }
                            catch (Exception e)
                            {
                                
                            }
                        } while (s != "0" && s != null);
                        
                    }
                }
                catch (Exception e)
                {

                }
            } while (s != null);

        }
    }
}
