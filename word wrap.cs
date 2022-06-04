namespace Enosis
{
    class wWrapC
    {
        // public static List<string> WordWrap(string input, int maxCharacters)
        public void wordwrapM()
    {
        string input = "jsdbvfsabcsaufg uwgfuygw wgtfuy gfuyrgf yq guqg ougyqgf quwfgoyqegf gv qwr gfgq o8wfeo qwo ";
        int maxCharacters = 20;
        List<string> lines = new List<string>();

        if (!input.Contains(" ") && !input.Contains("\n"))
        {
            int start = 0;
            while (start < input.Length)
            {
                lines.Add(input.Substring(start, Math.Min(maxCharacters, input.Length - start)));
                start += maxCharacters;
            }
        }
        else
        {
            string[] paragraphs = input.Split('\n');

            foreach (string paragraph in paragraphs)
            {
                string[] words = paragraph.Split(' ');

                string line = "";
                foreach (string word in words)
                {
                    if ((line + word).Length > maxCharacters)
                    {
                        lines.Add(line.Trim());
                        line = "";
                    }

                    line += string.Format("{0} ", word);
                }

                if (line.Length > 0)
                {
                    lines.Add(line.Trim());
                }
            }
        }
        foreach (var item in lines)
        {
            System.Console.WriteLine(item);
        }
    }
    }
}