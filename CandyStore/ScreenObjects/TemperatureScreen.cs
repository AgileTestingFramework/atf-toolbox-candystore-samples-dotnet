using atf.toolbox;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace CandyStore.ScreenObjects
{
    public class TemperatureScreen
    {
        private Window _temperature;

        public TemperatureScreen()
        {
            _temperature = ATFHandler.Instance.FormAutomation.ApplicationDriver.GetWindow("Multiconverter");
            ComboBox selectConverter = _temperature.Get<ComboBox>("typeSelect");
            selectConverter.Select("Temperature");
        }

        public void EnterCelsius(decimal celsius)
        {
            _temperature.Get<TextBox>("celsius1").Text = celsius.ToString();
        }

        public void ClickEqual1()
        {
            _temperature.Get<Button>("btnEqual1").Click();
        }

        public decimal FahrenheitText1()
        {
            return decimal.Parse(_temperature.Get<TextBox>("fahrenheit3").Text.ToString());
        }
    }
}
