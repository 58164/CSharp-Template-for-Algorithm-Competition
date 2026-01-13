using Equinox.IO;

namespace Template {
    public class Solution
    {
        public void Solve()
        {

        }
        public void _Main()
        {
            int T = 1;
             T = br.ReadInt32();
            while (T-- > 0)
            {
                Solve();
            }
            bw.Output();
            SourceExpander.Expander.Expand();
        }

        public Solution(Stream inputStream = null, Stream outputStream = null)
        {
            br = new BufferedReader(inputStream ?? Console.OpenStandardInput(), 0);
            bw = new BufferedWriter(outputStream ?? Console.OpenStandardOutput());
        }
        public static void Main(string[] args) => new Solution()._Main();
        private readonly BufferedReader br;
        private readonly BufferedWriter bw; 
    }
}
