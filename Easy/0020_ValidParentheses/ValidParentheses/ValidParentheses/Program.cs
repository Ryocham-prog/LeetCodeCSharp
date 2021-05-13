using System;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var isval = new Program();
            var s = "([])";
            var rtn = isval.IsValid(s);
        }

        // Runtime: 124ms
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1) return false;

            var targetBefore = s;
            var targetAfter = string.Empty;
            var i = 0;
            while (targetBefore.Length != targetAfter.Length)
            {
                if (i != 0) targetBefore = targetAfter;

                targetAfter = targetBefore.Replace("()", "");
                targetAfter = targetAfter.Replace("[]", "");
                targetAfter = targetAfter.Replace("{}", "");

                i++;
            }
            return targetAfter.Length == 0;
        }

        // Runtime: 152ms
        public bool IsValid2(string s)
        {
            if (s.Length % 2 == 1) return false;
            var target = s;

            while (target.IndexOf("()") > -1 || target.IndexOf("[]") > -1 || target.IndexOf("{}") > -1)
            {
                target = target.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return target.Length == 0;
        }

        // Runtime: 128ms
        public bool IsValid3(string s)
        {
            if (s.Length % 2 == 1) return false;
            var target = s;

            var isLoop = true;
            while (isLoop == true)
            {
                var beforeTarget = target;
                target = target.Replace("()", "").Replace("[]", "").Replace("{}", "");

                if (beforeTarget == target) isLoop = false;
            }
            return target.Length == 0;
        }

    }
}
