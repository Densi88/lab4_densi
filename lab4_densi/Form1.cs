namespace lab4_densi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowInfo();

        }
        List<Drinks> drinks = new List<Drinks>();
        private void ShowInfo()
        {
            int juiceCount = 0;
            int sodaCount = 0;
            int alcoCount = 0;
            foreach (var drink in this.drinks)
            {
                if (drink is Juice)
                {
                    juiceCount++;
                }
                else if (drink is Soda)
                {
                    sodaCount++;
                }
                else if (drink is Alco)
                {

                    alcoCount++;
                }
            }
            txtInfo.Text = "���\t����\t����"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", juiceCount, sodaCount, alcoCount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.drinks.Clear();
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var randomValue = random.Next() % 3;
                switch (randomValue)
                {
                    case 0:
                        this.drinks.Add(Juice.Generate());
                        break;
                    case 1:
                        this.drinks.Add(Soda.Generate());
                        break;
                    case 2:
                        this.drinks.Add(Alco.Generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.drinks.Count == 0)
            {
                txtOut.Text = "����� Q_Q";
                return;
            }
            var drink = this.drinks[0];
            this.drinks.RemoveAt(0);

            // ������� ���� if`�
            txtOut.Text = drink.GetInfo();
            ShowInfo();
        }
    }
}