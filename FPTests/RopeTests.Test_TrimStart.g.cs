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
        public void Test_TrimStart01() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimStart("\u3000", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart02() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[1];
            this.Test_TrimStart("\u0001", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart03() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimStart("\u3000\u3000", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart15() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            char[] cs = new char[0];
            this.Test_TrimStart("\0\u0080", cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart17() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)114);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u8000\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        public void Test_TrimStart18() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1);
            char[] cs = new char[126];
            cs[0] = '\u0001';
            cs[1] = '\u0001';
            cs[2] = '\u0001';
            cs[3] = '\u0001';
            cs[4] = '\u0001';
            cs[5] = '\u0001';
            cs[6] = '\u0001';
            cs[7] = '\u0001';
            cs[8] = '\u0001';
            cs[9] = '\u0001';
            cs[10] = '\u0001';
            cs[11] = '\u0001';
            cs[12] = '\u0001';
            cs[13] = '\u0001';
            cs[14] = '\u0001';
            cs[15] = '\u0001';
            cs[16] = '\u0001';
            cs[17] = '\u0001';
            cs[18] = '\u0001';
            cs[19] = '\u0001';
            cs[20] = '\u0001';
            cs[21] = '\u0001';
            cs[22] = '\u0001';
            cs[23] = '\u0001';
            cs[24] = '\u0001';
            cs[25] = '\u0001';
            cs[26] = '\u0004';
            cs[27] = '\u0001';
            cs[28] = '\u0001';
            cs[29] = '\u0001';
            cs[30] = '\u0001';
            cs[31] = '\u0001';
            cs[32] = '\u0001';
            cs[33] = '\u0001';
            cs[34] = '\u0001';
            cs[35] = '\u0001';
            cs[36] = '\u0001';
            cs[37] = '\u0001';
            cs[38] = '\u0001';
            cs[39] = '\u0001';
            cs[40] = '\u0001';
            cs[41] = '\u0001';
            cs[42] = '\u0001';
            cs[43] = '\u0001';
            cs[44] = '\u0001';
            cs[45] = '\u0001';
            cs[46] = '\u0001';
            cs[47] = '\u0001';
            cs[48] = '\u0001';
            cs[49] = '\u0001';
            cs[50] = '\u0001';
            cs[51] = '\u0001';
            cs[52] = '\u0001';
            cs[53] = '\u0001';
            cs[54] = '\u0001';
            cs[55] = '\u1000';
            cs[56] = '\u0010';
            cs[57] = '\u1000';
            cs[58] = '\u0080';
            cs[59] = '\u2000';
            cs[60] = '@';
            cs[61] = '\u0001';
            cs[62] = '\u0001';
            cs[63] = '\u0001';
            cs[64] = '\u2000';
            cs[65] = '@';
            cs[66] = '\u0002';
            cs[67] = '\u0001';
            cs[68] = '\u0001';
            cs[69] = '\u0001';
            cs[70] = '\u0001';
            cs[71] = '\u0001';
            cs[72] = '\u0001';
            cs[73] = '\u0001';
            cs[74] = '\b';
            cs[75] = '\u0400';
            cs[76] = '\u0001';
            cs[77] = '\u0001';
            cs[78] = '\u0001';
            cs[79] = '\u0001';
            cs[80] = '\u0001';
            cs[81] = '\u0001';
            cs[82] = '\u0001';
            cs[83] = '\u0001';
            cs[84] = '\u0001';
            cs[85] = '\u0002';
            cs[86] = '\u0001';
            cs[87] = '\u0001';
            cs[88] = '\u0001';
            cs[89] = '\u0002';
            cs[90] = '\u0001';
            cs[91] = '\u0001';
            cs[92] = '\u0001';
            cs[93] = '\u0001';
            cs[94] = '\u0001';
            cs[95] = '\u0001';
            cs[96] = '\u0001';
            cs[97] = '\u0001';
            cs[98] = '\u0001';
            cs[99] = '\u0001';
            cs[100] = '\u0001';
            cs[101] = '\u0001';
            cs[102] = '\u0001';
            cs[103] = '\u0001';
            cs[104] = '\u0001';
            cs[105] = '\u0001';
            cs[106] = '\u0001';
            cs[107] = '\u0001';
            cs[108] = '\u0001';
            cs[109] = '\u0001';
            cs[110] = '\u0001';
            cs[111] = '\u0001';
            cs[112] = '\u0001';
            cs[113] = '\u0100';
            cs[114] = '\u4000';
            cs[115] = '\u0010';
            cs[116] = '\u0004';
            cs[117] = '\u0001';
            cs[118] = '\u0001';
            cs[119] = '\u0001';
            cs[120] = '\u0001';
            cs[121] = '\u0001';
            cs[122] = '\u8000';
            cs[123] = '\u0100';
            cs[124] = '\u0100';
            cs[125] = '\u0100';
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0010\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart19() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u1000\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        public void Test_TrimStart20() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1);
            char[] cs = new char[126];
            cs[2] = 'H';
            cs[4] = 'D';
            cs[89] = 'A';
            cs[102] = 'A';
            cs[107] = 'A';
            cs[110] = 'A';
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0@\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart21() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)2);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\t\0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
                cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart22() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)1);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\t\0\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
                cs);
        }

        [Fact]
        public void Test_TrimStart23() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true);
            char[] cs = new char[0];
            this.Test_TrimStart(new string('\ufeff', 100), cs);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_TrimStart24() {
            IPexChoiceRecorder choices = PexChoose.NewTest();
            choices.DefaultSession
                .At(0, "requireLarge", (object)true)
                .At(1, "goDeeper", (object)true)
                .At(2, "length1", (object)114)
                .At(3, "goDeeper", (object)true)
                .At(5, "goDeeper", (object)true);
            char[] cs = new char[0];
            this.Test_TrimStart
                ("\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0",
                cs);
        }

    }
}
