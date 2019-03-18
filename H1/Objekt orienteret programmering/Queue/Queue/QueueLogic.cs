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

        /// <summary>
        /// adds a new patient to the queue
        /// </summary>
        /// <param name="inputName"></param>
        public void AddToQueue(string inputName)
        {
            patientQueue.Enqueue(new Patient() { Name = inputName });
        }

        /// <summary>
        /// dequeues a patient
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// shows every patient in queue
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// tells how many patients are in queue
        /// </summary>
        /// <returns></returns>
        public int PeopleInQueue()
        {
            return patientQueue.Count();
        }
    }
}
