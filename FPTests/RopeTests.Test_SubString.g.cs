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
        public void Test_SubString01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_SubString("\u0010", 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            this.Test_SubString("\u0002", 0, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString17() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true)
                .At(6, "length1", (object)100);
            this.Test_SubString
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                63, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString20() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true);
            this.Test_SubString
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString21() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true);
            this.Test_SubString
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString22() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94);
            this.Test_SubString(new string('\u0001', 100), 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString23() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100);
            this.Test_SubString(new string('\u0001', 100), 64, 17);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString24() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94);
            this.Test_SubString(new string('\u4000', 100), 0, 100);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString25() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)100);
            this.Test_SubString(new string('\u0001', 100), 32, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString26() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(3, "goDeeper", (object)true);
            this.Test_SubString
                ("\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString27() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94);
            this.Test_SubString(new string('\u2000', 100), 72, 28);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString28() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94);
            this.Test_SubString(new string('\u0001', 100), 64, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString29() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)69);
            this.Test_SubString(new string('\u0001', 100), 68, 18);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString30() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)94);
            this.Test_SubString(new string('@', 100), 93, 7);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString31() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)6);
            this.Test_SubString(new string('\u0200', 100), 0, 25);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString33() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)93);
            this.Test_SubString(new string('@', 100), 96, 1);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString34() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)82)
                .At(4, "goDeeper", (object)true)
                .At(6, "goDeeper", (object)true)
                .At(8, "goDeeper", (object)true)
                .At(9, "length1", (object)11)
                .At(10, "goDeeper", (object)true)
                .At(12, "goDeeper", (object)true)
                .At(14, "goDeeper", (object)true)
                .At(16, "goDeeper", (object)true)
                .At(18, "goDeeper", (object)true)
                .At(20, "goDeeper", (object)true)
                .At(22, "goDeeper", (object)true)
                .At(24, "goDeeper", (object)true);
            this.Test_SubString(new string('\u0001', 100), 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString35() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)6)
                .At(4, "goDeeper", (object)true)
                .At(6, "goDeeper", (object)true)
                .At(8, "goDeeper", (object)true)
                .At(9, "length1", (object)6)
                .At(10, "goDeeper", (object)true)
                .At(12, "goDeeper", (object)true)
                .At(14, "goDeeper", (object)true)
                .At(16, "goDeeper", (object)true)
                .At(18, "goDeeper", (object)true)
                .At(20, "goDeeper", (object)true)
                .At(22, "goDeeper", (object)true)
                .At(24, "goDeeper", (object)true);
            this.Test_SubString(new string('\u0004', 100), 0, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString36() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)83)
                .At(4, "goDeeper", (object)true)
                .At(6, "goDeeper", (object)true)
                .At(8, "goDeeper", (object)true)
                .At(9, "length1", (object)10)
                .At(10, "goDeeper", (object)true)
                .At(12, "goDeeper", (object)true)
                .At(14, "goDeeper", (object)true)
                .At(16, "goDeeper", (object)true)
                .At(18, "goDeeper", (object)true)
                .At(20, "goDeeper", (object)true)
                .At(22, "goDeeper", (object)true)
                .At(24, "goDeeper", (object)true);
            this.Test_SubString(new string('\u0400', 100), 0, 100);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_SubString37() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)70);
            this.Test_SubString(new string(' ', 100), 24, 63);
        }

    }
}
