using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorWasmNetlify.Shared {
    public partial class NavMenu {


        #region Fields
        public int _switch_To;
        #endregion (Fields)


        #region Methods
        public Task On_Switch_To_Changed(int tiValue) {
            _switch_To = tiValue;
            //test_int = tiValue;
            return Test_Int_Changed.InvokeAsync(tiValue);
        }
        #endregion (Methods)


        #region Properties
        public int Switch_To { get => _switch_To; set => On_Switch_To_Changed(value); }

        [Parameter]
        public int Test_Int { get; set; }

        [Parameter]
        public EventCallback<int> Test_Int_Changed { get; set; }
        #endregion (Properties)

    }
}
