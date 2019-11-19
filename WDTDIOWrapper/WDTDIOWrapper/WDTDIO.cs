using static WDTDIOWrapper.NativeImports;

namespace WDTDIOWrapper
{
    public static class WDTDIO
    {
        public static int InitDIO()
        {
            return NativeImports.InitDIO();
        }

        public static bool DIReadLine(byte ch)
        {
            return NativeImports.DIReadLine(ch);
        }

        public static ushort DIReadPort()
        {
            return NativeImports.DIReadPort();
        }

        public static void DOWriteLine(byte ch, bool value)
        {
            NativeImports.DOWriteLine(ch, value);
        }

        public static void DOWritePort(ushort value)
        {
            NativeImports.DOWritePort(value);
        }

        public static void DOWriteLineChecked(byte ch, bool value)
        {
            NativeImports.DOWriteLineChecked(ch, value);
        }

        public static void DOWritePortChecked(ushort value)
        {
            NativeImports.DOWritePortChecked(value);
        }

        public static bool StopDIO()
        {
            return NativeImports.StopDIO();
        }

        public static bool InitWDT()
        {
            return NativeImports.InitWDT();
        }

        public static bool StopWDT()
        {
            return NativeImports.StopWDT();
        }

        public static bool StartWDT()
        {
            return NativeImports.StartWDT();
        }

        public static bool SetWDT(ushort tick, byte unit)
        {
            return NativeImports.SetWDT(tick, unit);
        }

        public static bool ResetWDT()
        {
            return NativeImports.ResetWDT();
        }

        public static byte GetStatusPoEPort(byte port)
        {
            return NativeImports.GetStatusPoEPort(port);
        }

        public static bool DisablePoEPort(byte port)
        {
            return NativeImports.DisablePoEPort(port);
        }

        public static bool EnablePoEPort(byte port)
        {
            return NativeImports.EnablePoEPort(port);
        }

        public static bool SetupDICOS(ref COS_INT_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.SetupDICOS(ref lpSetup, cbSetup);
        }

        public static bool StartDICOS()
        {
            return NativeImports.StartDICOS();
        }

        public static bool StopDICOS()
        {
            return NativeImports.StopDICOS();
        }

        public static bool RegisterCallbackDICOS(COS_INT_CALLBACK pfnHandler)
        {
            return NativeImports.RegisterCallbackDICOS(pfnHandler);
        }

        public static bool SetupDTIO(ref DTIO_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.SetupDTIO(ref lpSetup, cbSetup);
        }

        public static bool StartDTIO()
        {
            return NativeImports.StartDTIO();
        }

        public static bool StopDTIO()
        {
            return NativeImports.StopDTIO();
        }

        public static bool SetUnitDTIO(ushort unit, int delta)
        {
            return NativeImports.SetUnitDTIO(unit, delta);
        }

        public static ushort GetUnitDTIO()
        {
            return NativeImports.GetUnitDTIO();
        }

        public static bool SetupDTFO(ref DTFO_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.SetupDTFO(ref lpSetup, cbSetup);
        }

        public static bool StartDTFO()
        {
            return NativeImports.StartDTFO();
        }

        public static bool StopDTFO()
        {
            return NativeImports.StopDTFO();
        }

        public static bool SetUnitDTFO(ushort unit, int delta)
        {
            return NativeImports.SetUnitDTFO(unit, delta);
        }

        public static ushort GetUnitDTFO()
        {
            return NativeImports.GetUnitDTFO();
        }

        public static bool LED_SetCurrentDriving(ulong mode, ulong data)
        {
            return NativeImports.LED_SetCurrentDriving(mode, data);
        }

        public static bool MCU_GetVersion(ref ulong lpDateCode)
        {
            return NativeImports.MCU_GetVersion(ref lpDateCode);
        }

        public static bool MCU_Reset()
        {
            return NativeImports.MCU_Reset();
        }

        public static bool IGN_GetState(ref ulong lpState)
        {
            return NativeImports.IGN_GetState(ref lpState);
        }

        public static bool IGN_GetBatteryVoltage(ref double lpVoltage)
        {
            return NativeImports.IGN_GetBatteryVoltage(ref lpVoltage);
        }

        public static bool IGN_GetSetting(ref IGN_SETTING lpSetting, ulong cbSetting)
        {
            return NativeImports.IGN_GetSetting(ref lpSetting, cbSetting);
        }

        public static bool CAN_RegisterReceived(ulong idx, CAN_RegisterReceivedHandler pfnHandler)
        {
            return NativeImports.CAN_RegisterReceived(idx, pfnHandler);
        }

        public static bool CAN_Setup(ulong idx, ref CAN_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.CAN_Setup(idx, ref lpSetup, cbSetup);
        }

        public static bool CAN_Start(ulong idx)
        {
            return NativeImports.CAN_Start(idx);
        }

        public static bool CAN_Stop(ulong idx)
        {
            return NativeImports.CAN_Stop(idx);
        }

        public static bool CAN_Send(ulong idx, ref CAN_MSG lpMsg, ulong cbMsg)
        {
            return NativeImports.CAN_Send(idx, ref lpMsg, cbMsg);
        }

        public static bool PWM_ClockSet(ulong idx, ulong divClock)
        {
            return NativeImports.PWM_ClockSet(idx, divClock);
        }

        public static bool PWM_RegisterStatus(PWM_RegisterStatusHandler pfnHandler)
        {
            return NativeImports.PWM_RegisterStatus(pfnHandler);
        }

        public static bool PWM_GenSetup(ulong genBits, ref PWM_GEN_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.PWM_GenSetup(genBits, ref lpSetup, cbSetup);
        }

        public static bool PWM_GenPeriod(ulong genBits, ulong period)
        {
            return NativeImports.PWM_GenPeriod(genBits, period);
        }

        public static bool PWM_PulseWidth(ulong pinBits, ulong width)
        {
            return NativeImports.PWM_PulseWidth(pinBits, width);
        }

        public static bool PWM_PulseInvert(ulong pinBits)
        {
            return NativeImports.PWM_PulseInvert(pinBits);
        }

        public static bool PWM_Start(ulong pinBits)
        {
            return NativeImports.PWM_Start(pinBits);
        }

        public static bool PWM_Stop(ulong pinBits)
        {
            return NativeImports.PWM_Stop(pinBits);
        }

        public static bool PWM_SyncTimeBase(ulong genBits)
        {
            return NativeImports.PWM_SyncTimeBase(genBits);
        }

        public static bool PWM_SyncUpdate(ulong genBits)
        {
            return NativeImports.PWM_SyncUpdate(genBits);
        }

        public static bool ADC_Stop(ulong idx)
        {
            return NativeImports.ADC_Stop(idx);
        }

        public static bool ADC_Start(ulong idx)
        {
            return NativeImports.ADC_Start(idx);
        }

        public static bool ADC_GetData(ulong idx, ref double lpData)
        {
            return NativeImports.ADC_GetData(idx, ref lpData);
        }

        public static bool QEI_Stop(ulong idx)
        {
            return NativeImports.QEI_Stop(idx);
        }

        public static bool QEI_Start(ulong idx)
        {
            return NativeImports.QEI_Start(idx);
        }

        public static bool QEI_Setup(ulong idx, ref QEI_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.QEI_Setup(idx, ref lpSetup, cbSetup);
        }

        public static bool QEI_GetDirection(ulong idx, ref ulong lpDirection)
        {
            return NativeImports.QEI_GetDirection(idx, ref lpDirection);
        }

        public static bool QEI_GetVelocity(ulong idx, ref ulong lpVelocity)
        {
            return NativeImports.QEI_GetVelocity(idx, ref lpVelocity);
        }

        public static bool QEI_GetPosition(ulong idx, ref ulong lpPosition)
        {
            return NativeImports.QEI_GetPosition(idx, ref lpPosition);
        }

        public static bool QEI_SetPosition(ulong idx, ulong position)
        {
            return NativeImports.QEI_SetPosition(idx, position);
        }

        public static byte PCI_GetStatusPoEPort(ulong boardId, ulong port)
        {
            return NativeImports.PCI_GetStatusPoEPort(boardId, port);
        }

        public static bool PCI_DisablePoEPort(ulong boardId, ulong port)
        {
            return NativeImports.PCI_DisablePoEPort(boardId, port);
        }

        public static bool PCI_EnablePoEPort(ulong boardId, ulong port)
        {
            return NativeImports.PCI_EnablePoEPort(boardId, port);
        }

        public static bool DT2_Setup(ref DT2_SETUP lpSetup, ulong cbSetup)
        {
            return NativeImports.DT2_Setup(ref lpSetup, cbSetup);
        }

        public static bool DT2_Start()
        {
            return NativeImports.DT2_Start();
        }

        public static bool DT2_Stop()
        {
            return NativeImports.DT2_Stop();
        }

        public static bool DT2_SetUnit(ulong unit, int delta)
        {
            return NativeImports.DT2_SetUnit(unit, delta);
        }

        public static ushort DT2_GetUnit()
        {
            return NativeImports.DT2_GetUnit();
        }

        public static bool DT2_StPush(ulong mask, ulong value)
        {
            return NativeImports.DT2_StPush(mask, value);
        }

        public static bool DT2_StPull(ref ulong lpValue)
        {
            return NativeImports.DT2_StPull(ref lpValue);
        }

        public static bool DT2_EiRegisterIndexed(DT2_EiRegisterIndexedHandler pfnHandler)
        {
            return NativeImports.DT2_EiRegisterIndexed(pfnHandler);
        }

        public static bool DT2_EiSendResult(ulong idx, ulong value)
        {
            return NativeImports.DT2_EiSendResult(idx, value);
        }
    }
}
