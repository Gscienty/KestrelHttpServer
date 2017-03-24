// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Xunit.Sdk;

namespace Xunit
{
    public static class AssertEx
    {
        public static void Equal(byte[] expected, Span<byte> actual)
        {
            if (expected.Length != actual.Length)
            {
                throw new XunitException($"Expected length to be {expected.Length} but was {actual.Length}");
            }

            for (var i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    throw new XunitException($@"Expected byte at index {i} to be '\x{expected[i]}' but was '\x{actual[i]}'");
                }
            }
        }
    }
}
