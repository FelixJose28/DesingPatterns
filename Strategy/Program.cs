// See https://aka.ms/new-console-template for more information
using Strategy;
/*
 what is: Strategy is a behavioral design pattern that turns a set of behaviors into objects and makes them interchangeable inside original context object.
 When use: Use the Strategy when you have a huge switch or if else. Use when you have a lot of similar classes that only differ in the way they execute some behavior.
 */


//Reports types
ExcelReport excelReport = new();
PdfReport pdfReport = new();
WordReport wordReport = new();


ReportLogic reportLogic = new();



reportLogic.ExecuteReport(excelReport);
reportLogic.ExecuteReport(pdfReport);
reportLogic.ExecuteReport(wordReport);
