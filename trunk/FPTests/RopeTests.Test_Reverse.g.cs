// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using Xunit;
using Microsoft.Pex.Framework.Generated;

namespace FPTests
{
    public partial class RopeTests {

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse05() {
            string[] ss = new string[2];
            ss[0] = "\0";
            ss[1] = " ";
            this.Test_Reverse(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse02() {
            string[] ss = new string[2];
            ss[0] = new string('\u4000', 24);
            ss[1] = "";
            this.Test_Reverse(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse06() {
            string[] ss = new string[2];
            ss[0] = new string('\u8000', 15);
            ss[1] = "\0\0";
            this.Test_Reverse(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse07() {
            string[] ss = new string[2];
            ss[0] = new string('\0', 20);
            ss[1] = new string('\u8000', 17);
            this.Test_Reverse(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse11() {
            string[] ss = new string[3];
            ss[0] = "\0";
            ss[1] = "\u4000\u4000";
            ss[2] = "\0\0";
            this.Test_Reverse(ss);
        }

        [Fact]
        [PexGeneratedBy(typeof(RopeTests))]
        public void Test_Reverse12() {
            string[] ss = new string[3];
            ss[0] = new string('\u8000', 26);
            ss[1] = "";
            ss[2] = "";
            this.Test_Reverse(ss);
        }

    }
}
