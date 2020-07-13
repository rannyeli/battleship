using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BattleShip
{
    public partial class Game : Form
    {
        Graphics g;
        Board game1;
        Board game2;
        Ship s1;
        Ship s2;
        Ship s3;
        Ship s4;
        Ship s5;
        Ship s = new Ship();
        Ship sComp = new Ship();
        Ship sPlayer = new Ship();
        Random rnd = new Random();
        bool boardCreated = false;//האם סיימנו להקים את הלוח שלנו
        int t = 0;
        Find f;
        bool CompTurnDone;//האם הסתיים התור של המחשב
        int countC = 0;//מספר התאים שפוצצו-מחשב
        int sizeC = 0;//מחשב-גודל הצוללת
        bool posC = true;//מנח הצוללת-מחשב
        int firstIC = 0;//השורה של התא הראשון בצוללת-מחשב
        int firstJC = 0;//העמודה של התא הראשון בצוללת-מחשב
        int countP = 0;//מספר התאים שפוצצו-שחקן
        int sizeP = 0;//גודל הצוללת-שחקן
        bool posP = true;//מנח הצוללת-שחקן
        int firstIP = 0;// השורה של התא הראשון בצוללת -שחקן
        int firstJP = 0;//העמודה של התא הראשון בצוללת-שחקן
        bool ifFound = false;
        int countFoundsC = 0;//מספר הצוללות שגילה המחשב
        int countFoundsP = 0;//מספר הצוללות שגילה השחקן
        
        public Game()
        {
            InitializeComponent();  
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            game1 = new Board(280,150);
            s1 = new Ship();
            s1.SetX(753);
            s1.SetY(307);
            s1.SetSize(5);
            s2 = new Ship();
            s2.SetX(856);
            s2.SetY(328);
            s2.SetSize(4);
            s3 = new Ship();
            s3.SetX(753);
            s3.SetY(470);
            s3.SetSize(3);
            s4 = new Ship();
            s4.SetX(856);
            s4.SetY(470);
            s4.SetSize(3);
            s5 = new Ship();
            s5.SetX(941);
            s5.SetY(500);
            s5.SetSize(2);
        }

        private void Game1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if (boardCreated == false)
            {                
                s1.PaintShip(g);
                s2.PaintShip(g);
                s3.PaintShip(g);
                s4.PaintShip(g);
                s5.PaintShip(g);
                EnemyTurn.Hide();
                PlayerTurn.Hide();
                player.Hide();
                enemy.Hide();
                game1.PaintBoard(g); 
            }
            else
            {
                game1.MoveBoard(150, 150);
                game2.PaintBoard2(g);
                player.Show();
                enemy.Show();
                battle.Hide();
                explain.Hide();
                if (t == 0)
                {
                    EnemyTurn.Hide();
                    PlayerTurn.Show();
                }
                else
                {
                    PlayerTurn.Hide();
                    EnemyTurn.Show();
                }
            }
            game1.PaintBoard(g);            
        }

        private void menu_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Game1_MouseDown(object sender, MouseEventArgs e)
        {
            s = null;
            if (boardCreated == false)
            {
                g = CreateGraphics();
                int x = e.X;
                int y = e.Y;
                if (s1.GetPosition() == true)
                {
                    if (x >= s1.GetX() && x <= s1.GetX() + 22 && y >= s1.GetY() && y <= s1.GetY() + 125)//ship5
                        s = this.s1;
                }
                else if (x >= s1.GetX() && x <= s1.GetX() + 125 && y >= s1.GetY() && y <= s1.GetY() + 22)
                    s = this.s1;
                if (s2.GetPosition() == true)
                {
                    if (x >= s2.GetX() && x <= s2.GetX() + 22 && y >= s2.GetY() && y <= s2.GetY() + 105)//ship4
                        s = this.s2;
                }
                else if (x >= s2.GetX() && x <= s2.GetX() + 105 && y >= s2.GetY() && y <= s2.GetY() + 22)
                    s = this.s2;
                if (s3.GetPosition() == true)
                {
                    if (x >= s3.GetX() && x <= s3.GetX() + 22 && y >= s3.GetY() && y <= s3.GetY() + 85)//ship3
                        s = this.s3;
                }
                else if (x >= s3.GetX() && x <= s3.GetX() + 85 && y >= s3.GetY() && y <= s3.GetY() + 22)
                    s = this.s3;
                if (s4.GetPosition() == true)
                {
                    if (x >= s4.GetX() && x <= s4.GetX() + 22 && y >= s4.GetY() && y <= s4.GetY() + 85)//ship3(2)
                        s = this.s4;
                }
                else if (x >= s4.GetX() && x <= s4.GetX() + 85 && y >= s4.GetY() && y <= s4.GetY() + 22)
                    s = this.s4;
                if (s5.GetPosition() == true)
                {
                    if (x >= s5.GetX() && x <= s5.GetX() + 22 && y >= s5.GetY() && y <= s5.GetY() + 65)//ship2
                        s = this.s5;
                }
                else if (x >= s5.GetX() && x <= s5.GetX() + 65 && y >= s5.GetY() && y <= s5.GetY() + 22)
                    s = this.s5;
                if (s != null)
                {
                    if (x >= 400 && x <= 700 && y >= 270 && y <= 570)//האם הלחיצה הייתה בגבולות המשחק
                    {
                        int oldI = (s.GetY() - 150) / 30;
                        int oldJ = (s.GetX() - 280) / 30;
                        if (game1.GetBoard()[oldI, oldJ].GetShip() != null)
                            game1.RemoveShipOfBoard(oldI, oldJ);
                    }
                }
            }
        }

        private void Game1_MouseUp(object sender, MouseEventArgs e)
        {
            if (boardCreated == false)
            {
                g = CreateGraphics();
                int x = e.X;
                int y = e.Y;
                if (x >= 400 && x <= 700 && y >= 270 && y <= 570)//האם הלחיצה הייתה בגבולות המשחק
                {
                    int i = (y - 150) / 30;
                    int j = (x - 280) / 30;

                    if (game1.IsAvilable(i, j, s) == true)//התא פנוי
                    {
                        x = game1.GetBoard()[i, j].GetX();
                        y = game1.GetBoard()[i, j].GetY();
                        s.SetX(x);
                        s.SetY(y);
                        game1.GetBoard()[i, j].SetShip(s);
                        game1.SetShipOnBoard(i, j);
                    }
                    Refresh();
                }
            }
            s = null;
        }

        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            boardCreated = false;
            battle.Show();
            explain.Show();
            game1 = new Board(280, 150);
            game2 = new Board(650, 150);
            s1 = new Ship();
            s1.SetX(753);
            s1.SetY(307);
            s1.SetSize(5);
            s2 = new Ship();
            s2.SetX(856);
            s2.SetY(328);
            s2.SetSize(4);
            s3 = new Ship();
            s3.SetX(753);
            s3.SetY(470);
            s3.SetSize(3);
            s4 = new Ship();
            s4.SetX(856);
            s4.SetY(470);
            s4.SetSize(3);
            s5 = new Ship();
            s5.SetX(941);
            s5.SetY(500);
            s5.SetSize(2);
            s = null;
            countC = 0;//מספר התאים שפוצצו-מחשב
            sizeC = 0;//מחשב-גודל הצוללת
            posC = true;//מנח הצוללת-מחשב
            firstIC = 0;//השורה של התא הראשון בצוללת-מחשב
            firstJC = 0;//העמודה של התא הראשון בצוללת-מחשב
            countP = 0;//מספר התאים שפוצצו-שחקן
            sizeP = 0;//גודל הצוללת-שחקן
            posP = true;//מנח הצוללת-שחקן
            firstIP = 0;// השורה של התא הראשון בצוללת -שחקן
            firstJP = 0;//העמודה של התא הראשון בצוללת-שחקן
            ifFound = false;
            countFoundsC = 0;//מספר הצוללות שגילה המחשב
            countFoundsP = 0;//מספר הצוללות שגילה השחקן
            Refresh();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions a = new Instructions();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("האם אתה בטוח שברצונך לצאת מהמשחק?", "יציאה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Game1_MouseClick(object sender, MouseEventArgs e)
        {
            bool legalClick = true;//הלחיצה חוקית
            int x = e.X;
            int y = e.Y;
            if (boardCreated == false)//אם עדיין לא בנינו את הלוח שלנו
            {
                if (s == null)//לא נבחרה צוללת
                    legalClick = false;//הלחיצה לא חוקית                
            }

            if (legalClick == true && e.Button == MouseButtons.Right)
            {                
                int i = (y - 150 )/30;
                int j = (x - 280)/30;
                //ship5
                if (s1.GetPosition() == true)
                {
                    if (x >= s1.GetX() && x <= s1.GetX() + 22 && y >= s1.GetY() && y <= s1.GetY() + 125)
                    { 
                        s1.SetPosition(!(s1.GetPosition()));
                        s1.PaintShip(g); 
                    }
                }
                else if (y >= s1.GetY() && y <= s1.GetY() + 22 && x >= s1.GetX() && x <= s1.GetX() + 125)
                {
                    s1.SetPosition(!(s1.GetPosition()));
                    s1.PaintShip(g);
                }
                //ship4
                if (s2.GetPosition() == true)
                {
                    if (x >= s2.GetX() && x <= s2.GetX() + 22 && y >= s2.GetY() && y <= s2.GetY() + 105)
                    {
                        s2.SetPosition(!(s2.GetPosition()));
                        s2.PaintShip(g);
                    }
                }
                else if (y >= s2.GetY() && y <= s2.GetY() + 22 && x >= s2.GetX() && x <= s2.GetX() + 105)
                {
                    s2.SetPosition(!(s2.GetPosition()));
                    s2.PaintShip(g);
                }
                //ship3
                if (s3.GetPosition() == true)
                {
                    if (x >= s3.GetX() && x <= s3.GetX() + 22 && y >= s3.GetY() && y <= s3.GetY() + 85)
                    {
                        s3.SetPosition(!(s3.GetPosition()));
                        s3.PaintShip(g);
                    }
                }
                else if (y >= s3.GetY() && y <= s3.GetY() + 22 && x >= s3.GetX() && x <= s3.GetX() + 85)
                {
                    s3.SetPosition(!(s3.GetPosition()));
                    s3.PaintShip(g);
                }
                //ship3(2)
                if (s4.GetPosition() == true)
                {
                    if (x >= s4.GetX() && x <= s4.GetX() + 22 && y >= s4.GetY() && y <= s4.GetY() + 85)
                    {
                        s4.SetPosition(!(s4.GetPosition()));
                        s4.PaintShip(g);
                    }
                }
                else if (y >= s4.GetY() && y <= s4.GetY() + 22 && x >= s4.GetX() && x <= s4.GetX() + 85)
                {
                    s4.SetPosition(!(s4.GetPosition()));
                    s4.PaintShip(g);
                }
                //ship2
                if (s5.GetPosition() == true)
                {
                    if (x >= s5.GetX() && x <= s5.GetX() + 22 && y >= s5.GetY() && y <= s5.GetY() + 65)
                    {
                        s5.SetPosition(!(s5.GetPosition()));
                        s5.PaintShip(g);
                    }
                }
                else if (y >= s5.GetY() && y <= s5.GetY() + 22 && x >= s5.GetX() && x <= s5.GetX() + 65)
                {
                    s5.SetPosition(!(s5.GetPosition()));
                    s5.PaintShip(g);
                }
                
            }
            else
            {
                if (legalClick == true && boardCreated == true)
                {
                    g = CreateGraphics();
                    if (t == 0)
                    {
                        int i = (y - 150) / 30;
                        int j = (x - 650) / 30;
                        if (x >= 770 && x <= 1070 && y >= 270 && y <= 570 && game2.GetBoard()[i, j].GetHit() == 0)//האם הלחיצה הייתה בגבולות המשחק
                        {
                            if (game2.GetBoard()[i, j].GetStatus())
                                game2.GetBoard()[i, j].SetHit(1);
                            else
                            {
                                game2.GetBoard()[i, j].SetHit(2);
                                if (game2.GetBoard()[i, j].GetShip() != null)
                                {
                                    sizeP = game2.GetBoard()[i, j].GetShip().GetSize();
                                    posP = game2.GetBoard()[i, j].GetShip().GetPosition();
                                    firstIP = i;
                                    firstJP = j;
                                }
                                countP++;
                            }
                            if (countP != 0 && sizeP == countP)
                            {
                                if (posP == true)
                                {
                                    for (int k = firstIP - 1; k <= firstIP + sizeP; k++)
                                    {
                                        for (int l = firstJP - 1; l < firstJP + 2; l++)
                                        {
                                            if (game2.GetBoard()[k, l].GetHit() == 0)
                                                game2.GetBoard()[k, l].SetHit(1);
                                        }
                                    }
                                }
                                else
                                {
                                    for (int l = firstJP - 1; l <= firstJP + sizeP; l++)
                                    {
                                        for (int k = firstIP - 1; k < firstIP + 2; k++)
                                        {
                                            if (game2.GetBoard()[k, l].GetHit() == 0)
                                                game2.GetBoard()[k, l].SetHit(1);
                                        }
                                    }
                                }
                                sizeP = 0;
                                countP = 0;
                                posP = true;
                                firstIP = 0;
                                firstJP = 0;
                                countFoundsP++;
                            }
                            Refresh();
                            if (game2.CheckWinP(countFoundsP))
                            {
                                MessageBox.Show("כל הכבוד! ניצחת בקרב!");
                                this.Close();
                            }
                            if (game2.GetBoard()[i, j].GetHit() == 1)
                                t = (t * -1) + 1;
                        }
                    }
                    Refresh(); 
                    Thread.Sleep(1000);                    
                    EnemyMove();
                }
            }

            Refresh();
        }

        private void EnemyMove()
        {            
            while (t == 1)
            {
                int i; int j;
                if (f == null)
                {
                    i = rnd.Next(10) + 4;
                    j = rnd.Next(10) + 4;
                    while (game1.GetBoard()[i, j].GetHit() != 0)
                    {
                        i = rnd.Next(10) + 4;
                        j = rnd.Next(10) + 4;
                    }
                    CompTurnDone = SetHit1(i, j);
                    if (CompTurnDone == false)
                   {
                       f = new Find();
                       f.SetShura(i);
                       f.SetAmuda(j);
                   }
                   else
                       t = (t * -1) + 1;
                }
                else
                {                                                       
                    int shura = f.GetShura();
                    int amuda = f.GetAmuda();
                    CompTurnDone = false;
                    bool direct = false;//כיוון הצוללות: אמת- מאונך ,שקר- מאוזן
                    while (CompTurnDone == false && ifFound == false)//כל עוד לא הסתיים התור של המחשב ולא התגלתה הצוללת
                    {                       
                        //מחפשים ימינה
                        if (amuda < 13 && game1.GetBoard()[shura, amuda + 1].GetHit() == 0 && direct == false)//עדיין לא ניסינו את התא
                        {
                            amuda = amuda + 1;
                            CompTurnDone = SetHit1(shura, amuda);
                            if (game1.GetBoard()[shura, amuda + 1].GetHit() == 2)//בתא מימין יש פגיעה
                            {
                                int amuda1 = amuda;
                                while (game1.GetBoard()[shura, amuda + 1].GetHit() == 2 && amuda + 1 < 14)
                                {
                                    amuda = amuda + 1;
                                    CompTurnDone = SetHit1(shura, amuda);
                                }
                                //צריך להמשיך לחפש שמאלה
                                while (CompTurnDone == false && game1.GetBoard()[shura, amuda - 1].GetHit() == 2 && amuda - 1 >= 4)
                                {
                                    amuda = amuda1;
                                    amuda = amuda - 1;
                                    CompTurnDone = SetHit1(shura, amuda);
                                }
                            }
                        }
                        else
                        {
                            //מחפשים שמאלה
                            amuda = f.GetAmuda();
                            if (amuda > 4 && game1.GetBoard()[shura, amuda - 1].GetHit() == 0 && direct == false)//עדיין לא ניסינו את התא
                            {
                                amuda = amuda - 1;
                                CompTurnDone = SetHit1(shura, amuda);

                                if (amuda > 4 && game1.GetBoard()[shura, amuda].GetHit() == 2)//בתא משמאל יש פגיעה
                                {
                                    int amuda1 = amuda;
                                    while (CompTurnDone == false && game1.GetBoard()[shura, amuda].GetHit() == 2 && amuda - 1 >= 4)
                                    {
                                        amuda = amuda - 1;
                                        CompTurnDone = SetHit1(shura, amuda);
                                    }
                                }
                            }
                            else
                            {
                                if (CompTurnDone == false && ifFound == false)
                                {
                                    //מחפשים למטה
                                    if (shura + 1 < 14 && game1.GetBoard()[shura + 1, amuda].GetHit() == 0)//עדיין לא ניסינו את התא
                                    {
                                        shura = shura + 1;
                                        CompTurnDone = SetHit1(shura, amuda);

                                        if (CompTurnDone == false && game1.GetBoard()[shura, amuda].GetHit() == 2)//בתא מלמטה יש פגיעה
                                        {
                                            int shura1 = shura;
                                            while (CompTurnDone == false && game1.GetBoard()[shura, amuda].GetHit() == 2 && shura + 1 < 14 && game1.GetBoard()[shura + 1, amuda].GetHit() == 0)
                                            {
                                                shura = shura + 1;
                                                CompTurnDone = SetHit1(shura, amuda);
                                            }
                                            direct = true;
                                        }
                                    }
                                    else
                                    {
                                        //מחפשים למעלה
                                        shura = f.GetShura();
                                        if (shura > 4 && game1.GetBoard()[shura - 1, amuda].GetHit() == 0)//עדיין לא ניסינו את התא
                                        {
                                            shura = shura - 1;
                                            CompTurnDone = SetHit1(shura, amuda);

                                            if (CompTurnDone == false && game1.GetBoard()[shura, amuda].GetHit() == 2)//בתא מלעמלה יש פגיעה
                                            {
                                                int shura1 = shura;
                                                while (CompTurnDone == false && game1.GetBoard()[shura, amuda].GetHit() == 2 && shura - 1 >= 4)
                                                {
                                                    shura = shura - 1;
                                                    CompTurnDone = SetHit1(shura, amuda);
                                                }
                                                direct = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (ifFound == false)
                        t = (t * -1) + 1;
                }
                if (game1.CheckWinC(countFoundsC))
                {
                    MessageBox.Show("הפסדת בקרב:(");
                    this.Close();
                    t = (t * -1) + 1;
                }
            }
            Refresh();    
        }

        private void battle_MouseClick(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            if (game1.CheckBoard())
            {
                game2 = new Board(650, 150);
                CreateBoard();
                game2.PaintBoard2(g);
                game1.PaintBoard(g); 
            }
            else MessageBox.Show("קיימת שגיאה בהצבתך, עליך להציב את כל הצוללות על הלוח וברווח משבצת אחת לפחות בין כל צוללת.");
            
            Refresh();
        }
     
        public bool SetHit1(int i, int j)
        {
            Thread.Sleep(1000);
            if (game1.GetBoard()[i, j].GetStatus() == false)
            {
                ifFound = false;
                game1.GetBoard()[i, j].SetHit(2);
                countC++;
                if (game1.GetBoard()[i, j].GetShip() != null)
                {
                    sizeC = game1.GetBoard()[i, j].GetShip().GetSize();
                    posC = game1.GetBoard()[i, j].GetShip().GetPosition();
                    firstIC = i;
                    firstJC = j;                    
                }
                if (countC != 0 && sizeC == countC)
                {
                    if (posC == true)//אם הצוללת מונחת במאונך
                    {
                        for (int k = firstIC-1; k <= firstIC + sizeC; k++)
                        {
                            for (int l = firstJC - 1; l < firstJC + 2; l++)
                            {
                                if(game1.GetBoard()[k, l].GetHit() == 0)
                                    game1.GetBoard()[k, l].SetHit(1);
                            }
                        }
                    }
                    else // הצוללת מונחת במאוזן
                    {
                        for (int l = firstJC - 1; l <= firstJC + sizeC; l++)
                        {
                            for (int k = firstIC - 1; k < firstIC + 2; k++)
                            {
                                if (game1.GetBoard()[k, l].GetHit() == 0)
                                    game1.GetBoard()[k, l].SetHit(1);
                            }
                        }
                    }
                    
                    f = null;
                    sizeC = 0;
                    countC = 0;
                    posC = true;
                    firstIC = 0;
                    firstJC = 0;
                    ifFound = true;
                    countFoundsC++;
                }
                Refresh();
                return false;
            }
            else
            {
                game1.GetBoard()[i, j].SetHit(1);
                Refresh();
                return true;
            }
        }

        public void CreateBoard()
        {
            int i1 = 0, j1 = 0;
            bool position;
            for (int i = 1; i <= 5; i++)
            {
                Ship sT = new Ship();
                switch (i)
                {
                    case 1:
                        sT = new Ship();
                        sT.SetSize(s4.GetSize());
                        break;
                    case 2:
                        sT = new Ship();
                        sT.SetSize(s5.GetSize());
                        break;
                    case 3 :
                        sT = new Ship();
                        sT.SetSize(s3.GetSize());
                        break;
                    case 4 :
                        sT = new Ship();
                        sT.SetSize(s2.GetSize());
                        break;
                    case 5 :
                        sT = new Ship();
                        sT.SetSize(s1.GetSize());
                        break;

                }
                i1 = rnd.Next(10) + 4;
                j1 = rnd.Next(10) + 4;
                if (rnd.Next(2) == 0)
                    position = true;
                else
                    position = false;
                sT.SetPosition(position);
                while (game2.CheckShip(sT, i1, j1) == false)
                {
                    i1 = rnd.Next(10) + 4;
                    j1 = rnd.Next(10) + 4;
                }
                game2.GetBoard()[i1, j1].SetShip(sT);
                game2.SetShipOnBoard(i1, j1);
            }
            boardCreated = true;
        }

    }
}
