using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;
        public static Random random = new Random();
        static void Initialize(Engine engine)
        {
            int startRow = 0;
            int startCol = 0;
            int endCol = WorldCols;
            int endRow = WorldRows - 1;
            int numberOfBlockRows = 2;

            for (int row = startRow; row < endRow; row++)
            {
                for (int col = startCol; col < endCol; col++)
                {
                    if (row == 0)
                    {
                        engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, col)));
                    }
                    else if (col == startCol || col == endCol - 1)
                    {
                        engine.AddObject(new IndestructibleBlock(new MatrixCoords(row, col)));
                    }
                    else
                    {
                        if (numberOfBlockRows >= row)
                        { 
                            int randomNumber = random.Next(0, 8);
                            if (randomNumber % 5 == 0)
                            {
                                engine.AddObject(new UnpassableBlock(new MatrixCoords(row, col)));
                            }
                            else if (randomNumber % 6 == 0)
                            {
                                engine.AddObject(new ExplodingBlock(new MatrixCoords(row, col)));
                            }
                            else if (randomNumber % 7 == 0)
                            {
                                engine.AddObject(new GiftBlock(new MatrixCoords(row, col)));
                            }
                            else
                            { 
                                engine.AddObject(new Block(new MatrixCoords(row, col)));
                            }
                        }
                    }
                }
            }
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //Ball theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            Ball theBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 3), RacketLength);
            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            EngineMkII gameEngine = new EngineMkII(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };
            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);
            gameEngine.Run();
        }
    }
}
