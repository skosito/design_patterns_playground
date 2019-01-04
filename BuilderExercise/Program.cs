using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExercise
{
    class Program
    {
        public class Property 
        {
            public string Name, Type;

            public override string ToString()
            {
                return $"public {Type} {Name}";
            }
        }

        public class Class
        {
            public string Name;
            public List<Property> Properties = new List<Property>();

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"public class {Name}").AppendLine("{");
                foreach(var p in Properties)
                {
                    sb.AppendLine($"  {p};");
                }
                sb.AppendLine("}");

                return sb.ToString();
            }
        }

        public class CodeBuilder
        {
            private Class _rootClass = new Class();

            public CodeBuilder(string rootName)
            {
                _rootClass.Name = rootName;
            }

            public CodeBuilder AddField(string n, string t)
            {
                _rootClass.Properties.Add(new Property { Name = n, Type = t });
                return this;
            }

            public override string ToString()
            {
                return _rootClass.ToString();
            }
        }

        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            System.Console.WriteLine(cb);
        }
    }
}
