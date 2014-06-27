using System;

namespace Ims.Domain
{
    public class UnitMeasure
    {
        public UnitMeasure(byte unitMeasureId, string unitMeasureCode, string unitMeasureName, decimal conversionToBaseMeasure, bool isActive)
        {
            UnitMeasureId = unitMeasureId;
            UnitMeasureCode = unitMeasureCode;
            UnitMeasureName = unitMeasureName;
            ConversionToBaseMeasure = conversionToBaseMeasure;
            IsActive = isActive;
        }
    
        public byte UnitMeasureId { get; set; }
        public string UnitMeasureCode { get; set; }
        public string UnitMeasureName { get; set; }
        public decimal ConversionToBaseMeasure { get; set; }
        public bool IsActive { get; set; }
    }
}