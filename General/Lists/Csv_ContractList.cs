using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Csv_ContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Csv_Contract>
    {
        private string Was_File_Name = "Store.CSV";
        private string[] Was_File_Path = new string[] { @"z:\was1", @"z:\was2", @"z:\was3", @"z:\wasportable" };

        public Csv_ContractList()
        {
            this.spName = "";
            this.list = new List<RASF.General.Data.Csv_Contract>();
            this.deletedlist = new List<RASF.General.Data.Csv_Contract>();
        }

        public Csv_ContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill()
        {
            this.list = new List<Data.Csv_Contract>();

            foreach (string FilePath in Was_File_Path)
            {
                string file = this.CopyFile(FilePath);

                //MessageBox.Show(string.Format("{0}-{1}", file, FilePath));

                if (file != null)
                {
                    Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(file);
                    Aspose.Cells.Worksheet worksheet = workbook.Worksheets[0];
                    int num = 0;
                    string[] strArray = new string[60];
                    System.Globalization.CultureInfo enUS = null;
                    while (worksheet.Cells[num, 0].Value != null)
                    {
                        short num2 = 26;
                        short index = 0;
                        if (string.Equals(worksheet.Cells[num, 0].StringValue, "Date"))
                        {
                            while (worksheet.Cells[num, num2].Value != null)
                            {
                                strArray[index] = worksheet.Cells[num, num2].StringValue;
                                index = (short)(index + 1);
                                num2 = (short)(num2 + 2);
                            }
                        }
                        else if (string.Equals(worksheet.Cells[num, 0x18].StringValue, "0"))
                        {
                            if(enUS == null)
                            {
                                try
                                {
                                    enUS = new System.Globalization.CultureInfo("en-US");
                                    string pdate = this.GetPersianDateWithTime(Convert.ToDateTime(worksheet.Cells[num, 0].StringValue, enUS));
                                }
                                catch
                                {
                                    enUS = new System.Globalization.CultureInfo("es-ES");
                                    string pdate = this.GetPersianDateWithTime(Convert.ToDateTime(worksheet.Cells[num, 0].StringValue, enUS));
                                }
                            }
                            

                            RASF.General.Data.Csv_Contract item = new RASF.General.Data.Csv_Contract
                            {
                                Date = this.GetPersianDateWithTime(Convert.ToDateTime(worksheet.Cells[num, 0].StringValue, enUS)),
                                Base = worksheet.Cells[num, 1].StringValue,
                                Name = worksheet.Cells[num, 3].StringValue
                            };

                            while (worksheet.Cells[num, num2].Value != null)
                            {
                                RASF.General.Data.Csv_Data data = new RASF.General.Data.Csv_Data
                                {
                                    Name = strArray[index],
                                    Value = worksheet.Cells[num, num2].StringValue,
                                    Sign = worksheet.Cells[num, num2 - 1].StringValue
                                };
                                item.Csv_DataList.Add(data);
                                index = (short)(index + 1);
                                num2 = (short)(num2 + 2);
                            }
                            list.Add(item);
                        }
                        num++;
                    }
                }
            }
            return this.list.Count();
        }

        private string GetPersianDateWithTime(DateTime Date)
        {
            System.Globalization.PersianCalendar calendar = new System.Globalization.PersianCalendar();
            return string.Format("{0}/{1:D2}/{2:D2} : {3:D2}:{4:D2}", calendar.GetYear(Date), calendar.GetMonth(Date), calendar.GetDayOfMonth(Date), Date.Hour, Date.Minute);
        }
        private String CopyFile(String FilePath)
        {
            string sourceFileName = System.IO.Path.Combine(FilePath, this.Was_File_Name);
            string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), this.Was_File_Name);

            //MessageBox.Show(string.Format("{0}-{1}", sourceFileName, path));
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                System.IO.File.Copy(sourceFileName, path, true);
                return path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}