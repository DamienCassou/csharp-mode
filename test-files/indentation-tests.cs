using System;

/* comment block
   on namespace test */
namespace Boo
{
    // comment on class test
    public class Foo
    {
        // auto-property-test
        public bool AutoProperty { get; set; }

        // regular property-test
        public bool Property
        {
            get
            {
                return true;
            }
            set
            {
                // ignored
            }
        }

        /// <summary>
        ///   Codedoc on method-test
        /// </summary>
        public void Foo(string a = "hkfdhkd", string b = "bbbbbb")
        {
            // OK!
        }

        public void Test()
        {
            if (test)
            {

            }

            if (test2) {
                // should work too
                bool b = true;
            }

            var x = new {
                adhoc = object,
                with = new prop(),
            };

            var array1 = new ArrayList
            {
                1, 2, 3, 4, 5
            };

            var array2 = new string[]
            {
                "a", "b", "c"
            };

            var map = new Dictionary<int,string> {
                { 1, "true" },
                { 2, "false" },
            };

            var map2 = new Dictionary<int,string>
            {
                { 1, "true" },
                { 2, "false" },
            };

            var map3 = new Dictionary<string,Func<int, bool>>
            {
                { "IsZero", (int i) => i == 0 }
            };

            using (test)
            {
                System.Console.WriteLine("boo");
            }
        }

        public void CaseStamentIndentation()
        {
            int bar = 0;
            switch (foo)
            {
                case "foo":
                    bar = 0;
                    break;
            }
            switch (bar)
            {
                case 1:
                case 2:
                    bar = 0;
                    break;
            }
            switch (foo)
            {
                case "foo":
                case "bar":
                    bar = 0;
                    bar += 1;
                    break;
            }
        }
    }

    // enum-tests

    public enum Enumizer
    {
        a,
        b,
        c
    }

    public enum Inheritance : int
    {
        a,
        b,
        c
    }
}
