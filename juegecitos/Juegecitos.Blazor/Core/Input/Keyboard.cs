using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;

namespace Juegecitos.Blazor.Core.Input
{
    public class Keyboard : IAfterUpdate
    {
        private Queue<KeyInfo> mKeysAdds = new Queue<KeyInfo>();
        private Dictionary<string, KeyInfo> mKeysActs = new Dictionary<string, KeyInfo>();
        private Dictionary<string, KeyInfo> mKeyCodesActs = new Dictionary<string, KeyInfo>();
        private Queue<KeyboardEventArgs> mKeysFree = new Queue<KeyboardEventArgs>();

        public KeyInfo LastUpdate { get; internal set; } = new KeyInfo();

        public void AddKey(KeyInfo key)
        {
            lock (mKeysAdds)
                mKeysAdds.Enqueue(key);
            if (key.State == EButtonState.Up)
                lock (mKeysFree)
                    mKeysFree.Enqueue(key.Event);
        }

        public KeyInfo GetKeyInfo(string key) => (mKeysActs.TryGetValue(key, out KeyInfo pInfo)) ? pInfo : KeyInfo.None;
        public KeyInfo GetKeyCodeInfo(string key) => (mKeyCodesActs.TryGetValue(key, out KeyInfo pInfo)) ? pInfo : KeyInfo.None;

        public void Update()
        {
            while (mKeysAdds.Count > 0)
            {
                KeyInfo pKey;

                lock (mKeysAdds)
                    pKey = mKeysAdds.Dequeue();
                if (mKeysActs.TryGetValue(pKey.Event.Key, out KeyInfo pKeyOld))
                    pKey.KeyInfoOld = pKeyOld;

                mKeysActs[pKey.Event.Key] = pKey;
                mKeyCodesActs[pKey.Event.Code] = pKey;
            }
        }

        public void AfterUpdate()
        {
            while (mKeysFree.Count > 0)
            {
                KeyboardEventArgs pKey;

                lock (mKeysFree)
                    pKey = mKeysFree.Dequeue();

                mKeysActs.Remove(pKey.Key);
                mKeyCodesActs.Remove(pKey.Code);
            }
        }
    }
}
