# Семинарска работа по Визуелно Програмирање - Simple Slot Machine Game
## Објаснување на апликацијата
Апликацијата е едноставна слот машина односно игра. Играта се состои од еден играч кој почнува со 100 поени и треба да напише колку поени сака да вложи пред да сврти (default bet = 10). Кога играчот ќе притисне на копчето "Spin" 3те слотови од кои секој слот се состои од 3 елементи (седмица, дијамант и лимон) почнуваат да се вртат. После кратко random време тие едно по друго почнуваат да застануваат. Кога сите 3 ќе застанат ако сите 3 слотови во средина (означена со црвена линија) покажуваат иста слика тогаш играчот добил jackpot и добива поени според соодветната слика.
Бодувањето на jackpot работи на следниот начин:
* Седмица: points += bet x 2
* Дијамант: points += bet x 1.5
* Лимон: points += bet x 1.25
Играта трае се додека играчот не ги изгуби сите поени. На крајот ако неговиот highscore (најмногу поени што имал во таа сесија) го надминува стариот тогаш автоматски се зачувува во binary file и се прикажува во играта.
## Опис на решавање на проблемот
1. При изработка на апликацијата најголемиот предизвик беше добра анимација и пресметка на кој елемент застанал слотот. За ефектот на вртење на слотовите да изгледа правилно и прегледно е искористено 3 објекти од мојата класа ```Slot``` која содржи 2 pictureBox како пар за секој слот. Тие се движат со повикување на методата ```Update()``` од класата ```Slot``` додека трае timer-от ```tmrSlot1``` кој прави Tick на интервал од 1ms. Додека трае timer-от тој константно проверува дали истекло времето за вртење на слотовите и ако истекло да повика методата ```Stop()``` од класата ```Slot``` за соодветниот слот. Кога ќе застанат сите се прави уште една проверка дали добил jackpot или не. Ако добил тогаш се повикува функцијата ```Score()``` која одредува колку поени да добие. Ако не добие тогаш се прави уште една проверка која проверува дали ги изгубил сите поени и ако да тогаш да го провери highscore-от и да го запише ако треба и да ги ресетира поените и играта.

```
private void tmrSlot1_Tick(object sender, EventArgs e)
        {
            btnSpin.Enabled = false;
            betBox.Enabled = false;
            SoundPlayer clink = new SoundPlayer(Properties.Resources.clink);
            counter += 10;
            if (counter >= time)
            {
                check[0] = slot1.Stop();
            }
            else
            {
                slot1.Update();
            }
            if (counter >= time * 2)
            {
                check[1] = slot2.Stop();
            }
            else
            {
                slot2.Update();
            }
            if (counter >= time * 3)
            {
                check[2] = slot3.Stop();
                btnSpin.Enabled = true;
                betBox.Enabled = true;
                tmrSlot1.Stop();
                counter = 0;
                if (check[0] == check[1] && check[1] == check[2])
                {
                    SoundPlayer jackpot = new SoundPlayer(Properties.Resources.jackpot);
                    jackpot.Play();
                    MessageBox.Show("JACKPOT!");
                    background.PlayLooping();
                    Score();
                    pointsLabel.Text = "Points: " + points;
                }
                else
                {
                    pointsLabel.Text = "Points: " + points;
                    if (points <= 0)
                    {
                        SoundPlayer gameover = new SoundPlayer(Properties.Resources.gameOver);
                        gameover.Play();
                        MessageBox.Show("YOU RAN OUT OF POINTS!");
                        WriteHighScore();
                        DisplayNewHighScore();
                        background.PlayLooping();
                        points = 100;
                        pointsLabel.Text = "Points: " + points;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    check[i] = "";
                }
            }
            else
            {
                slot3.Update();
            }
        }
```


2. За запис и читање на highscore имам 3 функции WriteHighScore(), DisplayHighScore() и DisplayNewHighScore().

```
public void WriteHighScore()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(highscore);
            }
        }
```
Оваа функција ја користам за запишување на highscore во binary file.

```
public void DisplayHighScore()
        {
            int highscoreRead;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    highscoreRead = reader.ReadInt32();
                }

                    labelHighscore.Text = "HighScore: " + highscoreRead;
                    highscore = highscoreRead;
            }
        }
```
Оваа функција ја користам за читање на highscore од binary file при стартување на апликацијата.

```
public void DisplayNewHighScore()
        {
            int highscoreRead;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    highscoreRead = reader.ReadInt32();
                }

                if (highscoreRead >= highscore)
                {
                    highscore = highscoreRead;
                    labelHighscore.Text = "HighScore: " + highscoreRead;
                }
            }
        }
```
Оваа функција ја користам за читање на highscore од binary file и прикажување на истиот во играта.

## Опис на класата Slot.cs
Во оваа класа се чуваат два oictureBox, integer scroll кој се користи за детекција на моментална слика која е во сред од слотот, константен integer SPEED која е брзината на движење на слотовите, bool running кој се користи за проверка дали се движи слотот и еден string result во кој го чувам резултатот на слотот при крај на вртењето.

```
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
```
Во оваа класа како што спомнав има 2 методи ```Update()``` и ```Stop()```. 
* Методата ```Update()``` ја користам за движење на слотот. Во методата најпрво давам true вредност на running за да означам дека се движи и има две проверки со кои што проверуваме дали двете слики посебно (парот слики кои се еден врз друг) ја преминале границата и да ги врати на соодветната позиција. По извршување на двете проверки ги поместува сликите по Y оската за нивната локација на Y оската+брзината (односно за колку да ги помести) и на крај променливата scroll ја зголемувам за константната вредност SPEED (со ова додавам дека била помрдната за толку).
* Методата ```Stop()``` ја користам за стопирање на движењето и пресметка според моја формула на кој елемент застанал слотот (односно кој елемент навлегол во средината). Прво ако се движи (running=true) давам false вредност на running за да означам дека веќе не се движи и потоа вршам проверка дали се паднало на седмица, лимон или дијамант. Потоа проверува колку вкупно се помрднале сликите со променливата scroll и според тоа одредува на кој елемент се паднало, ја менува вредноста на result според кое се паднало и го наместува тоа точно во сред. На крај методата го враќа резултатот (result).
##Screenshots
* 




     
