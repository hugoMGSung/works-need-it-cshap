using System;
using System.Collections.Generic;

namespace NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        } 

        public string GetConfig(string item)
        {
            foreach (var iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }
            return "";
        }

        public void DispConfigs()
        {
            foreach (var item in listConfig)
            {
                Console.WriteLine($"{item.GetItem()} : {item.GetValue()}");
            }
        }

        private class ItemValue
        {
            private string item;
            private string value;

            public string GetItem() { return item; }
            public string GetValue() { return value; }

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655.324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.1");
            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("size"));
            config.SetConfig("size", "777.609 KB");

            config.DispConfigs();
        }
    }
}
