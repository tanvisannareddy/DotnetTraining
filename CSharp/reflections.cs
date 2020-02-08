using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflectionexample
{
class Program
{
public static int s;
public int w;
protected bool w1;
private string w0;
public void m1() { }
public int m2() { return 0; }
static void Main(string[] args)
{
Type t = typeof(Program);
MethodInfo[] mi = t.GetMethods();
foreach(MethodInfo m in mi)
{
Console.WriteLine("methodname{0} and return type:{1}" ,m.Name,m.ReturnType);
}
FieldInfo[] fi = t.GetFields(BindingFlags.Public|BindingFlags.Instance|BindingFlags.NonPublic|BindingFlags.Static);
foreach(FieldInfo f in fi)
{
Console.WriteLine("fieldname:{0} and datetype:{ 1}", f.Name, f.FieldType);
}
}
}
}
