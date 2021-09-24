using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    enum Operation
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Operation Operation;  //enum операций
        bool DotPressed = false; // была нажата точка  или нет
        string s1;  // строка(число) 1
        string s2;  // строка(число) 2 результат
        bool FirstClickNumberButton = true; // переменная нажатия после вывода результата оепраций на экран
        bool SingPressed = false; // был нажат арифметический знак или нет
        bool EqualPressed = false; // 
        bool ErrorOperation = false; 

        private void FirstClickNumbButton() // проверяет  firstClickNumberButton  и очишает основное окно ввода/вывода
        {
            SingPressed = false;
            if (FirstClickNumberButton)
            {
                FirstClickNumberButton = false;
                MainLabel.Text = "";               
            }
        }

        private void EqualUnPressed() //очищает HistoryBox если был нажат знак равно
        {
            if (EqualPressed == true)
            {
                EqualPressed = false;
                HistoryBox.Text = "";
            }
        }

        private void CheckError()
        {
            if (ErrorOperation == true)
            {
                ErrorOperation = false;
                MainLabel.Text = "0";
            }
        }

        private void TrimFirstZero(string buttonText) // обрезает первые нули если не нажата Точка
        { 
            if (DotPressed == false)
            {
                MainLabel.Text = MainLabel.Text.TrimStart('0') + buttonText;
            }
            else
            {
                MainLabel.Text = MainLabel.Text + buttonText;
            }
        }

        private void button0_Click(object sender, EventArgs e) // 0
        {
            EqualUnPressed();
            FirstClickNumbButton();
            if (MainLabel.Text == "")
            {
                MainLabel.Text = MainLabel.Text + 0;
            }
            else if (DotPressed == true)
            {
                MainLabel.Text = MainLabel.Text + 0;
            }
            else if (MainLabel.Text[0] != '0')
            {
                MainLabel.Text = MainLabel.Text + 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) // 1
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button1.Text);
            //textLogic.Text = textLogic.Text.TrimStart('0') + 1;           
        }
        private void button2_Click(object sender, EventArgs e) // 2
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button2.Text);
        }
        private void button3_Click(object sender, EventArgs e) // 3
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button3.Text);
        }
        private void button4_Click(object sender, EventArgs e) // 4
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button4.Text);
        }
        private void button5_Click(object sender, EventArgs e) // 5
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button5.Text);
        }
        private void button6_Click(object sender, EventArgs e) // 6
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button6.Text);
        }
        private void button7_Click(object sender, EventArgs e) // 7
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button7.Text);
        }
        private void button8_Click(object sender, EventArgs e) // 8
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button8.Text);
        }
        private void button9_Click(object sender, EventArgs e) // 9
        {
            EqualUnPressed();
            FirstClickNumbButton();
            TrimFirstZero(button9.Text);
        }

        private void buttonDot_Click(object sender, EventArgs e) //  Dot.
        {
            if (DotPressed == false)
            {
                if (FirstClickNumberButton)
                {
                    FirstClickNumbButton();
                    DotPressed = true;
                    MainLabel.Text = MainLabel.Text + "0" + ".";
                }
                else
                {
                    DotPressed = true;
                    MainLabel.Text = MainLabel.Text + ".";
                }
            }
        }

        private void SingOperation(Operation tempOperation, string buttonText)
        {
            if (SingPressed == true) // повторное нажатие знака + - * /
            { 
                HistoryBox.Text = HistoryBox.Text.Remove(HistoryBox.Text.Length - 2) + buttonText + " ";
            }
            else // проверка первого нажатия на знак
            {
                ValidateMainLabelText(buttonText);
                s1 = MainLabel.Text;
                if (tempOperation != default) // Проверять доп переменную tempOperation 
                { //проверка и арифметика
                    ValidateAndOpetarion(tempOperation);
                }
                else
                {
                    s2 = MainLabel.Text;
                    SingPressed = true;
                    FirstClickNumberButton = true;
                }
            }
        }

        private void ValidateMainLabelText(string buttonText) // Проверка mainlаbеl и запись в history box
        {
            if (DotPressed == true)
            {
                MainLabel.Text = MainLabel.Text.TrimEnd('0').TrimEnd('.');
                DotPressed = false;
                HistoryBox.Text = HistoryBox.Text + MainLabel.Text + " " + buttonText + " ";
            }
            else
            {   HistoryBox.Text = HistoryBox.Text + MainLabel.Text + " " + buttonText + " "; }
        }

        private void ValidateAndOpetarion(Operation tempOperation)
        {
            if (tempOperation == Operation.Divide && s1 == "0")
            {
                HistoryBox.Text = "";
                MainLabel.Text = "Invalid Operation";
                //s2 = "0";
                s2 = null;
                SingPressed = false;
                FirstClickNumberButton = true;
                ErrorOperation = true;
                Operation = default;
            }
            else
            {
                MainLabel.Text = CalculateLogic.ChooseOperation(tempOperation, s1, s2);
                s2 = MainLabel.Text;
                SingPressed = true;
                FirstClickNumberButton = true;             

            }
        }
        /*private void buttonAdding_Click(object sender, EventArgs e) // +
        {// может сделать проверку на 0 и очистку MainLabel.Text 
            Operation tempOperation = Operation;
            Operation = Operation.Add;
            EqualUnPressed();
            CheckError();
            string buttonText = buttonAdding.Text;
            if (SingPressed == true) // повторное нажатие знака + - * /
            { // можно в отдельный метод положить "Повторное нажатие" но нужно модернизировать чтобы передовать знак +
                HistoryBox.Text = HistoryBox.Text.Remove(HistoryBox.Text.Length - 2) + buttonAdding.Text + " ";
            }
            else //if (znakPress == false) // проверка первого нажатия на знак
            {
                if (DotPressed == true)
                {
                    MainLabel.Text = MainLabel.Text.TrimEnd('0').TrimEnd('.');
                    DotPressed = false;
                    HistoryBox.Text = HistoryBox.Text + MainLabel.Text + " " + buttonAdding.Text + " ";
                }
                else
                {
                    HistoryBox.Text = HistoryBox.Text + MainLabel.Text + " " + buttonAdding.Text + " ";
                }
                s1 = MainLabel.Text;
                if (tempOperation != default) // Проверять доп переменную tempOperation 
                { //проверка и арифметика
                    if (tempOperation == Operation.Divide && s1 == "0")
                    {
                        HistoryBox.Text = "";
                        MainLabel.Text = "Invalid Operation";
                        //s2 = "0";
                        s2 = null;
                        SingPressed = false;
                        FirstClickNumberButton = true;
                        ErrorOperation = true;
                        Operation = default;
                    }
                    else
                    {
                        MainLabel.Text = CalculateLogic.ChooseOperation(tempOperation, s1, s2);
                        s2 = MainLabel.Text;
                        SingPressed = true;
                        FirstClickNumberButton = true;

                    }
                }
                else
                {
                    s2 = MainLabel.Text;
                    SingPressed = true;
                    FirstClickNumberButton = true;
                }
            }
        }*/

        private void buttonAdding_Click(object sender, EventArgs e) // +
        {
            Operation tempOperation = Operation;
            string buttonText = buttonAdding.Text;
            EqualUnPressed();
            CheckError();
            SingOperation(tempOperation, buttonText);
            Operation = Operation.Add;
        }

        private void buttonSubtract_Click(object sender, EventArgs e) // -
        {
            Operation tempOperation = Operation;
            string buttonText = buttonSubtract.Text;
            EqualUnPressed();
            CheckError();
            SingOperation(tempOperation, buttonText);
            Operation = Operation.Subtract;
        }

        private void buttoMultip_Click(object sender, EventArgs e) // *
        {
            Operation tempOperation = Operation;
            string buttonText = buttoMultip.Text;
            EqualUnPressed();
            CheckError();
            SingOperation(tempOperation, buttonText);
            Operation = Operation.Multiply;
        }

        private void buttonDivide_Click(object sender, EventArgs e) // /
        { 
            Operation tempOperation = Operation;
            string buttonText = buttonDivide.Text;
            EqualUnPressed();
            CheckError();
            SingOperation(tempOperation, buttonText);
            Operation = Operation.Divide;
        }

        private void buttonDelete_Click(object sender, EventArgs e) // Delete
        {  // удаляет результат операции после =  // может остаивть типо фишка
            if (SingPressed == false)
            {
                int len = MainLabel.Text.Length;
                if (len > 0)
                {
                    if (MainLabel.Text[len - 1] == '.')
                        DotPressed = false; 
                    MainLabel.Text = MainLabel.Text.Remove(len - 1);
                }
                if (MainLabel.Text.Length == 0)
                {
                    MainLabel.Text = "0";
                    FirstClickNumberButton = true;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) // Clear
        {
            Operation = default;
            FirstClickNumberButton = true;
            SingPressed = false;
            DotPressed = false;
            EqualPressed = false;
            s2 = null;
            MainLabel.Text = "0";
            HistoryBox.Text = "";
        }

        private void buttonResultat_Click(object sender, EventArgs e) // =
        {
            string buttonText = buttonResultat.Text;

            if (SingPressed == false && EqualPressed != true)
            {
                EqualPressed = true;
                ValidateMainLabelText(buttonText);
                s1 = MainLabel.Text;
                if (Operation != default)
                {
                    if (Operation == Operation.Divide && s1 == "0") // проверка деления на 0
                    { 
                        HistoryBox.Text = "";
                        MainLabel.Text = "Invalid Operation";
                        //s2 = "0";
                        s2 = null;
                        //s1 = "0";
                        SingPressed = false; //в ValidateAndOpetarion значение равняется true
                        FirstClickNumberButton = true;
                        ErrorOperation = true;
                        Operation = default;                       
                    }
                    else
                    {
                        MainLabel.Text = CalculateLogic.ChooseOperation(Operation, s1, s2);
                        s2 = MainLabel.Text;
                        SingPressed = false;
                        FirstClickNumberButton = true;
                        Operation = default;
                    }
                }
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e) // %
        { // доделать
            // может сделать проверку на 0 и очистку MainLabel.Text 
            if (ErrorOperation != true)
            {
                string buttonText = buttonPercent.Text;
                ValidateMainLabelText(buttonText);
                /*if (DotPressed == true)
                {
                    MainLabel.Text = MainLabel.Text.TrimEnd('0').TrimEnd('.');
                    DotPressed = false;
                    HistoryBox.Text = HistoryBox.Text + MainLabel.Text;
                    HistoryBox.Text += " " + buttonPercent.Text+ " ";  //buttonPercent.Text;
                }
                else
                {
                    HistoryBox.Text = HistoryBox.Text + MainLabel.Text;
                    HistoryBox.Text += " " + buttonPercent.Text +  " ";   //buttonPercent.Text;
                }*/
                s1 = MainLabel.Text;
                double res = double.Parse(s1, CultureInfo.InvariantCulture) / 100;
                MainLabel.Text = res.ToString(CultureInfo.InvariantCulture);
                s2 = MainLabel.Text;
                FirstClickNumberButton = true;
            }
        }

        private void buttonPercent_MouseEnter(object sender, EventArgs e)
        {
            PercentHelp.SetToolTip(buttonPercent, "Вычисляет 1% от числа.");
            //PercentHelp.Show("Test", buttonPercent);
        }

        private void MainLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //contextMenuStrip1.Show();
                //MessageBox.Show("Да работает");
            }
        }

        private void buttonSing_Click(object sender, EventArgs e)
        {
            if (MainLabel.Text != "0")
            {
                double numb = double.Parse(MainLabel.Text,CultureInfo.InvariantCulture);
                double res = numb * -(1);
                MainLabel.Text = res.ToString(CultureInfo.InvariantCulture);
            }
        }
    }
}
