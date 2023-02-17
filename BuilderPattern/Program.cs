using BuilderPattern.New;
using BuilderPattern.New.Interfaces;
using System;

/*
 what is: Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
 When use: When you have a big constructor
 */

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