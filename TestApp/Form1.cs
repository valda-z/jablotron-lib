using JaLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {

        private JaInterface ja;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ja = new JaInterface();
            ja.AlarmDataChanged += Ja_AlarmDataChanged;
            ja.AlarmStateChanged += Ja_AlarmStateChanged;
        }

        private void Ja_AlarmStateChanged(JaInterface sender, AlarmState state, byte deviceId)
        {
            Invoke((Action)(() =>
            {
                lblMessage.Text = string.Format("State: {0} / device: 0x{1:X2}", state.ToString(), deviceId);
            }));
        }

        private void Ja_AlarmDataChanged(JaInterface sender)
        {
            Invoke((Action)(() =>
            {
                lblDisplay.Text = string.Format("msg: 0x{0:X2} / device: 0x{1:X2}", sender.MessageId, sender.DeviceId);

                btnA.BackColor = sender.LED_A ? Color.Red : Color.LightGray;
                btnB.BackColor = sender.LED_B ? Color.Red : Color.LightGray;
                btnC.BackColor = sender.LED_C ? Color.Red : Color.LightGray;
                btnW.BackColor = sender.LED_Warning ? Color.Red : Color.LightGray;
            }));
        }

        private void btnDisarm_Click(object sender, EventArgs e)
        {
            ja.SetDisArmed();
        }

        private void btnArm_Click(object sender, EventArgs e)
        {
            ja.SetArmed();
        }

        private void btnArmA_Click(object sender, EventArgs e)
        {
            ja.SetArmA();
        }

        private void btnArmB_Click(object sender, EventArgs e)
        {
            ja.SetArmB();
        }

        private void btnArmABC_Click(object sender, EventArgs e)
        {
            ja.SetArmABC();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ja.PIN = txtPIN.Text;
            ja.Open(txtCom.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ja.Close();
        }
    }
}
