// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Murmur;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    /// <summary>
    /// AccelByte Bloom Filter based on iam-python-sdk
    /// (https://github.com/AccelByte/iam-python-sdk/blob/2829d30ab87072ed887735f661b346750ebfab03/iam_python_sdk/bloom.py)
    /// 
    /// Using Murmur Hash 128bit x64
    /// </summary>
    public class BloomFilter
    {
        private BitArray _Bits;

        private int _K;

        private ulong _M;

        public BloomFilter(List<ulong> bits, int k, ulong m)
        {
            _K = k;
            _M = m;

            using (MemoryStream ms = new MemoryStream())
            {
                BinaryWriter bWriter = new BinaryWriter(ms);
                foreach (ulong item in bits)
                    bWriter.Write(item);
                _Bits = new BitArray(ms.ToArray());
            }
        }

        public BloomFilter(BloomFilterJSON revocationList)
        {
            _M = (ulong)revocationList.M!.Value;
            _K = (int)revocationList.K!.Value;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryWriter bWriter = new BinaryWriter(ms);
                foreach (ulong item in revocationList.Bits!)
                    bWriter.Write(item);
                _Bits = new BitArray(ms.ToArray());
            }
        }

        public ulong[] GetIndexes(string key)
        {
            HashAlgorithm mm3 = MurmurHash.Create128(0, true, AlgorithmPreference.X64);
            byte[] keyHash = mm3.ComputeHash(Encoding.UTF8.GetBytes(key));

            ulong h1 = BitConverter.ToUInt64(keyHash, 0);
            ulong h2 = BitConverter.ToUInt64(keyHash, 8);

            ulong combined = h1 & 0xffffffffffffffff;

            ulong[] indexes = new ulong[_K];
            for (int i = 0; i < _K; i++)
            {
                indexes[i] = (combined & 0x7fffffffffffffff) % _M;
                combined += h2;
            }

            return indexes;
        }

        public bool MightContain(string key)
        {
            ulong[] indexes = GetIndexes(key);
            foreach (ulong i in indexes)
            {
                if (!_Bits.Get((int)i))
                    return false;
            }

            return true;
        }
    }
}
