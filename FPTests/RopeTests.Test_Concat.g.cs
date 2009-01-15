// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework;
using Xunit;

namespace FPTests
{
    public partial class RopeTests {
        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_Concat("\u0004", "\u8000");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_Concat("\u0002", "\u0010\u0010\u0010\u0010\u0010\u0010");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat12() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(2, "goDeeper", (object)true);
            this.Test_Concat("\u0100", "\u0100\u0100\u0100\u0100\u0100\u0100");
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat13() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(2, "requireLarge", (object)true);
            this.Test_Concat(new string('\u0001', 126), new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat14() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(3, "goDeeper", (object)true);
            this.Test_Concat(new string('\u0001', 126), new string('\u0001', 126));
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Concat15() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(2, "requireLarge", (object)true)
                .At(3, "goDeeper", (object)true)
                .At(4, "length1", (object)93);
            this.Test_Concat(new string('@', 100), new string('\u0002', 100));
        }

    }
}
