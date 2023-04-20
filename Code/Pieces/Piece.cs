namespace Scacchi {
    public abstract class Piece {

        public string ImageName;
        public string PlayerOwner;
        public string Color;
        public bool IsPawn { get; protected set; }
        //protected Coordinate _coordinates;

        //public Coordinate Coordinate { get { return _coordinates; } }

        public Piece(string imageName, string playerOwner, string color, bool isPawn) {
            ImageName = imageName;
            PlayerOwner = playerOwner;
            Color = color;
            IsPawn = isPawn;
            //_coordinates = coordinates;
        }

        public abstract List<Coordinate> CanMoveTo(Coordinate currentPosition);
        //public abstract List<Coordinate> CanEat();
        //public abstract void MoveTo(Coordinate coordinate);

    }

    
}
