using GOST.Ciphers;
using GOST.Interfaces;
using GOST.SBlocks;
using GOST.Types;
using System;
using System.Collections.Generic;

namespace GOST
{
    /// <summary>
    /// GOST stream cipher.
    /// </summary>
    public class GOSTManaged : IManaged, IDisposable
    {
        private ISBlocks sBlock;

        private SBlockTypes sBlockType;

        private byte[] key;

        private byte[] message;

        private byte[] iv;

        private List<uint> subKeys;

        private bool released;

        private byte[] Key
        {
            get { return key; }
            set
            {
                if (value.Length != 32)
                {
                    throw new ArgumentException("Wrong key. Try to use 256 bit key.");
                }
                else if (value.Length == 32)
                {
                    key = value;
                }
            }
        }

        private byte[] Message
        {
            get { return message; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Empty message!");
                }
                else
                {
                    message = value;
                }
            }
        }

        private byte[] IV
        {
            get { return iv; }
            set
            {
                if (value.Length != 8)
                {
                    throw new ArgumentException("Wrong IV. Try to use 64 bit IV.");
                }
                else if (value.Length == 8)
                {
                    iv = value;
                }
            }
        }

        public GOSTManaged()
        {
            released = false;
            subKeys = new List<uint>();
        }

        private void SetSBlock()
        {
            switch (sBlockType)
            {
                case SBlockTypes.CryptoProA:
                    sBlock = new CryptoProABlock();
                    break;
                case SBlockTypes.CryptoProB:
                    sBlock = new CryptoProBBlock();
                    break;
                case SBlockTypes.CryptoProC:
                    sBlock = new CryptoProCBlock();
                    break;
                case SBlockTypes.CryptoProD:
                    sBlock = new CryptoProDBlock();
                    break;
                case SBlockTypes.GOST:
                    sBlock = new GOSTBlock();
                    break;
                case SBlockTypes.TC26:
                    sBlock = new TC26Block();
                    break;
                default:
                    sBlock = null;
                    throw new Exception("Something wrong...");
            }
        }

        private void GetSubKeys()
        {
            byte[] res = new byte[4];
            // Stage 1.
            int j = 0;
            for (int i = 0; i != key.Length; i++)
            {
                res[j] = key[i];

                if (j % 3 == 0 && j != 0)
                {
                    subKeys.Add(BitConverter.ToUInt32(res, 0));
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
            // Stage 2.
            for (int i = 0; i != 16; i++)
            {
                subKeys.Add(subKeys[i]);
            }
            // Stage 3.
            for (int i = 7; i != -1; i--)
            {
                subKeys.Add(subKeys[i]);
            }
        }

        public byte[] XOREncode(byte[] key, byte[] iv, byte[] message, SBlockTypes sBlockType = SBlockTypes.GOST)
        {
            Key = key;
            Message = message;
            IV = iv;

            this.sBlockType = sBlockType;
            SetSBlock();

            byte[] encode = XORProcess();
            return encode;
        }

        public byte[] XORDecode(byte[] key, byte[] iv, byte[] message, SBlockTypes sBlockType = SBlockTypes.GOST)
        {
            return XOREncode(key, iv, message, sBlockType); ;
        }

        private byte[] XORProcess()
        {
            var cipher = new XORCipher(sBlock);

            GetSubKeys();

            byte[] res = new byte[message.Length];
            int index = 0;

            cipher.SetIV(iv, subKeys);

            foreach (var chunk in ReadByChunk())
            {
                Array.Copy(cipher.EncodeProcess(chunk, subKeys), 0, res, index, chunk.Length);
                index += chunk.Length;
            }
            return res;
        }        

        private IEnumerable<byte[]> ReadByChunk()
        {
            for (int i = 0; i < message.Length; i += 8)
            {
                var min = Math.Min(8, message.Length - i);

                byte[] res = new byte[min];

                Array.Copy(message, i, res, 0, min);

                yield return res;
            }
        }

        public void Dispose()
        {
            if (!released)
            {
                released = true;

                sBlock = null;
                message = null;
                key = null;
                iv = null;
                subKeys.Clear();
            }
        }
    }
}