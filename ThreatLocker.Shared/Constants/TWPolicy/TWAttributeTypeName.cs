using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants.TWPolicy
{
    public class TWAttributeTypeName
    {
        public static readonly TWAttributeTypeName InputText = new TWAttributeTypeName(1, "InputText");
        public static readonly TWAttributeTypeName InputSwitch = new TWAttributeTypeName(2, "InputSwitch");
        public static readonly TWAttributeTypeName InputSlider = new TWAttributeTypeName(3, "InputSlider");
        public static readonly TWAttributeTypeName SelectButton = new TWAttributeTypeName(4, "SelectButton");
        public static readonly TWAttributeTypeName Dropdown = new TWAttributeTypeName(5, "Dropdown");
        public static readonly TWAttributeTypeName Listbox = new TWAttributeTypeName(6, "Listbox");
        public static readonly TWAttributeTypeName MultiSelect = new TWAttributeTypeName(7, "MultiSelect");
        public static readonly TWAttributeTypeName Label = new TWAttributeTypeName(8, "Label");
        public static readonly TWAttributeTypeName CalendarTime = new TWAttributeTypeName(9, "CalendarTime");
        public static readonly TWAttributeTypeName CalendarDate = new TWAttributeTypeName(10, "CalendarDate");
        public static readonly TWAttributeTypeName Image = new TWAttributeTypeName(11, "Image");
        public static readonly TWAttributeTypeName Password = new TWAttributeTypeName(12, "Password");
        public static readonly TWAttributeTypeName InputSwitchGrid = new TWAttributeTypeName(13, "InputSwitchGrid");
        public static readonly TWAttributeTypeName InputTextarea = new TWAttributeTypeName(15, "InputTextarea");
        public static readonly TWAttributeTypeName InputSwitchMessage = new TWAttributeTypeName(16, "InputSwitchMessage");


        public TWAttributeTypeName(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly TWAttributeTypeName[] All =
       {
            InputText,
            InputSwitch,
            InputSlider,
            SelectButton,
            Dropdown,
            Listbox,
            MultiSelect,
            Label,
            CalendarTime,
            CalendarDate,
            Image,
            Password,
            InputSwitchGrid,
            InputTextarea,
            InputSwitchMessage
       };

        public static TWAttributeTypeName Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static TWAttributeTypeName FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
