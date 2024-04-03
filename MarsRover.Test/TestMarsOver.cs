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
        public void Should_Robot_Go_Forward_When_Receive_Forward_Command()
        {
            RobotMarsRover robot = new RobotMarsRover("ROBOT 2024", 5,6);
            robot.Deplacer('f','N');
            Assert.AreEqual(robot.PosX, 5);
            Assert.AreEqual(robot.PosY, 7);

        }


    }
}