﻿using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using skycoin;
namespace LibskycoinNetTest {
    [TestFixture ()]
    public class check_cipher_encrypt_scrypt_chacha20poly1305 {

        private String cutString (String str, String ini, String end) {
            int endIndex = str.LastIndexOf (end);
            String outs = str.Substring (0, endIndex);
            int offset = ini.Length;
            int initIndex = outs.LastIndexOf (ini) + offset;
            int cut = outs.Length - initIndex;
            outs = outs.Substring (initIndex, cut);
            return outs;
        }

        [Test]
        public void TestScryptChacha20poly1305Encrypt () {
            for (int i = 1; i < 20; i++) {
                var name = "N=1<<" + i.ToString () + "(" + (1 << i).ToString () + ")" + ", R=8, p=1, keyLen=32";
                var crypto = new encrypt__ScryptChacha20poly1305 ();
                crypto.N = Convert.ToInt64 (1 << i);
                crypto.R = 8;
                crypto.P = 1;
                crypto.KeyLen = 32;
                var encData = new GoSlice ();
                var plain = new GoSlice ();
                var passwd = new GoSlice ();
                var plaintext = new _GoString_ ();
                var passwdText = new _GoString_ ();
                plaintext.p = "plaintext";
                plain.convertString (plaintext);
                passwdText.p = "password";
                passwd.convertString (passwdText);
                var err = skycoin.skycoin.SKY_encrypt_ScryptChacha20poly1305_Encrypt (crypto, plain, passwd, encData);
                Assert.AreEqual (err, skycoin.skycoin.SKY_OK, name);
                Assert.AreEqual (encData.len > 2, true);
                var str = encData.getString ();
                Console.WriteLine (name);

                if (str.n <= 188) {
                    var base64 = Convert.FromBase64String (str.p);
                    var meta = System.Text.Encoding.UTF8.GetString (base64);
                    var n = skycoin.skycoin.new_Gointp ();
                    var r = skycoin.skycoin.new_Gointp ();
                    var p = skycoin.skycoin.new_Gointp ();
                    var keyLen = skycoin.skycoin.new_Gointp ();
                    meta = cutString (meta, "{", "}");
                    skycoin.skycoin.parseJsonMetaData (meta, n, r, p, keyLen);
                    Assert.AreEqual (1 << i, skycoin.skycoin.Gointp_value (n), name);
                    Assert.AreEqual (8, skycoin.skycoin.Gointp_value (r), name);
                    Assert.AreEqual (1, skycoin.skycoin.Gointp_value (p), name);
                    Assert.AreEqual (32, skycoin.skycoin.Gointp_value (keyLen), name);
                }
            }
        }

        struct StructTest {
            public string name;
            public GoSlice data;
            public GoSlice encData;
            public GoSlice encPwd;
            public GoSlice decPwd;
            public long err;
        }

        [Test ()]
        public void TestScryptChacha20poly1305Decrypt () {

            var casett = new StructTest ();

            // StructTest.data
            var pData = new GoSlice ();
            var pDataText = new _GoString_ ();
            pDataText.p = "plaintext";
            pData.convertString (pDataText);

            // StructTest.encData
            var pencData = new GoSlice ();
            var pencDataText = new _GoString_ ();
            pencDataText.p = "dQB7Im4iOjUyNDI4OCwiciI6OCwicCI6MSwia2V5TGVuIjozMiwic2FsdCI6ImpiejUrSFNjTFFLWkI5T0tYblNNRmt2WDBPY3JxVGZ0ZFpDNm9KUFpaeHc9Iiwibm9uY2UiOiJLTlhOQmRQa1ZUWHZYNHdoIn3PQFmOot0ETxTuv//skTG7Q57UVamGCgG5";
            pencData.convertString (pDataText);

            // StructTest.encPwd
            var pencPwd = new GoSlice ();
            var pencPwdText = new _GoString_ ();
            pencPwdText.p = "pwd";
            pencPwd.convertString (pencPwdText);

            // StructTest.decPwd
            var pdecPwd = new GoSlice ();
            var pdecPwdText = new _GoString_ ();
            pdecPwdText.p = "pwd";
            pdecPwd.convertString (pdecPwdText);
            casett.data = pData;
            casett.decPwd = pdecPwd;
            casett.encData = pencData;
            casett.encPwd = pencPwd;
            casett.err = skycoin.skycoin.SKY_OK;
            StructTest[] tt = { casett };

            // for (int i = 0; i < tt.Length; i++) {
            //     var tc = tt[i];
            //     var name = "N=1<<19 r=8 p=1 keyLen=32 " + tc.name;
            //     var crypto = new encrypt__ScryptChacha20poly1305 ();
            //     var data = new GoSlice ();
            //     var err = skycoin.skycoin.SKY_encrypt_ScryptChacha20poly1305_Decrypt (crypto, tc.encData, tc.decPwd, data);
            //     Assert.AreEqual (err, tc.err, name);

            // }
        }
    }
}