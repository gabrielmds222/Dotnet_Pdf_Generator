using System.Security.Cryptography.X509Certificates;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

QuestPDF.Settings.License = LicenseType.Community;

Document.Create(container => 
{
    container.Page(page => 
    {
        page.Size(PageSizes.A4);
         page.Margin(value:2, Unit.Centimetre);
         page.PageColor(Colors.White);
         page.DefaultTextStyle(handler:x => x.FontSize(20));
    });
})//Document
.ShowInCompanion();
