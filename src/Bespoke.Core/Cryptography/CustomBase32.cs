#region Header Info

// Copyright 2024 Rod Johnson.  All rights reserved

#endregion

using System.Text;

namespace Bespoke.Core.Cryptography;

public static class CustomBase32
{
    private static readonly string _base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

    public static string ToBase32(byte[] input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));

        var sb = new StringBuilder();
        for (var offset = 0; offset < input.Length;)
        {
            byte a, b, c, d, e, f, g, h;
            var numCharsToOutput = GetNextGroup(input, ref offset, out a, out b, out c, out d, out e, out f, out g,
                out h);

            sb.Append(numCharsToOutput >= 1 ? _base32Chars[a] : '=');
            sb.Append(numCharsToOutput >= 2 ? _base32Chars[b] : '=');
            sb.Append(numCharsToOutput >= 3 ? _base32Chars[c] : '=');
            sb.Append(numCharsToOutput >= 4 ? _base32Chars[d] : '=');
            sb.Append(numCharsToOutput >= 5 ? _base32Chars[e] : '=');
            sb.Append(numCharsToOutput >= 6 ? _base32Chars[f] : '=');
            sb.Append(numCharsToOutput >= 7 ? _base32Chars[g] : '=');
            sb.Append(numCharsToOutput >= 8 ? _base32Chars[h] : '=');
        }

        return sb.ToString();
    }
    public static byte[] FromBase32(string input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));

        // Convert input to uppercase and remove padding
        input = input.TrimEnd('=').ToUpperInvariant();
        if (input.Length == 0) return new byte[0];  // Handle empty input

        var output = new byte[input.Length * 5 / 8];  // Calculate output size based on Base32 encoding rules
        int bitIndex = 0;
        int inputIndex = 0;
        int outputIndex = 0;
        int currentByte = 0;

        // Process each character in the Base32 string
        foreach (var ch in input)
        {
            int byteIndex = _base32Chars.IndexOf(ch);
            if (byteIndex < 0) throw new FormatException("Invalid Base32 character encountered.");

            // Shift the current bits into the output byte array
            currentByte = (currentByte << 5) | byteIndex;
            bitIndex += 5;

            // Once we've accumulated 8 bits, store them in the output byte array
            if (bitIndex >= 8)
            {
                output[outputIndex++] = (byte)(currentByte >> (bitIndex - 8));
                bitIndex -= 8;
            }
        }

        // Return the decoded byte array
        return output;
    }


    // returns the number of bytes that were output
    private static int GetNextGroup(byte[] input, ref int offset, out byte a, out byte b, out byte c, out byte d,
        out byte e, out byte f, out byte g, out byte h)
    {
        uint b1, b2, b3, b4, b5;

        int retVal;
        switch (input.Length - offset)
        {
            case 1:
                retVal = 2;
                break;
            case 2:
                retVal = 4;
                break;
            case 3:
                retVal = 5;
                break;
            case 4:
                retVal = 7;
                break;
            default:
                retVal = 8;
                break;
        }

        b1 = offset < input.Length ? input[offset++] : 0U;
        b2 = offset < input.Length ? input[offset++] : 0U;
        b3 = offset < input.Length ? input[offset++] : 0U;
        b4 = offset < input.Length ? input[offset++] : 0U;
        b5 = offset < input.Length ? input[offset++] : 0U;

        a = (byte) (b1 >> 3);
        b = (byte) (((b1 & 0x07) << 2) | (b2 >> 6));
        c = (byte) ((b2 >> 1) & 0x1f);
        d = (byte) (((b2 & 0x01) << 4) | (b3 >> 4));
        e = (byte) (((b3 & 0x0f) << 1) | (b4 >> 7));
        f = (byte) ((b4 >> 2) & 0x1f);
        g = (byte) (((b4 & 0x3) << 3) | (b5 >> 5));
        h = (byte) (b5 & 0x1f);

        return retVal;
    }
}