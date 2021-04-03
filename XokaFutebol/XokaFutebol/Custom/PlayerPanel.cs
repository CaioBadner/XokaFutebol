using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XokaFutebol
{
    public delegate void PlayerPanelNotify(int startY, int finalY);
    class PlayerPanel : FlowLayoutPanel
    {
        bool isDragged = false;
        public bool isDraggable = false;
        Point ptOffset, ptStartPosition;
        Color foreColor;
        public Obj.Player player;
        public Label lPlayerName, lPlayerInfo;
        public event PlayerPanelNotify ChangedPos;
        readonly int infoSize = 100, panelHeight = 27;
        readonly int gridPoints;
        int originalY;

        public PlayerPanel(Obj.Player player, int size, int gridPoints, bool isFirstTeam, bool isDraggable)
        {
            this.player = player;
            this.isDraggable = isDraggable;
            this.gridPoints = gridPoints;
            if (isFirstTeam) foreColor = Color.White;
            else foreColor = Color.Silver;
            lPlayerName = new Label
            {
                Text = player.Nickname,
                Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                BackColor = Color.Transparent,
                ForeColor = foreColor,
                Size = new Size(size - infoSize, panelHeight),
                TextAlign = ContentAlignment.BottomLeft
            };
            lPlayerInfo = new Label
            {
                Text = player.GetPosSide(),
                Font = new Font("Microsoft YaHei", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                BackColor = Color.Transparent,
                ForeColor = foreColor,
                Size = new Size(infoSize, panelHeight),
                TextAlign = ContentAlignment.BottomRight
            };
            
            lPlayerName.MouseDown += new MouseEventHandler(this.MouseDown);
            lPlayerName.MouseMove += new MouseEventHandler(this.MouseMove);
            lPlayerName.MouseUp += new MouseEventHandler(this.MouseUp);
            /*
            lPlayerInfo.MouseDown += new MouseEventHandler(this.MouseDown);
            lPlayerInfo.MouseMove += new MouseEventHandler(this.MouseMove);
            lPlayerInfo.MouseUp += new MouseEventHandler(this.MouseUp);
            */

            this.BackColor = Color.Transparent;
            this.FlowDirection = FlowDirection.LeftToRight;
            this.AutoSize = true;
            this.WrapContents = false;
            this.Controls.Add(lPlayerName);
            this.Controls.Add(lPlayerInfo);
            this.Size = new Size(size, panelHeight);
        }

        
        public void ChangeInfo(string info)
        {
            this.lPlayerInfo.Text = info;
        }

        public void ChangePlayer(Obj.Player player)
        {
            this.player = player;
            lPlayerName.Text = player.Nickname;
            //lPlayerInfo.Text = player.GetPosSide();
        }

        public void UpdateSub(bool isNowFirstTeam, string matchMinute)
        {
            string inOutText;
            if (isNowFirstTeam) inOutText = "in";
            else inOutText = "out";
            string subText = String.Format("   ({0} {1})", inOutText, matchMinute);
            lPlayerName.Text += subText;
            if (isNowFirstTeam) foreColor = Color.White;
            else
            {
                foreColor = Color.Silver;
                isDraggable = false;
            }
            lPlayerName.ForeColor = lPlayerInfo.ForeColor = foreColor;
        }

        new public void MouseDown(object sender, MouseEventArgs e)
        {
            if (isDraggable)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragged = true;
                    this.BringToFront();
                    ptStartPosition = this.PointToScreen(new Point(e.X, e.Y));

                    ptOffset = new Point();
                    ptOffset.X = this.Location.X - ptStartPosition.X;
                    ptOffset.Y = this.Location.Y - ptStartPosition.Y;
                    originalY = this.Location.Y;
                }
                else
                {
                    isDragged = false;
                }
            }
        }

        new public void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                this.Location = newPoint;
            }
        }

        new public void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragged)
            {
                isDragged = false;
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(ptOffset);
                int minX = 100, minY = 15, maxY = 820, gridY = this.Height, finalY = 0;
                if (newPoint.Y <= minY)
                {
                    finalY = minY;
                }
                else
                {
                    for (int y = 0; y < gridPoints; y++)
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
                //we only call the ChangePos event if the panel landed on a different spot in the grid
                if (originalY != finalY)
                    OnChangedPos(originalY, finalY);
                //and we send the panel back to the original spot, regardless of what will happen
                //later in the form
                this.Location = new Point(minX, originalY);
            }
        }

        protected virtual void OnChangedPos(int startY, int finalY)
        {
            ChangedPos?.Invoke(startY, finalY);
        }
    }
}
