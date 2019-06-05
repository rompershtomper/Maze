namespace Mazes
{
    public static class SnakeMazeTask
    {
	public static void MoveOut(Robot robot, int width, int height)
	{
            int turnsDown = height / 4;
            for (;turnsDown>0;turnsDown--)
	    {
                GoRight(robot, width);
                TwoStepsDown(robot);
                GoLeft(robot, width);
                if (turnsDown == 1) break;
                TwoStepsDown(robot);
            }
	}

        static void GoRight(Robot robot, int width)
        {
            for (int i = 3; i < width; i++)
                robot.MoveTo(Direction.Right);
        }

        static void GoLeft(Robot robot, int width)
        {
            for (int i = 3; i < width; i++)
                robot.MoveTo(Direction.Left);
        }

        static void TwoStepsDown(Robot robot)
        {
            for (int i = 0; i < 2; i++)
                robot.MoveTo(Direction.Down);
        }
    }
}
