using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class CharacterFactory
    {
        public int objectCount = 0;

        private Dictionary<Char, IFWCharacter> charObjects = new Dictionary<char, IFWCharacter>();

        public IFWCharacter getCharacter(Char c)
        {
            Char lowerC = Char.ToLower(c);

            if (!charObjects.ContainsKey(lowerC))
            {
                objectCount++;

                switch (lowerC)
                {
                    case 'a':
                        charObjects.Add(lowerC, new ACharacter());
                        break;
                    case 'b':
                        charObjects.Add(lowerC, new BCharacter());
                        break;
                    case 'c':
                        charObjects.Add(lowerC, new CCharacter());
                        break;
                    case 'd':
                        charObjects.Add(lowerC, new DCharacter());
                        break;
                    case 'e':
                        charObjects.Add(lowerC, new ECharacter());
                        break;
                    case 'f':
                        charObjects.Add(lowerC, new FCharacter());
                        break;
                    case 'g':
                        charObjects.Add(lowerC, new GCharacter());
                        break;
                    case 'h':
                        charObjects.Add(lowerC, new HCharacter());
                        break;
                    case 'i':
                        charObjects.Add(lowerC, new ICharacter());
                        break;
                    case 'j':
                        charObjects.Add(lowerC, new JCharacter());
                        break;
                    case 'k':
                        charObjects.Add(lowerC, new KCharacter());
                        break;
                    case 'l':
                        charObjects.Add(lowerC, new LCharacter());
                        break;
                    case 'm':
                        charObjects.Add(lowerC, new MCharacter());
                        break;
                    case 'n':
                        charObjects.Add(lowerC, new NCharacter());
                        break;
                    case 'o':
                        charObjects.Add(lowerC, new OCharacter());
                        break;
                    case 'p':
                        charObjects.Add(lowerC, new PCharacter());
                        break;
                    case 'q':
                        charObjects.Add(lowerC, new QCharacter());
                        break;
                    case 'r':
                        charObjects.Add(lowerC, new RCharacter());
                        break;
                    case 's':
                        charObjects.Add(lowerC, new SCharacter());
                        break;
                    case 't':
                        charObjects.Add(lowerC, new TCharacter());
                        break;
                    case 'u':
                        charObjects.Add(lowerC, new UCharacter());
                        break;
                    case 'v':
                        charObjects.Add(lowerC, new VCharacter());
                        break;
                    case 'w':
                        charObjects.Add(lowerC, new WCharacter());
                        break;
                    case 'x':
                        charObjects.Add(lowerC, new XCharacter());
                        break;
                    case 'y':
                        charObjects.Add(lowerC, new YCharacter());
                        break;
                    case 'z':
                        charObjects.Add(lowerC, new ZCharacter());
                        break;
                    case ' ':
                        charObjects.Add(lowerC, new SpaceCharacter());
                        break;
                }
            }

            return charObjects[lowerC];
        }
    }
}
