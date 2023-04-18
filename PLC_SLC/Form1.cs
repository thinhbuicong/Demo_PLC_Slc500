using System;
using System.Windows.Forms;
using libplctag;
using libplctag.DataTypes;
using libplctag.DataTypes.Simple;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PLC_SLC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            com_Type.DataSource = Enum.GetNames(typeof(PlcType));
            com_Type.SelectedIndex = 4;
        }

        public Tag<IntPlcMapper, short> myTag, myTag_2, myTag_3, myTag_4;


        private void btn_connect_Click(object sender, EventArgs e)
        {
            PlcType cpuType = (PlcType)Enum.Parse(typeof(PlcType), com_Type.Text, true);
            // Xoa var neu khong hoat dong
            var myTag = new Tag<IntPlcMapper, short>()
            {
                //Name is the full path to tag. 
                Name = "N101:0",
                //Gateway is the IP Address of the PLC or communication module.
                Gateway = txt_IP.Text,
                //Path is the location in the control plane of the CPU. Almost always "1,0".
                Path = "1,0",
                PlcType = cpuType,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            var myTag_2 = new Tag<IntPlcMapper, short>()
            {
                Name = "N101:2",
                Gateway = txt_IP.Text,
                Path = "1,0",
                PlcType = cpuType,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            var myTag_3 = new Tag<IntPlcMapper, short>()
            {
                Name = "N7:49",
                Gateway = txt_IP.Text,
                Path = "1,0",
                PlcType = cpuType,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            var myTag_4 = new Tag<IntPlcMapper, short>()
            {
                Name = "N7:50",
                Gateway = txt_IP.Text,
                Path = "1,0",
                PlcType = cpuType,
                Protocol = Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            timer1.Start();
        }
        // Read the value from the PLC
        private void Read_PLC()
        {

            myTag.Read();
            myTag_2.Read();
            myTag_3.Read();
            myTag_4.Read();
            txt_data.Text = myTag.Value.ToString();
            txt_data_2.Text = myTag_2.Value.ToString();

            txt_1.Text = myTag_3.Value.ToString().Insert(2, ",");
            
            if (myTag_4.Value.ToString().Length == 3)
            {
                txt_2.Text = myTag_4.Value.ToString().Insert(1, ",");
            }
            else
            {
                txt_2.Text = myTag_4.Value.ToString();
            }
            

        }
        // Setup Timer
        private void txtTimer_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(txtTimer.Text);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Read_PLC();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

    }
}