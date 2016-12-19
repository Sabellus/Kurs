using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class RandomPrintEdition
    {
        static Random rand = new Random();
        public static Literature Random_Lit_Method()
        {
            string[] EducNameBook = { "Программируемые контроллеры", "Начертательная геометрия", "Конспект лекций по высшей математике","Черчение", "С# 4.0 на примерах", "С# 4.0 полное руководство"};
            string[] EducAuthor = { "Герберт Шилдт", "Бен Ватсон", "Виноградов В.Н.", "Дмитрий Письменный", "Шишов О.В" };
            string[] EducSubject = { "Начертательная геометрия", "Программирование", "Промышленная автоматизация", "Математика"};
            string[] EducSpecialty = { "АСУ", "КОБ", "РИС", "АТ", "ЭВТ" };
            int RandomClass = rand.Next(1, 2);
            switch (RandomClass)
            {
                case 1:
                    {
                        EducLiter educ = new EducLiter();
                        educ.Namebook = EducNameBook[rand.Next(1, 6)];
                        educ.Year = rand.Next(1954, 2016);
                        educ.Author = EducAuthor[rand.Next(1,5)];
                        educ.Namebook = EducNameBook[rand.Next(1, 6)];
                        educ.Subject = EducSubject[rand.Next(1, 4)];
                        educ.Specialty = EducSpecialty[rand.Next(1, 5)];
                        return educ;
                     
                    }
                
            }
            Literature dc = new Literature();
            
            return dc;
        }
        public static PeriodicalPublic Random_Per_Method()
        {
            string[] PerNameBook = { "Радио","Auto.ru","Игромания","Maxim"};
            string[] PerTheme = { "Научная-популярная", "Автомобильная", "Техническая", "Развлекательная","Женский" };
            int RandomClass = rand.Next(1, 2);
            switch (RandomClass)
            {
                case 1:
                    {
                        Jor jor1 = new Jor();
                        jor1.Namebook = PerNameBook[rand.Next(1, 4)];
                        jor1.Year = rand.Next(1954, 2016);
                        jor1.Number = rand.Next(1, 500);
                        jor1.Themes = PerTheme[rand.Next(1, 5)];              
                        return jor1;
                    }

            }
            PeriodicalPublic dc = new PeriodicalPublic();

            return dc;
        }
    }
}
