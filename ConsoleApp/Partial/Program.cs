namespace Partial
{
    public class Base
    {
        int itemNumber;

        public void Construct()
        {
            Console.WriteLine("건물을 지었습니다.");
        }

        public class Village
        {
            Base aClass = new Base();
            int bNumber;

            public void Information()
            {
                bNumber = aClass.itemNumber;
            }

        }
    }

namespace KGS
{
    class Function
    {
        public Function()
        {
            Console.WriteLine("xxx 시스템 개발");
        }
    }
}



namespace MJY
{
    class Function
    {
        public Function()
        {
            Console.WriteLine("내가 개발한 시스템");
        }
    }


}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial 클래스
            //Player player = new Player();
            //player.Talk();
            //player.MoveMent();
            //player.Attack();
            #endregion

            #region 중첩 클래스
            //Base aClass = new Base();
            //Base.Village nestedClass = new Base.Village();
            //nestedClass.Information();
            #endregion


            // nameSpace 이름을 넣어서 구분
            MJY.Function mjy = new MJY.Function();

            KGS.Function sjh = new KGS.Function();  

        }
    }
}