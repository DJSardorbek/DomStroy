using DomStroyB2C_MVVM.Commands;
using DomStroyB2C_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DomStroyB2C_MVVM.ViewModels
{
    public class QueueNavbatlarViewModel : BaseViewModel
    {
        #region Constructor

        public QueueNavbatlarViewModel()
        {
            objDbAccess = new DBAccess();
            tbQueue = new DataTable();
            GetQueueList();
        }

        #endregion

        #region Command
        private RelayCommand command;

        public RelayCommand Command
        {
            get { return command; }
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The queue to be selected
        /// </summary>
        private queueDTO queue;

        public queueDTO Queue
        {
            get { return queue; }
            set { queue = value; OnPropertyChanged("Queue"); }
        }

        /// <summary>
        /// The queue list
        /// </summary>
        private List<queueDTO> queueList;

        public List<queueDTO> QueueList
        {
            get { return queueList; }
            set { queueList = value; OnPropertyChanged("QueueList"); }
        }

        /// <summary>
        /// Data access
        /// </summary>
        private DBAccess objDbAccess;

        public DBAccess ObjDbAccess
        {
            get { return objDbAccess; }
        }

        /// <summary>
        /// The data table of queue list
        /// </summary>
        private DataTable tbQueue;

        public DataTable TbQueue
        {
            get { return tbQueue; }
        }

        #endregion

        #region Helper Methods

        public void GetQueueList()
        {
            string queryToQueue = "select sh.id, sh.comment, st.first_name, sh.total_sum, sh.total_dollar, sh.traded_at from shop as sh " +
                "inner join staff  as st on sh.seller = st.id " +
                "where sh.queue = 1";
            TbQueue.Clear();
            ObjDbAccess.readDatathroughAdapter(queryToQueue, TbQueue);
            ConvertQueueTableToList();

        }

        public void ConvertQueueTableToList()
        {
            QueueList = (from DataRow dr in TbQueue.Rows
                         select new queueDTO()
                         {
                             Chek = Convert.ToInt32(dr["id"]),
                             Comment = dr["comment"].ToString(),
                             Seller = dr["first_name"].ToString(),
                             Sum = Convert.ToDouble(dr["total_sum"]),
                             Dollar = Convert.ToDouble(dr["total_dollar"]),
                             Date = Convert.ToDateTime(dr["traded_at"])
                         }).ToList();
        }

        #endregion

    }
}
