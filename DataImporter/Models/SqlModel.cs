using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataImporter.Models
{
    class SqlModel
    {

        [SkipProperty] public string FileName { get; internal set; }
        [SkipProperty] public string FileTyp { get; set; }
        [SkipProperty] public string Prozessmodul { get; set; }
        [SkipProperty] public string Losnummer { get; set; }
        [SkipProperty] public int Slotnummer { get; set; }
        [SkipProperty] public string ProcesID { get; set; }
        [SkipProperty] public DateTime DateAndTime { get; set; }
        [SkipProperty] public string WaferId { get; internal set; }
        [SkipProperty] public string Recipe { get; internal set; }
        [SkipProperty] public string MachineId { get; internal set; }
        [SkipProperty] public string Pcma { get; internal set; }
        // Summary data
        [SkipProperty] public double ParameterProc { get; set; }


        #region Calculated Values
        private double chuckDrivePositionCountActual, chuckTempControlDCBiasActVoltage, chuckTempControlSensor, currentStepNumber, dCActualCurrent, dCActualPower, dCActualVoltage, dCHardArcPerRun, dCMicroArcPerRun, dCPowerCorrection, dCShieldLifeCounter, dCTargetLifeCounter, flexiCathMagnetPositionSensor, gasVacuumSystemGas1Sensor, gGasVacuumSystemGas3Sensor, gasVacuumSystemPressureReaderManagerPressure, gasVacuumSystemPressureReaderManagerWiderangeGaugeSensor, matchingSeriesCapacitorPositionSensor, matchingShuntCapacitorPositionSensor, processTimerTimeCorrection, rFBiasDCVoltageSensor, rFBiasLoadPowerCorrection, rFBiasLoadPowerSensor, rFBiasReflectedPowerSensor, waferIDRead, zzEvent;
        private double gasVacuumSystemGas3Sensor;
        public double ChuckDrivePositionCountActual { get { return chuckDrivePositionCountActual; } set { chuckDrivePositionCountActual = value; } }
        public double ChuckTempControlDCBiasActVoltage { get { return chuckTempControlDCBiasActVoltage; } set { chuckTempControlDCBiasActVoltage = value; } }
        public double ChuckTempControlSensor { get { return chuckTempControlSensor; } set { chuckTempControlSensor = value; } }
        public double CurrentStepNumber { get { return currentStepNumber; } set { currentStepNumber = value; } }
        public double DCActualCurrent { get { return dCActualCurrent; } set { dCActualCurrent = value; } }
        public double DCActualPower { get { return dCActualPower; } set { dCActualPower = value; } }
        public double DCActualVoltage { get { return dCActualVoltage; } set { dCActualVoltage = value; } }
        public double DCHardArcPerRun { get { return dCHardArcPerRun; } set { dCHardArcPerRun = value; } }
        public double DCMicroArcPerRun { get { return dCMicroArcPerRun; } set { dCMicroArcPerRun = value; } }
        public double DCPowerCorrection { get { return dCPowerCorrection; } set { dCPowerCorrection = value; } }
        public double DCShieldLifeCounter { get { return dCShieldLifeCounter; } set { dCShieldLifeCounter = value; } }
        public double DCTargetLifeCounter { get { return dCTargetLifeCounter; } set { dCTargetLifeCounter = value; } }
        public double FlexiCathMagnetPositionSensor { get { return flexiCathMagnetPositionSensor; } set { flexiCathMagnetPositionSensor = value; } }
        public double GasVacuumSystemGas1Sensor { get { return gasVacuumSystemGas1Sensor; } set { gasVacuumSystemGas1Sensor = value; } }
        public double GasVacuumSystemGas3Sensor { get { return gasVacuumSystemGas3Sensor; } set { gasVacuumSystemGas3Sensor = value; } }
        public double GGasVacuumSystemGas3Sensor { get { return gGasVacuumSystemGas3Sensor; } set { gGasVacuumSystemGas3Sensor = value; } }
        public double GasVacuumSystemPressureReaderManagerPressure { get { return gasVacuumSystemPressureReaderManagerPressure; } set { gasVacuumSystemPressureReaderManagerPressure = value; } }
        public double GasVacuumSystemPressureReaderManagerWiderangeGaugeSensor { get { return gasVacuumSystemPressureReaderManagerWiderangeGaugeSensor; } set { gasVacuumSystemPressureReaderManagerWiderangeGaugeSensor = value; } }
        public double MatchingSeriesCapacitorPositionSensor { get { return matchingSeriesCapacitorPositionSensor; } set { matchingSeriesCapacitorPositionSensor = value; } }
        public double MatchingShuntCapacitorPositionSensor { get { return matchingShuntCapacitorPositionSensor; } set { matchingShuntCapacitorPositionSensor = value; } }
        public double ProcessTimerTimeCorrection { get { return processTimerTimeCorrection; } set { processTimerTimeCorrection = value; } }
        public double RFBiasDCVoltageSensor { get { return rFBiasDCVoltageSensor; } set { rFBiasDCVoltageSensor = value; } }
        public double RFBiasLoadPowerCorrection { get { return rFBiasLoadPowerCorrection; } set { rFBiasLoadPowerCorrection = value; } }
        public double RFBiasLoadPowerSensor { get { return rFBiasLoadPowerSensor; } set { rFBiasLoadPowerSensor = value; } }
        public double RFBiasReflectedPowerSensor { get { return rFBiasReflectedPowerSensor; } set { rFBiasReflectedPowerSensor = value; } }
        public double WaferIDRead { get { return waferIDRead; } set { waferIDRead = value; } }
        public double ZzEvent { get { return zzEvent; } set { zzEvent = value; } }


        #endregion

        [SkipProperty]
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}\t{19}\t{20}\t{21}\t{22}\t{23}\t{24}\t{25}\t{26}\t" +
                "{27}\t{28}\t{29}\t{30}\t{31}\t{32}\t{33}\t{34}\t{35}\t{36}\t{37}\t", 
                FileName, FileTyp, Prozessmodul, Losnummer, Slotnummer, ProcesID, DateAndTime, WaferId, Recipe, MachineId, Pcma, ParameterProc, ChuckDrivePositionCountActual, ChuckTempControlDCBiasActVoltage, ChuckTempControlSensor, CurrentStepNumber, DCActualCurrent, DCActualPower, DCActualVoltage, DCHardArcPerRun, DCMicroArcPerRun, DCPowerCorrection, DCShieldLifeCounter, DCTargetLifeCounter, FlexiCathMagnetPositionSensor, GasVacuumSystemGas1Sensor, GasVacuumSystemGas3Sensor, GasVacuumSystemPressureReaderManagerPressure, GasVacuumSystemPressureReaderManagerWiderangeGaugeSensor, MatchingSeriesCapacitorPositionSensor, MatchingShuntCapacitorPositionSensor, ProcessTimerTimeCorrection, RFBiasDCVoltageSensor, RFBiasLoadPowerCorrection, RFBiasLoadPowerSensor, RFBiasReflectedPowerSensor, WaferIDRead, zzEvent);
        }

        [SkipProperty]
        public string HeadersForTxtExport ()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}\t{19}\t{20}\t{21}\t{22}\t{23}\t{24}\t{25}\t{26}\t" +
                "{27}\t{28}\t{29}\t{30}\t{31}\t{32}\t{33}\t{34}\t{35}\t{36}\t{37}\t", 
                "FileName",  "FileTyp",  "Prozessmodul",  "Losnummer",  "Slotnummer",  "ProcesID",  "DateAndTime",  "WaferId",  "Recipe",  "MachineId",  "Pcma",  "ParameterProc",  "ChuckDrivePositionCountActual",  "ChuckTempControlDCBiasActVoltage",  "ChuckTempControlSensor",  "CurrentStepNumber",  "DCActualCurrent",  "DCActualPower",  "DCActualVoltage",  "DCHardArcPerRun",  "DCMicroArcPerRun",  "DCPowerCorrection",  "DCShieldLifeCounter",  "DCTargetLifeCounter",  "FlexiCathMagnetPositionSensor",  "GasVacuumSystemGas1Sensor",  "GasVacuumSystemGas3Sensor",  "GasVacuumSystemPressureReaderManagerPressure",  "GasVacuumSystemPressureReaderManagerWiderangeGaugeSensor",  "MatchingSeriesCapacitorPositionSensor",  "MatchingShuntCapacitorPositionSensor",  "ProcessTimerTimeCorrection",  "RFBiasDCVoltageSensor",  "RFBiasLoadPowerCorrection",  "RFBiasLoadPowerSensor",  "RFBiasReflectedPowerSensor",  "WaferIDRead",  "zzEvent");
        }
    }


    public class SkipPropertyAttribute : Attribute
    {
    }



}
