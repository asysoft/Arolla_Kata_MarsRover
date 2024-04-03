namespace MarsRover.Service
{
    public class RobotMarsRover : IDeplacerRobot
    {
        public string Name;
        
        public int PosX { get; set; }
        public int PosY { get; set; }

        public RobotMarsRover(string name, int x, int y)
        {
            Name = name;
            PosX = x;
            PosY = y;
        }

        public enum commands
        {
            Faire_avancer = 'f' ,
            Faire_Reculer_  = 'b'
        }

        public void Deplacer(char comand, char direction)
        {
            switch (comand)
            {
                case 'f':
                    if (direction == 'N')
                    {
                        PosY = PosY + 1;
                    }
                    else if (direction == 'S')
                    {
                        PosY = PosY - 1;
                    }
                    else if (direction == 'W')
                    {
                        PosX = PosX + 1;
                    }
                    else if (direction == 'E')
                    {
                        PosX = PosX - 1;
                    }
                    break; 
                case 'b':
                    if (direction == 'N')
                    {
                        PosY = PosY - 1;
                    }
                    else if (direction == 'S')
                    {
                        PosY = PosY + 1;
                    }
                    else if (direction == 'W')
                    {
                        PosX = PosX - 1;
                    }
                    else if (direction == 'E')
                    {
                        PosX = PosX + 1;
                    }
                    break;

                default:
                    break;
            }


        }
    }
}