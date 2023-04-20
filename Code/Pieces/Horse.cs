namespace Scacchi {

    public class Horse : Piece {

        public Horse(string image, string owner, string color) : base(image, owner, color, false) { }

        public override List<Coordinate> CanMoveTo(Coordinate currentPosition) {

            var ret = new List<Coordinate> {
                new Coordinate() { XCoordinate = currentPosition.XCoordinate - 2, YCoordinate = currentPosition.YCoordinate - 1 },
                new Coordinate() { XCoordinate = currentPosition.XCoordinate - 2, YCoordinate = currentPosition.YCoordinate + 1 },

                new Coordinate() { XCoordinate = currentPosition.XCoordinate + 2, YCoordinate = currentPosition.YCoordinate - 1 },
                new Coordinate() { XCoordinate = currentPosition.XCoordinate + 2, YCoordinate = currentPosition.YCoordinate + 1 },

                new Coordinate() { XCoordinate = currentPosition.XCoordinate - 1, YCoordinate = currentPosition.YCoordinate - 2 },
                new Coordinate() { XCoordinate = currentPosition.XCoordinate + 1, YCoordinate = currentPosition.YCoordinate - 2 },

                new Coordinate() { XCoordinate = currentPosition.XCoordinate - 1, YCoordinate = currentPosition.YCoordinate + 2 },
                new Coordinate() { XCoordinate = currentPosition.XCoordinate + 1, YCoordinate = currentPosition.YCoordinate + 2 }
            };


            return ret.Where(x => x.XCoordinate <= Coordinate.Max && x.XCoordinate >= Coordinate.Min &&  x.YCoordinate >= Coordinate.Min && x.YCoordinate  <= Coordinate.Max)
                .ToList();
        }

    }
}
