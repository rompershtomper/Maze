namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int stepsForvard = ((System.Math.Max(width, height)) - 2) / ((System.Math.Min(width, height)) - 2);
            int stepsSide = 1;

            if (height > width)
                VertikalMaze(robot, stepsForvard, stepsSide);
            else HorizontalMaze(robot, stepsForvard, stepsSide);
        }

        static void GoRight(Robot robot, int steps)
        {
            for (int i = 0; i < steps; i++)
                robot.MoveTo(Direction.Right);
        }

        static void GoDown(Robot robot, int steps)
        {
            for (int i = 0; i < steps; i++)
                robot.MoveTo(Direction.Down);
        }

        static void VertikalMaze(Robot robot, int stepsForvard, int stepsSide)
        {
            while (!robot.Finished)
            {
                GoDown(robot, stepsForvard);
                if (!robot.Finished)
                    GoRight(robot, stepsSide);
            }
        }

        static void HorizontalMaze(Robot robot, int stepsForvard, int stepsSide)
        {
            while (!robot.Finished)
            {
                GoRight(robot, stepsForvard);
                if (!robot.Finished)
                    GoDown(robot, stepsSide);
            }
        }
    }
}