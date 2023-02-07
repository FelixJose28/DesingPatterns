// See https://aka.ms/new-console-template for more information
using Strategy;

//Reports types
ExcelReport excelReport = new();
PdfReport pdfReport = new();
WordReport wordReport = new();


ReportLogic reportLogic = new();



reportLogic.ExecuteReport(excelReport);
reportLogic.ExecuteReport(pdfReport);
reportLogic.ExecuteReport(wordReport);
