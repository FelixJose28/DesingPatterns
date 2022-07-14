using BuilderPattern;
using BuilderPattern.New;
using BuilderPattern.New.Interfaces;
using System;

// Client Code
ReportProduct report;
ReportDirector reportDirector = new ReportDirector();
// Construct and display Reports
PDFReport pdfReport = new PDFReport();
report = reportDirector.MakeReport(pdfReport);
report.DisplayReport();
Console.WriteLine("-------------------");
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();

Console.ReadKey();