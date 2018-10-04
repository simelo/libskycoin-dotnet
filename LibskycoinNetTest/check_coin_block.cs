using System;
using NUnit.Framework;
using skycoin;
using utils;
namespace LibskycoinNetTest {
    [TestFixture ()]
    public class check_coin_block {

        utils.transutils transutils = new utils.transutils ();
        public SWIGTYPE_p_Transactions__Handle makeTestTransactions () {
            var txns = skycoin.skycoin.new_Transactions__Handlep ();
            var err = skycoin.skycoin.SKY_coin_Create_Transactions (txns);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var txn = transutils.makeEmptyTransaction ();
            err = skycoin.skycoin.SKY_coin_Transactions_Add (txns, txn);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            return txns;
        }

        [Test]
        public void TestNewBlock () {
            var txns = makeTestTransactions ();
            var block = skycoin.skycoin.new_Block__HandlePtr ();
            var err = skycoin.skycoin.SKY_coin_NewEmptyBlock (txns, block);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var pBlock = new coin__Block ();
            err = skycoin.skycoin.SKY_coin_GetBlockObject (block, pBlock);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            pBlock.Head.Version = 0x02;
            pBlock.Head.Time = 100;
            pBlock.Head.BkSeq = 98;
            var uxHash = transutils.RandSHA256 ();
            // TODO: Not complete by callback
        }

        [Test]
        public void TestBlockHashBody () {
            // TODO: not complete by callback
        }

        [Test]
        public void TestNewGenesisBlock () {
            var pubkey = new cipher_PubKey ();
            var seckey = new cipher_SecKey ();
            ulong genTime = 1000;
            ulong genCoins = (ulong) 1000e6;

            var err = skycoin.skycoin.SKY_cipher_GenerateKeyPair (pubkey, seckey);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var addr = new cipher__Address ();
            err = skycoin.skycoin.SKY_cipher_AddressFromPubKey (pubkey, addr);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var block = skycoin.skycoin.new_Block__HandlePtr ();
            err = skycoin.skycoin.SKY_coin_NewGenesisBlock (addr, genCoins, genTime, block);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var pBlock = new coin__Block ();
            err = skycoin.skycoin.SKY_coin_GetBlockObject (block, pBlock);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var nullHash = new cipher_SHA256 ();
            var Head = new GoSlice ();
            err = skycoin.skycoin.SKY_coin_BlockHeader_Bytes (pBlock.Head, Head);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.IsTrue (nullHash.getStr ().p == Head.getString ().p);
            // Assert.AreEqual (genTime, pBlock.Head.Time);
            Assert.AreEqual (0, pBlock.Head.BkSeq);
            Assert.AreEqual (0, pBlock.Head.Version);
            Assert.AreEqual (0, pBlock.Head.Fee);
        }

        struct testcase {
            public int index;
            public int failure;
        }

        [Test]
        public void TestCreateUnspent () {
            var p = new cipher_PubKey ();
            var s = new cipher_SecKey ();
            var a = new cipher__Address ();

            var err = skycoin.skycoin.SKY_cipher_GenerateKeyPair (p, s);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_AddressFromPubKey (p, a);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var h = new cipher_SHA256 ();
            var handle = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeEmptyTransaction (handle);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (handle, a, 11000000, 255);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var bh = new coin__BlockHeader ();
            bh.Time = 0;
            bh.BkSeq = 1;
            testcase[] t = new testcase[2];
            var tc = new testcase ();
            tc.index = 0;
            tc.failure = skycoin.skycoin.SKY_OK;
            t[0] = tc;
            tc = new testcase ();
            tc.failure = skycoin.skycoin.SKY_ERROR;
            tc.index = 10;
            t[1] = tc;
            var ux = new coin__UxOut ();
            var tests_count = t.Length;
            for (int i = 0; i < tests_count; i++) {
                err = skycoin.skycoin.SKY_coin_CreateUnspent (bh, handle, t[i].index, ux);
                if (t[i].failure == skycoin.skycoin.SKY_ERROR) {
                    continue;
                }
                Assert.AreEqual (bh.Time, ux.Head.Time);
                Assert.AreEqual (bh.BkSeq, ux.Head.BkSeq);
            }
        }

        [Test]
        public void TestCreateUnspents () {
            var a = new cipher__Address ();
            var p = new cipher_PubKey ();
            var s = new cipher_SecKey ();

            var err = skycoin.skycoin.SKY_cipher_GenerateKeyPair (p, s);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_AddressFromPubKey (p, a);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var h = new cipher_SHA256 ();
            var txn = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeEmptyTransaction (txn);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (txn, a, (ulong) 11e6, 255);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var bh = new coin__BlockHeader ();
            bh.Time = 0;
            bh.BkSeq = 1;
            var uxouts = new coin_UxOutArray ();
            err = skycoin.skycoin.SKY_coin_CreateUnspents (bh, txn, uxouts);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (uxouts.count, 1);
        }

    }

}