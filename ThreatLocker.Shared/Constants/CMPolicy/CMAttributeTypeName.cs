using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLocker.Shared.Constants.CMPolicy
{
    public class CMAttributeTypeName
    {
        public static readonly CMAttributeTypeName InputText = new CMAttributeTypeName(1, "InputText");
        public static readonly CMAttributeTypeName InputSwitch = new CMAttributeTypeName(2, "InputSwitch");
        public static readonly CMAttributeTypeName InputSlider = new CMAttributeTypeName(3, "InputSlider");
        public static readonly CMAttributeTypeName SelectButton = new CMAttributeTypeName(4, "SelectButton");
        public static readonly CMAttributeTypeName Dropdown = new CMAttributeTypeName(5, "Dropdown");
        public static readonly CMAttributeTypeName Listbox = new CMAttributeTypeName(6, "Listbox");
        public static readonly CMAttributeTypeName MultiSelect = new CMAttributeTypeName(7, "MultiSelect");
        public static readonly CMAttributeTypeName Label = new CMAttributeTypeName(8, "Label");
        public static readonly CMAttributeTypeName CalendarTime = new CMAttributeTypeName(9, "CalendarTime");
        public static readonly CMAttributeTypeName CalendarDate = new CMAttributeTypeName(10, "CalendarDate");
        public static readonly CMAttributeTypeName Image = new CMAttributeTypeName(11, "Image");
        public static readonly CMAttributeTypeName Password = new CMAttributeTypeName(12, "Password");
        public static readonly CMAttributeTypeName InputSwitchGrid = new CMAttributeTypeName(13, "InputSwitchGrid");
        public static readonly CMAttributeTypeName InputTextarea = new CMAttributeTypeName(15, "InputTextarea");
        public static readonly CMAttributeTypeName InputSwitchMessage = new CMAttributeTypeName(16, "InputSwitchMessage");
        public static readonly CMAttributeTypeName Checkbox = new CMAttributeTypeName(17, "Checkbox");
        public static readonly CMAttributeTypeName RadioButton = new CMAttributeTypeName(18, "RadioButton");


        public CMAttributeTypeName(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static readonly CMAttributeTypeName[] All =
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
             InputSwitchMessage,
			 Checkbox,
			 RadioButton
		};

        public static CMAttributeTypeName Find(int id)
        {
            return All.FirstOrDefault(x => x.Id == id);
        }

        public static CMAttributeTypeName FindByName(string name)
        {
            return All.FirstOrDefault(x => x.Name == name);
        }
    }
}
