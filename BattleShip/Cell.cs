using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BattleShip
{
    class Cell
    {
        private int x;
        private int y;
        private bool status;//false-תא צוללת //true-תא ריק
        private int hit;//1=החטאה 
                        //2=פגיעה
        private Image pic;
        private Ship s;
        public Cell()
        {
            this.x = 0;
            this.y = 0;
            this.status = true;
            this.hit = 0;
            this.pic = Image.FromFile("nada.png");
            s = null;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public bool GetStatus()
        {
            return this.status;
        }
        public Ship GetShip()
        {
            return this.s;
        }
        public int GetHit()
        {
            return this.hit;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetStatus(bool status)
        {
            this.status = status;
        }
        public void SetHit(int num)
        {
            this.hit = num;
        }
        public void SetShip(Ship s)
        {
            this.s = new Ship();
            this.s = s;
        }
        public void RemoveShip()
        {
            this.s = null;
        }
        public void PaintCell(Graphics g, bool sw)
        {
            Pen pen1;
            //if (this.status == false)
            //    pen1 = new Pen(Color.Red, 2);
            //else 
            pen1 = new Pen(Color.Aqua, 2);
            g.DrawRectangle(pen1, this.x, this.y, 30, 30);
            if (sw == true && this.s != null)
            {
                s.SetX(this.x);
                s.SetY(this.y);
                s.PaintShip(g);
            }
            Point p = new Point(this.x + 3, this.y + 3);
            if (this.hit == 1)
            {
                this.pic = Image.FromFile("splash.png");
            }
            else if (this.hit == 2)
            {
                this.pic = Image.FromFile("boom.png");
            }
            g.DrawImage(pic, p);
        }
    }
}
