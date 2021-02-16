using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using universal_calculate.Models.Opors;

namespace universal_calculate
{
    //класс для работы с xml ВЛ
    public class VLDataBase
    {
        string file = Environment.CurrentDirectory;//путь к папке с программой

        ////////////////////////////////////////первая серия//////////////////////////////////////////////

        //список названий опор первой серии
        public List<string> GetNameOp_1()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory.xml");
            listName = Name(xDoc);
            return listName;
        }
        //список названий разъединителей первой серии
        public List<string> GetNameRazyed_1()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Razyed.xml");
            listName = Name(xDoc);
            return listName;
        }
        //поиск имён в xml
        public List<string> Name(XmlDocument xDoc)
        {
            var listName = new List<string>();
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        listName.Add(attr.Value);
                    }

                }

            }
            return listName;
        }
        //1 серия
        //поиск элементов опоры
        public List<OporyVL> GetOp()
        {

            //создаём список опор
            var selectOpory = new List<OporyVL>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём опору вл
                var opora = new OporyVL();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        opora.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {

                    if (childnode.Name == "Stoyka_105")
                    {
                        opora.Stoyka_105 = Convert.ToInt32(childnode.InnerText);
                    }

                    if (childnode.Name == "Plita_P3")
                    {
                        opora.Plita_P3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "ZHb_Ves")
                    {
                        opora.ZHb_Ves = Convert.ToDecimal(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_1_or_24")
                    {
                        opora.Traversa_1_or_24 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_2")
                    {
                        opora.Traversa_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_3")
                    {
                        opora.Traversa_3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_5")
                    {
                        opora.Traversa_5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_6")
                    {
                        opora.Traversa_6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG_1")
                    {
                        opora.Ogolovok_OG_1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_2")
                    {
                        opora.Nakladka_OG_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_5")
                    {
                        opora.Nakladka_OG_5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_8")
                    {
                        opora.Nakladka_OG_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x1")
                    {
                        opora.Homut_x1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x2")
                    {
                        opora.Homut_x2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x7")
                    {
                        opora.Homut_x7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_b5")
                    {
                        opora.Bolt_b5 = Convert.ToInt32(childnode.InnerText);

                    }
                    if (childnode.Name == "Kronshtein_y1")
                    {
                        opora.Kronshtein_y1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Styazka_G1")
                    {
                        opora.Styazka_G1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        opora.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Kronshtein_RA4")
                    {
                        opora.Kronshtein_RA4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        opora.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Izolyator_SHF20")
                    {
                        opora.Izolyator_SHF20 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_k6")
                    {
                        opora.Kolpachek_k6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_k9")
                    {
                        opora.Kolpachek_k9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        opora.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PS")
                    {
                        opora.Zazhim_PS = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PA")
                    {
                        opora.Zazhim_PA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Natyazhnaya")
                    {
                        opora.Podveska_Natyazhnaya = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "ZZveno_Promezhut")
                    {
                        opora.ZZveno_Promezhut = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_SK7")
                    {
                        opora.Skoba_SK7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Serga_SRS7")
                    {
                        opora.Serga_SRS7 = Convert.ToInt32(childnode.InnerText);
                    }

                }
                selectOpory.Add(opora);
            }
            return selectOpory;
        }
        //1 серия
        //поиск элементов разъединителей
        public List<RazedVL> GetRaz()
        {
            //создаём список разъединителей
            var selectRz = new List<RazedVL>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Razyed.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём разъед вл
                var raz = new RazedVL();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        raz.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Kronstein_RA1")
                    {
                        raz.Kronstein_RA1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA2")
                    {
                        raz.Kronstein_RA2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA3")
                    {
                        raz.Kronstein_RA3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA4")
                    {
                        raz.Kronstein_RA4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA5")
                    {
                        raz.Kronstein_RA5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R1")
                    {
                        raz.Kronstein_R1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R2")
                    {
                        raz.Kronstein_R2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R4")
                    {
                        raz.Kronstein_R4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_KM1")
                    {
                        raz.Kronstein_KM1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ugolok_80")
                    {
                        raz.Ugolok_80 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_KM3")
                    {
                        raz.Skoba_KM3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X7")
                    {
                        raz.Homut_X7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X8")
                    {
                        raz.Homut_X8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X9")
                    {
                        raz.Homut_X9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X23")
                    {
                        raz.Homut_X23 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        raz.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Krug_10")
                    {
                        raz.Krug_10 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        raz.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Izol_SHF20")
                    {
                        raz.Izol_SHF20 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_K6")
                    {
                        raz.Kolpachek_K6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        raz.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PA")
                    {
                        raz.Zazhim_PA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Razed_RLND")
                    {
                        raz.Razed_RLND = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Privod_PRNZ")
                    {
                        raz.Privod_PRNZ = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Mufta_KMA")
                    {
                        raz.Mufta_KMA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Mufta_KN")
                    {
                        raz.Mufta_KN = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Razryad_vent")
                    {
                        raz.Razryad_vent = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_apparat")
                    {
                        raz.Zazhim_apparat = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakonech_7_8")
                    {
                        raz.Nakonech_7_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Oshinovka")
                    {
                        raz.Oshinovka = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Provod_zazeml")
                    {
                        raz.Provod_zazeml = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_M12")
                    {
                        raz.Bolt_M12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_M8")
                    {
                        raz.Bolt_M8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Gayka_M12")
                    {
                        raz.Gayka_M12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Gayka_M8")
                    {
                        raz.Gayka_M8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_12")
                    {
                        raz.Shayba_12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_8")
                    {
                        raz.Shayba_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_pruzhin")
                    {
                        raz.Shayba_pruzhin = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_apparatniy")
                    {
                        raz.Zazhim_apparatniy = Convert.ToInt32(childnode.InnerText);
                    }

                }
                selectRz.Add(raz);
            }
            return selectRz;
        }


        /// ////////////////////////////////////вторая серия/////////////////////////////////////////////////////

        //список названий опор второй серии
        public List<string> GetNameOp_2()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file+ @"\Opory2.xml");
            listName = Name(xDoc);
            return listName;
        }
        //2 серия
        //поиск элементов опоры
        public List<Opory11m> GetOp_2()
        {
            //создаём список опор
            var selectOpory = new List<Opory11m>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory2.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём опору вл
                var opora = new Opory11m();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        opora.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {

                    if (childnode.Name == "Stoyka_105")
                    {
                        opora.Stoyka_105 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Plita_P3")
                    {
                        opora.Plita_P3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_2")
                    {
                        opora.Traversa_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_3")
                    {
                        opora.Traversa_3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_5")
                    {
                        opora.Traversa_5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_6")
                    {
                        opora.Traversa_6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_9")
                    {
                        opora.Traversa_9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_10")
                    {
                        opora.Traversa_10 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG_1")
                    {
                        opora.Ogolovok_OG_1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_2")
                    {
                        opora.Nakladka_OG_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_5")
                    {
                        opora.Nakladka_OG_5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_8")
                    {
                        opora.Nakladka_OG_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_9")
                    {
                        opora.Nakladka_OG_9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x1")
                    {
                        opora.Homut_x1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x2")
                    {
                        opora.Homut_x2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x42")
                    {
                        opora.Homut_x42 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_b5")
                    {
                        opora.Bolt_b5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_y4")
                    {
                        opora.Kronshtein_y4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Styazka_G1")
                    {
                        opora.Styazka_G1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Stoyka_105")
                    {
                        opora.Stoyka_105 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_RA4")
                    {
                        opora.Kronshtein_RA4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x7")
                    {
                        opora.Homut_x7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        opora.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        opora.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Izolyator_SHF20")
                    {
                        opora.Izolyator_SHF20 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_k6")
                    {
                        opora.Kolpachek_k6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        opora.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PS")
                    {
                        opora.Zazhim_PS = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhimy")
                    {
                        opora.Zazhimy = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Natyazhnaya")
                    {
                        opora.Podveska_Natyazhnaya = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "ZZveno_Promezhut")
                    {
                        opora.ZZveno_Promezhut = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_SK7")
                    {
                        opora.Skoba_SK7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Serga_SRS7")
                    {
                        opora.Serga_SRS7 = Convert.ToInt32(childnode.InnerText);
                    }


                }
                selectOpory.Add(opora);
            }
            return selectOpory;
        }

        //список названий разъединителей второй серии
        public List<string> GetNameRazyed_2()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Razyed2.xml");
            listName = Name(xDoc);
            return listName;
        }
        //2 серия
        //поиск элементов разъединителей
        public List<Razyed11m> GetRaz_2()
        {
            //создаём список разъединителей
            var selectRz = new List<Razyed11m>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Razyed2.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём разъед вл
                var raz = new Razyed11m();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        raz.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Kronstein_RA1")
                    {
                        raz.Kronstein_RA1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA2")
                    {
                        raz.Kronstein_RA2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Val_RA3")
                    {
                        raz.Val_RA3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA4")
                    {
                        raz.Kronstein_RA4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA5")
                    {
                        raz.Kronstein_RA5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Val_RA7")
                    {
                        raz.Val_RA7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R1")
                    {
                        raz.Kronstein_R1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R2")
                    {
                        raz.Kronstein_R2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R5")
                    {
                        raz.Kronstein_R5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_KM1")
                    {
                        raz.Kronstein_KM1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ugolok_80")
                    {
                        raz.Ugolok_80 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_KM3")
                    {
                        raz.Skoba_KM3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X7")
                    {
                        raz.Homut_X7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X8")
                    {
                        raz.Homut_X8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X9")
                    {
                        raz.Homut_X9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X23")
                    {
                        raz.Homut_X23 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        raz.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Krug_10")
                    {
                        raz.Krug_10 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        raz.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Razed_RLND")
                    {
                        raz.Razed_RLND = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Privod_PRNZ")
                    {
                        raz.Privod_PRNZ = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Mufta_KMA")
                    {
                        raz.Mufta_KMA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Mufta_KN")
                    {
                        raz.Mufta_KN = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Razryad_vent")
                    {
                        raz.Razryad_vent = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Izol_SHF20")
                    {
                        raz.Izol_SHF20 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_K6")
                    {
                        raz.Kolpachek_K6 = Convert.ToInt32(childnode.InnerText);

                    }
                    if (childnode.Name == "Zazhim_PA ")
                    {
                        raz.Zazhim_PA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_apparat")
                    {
                        raz.Zazhim_apparat = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_apparat2")
                    {
                        raz.Zazhim_apparat2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakonech_7_8")
                    {
                        raz.Nakonech_7_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Oshinovka")
                    {
                        raz.Oshinovka = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Provod_zazeml")
                    {
                        raz.Provod_zazeml = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_M12")
                    {
                        raz.Bolt_M12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_M8")
                    {
                        raz.Bolt_M8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Gayka_M12")
                    {
                        raz.Gayka_M12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Gayka_M8")
                    {
                        raz.Gayka_M8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_12")
                    {
                        raz.Shayba_12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_8")
                    {
                        raz.Shayba_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_pruzhin")
                    {
                        raz.Shayba_pruzhin = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        raz.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                }
                selectRz.Add(raz);
            }
            return selectRz;
        }


        /////////////////////////////////////третья серия//////////////////////////////////////////////////////////

        //список названий опор третьей серии
        public List<string> GetNameOp_3()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory3.xml");
            listName = Name(xDoc);
            return listName;
        }
        //список названий разъединителей третьей серии
        public List<string> GetNameRazyed_3()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Razyed3.xml");
            listName = Name(xDoc);
            return listName;
        }
        public List<Opory13m> GetOp_3()
        {
            //создаём список опор
            var selectOpory = new List<Opory13m>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory3.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём опору вл
                var opora = new Opory13m();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        opora.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Stoyka_13")
                    {
                        opora.Stoyka_13 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Plita_P3 ")
                    {
                        opora.Plita_P3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_2")
                    {
                        opora.Traversa_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_11")
                    {
                        opora.Traversa_11 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_12")
                    {
                        opora.Traversa_12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_14")
                    {
                        opora.Traversa_14 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_2")
                    {
                        opora.Nakladka_OG_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_RA4")
                    {
                        opora.Kronshtein_RA4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_6")
                    {
                        opora.Nakladka_OG_6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG_10")
                    {
                        opora.Nakladka_OG_10 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Styr_OG_11")
                    {
                        opora.Styr_OG_11 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_b1")
                    {
                        opora.Bolt_b1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x4")
                    {
                        opora.Homut_x4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x5")
                    {
                        opora.Homut_x5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x6")
                    {
                        opora.Homut_x6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x37")
                    {
                        opora.Homut_x37 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_y2")
                    {
                        opora.Kronshtein_y2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Styazhka_G1")
                    {
                        opora.Styazhka_G1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        opora.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        opora.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Izolyator_SHF20")
                    {
                        opora.Izolyator_SHF20 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_k9")
                    {
                        opora.Kolpachek_k9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PS2")
                    {
                        opora.Zazhim_PS2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhimy")
                    {
                        opora.Zazhimy = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        opora.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Natyazhnaya")
                    {
                        opora.Podveska_Natyazhnaya = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Podderzh")
                    {
                        opora.Podveska_Podderzh = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Podderzh2")
                    {
                        opora.Podveska_Podderzh2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "ZZveno_Promezhut")
                    {
                        opora.ZZveno_Promezhut = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_SK7")
                    {
                        opora.Skoba_SK7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Serga_SRS7")
                    {
                        opora.Serga_SRS7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Uzel_krepl")
                    {
                        opora.Uzel_krepl = Convert.ToInt32(childnode.InnerText);
                    }

                }
                selectOpory.Add(opora);
            }
            return selectOpory;
        }
        public List<Razyed3> GetRaz_3()
        {
            //создаём список разъединителей
            var selectRz = new List<Razyed3>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Razyed3.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём разъед вл
                var raz = new Razyed3();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        raz.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Kronstein_RA1")
                    {
                        raz.Kronstein_RA1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA2")
                    {
                        raz.Kronstein_RA2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA4")
                    {
                        raz.Kronstein_RA4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_RA5")
                    {
                        raz.Kronstein_RA5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Val_RA7")
                    {
                        raz.Val_RA7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Val_RA8")
                    {
                        raz.Val_RA8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R2")
                    {
                        raz.Kronstein_R2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_R6")
                    {
                        raz.Kronstein_R6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_KM1")
                    {
                        raz.Kronstein_KM1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_KM4")
                    {
                        raz.Skoba_KM4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_KM5")
                    {
                        raz.Skoba_KM5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ugolok_80")
                    {
                        raz.Ugolok_80 = Convert.ToInt32(childnode.InnerText);

                    }
                    if (childnode.Name == "Homut_X37")
                    {
                        raz.Homut_X37 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X38")
                    {
                        raz.Homut_X38 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X39")
                    {
                        raz.Homut_X39 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X40")
                    {
                        raz.Homut_X40 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_X41")
                    {
                        raz.Homut_X41 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shtyr_OG11")
                    {
                        raz.Shtyr_OG11 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        raz.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Krug_10")
                    {
                        raz.Krug_10 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        raz.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }

                    if (childnode.Name == "Razed_RLND")
                    {
                        raz.Razed_RLND = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Privod_PRNZ")
                    {
                        raz.Privod_PRNZ = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Mufta_KMA")
                    {
                        raz.Mufta_KMA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Mufta_KN")
                    {
                        raz.Mufta_KN = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Razryad_vent")
                    {
                        raz.Razryad_vent = Convert.ToInt32(childnode.InnerText);
                    }


                    if (childnode.Name == "Izol_SHF20")
                    {
                        raz.Izol_SHF20 = Convert.ToInt32(childnode.InnerText);

                    }

                    if (childnode.Name == "Kolpachek_K9")
                    {
                        raz.Kolpachek_K9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PA")
                    {
                        raz.Zazhim_PA = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_apparat")
                    {
                        raz.Zazhim_apparat = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_apparat2")
                    {
                        raz.Zazhim_apparat2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakonech_7_8")
                    {
                        raz.Nakonech_7_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Oshinovka")
                    {
                        raz.Oshinovka = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Provod_zazeml")
                    {
                        raz.Provod_zazeml = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_M12")
                    {
                        raz.Bolt_M12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_M8")
                    {
                        raz.Bolt_M8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Gayka_M12")
                    {
                        raz.Gayka_M12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Gayka_M8")
                    {
                        raz.Gayka_M8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_12")
                    {
                        raz.Shayba_12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_8")
                    {
                        raz.Shayba_8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shayba_pruzhin")
                    {
                        raz.Shayba_pruzhin = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        raz.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                }
                selectRz.Add(raz);
            }
            return selectRz;
        }
        //список названий опор четвёртой серии
        public List<string> GetNameOp_4()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory4.xml");
            listName = Name(xDoc);
            return listName;
        }
        public List<Opory16m> GetOp_4()
        {
            //создаём список опор
            var selectOpory = new List<Opory16m>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory4.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём опору вл
                var opora = new Opory16m();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        opora.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Stoyka_16")
                    {
                        opora.Stoyka_16 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Plita_P3")
                    {
                        opora.Plita_P3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ancer_AC")
                    {
                        opora.Ancer_AC = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_15")
                    {
                        opora.Traversa_15 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_16")
                    {
                        opora.Traversa_16 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_17")
                    {
                        opora.Traversa_17 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_18")
                    {
                        opora.Traversa_18 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ottyazhka_3")
                    {
                        opora.Ottyazhka_3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ottyazhka_4")
                    {
                        opora.Ottyazhka_4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ottyazhka_5")
                    {
                        opora.Ottyazhka_5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_B1")
                    {
                        opora.Bolt_B1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_B6")
                    {
                        opora.Bolt_B6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG2")
                    {
                        opora.Nakladka_OG2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x33")
                    {
                        opora.Homut_x33 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x34")
                    {
                        opora.Homut_x34 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x35")
                    {
                        opora.Homut_x35 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        opora.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        opora.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Zazhim_ps3")
                    {
                        opora.Zazhim_ps3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_soedin")
                    {
                        opora.Zazhim_soedin = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_podderzh_izol")
                    {
                        opora.Podveska_podderzh_izol = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_podderzh_izol2")
                    {
                        opora.Podveska_podderzh_izol2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_natyazh_izol")
                    {
                        opora.Podveska_natyazh_izol = Convert.ToInt32(childnode.InnerText);
                    }

                }
                selectOpory.Add(opora);
            }
            return selectOpory;
        }
        //список названий опор пятой серии
        public List<string> GetNameOp_5()
        {
            var listName = new List<string>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory5.xml");
            listName = Name(xDoc);
            return listName;
        }
        public List<OporyPP> GetOp_5()
        {
            //создаём список опор
            var selectOpory = new List<OporyPP>();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(file + @"\Opory5.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                //создаём опору вл
                var opora = new OporyPP();
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        opora.Name = attr.Value;
                    }

                }
                // обходим все дочерние узлы элемента xml
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "Stoyka_105")
                    {
                        opora.Stoyka_105 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Stoyka_7_13")
                    {
                        opora.Stoyka_7_13 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Stoyka_164_12")
                    {
                        opora.Stoyka_164_12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Pristavka_PT_45")
                    {
                        opora.Pristavka_PT_45 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Pristavka_PT43_2")
                    {
                        opora.Pristavka_PT43_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Plita_P3")
                    {
                        opora.Plita_P3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Anker")
                    {
                        opora.Anker = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ves_Zh")
                    {
                        opora.Ves_Zh = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_2")
                    {
                        opora.Traversa_2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_3")
                    {
                        opora.Traversa_3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_4")
                    {
                        opora.Traversa_4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_6")
                    {
                        opora.Traversa_6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_13")
                    {
                        opora.Traversa_13 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_14")
                    {
                        opora.Traversa_14 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_17")
                    {
                        opora.Traversa_17 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_21")
                    {
                        opora.Traversa_21 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_22")
                    {
                        opora.Traversa_22 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_23")
                    {
                        opora.Traversa_23 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Traversa_30")
                    {
                        opora.Traversa_30 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nadstavka_1")
                    {
                        opora.Nadstavka_1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nadstavka_4")
                    {
                        opora.Nadstavka_4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nadstavka_6 ")
                    {
                        opora.Nadstavka_6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG1")
                    {
                        opora.Ogolovok_OG1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG7")
                    {
                        opora.Ogolovok_OG7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OG8")
                    {
                        opora.Nakladka_OG8 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Shtyr_OG11")
                    {
                        opora.Shtyr_OG11 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronstein_OG12")
                    {
                        opora.Kronstein_OG12 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG13")
                    {
                        opora.Ogolovok_OG13 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG14")
                    {
                        opora.Ogolovok_OG14 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ogolovok_OG15")
                    {
                        opora.Ogolovok_OG15 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_b1")
                    {
                        opora.Bolt_b1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_b5")
                    {
                        opora.Bolt_b5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Bolt_b6")
                    {
                        opora.Bolt_b6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x1")
                    {
                        opora.Homut_x1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x4")
                    {
                        opora.Homut_x4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x5")
                    {
                        opora.Homut_x5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x24 ")
                    {
                        opora.Homut_x24 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x25")
                    {
                        opora.Homut_x25 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x33")
                    {
                        opora.Homut_x33 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x34 ")
                    {
                        opora.Homut_x34 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Homut_x36")
                    {
                        opora.Homut_x36 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_U1")
                    {
                        opora.Kronshtein_U1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_U2")
                    {
                        opora.Kronshtein_U2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kronshtein_U5 ")
                    {
                        opora.Kronshtein_U5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Styazhka_G1")
                    {
                        opora.Styazhka_G1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Upor_G6")
                    {
                        opora.Upor_G6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ottyazhka_OT3")
                    {
                        opora.Ottyazhka_OT3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Ottyazhka_OT4")
                    {
                        opora.Ottyazhka_OT4 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Styazhka_OT5")
                    {
                        opora.Styazhka_OT5 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Nakladka_OT6")
                    {
                        opora.Nakladka_OT6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Provodnik_ZP1")
                    {
                        opora.Provodnik_ZP1 = Convert.ToDouble(childnode.Value);
                    }
                    if (childnode.Name == "Stal_Ves")
                    {
                        opora.Stal_Ves = Convert.ToDouble(childnode.Value);
                    }
                   
                    if (childnode.Name == "Izolyator_SHF20")
                    {
                        opora.Izolyator_SHF20 = Convert.ToInt32(childnode.InnerText);
                    }
                    
                    if (childnode.Name == "Kolpachek_k6")
                    {
                        opora.Kolpachek_k6 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kolpachek_k9")
                    {
                        opora.Kolpachek_k9 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Kreplenie_provoda")
                    {
                        opora.Kreplenie_provoda = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PS2")
                    {
                        opora.Zazhim_PS2 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Zazhim_PS3")
                    {
                        opora.Zazhim_PS3 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Natyazhnaya_izol")
                    {
                        opora.Podveska_Natyazhnaya_izol = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Natyazhnaya_izol_1")
                    {
                        opora.Podveska_Natyazhnaya_izol_1 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Podveska_Natyazhnaya_podderzh")
                    {
                        opora.Podveska_Natyazhnaya_podderzh = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "ZZveno_Promezhut")
                    {
                        opora.ZZveno_Promezhut = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Skoba_SK7")
                    {
                        opora.Skoba_SK7 = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "Serga_SRS7")
                    {
                        opora.Serga_SRS7 = Convert.ToInt32(childnode.InnerText);
                    }
                    
                }
                selectOpory.Add(opora);
            }
            return selectOpory;
        }
    }
}

