using System;

namespace JA82Lib
{
    public enum AlarmState
    {
        IDLE,
        OUTCOMMINGINGDELAY,
        INCOMMINGDELAY,
        ALARM
    }

    public class JaInterface
    {
        private bool _LED_A = false;
        private bool _LED_B = false;
        private bool _LED_C = false;
        private bool _LED_Warning = false;
        private bool _LED_Bcaklight = false;

        private bool _isOpen = false;
        private SerialPort port;

        private AlarmState _state = AlarmState.IDLE;

        public AlarmState State { get { return _state; } }

        public bool IsOpen { get { return _isOpen; } }

        public JaInterface()
        {

        }

        public void Open(string portName)
        {
            if (_isOpen)
            {
                throw new JaExceptionPortAlreadyOpen();
            }

            _isOpen = true;
        }

        public void Close()
        {
            _isOpen = false;
        }
    }
}
