using System;
using System.Windows.Forms;

namespace Praca_domowa_cpc_1_Patrycja_Zdradzisz
{
    public partial class FormGame : Form
    {
        /// <summary>
        /// zmienne odpowiadające za ilość surowców
        /// </summary>
        int gold = 200, ice = 10, wood = 0, fish = 10, knowledge = 0, penguins = 10, penguinGun = 0;
        /// <summary>
        /// zmienne przechowujące mijające sekundy dla timerEvent i timerAdd
        /// </summary>
        int counterEvents = 1, counterLevel = 1;
        /// <summary>
        /// zmienne przechowujące poziom dostępnych budynków do kupienia oraz PenguinGun
        /// </summary>
        int levelSawmill = 0, levelIgloo = 0, levelSchool = 0, levelFishingSpot = 0, levelPenguinGun = 0, levelGame = 1;

        public FormGame()
        {
            InitializeComponent();
            //uruchomienie obu timerów
            timerAdd.Start();
            timerEvent.Start();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            //zmiana tła na grafkę z wyspą i ustawienie jej pod rozmiar okna
            this.BackgroundImage = Properties.Resources.Island;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// funkcja odpowiedzialna za odjęcie randomowej ilości surowców podczas Eventu
        /// </summary>
        /// <param name="random"></param>
        private void thingsAfterEvent(int random)
        {
            if (gold >= random)
            {
                gold = gold - random;
                textBoxGold.Text = gold.ToString();
            }
            else
            {
                gold = 0;
                textBoxGold.Text = "0";
            }

            if (wood >= random)
            {
                wood = wood - random;
                textBoxWood.Text = wood.ToString();
            }
            else
            {
                wood = 0;
                textBoxWood.Text = "0";
            }

            if (ice >= random)
            {
                ice = ice - random;
                textBoxIce.Text = ice.ToString();
            }
            else
            {
                ice = 0;
                textBoxIce.Text = "0";
            }

            if (fish >= random)
            {
                fish = fish - random;
                textBoxFish.Text = fish.ToString();
            }
            else
            {
                fish = 0;
                textBoxFish.Text = "0";
            }

            if (knowledge >= random)
            {
                knowledge = knowledge - random;
                textBoxKnowledge.Text = knowledge.ToString();
            }
            else
            {
                knowledge = 0;
                textBoxKnowledge.Text = "0";
            }

            if (penguins >= random)
            {
                penguins = penguins - random;
                textBoxPenguin.Text = penguins.ToString();
            }
            else
            {
                penguins = 0;
                textBoxPenguin.Text = "0";
            }
        }

        /// <summary>
        /// funkcja przycisku Back to menu odpowiedzialna za powrót do okna z informacją o grze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            //zamknięcie okna z grą
            this.Close();
            //utworzenie obiektu klasy FormMain i wyświetenie okna
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        /// <summary>
        /// funkcja timerAdd, która dodaje surowce i sprawdza warunek na przegraną gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerAdd_Tick(object sender, EventArgs e)
        {
            //zwiększenie zmiennej conterLevel
            counterLevel++;
            //przypisanie dzielenia modulo conterLevel do zmiennej tymczasowej tmp2
            int tmp2 = counterLevel % 80;

            //jeśli spełniony warunek to zwiększanie wartości levelGame i wypisywanie obecnego poziomu do gry
            if(tmp2 == 0)
            {
                levelGame++;
                labelLevel.Text = "Level " + levelGame.ToString();
            }
            
            //jeśli spełniony warunek to zatrzymanie timerAdd, wypisanie wiadomości  przegranej i zamknięcie aplikacji
            if(levelGame == 4)
            {
                timerAdd.Stop();
                MessageBox.Show("Przegrałeś :( Nie udało ci się obronić przed niedźwiedziami. Twoje pingwiny zamiast pracować bawiły się z najeźdźcami i doprowadziły wioskę do ruiny.");
                Application.Exit();
            }

            //dodawanie surowców po każdej sekundzie
            gold = gold + 10;
            ice = ice + 4;
            textBoxGold.Text = gold.ToString();
            textBoxIce.Text = ice.ToString();

            wood = wood + levelSawmill * 2;
            textBoxWood.Text = wood.ToString();

            fish = fish + levelFishingSpot * 2;
            textBoxFish.Text = fish.ToString();

            knowledge = knowledge + levelSchool * 2;
            textBoxKnowledge.Text = knowledge.ToString();

            penguins = penguins + levelIgloo * 2;
            textBoxPenguin.Text = penguins.ToString();
        }

        /// <summary>
        /// funkcja przycisku buttonNewSchool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewSchool_Click(object sender, EventArgs e)
        {
            //warunek sprawdzający obecny poziom szkoły
            if (levelSchool == 0)
            {
                //warunek sprawdzający czy gracz ma odpowiednią ilość surowców
                if (gold >= 20 && penguins >= 20)
                {
                    //odjęcie surowców
                    gold = gold - 20;
                    penguins = penguins - 20;
                    //wypisanie aktualnych wartości
                    textBoxGold.Text = gold.ToString();
                    textBoxPenguin.Text = penguins.ToString();
                    //zwiększenie poziomu szkoły i wyisanie nowego tekstu na przycisk buttonNewSchool
                    levelSchool++;
                    buttonNewSchool.Text = " New School 40 Gold/ 40 Penguins";
                }
            }
            if (levelSchool == 1)
            {
                if (gold >= 40 && penguins >= 40)
                {
                    gold = gold - 40;
                    penguins = penguins - 40;
                    textBoxGold.Text = gold.ToString();
                    textBoxPenguin.Text = penguins.ToString();
                    levelSchool++;
                    buttonNewSchool.Text = " New School 60 Gold/ 60 Penguins";
                }
            }
            if (levelSchool == 2)
            {
                if (gold >= 60 && penguins >= 60)
                {
                    gold = gold - 60;
                    penguins = penguins - 60;
                    textBoxGold.Text = gold.ToString();
                    textBoxPenguin.Text = penguins.ToString();
                    levelSchool++;
                    buttonNewSchool.Text = " New School 80 Gold/ 80 Penguins";
                }
            }
            if (levelSchool == 3)
            {
                if (gold >= 80 && penguins >= 80)
                {
                    gold = gold - 80;
                    penguins = penguins - 80;
                    textBoxGold.Text = gold.ToString();
                    textBoxPenguin.Text = penguins.ToString();
                    buttonNewSchool.Text = " Max level School";
                    buttonNewSchool.Enabled = false;
                }
            }
        }

        /// <summary>
        /// funkcja przycisku buttonNewFishingSpot, działanie warunków jest anaogiczne jak w funkcji buttonNewSchool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewFishingSpot_Click(object sender, EventArgs e)
        {
            if (levelFishingSpot == 0)
            {
                if (gold >= 20 && wood >= 50)
                {
                    gold = gold - 20;
                    wood = wood - 50;
                    textBoxGold.Text = gold.ToString();
                    textBoxWood.Text = wood.ToString();
                    levelFishingSpot++;
                    buttonNewFishingSpot.Text = " New Fishing Spot 40 Gold/ 60 Wood";
                }
            }
            if (levelFishingSpot == 1)
            {
                if (gold >= 40 && wood >= 60)
                {
                    gold = gold - 40;
                    wood = wood - 60;
                    textBoxGold.Text = gold.ToString();
                    textBoxWood.Text = wood.ToString();
                    levelFishingSpot++;
                    buttonNewFishingSpot.Text = " New Fishing Spot 60 Gold/ 70 Wood";
                }
            }
            if (levelFishingSpot == 2)
            {
                if (gold >= 60 && wood >= 70)
                {
                    gold = gold - 60;
                    wood = wood - 70;
                    textBoxGold.Text = gold.ToString();
                    textBoxWood.Text = wood.ToString();
                    levelFishingSpot++;
                    buttonNewFishingSpot.Text = " New Fishing Spot 80 Gold/ 80 Wood";
                }
            }
            if (levelFishingSpot == 3)
            {
                if (gold >= 80 && wood >= 80)
                {
                    gold = gold - 80;
                    wood = wood - 80;
                    textBoxGold.Text = gold.ToString();
                    textBoxWood.Text = wood.ToString();
                    buttonNewFishingSpot.Text = " Max level Fishing Spot";
                    buttonNewFishingSpot.Enabled = false;
                }
            }
        }

        /// <summary>
        /// funkcja przycisku buttonNewIgloo, działanie warunków jest anaogiczne jak w funkcji buttonNewSchool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewIgloo_Click(object sender, EventArgs e)
        {
            if (levelIgloo == 0)
            {
                if (gold >= 50 && ice >= 50 && fish >= 20)
                {
                    gold = gold - 50;
                    ice = ice - 50;
                    fish = fish - 20;
                    textBoxGold.Text = gold.ToString();
                    textBoxIce.Text = ice.ToString();
                    textBoxFish.Text = fish.ToString();
                    levelIgloo++;
                    buttonNewIgloo.Text = " New Igloo 60 Gold/ 60 Ice/ 30 Fish";
                }
            }
            else if (levelIgloo == 1)
            {
                if (gold >= 60 && ice >= 60 && fish >= 30)
                {
                    gold = gold - 60;
                    ice = ice - 60;
                    fish = fish - 30;
                    textBoxGold.Text = gold.ToString();
                    textBoxIce.Text = ice.ToString();
                    textBoxFish.Text = fish.ToString();
                    levelIgloo++;
                    buttonNewIgloo.Text = " New Igloo 70 Gold/ 70 Ice/ 40 Fish";
                }
            }
            else if (levelIgloo == 2)
            {
                if (gold >= 70 && ice >= 70 && fish >= 40)
                {
                    gold = gold - 70;
                    ice = ice - 70;
                    fish = fish - 40;
                    textBoxGold.Text = gold.ToString();
                    textBoxIce.Text = ice.ToString();
                    textBoxFish.Text = fish.ToString();
                    levelIgloo++;
                    buttonNewIgloo.Text = " New Igloo 80 Gold/ 80 Ice/ 50 Fish";
                }
            }
            else if (levelIgloo == 3)
            {
                if (gold >= 80 && ice >= 80 && fish >= 50)
                {
                    gold = gold - 80;
                    ice = ice - 80;
                    fish = fish - 50;
                    textBoxGold.Text = gold.ToString();
                    textBoxIce.Text = ice.ToString();
                    textBoxFish.Text = fish.ToString();
                    buttonNewIgloo.Text = " Max level Igloo";
                    buttonNewIgloo.Enabled = false;
                }
            }
        }

        /// <summary>
        /// funkcja przycisku buttonNewSawmill, działanie warunków jest anaogiczne jak w funkcji buttonNewSchool
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewSawmill_Click(object sender, EventArgs e)
        {
            if (levelSawmill == 0)
            {
                if (gold >= 50)
                {
                    gold = gold - 50;
                    textBoxGold.Text = gold.ToString();
                    levelSawmill++;
                    buttonNewSawmill.Text = " New Sawmill 100 Gold";
                }
            }
            else if(levelSawmill == 1)
            {
                if (gold >= 100)
                {
                    gold = gold - 100;
                    textBoxGold.Text = gold.ToString();
                    levelSawmill++;
                    buttonNewSawmill.Text = " New Sawmill 200 Gold";
                }
            }
            else if (levelSawmill == 2)
            {
                if (gold >= 200)
                {
                    gold = gold - 200;
                    textBoxGold.Text = gold.ToString();
                    levelSawmill++;
                    buttonNewSawmill.Text = " New Sawmill 300 Gold";
                }
            }
            else if (levelSawmill == 3)
            {
                if (gold >= 300)
                {
                    gold = gold - 300;
                    textBoxGold.Text = gold.ToString();
                    buttonNewSawmill.Text = " Max level Sawmill";
                    buttonNewSawmill.Enabled = false;
                }
            }
        }

        /// <summary>
        /// funkcja przycisku buttonNewPenguinGun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewPenguinGun_Click(object sender, EventArgs e)
        {
            //warunek sprawdzający czy gracz ma odpowiednią ilość surowców
            if (gold >= 100 && knowledge >= 20 && wood >= 20 && ice >= 20 && penguins >= 20)
            {
                //odjęcie surowców
                gold = gold - 100;
                knowledge = knowledge - 20;
                wood = wood - 20;
                ice = ice - 20;
                penguins = penguins - 20;

                //zwiększenie ilości penguinGun oraz levelPenguinGun
                penguinGun++;
                levelPenguinGun++;

                //wypisanie do texBox'ów nowych wartości
                textBoxGold.Text = gold.ToString();
                textBoxKnowledge.Text = knowledge.ToString();
                textBoxWood.Text = wood.ToString();
                textBoxIce.Text = ice.ToString();
                textBoxPenguin.Text = penguins.ToString();
                textBoxPenguinGun.Text = penguinGun.ToString();
            }

            //jeśli spełniony warunek to wypisanie informacji o ukończeniu gry i zamknięcie aplikacji
            if(penguinGun == 3)
            {
                MessageBox.Show("Gratulacje ukończyłeś grę! Zdobyłeś odpowiednio dużo uzbrojonych pingwinów i niedźwiedzie już nie są da ciebie zagrożeniem");
                Application.Exit();
            }
     
        }

        /// <summary>
        /// funkcja timerEvent, która sprawdza poziom PenguinGun i w zależności od niego losuje z innego przedziału wartość odjętych później surowców
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEvent_Tick(object sender, EventArgs e)
        {
            //zwiększenie counterEvents, przypisanie wartości dzieenia modulo counterEvents do zmiennej tmp i zainicjowanie zmiennej random
            counterEvents++;
            int tmp = counterEvents % 45;
            int random;

            //jeśli prawdziwe to wykona się akcja eventu
            if (tmp == 0)
            {
                /*warunki sprawdzające poziom levelPenguinGun i w zależności od niego jest wypisywana inna informacja, losowana jest liczba 
                z innego przedziału i wywoływana jest funkcja thingsAfterEvent, która odejmuje wyosowaną ilość surowców*/
                if (levelPenguinGun == 0)
                {
                    MessageBox.Show("Na wioskę napadły niedźwiedzie i zaczęły się bawić z pingwinami, więc część z nich przestała pracować. Utracisz od 50 do 150 sztuk każdego z surowców");
                    random = new Random().Next(50, 151);
                    thingsAfterEvent(random);
                }
                else if(levelPenguinGun == 1)
                {
                    MessageBox.Show("Na wioskę napadły niedźwiedzie i zaczęły się bawić z pingwinami, więc część z nich przestała pracować. Na szczęście posiadasz pingwina z bronią na kulki dlatego utracisz od 25 do 50 sztuk każdego z surowców");
                    random = new Random().Next(25, 51);
                    thingsAfterEvent(random);
                }
                else if (levelPenguinGun == 2)
                {
                    MessageBox.Show("Na wioskę napadły niedźwiedzie i zaczęły się bawić z pingwinami, więc część z nich przestała pracować. Na szczęście posiadasz pingwiny z bronią na kulki dlatego utracisz od 0 do 20 sztuk każdego z surowców");
                    random = new Random().Next(0, 21);
                    thingsAfterEvent(random);
                }
            }

        }
    }
}
