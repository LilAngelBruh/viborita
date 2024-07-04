using System;
using System.Collections.Generic;
using System.Drawing;

namespace viborita
{
    public class Snake
    {
        private List<Rectangle> snakeBody;
        private SolidBrush pencil;
        private string snakeColor;
        private int x, y, width, height;
        private const int InitialLength = 3;

        public Rectangle[] SnakeBody
        {
            get { return snakeBody.ToArray(); }
        }

        public Snake()
        {
            snakeBody = new List<Rectangle>();
            snakeColor = "#217442";
            Color snakeBodyColor = ColorTranslator.FromHtml(snakeColor);
            pencil = new SolidBrush(snakeBodyColor);
            x = 50;
            y = 30;
            width = 10;
            height = 10;

            for (int i = 0; i < InitialLength; i++)
            {
                snakeBody.Add(new Rectangle(x - i * width, y, width, height));
            }
        }

        public void DrawSnake(Graphics papel)
        {
            foreach (Rectangle rec in snakeBody)
            {
                papel.FillRectangle(pencil, rec);
            }
        }

        public void MoveUp()
        {
            Move(0, -height);
        }

        public void MoveDown()
        {
            Move(0, height);
        }

        public void MoveLeft()
        {
            Move(-width, 0);
        }

        public void MoveRight()
        {
            Move(width, 0);
        }

        private void Move(int deltaX, int deltaY)
        {
            for (int i = snakeBody.Count - 1; i > 0; i--)
            {
                snakeBody[i] = snakeBody[i - 1];
            }
            snakeBody[0] = new Rectangle(snakeBody[0].X + deltaX, snakeBody[0].Y + deltaY, width, height);
        }

        public void GrowSnake()
        {
            snakeBody.Add(new Rectangle(snakeBody[snakeBody.Count - 1].X, snakeBody[snakeBody.Count - 1].Y, width, height));
        }

        public bool SnakeCollision(int maxWidth, int maxHeight)
        {
            Rectangle head = snakeBody[0];

            if (head.X < 0 || head.X >= maxWidth || head.Y < 0 || head.Y >= maxHeight)
            {
                return true;
            }

            for (int i = 1; i < snakeBody.Count; i++)
            {
                if (head.IntersectsWith(snakeBody[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
