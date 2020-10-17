using System.Linq;

namespace GetAllMethodsName
{
    public class GetAllMethodsName
    {
        public static string[] GetMethodNames(object TestObject)
             => TestObject == null
                ? new string[0]
                : TestObject.GetType().GetMethods().Select(m => m.Name).ToArray();
    }
}
