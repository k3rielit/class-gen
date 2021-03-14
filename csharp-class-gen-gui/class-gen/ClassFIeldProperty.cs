using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_gen {
    public class ClassFIeldProperty {
        public string Access { get; set; }
        public string Usage { get; set; }
        public bool HasGet { get; set; }
        public bool HasSet { get; set; }
        public string TypeMod { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public ClassFIeldProperty(string access, string usage, bool hasget, bool hasset, string typemod, string type, string name) {
            Access = access;
            Usage = usage;
            HasGet = hasget;
            HasSet = hasset;
            TypeMod = typemod;
            Type = type;
            Name = name;
        }
        public string GetPropType() {
            switch(TypeMod) {
                case "List":        return $"List<{Type}>";
                case "Array":       return $"{Type}[]";
                case "Dictionary":  return $"Dictionary<{Type},{Type}>";
                default:            return Type;
            }
        }
        public string GetCode(int indent) {
            string po = "{";
            string pc = "}";
            switch (Usage) {
                case "Autoproperty":                return $"{new string(' ',indent)}{Access} {GetPropType()} {Name} {po+" get; "+(HasSet ? "set; " : "")+pc}";
                case "Field":                       return $"{new string(' ',indent)}{Access} {GetPropType()} {Name};";
                case "Encapsulated field (simple)": return $"{new string(' ',indent)}{Access} {GetPropType()} {Name} {po+" "+(HasGet ? $"get => _{Name}; " : "")+(HasSet ? $"set => _{Name} = value; " : "")+pc}\n{new string(' ',indent)}private {GetPropType()} _{Name};";
                case "Encapsulated field (full)":   return $"{new string(' ',indent)}{Access} {GetPropType()} {Name} {po+" "+(HasGet ? $"get {po} return _{Name}; {pc} " : "")+(HasSet ? $"set {po} _{Name} = value; {pc} " : "")+pc}\n{new string(' ',indent)}private {GetPropType()} _{Name};";
                default:                            return "";
            }
        }
    }
}
