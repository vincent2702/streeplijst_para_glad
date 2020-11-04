using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using streeplijst_library;

namespace streeplijst
{
    public class ArduinoSerialReader : IDisposable
    {
        private SerialPort _serialPort;
        public String a;
        public String name;
        
        public ArduinoSerialReader(string portName)
        {
            FormList.OrderForm.dBConnect.Nameslist(" ");
            _serialPort = new SerialPort(portName);
            _serialPort.Open();
            _serialPort.DataReceived += serialPort_DataReceived;
        }

        public ArduinoSerialReader()
        {
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {
                Console.WriteLine(item);
                if (item == "COM4" )
                {
                    
                    FormList.OrderForm.dBConnect.Nameslist(" ");
                    _serialPort = new SerialPort(item);
                    _serialPort.Open();
                    _serialPort.DataReceived += serialPort_DataReceived;
                    break;
                }
                
            }

        }

        void serialPort_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            
            a = _serialPort.ReadLine();
            String b = a.Substring(a.Length -2);
            String d = a.Substring(4, 1);
            Console.WriteLine(b);
            try
            {



                if (b == ": " && d == ":")
                {
                    a = a.Substring(a.IndexOf(":") + 1);
                    a = a.Substring(0, a.IndexOf(":"));
                    string[] tag_data = a.Split(' ');
                    Console.WriteLine(tag_data[0]);

                    foreach (Lid lid in FormList.OrderForm.dBConnect.Names.Leden)
                    {
                        if (tag_data[2] == Convert.ToString(lid.Number) && tag_data[2] != "99")
                        {
                            name = lid.Firstname + "\t" + lid.Lastname;
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.StartForm.Hide()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.NameListForm.Hide()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.OrderForm.Show()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.OrderForm.FullName = name));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.OrderForm.GetData()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.OrderForm.timer1.Start()));
                        }
                        else if (tag_data[2] == "99")
                        {
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.NameListForm.timer1.Stop()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.StartForm.Hide()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.NameListForm.Hide()));
                            FormList.StartForm.Invoke((MethodInvoker)(() => FormList.PenningMeesterForm.Show()));
                        }
                        else
                        {
                            //Console.WriteLine("no");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(a);
                    d = " ";
                    b = " ";
                }
            }
            catch (Exception)
            {

                Console.WriteLine("An error occurred: '{0}'", e);
            }
            //Console.WriteLine(_serialPort.ReadLine());
        }
        public void Dispose()
        {
            if (_serialPort != null)
            {
                _serialPort.Dispose();
            }
        }
    }
}
