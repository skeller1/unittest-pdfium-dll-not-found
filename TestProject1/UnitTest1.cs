using Syncfusion.PdfToImageConverter;

namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			PdfToImageConverter imageConverter = new PdfToImageConverter();
			//Load the PDF document as a stream
			FileStream inputStream = new FileStream(Path.GetFullPath(@"../../../Input.pdf"), FileMode.Open, FileAccess.ReadWrite);
			imageConverter.Load(inputStream);
			//Convert PDF to Image.
			Stream outputStream = imageConverter.Convert(0, false, false);

			outputStream.Position = 0;
			outputStream.CopyTo(File.Create("test.jpg"));
		}
	}
}