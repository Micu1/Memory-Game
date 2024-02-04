using Microsoft.VisualBasic;

namespace Memory_game
{
    public partial class Form1 : Form
    {
        bool Click = false;
        PictureBox G1;
        Random rnd = new Random();

        int timp = 60;

        public Form1()
        {
            InitializeComponent();
        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.img1,
                    Properties.Resources.img2,
                    Properties.Resources.img3,
                    Properties.Resources.img4,
                    Properties.Resources.img5,
                    Properties.Resources.img6,
                    Properties.Resources.img7,
                    Properties.Resources.img8
                    

                };
            }
        }
        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                timp--;
                if (timp < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Timpul s-a scurs");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(timp);
                label1.Text = "00:" + timp.ToString();
            };
        }
        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            timp = 60;
            timer.Start();
        }
        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
                
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            } while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }
        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void ClickTimer_tick(object sender, EventArgs e)
        {
            HideImages();
            Click = true;
            ctimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Visible = false;
            }
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!Click) return;
            var pic = (PictureBox)sender;
            if (G1 == null)
            {
                G1 = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == G1.Image && pic != G1)
            {
                pic.Visible = G1.Visible = false;
                { G1 = pic; }
                HideImages();
            }
            else
            {
                Click = false;
                ctimer.Start();
            }
            G1 = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("Ai castigat, incearca din nou");
            ResetImages();
        }
        
        private void startGame(object sender, EventArgs e)
        {
            foreach (PictureBox pic in pictureBoxes)
            {
                pic.Visible = true;
            }
            label2.Visible = false;  
            Click = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            ctimer.Interval = 1000;
            ctimer.Tick += ClickTimer_tick;
            button1.Enabled = false;
        }
    }
}
