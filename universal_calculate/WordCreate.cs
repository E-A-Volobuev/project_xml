using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace universal_calculate
{
    public class WordCreate
    {
        
        //заполнение расчетной активной мощности электродвигателя 
        //для одной линии
        public string Rasch_oborud_1(string path,string newPath, string[] text_insert, string[] text_replace)
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
            }
            using (WordprocessingDocument wordDoc =
           WordprocessingDocument.Open(newPath, true))
            {
                string docText = null;
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                for (int i = 0; i < text_insert.Length; i++)
                {
                   
                    Regex regexText = new Regex(text_replace[i]);
                    docText = regexText.Replace(docText, text_insert[i]);
                }
                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
                
            }
            return "Документ сформирован! Заберите его здесь:"+newPath;
        }
        //для двух линий
        public string Rasch_oborud_2(string path, string[] text_insert, string[] text_replace)
        {

            using (WordprocessingDocument wordDoc =
           WordprocessingDocument.Open(path, true))
            {

                string docText = null;
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                for (int i = 0; i < text_insert.Length; i++)
                {
                    
                    Regex regexText = new Regex(text_replace[i]);
                    docText = regexText.Replace(docText, text_insert[i]);
                }
                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }

            }
            return "Документ сформирован! Заберите его здесь:" + path;
           
        }
      
    }
}
