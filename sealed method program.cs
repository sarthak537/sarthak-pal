using System;
namespace chetu
{
       class grandfather
       {
          public virtual void Marry()
          {
            Console.WriteLine("g.father");

          }
       }
        class parent : grandfather
        {
            public sealed override void Marry()
            {
                Console.WriteLine("father");
            }

        }
    
        class child : parent
        {
            public override void Marry()
            {
                Console.WriteLine(" SON");
            }
            static void Main()
            {
                child c = new child();
                c.Marry();

            }
        }
  }
