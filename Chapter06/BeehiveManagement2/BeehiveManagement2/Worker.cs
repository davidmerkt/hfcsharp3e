using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagement2
{
    class Worker : Bee
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        const double honeyUnitsPerShiftWorked = .65;

        private string currentJob = "";
        public string CurrentJob
        {
            get { return currentJob; }
        }

        public int ShiftsLeft
        {
            get { return shiftsToWork - shiftsWorked; }
            //private set; 
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
                if (jobsICanDo[i].ToUpper() == job.ToUpper())
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;

            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }

        public Worker(string[] job, double weightMg) : base(weightMg)
        {
            this.jobsICanDo = job;
        }

        public override double HoneyConsumptionRate()
        {
            double honeyConsumed = base.HoneyConsumptionRate();
            honeyConsumed += shiftsWorked * honeyUnitsPerShiftWorked; //if (!DidYouFinish()) honeyConsumed += .65;
            return honeyConsumed;
        }
    }
}
