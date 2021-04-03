using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XokaFutebol
{
    public delegate void RoundButtonNotify(int shirtNum, int finalX, int finalY);
    public class RoundButton : Button
    {
        public event RoundButtonNotify ChangedPos;

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width -3, ClientSize.Height -3);
            this.Region = new Region(grPath);
            base.OnPaint(e);
        }

        public RoundButton(Obj.Player player, Obj.TeamInfo team)
        {
            shirtNum = player.Shirt_number;
            this.Text = "" + player.Shirt_number;
            this.BackColor = Color.FromName(team.backcolor);
            this.ForeColor = Color.FromName(team.forecolor);
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(42, 42);
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            //this.MouseDown += new MouseEventHandler(this.mouseDown);
            //this.MouseMove += new MouseEventHandler(this.mouseMove);
            //this.MouseUp += new MouseEventHandler(this.mouseUp);
        }

        int shirtNum;
        bool isDragged = false;
        Point ptOffset, ptStartPosition;
        public void ChangeNumber(int shirtNum)
        {
            this.Text = "" + shirtNum;
        }

        public void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragged = true;
                ptStartPosition = this.PointToScreen(new Point(e.X, e.Y));

                ptOffset = new Point();
                ptOffset.X = this.Location.X - ptStartPosition.X;
                ptOffset.Y = this.Location.Y - ptStartPosition.Y;
            }
            else
            {
                isDragged = false;
            }
        }

        public void mouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                this.Location = newPoint;
            }
        }

        public void mouseUp(object sender, MouseEventArgs e)
        {
            isDragged = false;
            Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
            newPoint.Offset(ptOffset);
            int minX = 980, maxX = 1420, minY = 120, maxY = 775, gridX = 55,
                gridY = 50, gridXPoints = 8, gridYPoints = 13, finalX = 0, finalY = 0;
            if (newPoint.X <= minX)
            {
                finalX = minX;
            }
            else
            {
                for (int x = 0; x < gridXPoints; x++)
                {
                    if (newPoint.X <= minX + (x * gridX + gridX / 2))
                    {
                        finalX = minX + (x) * gridX;
                        break;
                    }
                    else if (newPoint.X > minX + (x * gridX + gridX / 2) && newPoint.X <= minX + ((x + 1) * gridX + gridX / 2))
                    {
                        finalX = minX + (x + 1) * gridX;
                        break;
                    }
                }
                if (finalX == 0)
                {
                    finalX = maxX;
                }
            }
            if (newPoint.Y <= minY)
            {
                finalY = minY;
            }
            else
            {
                for (int y = 0; y < gridYPoints; y++)
                {
                    if (newPoint.Y <= minY + y * gridY + gridY / 2)
                    {
                        finalY = minY + (y) * gridY;
                        break;
                    }
                    else if (newPoint.Y > minY + (y * gridY + gridY / 2) && newPoint.Y <= minY + ((y + 1) * gridY + gridY / 2))
                    {
                        finalY = minY + (y + 1) * gridY;
                        break;
                    }
                }
                if (finalY == 0)
                {
                    finalY = maxY;
                }

            }
            OnChangedPos(finalX, finalY);
            this.Location = new Point(finalX, finalY);
            //Console.WriteLine("X= " + gridX + " Y= " + gridY);

        }

        protected virtual void OnChangedPos(int finalX, int finalY)
        {
            ChangedPos?.Invoke(shirtNum, finalX, finalY);
        }

    }

    

}
