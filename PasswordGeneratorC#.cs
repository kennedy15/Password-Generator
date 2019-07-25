       
       Password Generator written in C#
       
       string[] Word_Lines = System.IO.File.ReadAllLines(@"C:\Users\nkennedy\Documents\words.txt");

       string characters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqUuRrSsTtVvWwXxYyZz123456789";
       
       public string Generate_Password()
        {
            int length = Word_Lines.Length;

            Random random = new Random();

            StringBuilder second_half = new StringBuilder();

            string first_half = Word_Lines[random.Next(length)];

            int size = 5;

            if (first_half.Length > 6)
            {
                int end = first_half.Length;
                first_half = first_half.Remove(4, end - 4);
            }

            for (int i = 0; i < size; i++)
            {
                second_half.Append(characters[random.Next(characters.Length)]);
            }

            return first_half + second_half.ToString();

        }
