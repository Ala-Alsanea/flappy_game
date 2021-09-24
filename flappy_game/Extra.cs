using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappy_game
{
    class Extra
    {
        

        public int changeToPositive(int num)
        {
            if (isPositive(num))
                return num;

            return num * -1;
        }

        public int changeToNagitive(int num)
        {
            if (!isPositive(num))
                return num;

            return num * -1;
        }

        bool isPositive(int num)
        {
            if (num >= 0)
                return true;

            return false;


        }

       public void pipMoves(Panel p1,Panel p2, int s )
        {
            p1.Left -= s;
            p2.Left -= s;

        }
        public int pipReset(Panel p1, Panel p2, int num)
        {
            if (p1.Left < -50)
            {
                p1.Left = 1000;
                num+=1;
            }

            if (p2.Left < -100)
            {
                p2.Left = 1200;
                num++;
            }

            return num;
        }

        public int increaseSpeed(int sp , int sc)
        {
            switch(sc)
            {
                case 5:
                    sp = 15;
                    break;

                case 15:
                    sp = 20;
                    break;

                case 20:
                    sp = 25;
                    break;

                default:
                    sp = sp;
                    break;
            }
            return sp;
        }
    }
}
