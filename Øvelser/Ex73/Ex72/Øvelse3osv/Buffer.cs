using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse3osv
{
    class Buffer
    {
        private Queue<Car> bufferData;
        private int capacity;

        private object bufferLock = new object();

        public Buffer(int capacity)
        {
            this.capacity = capacity;
            bufferData = new Queue<Car>();
        }
        public void Put(Car car)
        {        

            lock (bufferLock)
            {
                while (bufferData.Count > capacity)
                {
                    Monitor.Wait(bufferLock);
                }
                if (bufferData.Count == 0)
                {
                    Monitor.PulseAll(bufferLock);

                }
                if (bufferData.Count > capacity) throw new System.ArgumentException("Køen er fuld");
                bufferData.Enqueue(car);
            }

        }
        public Car Get()
        {
            Car car;
            lock (bufferLock)
            {
                while (bufferData.Count < 1)
                {
                    Monitor.Wait(bufferLock);
                }
                if (bufferData.Count > capacity)
                {
                    Monitor.PulseAll(bufferLock);

                }
                car = bufferData.Dequeue();
            }

            return car;
        }

        public bool IsEmpty()
        {
            bool isempty;
            lock (bufferLock)
            {
                isempty = bufferData.Count == 0;
            }
            return isempty;
        }

        public bool IsFull()
        {
            bool isfull;
            lock (bufferLock)
            {
                isfull = bufferData.Count == capacity;
            }
            return isfull;
        }
    }

}
