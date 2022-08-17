using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalApp
{
    public class AddRecordEventArgs : EventArgs
    {
        public int keyValue { get; private set; }
        public string nameValue { get; private set; }

        public AddRecordEventArgs(int keyValue, string nameValue)
        {
            this.keyValue = keyValue;
            this.nameValue = nameValue ?? throw new ArgumentNullException(nameof(nameValue));
        }
    }
}
