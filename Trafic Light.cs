using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kurs_Interfeces
{
    public class Trafic_Light
    {
        public int x; //координаты считаются относительно левого верхнего узла карты.
        public int y;
        public int state; //0 - красный, 1 - жёлный на зелёный, 2 - зелёный, 3 - режим ожидания, 4 - выключен, 5 - жёлтый на красный, 6 - прозрачный для ожидания
        public int red_timer;       //сколько времени светофор находится в каждом состоянии.
        public int yellow_timer;
        public int green_timer;
        public int seconds_left;
        public string comment; //комментарии про светофор
        public Trafic_Light(int inp_x, int inp_y, int inp_red, int inp_yellow, int inp_green, int inp_state = 4, string inp_comment = "")
        {
            x = inp_x;
            y = inp_y;
            red_timer = inp_red;
            yellow_timer = inp_yellow;
            green_timer = inp_green;
            state = inp_state;
            comment = inp_comment;
            switch (state)
            {
                case 0:
                    seconds_left = inp_red;
                    break;
                case 1:
                    seconds_left = inp_yellow;
                    break;
                case 2:
                    seconds_left = inp_green;
                    break;
                case 3:
                    seconds_left = 5;
                    break;
                case 4:
                    seconds_left = -1;
                    break;
                case 5:
                    seconds_left = inp_yellow;
                    break;
                case 6:
                    seconds_left = inp_yellow;
                    break;
            }
        }
        public void saveToFile(StreamWriter sw)
        {
            sw.WriteLine(x);
            sw.WriteLine(y);
            sw.WriteLine(state);
            sw.WriteLine(red_timer);
            sw.WriteLine(yellow_timer);
            sw.WriteLine(green_timer);
            sw.WriteLine(comment);
        }
    }
}
