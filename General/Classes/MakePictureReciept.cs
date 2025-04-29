using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public static class MakePictureReciept
    {
        
        public static RASF.General.Data.GetDocumentForPrint MakePage(Guid PartsTestMasterCode,Boolean RType,String LabType,String ManageName,String EnglishManageName)
        {
            byte[] Template;
            if (RType == false)
            {
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", "http://reports.razi-foundation.com/Pershian Template/Main/TemplatePic.docx"));
                Template = (byte[])RASF.General.Lists.BanksList.FillScalar("SelectFile", Parameters);
            }
            else
            {

                List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("@FileName", "http://reports.razi-foundation.com/English Template/Main/TemplatePic.docx"));
                Template = (byte[])RASF.General.Lists.BanksList.FillScalar("SelectFile", Parameters1);
            }
            
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            RASF.General.Lists.ReportPart_PicList Part_Pics_List = new Lists.ReportPart_PicList();
            Part_Pics_List.Fill(Parameters2);

            object missing = System.Reflection.Missing.Value;
            object readOnly = false;
            object isVisible = false;

            object fileName = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), System.IO.Path.GetRandomFileName());
           
            System.IO.File.WriteAllBytes(fileName.ToString(), Template);
           
            Microsoft.Office.Interop.Word.Application applicationWord = new Microsoft.Office.Interop.Word.Application();
           // Microsoft.Office.Interop.Word.Document modelloBusta = applicationWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref  missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
           // Microsoft.Office.Interop.Word.Document modelloBusta;
            Microsoft.Office.Interop.Word.Document modelloBusta = applicationWord.Documents.Add();


            try
            {

                modelloBusta = applicationWord.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref  missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);
                modelloBusta.Activate();

                RASF.General.Classes.Utility.Carte_Part_Table(modelloBusta, Part_Pics_List.list);
                modelloBusta.Save();
                modelloBusta.Close(ref missing, ref missing, ref missing);
               

            }
            catch
            {

            }
            applicationWord.Quit(ref missing, ref missing, ref missing);
            List<String> ManagerName = new List<String>();
            List<String> LaboratoryType = new List<String>();

            RASF.General.Data.GetDocumentForPrint Doc = new Data.GetDocumentForPrint();
            Doc.Content = System.IO.File.ReadAllBytes(fileName.ToString());
            Doc.Content = RASF.General.Classes.BookMarks.SetBookMarks(PartsTestMasterCode, Doc.Content, General.Enums.BookMark.AddState, RType);
            Doc.ManagerName = ManageName;
            Doc.LaboratoryType = LabType;
            ManagerName.Add(Doc.ManagerName);
            LaboratoryType.Add(Doc.LaboratoryType);
            Doc.PartsTestMasterCode = PartsTestMasterCode;
            Doc.TotalPage = 0;
            
            System.IO.File.Delete(fileName.ToString());
            return Doc;
        }
    }
}
