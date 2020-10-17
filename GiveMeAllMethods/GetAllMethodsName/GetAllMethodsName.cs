using System.Linq;
using System.Reflection;

namespace GetAllMethodsName
{
    public class GetAllMethodsName
    {
        public static string[] GetMethodNames(object TestObject)
             => TestObject == null
                ? new string[0]
                : TestObject.GetType().GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).Select(m => m.Name).ToArray();
    }
}
