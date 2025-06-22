import java.util.*;
public class Main {
    public static void main(String[] args) {
        System.out.println("Documents available:\n.docx \n.pdf \n.xlsx");
        System.out.println("Enter the document type:");
        Scanner sc=new Scanner(System.in);
        String type = sc.nextLine();
        if (type.equalsIgnoreCase("docx") || type.equalsIgnoreCase(".docx")) {
            DocumentFactory wordFactory = new WordDocumentFactory();
            Document word = wordFactory.createDocument();
            word.creating();
            word.opening();
            word.saveing();
            word.closing();
        }
        else if (type.equalsIgnoreCase("pdf") || type.equalsIgnoreCase(".pdf")){
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdf = pdfFactory.createDocument();
            pdf.creating();
            pdf.opening();
            pdf.saveing();
            pdf.closing();
        }

        else if (type.equalsIgnoreCase("xlsx") || type.equalsIgnoreCase(".xlsx")){
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excel = excelFactory.createDocument();
            excel.creating();
            excel.opening();
            excel.saveing();
            excel.closing();
        }
    }
}
