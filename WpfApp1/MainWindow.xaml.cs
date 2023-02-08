using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        private int choice;
        private string mark;
        private bool beginner;
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 450;
            this.Width = 370;
            beginner = false;
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            StartButton.IsEnabled = false;
            Button[,] buttons = new Button[3,3] { { Button1, Button2, Button3 },
                                                { Button4, Button5, Button6 },
                                                { Button7, Button8, Button9 } };

            foreach (Button but in buttons)
            {
                but.IsEnabled = true;
                but.Content = "";
            }
            
            if (beginner == false)
            {
                choice = rnd.Next(0, 2);
                Robot_Logic(choice, mark);
            }
        }

        private void Robot_Logic(int choice, string mark)
        {
            int move = rnd.Next(1,10);

            if (choice == 0) mark = "O";
            if (choice == 1) mark = "X";


            if (move == 1) if (Button1.IsEnabled == false) Robot_Logic(choice, mark);
            else
                {
                    Button1.Content = mark;
                    Button1.IsEnabled = false;
                }
            if (move == 2) if (Button2.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button2.Content = mark;
                    Button2.IsEnabled = false;
                }
            if (move == 3) if (Button3.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button3.Content = mark;
                    Button3.IsEnabled = false;
                }
            if (move == 4) if (Button4.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button4.Content = mark;
                    Button4.IsEnabled = false;
                }
            if (move == 5) if (Button5.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button5.Content = mark;
                    Button5.IsEnabled = false;
                }
            if (move == 6) if (Button6.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button6.Content = mark;
                    Button6.IsEnabled = false;
                }
            if (move == 7) if (Button7.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button7.Content = mark;
                    Button7.IsEnabled = false;
                }
            if (move == 8) if (Button8.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button8.Content = mark;
                    Button8.IsEnabled = false;
                }
            if (move == 9) if (Button9.IsEnabled == false) Robot_Logic(choice, mark);
                else
                {
                    Button9.Content = mark;
                    Button9.IsEnabled = false;
                }

            Has_Won();
        }

        private void Choice_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).IsEnabled = false;
            
            if (choice == 0) (sender as Button).Content = "X";
            if (choice == 1) (sender as Button).Content = "O";
            int ready = Has_Won();
            if (ready == 1) Robot_Logic(choice, mark);
            
        }
        private int Has_Won()
        {
            Button[,] buttons = new Button[3, 3] { { Button1, Button2, Button3 },
                                                { Button4, Button5, Button6 },
                                                { Button7, Button8, Button9 } };

            if (Button1.Content == Button2.Content && Button2.Content == Button3.Content && Button2.Content != "") // 1-ЫЙ ГОР.РЯД
            {
                if ((choice == 0 && Button1.Content == "X") || (choice == 1 && Button1.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }
            else if (Button4.Content == Button5.Content && Button5.Content == Button6.Content && Button5.Content != "") // 2-ОЙ ГОР.РЯД
            {
                if ((choice == 0 && Button4.Content == "X") || (choice == 1 && Button4.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }
            else if (Button7.Content == Button8.Content && Button8.Content == Button9.Content && Button8.Content != "") // 3-ИЙ ГОР.РЯД
            {
                if ((choice == 0 && Button7.Content == "X") || (choice == 1 && Button7.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }


            else if (Button1.Content == Button4.Content && Button4.Content == Button7.Content && Button4.Content != "") // 1-ЫЙ ВЕРТ.РЯД
            {
                if ((choice == 0 && Button1.Content == "X") || (choice == 1 && Button1.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }
            else if (Button2.Content == Button5.Content && Button5.Content == Button8.Content && Button5.Content != "") // 2-ЫЙ ВЕРТ.РЯД
            {
                if ((choice == 0 && Button2.Content == "X") || (choice == 1 && Button2.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }
            else if (Button3.Content == Button6.Content && Button6.Content == Button9.Content && Button6.Content != "") // 3-ЫЙ ВЕРТ.РЯД
            {
                if ((choice == 0 && Button3.Content == "X") || (choice == 1 && Button3.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }


            else if (Button1.Content == Button5.Content && Button5.Content == Button9.Content && Button5.Content != "") // ПО ДИАГОНАЛИ СВЕРХУ-ВНИЗ
            {
                if ((choice == 0 && Button1.Content == "X") || (choice == 1 && Button1.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }
            else if (Button7.Content == Button5.Content && Button5.Content == Button3.Content && Button5.Content != "") // ПО ДИАГОНАЛИ СНИЗУ-ВВЕРХ
            {
                if ((choice == 0 && Button7.Content == "X") || (choice == 1 && Button7.Content == "O"))
                {
                    MessageBox.Show("Вы победили!");
                }
                else
                {
                    MessageBox.Show("Вы проиграли!");
                }
                Return_Buttons(buttons);
                return 0;
            }

            int counter = 0;
            foreach (Button but in buttons)
            {
                if (but.IsEnabled == false) counter++;
            }
            
            if (counter == 9)
            {
                MessageBox.Show("Ничья");
                Return_Buttons(buttons);
                return 0;
            }
            return 1;
        }

        private void Return_Buttons(Button[,] buttons)
        {
            foreach (Button but in buttons) but.IsEnabled = false;
            StartButton.IsEnabled = true;
            beginner = !beginner;
        }
    }
}
