using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BattleShip
{
    class Ship
    {
        private int x;
        private int y;
        private int size;
        private Image pic;
        private bool position; 
        // true-מאונך
        // false-מאוזן
        
        public Ship()
        {
            this.x = 0;
            this.y = 0;
            this.size = 0;
            this.pic = Image.FromFile("ship5.png");
            this.position = true;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public int GetSize()
        {
            return this.size;
        }
        public bool GetPosition()
        {
            return this.position;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetPosition(bool position)
        {
            this.position = position;
        }
        public void SetSize(int size)
        {
            this.size = size;
        }
        public void PaintShip(Graphics g)
        {
            Point p = new Point(this.x + 5, this.y + 5);
            if(this.position == false)
                this.pic = Image.FromFile("ship" + this.size + "(2).png");
            else
                this.pic = Image.FromFile("ship" + this.size + ".png");
            g.DrawImage(pic, p);    
        }


    }
}
