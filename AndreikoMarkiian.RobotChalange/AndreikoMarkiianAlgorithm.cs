using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Common;


namespace AndreikoMarkiian.RobotChalange
{
    public class AndreikoMarkiianAlgorythm : IRobotAlgorithm
    {
        string IRobotAlgorithm.Author => "Andreiko";

        RobotCommand IRobotAlgorithm.DoStep(IList<Robot.Common.Robot> robots, int robotToMoveIndex, Map map)
        {
            var MyRobot = robots[robotToMoveIndex];
            var position = MyRobot.Position;
            position.X = position.X + 1;
            position.Y = position.Y + 1;
            return new MoveCommand() { NewPosition = position };
        }
    }
}
