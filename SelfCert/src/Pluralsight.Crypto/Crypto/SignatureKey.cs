﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.Crypto
{
    public class SignatureKey : CryptKey
    {
        internal SignatureKey(CryptContext ctx, IntPtr handle) : base(ctx, handle) { }
        
        public override KeyType Type
        {
            get { return KeyType.Signature; }
        }
    }
}
