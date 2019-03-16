using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class QueueLogic
    {
        Queue<Patient> patientQueue = new Queue<Patient>();

        public void AddToQueue(string inputName)
        {
            patientQueue.Enqueue(new Patient() { Name = inputName });
        }

        public string CallNext()
        {
            string temp;

            if (patientQueue.Count > 0)
            {
                temp = patientQueue.Peek().Name;
                patientQueue.Dequeue(); 
            }
            else
            {
                temp = "There are no patients left";
            }

            return temp;
        }

        public string PeekQueue()
        {
            string temp = "";

            if (patientQueue.Count > 0)
            {
                foreach (Patient p in patientQueue)
                {
                    temp += p.Name + ", ";
                } 
            }
            else
            {
                temp = "There are no patients in queue";
            }

            return temp;
        }

        public int PeopleInQueue()
        {
            return patientQueue.Count();
        }
    }
}
