namespace Constructor
{
    class Monster
    {
        private int health;
        private float attack;
        public Monster(int health, float attack)
        {
            this.health = health;
            this.attack = attack;
            
        }

        // 깊은 복사
        public Monster Clone()
        {
            Monster temp = new Monster(health, attack);

            return temp;
        }

        public void DataSetting(int x, int y)
        {
            health = x;
            attack = y;
        }

        public void Information(string name)
        {
            Console.WriteLine( name + "의 체력 : " + this.health);
            Console.WriteLine( name + "의 공격력 : " + this.attack);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 얕은복사와 깊은복사
            // // 기본 생성자
            // Monster monster1 = new Monster(100, 20);
            // monster1.Information("Monster1");
            //
            // // Monster monster2 = monster1; // 얕은복사
            // Monster monster2 = monster1.Clone(); // 깊은복사
            //
            // monster2.DataSetting(300, 50);
            //
            // monster1.Information("Monster1");
            // monster2.Information("Monster2");
            #endregion

            #region 백준 9086
           // int inputNum = int.Parse(Console.ReadLine());
           //
           // for (int i = 0; i < inputNum; i++)
           // {
           //    
           //     string name = Console.ReadLine();
           //
           //     Console.Write(name[0]);
           //     Console.WriteLine(name[name.Length - 1]);
           //     
           //
           // }
            #endregion
        }
    }
}