using System.Runtime.InteropServices;

namespace WDTDIOWrapper
{
    public static class NativeImports
    {
        private const string DLL_PATH = "WDT_DIO64.dll";

        // TODO: Test callbacks
        public delegate COS_INT_CALLBACK_ARG COS_INT_CALLBACK();

        public delegate void CAN_RegisterReceivedHandler([In] ref CAN_MSG lpMsg, [In] ulong cbMsg);

        public delegate void CAN_RegisterStatusHandler([In] ulong status);

        public delegate void PWM_RegisterStatusHandler([In] ulong genBits, [In] ulong status);

        public delegate void DT2_EiRegisterIndexedHandler([In] ulong data);

        public struct COS_INT_SETUP
        {
            ushort portMask;
            ushort edgeMode;
            ushort edgeType;
        }

        public struct COS_INT_CALLBACK_ARG
        {
            ushort portData;
            ushort intrFlag;
            byte intrSeq;
        }

        public struct DTIO_SETUP
        {
            byte trigMode;
            byte trigSrcDO;
            byte pulseTgtExtra;
            byte pulseExtra;
            ulong pulseDelay;
            ulong pulseWidth;
        }

        public struct DTFO_SETUP
        {
            byte trigMode;
            byte trigSrcDI;
            byte pulseTgtDO;
            byte pulseExtra;
            ulong pulseTag;
            ulong pulseWidth;
        }

        public struct IGN_SETTING
        {
            byte mode;
            byte batteryType;
            byte isSmartOff;
            byte isPostCheck;
            ulong onDelay;
            ulong offDelay;
            ulong hardOffTimeout;
            double lowVolThreshold;
        }

        public struct CAN_SETUP
        {
            ulong bitRate;
            ulong recvConfig;
            ulong recvId;
            ulong recvMask;
        }

        public unsafe struct CAN_MSG
        {
            ulong id;
            ushort flags;
            byte extra;
            byte len;
            fixed byte data[8];
        }

        public struct PWM_GEN_SETUP
        {
            ulong genMode;
            ulong intrTriggers;
            ushort deadBandRise;
            ushort deadBandFall;
        }

        public struct QEI_SETUP
        {
            ulong config;
            ulong maxPos;
            ulong velPeriod;
            ulong velPreDiv;
        }

        public struct DT2_SETUP
        {
            byte index;
            byte modeFlags;
            byte modeType;
            byte trigMode;
            ulong trigData;
            ulong trigSrc;
            ulong trigTgt;
            ulong pulseDelay;
            ulong pulseWidth;
            ulong pulseData1;
            ulong pulseData2;
        }

        public const ulong DTIO_INIT_HIGN = 0x01;
        public const ulong DTFO_INIT_HIGN = 0x01;

        public enum LED_Mode : ulong
        {
            DISABLE = 0x00,
            CC = 0x01,
            CV = 0x02,
            CD = 0x03,
        }

        public enum IGN_Mode : ulong
        {
            ATX = 0x00,
            AT = 0x01,
            IGN = 0x02,
        }

        public enum IGN_Batt : ulong
        {
            _12V = 0x00,
            _24V = 0x01,
        }

        public enum CAN_MSG_Flags : ulong
        {
            EXTENDED_ID = 0x04,
            REMOTE_FRAME = 0x40,
            DATA_NEW = 0x80,
            DATA_LOST = 0x100,
        }

        public enum CAN_MSG_Config : ulong
        {
            USE_ID_FILTER = 0x08,
            USE_DIR_FILTER = 0x10,
            USE_EXT_FILTER = 0x20,
        }

        public enum CAN_STATUS : ulong
        {
            BUS_OFF = 0x80,
            EWARN = 0x40,
            EPASS = 0x20,
            LEC_STUFF = 0x01,
            LEC_FORM = 0x02,
            LEC_ACK = 0x03,
            LEC_BIT1 = 0x04,
            LEC_BIT0 = 0x05,
            LEC_CRC = 0x06,
            LEC_MASK = 0x07,
        }

        public enum PWN_GEN_MODE : ulong
        {
            DOWN = 0x00,
            UP_DOWN = 0x02,
            SYNC = 0x38,
            NO_SYNC = 0x00, // ??
            FAULT_LATCHED = 0x40000,
            FAULT_UNLATCHED = 0x00, // ??
            FAULT_MINPER = 0x20000,
            FAULT_NO_MINPER = 0x00, // ??
            FAULT_EXT = 0x10000,
            FAULT_LEGACY = 0x00, // ??
            DB_NO_SYNC = 0x00, // ??
            DB_SYNC_LOCAL = 0xA800,
            DB_SYNC_GLOBAL = 0xFC00,
            GEN_NO_SYNC = 0x00, // ??
            GEN_SYNC_LOCAL = 0x280,
            GEN_SYNC_GLOBAL = 0x3C0,
        }

        public enum PWM_INTR_CNT : ulong
        {
            ZERO = 0x01,
            LOAD = 0x02,
            AU = 0x04,
            AD = 0x08,
            BU = 0x10,
            BD = 0x20,
        }

        public enum PWM_TRIG_CNT : ulong
        {
            ZERO = 0x100,
            LOAD = 0x200,
            AU = 0x400,
            AD = 0x800,
            BU = 0x1000,
            BD = 0x2000,
        }

        public enum PWM_CLK_DIV : ulong
        {
            DIV_1 = 0x00,
            DIV_2 = 0x01,
            DIV_4 = 0x02,
            DIV_8 = 0x03,
            DIV_16 = 0x04,
            DIV_32 = 0x05,
            DIV_64 = 0x06,
        }

        public enum PWM_PIN : ulong
        {
            PIN_0 = 0x01,
            PIN_1 = 0x02,
            PIN_2 = 0x04,
            PIN_3 = 0x08,
            PIN_4 = 0x10,
            PIN_5 = 0x20,
            PIN_6 = 0x40,
            PIN_7 = 0x80,
        }

        public enum PWM_GEN : ulong
        {
            GEN_0 = (PWM_PIN.PIN_0 | PWM_PIN.PIN_1),
            GEN_1 = (PWM_PIN.PIN_2 | PWM_PIN.PIN_3),
            GEN_2 = (PWM_PIN.PIN_4 | PWM_PIN.PIN_5),
            GEN_3 = (PWM_PIN.PIN_6 | PWM_PIN.PIN_7),
        }

        public enum QEI_CONFIG : ulong
        {
            CAPTURE_A = 0x00,
            CAPTURE_A_B = 0x08,
            NO_RESET = 0x00,
            RESET_IDX = 0x10,
            QUADRATURE = 0x00, // ??
            CLOCK_DIR = 0x04,
            NO_SWAP = 0x00, // ??
            SWAP = 0x02,
        }

        public enum QEI_VEL : ulong
        {
            DIV_1 = 0x00,
            DIV_2 = 0x40,
            DIV_4 = 0x80,
            DIV_8 = 0xC0,
            DIV_16 = 0x100,
            DIV_32 = 0x140,
            DIV_64 = 0x180,
            DIV_128 = 0x1C0,
        }

        public enum DT2_ModeFlags : ulong
        {
            INIT_HIGN = 0x01,
            TRIG_BUFF = 0x02,
            TRIG_EIDD = 0x04,
            TRIG_EIDA = 0x08,
        }

        public enum DT2_ModeType : ulong
        {
            PTT = 0x00,
            PTP = 0x01,
            PPT = 0x02,
            PPP = 0x03,
        }

        public enum DT2_TrigMode : ulong
        {
            NEVER = 0x00,
            RISING = 0x01,
            FALLING = 0x02,
            LEVEL = 0x03,
            ALWAYS = 0x04,
            ABOVE = 0x01, // ??
            BELOW = 0x02, // ??
        }

        public enum DT2_TrigSrc : ulong
        {
            // Inputs
            DI_00 = 0x10001,
            DI_01 = 0x10002,
            DI_02 = 0x10004,
            DI_03 = 0x10008,
            DI_04 = 0x10010,
            DI_05 = 0x10020,
            DI_06 = 0x10040,
            DI_07 = 0x10080,
            // Outputs
            DO_00 = 0x20001,
            DO_01 = 0x20002,
            DO_02 = 0x20004,
            DO_03 = 0x20008,
            DO_04 = 0x20010,
            DO_05 = 0x20020,
            DO_06 = 0x20040,
            DO_07 = 0x20080,
            DO_08 = 0x20100,
            DO_09 = 0x20200,
            DO_10 = 0x20400,
            DO_11 = 0x20800,
            //
            SI_00 = 0x40000001,
            SI_01 = 0x40000002,
            SI_02 = 0x40000004,
            SI_03 = 0x40000008,
            SI_04 = 0x40000010,
            SI_05 = 0x40000020,
            SI_06 = 0x40000040,
            SI_07 = 0x40000080,
            //
            SO_00 = 0x80000001,
            SO_01 = 0x80000002,
            SO_02 = 0x80000004,
            SO_03 = 0x80000008,
            SO_04 = 0x80000010,
            SO_05 = 0x80000020,
            SO_06 = 0x80000040,
            SO_07 = 0x80000080,
            //
            ADC_0 = 0x40001,
            ADC_1 = 0x40002,
            ADC_2 = 0x40004,
            ADC_3 = 0x40008,
            //
            QEI_0 = 0x80001,
            QEI_1 = 0x80002,
            //
            LED_0 = 0x200001,
            LED_1 = 0x200002,
            LED_2 = 0x200004,
            LED_3 = 0x200008,
        }

        public enum DT2_TrigTgt : ulong
        {
            DO_00 = 0x20001,
            DO_01 = 0x20002,
            DO_02 = 0x20004,
            DO_03 = 0x20008,
            DO_04 = 0x20010,
            DO_05 = 0x20020,
            DO_06 = 0x20040,
            DO_07 = 0x20080,
            DO_08 = 0x20100,
            DO_09 = 0x20200,
            DO_10 = 0x20400,
            DO_11 = 0x20800,
            DO_12 = 0x21000,
            DO_13 = 0x22000,
            DO_14 = 0x24000,
            DO_15 = 0x28000,
            //
            SO_00 = 0x80000001,
            SO_01 = 0x80000002,
            SO_02 = 0x80000004,
            SO_03 = 0x80000008,
            SO_04 = 0x80000010,
            SO_05 = 0x80000020,
            SO_06 = 0x80000040,
            SO_07 = 0x80000080,
            //
            PWM_0 = 0x100001,
            PWM_1 = 0x100002,
            PWM_2 = 0x100004,
            PWM_3 = 0x100008,
            PWM_4 = 0x100010,
            PWM_5 = 0x100020,
            PWM_6 = 0x100040,
            PWM_7 = 0x100080,
            //
            LED_0 = 0x200001,
            LED_1 = 0x200002,
            LED_2 = 0x200004,
            LED_3 = 0x200008,
        }

        [DllImport(DLL_PATH)]
        internal static extern int InitDIO();

        [DllImport(DLL_PATH)]
        internal static extern bool DIReadLine(byte ch);

        [DllImport(DLL_PATH)]
        internal static extern ushort DIReadPort();

        [DllImport(DLL_PATH)]
        internal static extern void DOWriteLine(byte ch, bool value);

        [DllImport(DLL_PATH)]
        internal static extern void DOWritePort(ushort value);

        [DllImport(DLL_PATH)]
        internal static extern void DOWriteLineChecked(byte ch, bool value);

        [DllImport(DLL_PATH)]
        internal static extern void DOWritePortChecked(ushort value);

        [DllImport(DLL_PATH)]
        internal static extern bool StopDIO();

        [DllImport(DLL_PATH)]
        internal static extern bool InitWDT();

        [DllImport(DLL_PATH)]
        internal static extern bool StopWDT();

        [DllImport(DLL_PATH)]
        internal static extern bool StartWDT();

        [DllImport(DLL_PATH)]
        internal static extern bool SetWDT(ushort tick, byte unit);

        [DllImport(DLL_PATH)]
        internal static extern bool ResetWDT();

        [DllImport(DLL_PATH)]
        internal static extern byte GetStatusPoEPort(byte port);

        [DllImport(DLL_PATH)]
        internal static extern bool DisablePoEPort(byte port);

        [DllImport(DLL_PATH)]
        internal static extern bool EnablePoEPort(byte port);

        [DllImport(DLL_PATH)]
        internal static extern bool SetupDICOS(ref COS_INT_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool StartDICOS();

        [DllImport(DLL_PATH)]
        internal static extern bool StopDICOS();

        [DllImport(DLL_PATH)]
        internal static extern bool RegisterCallbackDICOS([MarshalAs(UnmanagedType.FunctionPtr)] COS_INT_CALLBACK callback);

        [DllImport(DLL_PATH)]
        internal static extern bool SetupDTIO(ref DTIO_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool StartDTIO();

        [DllImport(DLL_PATH)]
        internal static extern bool StopDTIO();

        [DllImport(DLL_PATH)]
        internal static extern bool SetUnitDTIO(ushort unit, int delta);

        [DllImport(DLL_PATH)]
        internal static extern ushort GetUnitDTIO();

        [DllImport(DLL_PATH)]
        internal static extern bool SetupDTFO(ref DTFO_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool StartDTFO();

        [DllImport(DLL_PATH)]
        internal static extern bool StopDTFO();

        [DllImport(DLL_PATH)]
        internal static extern bool SetUnitDTFO(ushort unit, int delta);

        [DllImport(DLL_PATH)]
        internal static extern ushort GetUnitDTFO();

        [DllImport(DLL_PATH)]
        internal static extern bool LED_SetCurrentDriving(ulong mode, ulong data);

        [DllImport(DLL_PATH)]
        internal static extern bool MCU_GetVersion(ref ulong lpDateCode);

        [DllImport(DLL_PATH)]
        internal static extern bool MCU_Reset();

        [DllImport(DLL_PATH)]
        internal static extern bool IGN_GetState(ref ulong lpState);

        [DllImport(DLL_PATH)]
        internal static extern bool IGN_GetBatteryVoltage(ref double lpVoltage);

        [DllImport(DLL_PATH)]
        internal static extern bool IGN_GetSetting(ref IGN_SETTING lpSetting, ulong cbSetting);

        [DllImport(DLL_PATH)]
        internal static extern bool CAN_RegisterReceived(ulong idx, [MarshalAs(UnmanagedType.FunctionPtr)] CAN_RegisterReceivedHandler pfnHandler);

        [DllImport(DLL_PATH)]
        internal static extern bool CAN_RegisterStatus(ulong idx, [MarshalAs(UnmanagedType.FunctionPtr)] CAN_RegisterStatusHandler pfnHandler);

        [DllImport(DLL_PATH)]
        internal static extern bool CAN_Setup(ulong idx, ref CAN_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool CAN_Start(ulong idx);

        [DllImport(DLL_PATH)]
        internal static extern bool CAN_Stop(ulong idx);

        [DllImport(DLL_PATH)]
        internal static extern bool CAN_Send(ulong idx, ref CAN_MSG lpMsg, ulong cbMsg);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_ClockSet(ulong idx, ulong divClock);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_RegisterStatus([MarshalAs(UnmanagedType.FunctionPtr)] PWM_RegisterStatusHandler pfnHandler);

        [DllImport(DLL_PATH)]
        internal static extern bool MCU_Reset(ulong genBits, ref PWM_GEN_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_GenSetup(ulong genBits, ref PWM_GEN_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_GenPeriod(ulong genBits, ulong period);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_PulseWidth(ulong pinBits, ulong width);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_PulseInvert(ulong pinBits);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_Start(ulong pinBits);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_Stop(ulong pinBits);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_SyncTimeBase(ulong genBits);

        [DllImport(DLL_PATH)]
        internal static extern bool PWM_SyncUpdate(ulong genBits);

        [DllImport(DLL_PATH)]
        internal static extern bool ADC_Stop(ulong idx);

        [DllImport(DLL_PATH)]
        internal static extern bool ADC_Start(ulong idx);

        [DllImport(DLL_PATH)]
        internal static extern bool ADC_GetData(ulong idx, ref double lpData);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_Stop(ulong idx);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_Start(ulong idx);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_Setup(ulong idx, ref QEI_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_GetDirection(ulong idx, ref ulong lpDirection);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_GetVelocity(ulong idx, ref ulong lpVelocity);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_GetPosition(ulong idx, ref ulong lpPosition);

        [DllImport(DLL_PATH)]
        internal static extern bool QEI_SetPosition(ulong idx, ulong position);

        [DllImport(DLL_PATH)]
        internal static extern byte PCI_GetStatusPoEPort(ulong boardId, ulong port);

        [DllImport(DLL_PATH)]
        internal static extern bool PCI_DisablePoEPort(ulong boardId, ulong port);

        [DllImport(DLL_PATH)]
        internal static extern bool PCI_EnablePoEPort(ulong boardId, ulong port);

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_Setup(ref DT2_SETUP lpSetup, ulong cbSetup);

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_Start();

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_Stop();

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_SetUnit(ulong unit, int delta);

        [DllImport(DLL_PATH)]
        internal static extern ushort DT2_GetUnit();

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_StPush(ulong mask, ulong value);

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_StPull(ref ulong lpValue);

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_EiRegisterIndexed([MarshalAs(UnmanagedType.FunctionPtr)] DT2_EiRegisterIndexedHandler pfnHandler);

        [DllImport(DLL_PATH)]
        internal static extern bool DT2_EiSendResult(ulong idx, ulong value);
    }
}
