using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MarsRover.Service
{
    public class RobotMarsRover : IMoveRobot
    {
        public string Name;
        
        public int PosX { get; set; }
        public int PosY { get; set; }

        public char CurrentDirection { get; set; }

        private int posTryX;
        private int posTryY;

        // we Suppose Mars is projected into a plan surface X*Y
        const int PLAN_MARS_Y = 1000;
        const int PLAN_MARS_X = 1000;

        public RobotMarsRover(string name, int x, int y, char direction)
        {
            Name = name;
            PosX = x;
            PosY = y;
            CurrentDirection = direction;
        }

        public void Move(char command)
        {
            switch (command)
            {
                case 'f':
                    MoveForward();
                    break; 
                case 'b':
                    MoveBackward();
                    break;
                case 'l':
                    MoveLeft();
                    break;
                case 'r':
                    MoveRight();
                    break;

                default:
                    break;
            }
        }

        public void MoveNCommands(char[] commands)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (checkObstacle())
                {
                    ReportObstacleFound();
                    break;
                }
                Move(commands[i]);
            }
        }

        private bool checkObstacle()
        {
            bool res = false;

            // How to detect an obstacle ? Matrice X,Y of obstacle positions?

            return res;
        }
        private void ReportObstacleFound( )
        {
            Console.WriteLine("Obstacle found at {0} , {1}", posTryX, posTryY);
            Console.WriteLine("Waiting for new Instructions. Current Position : ({0},{1},{2} )", PosX, PosY, CurrentDirection);
        }
        private void MoveForward( bool tryMove = false)
        {
            if (CurrentDirection == 'N')
            {
                if (tryMove)
                {
                    posTryY = (PosY + 1) % PLAN_MARS_Y;
                    posTryX = PosX;
                }
                else
                    PosY = (PosY + 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'S')
            {
                if (tryMove)
                {
                    posTryY = (PosY - 1) % PLAN_MARS_Y;
                    posTryX = PosX;
                }
                else
                    PosY = (PosY - 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'W')
            {
                if (tryMove)
                {
                    posTryX = (PosX - 1) % PLAN_MARS_X;
                    posTryY = PosY;
                }
                else
                    PosX = (PosX - 1) % PLAN_MARS_X;
            }
            else if (CurrentDirection == 'E')
            {
                if (tryMove)
                {
                    posTryX = (PosX + 1) % PLAN_MARS_X;
                    posTryY = PosY;
                }
                else
                    PosX =  (PosX + 1) % PLAN_MARS_X;
            }

         }

        private void MoveBackward(bool tryMove = false)
        {
            if (CurrentDirection == 'N')
            {
                if (tryMove)
                {
                    posTryY = (PosY - 1) % PLAN_MARS_Y;
                    posTryX = PosX;
                }
                else
                    PosY = (PosY - 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'S')
            {
                if (tryMove)
                {
                    posTryY = (PosY + 1) % PLAN_MARS_Y;
                    posTryX = PosX;
                }
                else
                    PosY = (PosY + 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'W')
            {
                if (tryMove)
                {
                    posTryX = (PosX + 1) % PLAN_MARS_X;
                    posTryY = PosY;
                }
                else
                    PosX = (PosX + 1) % PLAN_MARS_X;
            }
            else if (CurrentDirection == 'E')
            {
                if (tryMove)
                {
                    posTryX = (PosX - 1) % PLAN_MARS_X;
                    posTryY = PosY;
                }
                else
                    PosX = (PosX - 1) % PLAN_MARS_X;
            }
        }

        private void MoveLeft()
        {
            if (CurrentDirection == 'N')
            {
                CurrentDirection = 'W';
            }
            else if (CurrentDirection == 'S')
            {
                CurrentDirection = 'E';
            }
            else if (CurrentDirection == 'W')
            {
                CurrentDirection = 'S';
            }
            else if (CurrentDirection == 'N')
            {
                PosX = PosX + 1;
            }
        }

        private void MoveRight()
        {
            if (CurrentDirection == 'N')
            {
                CurrentDirection = 'E';
            }
            else if (CurrentDirection == 'S')
            {
                CurrentDirection = 'W';
            }
            else if (CurrentDirection == 'W')
            {
                CurrentDirection = 'N';
            }
            else if (CurrentDirection == 'E')
            {
                CurrentDirection = 'S';
            }
        }

    }
}