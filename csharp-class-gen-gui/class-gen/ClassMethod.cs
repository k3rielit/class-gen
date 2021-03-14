using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_gen {
    public class ClassMethod {
        public bool IsAsync { get; set; }
        public string Access { get; set; }
        public string Type { get; set; }
        public string TypeMod { get; set; }
        public string Name { get; set; }
        public ClassMethod(bool isasync, string access, string typemod, string type, string name) {
            Access = access;
            IsAsync = isasync;
            Type = type;
            TypeMod = typemod;
            Name = name;
        }
        public string GetMethodType() {
            if(Type=="void") {
                return "void";
            }
            switch (TypeMod) {
                case "List":        return $"List<{Type}>";
                case "Array":       return $"{Type}[]";
                case "Dictionary":  return $"Dictionary<{Type},{Type}>";
                default:            return Type;
            }
        }
        public string GetCode(int indent) => new string(' ',indent)+Access+(IsAsync ? " async " : " ")+GetMethodType()+" "+Name+"() {}";
    }
}
