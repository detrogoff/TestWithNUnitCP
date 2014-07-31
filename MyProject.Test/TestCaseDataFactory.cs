using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace TestedProject.Test
{
    public sealed class TestCaseDataFactory<T>
    {
        public TestCaseData Get(T data, [CallerMemberName] string memberName = "noName")
        {
            return new TestCaseData(data).SetName(memberName);
        }
    }
}