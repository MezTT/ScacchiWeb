namespace Scacchi {

    public class Pawn : Piece {

        public bool ForwardIsPlus { get; private set; }

        public Pawn(string image, string owner, string color, bool forwardIsPlus) : base(image, owner, color, true) {
            ForwardIsPlus = forwardIsPlus;
        }

        public List<Coordinate> CanEat(Coordinate currentPosition) {
            
            var ret = new List<Coordinate>();

            if (ForwardIsPlus) {
                var target = currentPosition;
                target.YCoordinate++;
                target.XCoordinate++;
                ret.Add(target);

                target = currentPosition;
                target.YCoordinate++;
                target.XCoordinate--;
                ret.Add(target);
            }
            else {
                var target = currentPosition;
                target.YCoordinate--;
                target.XCoordinate++;
                ret.Add(target);

                target = currentPosition;
                target.YCoordinate--;
                target.XCoordinate--;
                ret.Add(target);
            }

            return ret;

        }

        public override List<Coordinate> CanMoveTo(Coordinate currentPosition) {
            
            var ret = new List<Coordinate>();
            var target = currentPosition;

            if(ForwardIsPlus)
                target.YCoordinate += 1;
            else
                target.YCoordinate -= 1; 

            ret.Add(target);
            return ret;

        }

    }
}
