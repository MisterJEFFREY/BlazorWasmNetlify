using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmNetlify.Components.TestComponent {
    public partial class CmpTestComponent {



        #region Fields
        public string _test_string;
        #endregion (Fields)


        #region Methods
        public void On_Test_String_Changed(string tsValue) {
            var random = new Random();
            string[] RandomString = { "String 0", "String 1", "String 2", "String 3" };
            var string_chosen = random.Next(RandomString.Length);
            _test_string = RandomString[string_chosen];
        }
            

        #endregion (Methods)


        #region Properties
        public string Test_string { get => _test_string; set => On_Test_String_Changed(value); }


        #endregion (Properties)


    }
}
