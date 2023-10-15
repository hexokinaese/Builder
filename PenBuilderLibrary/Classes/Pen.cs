using System.Collections.Generic;

namespace BuilderPattern.Classes
{
    public class Pen
    {
        private List<string> parts = new List<string>();

        public void Add(string p) { this.parts.Add(p); }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.parts.Count; i++) 
            {
                str += this.parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Pen parts: " + str + "\n";
        }
    }
}
