using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BattleShip
{
    class Board
    {
        private Cell[,] board;
        private int x1;
        private int y1;
        private Image pic;
        private Point p;
        public Board(int x, int y)
        {                   
            this.x1 = x;
            this.y1 = y;
            this.pic = Image.FromFile("frame.png");
            this.p = new Point(x + 66, y + 66);
            this.board = new Cell[18, 18];
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    Cell c = new Cell();
                    c.SetX(x1);
                    c.SetY(y1);
                    board[i, j] = c;
                    x1 = x1 + 30;
                }
                this.x1 = x;
                y1 = y1 + 30;
            }
        }
        public void PaintBoard(Graphics g)
        {
            g.DrawImage(this.pic, this.p);
            for (int i = 4; i < 14; i++)
                for (int j = 4; j < 14; j++)
                {
                    
                    if (board[i, j].GetShip() != null)
                    {
                        board[i, j].GetShip().PaintShip(g);
                    }
                    board[i, j].PaintCell(g,true);
                }
        }
        public void PaintBoard2(Graphics g)
        {
            g.DrawImage(this.pic, this.p);
            for (int i = 4; i < 14; i++)
                for (int j = 4; j < 14; j++)
                {                    
                    board[i, j].PaintCell(g, false);
                }
        }
        public Cell[,] GetBoard()
        {
            return this.board;
        }
        
        public bool IsAvilable(int i, int j, Ship s)
        {
            if (s != null)
            {
                //הפעולה מקבלת צוללת, שורה ועמודה ובודקת האם אפשר להניח שם את הצוללת הרצויה
                if (s.GetPosition() == true)
                {
                    if ((i - 4) + s.GetSize() <= 10)
                    {
                        if (this.GetBoard()[i, j].GetStatus() == true)//התא פנוי
                        {
                            return true;
                        }
                    }
                }
                else if ((j - 4) + s.GetSize() <= 10)
                {
                    if (this.GetBoard()[i, j].GetStatus() == true)//התא פנוי
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
        public bool CheckWinC(int founds)
        {
            if (founds == 5)
                return true;
            return false;
        }
        public bool CheckWinP(int founds)
        {
            if (founds == 5)
                return true;
            return false;
        }
        public void SetShipOnBoard(int i, int j)
        {
            int sI = i;
            int sJ = j;
            if (board[i, j].GetShip() != null)
            {                
                int size = board[i, j].GetShip().GetSize();
                bool position = board[i, j].GetShip().GetPosition();
                if (position == true)//אם הצוללת במאונך
                {
                    for (int i1 = 0; i1 < size; i1++)
                    {
                        board[sI, sJ].SetStatus(false);
                        sI++;
                    }
                }
                else//הצוללת במאוזן
                {
                    for (int j1 = 0; j1 < size; j1++)
                    {
                        board[sI, sJ].SetStatus(false);
                        sJ++;
                    }
                }
                board[i, j].GetShip().SetX(board[i, j].GetX());
                board[i, j].GetShip().SetY(board[i, j].GetY());
            }
        }

        public void RemoveShipOfBoard(int oldI, int oldJ)
        {
            int sI = oldI;
            int sJ = oldJ;
            int size = board[oldI, oldJ].GetShip().GetSize();
            bool position = board[oldI, oldJ].GetShip().GetPosition();
            if (position == true)//אם הצוללת במאונך
            {

                for (int i1 = 0; i1 < size; i1++)
                {
                    board[sI, sJ].SetStatus(true);
                    sI++;
                }
                
            }
            else//הצוללת במאוזן
            {

                for (int j1 = 0; j1 < size; j1++)
                {
                    board[sI, sJ].SetStatus(true);
                    sJ++;
                }               
            }
            board[oldI, oldJ].RemoveShip();
        }
        public void MoveBoard(int x, int y)
        {
            int x1 = x;
            int y1 = y;
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    board[i, j].SetX(x1);
                    board[i, j].SetY(y1);
                    if (board[i, j].GetShip() != null)
                    {
                        board[i, j].GetShip().SetX(x1);
                        board[i, j].GetShip().SetY(y1);
                    }
                    x1 = x1 + 30;
                }
                x1 = x;
                y1 = y1 + 30;
            }
            this.p = new Point(x + 66, y + 66);
        }
        public bool CheckBoard()
        {
            int size, j1, i1, mone=0;
            for (int i = 4; i < 14; i++)
            {
                for (int j = 4; j < 14; j++)
                {
                    if (board[i, j].GetStatus() == false)
                        mone++;
                }
            }
            if (mone != 17)
                return false;
            
            for (int i = 4; i < 14; i++)
            {
                for (int j = 4; j < 14; j++)
                {
                    if (board[i, j].GetShip() != null)
                    {
                        size = board[i, j].GetShip().GetSize();
                        if (board[i, j].GetShip().GetPosition())//אם הצוללת מונחת במאונך                        
                        {
                            i1 = i;
                            if (board[i1 - 1, j + 1].GetStatus() == false)
                                return false;
                            if (board[i1 - 1, j].GetStatus() == false)
                                return false;
                            for (int s = 0; s <= size; s++)
                            {
                                if (board[i1, j + 1].GetStatus() == false)
                                    return false;
                                i1++;
                            }
                            if (board[i1 - 1, j].GetStatus() == false)
                                return false;
                        }
                        else
                        {
                            j1 = j;
                            if (board[i + 1, j1 - 1].GetStatus() == false)
                                return false;
                            if (board[i, j1 - 1].GetStatus() == false)
                                return false;
                            for (int s = 0; s <= size; s++)
                            {
                                if (board[i + 1, j1].GetStatus() == false)
                                    return false;
                                j1++;
                            }
                            if (board[i, j1 - 1].GetStatus() == false)
                                return false;
                        }
                    }
                }
            }
            return true;
        }
        
        public bool CheckShip(Ship s, int i, int j)
        {
            // הפעולה מקבלת צוללת ושורה ןעמודה רצויים לראש צוללת
            //הפעולה תחזיר שקר אם הצוללת חורגת מגבולות המטריצה
            bool position = s.GetPosition();
            int size = s.GetSize();
            int i1 = i;
            int j1 = j;//משתני עזר כדי לא "לקלקל" את המשתנים המקוריים
            if (position == true)//אם הצוללת מונחת במאונך
            {
                if (i1 + size >= 14)
                    return false;
            }
            else
                if (j1 + size >= 14)
                    return false;            
            //הפעולה תחזיר שקר אם הצוללת מונחת על גבי צוללת אחרת

            //הפעולה מחזירה אמת אם הצוללת מונחת באופן חוקי על הלוח - אחרת מחזירה שקר
            if (position == true)//אם הצוללת מונחת במאונך
            {
               
                for (int k = i - 1; k <= i + size; k++)
                {
                    for (int l = j - 1; l < j + 2; l++)
                    {
                        if (board[k, l].GetStatus() == false)
                            return false;                      
                    }
                }
            }
            else // הצוללת מונחת במאוזן
            {
                for (int k = i - 1; k < i + 2; k++)
                {
                    for (int l = j - 1; l <= j + size; l++)
                    {
                        if (board[k, l].GetStatus() == false)
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
