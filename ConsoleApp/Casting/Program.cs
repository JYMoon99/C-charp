namespace Casting
{
     class Unit
    {
       protected int health = 100;
       protected int attack = 10;

       virtual public int AttackDamage()
        {
            return attack;
        }

        public void Skill()
        {
            Console.WriteLine("Unit의 스킬");
        }


        public void Recovery(Unit obj)
        {
            obj.health += 100;
        }

        public void Damage(Unit obj)
        {
            obj.health -= AttackDamage();
        }

    }


    class Marine : Unit
    {

        public Marine()
        {
            health = 50;
            attack = 5;
        }

      override public int AttackDamage()
        {
            Console.WriteLine("Marine Attack");
            return attack;
        }


        // 메소드 숨기기
        new public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }


    }

    class Ghost : Unit
    {

        public Ghost()
        {
            health = 75;
            attack = 15;
        }

       override public int AttackDamage()
        {
            Console.WriteLine("Ghost Attack");
            return attack;
        }


        new public void Skill()
        {
            Console.WriteLine("Lock Down");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Marine marine = new Marine();
            //marine.Skill();

            Ghost ghost = new Ghost();  
            //ghost.Skill();

            Unit unit = new Marine(); // unit이 Marine을 가르켰지만 실제로는 unit이 Unit을 가리켜서
                                      // 마린을 업캐스팅 해도 고스트까지 가능하다.
            
           // unit.Skill();

          // unit.Recovery(ghost);
          // unit.Recovery(marine);

            unit.Damage(marine);
            unit.Damage(ghost);
            

        }
    }
}