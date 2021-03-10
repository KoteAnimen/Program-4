using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task;

namespace Program_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Событие, где мы записываем ответ полученный в результате работы метода AnswerTask() класса Task.
        private void GetAnswer_Click(object sender, EventArgs e)
        {
            int positiveCount = 0;
            int negativeCount = 0;
            task.Task task1 = new task.Task((int)a.Value, (int)b.Value, (int)c.Value); //Конструктор класса Task
            task1.AnswerTask(out positiveCount, out negativeCount);
            answer1.Text = positiveCount.ToString();
            answer2.Text = negativeCount.ToString();
        }

        //Событие выхода из программы
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         //Событие "О программе"
        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, вариант 1. Даны три числа a, b, c. Определить количество отрицательных и количество положительных чисел.", "О программе");
        }
    }
}
