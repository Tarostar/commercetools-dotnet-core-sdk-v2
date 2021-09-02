using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Api.Models.CartDiscounts
{
    public enum StackingMode
    {
        [Description("Stacking")]
        Stacking,

        [Description("StopAfterThisDiscount")]
        StopAfterThisDiscount
    }
    public class StackingModeWrapper : IStackingMode
    {
        public string JsonName { get; internal set; }
        public StackingMode? Value { get; internal set; }
    }
    [EnumInterfaceCreator(typeof(IStackingMode), "FindEnum")]
    public interface IStackingMode : IJsonName
    {
        public static IStackingMode Stacking = new StackingModeWrapper
        { Value = StackingMode.Stacking, JsonName = "Stacking" };

        public static IStackingMode StopAfterThisDiscount = new StackingModeWrapper
        { Value = StackingMode.StopAfterThisDiscount, JsonName = "StopAfterThisDiscount" };

        StackingMode? Value { get; }

        static IStackingMode[] Values()
        {
            return new[]
            {
                Stacking ,
                StopAfterThisDiscount
           };
        }
        static IStackingMode FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new StackingModeWrapper() { JsonName = value };
        }
    }
}
