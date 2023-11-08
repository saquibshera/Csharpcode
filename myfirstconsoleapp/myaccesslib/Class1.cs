namespace myaccesslib
{
   public class bases
    {
        protected internal int x;
    }
    class derived : bases
    {
        public void exec()
        {
            derived dr = new derived();
            dr.x = 23;
            bases bs = new bases();
            bs.x = 23;
        }

    }
}