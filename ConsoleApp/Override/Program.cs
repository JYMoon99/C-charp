namespace Override
{

    class Weapon
    {
        private string name;
        public enum itemType
        {
            Sword,
            Gun,
            Arrow
        }

        public Weapon()
        {
            Console.WriteLine("매개변수가 없는 생성자 호출");
        }

        public Weapon(string name)
        {
            this.name = name;
            Console.WriteLine("매개변수가 있는 생성자 호출 : " + name);
        }

        public void Select(itemType item)
        {   

            switch(item)
            {
                case itemType.Sword : Console.WriteLine("Sword"); break;
                case itemType.Gun : Console.WriteLine("Gun"); break;
                case itemType.Arrow : Console.WriteLine("Arrow"); break;

            }
        }


        // 함수의 오버로딩
        public void Attack(int damage)
        {
            Console.WriteLine("int Damage : " + damage);

        }
        
        // 함수의 오버로딩은 매개변수 타입과 갯수에 따라서
        // 함수를 여러개 만들 수 있음.
        public void Attack(float damage)
        {
            Console.WriteLine("float Damage : " + damage);

        }

        public void Attack(int damage, float damage2)
        {
            Console.WriteLine("int Damage : " + damage);
            Console.WriteLine("float Damage : " + damage2);

        }



    }
    class Monster
    {
        virtual public void Attack()
        {
            Console.WriteLine("Monster 공격");
        }
    }

    class Goblin : Monster
    {
        override public void Attack()
        {
            Console.WriteLine("Goblin 공격");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 함수의 오버로딩
            // Weapon weapon = new Weapon(); // 매개 변수가 없는 생성자
            // Weapon weapon2 = new Weapon("Sword"); // 매개 변수가 있는 생성자
            //
            // weapon.Attack(100);
            // weapon.Attack(3.14f);
            //
            // Console.WriteLine("------------------------------------");
            //
            // weapon.Attack(500, 50.5f);
            #endregion

            #region Enum
            // Weapon weapon = new Weapon();
            // weapon.Select(Weapon.itemType.Sword); // Swrod
            // weapon.Select(Weapon.itemType.Gun); // Gun
            // weapon.Select(Weapon.itemType.Arrow); // Arrow
            #endregion

            Monster monster = new Goblin();
            monster.Attack();
            Monster monster2 = new Monster();
            monster2.Attack();

        }
    }
}