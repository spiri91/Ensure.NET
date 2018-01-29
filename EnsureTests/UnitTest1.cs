using System;

namespace EnsureTests
{
    using NUnit.Framework;
    using Ensure.NET;

    namespace Tests
    {
        [TestFixture]
        public class Tests
        {
            private int foo = 1;
            private int goo = 1;
            private int boo = 2;

            [SetUp]
            public void SetDefaultValue()
            {
                foo = 1;
                goo = 1;
                boo = 2;
            }

            [TestCase]
            public void Should_Throw_Error_On_Bool_Condition()
            {
                Assert.Throws<Exception>(() => Ensure.Condition(foo == boo, new Exception()));
            }

            [TestCase]
            public void Should_Throw_Error_On_Lambda_Condition()
            {
                Assert.Throws<Exception>(() => Ensure.Condition(() => foo == boo, new Exception()));
            }

            [TestCase]
            public void Should_Change_Value_Of_Object_On_Bool_Condition()
            {
                Ensure.Condition<int>(foo == boo, ref foo, boo);
                Assert.True(foo == boo);
            }

            [TestCase]
            public void Should_Change_Value_Of_Object_On_Lambda_Condition()
            {
                Ensure.Condition(() => foo == boo, ref foo, boo);
                Assert.True(foo == boo);
            }

            [TestCase]
            public void Should_Not_Throw_Error_On_Bool_Condition()
            {
                Assert.DoesNotThrow(() => Ensure.Condition(foo == goo, new Exception()));
            }

            [TestCase]
            public void Should_Not_Throw_Error_On_Lambda_Condition()
            {
                Ensure.Condition(() => foo == goo, new Exception());
            }

            [TestCase]
            public void Should_Not_Change_Value_Of_Object_On_Bool_Condition()
            {
                Ensure.Condition(foo == goo, ref foo, boo);
                Assert.False(foo == boo);
            }

            [TestCase]
            public void Should_Not_Change_Value_Of_Object_On_Lambda_Condition()
            {
                Ensure.Condition(() => foo == goo, ref foo, boo);
                Assert.False(foo == boo);
            }
        }
    }
}
