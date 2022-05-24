namespace getSet
{
    class Income
    {

        public int _income = 45000;

        public int income
        {
            get
            {
                return _income;
            }
            set
            {
                if(value <= 0)
                {
                    _income = 0;
                }
                else if(value > 45000)
                {
                    _income = 45000;
                }
                else
                {
                    _income = value;
                }
            }
        }
        public void Debit(int moneySpent)
        {
            _income = _income - moneySpent;
        }
    }
    
}