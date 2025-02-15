namespace EMV.Decode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código Pix (copia e cola):");

            string? pixCode = Console.ReadLine();
            
            if (string.IsNullOrEmpty(pixCode))
            {
                Console.WriteLine("Código Pix não pode ser vazio.");
                return;
            }

            try
            {
                var decodedEMV = DecodeEMV(pixCode);
                Console.WriteLine("======================================");
                PrintEMVStructure(decodedEMV);
            }
            catch (Exception ex)
            {
                string message = ex.Message + ex.StackTrace;

                Console.WriteLine(message);
            }
            
        }

        static Dictionary<string, string> DecodeEMV(string pixCode)
        {
            Dictionary<string, string> emvData = new Dictionary<string, string>();

            try
            {
                int index = 0;
                while (index < pixCode.Length)
                {
                    string tag = pixCode.Substring(index, 2);
                    index += 2;
                    int length = int.Parse(pixCode.Substring(index, 2));
                    index += 2;
                    string value = pixCode.Substring(index, length);
                    index += length;

                    emvData[tag] = value;
                }

               
            }
            catch (Exception ex)
            {
                string message = ex.Message + ex.StackTrace; 

                Console.WriteLine(message);
            }
            return emvData;
        }

        static void PrintEMVStructure(Dictionary<string, string> emvData)
        {
            Dictionary<string, string> emvTags = new Dictionary<string, string>
            {
                {"00", "Payload Format Indicator"},
                {"01", "Point of Initiation Method"},
                {"26", "Merchant Account Information"},
                {"52", "Merchant Category Code"},
                {"53", "Transaction Currency"},
                {"54", "Transaction Amount"},
                {"58", "Country Code"},
                {"59", "Merchant Name"},
                {"60", "Merchant City"},
                {"62", "Additional Data Field Template"},
                {"63", "CRC"}
            };

            try
            {
                foreach (var tag in emvData)
                {
                    string tagName = emvTags.ContainsKey(tag.Key) ? emvTags[tag.Key] : "Unknown Tag";
                    //Console.WriteLine($"{tagName} ({tag.Key}): {tag.Value}");
                    Console.WriteLine($"({tag.Key}) {tagName} : {tag.Value}");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }
    }
}


