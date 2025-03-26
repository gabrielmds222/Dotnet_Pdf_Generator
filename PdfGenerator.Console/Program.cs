using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

class Program
{
    static void Main()
    {
        // Definir a licença para evitar erros
        QuestPDF.Settings.License = LicenseType.Community;

        Document.Create(container =>
        {
            container.Page(page =>
            {
                page.Content().Text("Olá, este é um PDF gerado com QuestPDF!");
            });
        }).GeneratePdf("output.pdf");

        Console.WriteLine("PDF gerado com sucesso!");
    }
}
