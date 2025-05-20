using System.Linq;

namespace ThreatLocker.Shared.Constants
{
    public class MonitorModeDurationType
    {
        public static readonly MonitorModeDurationType ZeroDays = new MonitorModeDurationType(0, "0 Days");
        public static readonly MonitorModeDurationType OneDay = new MonitorModeDurationType(24, "1 Day");
        public static readonly MonitorModeDurationType TwoDays = new MonitorModeDurationType(48, "2 Days");
        public static readonly MonitorModeDurationType ThreeDays = new MonitorModeDurationType(72, "3 Days");
        public static readonly MonitorModeDurationType FourDays = new MonitorModeDurationType(96, "4 Days");
        public static readonly MonitorModeDurationType FiveDays = new MonitorModeDurationType(120, "5 Days");
        public static readonly MonitorModeDurationType SixDays = new MonitorModeDurationType(144, "6 Days");
        public static readonly MonitorModeDurationType SevenDays = new MonitorModeDurationType(168, "7 Days");
        public static readonly MonitorModeDurationType FourteenDays = new MonitorModeDurationType(336, "14 Days");
        public static readonly MonitorModeDurationType TwentyOneDays = new MonitorModeDurationType(504, "21 Days");
        public static readonly MonitorModeDurationType TwentyEightDays = new MonitorModeDurationType(672, "28 Days");
        public static readonly MonitorModeDurationType ThirtyFiveDays = new MonitorModeDurationType(840, "35 Days");
        public static readonly MonitorModeDurationType FortyFiveDays = new MonitorModeDurationType(1080, "45 Days");
        public static readonly MonitorModeDurationType Indefinite = new MonitorModeDurationType(90000, "Indefinite");

        public MonitorModeDurationType(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public int Value { get; set; }
        public string Text { get; set; }

        public static readonly MonitorModeDurationType[] All =
        {
            ZeroDays,
            OneDay,
            TwoDays,
            ThreeDays,
            FourDays,
            FiveDays,
            SixDays,
            SevenDays,
            FourteenDays,
            TwentyOneDays,
            TwentyEightDays,
            ThirtyFiveDays,
            FortyFiveDays,
            Indefinite
        };

        public static MonitorModeDurationType Find(int value)
        {
            return All.FirstOrDefault(x => x.Value == value);
        }

        public static MonitorModeDurationType FindByText(string text)
        {
            return All.FirstOrDefault(x => x.Text == text);
        }

    }
}
