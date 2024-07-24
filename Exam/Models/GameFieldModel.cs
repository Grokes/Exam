using Exam.Models.Interfaces;

namespace Exam.Models
{
    public class GameFieldModel: IGameFieldModel
    {
		public int Height => 10;
		public int Width => 10;

		public int PlayerPositionY { get; private set; }
		public int PlayerPositionX { get; private set; }

		public int[][] Map { get; private set; }

		public GameFieldModel()
		{
			PlayerPositionX = 0;
			PlayerPositionY = 0;
			GenerateMap();
		}

		public void GenerateMap()
		{
			Map = new int[Height][];

			for (int i = 0; i < Height; i++)
			{
				Map[i] = new int[Width];
				Array.Fill(Map[i], 0);
			}
			Map[PlayerPositionY][PlayerPositionX] = 1;
		}

		public void Up()
		{
			if (PlayerPositionY - 1 >= 0)
			{
                Map[PlayerPositionY][PlayerPositionX] = 0;
				PlayerPositionY -= 1;
                Map[PlayerPositionY][PlayerPositionX] = 1;
            }
		}
        public void Down()
        {
            if (PlayerPositionY + 1 < Height)
            {
                Map[PlayerPositionY][PlayerPositionX] = 0;
                PlayerPositionY += 1;
                Map[PlayerPositionY][PlayerPositionX] = 1;
            }
        }
        public void Right()
        {
            if (PlayerPositionX + 1 < Width)
            {
                Map[PlayerPositionY][PlayerPositionX] = 0;
                PlayerPositionX += 1;
                Map[PlayerPositionY][PlayerPositionX] = 1;
            }
        }
        public void Left()
        {
            if (PlayerPositionX - 1 >= Width)
            {
                Map[PlayerPositionY][PlayerPositionX] = 0;
                PlayerPositionX -= 1;
                Map[PlayerPositionY][PlayerPositionX] = 1;
            }
        }
    }
}
