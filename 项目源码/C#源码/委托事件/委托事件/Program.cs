using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Host h = new Host("贝尔.格里尔斯");    //声明一个主播
            Player p1 = new Player("玩家1");
            Player p2 = new Player("玩家2");
            Player p3 = new Player("玩家3");

            h.AddPlayer(p1);
            h.AddPlayer(p2);
            h.AddPlayer(p3);

            h.StartHost();

            Console.ReadKey();
        }
    }

  
    /// <summary>
    /// 主播
    /// </summary>
    public class Host
    {
        public string hostName;
        public List<Player> playerList = new List<Player>();

        public Host(string hostName)
        {
            this.hostName = hostName;
        }

        /// <summary>
        /// 开播了
        /// </summary>
        public void StartHost()
        {
            Console.WriteLine("我是主播   " + hostName +  "开播了" );
            if(playerList != null && playerList.Count > 0)      //持有list 遍历通知
            {
                foreach (Player p in playerList)
                {
                    p.AccepMessage(hostName);   //通知开播了
                }
            }
        }

        /// <summary>
        /// 添加观众
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(Player player)
        {
            this.playerList.Add(player);
        }
    }

    /// <summary>
    /// 玩家 观众
    /// </summary>
    public class Player
    {
        public string playerName;

        public Host host;

        public Player(string playerName)
        {
            this.playerName = playerName;
        }

        /// <summary>
        /// 接受开播了
        /// </summary>
        /// <param name="name"></param>
        public void AccepMessage(string name)
        {
            Console.WriteLine("我是玩家:   " + playerName + "   "  +  "收到了   " + name + "开播了的消息");
        }
    }
}
