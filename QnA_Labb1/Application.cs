using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnA_Labb1
{
    internal class Application
    {

        public void WriteIntro()
        {
            Console.WriteLine(@"
This is an app where you can ask questions about 
spirituality, tarot cards or meditation.
");
        }

        public void WriteLogo()
        {
            Console.WriteLine(@"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                SoulGuide
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
     (
     )\
     {_}
    .-;-.
   |'-=-'|
   |     |
   |     |
   |     |
   |     |
   '.___.'
                        ");

        }

        public void EndApp()
        {
                Console.Clear();
                Console.WriteLine(@"
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
You have chosen to quit the app.
The app will close...");
                Thread.Sleep(2500);
                Environment.Exit(0);
        }

        public static string WrapText(string text, int maxWidth)
        {
            var lines = new List<string>();

            // Split the input text into individual words
            var words = text.Split(' ');
            var currentLine = "";

            // Iterate over each word in the text
            foreach (var word in words)
            {
                if ((currentLine + word).Length > maxWidth)
                {
                    // Trim any extra spaces and add the current line to the list of lines
                    lines.Add(currentLine.Trim());

                    // Reset the currentLine string to start constructing a new line
                    currentLine = "";
                }

                // Add the word to the current line with a space before it
                currentLine += $" {word}";
            }

            // After processing all words, if there's any content left in the currentLine, 
            // add it to the list of lines after trimming extra spaces
            if (!string.IsNullOrWhiteSpace(currentLine))
                lines.Add(currentLine.Trim());

            // Join the list of lines using a new line as the separator and return the result
            return string.Join(Environment.NewLine, lines);
        }

    }
}
