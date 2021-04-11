using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juegecitos.Blazor.Core
{
    public class GameObjectsCollection : ICollection<GameObject>
    {
        protected List<GameObject> mObjs = new List<GameObject>();
        protected List<GameObject> mObjsUpdates = new List<GameObject>();
        protected List<GameObject> mObjsRenders = new List<GameObject>();
        protected bool mRecalcObjs;

        public int Count => mObjs.Count;

        public bool IsReadOnly => false;

        public void Add(GameObject item)
        {
            item.Initialize();
            mObjs.Add(item);
            mRecalcObjs = true;
        }

        public void AddRange(params GameObject[] argObjs)
        {
            foreach (var pObj in argObjs)
                Add(pObj);
        }

        public void Clear()
        {
            mObjs.Clear();
            mRecalcObjs = true;
        }

        public bool Contains(GameObject item) => mObjs.Contains(item);

        public void CopyTo(GameObject[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<GameObject> GetEnumerator() => mObjs.GetEnumerator();

        public bool Remove(GameObject item)
        {
            var pRet = mObjs.Remove(item);

            mRecalcObjs = true;

            return pRet;
        }

        public ICollection<GameObject> ObjsUpdates
        {
            get
            {
                if (mRecalcObjs)
                {
                    RecalcObjs();
                    mRecalcObjs = false;
                }

                return mObjsUpdates;
            }
        }

        public ICollection<GameObject> ObjsRenders
        {
            get
            {
                if (mRecalcObjs)
                {
                    RecalcObjs();
                    mRecalcObjs = false;
                }

                return mObjsRenders;
            }
        }

        public ICollection<GameObject> GetObjsEnableds() => ObjsUpdates;

        public ICollection<GameObject> GetObjsVisible() => ObjsRenders;

        protected void RecalcObjs()
        {
            mObjsUpdates.Clear();
            mObjsRenders.Clear();

            foreach (var pObj in mObjs)
            {
                if (pObj.IsUpdater)
                    mObjsUpdates.Add(pObj);
                if (pObj.IsRender)
                    mObjsRenders.Add(pObj);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => mObjs.GetEnumerator();
    }
}
