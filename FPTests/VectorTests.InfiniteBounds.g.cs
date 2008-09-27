using System;
using Xunit;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework.Exceptions;

namespace FPTests
{
    public partial class VectorTests {

        [Fact]
        [PexGeneratedBy(typeof(VectorTests))]
        public void InfiniteBounds01() {
            this.InfiniteBounds(0);
        }

        [Fact]
        [PexGeneratedBy(typeof(VectorTests))]
        public void InfiniteBounds02() {
            this.InfiniteBounds(1);
        }

        [Fact]
        [PexGeneratedBy(typeof(VectorTests))]
        public void InfiniteBounds03() {
            this.InfiniteBounds(1073741824);
        }

    }
}
