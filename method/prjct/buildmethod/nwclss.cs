namespace buildmethod
{
    public class nwclss
    {
        private int _tekededler;

        public int Ededler
        {
            get
            {
                return _tekededler;
            }
            set
            {
                if (value % 2 == 0 || value > 0)
                {
                    return ;
                }
                _tekededler = value;
            }
        }
    }
}
