using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Task
    {
        //Автоматические с-ва, где мы задаем значения числел a, b, c 
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        //Конструктор класса Task, где при создании экземпляра класса мы сразу задаем параметры
        public Task(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        //Функция, где мы ищем количество положительных и отрицательных чисел 
        public void AnswerTask(out int positiveCount, out int negativeCount)
        {
            positiveCount = 0;
            negativeCount = 0;
            if (A > 0) positiveCount++;
            else if(A != 0) negativeCount++;
            if (B > 0) positiveCount++;
            else if (B != 0) negativeCount++;
            if (C > 0) positiveCount++;
            else if(C != 0) negativeCount++;
            
        }
        
    }
}
