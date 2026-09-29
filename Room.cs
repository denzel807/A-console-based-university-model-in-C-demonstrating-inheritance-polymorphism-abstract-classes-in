using System;

namespace лаба1ооп
{
    internal abstract class Room
    {
        protected int capacity;
        protected bool isOpen;

        public int Capacity
        {
            get 
            { 
                return capacity; 
            }
            set 
            {
                capacity = value; 
            }
        }

        public bool IsOpen
        {
            get 
            {
                return isOpen; 
            }
        }

        public abstract void Open();
        public abstract void Close();
        public abstract void PrintInfo();

        protected Room(int capacity)
        {
            this.capacity = capacity;
            this.isOpen = false;
        }
    }
}