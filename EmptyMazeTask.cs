namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            GoRight(robot, width);
            GoDown(robot, height);
		}

        static void GoRight(Robot robot, int steps)
        {
            for (int i = 3; i < steps; i++)
                robot.MoveTo(Direction.Right);
        }

        static void GoDown(Robot robot, int steps)
        {
            for (int i = 3; i < steps; i++)
                robot.MoveTo(Direction.Down);
        }
    }
}