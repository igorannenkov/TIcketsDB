using System;
using System.Windows.Forms;
using MS_Excel = Microsoft.Office.Interop.Excel;

namespace TIckets
{
    internal static class ExcelReporter
    {
        public static void GetReport(DataGridView gridView)
        {
            try
            {
                MS_Excel.Application app = new MS_Excel.Application();
                MS_Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                MS_Excel.Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Лист1"];
                worksheet = workbook.ActiveSheet;
                MS_Excel.Range cells = workbook.Worksheets[1].Cells;
                // Устанавливаем текстовый формат ячеек.
                cells.NumberFormat = "@";

                for (int i = 1; i < gridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = gridView.Columns[i - 1].HeaderText;
                    app.ActiveCell.EntireRow.Font.Bold = true;
                }
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < gridView.Columns.Count; j++)
                    {
                        if (gridView.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = gridView.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                app.Columns.AutoFit();
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("Ошибка выгрузки данных. Вероятно в системе не установлен MS Office. \r\n\r\n" + ex.Message,
                                "Ошибка выгрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка выгрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}