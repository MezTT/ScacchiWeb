namespace Scacchi {

    public class Board {

        protected Dictionary<Coordinate, Piece> _board = new();

        public void StartPosition(string whitePlayerId, string blackPlayerId) {

        }

        public List<(Coordinate, bool)>? SelectPiece(string playerId, Coordinate coordinate) {

            Piece? piece; 
            var valid = _board.TryGetValue(coordinate, out piece);

            if(!valid || piece == null )
                return null;

            if (piece.PlayerOwner != playerId)
                return null;

            var moveList = piece.CanMoveTo(coordinate);
            var ret = new List<(Coordinate, bool)>();

            if (piece.IsPawn) {

                if (!_board.ContainsKey(moveList[0]))
                    ret.Add((moveList[0], false));

                var eats = ((Pawn)piece).CanEat(coordinate);

                foreach(var e in eats) {
                    if (_board.ContainsKey(e))
                        ret.Add((e, true));
                }

            }
            else {

                foreach(var m in moveList) {
                    if (_board.ContainsKey(m))
                        ret.Add((m, true));
                    else
                        ret.Add((m, false));
                }

            }

            return ret;

        }

        public void Move(string playerId, Coordinate piecePos, Coordinate target) {

            Piece? piece;
            var valid = _board.TryGetValue(piecePos, out piece);

            if (!valid || piece == null || piece.PlayerOwner != playerId) throw new Exception("Error on moving");

            _board.Remove(piecePos);
            _board.Add(target, piece);

        }

        public void Eat(string playerId, Coordinate piecePos, Coordinate coordinate) { 

        } 

    }


    public struct Coordinate {
        public int XCoordinate;
        public int YCoordinate;

        public const int Max = 8;
        public const int Min = 0;
    }
}
