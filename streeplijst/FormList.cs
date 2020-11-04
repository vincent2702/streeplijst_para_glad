using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streeplijst
{
    public class FormList
    {
        private static readonly OrderForm _OrderForm = new OrderForm();
        public static OrderForm OrderForm { get { return _OrderForm; } }
        private static readonly NameListForm _NameListForm = new NameListForm();
        public static NameListForm NameListForm { get { return _NameListForm; } }
        private static readonly PenningMeesterForm _PenningMeesterForm = new PenningMeesterForm();
        public static PenningMeesterForm PenningMeesterForm { get { return _PenningMeesterForm; } }
        private static readonly StartForm _StartForm = new StartForm();
        public static StartForm StartForm { get { return _StartForm; } }
        private static readonly ArduinoSerialReader _arduinoSerialReader = new ArduinoSerialReader();
        public static ArduinoSerialReader ArduinoSerialReader { get { return _arduinoSerialReader; } }



        public FormList() {
            StartForm.Show();
        }
    }
}
