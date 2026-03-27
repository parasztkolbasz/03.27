namespace _03._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kiadas> kiadasok;
            
            StreamReader sr = new StreamReader("kiadas.txt");
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(";");
                foreach (var item in sor)
                {
                    
                }
            }
            sr.Close();
        }
    }
}
