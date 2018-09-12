using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public enum HashTableType
    {
        Chaining,
        OpenAddressing_LinearProbing,
        OpenAddressing_DoubleHashing,
    }
    public class HashTable
    {
        private LinkedList<object>[] chainingArray;
        private int defaultCapacity = 32;
        private int capacity;
        private float loadFactor;

        public HashTable()
        {
            this.capacity = defaultCapacity;
            chainingArray = new LinkedList<object>[this.capacity];
        }

        public HashTable(int capacity)
        {
            this.capacity = capacity;
            chainingArray = new LinkedList<object>[this.capacity];
        }

        public HashTable(int capacity, float loadFactor)
        {
            this.capacity = capacity;
            this.loadFactor = loadFactor;
        }

        private int HashFunction(object key)
        {
            int hash = key.GetHashCode();
            int pos = hash % capacity;
            return pos;
        }

        private void GrowAndReHash()
        {

        }

        public void Add(object key, object value)
        {
            LinkedListNode<object> lln = new LinkedListNode<object>(key);
            chainingArray[HashFunction(key)].AddLast(lln);
            
        }

        public int Size()
        {
            throw new NotImplementedException();
        }

        public virtual void Clear()
        {
            throw new NotImplementedException();
        }
        public bool Contains(object key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(object key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsValue(object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

    }
}
