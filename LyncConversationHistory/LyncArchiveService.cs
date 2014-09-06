using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace LyncConversationHistory
{
    public partial class LyncArchiveService : ServiceBase
    {
        public LyncArchiveService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        public void Start(string[] args)
        {
            OnStart(args);
        }

        public void DoStop()
        {
            OnStop();
        }
    }
}
