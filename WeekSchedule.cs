using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте класс
//WeekSchedule, который будет представлять расписание на неделю и поддерживать доступ к расписанию по дням недели с помощью индексаторов. Класс должен содержать:
//Поле:
//string[] days -массив из 7 строк, представляющих расписание для каждого дня недели (понедельник, вторник, среда, четверг, пятница, суббота, воскресенье).
//Конструктор:
//Конструктор без параметров, который инициализирует массив days пустыми строками.
//Индексаторы:
//Индексатор для доступа к расписанию по номеру дня недели (от 0 до 6, где 0 - понедельник, 1 - вторник и так далее).
//Индексатор для доступа к расписанию по названию дня недели (строка "понедельник", "вторник" и так далее).


namespace Operator
{
    internal class WeekSchedule
    {
        public string[] days = new string[7];

        public WeekSchedule()
        {
            days = new string[7];
            for (int i = 0; i < 7; i++)
            {
                days[i] = "";
            }
        }

        public string this[int index]
        {
            get
            {
                if (!(index >= 0 && index <= 6))
                    throw new IndexOutOfRangeException($"Индекс {index} за пределами допустимой границы.");
                return days[index];
            }
            set
            {
                if (!(index >= 0 && index <= 6))
                    throw new IndexOutOfRangeException($"Индекс {index} за пределами допустимой границы.");
                days[index] = value;
            }
        }

        public string this[string str]
        {
            get
            {
                switch (str.ToLower())
                {
                    case "понедельник": return days[0];
                    case "вторник":  return days[1];
                    case "среда":   return days[2];
                    case "четверг": return days[3];
                    case "пятница": return days[4];
                    case "суббота": return days[5];
                    case "воскресенье": return days[6];
                    default:
                        throw new Exception($"{str} дня недели не существует.");
                }
            }
            set
            {
                switch (str.ToLower())
                {
                    case "понедельник":
                        days[0] = value;
                        break;
                    case "вторник":
                        days[1] = value;
                        break;
                    case "среда":
                        days[2] = value;
                        break;
                    case "четверг":
                        days[3] = value;
                        break;
                    case "пятница":
                        days[4] = value;
                        break;
                    case "суббота":
                        days[5] = value;
                        break;
                    case "воскресенье":
                        days[6] = value;
                        break;
                    default:
                        throw new Exception($"{str} дня недели не существует.");
                }
            }
        }
    }
}
