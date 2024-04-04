using MarsRover.Service;

namespace MarsRoverTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Robot_Go_Forward_When_Receive_One_Forward_Command_Without_Obstacle()
        {
            RobotMarsRover robot = new RobotMarsRover("ROBOT Alain SY 2024", 5,6,'N');
            robot.Move('f');
            Assert.AreEqual(robot.PosX, 5);
            Assert.AreEqual(robot.PosY, 7);

        }

        [Test]
        public void Should_Robot_Go_Backward_When_Receive_One_Backward_Command_Without_Obstacle()
        {
            RobotMarsRover robot = new RobotMarsRover("ROBOT Alain SY 2024", 5, 6, 'N');
            robot.Move('b');
            Assert.AreEqual(robot.PosX, 5);
            Assert.AreEqual(robot.PosY, 5);

        }

        [Test]
        public void Should_Robot_Turn_Left_When_Receive_One_Backward_Command_Without_Obstacle()
        {
            RobotMarsRover robot = new RobotMarsRover("ROBOT Alain SY 2024", 5, 6, 'N');
            robot.Move('l');
            Assert.AreEqual(robot.PosX, 5);
            Assert.AreEqual(robot.PosY, 6);
            Assert.AreEqual(robot.CurrentDirection, 'W');

        }

        [Test]
        public void Should_Robot_Turn_Right_When_Receive_One_Right_Command_Without_Obstacle()
        {
            RobotMarsRover robot = new RobotMarsRover("ROBOT Alain SY 2024", 5, 6, 'N');
            robot.Move('r');
            Assert.AreEqual(robot.PosX, 5);
            Assert.AreEqual(robot.PosY, 6);
            Assert.AreEqual(robot.CurrentDirection, 'E');

        }

        [Test]
        public void Should_Robot_Go_Correctly_When_Receive_Multiple_Command_Without_Obstacle()
        {
            // should go from (5,6,N) to
            // (5,7,N),(5,8,N),(5,8,E),(6,8,E),(6,8,S),(6,9,S),(6,10,S)
            char[] itinerary = { 'f', 'f', 'r', 'f', 'r', 'b', 'b' };
            RobotMarsRover robot = new RobotMarsRover("ROBOT Alain SY 2024", 5, 6, 'N');
            robot.MoveNCommands(itinerary);
           
            Assert.AreEqual(robot.PosX, 6);
            Assert.AreEqual(robot.PosY, 10);
            Assert.AreEqual(robot.CurrentDirection, 'S');

        }

    }
}