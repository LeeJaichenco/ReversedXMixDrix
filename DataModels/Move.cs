namespace ReversedXMixDrix
{
    internal class Move
    {
        internal int Row { get; set; }
        internal int Column { get; set; }

        public static bool operator ==(Move i_move1, Move i_move2)
        {
            return i_move1.Equals(i_move2);
        }

        public static bool operator !=(Move i_move1, Move i_move2)
        {
            return !i_move1.Equals(i_move2);
        }

        public override bool Equals(object i_Obj)
        {
            Move other = i_Obj as Move;
            bool result = false;

            if (!(other is null))
            {
                result = Equals(other);
            }

            return result;
        }

        public bool Equals(Move i_move)
        {
            bool result = false;

            if (!(i_move is null))
            {
                result = this.Row == i_move.Row && this.Column == i_move.Column;
            }

            return result;
        }
    }
}
