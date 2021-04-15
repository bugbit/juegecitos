using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core.Input
{
    public class Keyboard : IAfterUpdate
    {
        private Dictionary<string, KeyInfo> mKeysActs = new Dictionary<string, KeyInfo>();
        private Queue<string> mKeysFree = new Queue<string>();

        public KeyInfo LastUpdate { get; internal set; } = new KeyInfo();

        public void AddKey(KeyInfo key)
        {
            mKeysActs[key.Key] = key;
            if (key.State == EButtonState.Down)
                mKeysFree.Enqueue(key.Key);
        }

        public KeyInfo GetKeyInfo(string key) => (mKeysActs.TryGetValue(key, out KeyInfo pInfo)) ? pInfo : KeyInfo.None;

        public void AfterUpdate()
        {
            while (mKeysFree.Count > 0)
            {
                var pKey = mKeysFree.Dequeue();

                mKeysActs.Remove(pKey);
            }
        }
    }
}
