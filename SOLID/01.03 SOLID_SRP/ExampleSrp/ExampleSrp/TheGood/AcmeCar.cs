using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
  public class AcmeCar
    {
        public LockState IsLocked { get; private set; }

        // obj e od tip na klasa koj go implementira ILog
        public ILogger obj;

        
       
        public ILoggerComputer compLog;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        public AcmeCar(ILogger log, ILoggerComputer comLogger)
        {
            if(log != null && comLogger!=null)
            {
                obj = log;
                compLog = comLogger;
            }
            else
            {
                throw new NullReferenceException();
            }
            
            
        }
            


        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
               compLog.ComputerLogChangeState("CarLocked"); // status message should be logg on clients phone

            }
            catch (Exception)
            {
                

                obj.LogException("Greska vo lock!"); // Exception messages should be logged depend of Log value
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //
                compLog.ComputerLogChangeState("CarUnlocked"); // status message should be logg on clients phone
            }
            catch (Exception)
            {
               

                obj.LogException("Greshka vo unlock!"); // Exception messages should be logged on the cloud

            }

        }     

    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }

    
}

