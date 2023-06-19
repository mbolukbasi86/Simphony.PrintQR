using Micros.Ops.Extensibility;
using Micros.PosCore.Extensibility;
using Micros.PosCore.Extensibility.Ops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simphony.PrintQR.Extension
{
    public class Application : OpsExtensibilityApplication
    {
        public Application(IExecutionContext context) : base(context)
        {
            this.OpsInitEvent += OnInitEvent;
            OpsPrinterDataEvent += OnPrintDataEvent;
        }

        [ExtensibilityMethod]
        public void InitTest()
        {
            OpsContext.ShowMessage(string.Format("Init {0}", this.ApplicationName));
        }

        private EventProcessingInstruction OnInitEvent(object sender, OpsInitEventArgs args)
        {
            this.OpsContext.ShowMessage("Init");
            return EventProcessingInstruction.Continue;
        }

        private EventProcessingInstruction OnPrintDataEvent(object sender, OpsPrinterDataArgs args)
        {
            // :)
            return EventProcessingInstruction.Continue;
        }
    }
}
