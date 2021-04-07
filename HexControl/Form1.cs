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
        //Control protocol packet
        private const ushort confirmCode = 0x55aa;
        private const ushort passCode = 0;
        private const ushort functionCode = 0x1401;
        private const ushort objectChannel = 1;
        private const ushort whoAccpet = 0xFFFF;
        private const ushort whoReply = 0;
        private const ushort line = 0;
        private uint absTime = 50;//millisecond
        private uint xPos = 0;
        private uint yPos = 0;
        private uint zPos = 0;
        private uint uPos = 0;
        private uint vPos = 0;
        private uint wPos = 0;
        private uint baseDout1 = 0;
        private uint baseDout2 = 0;
        private const uint dac = 0;
        private uint baseDout3 = 0;
        private uint baseDout4 = 0;
        private uint effects = 0;

        public RotationLength()
        {
            InitializeComponent();
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
