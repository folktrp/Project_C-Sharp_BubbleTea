using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPBubbleTea.BC
{
    public class EntityBase
    {

        #region Enum

        /// <summary>
        /// 
        /// </summary>
        public enum EntityStates
        {
            Added,
            Change,
            UnChange
        }



        #endregion


        #region Properties

        public EntityStates EntityState { get; set; }
        

        #endregion

    }
}
