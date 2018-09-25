using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托事件改进
{
    class Program
    {
        static void Main(string[] args)
        {

            Mana m = new Mana();
            Host h = new Host();
            Player p = new Player();


            m.AddEvent += h.Add;
            m.AddEvent += p.Add;

            m.Change(1);

            Console.ReadKey();
             
        }
    }


    /// <summary>
    /// 主播
    /// </summary>
    public class Host {

        public void Add(int a)
        {
            Console.WriteLine("host" + a);
        }
    }

    /// <summary>
    /// 玩家 观众
    /// </summary>
    public class Player
    {
        public void Add(int a)
        {
            Console.WriteLine("player" + a);
        }
    }


    public class Mana
    {
        public delegate void Add(int a);

        public event Add AddEvent;

        public void Change(int a)
        {
            AddEvent(a);
        }
    }

}
