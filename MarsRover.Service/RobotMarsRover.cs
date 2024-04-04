﻿namespace MarsRover.Service
{
    public class RobotMarsRover : IMoveRobot
    {
        public string Name;
        
        public int PosX { get; set; }
        public int PosY { get; set; }

        public char CurrentDirection { get; set; }

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
                Move(commands[i]);
            }
        }

        private void MoveForward()
        {
            if (CurrentDirection == 'N')
            {
                PosY = (PosY + 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'S')
            {
                PosY = (PosY - 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'W')
            {
                PosX = (PosX - 1) % PLAN_MARS_X;
            }
            else if (CurrentDirection == 'E')
            {
                PosX =  (PosX + 1) % PLAN_MARS_X;
            }

         }

        private void MoveBackward()
        {
            if (CurrentDirection == 'N')
            {
                PosY = (PosY - 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'S')
            {
                PosY = (PosY + 1) % PLAN_MARS_Y;
            }
            else if (CurrentDirection == 'W')
            {
                PosX = (PosX + 1) % PLAN_MARS_X;
            }
            else if (CurrentDirection == 'E')
            {
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