﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SolovevVG.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            switch (value1)
            {
                case 1:
                    switch (value2)
                    {
                        case 6: return "Шестёрка пик";
                        case 7: return "Семёрка пик";
                        case 8: return "Восьмёрка пик";
                        case 9: return "Девятка пик";
                        case 10: return "Десятка пик";
                        case 11: return "Валет пик";
                        case 12: return "Дама пик";
                        case 13: return "Король пик";
                        case 14: return "Туз пик";
                    }
                    return "Введено некорректное число";
                case 2:
                    switch (value2)
                    {
                        case 6: return "Шестёрка треф";
                        case 7: return "Семёрка треф";
                        case 8: return "Восьмёрка треф";
                        case 9: return "Девятка треф";
                        case 10: return "Десятка треф";
                        case 11: return "Валет треф";
                        case 12: return "Дама треф";
                        case 13: return "Король треф";
                        case 14: return "Туз треф";
                    }
                    return "Введено некорректное число";
                case 3:
                    switch (value2)
                    {
                        case 6: return "Шестёрка бубен";
                        case 7: return "Семёрка бубен";
                        case 8: return "Восьмёрка бубен";
                        case 9: return "Девятка бубен";
                        case 10: return "Десятка бубен";
                        case 11: return "Валет бубен";
                        case 12: return "Дама бубен";
                        case 13: return "Король бубен";
                        case 14: return "Туз бубен";
                    }
                    return "Введено некорректное число";
                case 4:
                    switch (value2)
                    {
                        case 6: return "Шестёрка червь";
                        case 7: return "Семёрка червь";
                        case 8: return "Восьмёрка червь";
                        case 9: return "Девятка червь";
                        case 10: return "Десятка червь";
                        case 11: return "Валет червь";
                        case 12: return "Дама червь";
                        case 13: return "Король червь";
                        case 14: return "Туз червь";
                    }
                    return "Введено некорректное число";
                default: return "Введено некорректное число";
            }
        }
    }
}
