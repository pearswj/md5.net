using System;
using System.IO;

namespace Md5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            foreach (string path in args)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                string hash;
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower(); // unix-y md5 hash
                    }
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                Console.WriteLine(string.Format("{0}\t{1}\t{2}ms", path, hash, elapsedMs));
            }
        }
    }
}
