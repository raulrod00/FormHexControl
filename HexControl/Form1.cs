using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hex_Control
{
    public partial class RotationLength : Form
    {

        //Action platform mechanical parameters
        //public uint AccessDistanceUnit { get; set; }//350 ActLength
        //public uint LeadDistanceUnit { get; set; }  //10 RotLength
        //public uint OneTurnPulseNum { get; set; }   //10000 RotPulse

        public uint accessDistanceUnit;
        public uint leadDistanceUnit;
        public uint oneTurnPulseNum;

        //Control protocol packet
        private const ushort confirmCode = 0x55aa;
        private const ushort passCode = 0;
        private const ushort functionCode = 0x1401;
        private const ushort objectChannel = 1;
        private const ushort whoAccpet = 0xFFFF;
        private const ushort whoReply = 0;
        private const ushort line = 0;
        private uint absTime = 50;//millisecond
        private uint xPos = 1;
        private uint yPos = 1;
        private uint zPos = 1;
        private uint uPos = 1;
        private uint vPos = 1;
        private uint wPos = 1;
        private uint baseDout1 = 0;
        private uint baseDout2 = 0;
        private const uint dac = 0;
        private uint baseDout3 = 0;
        private uint baseDout4 = 0;
        private uint effects = 0;

        //udp
        private IPEndPoint mboxIPE = null;
        private Socket socket = null;

        private void constructPacket()
        {
            StringBuilder str = new StringBuilder();
            accessDistanceUnit = Convert.ToUInt16(ActLength.Text);
            leadDistanceUnit   = Convert.ToUInt16(RotLength.Text);
            oneTurnPulseNum    = Convert.ToUInt16(RotPulses.Text);

            uint _xPos = (accessDistanceUnit / leadDistanceUnit) * oneTurnPulseNum * xPos / 255;
            uint _yPos = (accessDistanceUnit / leadDistanceUnit) * oneTurnPulseNum * yPos / 255;
            uint _zPos = (accessDistanceUnit / leadDistanceUnit) * oneTurnPulseNum * zPos / 255;
            uint _uPos = (accessDistanceUnit / leadDistanceUnit) * oneTurnPulseNum * uPos / 255;
            uint _vPos = (accessDistanceUnit / leadDistanceUnit) * oneTurnPulseNum * vPos / 255;
            uint _wPos = (accessDistanceUnit / leadDistanceUnit) * oneTurnPulseNum * wPos / 255;

            str.Append(confirmCode.ToString("X4"));
            str.Append(passCode.ToString("X4"));
            str.Append(functionCode.ToString("X4"));
            str.Append(objectChannel.ToString("X4"));
            str.Append(whoAccpet.ToString("X4"));
            str.Append(whoReply.ToString("X4"));
            str.Append(line.ToString("X8"));
            str.Append(absTime.ToString("X8"));
            str.Append(_xPos.ToString("X8"));
            str.Append(_yPos.ToString("X8"));
            str.Append(_zPos.ToString("X8"));
            str.Append(_uPos.ToString("X8"));
            str.Append(_vPos.ToString("X8"));
            str.Append(_wPos.ToString("X8"));
            str.Append(baseDout1.ToString("X2"));
            str.Append(baseDout4.ToString("X2"));
            str.Append(dac.ToString("X8"));
            str.Append(baseDout3.ToString("X2"));
            str.Append(baseDout2.ToString("X2"));

            string sendStr = str.ToString().ToLower();

            byte[] sendBuf = HexStringToByteArray(sendStr);
            //socket.SendTo(sendBuf, mboxIPE);
            Test_String.Text = sendStr;
            //Console.WriteLine(sendBuf);

        }

        public RotationLength()
        {
            InitializeComponent();
            mboxIPE = new IPEndPoint(IPAddress.Parse("192.168.15.255"), 7408);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RotationLength_Load(object sender, EventArgs e)
        {

        }

        private void ActLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sendCom_Click(object sender, EventArgs e)
        {
            constructPacket();
        }


        /// <summary>
        /// Reset
        /// </summary>
        public void Reset()
        {
            string str = "55aa000012010002ffffffff000000010000";
            byte[] sendBuf = HexStringToByteArray(str);
            socket.SendTo(sendBuf, mboxIPE);
        }


        private byte[] HexStringToByteArray(string s)
        {
            //s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            }
            return buffer;
        }

    }
}
