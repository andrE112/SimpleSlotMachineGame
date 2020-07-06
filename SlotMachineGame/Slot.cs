using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineGame
{
    class Slot
    {
        private PictureBox picture1;
        private PictureBox picture2;
        private int scroll = 0;
        private const int SPEED = 75;
        private bool running = false;
        private string result;

        public string Result
        {
            get { return result; }
        }

        public Slot(PictureBox picture1, PictureBox picture2)
        {
            this.picture1 = picture1;
            this.picture2 = picture2;
        }

        public void Update()
        {
            running = true;
            if (picture1.Location.Y >= picture1.Height)
            {
                picture1.Location = new Point(picture1.Location.X, -600);
                scroll = 0;
            }
            if (picture2.Location.Y >= picture1.Height)
            {
                picture2.Location = new Point(picture2.Location.X, -600);
                scroll = 0;
            }
            picture1.Location = new Point(picture1.Location.X, picture1.Location.Y + SPEED);
            picture2.Location = new Point(picture2.Location.X, picture2.Location.Y + SPEED);
            scroll += SPEED;
        }

        public string Stop()
        {
            if (running)
            {
                running = false;
                if (scroll >= 0 && scroll <= 200)
                {
                    result = "Seven";
                    scroll = 200 - scroll;
                    picture1.Location = new Point(picture1.Location.X, picture1.Location.Y + scroll);
                    picture2.Location = new Point(picture2.Location.X, picture2.Location.Y + scroll);
                }
                else if (scroll > 200 && scroll <= 400)
                {
                    result = "Lemon";
                    scroll = 400 - scroll;
                    picture1.Location = new Point(picture1.Location.X, picture1.Location.Y + scroll);
                    picture2.Location = new Point(picture2.Location.X, picture2.Location.Y + scroll);

                }
                else if (scroll > 400 && scroll <= 600)
                {
                    result = "Diamond";
                    scroll = 600 - scroll;
                    picture1.Location = new Point(picture1.Location.X, picture1.Location.Y + scroll);
                    picture2.Location = new Point(picture2.Location.X, picture2.Location.Y + scroll);

                }
            }

            return result;
        }


    }
}
