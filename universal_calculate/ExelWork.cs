using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using universal_calculate.Models.Opors;

namespace universal_calculate
{
    public class ExelWork
    {
        List<string> NameSelectElement = new List<string>();//все выбранные элементы в форме
        //список количества штук элементов 
        List<int> ColSelectELement = new List<int>();

        /// //////////////////////////////1-я серия опор////////////////////////////////////////////////////////

        //список опор вл
        List<OporyVL> OpVl = new List<OporyVL>();
        //список названий опор
        List<string> NameOpor = new List<string>();
        //количество опор
        int colOp = 0;
        //Cписок разъеденителей вл
        List<RazedVL> RZ = new List<RazedVL>();
        //список названий разъединителей
        List<string> NameRZ = new List<string>();
        //количество разъединителей
        int raz = 0;



        //инициализация общего количества элементов и всех наименований
        public void Element(List<string> ListNameELement, List<int> ColELement)
        {
            NameSelectElement = ListNameELement;
            ColSelectELement = ColELement;
        }

        //присвоение значений  для первой серии
        public void ListName(List<OporyVL> Op, List<RazedVL> Razed)
        {
            OpVl = Op;
            foreach (var s in Op)
            {
                NameOpor.Add(s.Name);

            }
            colOp = NameOpor.Count();
            RZ = Razed;
            foreach (var s in RZ)
            {
                NameRZ.Add(s.Name);
            }
            raz = NameRZ.Count();


        }
        //    /// //////////////////////////////2-я серия опор////////////////////////////////////////////////////////

        //список опор вл 2 серия
        List<Opory11m> OpVl11m = new List<Opory11m>();
        //список названий опор
        List<string> NameOpor11m = new List<string>();
        //количество опор
        int colOp11m = 0;
        //Cписок разъеденителей вл
        List<Razyed11m> RZ11m = new List<Razyed11m>();
        //список названий разъединителей
        List<string> NameRZ11m = new List<string>();
        //количество разъединителей
        int raz11m = 0;





        //присвоение значений  для второй серии
        public void ListName11m(List<Opory11m> Op, List<Razyed11m> Razed)
        {
            OpVl11m = Op;
            foreach (var s in Op)
            {
                NameOpor11m.Add(s.Name);

            }
            colOp11m = NameOpor11m.Count();
            RZ11m = Razed;
            foreach (var s in RZ)
            {
                NameRZ11m.Add(s.Name);
            }
            raz11m = NameRZ11m.Count();


        }


        //составление спецификации
        public void Specification()
        {
            // создание экземпляра экселя

            //создаём эксель
            Excel.Application exel = new Excel.Application();

            //книгу
            Excel._Workbook oWB = (Excel._Workbook)(exel.Workbooks.Add(Missing.Value));
            //листы
            Excel._Worksheet oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            CreateOp10m(oSheet);
            CreateRZ10m(oSheet);
            CreateOp11m(oSheet);
            CreateRZ11m(oSheet);
            CreateOp13m(oSheet);
            CreateRZ13m(oSheet);
            CreateOp16m(oSheet);
            CreateOpPP(oSheet);


            exel.Visible = true;

        }
        //    /// <summary>
        //    /// /////////////////////ДЛЯ ПЕРВОЙ СЕРИИ ОПОР И РАЗЪЕДИНИТЕЛЕЙ
        //    /// </summary>
        /// ///опоры серии 1
        public void CreateOp10m(Excel._Worksheet oSheet)
        {

            //////////////////////////////////////////////////// 1-я серия               //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //создаём заголовки таблиц по ячейкам для опор
            OporyVL vl = new OporyVL();
            int col = 0;//количество 'элементов
                        //массив свойств опоры вл
            PropertyInfo[] pi = vl.GetType().GetProperties();
            for (int i = 0; i < OpVl.Count(); i++)
            {
                oSheet.Cells[1, i + 2] = OpVl[i].Name;
                vl = OpVl.FirstOrDefault(x => x.Name == OpVl[i].Name);
                col = Colich(OpVl[i].Name);


                for (int j = 1; j < pi.Count() - 1; j++)
                {

                    double name = Convert.ToDouble(pi[j].GetValue(vl, null));
                    oSheet.Cells[j + 2, i + 2] = name * col;

                }

            }
            oSheet.Cells[1, OpVl.Count() + 2] = "Итого:";

            for (int i = 3; i < pi.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[i, 2].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[i, OpVl.Count() + 1].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[i, OpVl.Count() + 2] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов опор вл

            var s = vl.NameProperties();

            for (int i = 1; i < s.Count() - 1; i++)
            {
                oSheet.Cells[i + 2, 1] = s[i];
            }

        }
        //разъединители серии1
        public void CreateRZ10m(Excel._Worksheet oSheet)
        {
            //////////////////////////////разъединители////////////////////////////////////////////////////////
            RazedVL Razyed1 = new RazedVL();
            int col = 0;//количество 'элементов
                        ////массив свойств опоры вл
            PropertyInfo[] pv = Razyed1.GetType().GetProperties();

            for (int i = 0; i < RZ.Count(); i++)
            {
                oSheet.Cells[1, i + OpVl.Count() + 5] = RZ[i].Name;

                Razyed1 = RZ.FirstOrDefault(x => x.Name == RZ[i].Name);
                col = Colich(RZ[i].Name);


                for (int j = 2; j < pv.Count(); j++)
                {

                    double name = Convert.ToDouble(pv[j].GetValue(Razyed1, null));
                    oSheet.Cells[j + 1, i + OpVl.Count() + 5] = name * col;

                }

            }
            oSheet.Cells[1, OpVl.Count() + 5 + RZ.Count()] = "Итого:";

            for (int i = 3; i < pv.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[i, OpVl.Count() + 5].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[i, OpVl.Count() + 4 + RZ.Count()].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[i, OpVl.Count() + 5 + RZ.Count()] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд разъединителей вл

            var rr = Razyed1.GetName();

            for (int i = 2; i < rr.Count(); i++)
            {
                oSheet.Cells[i + 1, OpVl.Count() + 4] = rr[i];
            }
        }



        //    /// //////////////////////////////////////для второй серии опор//////////////////
        public void CreateOp11m(Excel._Worksheet oSheet)
        {

            //////////////////////////////////////////////////// 2-я серия               //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //создаём заголовки таблиц по ячейкам для опор
            Opory11m vl = new Opory11m();
            int col = 0;//количество 'элементов
                        //массив свойств опоры вл
            PropertyInfo[] pi = vl.GetType().GetProperties();
            for (int i = 0; i < OpVl11m.Count(); i++)
            {
                oSheet.Cells[46, i + 2] = OpVl11m[i].Name;
                vl = OpVl11m.FirstOrDefault(x => x.Name == OpVl11m[i].Name);
                col = Colich(OpVl11m[i].Name);


                for (int j = 1; j < pi.Count(); j++)
                {

                    double name = Convert.ToDouble(pi[j].GetValue(vl, null));
                    oSheet.Cells[46 + j + 1, i + 2] = name * col;

                }

            }
            oSheet.Cells[46, OpVl11m.Count() + 2] = "Итого:";

            for (int i = 2; i < pi.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[46 + i, 2].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[46 + i, OpVl11m.Count() + 1].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[46 + i, OpVl11m.Count() + 2] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд опор вл

            var s = vl.GetName();

            for (int i = 1; i < s.Count(); i++)
            {
                oSheet.Cells[47 + i, 1] = s[i];
            }

        }

        public void CreateRZ11m(Excel._Worksheet oSheet)
        {
            //////////////////////////////разъединители////////////////////////////////////////////////////////
            Razyed11m Razyed1 = new Razyed11m();
            int col = 0;//количество 'элементов
                        ////массив свойств опоры вл
            PropertyInfo[] pv = Razyed1.GetType().GetProperties();

            for (int i = 0; i < RZ11m.Count(); i++)
            {
                oSheet.Cells[46, i + OpVl11m.Count() + 5] = RZ11m[i].Name;

                Razyed1 = RZ11m.FirstOrDefault(x => x.Name == RZ11m[i].Name);
                col = Colich(RZ11m[i].Name);


                for (int j = 2; j < pv.Count(); j++)
                {

                    double name = Convert.ToDouble(pv[j].GetValue(Razyed1, null));
                    oSheet.Cells[45 + j + 1, i + OpVl11m.Count() + 5] = name * col;

                }

            }
            oSheet.Cells[46, OpVl11m.Count() + 5 + RZ11m.Count()] = "Итого:";

            for (int i = 3; i < pv.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[45 + i, OpVl11m.Count() + 5].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[45 + i, OpVl11m.Count() + 4 + RZ11m.Count()].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[45 + i, OpVl11m.Count() + 5 + RZ11m.Count()] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд разъединителей вл

            var rr = Razyed1.GetName();

            for (int i = 2; i < rr.Count(); i++)
            {
                oSheet.Cells[46 + i, OpVl11m.Count() + 4] = rr[i];
            }
        }


        //поиск количества оборудования в списке по индексу из списка названий(т.к.у нас в бд 2 таблицы оборудования, а лист названий один)
        public int Colich(string name)
        {
            int index = NameSelectElement.IndexOf(name);// индекс элемента по имени , т.к. в списках имён и количества у combobox и textbox одной позиции в форме оборудавания  одинаковые индексы
            var listCol = ColSelectELement; // список количества
            int colichestvo = listCol[index];
            return colichestvo;
        }
        //    /// //////////////////////////////////////для третьей серии опор//////////////////
        //список опор вл 3 серия
        List<Opory13m> OpVl13m = new List<Opory13m>();
        //список названий опор
        List<string> NameOpor13m = new List<string>();
        //количество опор
        int colOp13m = 0;
        //Cписок разъеденителей вл
        List<Razyed3> RZ13m = new List<Razyed3>();
        //список названий разъединителей
        List<string> NameRZ13m = new List<string>();
        //количество разъединителей
        int raz13m = 0;





        //присвоение значений  для третьей серии
        public void ListName13m(List<Opory13m> Op, List<Razyed3> Razed)
        {
            OpVl13m = Op;
            foreach (var s in Op)
            {
                NameOpor13m.Add(s.Name);

            }
            colOp13m = NameOpor13m.Count();
            RZ13m = Razed;
            foreach (var s in RZ)
            {
                NameRZ13m.Add(s.Name);
            }
            raz13m = NameRZ13m.Count();


        }
        public void CreateOp13m(Excel._Worksheet oSheet)
        {

            //////////////////////////////////////////////////// 3-я серия               //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //создаём заголовки таблиц по ячейкам для опор
            Opory13m vl = new Opory13m();
            int col = 0;//количество 'элементов
                        //массив свойств опоры вл
            PropertyInfo[] pi = vl.GetType().GetProperties();
            for (int i = 0; i < OpVl13m.Count(); i++)
            {
                oSheet.Cells[90, i + 2] = OpVl13m[i].Name;
                vl = OpVl13m.FirstOrDefault(x => x.Name == OpVl13m[i].Name);
                col = Colich(OpVl13m[i].Name);


                for (int j = 1; j < pi.Count(); j++)
                {

                    double name = Convert.ToDouble(pi[j].GetValue(vl, null));
                    oSheet.Cells[90 + j + 1, i + 2] = name * col;

                }

            }
            oSheet.Cells[90, OpVl13m.Count() + 2] = "Итого:";

            for (int i = 2; i < pi.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[90 + i, 2].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[90 + i, OpVl13m.Count() + 1].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[90 + i, OpVl13m.Count() + 2] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд опор вл

            var s = vl.GetName();

            for (int i = 1; i < s.Count(); i++)
            {
                oSheet.Cells[91 + i, 1] = s[i];
            }

        }
        public void CreateRZ13m(Excel._Worksheet oSheet)
        {
            //////////////////////////////разъединители////////////////////////////////////////////////////////
            Razyed3 Razyed1 = new Razyed3();
            int col = 0;//количество 'элементов
                        ////массив свойств опоры вл
            PropertyInfo[] pv = Razyed1.GetType().GetProperties();

            for (int i = 0; i < RZ13m.Count(); i++)
            {
                oSheet.Cells[90, i + OpVl13m.Count() + 5] = RZ13m[i].Name;

                Razyed1 = RZ13m.FirstOrDefault(x => x.Name == RZ13m[i].Name);
                col = Colich(RZ13m[i].Name);


                for (int j = 2; j < pv.Count(); j++)
                {

                    double name = Convert.ToDouble(pv[j].GetValue(Razyed1, null));
                    oSheet.Cells[90 + j, i + OpVl13m.Count() + 5] = name * col;

                }

            }
            oSheet.Cells[90, OpVl13m.Count() + 5 + RZ13m.Count()] = "Итого:";

            for (int i = 3; i < pv.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[89 + i, OpVl13m.Count() + 5].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[89 + i, OpVl13m.Count() + 4 + RZ13m.Count()].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[89 + i, OpVl13m.Count() + 5 + RZ13m.Count()] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд разъединителей вл

            var rr = Razyed1.GetName();

            for (int i = 2; i < rr.Count(); i++)
            {
                oSheet.Cells[90 + i, OpVl13m.Count() + 4] = rr[i];
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////четвёртая серия
          //список опор вл 4 серия
        List<Opory16m> OpVl16m = new List<Opory16m>();
        //список названий опор
        List<string> NameOpor16m = new List<string>();
        //количество опор
        int colOp16m = 0;
        //присвоение значений  для четвёртой серии
        public void ListName16m(List<Opory16m> Op)
        {
            OpVl16m = Op;
            foreach (var s in Op)
            {
                NameOpor16m.Add(s.Name);

            }
            colOp16m = NameOpor16m.Count();

        }
        public void CreateOp16m(Excel._Worksheet oSheet)
        {

            //////////////////////////////////////////////////// 4-я серия               //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //создаём заголовки таблиц по ячейкам для опор
            Opory16m vl = new Opory16m();
            int col = 0;//количество 'элементов
                        //массив свойств опоры вл
            PropertyInfo[] pi = vl.GetType().GetProperties();
            for (int i = 0; i < OpVl16m.Count(); i++)
            {
                oSheet.Cells[135, i + 2] = OpVl16m[i].Name;
                vl = OpVl16m.FirstOrDefault(x => x.Name == OpVl16m[i].Name);
                col = Colich(OpVl16m[i].Name);


                for (int j = 1; j < pi.Count(); j++)
                {

                    double name = Convert.ToDouble(pi[j].GetValue(vl, null));
                    oSheet.Cells[135 + j + 1, i + 2] = name * col;

                }

            }
            oSheet.Cells[135, OpVl16m.Count() + 2] = "Итого:";

            for (int i = 2; i < pi.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[135 + i, 2].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[135 + i, OpVl16m.Count() + 1].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[135 + i, OpVl16m.Count() + 2] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд опор вл

            var s = vl.GetName();

            for (int i = 1; i < s.Count(); i++)
            {
                oSheet.Cells[136 + i, 1] = s[i];
            }

        }
        //////////////////////////////////////////////////////////////////////////////////////////////пятая серия
        //список опор вл 5 серия
        List<OporyPP> OpVlPP = new List<OporyPP>();
        //список названий опор
        List<string> NameOporPP = new List<string>();
        //количество опор
        int colOpPP = 0;
        //присвоение значений  для пятой серии
        public void ListNamePP(List<OporyPP> Op)
        {
            OpVlPP = Op;
            foreach (var s in Op)
            {
                NameOporPP.Add(s.Name);

            }
            colOpPP = NameOporPP.Count();

        }
        public void CreateOpPP(Excel._Worksheet oSheet)
        {

            //////////////////////////////////////////////////// 5-я серия               //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //создаём заголовки таблиц по ячейкам для опор
            OporyPP vl = new OporyPP();
            int col = 0;//количество 'элементов
                        //массив свойств опоры вл
            PropertyInfo[] pi = vl.GetType().GetProperties();
            for (int i = 0; i < OpVlPP.Count(); i++)
            {
                oSheet.Cells[163, i + 2] = OpVlPP[i].Name;
                vl = OpVlPP.FirstOrDefault(x => x.Name == OpVlPP[i].Name);
                col = Colich(OpVlPP[i].Name);


                for (int j = 1; j < pi.Count(); j++)
                {

                    double name = Convert.ToDouble(pi[j].GetValue(vl, null));
                    oSheet.Cells[163 + j + 1, i + 2] = name * col;

                }

            }
            oSheet.Cells[163, OpVlPP.Count() + 2] = "Итого:";

            for (int i = 2; i < pi.Count() + 1; i++)
            {
                var cellStart = oSheet.Cells[163 + i, 2].Address;// первая заполненная ячейка в строке
                var cellEnd = oSheet.Cells[163 + i, OpVlPP.Count() + 1].Address;// последняя заполненная ячейка в строке

                oSheet.Cells[163 + i, OpVlPP.Count() + 2] = "=SUM(" + cellStart + ":" + cellEnd + ")";
            }
            //список названий столбцов бд опор вл

            var s = vl.GetName();

            for (int i = 1; i < s.Count(); i++)
            {
                oSheet.Cells[164 + i, 1] = s[i];
            }

        }



        /////для грцнтовки и краски
        public void Paint(string paint, string grunt)
        {
            //создаём эксель
            Excel.Application exel = new Excel.Application();

            //книгу
            Excel._Workbook oWB = (Excel._Workbook)(exel.Workbooks.Add(Missing.Value));
            //листы
            Excel._Worksheet oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oSheet.Cells[2, 2] = "Эмаль ПФ-115";
            oSheet.Cells[2, 3] = "ГОСТ 6465-769";
            oSheet.Cells[2, 6] = "кг";
            oSheet.Cells[2, 6] = paint;

            oSheet.Cells[3, 2] = "Грунт ГФ-021";
            oSheet.Cells[3, 3] = "ГОСТ 25129-82";
            oSheet.Cells[3, 6] = "кг";
            oSheet.Cells[3, 6] = grunt;
            exel.Visible = true;
            
        }
        ///////////////////////////////////////////////////составление кабельно-трубного журнала/////////////////////////////
        public void Kab_Trub(List<KabLine> list)
        {
            int count = list.Count();
            string file = Environment.CurrentDirectory;//путь к папке с программой
            string path = file + @"\КЖ_1.xlsx"; //исходный шаблон
            //создаём эксель
            Excel.Application exel = new Excel.Application();

            //книгу
            Excel._Workbook oWB = exel.Workbooks.Open(path);
            //листы
            Excel._Worksheet oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            for (int i = 0; i < count; i++)
            {

                if(i<24)
                {
                    oSheet.Cells[i + 7, 5] = list.ElementAt(i).Obozn_provoda;
                    oSheet.Cells[i + 7, 10] = list.ElementAt(i).Trassa_nachalo;
                    oSheet.Cells[i + 7, 22] = list.ElementAt(i).Trassa_konec;
                    oSheet.Cells[i + 7, 34] = list.ElementAt(i).Truba_oboznach;
                    oSheet.Cells[i + 7, 38] = list.ElementAt(i).Truba_diametr;
                    oSheet.Cells[i + 7, 41] = list.ElementAt(i).Truba_dlina;
                    oSheet.Cells[i + 7, 44] = list.ElementAt(i).Metalloruk_tip;
                    oSheet.Cells[i + 7, 49] = list.ElementAt(i).Metalloruk_dlina;
                    oSheet.Cells[i + 7, 52] = list.ElementAt(i).Protyazh_yashik;
                    oSheet.Cells[i + 7, 56] = list.ElementAt(i).Provod_Proekt_marka;
                    oSheet.Cells[i + 7, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                    oSheet.Cells[i + 7, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                    oSheet.Cells[i + 7, 70] = list.ElementAt(i).Provod_Fakt_marka;
                    oSheet.Cells[i + 7, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                    oSheet.Cells[i + 7, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                }
                else if (i>23&&i<48)
                {
                    oSheet.Cells[i + 29, 5] = list.ElementAt(i).Obozn_provoda;
                    oSheet.Cells[i + 29, 10] = list.ElementAt(i).Trassa_nachalo;
                    oSheet.Cells[i + 29, 22] = list.ElementAt(i).Trassa_konec;
                    oSheet.Cells[i + 29, 34] = list.ElementAt(i).Truba_oboznach;
                    oSheet.Cells[i + 29, 38] = list.ElementAt(i).Truba_diametr;
                    oSheet.Cells[i + 29, 41] = list.ElementAt(i).Truba_dlina;
                    oSheet.Cells[i + 29, 44] = list.ElementAt(i).Metalloruk_tip;
                    oSheet.Cells[i + 29, 49] = list.ElementAt(i).Metalloruk_dlina;
                    oSheet.Cells[i + 29, 52] = list.ElementAt(i).Protyazh_yashik;
                    oSheet.Cells[i + 29, 56] = list.ElementAt(i).Provod_Proekt_marka;
                    oSheet.Cells[i + 29, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                    oSheet.Cells[i + 29, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                    oSheet.Cells[i + 29, 70] = list.ElementAt(i).Provod_Fakt_marka;
                    oSheet.Cells[i + 29, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                    oSheet.Cells[i + 29, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                }
                else if(i>47&&i<73)
                {
                    oSheet.Cells[i + 51, 5] = list.ElementAt(i).Obozn_provoda;
                    oSheet.Cells[i + 51, 10] = list.ElementAt(i).Trassa_nachalo;
                    oSheet.Cells[i + 51, 22] = list.ElementAt(i).Trassa_konec;
                    oSheet.Cells[i + 51, 34] = list.ElementAt(i).Truba_oboznach;
                    oSheet.Cells[i + 51, 38] = list.ElementAt(i).Truba_diametr;
                    oSheet.Cells[i + 51, 41] = list.ElementAt(i).Truba_dlina;
                    oSheet.Cells[i + 51, 44] = list.ElementAt(i).Metalloruk_tip;
                    oSheet.Cells[i + 51, 49] = list.ElementAt(i).Metalloruk_dlina;
                    oSheet.Cells[i + 51, 52] = list.ElementAt(i).Protyazh_yashik;
                    oSheet.Cells[i + 51, 56] = list.ElementAt(i).Provod_Proekt_marka;
                    oSheet.Cells[i + 51, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                    oSheet.Cells[i + 51, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                    oSheet.Cells[i + 51, 70] = list.ElementAt(i).Provod_Fakt_marka;
                    oSheet.Cells[i + 51, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                    oSheet.Cells[i + 51, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                }
                else if(i>72&&i<96)
                {
                    oSheet.Cells[i + 73, 5] = list.ElementAt(i).Obozn_provoda;
                    oSheet.Cells[i + 73, 10] = list.ElementAt(i).Trassa_nachalo;
                    oSheet.Cells[i + 73, 22] = list.ElementAt(i).Trassa_konec;
                    oSheet.Cells[i + 73, 34] = list.ElementAt(i).Truba_oboznach;
                    oSheet.Cells[i + 73, 38] = list.ElementAt(i).Truba_diametr;
                    oSheet.Cells[i + 73, 41] = list.ElementAt(i).Truba_dlina;
                    oSheet.Cells[i + 73, 44] = list.ElementAt(i).Metalloruk_tip;
                    oSheet.Cells[i + 73, 49] = list.ElementAt(i).Metalloruk_dlina;
                    oSheet.Cells[i + 73, 52] = list.ElementAt(i).Protyazh_yashik;
                    oSheet.Cells[i + 73, 56] = list.ElementAt(i).Provod_Proekt_marka;
                    oSheet.Cells[i + 73, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                    oSheet.Cells[i + 73, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                    oSheet.Cells[i + 73, 70] = list.ElementAt(i).Provod_Fakt_marka;
                    oSheet.Cells[i + 73, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                    oSheet.Cells[i + 73, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                }
                else
                {
                    oSheet.Cells[i + 96, 5] = list.ElementAt(i).Obozn_provoda;
                    oSheet.Cells[i + 96, 10] = list.ElementAt(i).Trassa_nachalo;
                    oSheet.Cells[i + 96, 22] = list.ElementAt(i).Trassa_konec;
                    oSheet.Cells[i + 96, 34] = list.ElementAt(i).Truba_oboznach;
                    oSheet.Cells[i + 96, 38] = list.ElementAt(i).Truba_diametr;
                    oSheet.Cells[i + 96, 41] = list.ElementAt(i).Truba_dlina;
                    oSheet.Cells[i + 96, 44] = list.ElementAt(i).Metalloruk_tip;
                    oSheet.Cells[i + 96, 49] = list.ElementAt(i).Metalloruk_dlina;
                    oSheet.Cells[i + 96, 52] = list.ElementAt(i).Protyazh_yashik;
                    oSheet.Cells[i + 96, 56] = list.ElementAt(i).Provod_Proekt_marka;
                    oSheet.Cells[i + 96, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                    oSheet.Cells[i + 96, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                    oSheet.Cells[i + 96, 70] = list.ElementAt(i).Provod_Fakt_marka;
                    oSheet.Cells[i + 96, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                    oSheet.Cells[i + 96, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                }
          
                   

                
           

                //else if (i > 76 && i < 123)
                //{
                //    oSheet.Cells[i + 99, 5] = list.ElementAt(i).Obozn_provoda;
                //    oSheet.Cells[i + 99, 10] = list.ElementAt(i).Trassa_nachalo;
                //    oSheet.Cells[i + 98, 22] = list.ElementAt(i).Trassa_konec;
                //    oSheet.Cells[i + 99, 34] = list.ElementAt(i).Truba_oboznach;
                //    oSheet.Cells[i + 99, 38] = list.ElementAt(i).Truba_diametr;
                //    oSheet.Cells[i + 99, 41] = list.ElementAt(i).Truba_dlina;
                //    oSheet.Cells[i + 99, 44] = list.ElementAt(i).Metalloruk_tip;
                //    oSheet.Cells[i + 99, 49] = list.ElementAt(i).Metalloruk_dlina;
                //    oSheet.Cells[i + 99, 52] = list.ElementAt(i).Protyazh_yashik;
                //    oSheet.Cells[i + 99, 56] = list.ElementAt(i).Provod_Proekt_marka;
                //    oSheet.Cells[i + 99, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                //    oSheet.Cells[i + 99, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                //    oSheet.Cells[i + 99, 70] = list.ElementAt(i).Provod_Fakt_marka;
                //    oSheet.Cells[i + 99, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                //    oSheet.Cells[i + 99, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                //}
                //else if (i > 122 && i < 169)
                //{
                //    oSheet.Cells[i + 145, 5] = list.ElementAt(i).Obozn_provoda;
                //    oSheet.Cells[i + 145, 10] = list.ElementAt(i).Trassa_nachalo;
                //    oSheet.Cells[i + 145, 22] = list.ElementAt(i).Trassa_konec;
                //    oSheet.Cells[i + 145, 34] = list.ElementAt(i).Truba_oboznach;
                //    oSheet.Cells[i + 145, 38] = list.ElementAt(i).Truba_diametr;
                //    oSheet.Cells[i + 145, 41] = list.ElementAt(i).Truba_dlina;
                //    oSheet.Cells[i + 145, 44] = list.ElementAt(i).Metalloruk_tip;
                //    oSheet.Cells[i + 145, 49] = list.ElementAt(i).Metalloruk_dlina;
                //    oSheet.Cells[i + 145, 52] = list.ElementAt(i).Protyazh_yashik;
                //    oSheet.Cells[i + 145, 56] = list.ElementAt(i).Provod_Proekt_marka;
                //    oSheet.Cells[i + 145, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                //    oSheet.Cells[i + 145, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                //    oSheet.Cells[i + 145, 70] = list.ElementAt(i).Provod_Fakt_marka;
                //    oSheet.Cells[i + 145, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                //    oSheet.Cells[i + 145, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                //}
                //else
                //{
                //    oSheet.Cells[i + 192, 5] = list.ElementAt(i).Obozn_provoda;
                //    oSheet.Cells[i + 192, 10] = list.ElementAt(i).Trassa_nachalo;
                //    oSheet.Cells[i + 192, 22] = list.ElementAt(i).Trassa_konec;
                //    oSheet.Cells[i + 192, 34] = list.ElementAt(i).Truba_oboznach;
                //    oSheet.Cells[i + 192, 38] = list.ElementAt(i).Truba_diametr;
                //    oSheet.Cells[i + 192, 41] = list.ElementAt(i).Truba_dlina;
                //    oSheet.Cells[i + 192, 44] = list.ElementAt(i).Metalloruk_tip;
                //    oSheet.Cells[i + 192, 49] = list.ElementAt(i).Metalloruk_dlina;
                //    oSheet.Cells[i + 192, 52] = list.ElementAt(i).Protyazh_yashik;
                //    oSheet.Cells[i + 192, 56] = list.ElementAt(i).Provod_Proekt_marka;
                //    oSheet.Cells[i + 192, 60] = list.ElementAt(i).Provod_Proekt_kol_zhil;
                //    oSheet.Cells[i + 192, 67] = list.ElementAt(i).Provod_Proekt_dlina;
                //    oSheet.Cells[i + 192, 70] = list.ElementAt(i).Provod_Fakt_marka;
                //    oSheet.Cells[i + 192, 74] = list.ElementAt(i).Provod_Fakt_kol_zhil;
                //    oSheet.Cells[i + 192, 81] = list.ElementAt(i).Provod_Fakt_dlina;
                //}


            }

            exel.Visible = true;
        }
    }
}