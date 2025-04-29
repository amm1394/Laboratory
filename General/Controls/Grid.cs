using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RASF.General.Controls
{
    public class Grid : Janus.Windows.GridEX.GridEX
    {
//        private Type rowType;
        public event RASF.General.Events.ReturnRow ReturnRow;

        [System.ComponentModel.Category("RASF")]
        public Boolean AlowRetrieveStructure { get; set; }

        [System.ComponentModel.Category("RASF")]
        public Janus.Windows.GridEX.TextAlignment TextAlignment { get; set; }

        public Grid()
            : base()
        {
            this.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.AlowRetrieveStructure = true;
            this.AlternatingColors = true;
            this.GroupByBoxVisible = false;
            this.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><RecordNavigator>سـطـر | از</RecordNavigator><FilterRowConditionNotContains>شامل نشود</FilterRowConditionNotContains><FilterRowConditionContains>شامل شود </FilterRowConditionContains><FilterRowConditionEqual>برابر باشد با</FilterRowConditionEqual><FilterRowConditionNotEqual>برابر نباشد با</FilterRowConditionNotEqual><FilterRowConditionGreaterThan>بزرگتر باشد از</FilterRowConditionGreaterThan><FilterRowConditionGreaterThanOrEqual>بزرگتر و مساوی باشد از</FilterRowConditionGreaterThanOrEqual><FilterRowConditionLessThan>کمتر باشد از</FilterRowConditionLessThan><FilterRowConditionLessThanOrEqual>کمتر و مساوی باشد از</FilterRowConditionLessThanOrEqual><FilterRowConditionContains>شامل شود با</FilterRowConditionContains><FilterRowConditionNotContains>شامل نشود با</FilterRowConditionNotContains><FilterRowConditionEndsWith>پایان یابد با</FilterRowConditionEndsWith><FilterRowConditionBeginsWith>شروع شود با</FilterRowConditionBeginsWith><FilterRowConditionIsEmpty>خالی باشد</FilterRowConditionIsEmpty><FilterRowConditionNotIsEmpty>خالی نباشد</FilterRowConditionNotIsEmpty><FilterRowConditionClear>حذف فیلتر</FilterRowConditionClear></LocalizableData>";
            this.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;

            this.BindingContextChanged += Grid_BindingContextChanged;
            this.RecordAdded += Grid_RecordAdded;
            this.DeletingRecord += Grid_DeletingRecord;
            this.RecordUpdated += Grid_RecordUpdated;
        }

        public new void Refetch()
        {
            if (this.BindingContext[this.DataSource].Position > this.BindingContext[this.DataSource].Count - 1)
            {
                this.BindingContext[this.DataSource].Position = this.BindingContext[this.DataSource].Count - 1;
            }
            base.Refetch();
        }

        private void Grid_RecordUpdated(object sender, EventArgs e)
        {
            Type rowType = this.CurrentRow.DataRow.GetType();

            System.Reflection.PropertyInfo info = rowType.GetProperty("RowState");

            if (info != null)
            {
                if ((RASF.General.Enums.RowState)info.GetValue(this.CurrentRow.DataRow) == RASF.General.Enums.RowState.Original)
                {
                    info.SetValue(this.CurrentRow.DataRow, RASF.General.Enums.RowState.Updated);
                   // this.Refetch();
                }
            }
        }    

        private void Grid_DeletingRecord(object sender, Janus.Windows.GridEX.RowActionCancelEventArgs e)
        {
           if (System.Windows.Forms.MessageBox.Show("آیا مطمئن هستید.","",System.Windows.Forms.MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
           {
               ((System.Collections.IList)this.DataSource).Remove(e.Row.DataRow);
           }
           this.Refetch();
        }

        private void Grid_RecordAdded(object sender, EventArgs e)
        {
            if (this.CurrentRow != null)
            {
                Type rowType = this.DataSource.GetType().BaseType.GenericTypeArguments[0];

                object instance = Activator.CreateInstance(rowType);

                System.Reflection.PropertyInfo RowState = rowType.GetProperty("RowState");
                RowState.SetValue(instance, RASF.General.Enums.RowState.Added);

                foreach (Janus.Windows.GridEX.GridEXColumn Col in this.RootTable.Columns)
                {
                    System.Reflection.PropertyInfo info = rowType.GetProperty(Col.Key);
                    if (info != null)
                    {
                        Object[] Attributes = info.GetCustomAttributes(typeof(RASF.General.Attributes.DataAttribute), false);
                        if (Attributes != null)
                        {
                            if (((RASF.General.Attributes.DataAttribute)Attributes[0]).IsUnique == true)
                            {
                                if (info.PropertyType == typeof(Guid))
                                {
                                    System.Reflection.MethodInfo GetId_Method = this.DataSource.GetType().GetMethod("GetId");
                                    info.SetValue(instance, GetId_Method.Invoke(this.DataSource, null));
                                }
                                else
                                {
                                    System.Reflection.MethodInfo Count_Method = this.DataSource.GetType().GetMethod("Count");
                                    info.SetValue(instance, Convert.ToDecimal(Count_Method.Invoke(this.DataSource, null)));
                                }
                            }
                            else if (this.CurrentRow.Cells[Col].Value != null)
                            {
                                info.SetValue(instance, this.CurrentRow.Cells[Col].Value);
                            }
                        }
                    }

                }

                ((System.Collections.IList)this.DataSource).Add(instance);

                this.Refetch();

                this.BindingContext[this.DataSource].Position = this.BindingContext[this.DataSource].Count - 1;

                if (this.ReturnRow != null)
                {
                    this.ReturnRow(new Events.ReturnRowEventArgs(this, instance));
                }
            }
        }

        private void Grid_BindingContextChanged(object sender, EventArgs e)
        {
            if ((this.DataSource != null) && (this.AlowRetrieveStructure == true))
            {
                this.RetrieveStructure();
                Type rowType = this.DataSource.GetType().BaseType.GenericTypeArguments[0];
                foreach (Janus.Windows.GridEX.GridEXColumn Col in this.RootTable.Columns)
                {
                    System.Reflection.PropertyInfo info = rowType.GetProperty(Col.Key);
                    if (info != null)
                    {
                        Object[] Attributes = info.GetCustomAttributes(typeof(RASF.General.Attributes.DataAttribute), false);
                        if (Attributes != null)
                        {
                            Col.Caption = ((RASF.General.Attributes.DataAttribute)Attributes[0]).Caption;
                            Col.Visible = ((RASF.General.Attributes.DataAttribute)Attributes[0]).Visibale;
                            Col.HeaderAlignment = TextAlignment;
                            Col.TextAlignment = TextAlignment;
                            if (String.IsNullOrWhiteSpace(((RASF.General.Attributes.DataAttribute)Attributes[0]).DataType) == false)
                            {
                                Col.InputMask = ((RASF.General.Attributes.DataAttribute)Attributes[0]).DataType;
                            }
                        }
                    }
                    else
                    {
                        Col.Visible = false;
                    }
                }
            }
        }
        public void RemoveBindingContextChanged()
        {
            this.BindingContextChanged -= Grid_BindingContextChanged;
        }

        public void ExportToExcel(String SheetName)
        {
            System.Windows.Forms.SaveFileDialog SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            SaveFileDialog.Filter = "Excel File|*.Xlsx";
            SaveFileDialog.Title = "Save an Excel File";
            SaveFileDialog.DefaultExt = "*.Xlsx";

            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Aspose.Cells.Workbook Workbook = new Aspose.Cells.Workbook(Aspose.Cells.FileFormatType.Xlsx);
                Aspose.Cells.Worksheet Worksheet = Workbook.Worksheets[0];
                if (SheetName.Length > 30)
                {
                    SheetName = SheetName.Trim().Substring(0, 30);
                }
                Worksheet.Name = SheetName;

                int Col = 0;
                foreach (Janus.Windows.GridEX.GridEXColumn Column in this.RootTable.Columns)
                {
                    if (Column.Visible == true)
                    {
                        Worksheet.Cells[0, Col].Value = Column.Caption;
                        Col++;
                    }
                }


                for (int i = 0; i < this.RowCount; i++)
                {
                    Col = 0;
                    foreach (Janus.Windows.GridEX.GridEXColumn Column in this.RootTable.Columns)
                    {
                        if (Column.Visible == true)
                        {
                            Worksheet.Cells[i + 1, Col].Value = this.GetRow(i).Cells[Column.Key].Value;
                            Col++;
                        }
                    }
                }
                Workbook.Save(SaveFileDialog.FileName);

                if (System.Windows.Forms.MessageBox.Show("آیا مایل به باز کردن فایل می باشید.","",System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(SaveFileDialog.FileName);
                    psi.UseShellExecute = true;
                    System.Diagnostics.Process.Start(psi);
                }
            }

        }

        public void ExportToAccess()
        {
            System.Windows.Forms.SaveFileDialog SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            SaveFileDialog.Filter = "access File|*.accdb";
            SaveFileDialog.Title = "Save an access File";
            SaveFileDialog.DefaultExt = "*.accdb";

            if (SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Aspose.Cells.Workbook Workbook = new Aspose.Cells.Workbook(Aspose.Cells.FileFormatType.Xlsx);
               // Aspose.Cells.
                Aspose.Cells.Worksheet Worksheet = Workbook.Worksheets[0];
                //if (SheetName.Length > 30)
                //{
                //    SheetName = SheetName.Trim().Substring(0, 30);
                //}
                //Worksheet.Name = SheetName;

                int Col = 0;
                foreach (Janus.Windows.GridEX.GridEXColumn Column in this.RootTable.Columns)
                {
                    if (Column.Visible == true)
                    {
                        Worksheet.Cells[0, Col].Value = Column.Caption;
                        Col++;
                    }
                }


                for (int i = 0; i < this.RowCount; i++)
                {
                    Col = 0;
                    foreach (Janus.Windows.GridEX.GridEXColumn Column in this.RootTable.Columns)
                    {
                        if (Column.Visible == true)
                        {
                            Worksheet.Cells[i + 1, Col].Value = this.GetRow(i).Cells[Column.Key].Value;
                            Col++;
                        }
                    }
                }
                Workbook.Save(SaveFileDialog.FileName);

                if (System.Windows.Forms.MessageBox.Show("آیا مایل به باز کردن فایل می باشید.", "", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(SaveFileDialog.FileName);
                    psi.UseShellExecute = true;
                    System.Diagnostics.Process.Start(psi);
                }
            }

        }


    }
}