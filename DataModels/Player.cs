namespace ReversedXMixDrix
{
    internal class Player
    {
        private eSymbol m_Symbol;
        private int m_Score = 0;
        private string m_Name;

        internal Player(eSymbol i_symbol, string i_Name)
        {
            m_Symbol = i_symbol;
            m_Name = i_Name;
        }

        internal string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        internal int Score
        {
            get { return m_Score; }
            set { m_Score = value; }
        }

        internal eSymbol Symbol
        {
            get { return m_Symbol; }
        }

        internal void IncreaseScore()
        {
            Score++;
        }
    }
}
