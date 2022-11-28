using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedItemDataFramework;

namespace ExtraItemsEpicLoot
{
    public class ExtraItemInitializer : ExtendedItemDataFramework.BaseExtendedItemComponent
    {
        public ExtraItemInitializer(ExtendedItemData parent) : base(typeof(UniqueItemData).AssemblyQualifiedName, parent)
        {

        }

        public override BaseExtendedItemComponent Clone()
        {
            throw new NotImplementedException();
        }

        public override void Deserialize(string data)
        {
            throw new NotImplementedException();
        }

        public override string Serialize()
        {
            throw new NotImplementedException();
        }
    }
    
}
