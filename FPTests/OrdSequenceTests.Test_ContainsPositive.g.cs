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
    public partial class OrdSequenceTests {
        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive01() {
            int[] ints = new int[1];
            this.Test_ContainsPositive<int>(ints, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive02() {
            int[] ints = new int[2];
            ints[0] = 4097;
            ints[1] = 2048;
            this.Test_ContainsPositive<int>(ints, 4097);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive03() {
            int[] ints = new int[12];
            ints[0] = 2147483521;
            ints[1] = -2147479553;
            ints[2] = -2147483633;
            ints[3] = 2147483516;
            ints[4] = 2147483514;
            ints[5] = -2147483647;
            ints[6] = int.MinValue;
            ints[7] = -1073742079;
            ints[8] = -1073742079;
            ints[9] = -1073742080;
            ints[10] = -1073741825;
            ints[11] = -1073741825;
            this.Test_ContainsPositive<int>(ints, 2147483521);
        }

        [Fact]
        public void Test_ContainsPositive04() {
            int[] ints = new int[30];
            ints[0] = 1082263552;
            ints[1] = -2140717056;
            ints[2] = -2145587206;
            ints[3] = 1073801214;
            ints[4] = 1013771280;
            ints[5] = -202379464;
            ints[6] = -2077540328;
            ints[7] = -611323936;
            ints[8] = -2140717056;
            ints[9] = -1013214;
            ints[10] = -2077499391;
            ints[11] = -1970073831;
            ints[12] = -1970073831;
            ints[13] = -1970073831;
            ints[14] = -1970073831;
            ints[15] = -1970073831;
            ints[16] = -1970073831;
            ints[17] = -1970073831;
            ints[18] = -1970073831;
            ints[19] = -1970073831;
            ints[20] = -1970073831;
            ints[21] = -1970073831;
            ints[22] = -1970073831;
            ints[23] = -1970073831;
            ints[24] = -1970073831;
            ints[25] = -1970073831;
            ints[26] = -1970073831;
            ints[27] = -1970073831;
            ints[28] = -1970073831;
            ints[29] = -1970073831;
            this.Test_ContainsPositive<int>(ints, 16);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive05() {
            int[] ints = new int[6];
            ints[0] = 1082196736;
            ints[1] = -2147090432;
            ints[2] = -2147417346;
            ints[3] = -2147422210;
            ints[4] = -1129670080;
            ints[5] = -1129670080;
            this.Test_ContainsPositive<int>(ints, 1082196736);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive06() {
            int[] ints = new int[3];
            ints[0] = 2147483266;
            ints[1] = -2147483216;
            ints[2] = 2147483246;
            this.Test_ContainsPositive<int>(ints, 2147483266);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive07() {
            int[] ints = new int[15];
            ints[0] = 1082327040;
            ints[1] = -2113872768;
            ints[2] = -2127822722;
            ints[3] = 33833216;
            ints[4] = 1073635424;
            ints[5] = -2113641343;
            ints[7] = -2097139581;
            ints[8] = -2097139581;
            ints[9] = -2097139581;
            ints[10] = 33824771;
            ints[11] = -1074257026;
            ints[12] = -793473;
            ints[13] = -1082121224;
            ints[14] = -8380192;
            this.Test_ContainsPositive<int>(ints, 33824771);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive08() {
            int[] ints = new int[2];
            ints[0] = 1;
            this.Test_ContainsPositive<int>(ints, 0);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive09() {
            int[] ints = new int[6];
            ints[0] = 92405761;
            ints[1] = -452591616;
            ints[2] = -1753257666;
            ints[3] = -452591616;
            ints[4] = -452591616;
            ints[5] = -452591616;
            this.Test_ContainsPositive<int>(ints, 92405761);
        }

        [Fact]
        public void Test_ContainsPositive10() {
            int[] ints = new int[31];
            ints[0] = 397312;
            ints[1] = -2139207491;
            ints[2] = -2143697026;
            ints[3] = -1880225851;
            ints[4] = 233224;
            ints[5] = -1492052736;
            ints[6] = -2147473666;
            ints[7] = -267263489;
            ints[8] = -1609572296;
            ints[9] = -1492052736;
            ints[10] = -1594827457;
            ints[11] = -1492052736;
            ints[12] = -1492052736;
            ints[13] = -1492052736;
            ints[14] = -1492052736;
            ints[15] = -1492052736;
            ints[16] = -1492052736;
            ints[17] = -1492052736;
            ints[18] = -1492052736;
            ints[19] = -1492052736;
            ints[20] = -1492052736;
            ints[21] = -1492052736;
            ints[22] = -1492052736;
            ints[23] = -1492052736;
            ints[24] = -1492052736;
            ints[25] = -1492052736;
            ints[26] = -1492052736;
            ints[27] = -1492052736;
            ints[28] = -1492052736;
            ints[29] = -1492052736;
            ints[30] = -1492052736;
            this.Test_ContainsPositive<int>(ints, 16);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive11() {
            int[] ints = new int[2];
            ints[0] = -2146958209;
            ints[1] = 2146435968;
            this.Test_ContainsPositive<int>(ints, -2146958209);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive12() {
            int[] ints = new int[19];
            ints[0] = 1753219080;
            ints[1] = -1870135298;
            ints[2] = -1881333754;
            ints[3] = 1738333139;
            ints[4] = 1585121260;
            ints[5] = -1660421119;
            ints[6] = -1861747762;
            ints[7] = -1755838458;
            ints[8] = -1795161601;
            ints[9] = -1879048191;
            ints[10] = -1646788608;
            ints[11] = -1646788608;
            ints[12] = -1646788608;
            ints[13] = -1646788608;
            ints[14] = -1727570980;
            ints[15] = -1727570980;
            ints[16] = -1646788607;
            ints[17] = -1727570980;
            ints[18] = -1727570980;
            this.Test_ContainsPositive<int>(ints, -1646788607);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive13() {
            int[] ints = new int[19];
            ints[0] = 1083179008;
            ints[1] = -1988097024;
            ints[2] = -2013300642;
            ints[3] = 1073741824;
            ints[4] = 554695808;
            ints[5] = -1603374977;
            ints[6] = -1988022912;
            ints[7] = -167834624;
            ints[8] = -259722880;
            ints[9] = -268112896;
            ints[10] = -1342177248;
            ints[11] = -1342177248;
            ints[12] = -1342177248;
            ints[13] = -1342177248;
            ints[14] = -1744830465;
            ints[15] = -1610482722;
            ints[16] = -1646788607;
            ints[17] = -1727570980;
            ints[18] = -1727570980;
            this.Test_ContainsPositive<int>(ints, -1646788607);
        }

        [Fact]
        [PexGeneratedBy(typeof(OrdSequenceTests))]
        public void Test_ContainsPositive14() {
            int[] ints = new int[15];
            ints[0] = 1073760841;
            ints[1] = -34216265;
            ints[2] = -1107959808;
            ints[3] = 8;
            ints[4] = -603905872;
            ints[5] = 1073741825;
            ints[6] = 1073741824;
            this.Test_ContainsPositive<int>(ints, 8);
        }

    }
}
