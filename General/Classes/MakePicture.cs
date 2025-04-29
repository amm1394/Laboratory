using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public static class MakePicture
    {
        
        public static RASF.General.Data.GetDocumentForPrint MakePage(Guid PartsTestMasterCode,Boolean RType,String LabType,String ManageName,String EnglishManageName)
        {
            byte[] Template;
            if (RType == false)
            {
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", "http://reports.razi-foundation.com/Pershian Template/Main/TemplatePic.docx"));
                Template = (byte[])RASF.General.Lists.BanksList.FillScalar("SelectFilePic", Parameters);
            }
            else
            {

                List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("@FileName", "http://reports.razi-foundation.com/English Template/Main/NewTemplatePic.docx"));
                Template = (byte[])RASF.General.Lists.BanksList.FillScalar("SelectFilePic", Parameters1);
            }
            
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            RASF.General.Lists.ReportPart_PicList Part_Pics_List = new Lists.ReportPart_PicList();
            Part_Pics_List.Fill(Parameters2);

           // object missing = System.Reflection.Missing.Value;
           // object readOnly = false;
           // object isVisible = false;

           // object fileName = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), System.IO.Path.GetRandomFileName());
           
           // System.IO.File.WriteAllBytes(fileName.ToString(), Template);
           
           // Microsoft.Office.Interop.Word.Application applicationWord = new Microsoft.Office.Interop.Word.Application();
           //// Microsoft.Office.Interop.Word.Document modelloBusta = applicationWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref  missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
           //// Microsoft.Office.Interop.Word.Document modelloBusta;
           // Microsoft.Office.Interop.Word.Document modelloBusta = applicationWord.Documents.Add();


            RASF.General.Data.GetDocumentForPrint Doc = new Data.GetDocumentForPrint();
            //try
            //{
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Template))
            {
                Aspose.Words.Document doc = new Aspose.Words.Document(ms);
                Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
                using (System.Drawing.Image img = System.Drawing.Image.FromStream(new System.IO.MemoryStream(Part_Pics_List[0].Pciture)))
                {
                    builder.InsertImage(img, Aspose.Words.Drawing.RelativeHorizontalPosition.Margin, 125, Aspose.Words.Drawing.RelativeVerticalPosition.Margin, 10, img.Width * 0.65, img.Height * 0.65, Aspose.Words.Drawing.WrapType.Square);
                }
                using (System.IO.MemoryStream DocMs = new System.IO.MemoryStream())
                {
                    doc.Save(DocMs, Aspose.Words.SaveFormat.Docx);
                    DocMs.Flush();
                    Doc.Content = DocMs.ToArray();
                }
            }
                //modelloBusta = applicationWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref  missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
                //modelloBusta.Activate();

                //RASF.General.Classes.Utility.Carte_Part_Table(modelloBusta, Part_Pics_List.list);
                //modelloBusta.Save();
                //modelloBusta.Close(ref missing, ref missing, ref missing);
               

            //}
            //catch
            //{

            //}
//            applicationWord.Quit(ref missing, ref missing, ref missing);
            List<String> ManagerName = new List<String>();
            List<String> LaboratoryType = new List<String>();

//            Doc.Content = System.IO.File.ReadAllBytes(fileName.ToString());
            Doc.Content = RASF.General.Classes.BookMarks.SetBookMarks(PartsTestMasterCode, Doc.Content, General.Enums.BookMark.AddState, RType);
            Doc.ManagerName = ManageName;
            Doc.LaboratoryType = LabType;
            ManagerName.Add(Doc.ManagerName);
            LaboratoryType.Add(Doc.LaboratoryType);
            Doc.PartsTestMasterCode = PartsTestMasterCode;
            Doc.TotalPage = 1;
          
            
  //          System.IO.File.Delete(fileName.ToString());
            return Doc;
        }
    }
}
