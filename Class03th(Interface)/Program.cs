namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 추상 클래스
            // 직접 생성할 수는 없지만, 다른 클래스가 상속받아
            // 구체적인 기능을 만들 수 있도록 설계되어 있는 클래스.

            int width = 40;
            int height = 20;
            Terrain terrain = new Fog(width, height);
            terrain.Describe();

            Fog fog = new Fog(width, height);
            fog.Hiding();

            #endregion

        }
    }
}
