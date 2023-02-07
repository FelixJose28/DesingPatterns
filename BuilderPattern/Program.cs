using BuilderPattern.New;
using BuilderPattern.New.Interfaces;
using System;

//builder: contructor muy grande o con mucho parametros. DIrector que le digo que metodo usar de acuerdo a ciertas configurciones por ejemplo (otra opcion es crear clase declarar peropiedades y pasar la clase como el proyecto de OIT cambiar funcionalidad a builder que es la correcta)


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