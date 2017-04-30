using System;
using System.Collections.Generic;
using System.Configuration;

namespace MPKNetworkManager.Configuration
{
    public class CommandsSection : ConfigurationSection
    {
        [ConfigurationProperty("Commands", IsRequired = false, IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(CommandsSectionCollection))]
        public CommandsSectionCollection Command
        {
            get
            {
                return (CommandsSectionCollection)this["Commands"];
            }
            set
            {
                this["Commands"] = value;
            }
        }
    }

    [ConfigurationCollection(typeof(Command))]
    public class CommandsSectionCollection : ConfigurationElementCollection
    {

        internal const string PropertyName = "Command";

        public CommandsSectionCollection()
        {
        }

        protected override string ElementName
        {
            get
            {
                return PropertyName;
            }
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        protected override bool IsElementName(string elementName)
        {
            return elementName.Equals(PropertyName, StringComparison.InvariantCultureIgnoreCase);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new Command();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            //set to whatever Element Property you want to use for a key
            return ((Command)element).value;
        }

        public Command this[int idx]
        {
            get
            {
                return (Command)BaseGet(idx);
            }
        }
    }
}
