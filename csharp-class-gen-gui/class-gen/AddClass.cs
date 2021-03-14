using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_gen {
    public class AddClass {
        public bool SeparateFile { get; set; }
        public string ClassNamespace { get; set; }
        public string ClassName { get; set; }
        public bool InclConstr { get; set; }
        public bool ConstrAuto { get; set; }
        public List<string> ClassNamespaces { get; set; }
        public List<ClassFIeldProperty> FieldsProps { get; set; }
        public List<ClassMethod> Methods { get; set; }
        public AddClass() {
            SeparateFile = false;
            ClassNamespace = "";
            ClassName = "Class1";
            InclConstr = true;
            ConstrAuto = true;
            ClassNamespaces = new List<string> { "System" };
            FieldsProps = new List<ClassFIeldProperty>();
            Methods = new List<ClassMethod>();
        }
        public void AddFieldProperty(string access, string usage, bool hasget, bool hasset, string typemod, string type, string name) => FieldsProps.Add(new ClassFIeldProperty(access, usage, hasget, hasset, typemod, type, name));
        public void AddMethod(bool isasync, string access, string typemod, string type, string name) => Methods.Add(new ClassMethod(isasync, access, typemod, type, name));
        public void Remove(int index, bool ismethod) {
            if(ismethod) {
                Methods.RemoveAt(index-FieldsProps.Count());
                return;
            }
            else if(FieldsProps.Count()<1 || index<0) return;
            FieldsProps.RemoveAt(index);
        }
        public void RemoveAll() {
            FieldsProps.Clear();
            Methods.Clear();
        }
        public string GetConstr(int indent) {
            string po = "{";
            string pc = "}";
            string cparams = string.Join(", ",FieldsProps.Where(s => s.HasSet).Select(s => s.GetPropType()+" p_"+s.Name));
            string content = string.Join("\n",FieldsProps.Where(s => s.HasSet).Select(s => $"{new string(' ',indent+4)+s.Name} = p_{s.Name};"));
            return $"{new string(' ',indent)}public {ClassName}({(ConstrAuto ? cparams : "")}) {po}\n{(ConstrAuto ? content : new string(' ',indent+4))}\n{new string(' ', indent)}{pc}";
        }
        public bool CheckName(string name, string category) {
            foreach(char ch in name.Trim()) {
                if(!char.IsDigit(ch) && !char.IsLetter(ch) && ch!='_') {
                    return false;
                }
            }
            switch(category) {
                case "item":    return name.Length>0 && !char.IsDigit(name[0]) && FieldsProps.Where(s => s.Name==name).Count()==0;
                case "method":  return name.Length>0 && !char.IsDigit(name[0]) && Methods.Where(s => s.Name==name).Count()==0;
                default:        return name.Length>0 && !char.IsDigit(name[0]);
            }
        }
        public string Export() {
            int indent = SeparateFile ? 4 : 0;
            string exported = SeparateFile ? string.Join("\n", ClassNamespaces.Select(s => $"using {s};"))+"\n" : "";
            exported += SeparateFile ? "namespace "+ClassNamespace+" {\n" : "";
            exported += new string(' ',indent)+"class "+ClassName+" {\n";
            exported += string.Join("",FieldsProps.Select(s => s.GetCode(indent+4)+"\n"));  // fields/properties
            exported += InclConstr ? GetConstr(indent+4)+"\n" : "";                         // constructor
            exported += string.Join("",Methods.Select(s => s.GetCode(indent+4)+"\n"));      // methods
            exported += new string(' ',indent)+"}";
            exported += SeparateFile ? "\n}" : "";
            return exported;
        }
    }
}
