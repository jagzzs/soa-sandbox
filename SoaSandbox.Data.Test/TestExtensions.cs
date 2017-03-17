using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoaSandbox.Data.Test
{
    public static class TestExtensions
    {
        public static T GetPrivateInstance<T>(this Object instance, String fieldName)
            where T : class
        {
            FieldInfo[] fields = instance.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo field = fields.First(x => x.Name == fieldName);
            Object rawValue = field.GetValue(instance);

            return rawValue == null ? null : (T)rawValue;
        }
    }
}
